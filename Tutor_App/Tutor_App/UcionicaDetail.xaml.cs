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
	public partial class UcionicaDetail : ContentPage
	{
        private WebApiHelper ucionicaService = new WebApiHelper("http://192.168.0.102", "api/Ucionica");
        int idUcionice = 0;
        public UcionicaDetail (int UcionicaId)
		{
            idUcionice = UcionicaId;
            InitializeComponent ();
            LoadForm();
        }

        private void LoadForm()
        {
            HttpResponseMessage response = ucionicaService.GetActionResponse("UcionicaDetails", idUcionice.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jasonObject = response.Content.ReadAsStringAsync();
                var ucionica = JsonConvert.DeserializeObject<Ucionica>(jasonObject.Result);
                //popuni podatke


                response = ucionicaService.GetActionResponse("Termini", idUcionice.ToString());
                jasonObject = response.Content.ReadAsStringAsync();
                var termini = JsonConvert.DeserializeObject<List<Termin>>(jasonObject.Result);
                //popuni podatke



            }
        }
    }
}