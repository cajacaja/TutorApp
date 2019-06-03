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

namespace Tutor_UI.Users
{
    public partial class StudentForm : Form
    {
        WebAPIHelper studentService = new WebAPIHelper("Student");
        WebAPIHelper gradService = new WebAPIHelper("Grad");

        int pageNummber = 1;
        IPagedList<Student_SearchSelect_Result> list;
        public StudentForm()
        {
            InitializeComponent();
            BindGrad();
        }

        public async Task<IPagedList<Student_SearchSelect_Result>> GetPagedListAsync(int pageNummber = 1, int pageSize = 10) {

           

            return await Task.Factory.StartNew(()=>            {
               
                var response = studentService.GetActionResponse("SearchStudent");
                return response.Content.ReadAsAsync<List<Student_SearchSelect_Result>>().Result.ToPagedList(pageNummber, pageSize);

            });
        }

        private void BindGrad()
        {
            var response = gradService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                var lstGradovi = response.Content.ReadAsAsync<List<Grad>>().Result;
                lstGradovi.Insert(0, new Grad() {Naziv="Odaberite grad"});
                GradCmb.DataSource = lstGradovi;
                GradCmb.DisplayMember = "Naziv";
                GradCmb.ValueMember = "GradId";
            }
        }

        private void TraziBtn_Click(object sender, EventArgs e)
        {
            string parametar = searchNameInput.Text.Trim() + '/' + GradCmb.SelectedValue.ToString();
            if (String.IsNullOrEmpty(searchNameInput.Text))
            {
                parametar = "Empty" + '/' + GradCmb.SelectedValue.ToString();
            }
            var response = studentService.GetActionResponse("SearchStudent",parametar);
            if (response.IsSuccessStatusCode) {

                var lstStudent = response.Content.ReadAsAsync<List<Student_SearchSelect_Result>>().Result;
                StudentGridView.DataSource = lstStudent;
                StudentGridView.ClearSelection();
            };
        }

        private void DetaljiBtn_Click(object sender, EventArgs e)
        {
            if (StudentGridView.SelectedRows.Count != 0)
            {
                StudentDetalj tutorDetalj = new StudentDetalj(Convert.ToInt32(StudentGridView.SelectedRows[0].Cells[0].Value));
                tutorDetalj.ShowDialog();
                tutorDetalj.MdiParent = this.MdiParent;
            }
        }

        private async void FowardBtn_Click(object sender, EventArgs e)
        {
            if (list.HasNextPage)
            {
                list = await GetPagedListAsync(++pageNummber);
                BackBtn.Enabled = list.HasPreviousPage;
                FowardBtn.Enabled = list.HasNextPage;
                StudentGridView.DataSource = list.ToList();
                brojListe.Text = string.Format("Page {0}/{1}", pageNummber, list.PageCount);

            }
        }

        private async void StudentForm_Load(object sender, EventArgs e)
        {
            list = await GetPagedListAsync();
            BackBtn.Enabled = list.HasPreviousPage;
            FowardBtn.Enabled = list.HasNextPage;
            StudentGridView.DataSource = list.ToList();
            brojListe.Text = string.Format("Page {0}/{1}", pageNummber, list.PageCount);

        }

        private async void BackBtn_Click(object sender, EventArgs e)
        {
            if (list.HasPreviousPage)
            {
                list = await GetPagedListAsync(--pageNummber);
                BackBtn.Enabled = list.HasPreviousPage;
                FowardBtn.Enabled = list.HasNextPage;
                StudentGridView.DataSource = list.ToList();
                brojListe.Text = string.Format("Page {0}/{1}", pageNummber, list.PageCount);

            }
        }
    }
}
