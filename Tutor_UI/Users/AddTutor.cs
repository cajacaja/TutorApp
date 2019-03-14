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
    public partial class AddTutor : Form
    {
        private WebAPIHelper spolService = new WebAPIHelper(Global.URI, Global.SpolRoute);
        private WebAPIHelper gradService = new WebAPIHelper(Global.URI, Global.GradRoute);
        private WebAPIHelper radnostanjeService = new WebAPIHelper(Global.URI, Global.RadnoStanjeRoute);
        private WebAPIHelper predmetService = new WebAPIHelper(Global.URI, Global.PredmetiRoute);
        private WebAPIHelper tipStudentaService = new WebAPIHelper(Global.URI, Global.TipStudentaRoute);
        private WebAPIHelper titulaService = new WebAPIHelper(Global.URI, Global.TutorTitulaRoute);


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

            await  BindGrad();
            
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
                PredmetInput.DataSource = response.Content.ReadAsAsync<List<Podkategorija>>().Result;
                PredmetInput.DisplayMember = "Naziv";
                PredmetInput.ValueMember = "PodkategorijaId";
            }
        }

        private async Task BindTitula()
        {
            HttpResponseMessage response = await Task.Run(() => titulaService.GetResponse());
            if (response.IsSuccessStatusCode)
            {
                //Promjeni ime u PredmetCmb
                TitulaInput.DataSource = response.Content.ReadAsAsync<List<TutorTitula>>().Result;
                TitulaInput.DisplayMember = "Naziv";
                TitulaInput.ValueMember = "TutorTitulaId";
            }
        }

        private async Task BindZaposlenost()
        {
            HttpResponseMessage response = await Task.Run(() => radnostanjeService.GetResponse());
            if (response.IsSuccessStatusCode)
            {
                //Promjeni ime u PredmetCmb
                ZaposlenostiInput.DataSource = response.Content.ReadAsAsync<List<RadnoStanje>>().Result;
                ZaposlenostiInput.DisplayMember = "Naziv";
                ZaposlenostiInput.ValueMember = "RadnoStanjeId";
            }
        }
    }
}
