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
    public partial class EditAdministrator : Form
    {
        private WebAPIHelper administratorService = new WebAPIHelper(Global.URI, Global.AdministratorRoute);
        private Administrator_SelectOne admin;

        public EditAdministrator(int administratorId)
        {
            InitializeComponent();

            HttpResponseMessage response = administratorService.GetResponse(administratorId.ToString());
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                admin = null;
            else if (response.IsSuccessStatusCode)
            {
                admin = response.Content.ReadAsAsync<Administrator_SelectOne>().Result;
                FillForm();
            }
        }

        private void FillForm()
        {
            ImeInput.Text = admin.Ime;
            PrezimeInput.Text = admin.Prezime;
            EmailInput.Text = admin.Email;
            TelefonInput.Text = admin.Telefon;
            KorisnickoImeInput.Text = admin.KorisnickoIme;
        }

        private void SacuvajBtn_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                admin.Ime = ImeInput.Text;
                admin.Prezime = PrezimeInput.Text;
                admin.Telefon = TelefonInput.Text;
                admin.Email = EmailInput.Text;
                admin.KorisnickoIme = KorisnickoImeInput.Text;

                if (LozinkaInput.Text != String.Empty)
                {
                    admin.LozinkaSalt = UIHelper.GenerateSalt();
                    admin.LozinkaHash = UIHelper.GenerateHash(LozinkaInput.Text, admin.LozinkaSalt);
                }

                var response = administratorService.PutResponse(admin.AdministratorId, admin);

                if (response.IsSuccessStatusCode) {
                    MessageBox.Show("Uspjesno editovan je ovaj lik!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Uuuu brate nesto ste ustali pravo!");
                }

            }
        }
    }
}
