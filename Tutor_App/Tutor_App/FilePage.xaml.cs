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
        private WebApiHelper materijalService = new WebApiHelper("http://192.168.0.102", "api/Materijal");
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

       

        private void MaterijalList_ItemTapped(object sender, ItemTappedEventArgs e)
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
                    }
                    else
                    {
                        //zbog ogranicenih premisija koji UWP nam daje (app sandbox)
                        var document = Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
                        var fileName = Path.Combine(document, materijali.Naslov + materijali.TipFila);
                        File.WriteAllBytes(fileName, materijali.Materijal1);
                    }
                    
                   

                    DisplayAlert("Poruka", "Materijal je preuzet", "OK");
                   
                }
            }
        }
    }
}