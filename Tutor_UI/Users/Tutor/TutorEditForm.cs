using System;
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

namespace Tutor_UI.Users.Tutor
{
    public partial class TutorEditForm : Form
    {
        private WebAPIHelper tutorService = new WebAPIHelper("Tutor");
        private WebAPIHelper tipService = new WebAPIHelper("TipStudenta");

        private WebAPIHelper gradService = new WebAPIHelper("Grad");
        private WebAPIHelper radnostanjeService = new WebAPIHelper("RadnoStanje");
        private WebAPIHelper predmetService = new WebAPIHelper("Podkategorija");
        private WebAPIHelper titulaService = new WebAPIHelper("TutorTitula");

        private Tutor_UpdateSelect_Result tutorUpdate;

        private byte[] SlikaPrava;
        private byte[] SlikaTumbnail;

        private Tutor_API.Models.Tutor tutor;

        public TutorEditForm(int tutorId)
        {
            InitializeComponent();
            tutor = new Tutor_API.Models.Tutor();
            this.AutoValidate = AutoValidate.Disable;
            openFileDialog1.Filter = "Image Files (JPG,PNG,SVG)|*.JPG;*.PNG;*.SVG";

            BindTutor(tutorId);

        }

        private void BindTutor(int tutorId)
        {
            var response = tutorService.GetActionResponse("SelectOne", tutorId.ToString());
            if (response.IsSuccessStatusCode)
            {
                tutorUpdate = response.Content.ReadAsAsync<Tutor_UpdateSelect_Result>().Result;
                EmailInput.Text = tutorUpdate.Email;
                TelefonInput.Text = tutorUpdate.Telefon;
                AdresaInput.Text = tutorUpdate.Adresa;
                NazivObjektaInput.Text = tutorUpdate.NazivUstanove;
                CijenaInput.Value =(decimal)tutorUpdate.CijenaCasA;
                var ms = new MemoryStream(tutorUpdate.TutorTumbnail);
                tutorPictureBox.Image = Image.FromStream(ms);

                SlikaTumbnail = tutorUpdate.TutorTumbnail;
                SlikaPrava = tutorUpdate.TutorSlika;

                BindGrad(tutorUpdate.GradId);
                BindZaposelonst(tutorUpdate.RadnoStanjeId);
                BindTitula(tutorUpdate.TutorTitulaId);
                BindPredmet(tutorUpdate.PodKategorijaId);
                BindObim(tutorId);
            }
        }

        private void BindPredmet(int podKategorijaId)
        {
            HttpResponseMessage response = predmetService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                //Promjeni ime u PredmetCmb
                PredmetCmb.DataSource = response.Content.ReadAsAsync<List<Podkategorija>>().Result;
                PredmetCmb.DisplayMember = "Naziv";
                PredmetCmb.ValueMember = "PodkategorijaId";

                PredmetCmb.SelectedValue = podKategorijaId;
            }
        }

        private void BindTitula(int tutorTitulaId)
        {
            HttpResponseMessage response = titulaService.GetResponse();
            if (response.IsSuccessStatusCode)
            {

                TitulaCmb.DataSource = response.Content.ReadAsAsync<List<TutorTitula>>().Result;
                TitulaCmb.DisplayMember = "Naziv";
                TitulaCmb.ValueMember = "TutorTitulaId";

                TitulaCmb.SelectedValue = tutorTitulaId;
            }
        }

