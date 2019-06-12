
using Newtonsoft.Json;
using PCL_tutor.Model;
using PCL_tutor.Util;
using PCLStorage;
using System;
using System.Collections.Generic;

using System.IO;

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
                        try {
                            var externalPath = "/storage/emulated/0/" + materijali.Naslov + materijali.TipFila;
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
                        catch (Exception exp)
                        {
                            await DisplayAlert("Error", "Aplikacija nema pristup vasim folderima.", "OK");

                        }
                    }
                    else if (Device.RuntimePlatform == Device.UWP)
                    {
                        //premoran koristit localapplicaitondata radi sandbox-a i premisija UWP-a pokusano je uradit se sa pickerima preko 
                        //restricted capability ali opet nije dalo dalje od ovvoga foldera tako da sam primoran da ovde sacuvam datoteke
                        //porbano je dodati premisije u Package.appxmanifest ali nije ni to pomoglo
                        try
                        {
                            IFolder folder = FileSystem.Current.LocalStorage;
                            
                            var fileName = Path.Combine(folder.Path, materijali.Naslov + materijali.TipFila);                

                            File.WriteAllBytes(fileName, materijali.Materijal1);

                          

                            await DisplayAlert("Materijal skinut", folder.Path, "Ok");


                        }
                        catch (Exception exp)
                        {
                           
                            await DisplayAlert("Error", "Aplikacija nema pristup vasim folderima.Molimo omogucite pristup", "OK");
                        }

                    }

                }
            }

        }
    }
}