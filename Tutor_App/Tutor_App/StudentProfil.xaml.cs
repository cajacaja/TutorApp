using Newtonsoft.Json;
using PCL_tutor.Model;
using PCL_tutor.Util;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutor_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StudentProfil : ContentPage
	{
        private WebApiHelper gradService = new WebApiHelper("Grad");
        private WebApiHelper spolService = new WebApiHelper("Spol");
        private WebApiHelper tipStudentaService = new WebApiHelper("TipStudenta");
        private WebApiHelper kontakInfoService = new WebApiHelper("KontaktInfo");
        private WebApiHelper korisnickiNalogService = new WebApiHelper("KorisnickiNalog");
        private WebApiHelper studentService = new WebApiHelper("Student");



        public StudentProfil ()
		{
			InitializeComponent ();
            NavigationPage.SetHasBackButton(this, false);
		}

        protected override void OnAppearing()
        {
            Student student = Global.prijavljeniStudent;
            studentPicture.Source = ImageSource.FromStream(() => new MemoryStream(Global.prijavljeniStudent.StudentskaSlika));           
            datumRodjenjaInput.Text = student.DatumRodjenja.ToShortDateString();

            var response = spolService.GetResponse(student.SpolId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jasonObject = response.Content.ReadAsStringAsync();
                var spol = JsonConvert.DeserializeObject<Spol>(jasonObject.Result);
                spolInput.Text = spol.Naziv;
            }

            response = gradService.GetResponse(student.GradId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jasonObject = response.Content.ReadAsStringAsync();
                var grad = JsonConvert.DeserializeObject<Gradovi>(jasonObject.Result);
                gradInput.Text = grad.Naziv;
            }

            response = tipStudentaService.GetResponse(student.TipoviStudentaId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jasonObject = response.Content.ReadAsStringAsync();
                var tipStudenta = JsonConvert.DeserializeObject<TipStudenta>(jasonObject.Result);
                tipStudentaInput.Text = tipStudenta.Naziv;
            }

            response = korisnickiNalogService.GetResponse(student.KorisnickiNalogId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jasonObject = response.Content.ReadAsStringAsync();
                var korisnickiNalog = JsonConvert.DeserializeObject<KorisnickiNalog>(jasonObject.Result);

                Global.prijavljeniStudent.KorisnickoIme = korisnickiNalog.KorisnickoIme;
                Global.prijavljeniStudent.LozinkaSalt   = korisnickiNalog.LozinkaSalt;
                Global.prijavljeniStudent.LozinkaHash   = korisnickiNalog.LozinkaHash;

                korisnickoImeInput.Text = korisnickiNalog.KorisnickoIme;


            }


            response = kontakInfoService.GetResponse(student.KontaktInfoId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jasonObject = response.Content.ReadAsStringAsync();
                var kontakInfo = JsonConvert.DeserializeObject<KontaktInfo>(jasonObject.Result);

                Global.prijavljeniStudent.Email   = kontakInfo.Email;
                Global.prijavljeniStudent.Telefon = kontakInfo.Telefon;
                Global.prijavljeniStudent.Adresa  = kontakInfo.Adresa;

               emailInput.Text   = kontakInfo.Email;
               adresaInput.Text  = kontakInfo.Telefon;
               telefonInput.Text = kontakInfo.Adresa;


            }

            base.OnAppearing();
        }

        private  void izborBtn_Clicked(object sender, EventArgs e)
        {
            izaberiBtn.IsVisible = true;
            uslikajBtn.IsVisible = true;
            izborBtn.IsVisible = false;
            editBtn.IsVisible = false;
            
        }

        private async void IzaberiBtn_Clicked(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Error", "Odabir slika nije podrzan", "Ok");
                return;
            }

            var mediaFile = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions
            {
                PhotoSize = PhotoSize.Medium,
            });

            if (mediaFile.Equals(null))
                return;

            Stream stream = mediaFile.GetStream();
            using (var streamReader = new MemoryStream())
            {
                stream.CopyTo(streamReader);
                Global.prijavljeniStudent.StudentskaSlika = streamReader.ToArray();
            }

            var response = studentService.PutResponse(Global.prijavljeniStudent.StudentId, Global.prijavljeniStudent);
            if (response.IsSuccessStatusCode)
            {
                izaberiBtn.IsVisible = false;
                uslikajBtn.IsVisible = false;
                Application.Current.MainPage = new Nav.Menu();
            }
        }

        private async void UslikajBtn_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":( No camera available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "Sample",
                Name = "test.jpg"
            });

            if (file == null)
                return;

            Stream stream = file.GetStream();
            using (var streamReader = new MemoryStream())
            {
                stream.CopyTo(streamReader);
                Global.prijavljeniStudent.StudentskaSlika = streamReader.ToArray();
            }

            var response = studentService.PutResponse(Global.prijavljeniStudent.StudentId, Global.prijavljeniStudent);
            if (response.IsSuccessStatusCode)
            {
                izaberiBtn.IsVisible = false;
                uslikajBtn.IsVisible = false;
                Application.Current.MainPage = new Nav.Menu();
            }
        }

        private async void EditBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditPage());
        }
    }
}