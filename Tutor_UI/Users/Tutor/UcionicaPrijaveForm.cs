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
    public partial class UcionicaPrijaveForm : Form
    {
        private WebAPIHelper prijaveService = new WebAPIHelper(Global.URI, Global.PrijavaRoute);

        int idUcionice = 0;
        public UcionicaPrijaveForm(int ucionicaId)
        {
            InitializeComponent();
            idUcionice = ucionicaId;
            BindForm();

        }

        private void BindForm()
        {
            HttpResponseMessage response = prijaveService.GetActionResponse("PrijaveUcionica",idUcionice.ToString());
            if (response.IsSuccessStatusCode)
            {
                var lstPrijava = response.Content.ReadAsAsync<List<Prijava_SelectUcionica_Result>>().Result;
                prijaveGridView.DataSource = lstPrijava;
                prijaveGridView.ClearSelection();
            }
        }

       

        private void prihvatiBtn_Click(object sender, EventArgs e)
        {
            if (prijaveGridView.SelectedRows.Count != 0)
            {
                int prijavaId = Convert.ToInt32(prijaveGridView.SelectedRows[0].Cells[0].Value);
                var response = prijaveService.GetResponse(prijavaId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    var prijava = response.Content.ReadAsAsync<Prijava>().Result;
                    prijava.Prihvaceno = true;
                    response = prijaveService.PutResponse(prijava.PrijavaId,prijava);
                    if (response.IsSuccessStatusCode)
                        BindForm();
                }
            }
        }

        private void odbijBtn_Click(object sender, EventArgs e)
        {
            if (prijaveGridView.SelectedRows.Count != 0)
            {
                int prijavaId = Convert.ToInt32(prijaveGridView.SelectedRows[0].Cells[0].Value);
                var response = prijaveService.GetResponse(prijavaId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    var prijava = response.Content.ReadAsAsync<Prijava>().Result;
                    prijava.Odbijeno = true;
                    response = prijaveService.PutResponse(prijava.PrijavaId, prijava);
                    if (response.IsSuccessStatusCode)
                        BindForm();
                }
            }
        }

        private void pregledBtn_Click(object sender, EventArgs e)
        {
            if (prijaveGridView.SelectedRows.Count != 0)
            {
                int studentId = Convert.ToInt32(prijaveGridView.SelectedRows[0].Cells[1].Value);
                KomentariForm komentari = new KomentariForm(studentId);
                komentari.Show();
                komentari.MdiParent = this.MdiParent;
            }
           
        }

        private void UcionicaPrijaveForm_Enter(object sender, EventArgs e)
        {
            BindForm();
        }
    }
}
