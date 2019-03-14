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
            await  BindGrad();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

     
    }
}
