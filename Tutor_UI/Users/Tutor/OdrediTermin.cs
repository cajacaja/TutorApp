using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutor_API.Models;
using Tutor_UI.Util;

namespace Tutor_UI.Users.Tutor
{
    public partial class OdrediTermin : Form
    {
        private WebAPIHelper zahtjevService = new WebAPIHelper("Zahtjev");
        private WebAPIHelper terminCasaService = new WebAPIHelper("TerminCasa");

        int brojCasova = 0;
        int brojac = 0;

        private int IDzahtjeva = 0;
        public OdrediTermin(int zahtjevId)
        {
            IDzahtjeva = zahtjevId;
            InitializeComponent();
            TimePicker.CustomFormat = "HH:mm";
            TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            TimePicker.ShowUpDown = true;
            DatumCasaDatePicker.Format = DateTimePickerFormat.Short;

            BindForm(zahtjevId);
        }

        private void BindForm(int zahtjevId)
        {
            HttpResponseMessage response = zahtjevService.GetResponse(zahtjevId.ToString());

            if (response.IsSuccessStatusCode)
            {
                var zahtjev = response.Content.ReadAsAsync<Zahtjev>().Result;
                DatumCasaDatePicker.MinDate = zahtjev.DatumOd;
                DatumCasaDatePicker.MaxDate = zahtjev.DatumDo;

                TimePicker.Value= DateTime.Parse(zahtjev.VrijemeOd.ToString());
                TimePicker.MinDate = DateTime.Parse(zahtjev.VrijemeOd.ToString());
                TimePicker.MaxDate= DateTime.Parse(zahtjev.VrijemeDo.ToString());

                brojCasova = zahtjev.BrojCasova;

                TerminForm(zahtjevId);
            }
        }

        private void TerminForm(int zahtjevId)
        {
            HttpResponseMessage response = terminCasaService.GetResponse(zahtjevId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var lstTermina = response.Content.ReadAsAsync<List<TerminCasa>>().Result;
                brojac = lstTermina.Count;
                terminiGridView.DataSource = lstTermina;               
                terminiGridView.ClearSelection();

                BrojTerminaLabel.Text = string.Format("Broj termina:{0}/{1}", brojac, brojCasova);
            }
        }

        private void ZakaziBtn_Click(object sender, EventArgs e)
        {
            TerminCasa termin = new TerminCasa()
            {
                ZahtjevId = IDzahtjeva,
                DatumCasa = DatumCasaDatePicker.Value,
                VrijemePocetka = TimeSpan.Parse(TimePicker.Value.ToString("HH:mm")),
                DanNaziv = VratiDan(DatumCasaDatePicker.Value.ToString("dddd"))

            };

            var sacuvajTermin = terminCasaService.PostResponse(termin);
            if (sacuvajTermin.IsSuccessStatusCode) {

                TerminForm(IDzahtjeva);
            }

            
            if (brojac == brojCasova)
            {
                var response = zahtjevService.GetResponse(IDzahtjeva.ToString());
                if (response.IsSuccessStatusCode)
                {
                    var zahtjev = response.Content.ReadAsAsync<Zahtjev>().Result;
                    zahtjev.Prihvaceno = true;

                    var response2 = zahtjevService.PutResponse(IDzahtjeva, zahtjev);
                    if (response2.IsSuccessStatusCode)
                    {
                        
                        StudentKontakInfoForm kontakInfo = new StudentKontakInfoForm(zahtjev.StudentId);
                        kontakInfo.ShowDialog();
                        kontakInfo.MdiParent = this.MdiParent;
                        ZakaziBtn.Enabled = false;
                        this.ControlBox = true;
                       
                        
                    }
                }
            }
        }

        private string VratiDan(string danEng) {

            string dan="";
            switch (danEng)
            {
                case "Monday":
                    dan = "Ponedeljak";
                    break;
                case "Tuesday":
                    dan = "Utorak";
                    break;
                case "Wednesday":
                    dan = "Srijeda";
                    break;
                case "Thursday":
                    dan = "Cetvrtak";
                    break;
                case "Friday":
                    dan = "Petak";
                    break;
                case "Saturday":
                    dan = "Subota";
                    break;
                case "Sunday":
                    dan = "Nedelja";
                    break;
                default:
                    dan = "Nista";
                    break;
            }


            return dan;
        }

        
    }
}
