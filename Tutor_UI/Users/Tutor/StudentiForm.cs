using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class StudentiForm : Form
    {
        private WebAPIHelper tutorService = new WebAPIHelper("Tutor");

        private int tutorId = Global.prijavljeniTutor.TutorId;

        int pageNummber = 1;
        IPagedList<Tutor_SelectTutorStudents_Result> list;

        public async Task<IPagedList<Tutor_SelectTutorStudents_Result>> GetPagedListAsync(int pageNummber = 1, int pageSize = 10)
        {



            return await Task.Factory.StartNew(() => {

                HttpResponseMessage response = tutorService.GetActionResponse("SelectStudents", tutorId.ToString());
                return response.Content.ReadAsAsync<List<Tutor_SelectTutorStudents_Result>>().Result.ToPagedList(pageNummber, pageSize);

            });
        }

        public StudentiForm()
        {
            InitializeComponent();

            BindGrid(tutorId);
        }

        private async void BindGrid(int tutorId)
        {
            Cursor = Cursors.WaitCursor;
            BackBtn.Enabled = false;
            FowardBtn.Enabled = false;           
            list = await GetPagedListAsync();
            studentiGridView.DataSource = list.ToList();
            BackBtn.Enabled = list.HasPreviousPage;
            FowardBtn.Enabled = list.HasNextPage;
            brojListe.Text = string.Format("{0}/{1}", pageNummber, list.PageCount);
            Cursor = Cursors.Arrow;
            
        }

        private async void BackBtn_Click(object sender, EventArgs e)
        {
            if (list.HasPreviousPage)
            {
                Cursor = Cursors.WaitCursor;
                BackBtn.Enabled = false;
                FowardBtn.Enabled = false;
                list = await GetPagedListAsync(--pageNummber);
                studentiGridView.DataSource = list.ToList();
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
                studentiGridView.DataSource = list.ToList();
                BackBtn.Enabled = list.HasPreviousPage;
                FowardBtn.Enabled = list.HasNextPage;
                brojListe.Text = string.Format("{0}/{1}", pageNummber, list.PageCount);
                Cursor = Cursors.Arrow;

            }
        }

        private void PrijaviBtn_Click(object sender, EventArgs e)
        {
            if (studentiGridView.SelectedRows.Count != 0)
            {
                int studentId = Convert.ToInt32(studentiGridView.SelectedRows[0].Cells[0].Value);
                PrijavaForm prijava = new PrijavaForm(studentId);
                prijava.ShowDialog();
                prijava.MdiParent = this.MdiParent;
            }
        }

        private void PregledBtn_Click(object sender, EventArgs e)
        {
            if (studentiGridView.SelectedRows.Count != 0)
            {
                int studentId = Convert.ToInt32(studentiGridView.SelectedRows[0].Cells[0].Value);
                StudentDetalj student = new StudentDetalj(studentId);
                student.ShowDialog();
                student.MdiParent = this.MdiParent;
            }
           
        }
    }
}
