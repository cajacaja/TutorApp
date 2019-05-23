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
	public partial class TutoriPage : ContentPage
	{
        private WebApiHelper oblastService = new WebApiHelper("http://192.168.0.102", "api/Oblast");
        private WebApiHelper tutorService = new WebApiHelper("http://192.168.0.102", "api/Tutor");
        public TutoriPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            HttpResponseMessage response = oblastService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                var jasonObject = response.Content.ReadAsStringAsync();
                List<Oblast> oblasti = JsonConvert.DeserializeObject<List<Oblast>>(jasonObject.Result);

                oblastPicker.ItemsSource = oblasti;
                oblastPicker.ItemDisplayBinding = new Binding("Naziv");
            }
            base.OnAppearing();
        }

        protected void oblastPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (oblastPicker.SelectedItem != null)
            {
                int oblasdtId = (oblastPicker.SelectedItem as Oblast).OblastId;
                HttpResponseMessage response = tutorService.GetActionResponse("SelectByOblast",oblasdtId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    var jasonObject = response.Content.ReadAsStringAsync();
                    List<Tutori> tutori = JsonConvert.DeserializeObject<List<Tutori>>(jasonObject.Result);

                    tutorLista.ItemsSource = tutori;
                    
                }
            }
        }
    }
}