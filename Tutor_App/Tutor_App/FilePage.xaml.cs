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
	public partial class FilePage : ContentPage
	{
        private WebApiHelper materijalService = new WebApiHelper("Materijal");
        public FilePage (int ucionicaId)
		{
			InitializeComponent ();
            var response = materijalService.GetActionResponse("GetMaterijale",ucionicaId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jasonObject = response.Content.ReadAsStringAsync();
                var materijali = JsonConvert.DeserializeObject<List<Materijal>>(jasonObject.Result);

                materijalList.ItemsSource = materijali;
            }
		}



        private async void MaterijalList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            bool check = false;
            var actionSheet = await DisplayActionSheet("Skinuti materijal", null, null, "Ok", "Cancel");
            switch (actionSheet)
            {
                case "Cancel":
                    check = false;
                    break;

                case "Ok":
                    check = true;
                    break;           
            }
            if (check)
            {
                if (e.Item != null)
                {
                    int materijalId = (e.Item as Materijal).MaterijalId;
                    var response = materijalService.GetResponse(materijalId.ToString());
                    if (response.IsSuccessStatusCode)
                    {
                        var jasonObject = response.Content.ReadAsStringAsync();
                        var materijali = JsonConvert.DeserializeObject<Materijal>(jasonObject.Result);
                        if (Device.RuntimePlatform == Device.Android)
                        {
                            var document = Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                            var fileName = Path.Combine(document, materijali.Naslov + materijali.TipFila);
                            File.WriteAllBytes(fileName, materijali.Materijal1);
                            await DisplayAlert("Materijal", "Materijal skinut", "OK");
                        }
                        else
                        {
                            //premoran koristit localapplicaitondata radi sandbox-a i premisija UWP-a
                            var document = Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
                            var fileName = Path.Combine(document, materijali.Naslov + materijali.TipFila);
                            File.WriteAllBytes(fileName, materijali.Materijal1);
                        }

                       
                    }
                }
            }
        }
    }
}