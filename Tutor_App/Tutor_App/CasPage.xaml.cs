using PCL_tutor.Model;
using PCL_tutor.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutor_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CasPage : ContentPage
	{
        private WebApiHelper zahtjevService = new WebApiHelper("http://192.168.0.102", "api/Zahtjev");
        private int idTutora = 0;
		public CasPage (int tutorId)
		{
            idTutora = tutorId;
			InitializeComponent ();
            timePickerOd.Format = "HH:mm";
            timePickerDo.Format = "HH:mm";
        }

        private void PosaljeBtn_Clicked(object sender, EventArgs e)
        {
            Zahtjev noviZahtjev = new Zahtjev()
            {
                TutorId = idTutora,
                StudentId = Global.prijavljeniStudent.StudentId,
                DatumSlanja = DateTime.Now,
                DatumOd = DatumOd.Date,
                DatumDo = DatumDo.Date,
                VrijemeOd = timePickerOd.Time,
                VrijemeDo = timePickerDo.Time,
                BrojCasova = Convert.ToInt32(brojCasovaInput.Text)
            };

            HttpResponseMessage response = zahtjevService.PostResponse(noviZahtjev);
            if (response.IsSuccessStatusCode)
            {
                DisplayAlert("Zahtjev", "Zahtjev je poslan", "OK");
                this.Navigation.PushAsync(new TutorDetails(idTutora));
            }
        }
    }
}