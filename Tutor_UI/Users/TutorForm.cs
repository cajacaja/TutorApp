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

namespace Tutor_UI.Users
{
    public partial class TutorForm : Form
    {
        private WebAPIHelper administratorService = new WebAPIHelper(Global.URI, Global.TutorRoute);
        private WebAPIHelper gradService = new WebAPIHelper(Global.URI, Global.GradRoute);
        private WebAPIHelper predmetService = new WebAPIHelper(Global.URI, Global.OblastRoute);


        public TutorForm()
        {
            InitializeComponent();
            BindForm();
            BindGrad();
            BindKategorije();
        }



        private void BindForm()
        {
            var response = administratorService.GetActionResponse("TutorFilter");
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
            var response = administratorService.GetActionResponse("TutorFilter", parametar);
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
            }

        }

        private void DetaljBtn_Click(object sender, EventArgs e)
        {
            if (TutorGridView.SelectedRows.Count != 0)
            {
                TutorDetalj tutorDetalj = new TutorDetalj(Convert.ToInt32(TutorGridView.SelectedRows[0].Cells[0].Value));
                tutorDetalj.Show();
            }

        }
    }
}
