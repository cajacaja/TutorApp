using PCL_tutor.Model;
using PCL_tutor.Util;
using Rg.Plugins.Popup.Services;
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
	public partial class OcjeniPage : Rg.Plugins.Popup.Pages.PopupPage
    {
        private WebApiHelper ocjeneService = new WebApiHelper("OcjenaTutor");
        private int[] ocjene = { 1, 2, 3, 4, 5 };
        private int idTutora = 0;

      
        public OcjeniPage (int tutorId)
		{
			InitializeComponent ();
            idTutora = tutorId;
            ocjenaPiker.ItemsSource = ocjene;
		}

        private void OcjeniBtn_Clicked(object sender, EventArgs e)
        {
            if (ocjenaPiker.SelectedItem != null)
            {
                OcjenaTutor ocjena = new OcjenaTutor()
                {
                    TutorId=idTutora,
                    StudentId=Global.prijavljeniStudent.StudentId,
                    Komentar= Komentar.Text,
                    Ocjena=Convert.ToInt32(ocjenaPiker.SelectedItem),
                    Datum=DateTime.Today
                    
                };

                HttpResponseMessage response = ocjeneService.PostResponse(ocjena);
                MessagingCenter.Send<App>((App)Application.Current, "OcjeniBtn_Clicked");
                PopupNavigation.Instance.PopAsync(true);
            }
        }
    }
}