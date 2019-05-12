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
    public partial class LoginForm : Form
    {
        private WebAPIHelper administratorService = new WebAPIHelper(Global.URI, Global.AdministratorRoute);
        private WebAPIHelper tutorService = new WebAPIHelper(Global.URI, Global.TutorRoute);

        public LoginForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void PrijavaBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var parametar = korisnickoImeInput.Text + '/' + lozinkaInput.Text;
                HttpResponseMessage provjeriAdministrator = administratorService.GetActionResponse("LoginCheck", parametar);
                HttpResponseMessage provjeraTutor = tutorService.GetActionResponse("LoginCheck", parametar);
                if (provjeriAdministrator.IsSuccessStatusCode)
                {
                    Users.MainForm mainForm = new MainForm();
                    Global.prijavljeniAdministrator = provjeriAdministrator.Content.ReadAsAsync<Administrator>().Result;
                    mainForm.Show();
                    
                }
                else if (provjeraTutor.IsSuccessStatusCode)
                {
                    Users.Tutor.MainForm mainForm = new Tutor.MainForm();
                    Global.prijavljeniTutor = provjeraTutor.Content.ReadAsAsync<Tutor_API.Models.Tutor>().Result;
                    mainForm.Show();
                    
                }
                else
                {
                    MessageBox.Show("Pogresno korisnicko ime ili lozinka.");
                }

            }
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

        private void korisnickoImeInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Provjera(korisnickoImeInput);
        }

        private void lozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Provjera(lozinkaInput);
        }
    }
}
