using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PCL_tutor;
using PCL_tutor.Util;
using System.Net.Http;
using Newtonsoft.Json;
using PCL_tutor.Model;
using System.Threading;

namespace Tutor_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        private WebApiHelper studentService = new WebApiHelper("Student");
        


        public LoginPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            errorMessage.IsVisible = false;
            loginIndicator.IsVisible = false;
            loginIndicator.IsRunning = false;

            

        }

      

        private async  void LogIn_Clicked(object sender, EventArgs e)
        {
           
            var parametar = KorisnickoImeInput.Text + "/" + PasswordInput.Text;
            errorMessage.IsVisible = false;
            loginIndicator.IsVisible = true;
            loginIndicator.IsRunning = true;
            regstracijaBtn.IsEnabled = false;
             HttpResponseMessage response = await Task.Run(() =>studentService.GetActionResponse("LoginCheck", parametar));
                
                
            

            if (response.IsSuccessStatusCode) {
                errorMessage.IsVisible = false;
                var jasonObject = response.Content.ReadAsStringAsync();
                var student= JsonConvert.DeserializeObject<Student>(jasonObject.Result);

                loginIndicator.IsVisible = false;
                loginIndicator.IsRunning = false;
                regstracijaBtn.IsEnabled = true;
                if (student.StatusKorisnickoRacunaId == 3)
                {
                   await DisplayAlert("Ban", "Vas racun je banovan.Za vise informacija kontaktirajte administraciju", "OK");
                }
                else
                {
                    Global.prijavljeniStudent = student;
                    Application.Current.MainPage = new Nav.Menu();

                }

               

            }
            else
            {
                loginIndicator.IsVisible = false;
                loginIndicator.IsRunning = false;
                regstracijaBtn.IsEnabled = true;
                errorMessage.IsVisible = true;
            }

        }

        private async void Registracija_Clicked(object sender, EventArgs e) {
            
            await Navigation.PushAsync(new Registracija());
        }





    }
}