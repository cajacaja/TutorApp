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

namespace Tutor_UI.Users.Tutor
{
    public partial class UcionicaDetailsForm : Form
    {
        private WebAPIHelper ucionicaService = new WebAPIHelper("Ucionica");
        private WebAPIHelper prijaveService = new WebAPIHelper("Prijava");
        private WebAPIHelper terminiService = new WebAPIHelper("Termin");

        private int idUcionice = 0;

        public UcionicaDetailsForm(int ucionicaId)
        {
            InitializeComponent();
            idUcionice = ucionicaId;
           BindUcionica(ucionicaId);

        }

        private void BindUcionica(int ucionicaId)
        {
            HttpResponseMessage response = ucionicaService.GetActionResponse("Details", ucionicaId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var ucionica = response.Content.ReadAsAsync<Ucionica_SelectDetails_Result>().Result;

                NaslovInput.Text = ucionica.Naslov;
                MemoryStream ms = new MemoryStream(ucionica.Slika);
                slikaInput.Image = Image.FromStream(ms);
                opisInput.Text = ucionica.Opis;
                datumPocectkaInput.Text = ucionica.DatumPocetka.ToShortDateString();
                datumZavrsetkaInput.Text = ucionica.DatumZavrsetka.ToShortDateString();
                adresaInput.Text = ucionica.AdresaUcionice;
                nivoTezineInput.Text = ucionica.NivoTezine;
                cijenaInput.Text = ucionica.Cijena.ToString() + " KM";
                brojCasovaInput.Text = ucionica.BrojCasova.ToString();
                brojUcenikaInput.Text = ucionica.MaxBrojPolaznika.ToString();

                BindTermine(ucionicaId);
                BindUcenici(ucionicaId);


            }
        }

        private void BindUcenici(int ucionicaId)
        {
            HttpResponseMessage response = prijaveService.GetActionResponse("SelectAccepted", ucionicaId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var lstTermina = response.Content.ReadAsAsync<List<Prijave_SelectAccepted_Result>>().Result;
                prihvacenePrijaveGridView.DataSource = lstTermina;
                prihvacenePrijaveGridView.ClearSelection();
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

        private void pregledajBtn_Click(object sender, EventArgs e)
        {
            MaterijaliForm materijali = new MaterijaliForm(idUcionice);
            materijali.ShowDialog();
            materijali.MdiParent = this.MdiParent;
        }

        private void prijaveBtn_Click(object sender, EventArgs e)
        {
            UcionicaPrijaveForm prijaveForm = new UcionicaPrijaveForm(idUcionice);
            prijaveForm.ShowDialog();
            prijaveForm.MdiParent = this.MdiParent;
        }

        private void UcionicaDetailsForm_Enter(object sender, EventArgs e)
        {
            BindUcenici(idUcionice);
        }
    }
}
