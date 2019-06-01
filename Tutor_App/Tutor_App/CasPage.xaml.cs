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
	public partial class CasPage : ContentPage
	{
        private WebApiHelper zahtjevService = new WebApiHelper("Zahtjev");
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
            if (Validete())
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

        private bool Validete()
        {
           var listError = new List<bool>();
            listError.Add(ValideteDatum());
            listError.Add(ValideteVrijeme());
            listError.Add(ValideteBrojCasova());

            int broj = listError.Where(x => x.Equals(false)).Count();

            if (broj > 0) return false;

            return true;
        }

        private bool ValideteDatum()
        {
            if (DatumOd.Date > DatumDo.Date)
            {
                datumError.IsVisible = true;
                datumError.Text = "Datum od ne smije biti veci od Datuma do.";
                return false;
            }

            datumError.IsVisible = false;
            return true;
        }

        private bool ValideteVrijeme()
        {
            if (timePickerOd.Time > timePickerDo.Time)
            {
                vrijemeError.IsVisible = true;
                vrijemeError.Text = "Vrijeme od ne smije biti veci od Vremena do.";
                return false;
            }

            vrijemeError.IsVisible = false;
            return true;
        }

        private bool ValideteBrojCasova()
        {
            if (String.IsNullOrEmpty(brojCasovaInput.Text))
            {
                brojCasovaError.IsVisible = true;
                brojCasovaError.Text = "Morate odrediti broj casova.";
                return false;
            }
            else if (!Regex.Match(brojCasovaInput.Text, @"[0-9]+").Success)
            {
                brojCasovaError.IsVisible = true;
                brojCasovaError.Text = "Broj casova prima samo brojeve";

                return false;
            }
            brojCasovaError.IsVisible = false;
            return true;
        }
    }
}