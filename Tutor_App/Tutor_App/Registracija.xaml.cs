using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PCL_tutor.Util;
using System.Net.Http;
using PCL_tutor.Model;
using Newtonsoft.Json;

using System.IO;
using System.Text.RegularExpressions;

namespace Tutor_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registracija : ContentPage
    {
        private WebApiHelper spolService = new WebApiHelper("Spol");
        private WebApiHelper gradService = new WebApiHelper("Grad");
        private WebApiHelper tipStudentaService = new WebApiHelper("TipStudenta");
        private WebApiHelper studentService = new WebApiHelper("Student");

        public Registracija()
        {
            InitializeComponent();



        }

        protected override async void OnAppearing()
        {
            BindGrad();
            BindSpol();
            await BindVrstaStudenta();

            base.OnAppearing();
        }

        private async Task BindVrstaStudenta()
        {
            HttpResponseMessage response = await Task.Run(() => tipStudentaService.GetResponse());

            if (response.IsSuccessStatusCode)
            {
                var jasonObject = response.Content.ReadAsStringAsync();
                List<TipStudenta> tipStudenta = JsonConvert.DeserializeObject<List<TipStudenta>>(jasonObject.Result);
                vrstaStudentaPicker.ItemsSource = tipStudenta;
                vrstaStudentaPicker.ItemDisplayBinding = new Binding("Naziv");


            }
        }

        private async Task BindSpol()
        {
            HttpResponseMessage response = await Task.Run(() => spolService.GetResponse());

            if (response.IsSuccessStatusCode)
            {
                var jasonObject = response.Content.ReadAsStringAsync();
                List<Spol> spol = JsonConvert.DeserializeObject<List<Spol>>(jasonObject.Result);
                spolPiker.ItemsSource = spol;
                spolPiker.ItemDisplayBinding = new Binding("Naziv");


            }
        }

        private async Task BindGrad()
        {
            HttpResponseMessage response = await Task.Run(() => gradService.GetResponse());

            if (response.IsSuccessStatusCode)
            {
                var jasonObject = response.Content.ReadAsStringAsync();
                List<Gradovi> gradovi = JsonConvert.DeserializeObject<List<Gradovi>>(jasonObject.Result);
                gradPicker.ItemsSource = gradovi;
                gradPicker.ItemDisplayBinding = new Binding("Naziv");


            }
        }



        private void registracijaButton_Clicked(object sender, EventArgs e)
        {

            if (Validate())
            {

                Student student = new Student();


                student.Ime = imeInput.Text;
                student.Prezime = prezimeInput.Text;
                student.DatumRodjenja = datumRodjenjaInput.Date;
                student.DatumDodavanja = DateTime.Today;
                student.Email = emailInput.Text;
                student.Adresa = adresaInput.Text;
                student.Telefon = telefonInput.Text;
                student.KorisnickoIme = korisnickoImeInput.Text;
                student.LozinkaSalt = UIHelper.GenerateSalt();
                student.LozinkaHash = UIHelper.GenerateHash(student.LozinkaSalt, lozinkaInput.Text);


                if (spolPiker.SelectedItem != null)
                {
                    student.SpolId = (spolPiker.SelectedItem as Spol).SpolId;
                }
                if (gradPicker.SelectedItem != null)
                {
                    student.GradId = (gradPicker.SelectedItem as Gradovi).GradId;

                }

                if (vrstaStudentaPicker.SelectedItem != null)
                {
                    student.TipoviStudentaId = (vrstaStudentaPicker.SelectedItem as TipStudenta).TipoviStudentaId;
                }

                HttpResponseMessage response = studentService.PostResponse(student);

                if (response.IsSuccessStatusCode)
                {
                    DisplayAlert("Info", "Registrovan", "OK");

                }
                else
                {
                    //Dodati resurs file za erore
                    var error = response.Content.ReadAsStringAsync().Result;
                    int startIndex = error.IndexOf(":") + 1;
                    int endIndex = error.IndexOf("\"}", startIndex + 1);

                    if (startIndex > 0 && endIndex > 0)
                    {

                        string errorResult = error.Substring(startIndex + 1, endIndex - startIndex - 1);
                        error = errorResult;
                    }

                    switch (error)
                    {
                        case "UniqueEmail_Error":
                            emailInput.Text = "";
                            emailInput.PlaceholderColor = Color.Red;
                            emailInput.Placeholder = "Unesni e-mail je vec zauzet!";
                            break;
                        case "UniquePhone_Error":
                            telefonInput.Text = "";
                            telefonInput.PlaceholderColor = Color.Red;
                            telefonInput.Placeholder = "Uneseni telefon je vec zauzet";
                            break;
                        case "UniqueUsername_Error":
                            korisnickoImeInput.Text = "";
                            korisnickoImeInput.PlaceholderColor = Color.Red;
                            korisnickoImeInput.Placeholder = "Korisnicko ime je vec zauzeto";
                            break;
                        default:
                            DisplayAlert("Error", "Pogresan unos u polje", "Ok");
                            break;
                    }


                }
            }
        }


        //Dodati resurs file za errore
        public bool Validate()
        {

            List<bool> lst = new List<bool>();
            lst.Add(ValidateIme());
            lst.Add(ValidatePrezime());
            lst.Add(ValidateAdresu());
            lst.Add(ValidateEmail());
            lst.Add(ValidateKorisnickoIme());
            lst.Add(ValidateLozinku());
            lst.Add(ValidateTelefon());
            lst.Add(ValidatePicker(spolPiker));
            lst.Add(ValidatePicker(gradPicker));
            lst.Add(ValidatePicker(vrstaStudentaPicker));
            int broj = lst.Where(x => x.Equals(false)).Count();

            if (broj > 0) return false;

            return true;
        }

        public bool ValidatePicker(Picker picker) {

            if (picker.SelectedItem == null) {

                picker.BackgroundColor = Color.Red;
                return false;
            }
            else
            {
                picker.BackgroundColor = Color.WhiteSmoke;
                return true;
            }
        }

        private bool ValidateIme()
        {
            if (String.IsNullOrEmpty(imeInput.Text))
            {
                imeInput.PlaceholderColor = Color.Red;
                imeInput.Placeholder = "Ime ne smije biti prazno";

                return false;
            }
            else if (!Regex.Match(imeInput.Text, @"[a-zA-Z]+").Success)
            {
                imeInput.Text = "";
                imeInput.PlaceholderColor = Color.Red;
                imeInput.Placeholder = "Ime sadrzi samo slova";

                return false;
            }

            return true;

        }



        private bool ValidatePrezime()
        {
            if (String.IsNullOrEmpty(prezimeInput.Text))
            {
                prezimeInput.PlaceholderColor = Color.Red;
                prezimeInput.Placeholder = "Prezime ne smije biti prazno";

                return false;
            }
            else if (!Regex.Match(prezimeInput.Text, @"[a-zA-Z]+").Success)
            {
                prezimeInput.Text = "";
                prezimeInput.PlaceholderColor = Color.Red;
                prezimeInput.Placeholder = "Prezime sadrzi samo slova";

                return false;
            }

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


        private bool ValidateKorisnickoIme()
        {
            if (String.IsNullOrEmpty(korisnickoImeInput.Text))
            {
                korisnickoImeInput.PlaceholderColor = Color.Red;
                korisnickoImeInput.Placeholder = "Korisnicko ime ne smije biti prazno";

                return false;
            }
            else if (!Regex.Match(korisnickoImeInput.Text, @"[a-zA-Z]+").Success)
            {
                prezimeInput.Text = "";
                korisnickoImeInput.PlaceholderColor = Color.Red;
                korisnickoImeInput.Placeholder = "Korisnicko ime sadrzi samo slova";

                return false;
            }

            return true;

        }


        private bool ValidateLozinku()
        {
            if (String.IsNullOrEmpty(lozinkaInput.Text))
            {
                lozinkaInput.PlaceholderColor = Color.Red;
                lozinkaInput.Placeholder = "Lozinka ne smije biti prazna";

                return false;
            }

            return true;
        }
    }
}
