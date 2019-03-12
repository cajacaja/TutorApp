using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class AdministratorAdd : Form
    {
        private WebAPIHelper administratorService = new WebAPIHelper(Global.URI, Global.AdministratorRoute);

        public AdministratorAdd()
        {
            InitializeComponent();
        }

        private void SacuvajBtn_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator();

            admin.Ime = ImeInput.Text;
            admin.Prezime = PrezimeInput.Text;
            admin.Email = EmailInput.Text;
            admin.Telefon = PrezimeInput.Text;
            admin.KoriniskoIme = KorisnickoImeInput.Text;
            admin.LozinkaSalt = UIHelper.GenerateSalt();
            admin.LozinkaHash = UIHelper.GenerateHash(admin.LozinkaSalt, LozinkaInput.Text);

            HttpResponseMessage response = administratorService.PostResponse(admin);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Administrator dodan!");
            }
            else
            {
                MessageBox.Show("Error:"+response.StatusCode+" Message:"+response.ReasonPhrase);
            }

        }
    }
}
