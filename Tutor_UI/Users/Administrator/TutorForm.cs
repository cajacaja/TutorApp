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
    public partial class TutorForm : Form
    {
        private WebAPIHelper tutorService = new WebAPIHelper("Tutor");
        private WebAPIHelper gradService = new WebAPIHelper("Grad");
        private WebAPIHelper predmetService = new WebAPIHelper("Oblast");

        int pageNummber = 1;
        IPagedList<Tutor_SearchSelect_Result> list;


        public TutorForm()
        {
            InitializeComponent();
            BindForm();
            BindGrad();
            BindKategorije();
        }

        public async Task<IPagedList<Tutor_SearchSelect_Result>> GetPagedListAsync(int pageNummber = 1, int pageSize = 5)
        {



            return await Task.Factory.StartNew(() => {

                var response = tutorService.GetActionResponse("TutorFilter");
                return response.Content.ReadAsAsync<List<Tutor_SearchSelect_Result>>().Result.ToPagedList(pageNummber, pageSize);

            });
        }



        private void BindForm()
        {
            var response = tutorService.GetActionResponse("TutorFilter");
            if (response.IsSuccessStatusCode)
            {
                var tutori = response.Content.ReadAsAsync<List<Tutor_SearchSelect_Result>>().Result;
                TutorGridView.DataSource = tutori;
                TutorGridView.ClearSelection();
            }
        }

        private void BindGrad()
        {
            var response = gradService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                var nesto = response.Content.ReadAsAsync<List<Grad>>().Result;
                nesto.Insert(0, new Grad() { Naziv = "Odaberite grad tutora" });
                GradoviCmb.DataSource = nesto;
                GradoviCmb.DisplayMember = "Naziv";
                GradoviCmb.ValueMember = "GradId";
            }

        }

        private void BindKategorije()
        {
            HttpResponseMessage response = predmetService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                //Promjeni ime u PredmetCmb
                var lstOblasti = response.Content.ReadAsAsync<List<Podkategorija>>().Result;
                lstOblasti.Insert(0, new Podkategorija() { Naziv = "Odaberite oblast" });
                PredmetCmb.DataSource = lstOblasti;
                PredmetCmb.DisplayMember = "Naziv";
                PredmetCmb.ValueMember = "OblastId";
            }
        }

        private void TraziBtn_Click(object sender, EventArgs e)
        {

            string parametar = searchNameInput.Text.Trim() + '/' + GradoviCmb.SelectedValue.ToString() + '/' + PredmetCmb.SelectedValue.ToString();
            if (String.IsNullOrEmpty(searchNameInput.Text))
            {
                parametar = "Empty" + '/' + GradoviCmb.SelectedValue.ToString() + '/' + PredmetCmb.SelectedValue.ToString();
            }
            var response = tutorService.GetActionResponse("TutorFilter", parametar);
            if (response.IsSuccessStatusCode)
            {
                var tutori = response.Content.ReadAsAsync<List<Tutor_SearchSelect_Result>>().Result;
                TutorGridView.DataSource = tutori;
                TutorGridView.ClearSelection();
            }


        }

        private void DodajBtn_Click(object sender, EventArgs e)
        {
            AddTutor addTutor = new AddTutor();
            if (addTutor.ShowDialog() == DialogResult.OK)
            {
                addTutor.Show();
                addTutor.MdiParent = this.MdiParent;
            }

        }

        private void DetaljBtn_Click(object sender, EventArgs e)
        {
            if (TutorGridView.SelectedRows.Count != 0)
            {
                TutorDetalj tutorDetalj = new TutorDetalj(Convert.ToInt32(TutorGridView.SelectedRows[0].Cells[0].Value));
                tutorDetalj.ShowDialog();
                tutorDetalj.MdiParent = this.MdiParent;
            }

        }

        private async void TutorForm_Load(object sender, EventArgs e)
        {
            list = await GetPagedListAsync();
            BackBtn.Enabled = list.HasPreviousPage;
            ForwardBtn.Enabled = list.HasNextPage;
            TutorGridView.DataSource = list.ToList();
            brojListe.Text = string.Format("Page {0}/{1}", pageNummber, list.PageCount);
        }

        private async void BackBtn_Click(object sender, EventArgs e)
        {

            if (list.HasPreviousPage)
            {
                list = await GetPagedListAsync(--pageNummber);
                BackBtn.Enabled = list.HasPreviousPage;
                ForwardBtn.Enabled = list.HasNextPage;
                TutorGridView.DataSource = list.ToList();
                brojListe.Text = string.Format("Page {0}/{1}", pageNummber, list.PageCount);

            }
        }

        private async void ForwardBtn_Click(object sender, EventArgs e)
        {
            if (list.HasNextPage)
            {
                list = await GetPagedListAsync(++pageNummber);
                BackBtn.Enabled = list.HasPreviousPage;
                ForwardBtn.Enabled = list.HasNextPage;
                TutorGridView.DataSource = list.ToList();
                brojListe.Text = string.Format("Page {0}/{1}", pageNummber, list.PageCount);

            }
        }
    }
}
