using Newtonsoft.Json;
using PCL_tutor.Model;
using PCL_tutor.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutor_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditPage : ContentPage
	{
        private WebApiHelper gradService = new WebApiHelper("Grad");
        private WebApiHelper tipStudentaService = new WebApiHelper("TipStudenta");
        private WebApiHelper studentService = new WebApiHelper("Student");
        private WebApiHelper korisnickiNalogService = new WebApiHelper("KorisnickiNalog");
        private WebApiHelper kontakInfoService = new WebApiHelper("KontaktInfo");
       


        public EditPage ()
		{
			InitializeComponent ();
            
		}

        protected override  void OnAppearing()
        {
            HttpResponseMessage response =tipStudentaService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                var jasonObject = response.Content.ReadAsStringAsync();
                List<TipStudenta> tipStudenta = JsonConvert.DeserializeObject<List<TipStudenta>>(jasonObject.Result);
                vrstaStudentaPicker.ItemsSource = tipStudenta;
                vrstaStudentaPicker.ItemDisplayBinding = new Binding("Naziv");
                


            }


            response = gradService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                var jasonObject = response.Content.ReadAsStringAsync();
                List<Gradovi> gradovi = JsonConvert.DeserializeObject<List<Gradovi>>(jasonObject.Result);
                gradPicker.ItemsSource = gradovi;
                gradPicker.ItemDisplayBinding = new Binding("Naziv");
               

            }

            emailInput.Text = Global.prijavljeniStudent.Email;
            telefonInput.Text = Global.prijavljeniStudent.Telefon;
            adresaInput.Text = Global.prijavljeniStudent.Adresa;

            base.OnAppearing();
        }

        private void EditBtn_Clicked(object sender, EventArgs e)
        {
            if (Validete())
            {
                if (gradPicker.SelectedItem != null)
                {
                    Global.prijavljeniStudent.GradId = (gradPicker.SelectedItem as Gradovi).GradId;
                }

                if (vrstaStudentaPicker.SelectedItem != null)
                {
                    Global.prijavljeniStudent.TipoviStudentaId = (vrstaStudentaPicker.SelectedItem as TipStudenta).TipoviStudentaId;
                }

                KontaktInfo noviInfo = new KontaktInfo()
                {
                    KontaktInfoId = Global.prijavljeniStudent.KontaktInfoId,
                    Email = emailInput.Text,
                    Telefon = telefonInput.Text,
                    Adresa = adresaInput.Text
                };
                var response = kontakInfoService.PutResponse(noviInfo.KontaktInfoId, noviInfo);
               

                KorisnickiNalog noviNalog = new KorisnickiNalog()
                {
                    KorisnickiNalogId = Global.prijavljeniStudent.KorisnickiNalogId,
                    KorisnickoIme = Global.prijavljeniStudent.KorisnickoIme,
                    LozinkaSalt = Global.prijavljeniStudent.LozinkaSalt
                };

                if (!String.IsNullOrEmpty(lozinkaInput.Text))
                {
                    Global.prijavljeniStudent.LozinkaHash = UIHelper.GenerateHash(noviNalog.LozinkaSalt, lozinkaInput.Text);
                    noviNalog.LozinkaHash = Global.prijavljeniStudent.LozinkaHash;
                    response = korisnickiNalogService.PutResponse(noviNalog.KorisnickiNalogId, noviNalog);

                }


                response = studentService.PutResponse(Global.prijavljeniStudent.StudentId, Global.prijavljeniStudent);
                if (response.IsSuccessStatusCode)
                {
                    this.Navigation.PopAsync();
                }
               



            }
        }

        #region Validacija edit paga
        private bool Validete()
        {
            List<bool> lst = new List<bool>();
            lst.Add(ValidateAdresu());
            lst.Add(ValidateEmail());
            lst.Add(ValidateTelefon());
            lst.Add(ValidatePicker(gradPicker));
            lst.Add(ValidatePicker(vrstaStudentaPicker));

            int broj = lst.Where(x => x.Equals(false)).Count();

            if (broj > 0) return false;

            return true;
        }

        private bool ValidateEmail()
        {
            if (String.IsNullOrEmpty(emailInput.Text))
            {
                emailInput.PlaceholderColor = Color.Red;
                emailInput.Placeholder = "Email ne smije biti prazno";

                return false;
            }
            else if (!Regex.Match(emailInput.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z").Success)
            {
                emailInput.Text = "";
                emailInput.PlaceholderColor = Color.Red;
                emailInput.Placeholder = "Pogresan format email-a";

                return false;
            }

            return true;

        }

        private bool ValidateAdresu()
        {
            if (String.IsNullOrEmpty(adresaInput.Text))
            {
                adresaInput.PlaceholderColor = Color.Red;
                adresaInput.Placeholder = "Polje ne smije biti prazno";

                return false;
            }

            return true;
        }

        private bool ValidateTelefon()
        {
            if (String.IsNullOrEmpty(telefonInput.Text))
            {
                telefonInput.PlaceholderColor = Color.Red;
                telefonInput.Placeholder = "Telefon ne smije biti prazan";

                return false;
            }
            else if (!Regex.Match(telefonInput.Text, @"\+387\([3|6][0-9]\)[0-9]{3}\-[0-9]{3}").Success)
            {
                telefonInput.Text = "";
                telefonInput.PlaceholderColor = Color.Red;
                telefonInput.Placeholder = "Pogresan format telefona!";

                return false;
            }

            return true;

        }

        public bool ValidatePicker(Picker picker)
        {

            if (picker.SelectedItem == null)
            {

                picker.BackgroundColor = Color.Red;
                return false;
            }
            else
            {
                picker.BackgroundColor = Color.WhiteSmoke;
                return true;
            }
        }
        #endregion
    }
}