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
    public partial class ReportTutora : Form
    {

        private WebAPIHelper tutorService = new WebAPIHelper(Global.URI, Global.TutorRoute);
        private WebAPIHelper gradService = new WebAPIHelper(Global.URI, Global.GradRoute);
        private WebAPIHelper oblastService = new WebAPIHelper(Global.URI, Global.OblastRoute);

        bool flag1 = false;
        bool flag2 = false;

        public ReportTutora()
        {
            InitializeComponent();

            string datumOd = Convert.ToDateTime(datumOdDatePicker.MinDate.ToString()).ToString("yyyy-MM-dd");
            string datumDo = Convert.ToDateTime(datumDoDatePicker.MaxDate.ToString()).ToString("yyyy-MM-dd");

            string parametars = "0/0/" + datumOd + "/" + datumDo;

            datumOdDatePicker.CustomFormat = " ";
            datumOdDatePicker.Format = DateTimePickerFormat.Custom;
            datumDoDatePicker.CustomFormat = " ";
            datumDoDatePicker.Format = DateTimePickerFormat.Custom;

            HttpResponseMessage response = tutorService.GetActionResponse("SelectBest", parametars);
            if (response.IsSuccessStatusCode)
            {

                var list = response.Content.ReadAsAsync<List<Tutor_SelectBest_Result>>().Result;
                Tutor_SelectBest_ResultBindingSource.DataSource = list;


                
            }

            BindGrad();
            BindOblast();
        }

        private void BindOblast()
        {
            var response = oblastService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                var lstOblasti = response.Content.ReadAsAsync<List<Oblast>>().Result;
                lstOblasti.Insert(0, new Oblast() { Naziv = "Odaberite oblast" });
                oblastCmb.DataSource = lstOblasti;
                oblastCmb.DisplayMember = "Naziv";
                oblastCmb.ValueMember = "OblastId";

            }
        }

        private void BindGrad()
        {
            var response = gradService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                var lstGradova = response.Content.ReadAsAsync<List<Grad>>().Result;
                lstGradova.Insert(0, new Grad() { Naziv = "Odaberite grad" });
                gradCmb.DataSource = lstGradova;
                gradCmb.DisplayMember = "Naziv";
                gradCmb.ValueMember = "GradId";

            }
        }

        private void ReportTutora_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void izbrisiDatumBtn_Click(object sender, EventArgs e)
        {
            flag1 = false;
            flag2 = false;
            datumOdDatePicker.CustomFormat = " ";
            datumOdDatePicker.Format = DateTimePickerFormat.Custom;
            datumDoDatePicker.CustomFormat = " ";
            datumDoDatePicker.Format = DateTimePickerFormat.Custom;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {

            string datumOd = Convert.ToDateTime(datumOdDatePicker.Value.ToString()).ToString("yyyy-MM-dd");
            string datumDo = Convert.ToDateTime(datumDoDatePicker.Value.ToString()).ToString("yyyy-MM-dd");

            if (!flag2)
            {
                datumDo = Convert.ToDateTime(datumDoDatePicker.MaxDate.ToString()).ToString("yyyy-MM-dd");
            }

            if (!flag1)
            {
                datumOd = Convert.ToDateTime(datumOdDatePicker.MinDate.ToString()).ToString("yyyy-MM-dd");
            }

            string parametars = gradCmb.SelectedValue.ToString() + "/"+oblastCmb.SelectedValue.ToString()+'/' + datumOd + "/" + datumDo;

            HttpResponseMessage response = tutorService.GetActionResponse("SelectBest", parametars);
            if (response.IsSuccessStatusCode)
            {

                var list = response.Content.ReadAsAsync<List<Tutor_SelectBest_Result>>().Result;
                Tutor_SelectBest_ResultBindingSource.DataSource = list;
                this.reportViewer1.RefreshReport();
            }

            flag1 = false;
            flag2 = false;
        }

        private void datumOdDatePicker_ValueChanged(object sender, EventArgs e)
        {
            datumOdDatePicker.Format = DateTimePickerFormat.Short;
            flag1 = true;
        }

        private void datumDoDatePicker_ValueChanged(object sender, EventArgs e)
        {
            datumDoDatePicker.Format = DateTimePickerFormat.Short;
            flag2 = true;
        }
    }
}
