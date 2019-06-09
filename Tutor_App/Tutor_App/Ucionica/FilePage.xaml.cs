using Newtonsoft.Json;
using PCL_tutor.Model;
using PCL_tutor.Util;
using Plugin.FilePicker;
using Plugin.FilePicker.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Pickers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutor_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilePage : ContentPage
    {
        private WebApiHelper materijalService = new WebApiHelper("Materijal");
        public FilePage(int ucionicaId)
        {
            InitializeComponent();
            var response = materijalService.GetActionResponse("GetMaterijale", ucionicaId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jasonObject = response.Content.ReadAsStringAsync();
                var materijali = JsonConvert.DeserializeObject<List<Materijal>>(jasonObject.Result);

                materijalList.ItemsSource = materijali;
            }
        }



        private async void MaterijalList_ItemTapped(object sender, ItemTappedEventArgs e)
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

                        var externalPath = Path.Combine(Android.OS.Environment.ExternalStorageState, materijali.Naslov + materijali.TipFila); 
                        File.WriteAllBytes(externalPath, materijali.Materijal1);
                        var openFile = await DisplayActionSheet("Pogledaj", "Da", "Ne", "Pogledajte dokument?");
                        switch (openFile)
                        {
                            case "Da":
                                {
                                    Device.OpenUri(new Uri(externalPath));
                                    break;
                                }
                            case "Ne":
                                {
                                    break;
                                }
                        }
                    }
                    else
                    {





                        //premoran koristit localapplicaitondata radi sandbox-a i premisija UWP-a pokusano je uradit se sa pickerima preko restricted capability ali opet nije dalo dalje od ovvoga foldera
                        var document = Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
                        var fileName = Path.Combine(document, materijali.Naslov + materijali.TipFila);
                        File.WriteAllBytes(fileName, materijali.Materijal1);
                        await DisplayAlert("Materijal", "Materijal skinut", "Ok");
                    }

                }
            }

        }
    }
}