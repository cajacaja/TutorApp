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
    public partial class AdministratorForm : Form
    {
        private WebAPIHelper administratorService = new WebAPIHelper(Global.URI, Global.AdministratorRoute);

        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void DodajBtn_Click(object sender, EventArgs e)
        {
            var administratorDodajForm = new AdministratorAdd();
            if (administratorDodajForm.ShowDialog()==DialogResult.OK)
            {
                administratorDodajForm.Show();
                BindGrid();
            }
           
        }

        private void BindGrid()
        {
            HttpResponseMessage response = administratorService.GetActionResponse("SearchByName",searchInput.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                var administratori = response.Content.ReadAsAsync<List<Administrator_NameSelect>>().Result;
                administratorGrid.DataSource = administratori;
                administratorGrid.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code:" + response.StatusCode + " Messagee-" + response.ReasonPhrase);
            }
        }

        private void TraziBtn_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var editForm = new EditAdministrator(Convert.ToInt32(administratorGrid.SelectedRows[0].Cells[0].Value));
            editForm.Show();
            BindGrid();
           
        }
    }
}
