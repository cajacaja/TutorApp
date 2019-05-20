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
    public partial class CasZahtjeviForm : Form
    {
        private WebAPIHelper zahtjevService = new WebAPIHelper(Global.URI, Global.ZahtjevRoute);
        private WebAPIHelper terminService = new WebAPIHelper(Global.URI, Global.TerminCasaRoute);

        private int TutorId = 5;//Global.prijavljeniTutor.TutorId;

        public CasZahtjeviForm()
        {
            InitializeComponent();

            var response = terminService.GetActionResponse("DeleteTermine",TutorId.ToString());

            BindNeprocitano();
            BindTermine();
        }

        private void BindTermine()
        {
            HttpResponseMessage response = terminService.GetActionResponse("AcceptedTermini", TutorId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var lstTermina = response.Content.ReadAsAsync<List<TerminCas_SelectTermins_Result>>().Result;
                lstTermina = lstTermina.OrderBy(x => x.DatumCasa).ToList();
                terminiGridView.DataSource = lstTermina;
                terminiGridView.ClearSelection();
            }
        }

        private void BindNeprocitano()
        {
            HttpResponseMessage response = zahtjevService.GetActionResponse("UnreadZahtjev", TutorId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var lstZahtjeva = response.Content.ReadAsAsync<List<Zahtjev_SelectUnread_Result>>().Result;
                neProcitanoGridView.DataSource = lstZahtjeva;
                neProcitanoGridView.ClearSelection();
            }
        }

        private void OdbijBtn_Click(object sender, EventArgs e)
        {
            if (zahtjeviTerminiTabControl.SelectedTab == zahtjeviTerminiTabControl.TabPages["tabPage1"])
            {
                if (neProcitanoGridView.SelectedRows.Count != 0)
                {
                    int ZahtjevId = Convert.ToInt32(neProcitanoGridView.SelectedRows[0].Cells[0].Value);
                    var response = zahtjevService.GetResponse(ZahtjevId.ToString());
                    if (response.IsSuccessStatusCode)
                    {
                        var zahtjev = response.Content.ReadAsAsync<Zahtjev>().Result;
                        zahtjev.Odbijeno = true;

                        var response2 = zahtjevService.PutResponse(ZahtjevId, zahtjev);
                        if (response2.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Zahtjev odbijen");
                        }
                    }
                }
                    
               
            }
        }

        private void PregledBtn_Click(object sender, EventArgs e)
        {
            if (zahtjeviTerminiTabControl.SelectedTab == zahtjeviTerminiTabControl.TabPages["tabPage1"])
            {
                if (neProcitanoGridView.SelectedRows.Count != 0)
                {
                    int ZahtjevId = Convert.ToInt32(neProcitanoGridView.SelectedRows[0].Cells[0].Value);
                    StudentZahtjevForm zahtjev = new StudentZahtjevForm(ZahtjevId);
                    zahtjev.Show();
                    zahtjev.MdiParent = this.MdiParent;
                }


            }

            if (zahtjeviTerminiTabControl.SelectedTab == zahtjeviTerminiTabControl.TabPages["tabPage2"])
            {
                if (terminiGridView.SelectedRows.Count != 0)
                {
                    int StudentId = Convert.ToInt32(terminiGridView.SelectedRows[0].Cells[0].Value);
                    StudentKontakInfoForm kontakInfo = new StudentKontakInfoForm(StudentId);
                    kontakInfo.Show();
                    kontakInfo.MdiParent = this.MdiParent;
                }
                
            }
        }

        private void zahtjeviTerminiTabControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (zahtjeviTerminiTabControl.SelectedTab == zahtjeviTerminiTabControl.TabPages["tabPage1"])
            {
                OdbijBtn.Visible = true;
            }
            else if (zahtjeviTerminiTabControl.SelectedTab == zahtjeviTerminiTabControl.TabPages["tabPage2"])
            {
                OdbijBtn.Visible = false;
            }
        }
    }
}
