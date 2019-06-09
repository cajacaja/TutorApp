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
        private WebAPIHelper administratorService = new WebAPIHelper("Administrator");
        private WebAPIHelper tutorService = new WebAPIHelper("Tutor");



        public LoginForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            HttpResponseMessage response = tutorService.GetActionResponse("TutorCount", "1/1/3");
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

                    Global.prijavljeniAdministrator = provjeriAdministrator.Content.ReadAsAsync<Tutor_API.Models.Administrator>().Result;
                    Users.MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();


                }
                else if (provjeraTutor.IsSuccessStatusCode)
                {

                    Global.prijavljeniTutor = provjeraTutor.Content.ReadAsAsync<Tutor_API.Models.Tutor>().Result;
                    if (Global.prijavljeniTutor.StatusKorisnickoRacunaId != 3)
                    {
                        Users.Tutor.MainForm mainForm = new Tutor.MainForm();
                        mainForm.ShowDialog();
                    }
                    else
                    {
                        Global.prijavljeniTutor = null;
                        MessageBox.Show("Vas korisnicki racun je banovan.Za vise informacija konaktirajte administraciju.");
                    }

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
