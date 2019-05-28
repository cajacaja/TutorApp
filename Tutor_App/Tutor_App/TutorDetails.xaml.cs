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
using Tutor_App.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutor_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TutorDetails : ContentPage
	{
        private WebApiHelper tutorService = new WebApiHelper("http://192.168.0.102", "api/Tutor");
        private Tutori tutor;
        List<Image> images;
       
        public TutorDetails (int tutorId)
		{
			InitializeComponent ();
            images = new List<Image>();
            LoadTutor(tutorId);
            BindingContext = new OcjeneTutorViewModel(tutorId);
            
		}

        private void LoadTutor(int tutorId)
        {
            HttpResponseMessage responseMessage = tutorService.GetActionResponse("TutorDetails", tutorId.ToString());
            var jasonObject = responseMessage.Content.ReadAsStringAsync();
            tutor = JsonConvert.DeserializeObject<Tutori>(jasonObject.Result);
           
           
            for (int i = 0; i < tutor.Ocjena; i++)
            {
                Image slika = new Image { Source = "onestar.png", HeightRequest = 25, WidthRequest = 25 };

                starList.Children.Add(slika);
            }


           
           

            tutorSlika.Source = ImageSource.FromStream(()=>new MemoryStream(tutor.TutorTumbnail));
            imeInput.Text = tutor.Ime;
            prezimeInput.Text = tutor.Prezime;
            spolInput.Text = tutor.Spol;
            predmetInput.Text = tutor.Predmet;
            cijenaInput.Text = tutor.CijenaCasa.ToString() + " KM";
         
        }

        private void ZakaziBtn_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new CasPage(tutor.TutorId));
        }

        private void Ocjeni_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new OcjeniPage(tutor.TutorId));
        }

        private void Prijavi_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new PrijaviTutoraPage (tutor.TutorId));
        }
    }
}