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
        private WebApiHelper tutorService = new WebApiHelper("Tutor");
        private WebApiHelper studentService = new WebApiHelper("Student");
        private WebApiHelper ocjenaTutorService = new WebApiHelper("OcjenaTutor");
        private WebApiHelper zahtjevService = new WebApiHelper("Zahtjev");

      

        private Tutori tutor;
        List<Image> images;
       
        public TutorDetails (int tutorId)
		{
			InitializeComponent ();
            images = new List<Image>();
            ocjeniBtn.IsVisible = false;
            prijaviBtn.IsVisible = false;
            LoadTutor(tutorId);
            BindingContext = new OcjeneTutorViewModel(tutorId);
            List<OcjenaTutor> lst = tutorLista.ItemsSource as List<OcjenaTutor>;
            int brojac = 0;
            if (lst != null)
                brojac = lst.Count;
            tutorLista.HeightRequest = tutorLista.RowHeight+10;

            
           
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


            string parameter = Global.prijavljeniStudent.StudentId.ToString();
            //provjeri jel predavao taj predmet tutor
            var response = studentService.GetActionResponse("PohadjeniPredmeti", parameter);
            if (response.IsSuccessStatusCode)
            {
               jasonObject = response.Content.ReadAsStringAsync();
               var predmeti = JsonConvert.DeserializeObject<List<PohadjaniPredmeti>>(jasonObject.Result);

                var predmet = predmeti.FirstOrDefault(x => x.TutorId == tutorId);
                if (predmet != null)
                {
                    //ako jest provjeri jel student dao ocjenu vec
                    response = ocjenaTutorService.GetActionResponse("CheckOcjena", tutorId.ToString() + "/" + parameter);
                    if (response.IsSuccessStatusCode)
                    {
                        jasonObject = response.Content.ReadAsStringAsync();
                        var ocjena = JsonConvert.DeserializeObject<bool>(jasonObject.Result);
                        //ako nije onda stavi da moze da ocjeni
                        if (!ocjena)
                            ocjeniBtn.IsVisible = true;
                        else
                            ocjeniBtn.IsVisible = false;
                    }
                    
                    prijaviBtn.IsVisible = true;
                }
            }

            //provjeri jel taj tutor predavao studentu ucionicu
            response = studentService.GetActionResponse("PohadjaneUcionice", parameter);
            if (response.IsSuccessStatusCode)
            {
                jasonObject = response.Content.ReadAsStringAsync();
                var ucionice = JsonConvert.DeserializeObject<List<PohadjaneUcionice>>(jasonObject.Result);

                var ucionica = ucionice.FirstOrDefault(x => x.TutorId == tutorId);
                if (ucionica != null)
                {
                    //ako jest provjeri jel ocjenen tutor
                    response = ocjenaTutorService.GetActionResponse("CheckOcjena", tutorId.ToString() + "/" + parameter);
                    if (response.IsSuccessStatusCode)
                    {
                        jasonObject = response.Content.ReadAsStringAsync();
                        var ocjena = JsonConvert.DeserializeObject<bool>(jasonObject.Result);
                        //ako nije postavi da student moze ocjenit tutora
                        if (!ocjena)
                            ocjeniBtn.IsVisible = true;
                        else
                            ocjeniBtn.IsVisible = false;
                    }
                    prijaviBtn.IsVisible = true;
                }
            }

           

            response = zahtjevService.GetActionResponse("Aktuelni", parameter);
            if (response.IsSuccessStatusCode)
            {
                jasonObject = response.Content.ReadAsStringAsync();
                var zahtjevi = JsonConvert.DeserializeObject<List<Zahtjev>>(jasonObject.Result);

                var zahtjev = zahtjevi.FirstOrDefault(x => x.TutorId == tutorId && x.Prihvaceno == true);
                if (zahtjev != null)
                    zakaziBtn.IsVisible = false;
                    

            }

            string parameter1 = tutorId.ToString() + "/" + Global.prijavljeniStudent.TipoviStudentaId.ToString();
            response = tutorService.GetActionResponse("RecommendTutor", parameter1);
            if ( response.IsSuccessStatusCode)
            {
                jasonObject = response.Content.ReadAsStringAsync();
                var preporuceniTutori = JsonConvert.DeserializeObject<List<Tutori>>(jasonObject.Result);
                preporukaList.ItemsSource = preporuceniTutori.Take(3);

                if (preporuceniTutori.Count == 0)
                    preporukaList.IsVisible = false;
                else
                {
                    preporukaList.HeightRequest = preporukaList.RowHeight * (preporuceniTutori.Count);
                    preporukaList.IsVisible = true;
                }
                   


            }

            
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

        private void PreporukaList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                int tutorId = (e.Item as Tutori).TutorId;
                this.Navigation.PushAsync(new TutorDetails(tutorId));
            }
        }
    }
}