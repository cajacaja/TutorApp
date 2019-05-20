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

namespace Tutor_UI.Users.Tutor
{
    public partial class UcionicaEdit : Form
    {
        private WebAPIHelper ucionicaService = new WebAPIHelper(Global.URI, Global.UcionicaRoute);
        private WebAPIHelper nivoTezineService = new WebAPIHelper(Global.URI, Global.NivoTezineRoute);
        private WebAPIHelper terminiService = new WebAPIHelper(Global.URI, Global.TerminUcionicaRoute);
        byte[] NaslovnaSlika;
        Ucionica editovanaUcionica = new Ucionica();
        int tutorId = Global.prijavljeniTutor.TutorId;
        int idUcionice = 0;

        string[] dani = { "Ponedeljak", "Utorak", "Srijeda", "Cetvrtak", "Petak", "Subota", "Nedelja" };

        public UcionicaEdit(int ucionicaId)
        {
            idUcionice = ucionicaId;
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
            BindForm(ucionicaId);
        }

        private void BindForm(int ucionicaId)
        {
            HttpResponseMessage response = ucionicaService.GetResponse(ucionicaId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var ucionica = response.Content.ReadAsAsync<Ucionica>().Result;

                NaslovInput.Text = ucionica.Naslov;
                MemoryStream ms = new MemoryStream(ucionica.Slika);
                NaslovnaSlika = ms.ToArray();
                naslovnaPictureBox.Image = Image.FromStream(ms);
                opisInput.Text = ucionica.Opis;
                datumPocetkaDatePicker.Value = ucionica.DatumPocetka; ;
                datumZavrsetkaDatePicker.Value = ucionica.DatumZavrsetka;
                adresaInput.Text = ucionica.AdresaUcionice;
                nivoTezineCmb.SelectedValue = ucionica.NivoTezineId;
                CijenaInput.Value = (decimal)ucionica.Cijena;
                brojCasovaInput.Value = ucionica.BrojCasova;
                brojUcenikaInput.Value = ucionica.MaxBrojPolaznika;

                BindTermine(ucionicaId);

                editovanaUcionica = ucionica;

            }
        }

        private void BindTermine(int ucionicaId)
        {

            HttpResponseMessage response = terminiService.GetActionResponse("Termini", ucionicaId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var lstTermina = response.Content.ReadAsAsync<List<Termin>>().Result;
                terminiDataGridView.DataSource = lstTermina;
                terminiDataGridView.ClearSelection();
            }

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

        private void SnimiBtn_Click(object sender, EventArgs e)
        {
            Termin termin = new Termin()
            {
                UcionicaId = idUcionice,
                Dan = daniCmb.Text,
                PocetakCasa = vrijemeInput.Value.ToString("HH:mm")
            };

            var response = terminiService.PostResponse(termin);
            if (response.IsSuccessStatusCode)
            {
                BindTermine(idUcionice);
            }
        }

        private void ObrisiBtn_Click(object sender, EventArgs e)
        {
            if (terminiDataGridView.SelectedRows.Count != 0)
            {
                int TerminId = Convert.ToInt32(terminiDataGridView.SelectedRows[0].Cells[0].Value);
                var response = terminiService.DeleteResponse(TerminId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    BindTermine(idUcionice);
                }
            }
        }

        private void BtnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                editovanaUcionica.Naslov = NaslovInput.Text;
                editovanaUcionica.Slika = NaslovnaSlika;
                editovanaUcionica.Opis = opisInput.Text;
                editovanaUcionica.AdresaUcionice = adresaInput.Text;
                editovanaUcionica.NivoTezineId = (int)nivoTezineCmb.SelectedValue;
                editovanaUcionica.DatumPocetka = datumPocetkaDatePicker.Value;
                editovanaUcionica.DatumZavrsetka = datumZavrsetkaDatePicker.Value;
                editovanaUcionica.Cijena = (double)CijenaInput.Value;
                editovanaUcionica.BrojCasova = (int)brojCasovaInput.Value;
                editovanaUcionica.MaxBrojPolaznika = (int)brojUcenikaInput.Value;

                var response = ucionicaService.PutResponse(idUcionice, editovanaUcionica);
                if (response.IsSuccessStatusCode)
                {
                    this.Close();
                }
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
            if (terminiDataGridView.RowCount == 0)
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
