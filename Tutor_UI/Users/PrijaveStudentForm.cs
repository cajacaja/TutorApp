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
using Tutor_UI.Util;
using Tutor_API.Models;

namespace Tutor_UI.Users
{
    public partial class PrijaveStudentForm : Form
    {
        private WebAPIHelper banTutorService = new WebAPIHelper(Global.URI, Global.BanTutorRoute);
        public PrijaveStudentForm()
        {
            InitializeComponent();
            IzbrisiBtn.Enabled = false;
        }

        private void PrijaveStudentForm_Load(object sender, EventArgs e)
        {
            BindNeProcitano();
            BindProcitano();
        }


        private void BindProcitano()
        {
            HttpResponseMessage response = banTutorService.GetResponse();


            if (response.IsSuccessStatusCode)
            {
                var lstProcitanih = response.Content.ReadAsAsync<List<BanTutor_Select_Result>>().Result;
                lstProcitanih = lstProcitanih.Where(x => x.IsRead == true).ToList();

                ProcitanePrijaveGridView.DataSource = lstProcitanih;
                ProcitanePrijaveGridView.ClearSelection();
            }
        }

        private void BindNeProcitano()
        {
            HttpResponseMessage response = banTutorService.GetResponse();


            if (response.IsSuccessStatusCode)
            {
                var lstNeProcitanih = response.Content.ReadAsAsync<List<BanTutor_Select_Result>>().Result;
                lstNeProcitanih = lstNeProcitanih.Where(x => x.IsRead == false).ToList();

                NovePrijaveGridView.DataSource = lstNeProcitanih;
                NovePrijaveGridView.ClearSelection();
            }

        }

        private void PregledBtn_Click(object sender, EventArgs e)
        {
            int TutorId = 0;
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"] && NovePrijaveGridView.SelectedRows.Count != 0)
            {
                TutorId = Convert.ToInt32(NovePrijaveGridView.SelectedRows[0].Cells[0].Value);
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"] && ProcitanePrijaveGridView.SelectedRows.Count != 0)
            {
                TutorId = Convert.ToInt32(ProcitanePrijaveGridView.SelectedRows[0].Cells[0].Value);
            }

            var detalji = new StudentPrijaveDetailsForm(TutorId);
            detalji.Show();
            BindNeProcitano();
            BindProcitano();
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                IzbrisiBtn.Enabled = false;
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                IzbrisiBtn.Enabled = true;
            }
        }

        private void IzbrisiBtn_Click(object sender, EventArgs e)
        {
            if (ProcitanePrijaveGridView.SelectedRows.Count != 0)
            {
                int procitanaPrijava = Convert.ToInt32(ProcitanePrijaveGridView.SelectedRows[0].Cells[0].Value);
                var response = banTutorService.DeleteResponse(procitanaPrijava.ToString());

                if (response.IsSuccessStatusCode)
                {

                    MessageBox.Show("Uspjenos obrisana prijava");
                    BindProcitano();
                }

            }
        }
    }
}