        private void BindGrad(int gradId)
        {
            HttpResponseMessage response = gradService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                var lstGradova = response.Content.ReadAsAsync<List<Grad>>().Result;
                GradCmb.DataSource = lstGradova.ToList();
                GradCmb.DisplayMember = "Naziv";
                GradCmb.ValueMember = "GradId";

                GradCmb.SelectedValue = gradId;
            }
        }

        private void BindZaposelonst(int radnoStanjeId)
        {
            HttpResponseMessage response = radnostanjeService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                //Promjeni ime u PredmetCmb
                ZaposlenostiCmb.DataSource = response.Content.ReadAsAsync<List<RadnoStanje>>().Result;
                ZaposlenostiCmb.DisplayMember = "Naziv";
                ZaposlenostiCmb.ValueMember = "RadnoStanjeId";

                ZaposlenostiCmb.SelectedValue = radnoStanjeId;
            }
        }

        private void BindObim(int tutorId)
        {
            HttpResponseMessage response = tipService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
               
                ObimListBox.DataSource = response.Content.ReadAsAsync<List<TipStudenta>>().Result;
                ObimListBox.DisplayMember = "Naziv";
                ObimListBox.ValueMember = "TipoviStudentaId";
                ObimListBox.ClearSelected();
                var response2 = tipService.GetActionResponse("PreferiraniStudenti", tutorId.ToString());
                if (response2.IsSuccessStatusCode)
                {

                   

                    var lst = response2.Content.ReadAsAsync<List<Oblast_select_Result>>().Result;
                    if (lst != null)
                    {
                        for (int i = 0; i < ObimListBox.Items.Count; i++)
                        {
                            var nesto = ObimListBox.Items[i] as TipStudenta;

                            foreach (var item in lst)
                            {
                                if(nesto.Naziv==item.Naziv)
                                    ObimListBox.SetItemChecked(i, true);
                            }
                        }
                    }
                }
            }
        }

        private void SnimiBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                tutor.GradId = (int)GradCmb.SelectedValue;
                tutor.RadnoStanjeId = (int)ZaposlenostiCmb.SelectedValue;
                tutor.TutorTitulaId = (int)TitulaCmb.SelectedValue;
                tutor.PodKategorijaId = (int)PredmetCmb.SelectedValue;
                tutor.Email = EmailInput.Text;
                tutor.Telefon = TelefonInput.Text;
                tutor.Adresa = AdresaInput.Text;
                tutor.NazivUstanove = NazivObjektaInput.Text;
                tutor.CijenaCasa = (double)CijenaInput.Value;
                tutor.TutorTumbnail = SlikaTumbnail;
                tutor.TutorSlika = SlikaPrava;
                tutor.TipStudenta = ObimListBox.CheckedItems.Cast<TipStudenta>().ToList();
                if (!String.IsNullOrEmpty(LozinkaInput.Text))
                {
                    tutor.LozinkaSalt = tutorUpdate.LozinkaSalt;
                    tutor.LozinkaHash = UIHelper.GenerateHash(tutor.LozinkaSalt, LozinkaInput.Text);
                }
                else
                {
                    tutor.LozinkaSalt = tutorUpdate.LozinkaSalt;
                    tutor.LozinkaHash = tutorUpdate.LozinkaHash;
                }

                var response = tutorService.PutResponse(Global.prijavljeniTutor.TutorId, tutor);
                if (response.IsSuccessStatusCode)
                {

                    MessageBox.Show("Uspjesno promjenjeno");
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
                    SlikaPrava = ms.ToArray();

                    if (resizedImageWidth >= cropedImageWidth && resizedImageHeight >= cropedImageHeight)
                    {
                        int croppedXPosition = (resizedImageWidth - cropedImageWidth) / 2;
                        int croppedYPosition = 20;

                        cropedImage = UIHelper.CropImage(resizedImage, new Rectangle(croppedXPosition, croppedYPosition,
                                                        cropedImageWidth - croppedXPosition,
                                                        cropedImageHeight - croppedYPosition));

                        ms = new MemoryStream();
                        cropedImage.Save(ms, ImageFormat.Jpeg);
                        SlikaTumbnail = ms.ToArray();


                    }
                    else
                    {
                        SlikaTumbnail = ms.ToArray();
                    }
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

        private void EmailInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Provjera(EmailInput, Messeges.Email_Regex);
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

        private void AdresaInput_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Provjera(AdresaInput);
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

        private void ObimListBox_Validating(object sender, CancelEventArgs e)
        {
            if (ObimListBox.CheckedItems.Count == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(ObimListBox, "Odaberite zeljene studente!");
            }
            else errorProvider.SetError(ObimListBox, "");
        }
    }
}
