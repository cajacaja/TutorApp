using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutor_API.Models;
using Tutor_UI.Util;

namespace Tutor_UI.Users
{
    public partial class AddTutor : Form
    {
        private WebAPIHelper spolService = new WebAPIHelper(Global.URI, Global.SpolRoute);
        private WebAPIHelper gradService = new WebAPIHelper(Global.URI, Global.GradRoute);
        private WebAPIHelper radnostanjeService = new WebAPIHelper(Global.URI, Global.RadnoStanjeRoute);
        private WebAPIHelper predmetService = new WebAPIHelper(Global.URI, Global.PredmetiRoute);
        private WebAPIHelper tipStudentaService = new WebAPIHelper(Global.URI, Global.TipStudentaRoute);
        private WebAPIHelper titulaService = new WebAPIHelper(Global.URI, Global.TutorTitulaRoute);

        private byte[] Slika1;
        private byte[] Slika2;

        public AddTutor()
        {
           InitializeComponent();
        }

        

        private async Task BindGrad()
        {
            HttpResponseMessage response = await Task.Run(()=> gradService.GetResponse());
            if (response.IsSuccessStatusCode)
            {
                var nesto= response.Content.ReadAsAsync<List<Grad>>().Result;
                GradCmb.DataSource = nesto.ToList();
                GradCmb.DisplayMember = "Naziv";
                GradCmb.ValueMember = "GradId";
            }
        }

        private async Task BindSpol()
        {
            HttpResponseMessage response = await Task.Run(() => spolService.GetResponse()); 
            if (response.IsSuccessStatusCode)
            {
                SpolCmb.DataSource = response.Content.ReadAsAsync<List<Spol>>().Result;
                SpolCmb.DisplayMember = "Naziv";
                SpolCmb.ValueMember = "SpolId";
            }
        }

        private async void AddTutor_Load(object sender, EventArgs e)
        {
            BindSpol();
            BindZaposlenost();
            BindPredmet();
            BindObim();
            BindTitula();

            await BindGrad();
            
        }

        private async Task BindObim()
        {
            HttpResponseMessage response = await Task.Run(() => tipStudentaService.GetResponse());
            if (response.IsSuccessStatusCode)
            {
                
                ObimListBox.DataSource = response.Content.ReadAsAsync<List<TipStudenta>>().Result;
                ObimListBox.DisplayMember = "Naziv";
                ObimListBox.ClearSelected();
            }
        }

        private async Task BindPredmet()
        {
            HttpResponseMessage response = await Task.Run(() => predmetService.GetResponse());
            if (response.IsSuccessStatusCode)
            {
                //Promjeni ime u PredmetCmb
                PredmetCmb.DataSource = response.Content.ReadAsAsync<List<Podkategorija>>().Result;
                PredmetCmb.DisplayMember = "Naziv";
                PredmetCmb.ValueMember = "PodkategorijaId";
            }
        }

        private async Task BindTitula()
        {
            HttpResponseMessage response = await Task.Run(() => titulaService.GetResponse());
            if (response.IsSuccessStatusCode)
            {
                //Promjeni ime u PredmetCmb
                TitulaCmb.DataSource = response.Content.ReadAsAsync<List<TutorTitula>>().Result;
                TitulaCmb.DisplayMember = "Naziv";
                TitulaCmb.ValueMember = "TutorTitulaId";
            }
        }

        private async Task BindZaposlenost()
        {
            HttpResponseMessage response = await Task.Run(() => radnostanjeService.GetResponse());
            if (response.IsSuccessStatusCode)
            {
                //Promjeni ime u PredmetCmb
                ZaposlenostiCmb.DataSource = response.Content.ReadAsAsync<List<RadnoStanje>>().Result;
                ZaposlenostiCmb.DisplayMember = "Naziv";
                ZaposlenostiCmb.ValueMember = "RadnoStanjeId";
            }
        }

        private void SnimiBtn_Click(object sender, EventArgs e)
        {
            Tutor noviTutor = new Tutor() {
                Ime = ImeInput.Text,
                Prezime = PrezimeInput.Text,
                Telefon = TelefonInput.Text,
                NazivUstanove=NazivObjektaInput.Text,
                SpolId = (int)SpolCmb.SelectedValue,
                Adresa = AdresaInput.Text,
                Email = EmailInput.Text,
                GradId = (int)GradCmb.SelectedValue,
                RadnoStanjeId = (int)ZaposlenostiCmb.SelectedValue,
                TutorTitulaId = (int)TitulaCmb.SelectedValue,
                PodKategorijaId = (int)PredmetCmb.SelectedValue,
                TipStudenta = ObimListBox.CheckedItems.Cast<TipStudenta>().ToList(),
                KorisnickoIme=KorisnickoImeInput.Text,
                CijenaCasa=(double)CijenaInput.Value,
                DatumRodjenja=DatumRodjenjaDP.Value,
                LozinkaSalt=UIHelper.GenerateSalt()
            };
            noviTutor.LozinkaHash = UIHelper.GenerateHash(noviTutor.LozinkaSalt, LozinkaInput.Text);
        }

        private void SlikaBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                SlikaTutorInput.Text = openFileDialog1.FileName;

                Image orignalImage = Image.FromFile(openFileDialog1.FileName);
                MemoryStream ms = new MemoryStream();
                orignalImage.Save(ms, ImageFormat.Jpeg);

                int resizedImageWidth =Convert.ToInt32(ConfigurationManager.AppSettings["resizedImageWidth"]);
                int resizedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImageHeight"]);
                int cropedImageWidth = Convert.ToInt32(ConfigurationManager.AppSettings["cropedImageWidth"]);
                int cropedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["cropedImageHeight"]);

                if (orignalImage.Width > resizedImageWidth)
                {
                    Image resizedImage = UIHelper.ResizeImage(orignalImage, new Size(resizedImageWidth, resizedImageHeight));
                    Image cropedImage = resizedImage;
                    resizedImage.Save(ms, ImageFormat.Jpeg);
                    Slika1 = ms.ToArray();

                    if (resizedImageWidth>=cropedImageWidth && resizedImageHeight>=cropedImageHeight)
                    {
                        int croppedXPosition = (resizedImageWidth - cropedImageWidth) / 2;
                        int croppedYPosition = 20;

                        cropedImage = UIHelper.CropImage(resizedImage, new Rectangle(croppedXPosition, croppedYPosition, 
                                                        cropedImageWidth - croppedXPosition, 
                                                        cropedImageHeight - croppedYPosition));

                        ms = new MemoryStream();
                        cropedImage.Save(ms, ImageFormat.Jpeg);
                        Slika2 = ms.ToArray();

                        pictureBox.Image = cropedImage;
                    }

                }
            }
        }
    }
}
