using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class UcionicaDetails : Form
    {
        private WebAPIHelper ucionicaService = new WebAPIHelper(Global.URI, Global.UcionicaRoute);
        private int TutorId = 0;
        public UcionicaDetails(int UcionicaId)
        {
            InitializeComponent();
            BindDetails(UcionicaId);
            BindUcenici(UcionicaId);
        }

        private void BindUcenici(int ucionicaId)
        {
            var response = ucionicaService.GetActionResponse("StudentiUcionice", ucionicaId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var lstUcecnika = response.Content.ReadAsAsync<List<Ucionica_SelectUcenici_Result>>().Result;
                uceniciGridView.DataSource = lstUcecnika;
                uceniciGridView.ClearSelection();
            }
        }

        private void BindDetails(int ucionicaId)
        {
            HttpResponseMessage response = ucionicaService.GetActionResponse("UcionicaDetails", ucionicaId.ToString());
            if (response.IsSuccessStatusCode) {

               
                var ucionica = response.Content.ReadAsAsync<Ucionica_Details_Result>().Result;
                TutorId = ucionica.TutorId;
                NaslovLabel.Text = ucionica.Naslov;

                var ms = new MemoryStream(ucionica.Slika);
                Image orignalImage = Image.FromStream(ms);

                if (orignalImage.Width > ucionicaPictureBox.Width*2)
                {
                    Image resizedImage = UIHelper.ResizeImage(orignalImage, new Size(ucionicaPictureBox.Width, ucionicaPictureBox.Height));
                    
                    ucionicaPictureBox.Image = resizedImage;
                }


                opisInput.Text = ucionica.Opis;
                datumPocetkaInput.Text = ucionica.DatumPocetka.ToShortDateString();
                datumZavrsetkaInput.Text = ucionica.DatumZavrsetka.ToShortDateString();
                TutorInput.Text = ucionica.Tutor;
                predmetInput.Text = ucionica.Predmet;
                GradInput.Text = ucionica.Grad;
                adresaInput.Text = ucionica.AdresaUcionice;
                CijenaInput.Text = ucionica.Cijena.ToString();
                maxBrUcenikaInput.Text = ucionica.MaxBrojPolaznika.ToString();
                tezinaInput.Text = ucionica.Tezina;
                brojCasovaInput.Text = ucionica.BrojCasova.ToString();
            }
        }

        private void TutorInput_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TutorDetalj tutor = new TutorDetalj(TutorId);
            tutor.Show();
            tutor.MdiParent = this.MdiParent;
        }
    }
}
