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

namespace Tutor_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        private WebApiHelper studentService = new WebApiHelper("http://192.168.0.102", "api/Student");
        public LoginPage ()
		{
			InitializeComponent ();
            errorMessage.IsVisible = false;
           

        }

        private async void LogIn_Clicked(object sender, EventArgs e)
        {
            var parametar = KorisnickoImeInput.Text + "/" + PasswordInput.Text;
            HttpResponseMessage response = studentService.GetActionResponse("LoginCheck", parametar);

            if (response.IsSuccessStatusCode) {
                errorMessage.IsVisible = false;
                await Navigation.PushAsync(new PretragaPage());

            }
            else
            {
                errorMessage.IsVisible = true;
            }

        }

        private async void Registracija_Clicked(object sender, EventArgs e) {

            await Navigation.PushAsync(new Registracija());
        }





    }
}