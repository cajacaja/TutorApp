using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PCL_tutor.Util;

namespace Tutor_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Registracija : ContentPage
	{
        private WebApiHelper studentiService = new WebApiHelper("", "api/Student");

		public Registracija ()
		{
			InitializeComponent ();
		}

        private void registracijaButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}