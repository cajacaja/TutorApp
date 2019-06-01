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
	public partial class UcionicePage : ContentPage
	{
        private WebApiHelper oblastService = new WebApiHelper("Oblast");
        public UcionicePage ()
		{
			InitializeComponent ();
            ucionicaList.IsVisible = false;
           
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

        private void OblastPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (oblastPicker.SelectedItem != null)
            {
                int oblasdtId = (oblastPicker.SelectedItem as Oblast).OblastId;
                BindingContext = new UcionicaViewModel(oblasdtId, Global.prijavljeniStudent.GradId, Global.prijavljeniStudent.TipoviStudentaId);
                ucionicaList.IsVisible = true;
            }

            
        }

        private void UcionicaList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                this.Navigation.PushAsync(new UcionicDetails((e.Item as Ucionica).UcionicaId));
            }
        }
    }
}