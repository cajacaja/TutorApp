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
using PagedList;

namespace Tutor_UI.Users.Tutor
{
    public partial class StudentDetalj : Form
    {
        private WebAPIHelper studentService = new WebAPIHelper("Student");
        private WebAPIHelper ocjenaService = new WebAPIHelper("OcjenaStudent");

        int pageNummber = 1;
        int studentId = 0;
        int tutorId = Global.prijavljeniTutor.TutorId;
        IPagedList<OcjenaStudent_SelectComments_Result> list;

        public async Task<IPagedList<OcjenaStudent_SelectComments_Result>> GetPagedListAsync(int pageNummber = 1, int pageSize = 10)
        {



            return await Task.Factory.StartNew(() => {

                HttpResponseMessage response = ocjenaService.GetActionResponse("GetOcjene", studentId.ToString());
                return response.Content.ReadAsAsync<List<OcjenaStudent_SelectComments_Result>>().Result.ToPagedList(pageNummber, pageSize);

            });
        }

        public StudentDetalj(int idStudenta)
        {
            studentId = idStudenta;
            InitializeComponent();
            BindForm(studentId);
            isGraded(tutorId, studentId);
            BindOcjene();
        }

        private void isGraded(int tutorId, int studentId)
        {
            string parametar = tutorId.ToString() + "/" + studentId.ToString();
            var response = ocjenaService.GetActionResponse("checkTutor", parametar);
            if (response.IsSuccessStatusCode)
            {
                OcjeniBtn.Visible = false;
            }
            else
            {
                OcjeniBtn.Visible = true;
            }
        }

        private async void BindOcjene()
        {
            Cursor = Cursors.WaitCursor;
            BackBtn.Enabled = false;
            FowardBtn.Enabled = false;            
            list = await GetPagedListAsync();
            ocjeneGridView.DataSource = list.ToList();
            BackBtn.Enabled = list.HasPreviousPage;
            FowardBtn.Enabled = list.HasNextPage;
            brojListe.Text = string.Format("{0}/{1}", pageNummber, list.PageCount);
            Cursor = Cursors.Arrow;
            
        }

        private void BindForm(int id)
        {
            HttpResponseMessage response = studentService.GetActionResponse("StudentDetails", id.ToString());
            if (response.IsSuccessStatusCode)
            {
                var student = response.Content.ReadAsAsync<Student_Details_Result>().Result;
                ImeInput.Text = student.Ime;
                PrezimeInput.Text = student.Prezime;
                SpolInput.Text = student.Spol;
                DatumRodjenjaInput.Text = student.DatumRodjenja.ToShortDateString();
               
                KorisnickoImeInput.Text = student.KorisnickoIme;
                DatumDodavanjaInput.Text = student.DatumDodavanja.ToShortDateString();
                TipStudentaInput.Text = student.TipStudenta;
                OcjenaInput.Text = student.OcjenaStudenta.ToString();
               


                var ms = new MemoryStream(student.StudentskaSlika);
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

        private async void BackBtn_Click(object sender, EventArgs e)
        {
            if (list.HasPreviousPage)
            {
                Cursor = Cursors.WaitCursor;
                BackBtn.Enabled = false;
                FowardBtn.Enabled = false;
                list = await GetPagedListAsync(--pageNummber);
                ocjeneGridView.DataSource = list.ToList();
                BackBtn.Enabled = list.HasPreviousPage;
                FowardBtn.Enabled = list.HasNextPage;
                brojListe.Text = string.Format("{0}/{1}", pageNummber, list.PageCount);
                Cursor = Cursors.Arrow;
            }
        }

        private async void FowardBtn_Click(object sender, EventArgs e)
        {
            if (list.HasNextPage)
            {
                Cursor = Cursors.WaitCursor;
                BackBtn.Enabled = false;
                FowardBtn.Enabled = false;
                list = await GetPagedListAsync(++pageNummber);
                ocjeneGridView.DataSource = list.ToList();
                BackBtn.Enabled = list.HasPreviousPage;
                FowardBtn.Enabled = list.HasNextPage;
                brojListe.Text = string.Format("{0}/{1}", pageNummber, list.PageCount);
                Cursor = Cursors.Arrow;

            }
        }

        private void OcjeniBtn_Click(object sender, EventArgs e)
        {
            OcjeniStudentForm ocjena = new OcjeniStudentForm(studentId);
            ocjena.ShowDialog();
            ocjena.MdiParent = this.MdiParent;
            OcjeniBtn.Enabled = false;
        }

        private void OcjeniBtn_Enter(object sender, EventArgs e)
        {
            isGraded(tutorId, studentId);
        }

        private void StudentDetalj_Enter(object sender, EventArgs e)
        {
            BindForm(studentId);
            isGraded(tutorId, studentId);
            BindOcjene();
        }
    }


}
