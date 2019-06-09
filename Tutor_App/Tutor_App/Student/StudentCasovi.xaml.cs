using Newtonsoft.Json;
using PCL_tutor.Model;
using PCL_tutor.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutor_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StudentCasovi : ContentPage
	{
        private WebApiHelper zahtjevService = new WebApiHelper("Zahtjev");
        private WebApiHelper tutorService = new WebApiHelper("Tutor");
        private List<AktuelniZahtjev> lstZahtjeva { get; set; }
        private List<AktuelniZahtjev> lstPrihvacenih { get; set; }
      
        public StudentCasovi ()
		{
			InitializeComponent ();
            lstZahtjeva = new List<AktuelniZahtjev>();
            lstPrihvacenih = new List<AktuelniZahtjev>();
           

            LoadForm();
            LoadPrihvacene();
            

        }

       
        private void LoadForm()
        {
            var response = zahtjevService.GetActionResponse("Aktuelni", Global.prijavljeniStudent.StudentId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jasonObject = response.Content.ReadAsStringAsync();
                lstZahtjeva = JsonConvert.DeserializeObject<List<AktuelniZahtjev>>(jasonObject.Result);
            }


            neodgCas.Text = lstZahtjeva.Where(x => x.Prihvaceno==false && x.Odbijeno==false).Count().ToString();
        }

        private void LoadPrihvacene()
        {
            lstPrihvacenih = lstZahtjeva.Where(x => x.Prihvaceno==true).ToList();           

            tutorLista.ItemsSource = lstPrihvacenih;
            int broj = 0;
            if (lstPrihvacenih != null)
                broj = lstPrihvacenih.Count;
            tutorLista.HeightRequest = tutorLista.RowHeight *(broj+1);
        }
       

        private void TutorListaOdb_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item!=null)
            {
                this.Navigation.PushAsync(new TutorDetails((e.Item as AktuelniZahtjev).TutorId));
            }
        }

        private void tutorList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                var zahtjev = e.Item as AktuelniZahtjev;
                this.Navigation.PushAsync(new CasDetalji(zahtjev.TutorId,zahtjev.ZahtjevId));
            }
        }
    }
}