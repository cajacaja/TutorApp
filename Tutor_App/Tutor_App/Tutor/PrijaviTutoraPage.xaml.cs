using PCL_tutor.Model;
using PCL_tutor.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutor_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrijaviTutoraPage : Rg.Plugins.Popup.Pages.PopupPage
    {
        private WebApiHelper prijavaService = new WebApiHelper("BanPrijavaStudent");
        private int idTutora = 0;
		public PrijaviTutoraPage (int tutorId)
		{
            idTutora = tutorId;
			InitializeComponent ();
		}

        private void PrijaviBtn_Clicked(object sender, EventArgs e)
        {
            PrijavaTutora prijave = new PrijavaTutora()
            {
                TutorId = idTutora,
                StudentId = Global.prijavljeniStudent.StudentId,
                RazlogPrijave=razlogInput.Text,
                DatumPrijave=DateTime.Now,
                IsRead=false
            };

            HttpResponseMessage response = prijavaService.PostResponse(prijave);
            if (response.IsSuccessStatusCode)
            {

                PopupNavigation.Instance.PopAsync(true);
            }
        }

       

    }
}