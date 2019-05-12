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
using PagedList;

namespace Tutor_UI.Users.Tutor
{
    public partial class ProfilDetailsForm : Form
    {
        private WebAPIHelper tutorService = new WebAPIHelper(Global.URI, Global.TutorRoute);
        private WebAPIHelper tipService = new WebAPIHelper(Global.URI, Global.TipStudentaRoute);
        private WebAPIHelper ocjenaTutorService = new WebAPIHelper(Global.URI, Global.OcjenaTutorRoute);

        int pageNummber = 1;
        IPagedList<Tutor_ReviewsSelect_Result> list;

        public async Task<IPagedList<Tutor_ReviewsSelect_Result>> GetPagedListAsync(int pageNummber = 1, int pageSize = 5)
        {



            return await Task.Factory.StartNew(() => {

                var response = ocjenaTutorService.GetActionResponse("TutorReview", Global.prijavljeniTutor.TutorId.ToString());
                return response.Content.ReadAsAsync<List<Tutor_ReviewsSelect_Result>>().Result.ToPagedList(pageNummber, pageSize);

            });
        }

        public ProfilDetailsForm(int tutorId)
        {
            InitializeComponent();

            BindForm(tutorId);
        }

        private void BindForm(int tutorId)
        {
            var response = tutorService.GetActionResponse("TutorDetails", tutorId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var Tutor = response.Content.ReadAsAsync<Tutor_Details_Result>().Result;
                var ms = new MemoryStream(Tutor.TutorTumbnail);
                tutorPictureBox.Image = Image.FromStream(ms);
                ImeInput.Text = Tutor.Ime;
                PrezimeInput.Text = Tutor.Prezime;
                EmailInput.Text = Tutor.Email;
                TelefonInput.Text = Tutor.Telefon;
                AdresaInput.Text = Tutor.Adresa;
                KorisnickoImeInput.Text = Tutor.KorisnickoIme;
                PredmetInput.Text = Tutor.Predmet;
                CijenaCasaInput.Text = Tutor.CijenaCasa.ToString() + " KM";
                RadnoStanjeInput.Text = Tutor.RadnoStanje;
                NazivUstanoveInput.Text = Tutor.NazivUstanove;
                spolInput.Text = Tutor.Spol;
                ocjenaInput.Text = Tutor.Ocjena.ToString();
                FillList(tutorId);

            }
            else
            {
                MessageBox.Show("Pogresan tutor");
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

        private async void BindOcjene(int id)
        {
            list = await GetPagedListAsync();
            BackBtn.Enabled = list.HasPreviousPage;
            ForwardBtn.Enabled = list.HasNextPage;
            OcjeneDataGridView.DataSource = list.ToList();
            pageInputLable.Text = string.Format("{0}/{1}", pageNummber, list.PageCount);

        }

        private async void BackBtn_Click(object sender, EventArgs e)
        {
            if (list.HasPreviousPage)
            {
                list = await GetPagedListAsync(--pageNummber);
                BackBtn.Enabled = list.HasPreviousPage;
                ForwardBtn.Enabled = list.HasNextPage;
                OcjeneDataGridView.DataSource = list.ToList();
                pageInputLable.Text = string.Format("{0}/{1}", pageNummber, list.PageCount);

            }
        }

        private async void ForwardBtn_Click(object sender, EventArgs e)
        {
            if (list.HasNextPage)
            {
                list = await GetPagedListAsync(++pageNummber);
                BackBtn.Enabled = list.HasPreviousPage;
                ForwardBtn.Enabled = list.HasNextPage;
                OcjeneDataGridView.DataSource = list.ToList();
                pageInputLable.Text = string.Format("{0}/{1}", pageNummber, list.PageCount);

            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            TutorEditForm editTutor = new TutorEditForm(Global.prijavljeniTutor.TutorId);

            editTutor.Show();
        }
    }
}
