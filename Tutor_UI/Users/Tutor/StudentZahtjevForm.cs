using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutor_API.Models;
using Tutor_UI.Util;

namespace Tutor_UI.Users.Tutor
{
    public partial class StudentZahtjevForm : Form
    {
        private WebAPIHelper zahtjevService = new WebAPIHelper("Zahtjev");
        private WebAPIHelper ocjenaService = new WebAPIHelper("OcjenaStudent");
        
        private int  ZahtjevId=0;

        public StudentZahtjevForm(int zahtjevId)
        {
            InitializeComponent();
            ZahtjevId = zahtjevId;


            BindForm(zahtjevId);
        }

        private void BindForm(int zahtjevId)
        {
            HttpResponseMessage response = zahtjevService.GetActionResponse("ZahtjevDetail", zahtjevId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var zahtjev = response.Content.ReadAsAsync<Zahtjev_SelectDetail_Result>().Result;

                var ms = new MemoryStream(zahtjev.StudentskaSlika);
                Image slika = Image.FromStream(ms);
                PripremiSliku(slika);
               
                ImePrezimeInput.Text = zahtjev.ImePrezime;
                tipInput.Text = zahtjev.TipStudenta;
                godineInput.Text = zahtjev.Godine.ToString();
                OcjenaInput.Text = zahtjev.Ocjena.ToString();
                DatumSlanjaInput.Text = zahtjev.DatumSlanja.ToShortDateString();
                BrojCasovaInput.Text = zahtjev.BrojCasova.ToString();
                DatumOdInput.Text = zahtjev.DatumOd.ToShortDateString();
                DatumDoInput.Text = zahtjev.DatumDo.ToShortDateString();
                VrijemOd.Text = zahtjev.VrijemeOd.ToString().Substring(0,5);
                VrijemeDo.Text = zahtjev.VrijemeDo.ToString().Substring(0,5);

                BindOcjene(zahtjev.StudentId);


            }
        }

        private void PripremiSliku(Image orignalImage)
        {
           
           

            int resizedImageWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImageWidth"]);
            int resizedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImageHeight"]);
            int cropedImageWidth = Convert.ToInt32(ConfigurationManager.AppSettings["cropedImageWidth"]);
            int cropedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["cropedImageHeight"]);

            if (orignalImage.Width > resizedImageWidth)
            {
                Image resizedImage = UIHelper.ResizeImage(orignalImage, new Size(resizedImageWidth, resizedImageHeight));
                studentPictureBox.Image = orignalImage;
                Image cropedImage = resizedImage;
                

                if (resizedImageWidth >= cropedImageWidth && resizedImageHeight >= cropedImageHeight)
                {
                    int croppedXPosition = (resizedImageWidth - cropedImageWidth) / 2;
                    int croppedYPosition = 20;

                    cropedImage = UIHelper.CropImage(resizedImage, new Rectangle(croppedXPosition, croppedYPosition,
                                                    cropedImageWidth - croppedXPosition,
                                                    cropedImageHeight - croppedYPosition));



                    studentPictureBox.Image = cropedImage;
                }

            }
            else
            {
                studentPictureBox.Image = orignalImage;
            }
        }

        private void BindOcjene(int studentId)
        {
            HttpResponseMessage response = ocjenaService.GetActionResponse("GetOcjene", studentId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var lstOcjene = response.Content.ReadAsAsync<List<OcjenaStudent_SelectComments_Result>>().Result;
                OcjeneStudentGridView.DataSource = lstOcjene;
                OcjeneStudentGridView.ClearSelection();
            }
        }

        private void PrihvatiBtn_Click(object sender, EventArgs e)
        {
            var response = zahtjevService.GetResponse(ZahtjevId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var zahtjev = response.Content.ReadAsAsync<Zahtjev>().Result;
                zahtjev.Prihvaceno = true;

                var response2 = zahtjevService.PutResponse(ZahtjevId, zahtjev);
                if (response2.IsSuccessStatusCode)
                {
                    OdrediTermin termini = new OdrediTermin(ZahtjevId);
                    termini.ShowDialog();
                    termini.MdiParent = this.MdiParent;
                    PrihvatiBtn.Enabled = false;
                }
            }
        }
    }
}
