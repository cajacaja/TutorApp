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
    public partial class UcionicaForm : Form
    {
        private WebAPIHelper tutorService = new WebAPIHelper(Global.URI,Global.TutorRoute);
        private WebAPIHelper ucionicaService = new WebAPIHelper(Global.URI, Global.UcionicaRoute);
        private int tutorID = Global.prijavljeniTutor.TutorId;

        public UcionicaForm()
        {
            InitializeComponent();
            BindAktivneUcionie();
        }

        private void BindAktivneUcionie()
        {
            HttpResponseMessage response = tutorService.GetActionResponse("ActiveUcionica",tutorID.ToString());
            if (response.IsSuccessStatusCode)
            {
                var lstUcionica = response.Content.ReadAsAsync<List<Tutor_SelectActiveUcionica_Result>>().Result;
                aktivneDataGridView.DataSource = lstUcionica;
                aktivneDataGridView.ClearSelection();
            }
        }

        private void NovaUcionicaBtn_Click(object sender, EventArgs e)
        {
            AddUcionicu addUcionicu = new AddUcionicu();
            addUcionicu.Show();
            addUcionicu.MdiParent = this.MdiParent;
        }

        private void DeactiveBtn_Click(object sender, EventArgs e)
        {
            if (aktivneDataGridView.SelectedRows.Count != 0)
            {
                int UcionicaId = Convert.ToInt32(aktivneDataGridView.SelectedRows[0].Cells[0].Value);
                var response = ucionicaService.GetResponse(UcionicaId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    var ucionica = response.Content.ReadAsAsync<Ucionica>().Result;
                    ucionica.Aktivna = false;
                    response = ucionicaService.PutResponse(ucionica.UcionicaId,ucionica);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Ucionica dektivirana");
                        BindAktivneUcionie();
                    }
                }
            }
            
        }

        private void PregledBtn_Click(object sender, EventArgs e)
        {
            if (aktivneDataGridView.SelectedRows.Count != 0)
            {
                int UcionicaId = Convert.ToInt32(aktivneDataGridView.SelectedRows[0].Cells[0].Value);
                UcionicaDetailsForm detaljiUcionice = new UcionicaDetailsForm(UcionicaId);
                detaljiUcionice.Show();
                detaljiUcionice.MdiParent = this.MdiParent;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (aktivneDataGridView.SelectedRows.Count != 0)
            {
                int UcionicaId = Convert.ToInt32(aktivneDataGridView.SelectedRows[0].Cells[0].Value);
                UcionicaEdit editUcionica = new UcionicaEdit(UcionicaId);
                editUcionica.Show();
                editUcionica.MdiParent = this.MdiParent;
            }
        }
    }
}
