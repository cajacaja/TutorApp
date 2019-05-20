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
using Tutor_UI.Resources;
using Tutor_UI.Util;

namespace Tutor_UI.Users.Tutor
{
    public partial class AddUcionicu : Form
    {
        private WebAPIHelper ucionicaService = new WebAPIHelper(Global.URI, Global.UcionicaRoute);
        private WebAPIHelper nivoTezineService = new WebAPIHelper(Global.URI, Global.NivoTezineRoute);


        byte[] NaslovnaSlika;
        BindingList<Termin> termini = new BindingList<Termin>();
        int tutorId = Global.prijavljeniTutor.TutorId;

        string[] dani = { "Ponedeljak", "Utorak", "Srijeda", "Cetvrtak", "Petak", "Subota", "Nedelja" };

        public AddUcionicu()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;           
            datumPocetkaDatePicker.Format = DateTimePickerFormat.Short;
            datumZavrsetkaDatePicker.Format = DateTimePickerFormat.Short;
            daniCmb.DataSource = dani;
            vrijemeInput.CustomFormat = "HH:mm";
            vrijemeInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            vrijemeInput.ShowUpDown = true;
            openFileDialog1.Filter = "Image Files (JPG,PNG,SVG)|*.JPG;*.PNG;*.SVG";
            BindTezinu();

        }

        private void BindTezinu()
        {
            var response = nivoTezineService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                var lstNivoa = response.Content.ReadAsAsync<List<NivoTezine>>().Result;
                nivoTezineCmb.DataSource = lstNivoa;
                nivoTezineCmb.DisplayMember = "Naziv";
                nivoTezineCmb.ValueMember = "NivoTezineId";

            }
        }

        private void naslovnaSlikaBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                slikaInput.Text = openFileDialog1.FileName;
               

                Image orignalImage = Image.FromFile(openFileDialog1.FileName);
                MemoryStream ms = new MemoryStream();
                orignalImage.Save(ms, ImageFormat.Jpeg);



                if (orignalImage.Width > naslovnaPictureBox.Width)
                {
                    Image resizedImage = UIHelper.ResizeImage(orignalImage, new Size(naslovnaPictureBox.Width, naslovnaPictureBox.Height));
                    naslovnaPictureBox.Image = resizedImage;
                    ms = new MemoryStream();
                    resizedImage.Save(ms, ImageFormat.Jpeg);
                    NaslovnaSlika = ms.ToArray();

                }
                else
                {
                    naslovnaPictureBox.Image = orignalImage;
                    NaslovnaSlika = ms.ToArray();
                }

            }
        }

        private void SnimiBtn_Click(object sender, EventArgs e)
        {
            Termin termin = new Termin()
            {
                Dan = daniCmb.Text,
                PocetakCasa = vrijemeInput.Value.ToString("HH:mm")
            };

            termini.Add(termin);

            BindTermin();
        }

        private void BindTermin()
        {

            terminiDataGridView.DataSource = termini;
            terminiDataGridView.ClearSelection();
        }

        private void ObrisiBtn_Click(object sender, EventArgs e)
        {
            termini.RemoveAt(termini.Count - 1);
            BindTermin();
        }

        private void BtnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                List<Termin> lstTermina = termini.ToList();
                Ucionica novaUcionica = new Ucionica()
                {
                    TutorId = tutorId,
                    Naslov = NaslovInput.Text,
                    Opis = opisInput.Text,
                    Slika = NaslovnaSlika,
                    AdresaUcionice = adresaInput.Text,
                    NivoTezineId = (int)nivoTezineCmb.SelectedValue,
                    Cijena = (double)CijenaInput.Value,
                    BrojCasova = (int)brojCasovaInput.Value,
                    MaxBrojPolaznika = (int)brojUcenikaInput.Value,
                    DatumPocetka = datumPocetkaDatePicker.Value,
                    DatumZavrsetka = datumZavrsetkaDatePicker.Value,
                    Termini = lstTermina
                };

                HttpResponseMessage response = ucionicaService.PostResponse(novaUcionica);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("ok");
                }
            }
        }

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
        private void NaslovInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Provjera(NaslovInput, Messeges.OnlyLetters_Regex);
        }

        private void opisInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(opisInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(opisInput, "Mora postojati opis ucenice.");

            }
           
        }

        private void adresaInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Provjera(adresaInput);
        }

        private void slikaInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Provjera(slikaInput);
        }

        private void CijenaInput_Validating(object sender, CancelEventArgs e)
        {
            if (CijenaInput.Value == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(CijenaInput, "Cijena ucionice ne moze biti 0KM.");
            }
            else errorProvider.SetError(CijenaInput, "");
        }

        private void brojCasovaInput_Validating(object sender, CancelEventArgs e)
        {
            if (brojCasovaInput.Value == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(brojCasovaInput, "Broj casova ne moze biti 0.");
            }
            else errorProvider.SetError(brojCasovaInput, "");
        }

        private void brojUcenikaInput_Validating(object sender, CancelEventArgs e)
        {
            if (brojUcenikaInput.Value == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(brojUcenikaInput, "Broj ucenika ne moze biti 0.");
            }
            else errorProvider.SetError(brojUcenikaInput, "");
        }

        private void terminiDataGridView_Validating(object sender, CancelEventArgs e)
        {
            if (termini.Count == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(terminiDataGridView, "Moraju biti odredjeni  termini");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(terminiDataGridView, "");
            }
        }
    }
}
