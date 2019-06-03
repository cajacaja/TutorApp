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
    public partial class StudentDetalj : Form
    {
        private WebAPIHelper studentService = new WebAPIHelper("Student");
        private WebAPIHelper ocjenaService = new WebAPIHelper("OcjenaStudent");
        private int StudentId;


        public StudentDetalj(int id)
        {
            InitializeComponent();
            StudentId = id;
           
            BindForm(id);
            BindOcjene(id);
            BindPredmeti(id);
            BindUcionice(id);
        }

        private void BindUcionice(int id)
        {
            HttpResponseMessage response = studentService.GetActionResponse("PohadjaneUcionice", id.ToString());
            if (response.IsSuccessStatusCode)
            {
                var lstUcionice = response.Content.ReadAsAsync<List<Student_SelectUcionice_Result>>().Result;
                UcionicaGridView.DataSource = lstUcionice;
                UcionicaGridView.ClearSelection();
            }
        }

        private void BindPredmeti(int id)
        {
            HttpResponseMessage response = studentService.GetActionResponse("PohadjeniPredmeti", id.ToString());
            if (response.IsSuccessStatusCode)
            {
                var lstPredmeti = response.Content.ReadAsAsync<List<Student_PohadajniPredmeti_Result>>().Result;
                PohadjaniGridView.DataSource = lstPredmeti;
                PohadjaniGridView.ClearSelection();
            }
        }

        private void BindOcjene(int id)
        {
            HttpResponseMessage response = ocjenaService.GetActionResponse("GetOcjene",id.ToString());
            if (response.IsSuccessStatusCode)
            {
                var lstOcjene = response.Content.ReadAsAsync<List<OcjenaStudent_SelectComments_Result>>().Result;
                OcjenaTutoraGridView.DataSource = lstOcjene;
                OcjenaTutoraGridView.ClearSelection();
            }
        }

        

        private void StudentDetalj_Load(object sender, EventArgs e)
        {
           
        }

        private void BindForm(int id)
        {
            HttpResponseMessage response = studentService.GetActionResponse("StudentDetails",id.ToString());
            if (response.IsSuccessStatusCode)
            {
                var student = response.Content.ReadAsAsync<Student_Details_Result>().Result;
                ImeInput.Text = student.Ime;
                PrezimeInput.Text = student.Prezime;
                SpolInput.Text = student.Spol;
                DatumRodjenjaInput.Text = student.DatumRodjenja.ToShortDateString();
                EmailInput.Text = student.Email;
                TelefonInput.Text = student.Telefon;
                GradInput.Text = student.Grad;
                AdresaInput.Text = student.Adresa;
                KorisnickoImeInput.Text = student.KorisnickoIme;
                DatumDodavanjaInput.Text = student.DatumDodavanja.ToShortDateString();
                TipStudentaInput.Text = student.TipStudenta;
                OcjenaInput.Text = student.OcjenaStudenta.ToString();
                ProvjeriStatsuKorisnika(StudentId);
               

                var ms= new MemoryStream(student.StudentskaSlika);
                Image originalImage = Image.FromStream(ms);
               

                int resizedImageWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImageWidth"]);
                int resizedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImageHeight"]);
                int cropedImageWidth = Convert.ToInt32(ConfigurationManager.AppSettings["cropedImageWidth"]);
                int cropedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["cropedImageHeight"]);
                if (originalImage.Width > resizedImageWidth)
                {
                    Image resizedImage = UIHelper.ResizeImage(originalImage, new Size(resizedImageWidth, resizedImageHeight));                   
                    studentSlikaPictureBox.Image = resizedImage;
                }
            }
        }

        private void BanBtn_Click(object sender, EventArgs e)
        {
            PromjeniStatus();           
        }
        private void ProvjeriStatsuKorisnika(int id)
        {
            var response = studentService.GetResponse(id.ToString());
            if (response.IsSuccessStatusCode) {

                var student = response.Content.ReadAsAsync<Student>().Result;

                if (student.StatusKorisnickoRacunaId == 3)
                {
                    BanBtn.Visible = false;
                    UnbanBtn.Visible = true;
                }
                else
                {
                    BanBtn.Visible = true;
                    UnbanBtn.Visible = false;
                }

            }
           
        }

        private void PromjeniStatus()
        {
            var response = studentService.GetResponse(StudentId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var student = response.Content.ReadAsAsync<Student>().Result;
                if (student.StatusKorisnickoRacunaId != 3)
                {
                    student.StatusKorisnickoRacunaId = 3;
                    var response2 = studentService.PutResponse(StudentId,student);
                    if (response2.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Student banovan!");
                        ProvjeriStatsuKorisnika(StudentId);
                    }
                }
                else
                {
                    student.StatusKorisnickoRacunaId = 1;
                    var response2 = studentService.PutResponse(StudentId, student);
                    if (response2.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Student unbanovan!");
                        ProvjeriStatsuKorisnika(StudentId);
                    }
                }


            }

        }

        private void UnbanBtn_Click(object sender, EventArgs e)
        {
            PromjeniStatus();
        }

       
    }
}
