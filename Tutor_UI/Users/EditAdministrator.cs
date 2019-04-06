using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
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
            this.AutoValidate = AutoValidate.Disable;

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
            if (admin != null && this.ValidateChildren())
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

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messeges.AdministratorEdit);
                    this.Close();
                }
                else
                {
                    var errorMessage = Global.ErrorFinder(response.Content.ReadAsStringAsync().Result);

                    if (!String.IsNullOrEmpty(Messeges.ResourceManager.GetString(errorMessage)))
                        errorMessage = Messeges.ResourceManager.GetString(errorMessage);

                    MessageBox.Show(errorMessage);
                }

            }


        }

        private void ImeInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Provjera(ImeInput, Messeges.OnlyLetters_Regex);
        }

        private void PrezimeInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Provjera(PrezimeInput, Messeges.OnlyLetters_Regex);
        }

        private bool Provjera(TextBox text, string regex = "")
        {



            var provjera = Global.TextInputProvjera(text.Text, regex);
            if (!provjera.Item1)
            {
                errorProvider.SetError(text, provjera.Item2);
                return true;
            }
            else
            {
                errorProvider.SetError(text, "");
            }

            return false;
        }

        private void EmailInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Provjera(EmailInput, Messeges.Email_Regex);

        }

        private void KorisnickoImeInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Provjera(KorisnickoImeInput);
        }



        private void TelefonInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.Match(TelefonInput.Text, Messeges.Error_Phone).Success)
            {
                e.Cancel = true;
                errorProvider.SetError(TelefonInput, Messeges.Error_Format);
            }
            else
            {
                errorProvider.SetError(TelefonInput, "");
            }
        }
    }
}
