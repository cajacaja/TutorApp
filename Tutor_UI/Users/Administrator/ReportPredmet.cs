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
    public partial class ReportPredmet : Form
    {
        private WebAPIHelper predmetService = new WebAPIHelper("Podkategorija");
        private WebAPIHelper gradService = new WebAPIHelper("Grad");

        bool flag1 = false;
        bool flag2 = false;
        

        public ReportPredmet()
        {
            InitializeComponent();
            
            string datumOd=Convert.ToDateTime(datumOdDatePicker.MinDate.ToString()).ToString("yyyy-MM-dd");
            string datumDo=Convert.ToDateTime(datumOdDatePicker.MaxDate.ToString()).ToString("yyyy-MM-dd");
            
            string parametars = "0/"+ datumOd+ "/" + datumDo;

            datumOdDatePicker.CustomFormat = " ";
            datumOdDatePicker.Format = DateTimePickerFormat.Custom;
            DatumDoDatePicker.CustomFormat = " ";
            DatumDoDatePicker.Format = DateTimePickerFormat.Custom;
           
            HttpResponseMessage response = predmetService.GetActionResponse("Report",parametars);
            if (response.IsSuccessStatusCode) {

                var list = response.Content.ReadAsAsync<List<Predmet_Report_Result>>().Result;
                Predmet_Report_ResultBindingSource.DataSource = list;
                

                BindGrad();
            }

        }

        private void BindGrad()
        {
            var response = gradService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                var lstGradova = response.Content.ReadAsAsync<List<Grad>>().Result;
                lstGradova.Insert(0, new Grad() {Naziv="Odaberite grad"});
                GradCmb.DataSource = lstGradova;
                GradCmb.DisplayMember = "Naziv";
                GradCmb.ValueMember = "GradId";
                
            }
        }

        private void ReportPredmet_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {

            string datumOd = Convert.ToDateTime(datumOdDatePicker.Value.ToString()).ToString("yyyy-MM-dd");
            string datumDo = Convert.ToDateTime(DatumDoDatePicker.Value.ToString()).ToString("yyyy-MM-dd");

            if (!flag2) {
                datumDo = Convert.ToDateTime(DatumDoDatePicker.MaxDate.ToString()).ToString("yyyy-MM-dd");
            }

            if (!flag1)
            {
               datumOd = Convert.ToDateTime(datumOdDatePicker.MinDate.ToString()).ToString("yyyy-MM-dd");
            }

            string parametars = GradCmb.SelectedValue.ToString()+"/" + datumOd + "/" + datumDo;

            HttpResponseMessage response = predmetService.GetActionResponse("Report", parametars);
            if (response.IsSuccessStatusCode)
            {

                var list = response.Content.ReadAsAsync<List<Predmet_Report_Result>>().Result;
                Predmet_Report_ResultBindingSource.DataSource = list;
                reportViewer1.RefreshReport();
               
            }

            flag1 = false;
            flag2 = false;
        }

        private void datumOdDatePicker_ValueChanged(object sender, EventArgs e)
        {
            datumOdDatePicker.Format = DateTimePickerFormat.Short;
            flag1 = true;
            
        }

        private void DatumDoDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DatumDoDatePicker.Format = DateTimePickerFormat.Short;
            flag2 = true;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            flag1 = false;
            flag2 = false;
            datumOdDatePicker.CustomFormat = " ";
            datumOdDatePicker.Format = DateTimePickerFormat.Custom;
            DatumDoDatePicker.CustomFormat = " ";
            DatumDoDatePicker.Format = DateTimePickerFormat.Custom;
        }
    }
}
