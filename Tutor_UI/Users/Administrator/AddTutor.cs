﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutor_API.Models;
using Tutor_UI.Util;

namespace Tutor_UI.Users
{
    public partial class AddTutor : Form
    {
        private WebAPIHelper spolService = new WebAPIHelper("Spol");
        private WebAPIHelper gradService = new WebAPIHelper("Grad");
        private WebAPIHelper radnostanjeService = new WebAPIHelper("RadnoStanje");
        private WebAPIHelper predmetService = new WebAPIHelper( "Podkategorija");
        private WebAPIHelper tipStudentaService = new WebAPIHelper("TipStudenta");
        private WebAPIHelper titulaService = new WebAPIHelper("TutorTitula");
        private WebAPIHelper tutorService = new WebAPIHelper("Tutor");
        private WebAPIHelper studentService = new WebAPIHelper("Student");

        private byte[] Slika1;
        private byte[] Slika2;
        private byte[] Slika3;

        public AddTutor()
        {

            
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            openFileDialog1.Filter = "Image Files (JPG,PNG,SVG)|*.JPG;*.PNG;*.SVG";
            openFileDialog2.Filter = "Image Files (JPG,PNG,SVG)|*.JPG;*.PNG;*.SVG";
            DatumRodjenjaDP.Format= DateTimePickerFormat.Short;
        }



        private  void BindGrad()
        {
            HttpResponseMessage response =gradService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                var gradovi = response.Content.ReadAsAsync<List<Grad>>().Result;
                gradovi.Insert(0, new Grad() {Naziv="Odaberite grad"});
                GradCmb.DataSource = gradovi.ToList();
                GradCmb.DisplayMember = "Naziv";
                GradCmb.ValueMember = "GradId";
            }
        }

