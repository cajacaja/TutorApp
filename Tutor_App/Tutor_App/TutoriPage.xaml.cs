using Newtonsoft.Json;
using PCL_tutor.Model;
using PCL_tutor.Util;
using System;
using System.Collections.Generic;
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
	public partial class TutoriPage : ContentPage
	{
        private WebApiHelper oblastService = new WebApiHelper("Oblast");
        private WebApiHelper tutorService = new WebApiHelper("Tutor");

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

            tutorLista.IsVisible = false;
            base.OnAppearing();
        }

        protected void oblastPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (oblastPicker.SelectedItem != null)
            {
                tutorLista.IsVisible = true;
                int oblasdtId = (oblastPicker.SelectedItem as Oblast).OblastId;
                BindingContext = new TutoriViewModel(oblasdtId,Global.prijavljeniStudent.GradId,Global.prijavljeniStudent.TipoviStudentaId);

                var index = (tutorLista.ItemsSource as List<Tutori>);
                if (index != null)
                tutorLista.HeightRequest = tutorLista.RowHeight * (index.Count + 1);

                
            }
        }

        private void TutorLista_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                this.Navigation.PushAsync(new TutorDetails((e.Item as Tutori).TutorId));
                
            }
        }
    }
}