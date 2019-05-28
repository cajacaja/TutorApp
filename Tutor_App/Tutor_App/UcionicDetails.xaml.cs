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
    public partial class UcionicDetails : ContentPage
    {
        private WebApiHelper ucionicaService = new WebApiHelper("http://192.168.0.102", "api/Ucionica");
        private WebApiHelper prijavaService = new WebApiHelper("http://192.168.0.102", "api/Prijava");
        private WebApiHelper studentService = new WebApiHelper("http://192.168.0.102", "api/Student");


        int idUcionice = 0;
        int tutorId = 0;
        public UcionicDetails(int UcionicaId)
        {
            idUcionice = UcionicaId;
            
            InitializeComponent();
            docDownloadBtn.IsVisible = false;
            LoadForm();
        }

        private void PrijavaCheck()
        {
            var response = studentService.GetActionResponse("AllPrijave",Global.prijavljeniStudent.StudentId.ToString());
            if (response.IsSuccessStatusCode)
            {
                bool check = true;
                var jasonObject = response.Content.ReadAsStringAsync();
                var lstPrijava = JsonConvert.DeserializeObject<List<Prijava>>(jasonObject.Result);
                foreach (var item in lstPrijava)
                {
                    if (item.UcionicaId.Equals(idUcionice))
                    {
                        if (item.Prihvaceno)
                        {
                            docDownloadBtn.IsVisible = true;
                        }
                       
                        check = false;
                    }
                        
                   
                }

                zahtjevBtn.IsVisible = check;
            }
        }

        private void LoadForm()
        {
            HttpResponseMessage response = ucionicaService.GetActionResponse("UcionicaDetails", idUcionice.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jasonObject = response.Content.ReadAsStringAsync();
                var ucionica = JsonConvert.DeserializeObject<Ucionica>(jasonObject.Result);
                //popuni podatke
                naslovInput.Text = ucionica.Naslov;
                ucionicaSlika.Source = ImageSource.FromStream(() => new MemoryStream(ucionica.Slika));
                opisInput.Text = ucionica.Opis;
                datumPocetkaInput.Text = ucionica.DatumPocetka.ToShortDateString();
                datumZavrsetkaInput.Text = ucionica.DatumZavrsetka.ToShortDateString();
                adresaInput.Text = ucionica.AdresaUcionice;
                maxBrUcenikaInput.Text = ucionica.MaxBrojPolaznika.ToString();
                cijenaInput.Text = ucionica.Cijena.ToString() + " KM";
                tutorId = ucionica.TutorId;


                response = ucionicaService.GetActionResponse("Termini", idUcionice.ToString());
                jasonObject = response.Content.ReadAsStringAsync();
                var termini = JsonConvert.DeserializeObject<List<Termin>>(jasonObject.Result);
                terminiList.ItemsSource = termini;
                terminiList.HeightRequest = terminiList.RowHeight * (termini.Count + 1);
                //popuni podatke

                PrijavaCheck();

            }
        }

        private void TutorBtn_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new TutorDetails(tutorId));
        }

        private void ZahtjevBtn_Clicked(object sender, EventArgs e)
        {
            Prijava prijava = new Prijava()
            {
                UcionicaId = idUcionice,
                StudentId = Global.prijavljeniStudent.StudentId,
                Prihvaceno = false,
                Odbijeno=false,
                DatumPrijave=DateTime.Today
            };

            var response = prijavaService.PostResponse(prijava);
            if (response.IsSuccessStatusCode)
            {
                DisplayAlert("Poruka", "Uspjeno poslana prijava", "OK");
                PrijavaCheck();
            }
        }

        private void DocDownloadBtn_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new FilePage(idUcionice));
        }
    }
}