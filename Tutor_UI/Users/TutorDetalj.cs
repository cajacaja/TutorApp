using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutor_API.Models;
using Tutor_UI.Util;

namespace Tutor_UI.Users
{
    public partial class TutorDetalj : Form
    {
        private WebAPIHelper tutorService = new WebAPIHelper(Global.URI, Global.TutorRoute);
        private WebAPIHelper tipService = new WebAPIHelper(Global.URI, Global.TipStudentaRoute);
        //private WebAPIHelper zahtjevService = new WebAPIHelper(Global.URI, Global.ZahtjevRoute);
        private WebAPIHelper ocjenaTutorService = new WebAPIHelper(Global.URI, Global.OcjenaTutorRoute);
        private WebAPIHelper ucionicaService = new WebAPIHelper(Global.URI, Global.UcionicaRoute);

        private Tutor_Details_Result Tutor;

        public TutorDetalj(int id)
        {
            InitializeComponent();

           

            var response = tutorService.GetActionResponse("TutorDetails", id.ToString());
            if (response.IsSuccessStatusCode)
            {
                Tutor = response.Content.ReadAsAsync<Tutor_Details_Result>().Result;
                var ms = new MemoryStream(Tutor.TutorTumbnail);
                tutorPictureBox.Image = Image.FromStream(ms);
                ImeInput.Text = Tutor.Ime;
                PrezimeInput.Text = Tutor.Prezime;
                EmailInput.Text = Tutor.Email;
                TelefonInput.Text = Tutor.Telefon;
                AdresaInput.Text = Tutor.Adresa;
                KorisnickoImeInput.Text = Tutor.KorisnickoIme;
                PredmetInput.Text = Tutor.Predmet;
                CijenaCasaInput.Text = Tutor.CijenaCasa.ToString() +" KM";
                RadnoStanjeInput.Text = Tutor.RadnoStanje;
                NazivUstanoveInput.Text = Tutor.NazivUstanove;
                FillList(id);
                BindGridOne(id);
                BindGridTwo(id);
                UpisiOcjenu(id);

                ProvjeriStatsuKorisnika(id);

                

            }
            else
            {
                MessageBox.Show("Pogresan tutor");
            }
        }

        private void ProvjeriStatsuKorisnika(int id)
        {
            var response = tutorService.GetResponse(id.ToString());
            var Tutor = response.Content.ReadAsAsync<Tutor>().Result;

            if (Tutor.StatusKorisnickoRacunaId == 3)
            {
                BanBtn.Visible = false;
                UnbanBtn.Visible = true;
            }
            else
            {
                BanBtn.Visible = true;
                UnbanBtn.Visible = false;
            }
        }

        private void UpisiOcjenu(int id)
        {
            var response = ocjenaTutorService.GetActionResponse("OcjenaAvg",id.ToString());
            if (response.IsSuccessStatusCode)
            {
               var ocjenaAvg = response.Content.ReadAsAsync<double>().Result;
                ocjenaInput.Text = ocjenaAvg.ToString();
            }
        }

        private void BindGridTwo(int id)
        {
            var response = ucionicaService.GetActionResponse("TutorUcionice",id.ToString());

            if (response.IsSuccessStatusCode)
            {
                var listaUcionica = response.Content.ReadAsAsync<List<Ucionica_SelectTutorUcionica_Result>>().Result;
                UcioniceDataGrid.DataSource = listaUcionica;
                UcioniceDataGrid.ClearSelection();
            }
        }

        private void BindGridOne(int id)
        {
            var response = ocjenaTutorService.GetActionResponse("TutorReview", id.ToString());
            if (response.IsSuccessStatusCode)
            {   
                var listaReviews= response.Content.ReadAsAsync<List<Tutor_ReviewsSelect_Result>>().Result;
                CasoviDataGrid.DataSource = listaReviews;
                CasoviDataGrid.ClearSelection();

            }
            
        }

        private void FillList(int id)
        {
            var response = tipService.GetResponse(id.ToString());
            if (response.IsSuccessStatusCode)
            {
                obimListBox.DataSource = response.Content.ReadAsAsync<List<Oblast_select_Result>>().Result;
                obimListBox.DisplayMember = "Naziv";
                for (int i = 0; i < obimListBox.Items.Count; i++)
                {
                    obimListBox.SetItemChecked(i, true);
                }

                obimListBox.SelectionMode = SelectionMode.None;
               
            }
        }

        private void TutorDetalj_Load(object sender, EventArgs e)
        {

        }

        private void PrikazBtn_Click(object sender, EventArgs e)
        {
            TutotrDokaz slika = new TutotrDokaz(Tutor.TutorId);
            slika.Show();
        }

        private void CijenaCasaInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void BanBtn_Click(object sender, EventArgs e)
        {
            PromjeniStatus();
            ProvjeriStatsuKorisnika(Tutor.TutorId);
        }

        private void UnbanBtn_Click(object sender, EventArgs e)
        {
            PromjeniStatus();
            ProvjeriStatsuKorisnika(Tutor.TutorId);
        }


        private void PromjeniStatus()
        {
            var response = tutorService.GetResponse(Tutor.TutorId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var tutor = response.Content.ReadAsAsync<Tutor>().Result;
                if (tutor.StatusKorisnickoRacunaId != 3)
                {
                    tutor.StatusKorisnickoRacunaId = 3;
                    var response2 = tutorService.PutResponse(Tutor.TutorId, tutor);
                    if (response2.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Tutor banovan!");
                        ProvjeriStatsuKorisnika(tutor.TutorId);
                    }
                }
                else
                {
                    tutor.StatusKorisnickoRacunaId = 1;
                    var response2 = tutorService.PutResponse(Tutor.TutorId, tutor);
                    if (response2.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Tutor unbanovan!");
                        ProvjeriStatsuKorisnika(tutor.TutorId);//Nesto ne radi kako treba ovde si stao!!!
                    }
                }


            }          

        }
    }
}