        private void BindSpol()
        {
            HttpResponseMessage response = spolService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                var lstSpol = response.Content.ReadAsAsync<List<Spol>>().Result;
                lstSpol.Insert(0,new Spol() { Naziv="Odaberite spol"});
                SpolCmb.DataSource = lstSpol;
                SpolCmb.DisplayMember = "Naziv";
                SpolCmb.ValueMember = "SpolId";
            }
        }

        private  void AddTutor_Load(object sender, EventArgs e)
        {
            BindSpol();
            BindZaposlenost();
            BindPredmet();
            BindObim();
            BindTitula();

             BindGrad();

        }
        #region Form setup
        private void BindObim()
        {
            HttpResponseMessage response =tipStudentaService.GetResponse();
            if (response.IsSuccessStatusCode)
            {

                ObimListBox.DataSource = response.Content.ReadAsAsync<List<TipStudenta>>().Result;
                ObimListBox.DisplayMember = "Naziv";
                ObimListBox.ClearSelected();
            }
        }

        private void BindPredmet()
        {
            HttpResponseMessage response =predmetService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
               
                var lstPredmeta = response.Content.ReadAsAsync<List<Podkategorija>>().Result;
                lstPredmeta.Insert(0, new Podkategorija() { Naziv = "Odaberite predmet" });
                PredmetCmb.DataSource = lstPredmeta;
                PredmetCmb.DisplayMember = "Naziv";
                PredmetCmb.ValueMember = "PodkategorijaId";
            }
        }

        private void BindTitula()
        {
            HttpResponseMessage response = titulaService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                var lstTitula= response.Content.ReadAsAsync<List<TutorTitula>>().Result;
                lstTitula.Insert(0,new TutorTitula() { Naziv="Odaberite titulu"});
                TitulaCmb.DataSource = lstTitula;
                TitulaCmb.DisplayMember = "Naziv";
                TitulaCmb.ValueMember = "TutorTitulaId";
            }
        }

        private void BindZaposlenost()
        {
            HttpResponseMessage response =radnostanjeService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                var lstZaposlenosti= response.Content.ReadAsAsync<List<RadnoStanje>>().Result;
                lstZaposlenosti.Insert(0, new RadnoStanje() { Naziv = "Odaberite radno stanje" });
                ZaposlenostiCmb.DataSource = lstZaposlenosti;
                ZaposlenostiCmb.DisplayMember = "Naziv";
                ZaposlenostiCmb.ValueMember = "RadnoStanjeId";
            }
        }
        #endregion

        private void SnimiBtn_Click(object sender, EventArgs e)
        {


            if (this.ValidateChildren())
            {




                Tutor_API.Models.Tutor noviTutor = new Tutor_API.Models.Tutor()
                {
                    Ime = ImeInput.Text,
                    Prezime = PrezimeInput.Text,
                    Telefon = TelefonInput.Text,
                    NazivUstanove = NazivObjektaInput.Text,
                    SpolId = (int)SpolCmb.SelectedValue,
                    Adresa = AdresaInput.Text,
                    Email = EmailInput.Text,
                    GradId = (int)GradCmb.SelectedValue,
                    RadnoStanjeId = (int)ZaposlenostiCmb.SelectedValue,
                    TutorTitulaId = (int)TitulaCmb.SelectedValue,
                    PodKategorijaId = (int)PredmetCmb.SelectedValue,
                    TipStudenta = ObimListBox.CheckedItems.Cast<TipStudenta>().ToList(),
                    KorisnickoIme = KorisnickoImeInput.Text,
                    CijenaCasa = (double)CijenaInput.Value,
                    DatumRodjenja = DatumRodjenjaDP.Value,
                    LozinkaSalt = UIHelper.GenerateSalt(),
                    TutorSlika = Slika1,
                    TutorTumbnail = Slika2,
                    SlikaOdobrenja = Slika3,
                    StatusKorisnickoRacunaId = 1

                };
                noviTutor.LozinkaHash = UIHelper.GenerateHash(noviTutor.LozinkaSalt, LozinkaInput.Text);

                HttpResponseMessage response = tutorService.PostResponse(noviTutor);
                if (response.IsSuccessStatusCode)
                {

                    MessageBox.Show("Uspjenso dodan tutor!");
                    this.Close();
                }
                else
                {



                    var errorMessage = Global.ErrorFinder(response.Content.ReadAsStringAsync().Result);

                    if (!String.IsNullOrEmpty(Messeges.ResourceManager.GetString(errorMessage)))
                        errorMessage = Messeges.ResourceManager.GetString(errorMessage);

                    MessageBox.Show(errorMessage);
                }

            }
        }

        private void SlikaBtn_Click(object sender, EventArgs e)
        {
           

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SlikaTutorInput.Text = openFileDialog1.FileName;
                string ext = Path.GetExtension(openFileDialog1.FileName);

                Image orignalImage = Image.FromFile(openFileDialog1.FileName);
                MemoryStream ms = new MemoryStream();
                orignalImage.Save(ms, ImageFormat.Jpeg);

                int resizedImageWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImageWidth"]);
                int resizedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImageHeight"]);
                int cropedImageWidth = Convert.ToInt32(ConfigurationManager.AppSettings["cropedImageWidth"]);
                int cropedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["cropedImageHeight"]);

                if (orignalImage.Width > resizedImageWidth)
                {
                    Image resizedImage = UIHelper.ResizeImage(orignalImage, new Size(resizedImageWidth, resizedImageHeight));
                    Image cropedImage = resizedImage;
                    resizedImage.Save(ms, ImageFormat.Jpeg);
                    Slika1 = ms.ToArray();

                    if (resizedImageWidth >= cropedImageWidth && resizedImageHeight >= cropedImageHeight)
                    {
                        int croppedXPosition = (resizedImageWidth - cropedImageWidth) / 2;
                        int croppedYPosition = 20;

                        cropedImage = UIHelper.CropImage(resizedImage, new Rectangle(croppedXPosition, croppedYPosition,
                                                        cropedImageWidth - croppedXPosition,
                                                        cropedImageHeight - croppedYPosition));

                        ms = new MemoryStream();
                        cropedImage.Save(ms, ImageFormat.Jpeg);
                        Slika2 = ms.ToArray();

                        pictureBox.Image = cropedImage;
                    }

                }
            }
        }

        private void DokazBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                SlikaDokazInput.Text = openFileDialog2.FileName;

                Image orignalImage = Image.FromFile(openFileDialog2.FileName);
                MemoryStream ms = new MemoryStream();
                orignalImage.Save(ms, ImageFormat.Jpeg);

                int resizedImageWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImageWidth"]);
                int resizedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImageHeight"]);

                if (orignalImage.Width > resizedImageWidth)
                {

                    Image resizedImage = UIHelper.ResizeImage(orignalImage, new Size(resizedImageWidth, resizedImageHeight));
                    resizedImage.Save(ms, ImageFormat.Jpeg);
                    Slika3 = ms.ToArray();

                }


            }
        }

        #region Validation

        private bool Provjera(TextBox text, string regex = "")
        {



            var provjera = Global.TextInputProvjera(text.Text, regex);
            if (!provjera.Item1)
            {
                errorProvider.SetError(text, provjera.Item2);
                return true;
            }
            else
            {
                errorProvider.SetError(text, "");
            }

            return false;
        }

        private void ImeInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Provjera(ImeInput, Messeges.OnlyLetters_Regex);
        }

        private void PrezimeInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Provjera(PrezimeInput, Messeges.OnlyLetters_Regex);
        }

        private void TelefonInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.Match(TelefonInput.Text, Messeges.Error_Phone).Success)
            {
                e.Cancel = true;
                errorProvider.SetError(TelefonInput, Messeges.Error_Format);
            }
            else
            {
                errorProvider.SetError(TelefonInput, "");
            }
        }

        private void EmailInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Provjera(EmailInput, Messeges.Email_Regex);
        }

        private void AdresaInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Provjera(AdresaInput);
        }

        private void ObimListBox_Validating(object sender, CancelEventArgs e)
        {
            if (ObimListBox.CheckedItems.Count == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(ObimListBox, "Odaberite zeljene studente!");
            }
            else errorProvider.SetError(ObimListBox, "");
        }

        private void CijenaInput_Validating(object sender, CancelEventArgs e)
        {
            if (CijenaInput.Value == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(CijenaInput, "Cijena casa ne moze biti 0KM.");
            }
            else errorProvider.SetError(CijenaInput, "");//<---It's readable.

        }

        private void KorisnickoImeInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Provjera(KorisnickoImeInput);
        }

        private void LozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Provjera(LozinkaInput);
        }

        private void SlikaTutorInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Provjera(SlikaTutorInput);
          
        }

        private void SlikaDokazInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Provjera(SlikaDokazInput);
        }

        #endregion

        private void DatumRodjenjaDP_Validating(object sender, CancelEventArgs e)
        {
            var Danas = DateTime.Today;
            var dob = Danas.Year - DatumRodjenjaDP.Value.Year;

            if (DatumRodjenjaDP.Value > Danas.AddYears(-dob)) dob--;

            if (dob < 18) {
                e.Cancel = true;
                errorProvider.SetError(DatumRodjenjaDP, "Tutor mora biti 18 ili preko.");
            }
            else errorProvider.SetError(DatumRodjenjaDP, "");
        }

        private void SpolCmb_Validating(object sender, CancelEventArgs e)
        {
            if (SpolCmb.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(SpolCmb, "Izaberite spol tutora");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(SpolCmb, "");
            }
        }

        private void GradCmb_Validating(object sender, CancelEventArgs e)
        {
            if (GradCmb.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(GradCmb, "Izaberite grad tutora");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(GradCmb, "");
            }
        }

        private void ZaposlenostiCmb_Validating(object sender, CancelEventArgs e)
        {
            if (ZaposlenostiCmb.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(ZaposlenostiCmb, "Odredite stanje zaposlenosti");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(ZaposlenostiCmb, "");
            }
        }

        private void TitulaCmb_Validating(object sender, CancelEventArgs e)
        {
            if (TitulaCmb.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(TitulaCmb, "Odredite titulu tutora.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(TitulaCmb, "");
            }
        }

        private void PredmetCmb_Validating(object sender, CancelEventArgs e)
        {
            if (PredmetCmb.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(PredmetCmb, "Odaberite predmet tutora");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(PredmetCmb, "");
            }
        }
    }
}
