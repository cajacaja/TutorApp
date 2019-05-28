using Newtonsoft.Json;
using PCL_tutor.Model;
using PCL_tutor.Util;
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
	public partial class CasDetalji : ContentPage
	{
        
        private WebApiHelper tutorService = new WebApiHelper("http://192.168.0.102", "api/Tutor");
        private WebApiHelper terminiService = new WebApiHelper("http://192.168.0.102", "api/TerminCasa");
        int idTutora = 0;
        int idZahtjeva = 0;

        public CasDetalji (int tutorId,int zahtjevId)
		{
			InitializeComponent ();
            idTutora = tutorId;
            idZahtjeva = zahtjevId;
            LoadTutor();
		}

        private void LoadTutor()
        {
            var response = tutorService.GetActionResponse("TutorDetails", idTutora.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jasonObject = response.Content.ReadAsStringAsync();
                var tutor = JsonConvert.DeserializeObject<Tutori>(jasonObject.Result);

                tutorSlika.Source = ImageSource.FromStream(() => new MemoryStream(tutor.TutorTumbnail));
                imeInput.Text = tutor.Ime;
                prezimeInput.Text = tutor.Prezime;
              
                

                for (int i = 0; i < tutor.Ocjena; i++)
                {
                    Image slika = new Image { Source = "onestar.png", HeightRequest = 20, WidthRequest = 20 };

                    starList.Children.Add(slika);
                }

                emailInput.Text = tutor.Email;
                adresaInput.Text = tutor.Adresa;
                telefonInput.Text = tutor.Telefon;

            }

            response = terminiService.GetActionResponse("TerminByZahtjev",idZahtjeva.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jasonObject = response.Content.ReadAsStringAsync();
                var termini = JsonConvert.DeserializeObject<List<TerminiCasa>>(jasonObject.Result);
                terminiList.ItemsSource = termini;
                terminiList.HeightRequest = terminiList.RowHeight * (termini.Count + 1);
            }
        }
    }
}