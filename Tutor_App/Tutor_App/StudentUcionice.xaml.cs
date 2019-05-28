using Newtonsoft.Json;
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
	public partial class StudentUcionice : ContentPage
	{
        private WebApiHelper studentService = new WebApiHelper("http://192.168.0.102", "api/Student");
        private WebApiHelper ucionicaService = new WebApiHelper("http://192.168.0.102", "api/Ucionica");
        private List<Prijava> prihvacene;
        private List<Prijava> odbijene;
        private List<Prijava> neOdgovorene;
        public StudentUcionice ()
		{
			InitializeComponent ();
            prihvacene = new List<Prijava>();
            odbijene = new List<Prijava>();
            neOdgovorene = new List<Prijava>();
        }

        protected override void OnAppearing()
        {
            string parameter = Global.prijavljeniStudent.StudentId.ToString();
            HttpResponseMessage response = studentService.GetActionResponse("AllPrijave", parameter);
            if (response.IsSuccessStatusCode)
            {
                var jasonObject = response.Content.ReadAsStringAsync();
                List<Prijava> prijave = JsonConvert.DeserializeObject<List<Prijava>>(jasonObject.Result);

                prihvacene = prijave.Where(x => x.Prihvaceno.Equals(true)).ToList();
                odbijene = prijave.Where(x => x.Odbijeno.Equals(true)).ToList();
                neOdgovorene = prijave.Where(x => x.Prihvaceno.Equals(false) && x.Odbijeno.Equals(false)).ToList();
                PrihvacenUcionica();
                OdbijenUcionica();
                NeOdgovoreneUcionice();
            }
            base.OnAppearing();
        }

        private void NeOdgovoreneUcionice()
        {
            List<Ucionica> neOdovorenePrijave = new List<Ucionica>();
            foreach (var prijava in neOdgovorene)
            {
                HttpResponseMessage response = ucionicaService.GetResponse(prijava.UcionicaId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    var jasonObject = response.Content.ReadAsStringAsync();
                    var ucionica = JsonConvert.DeserializeObject<Ucionica>(jasonObject.Result);
                    if (ucionica.Aktivna && ucionica.DatumPocetka > DateTime.Today)
                        neOdovorenePrijave.Add(ucionica);

                }
            }

            neodgovoreneInput.Text = neOdovorenePrijave.Count.ToString();
        }

        private void OdbijenUcionica()
        {
            List<Ucionica> ucionicaOdbijen = new List<Ucionica>();
            foreach (var prijava in odbijene)
            {
                HttpResponseMessage response = ucionicaService.GetResponse(prijava.UcionicaId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    var jasonObject = response.Content.ReadAsStringAsync();
                    var ucionica = JsonConvert.DeserializeObject<Ucionica>(jasonObject.Result);
                    if (ucionica.Aktivna && ucionica.DatumPocetka > DateTime.Today)
                        ucionicaOdbijen.Add(ucionica);

                }
            }

            //dodavanjeUListu
            odbijeniList.ItemsSource = ucionicaOdbijen;
        }

        private void PrihvacenUcionica()
        {
            List<Ucionica> ucionicaPrihvacen = new List<Ucionica>();
            foreach (var prijava in prihvacene)
            {
                HttpResponseMessage response = ucionicaService.GetResponse(prijava.UcionicaId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    var jasonObject = response.Content.ReadAsStringAsync();
                    var ucionica = JsonConvert.DeserializeObject<Ucionica>(jasonObject.Result);
                    if (ucionica.Aktivna && ucionica.DatumZavrsetka > DateTime.Today)
                        ucionicaPrihvacen.Add(ucionica);

                }
            }

            prihvaceneList.ItemsSource = ucionicaPrihvacen;
        }

        private async void PrihvaceneList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                await Navigation.PushAsync(new UcionicDetails((e.Item as Ucionica).UcionicaId));
            }
        }

        private async void OdbijeniList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                await Navigation.PushAsync(new UcionicDetails((e.Item as Ucionica).UcionicaId));
            }
        }
    }
}