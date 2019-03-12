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
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace Tutor_UI.Users
{
    public partial class AdministratorAdd : Form
    {
        private WebAPIHelper administratorService = new WebAPIHelper(Global.URI, Global.AdministratorRoute);

        public AdministratorAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void SacuvajBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
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
                    MessageBox.Show("Error:" + response.StatusCode + " Message:" + response.ReasonPhrase);
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

        private void LozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Provjera(LozinkaInput);//Treba skontat nacin da budem vise specifican sa porukama!
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


