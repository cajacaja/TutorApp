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
    public partial class MaterijaliForm : Form
    {
        private WebAPIHelper materijalService = new WebAPIHelper("Materijal");
        private int idUcionice = 0;
        public MaterijaliForm(int UcionicaId)
        {
            idUcionice = UcionicaId;
            InitializeComponent();
            BindForm();
        }

        private void BindForm()
        {
            HttpResponseMessage response = materijalService.GetActionResponse("GetMaterijale", idUcionice.ToString());
            if (response.IsSuccessStatusCode)
            {
                var lstMaterijala = response.Content.ReadAsAsync<List<Materijal_Select_Result>>().Result;
                fileGridView.DataSource = lstMaterijala;
                fileGridView.ClearSelection();
            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            UploadForm fileUpload = new UploadForm(idUcionice);
            fileUpload.FormClosed += new FormClosedEventHandler(Form_Closed);
            fileUpload.ShowDialog();

        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            if (fileGridView.SelectedRows.Count != 0)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileLocaiton = folderBrowserDialog1.SelectedPath;
                    int materijalId = Convert.ToInt32(fileGridView.SelectedRows[0].Cells[0].Value);
                    var response = materijalService.GetResponse(materijalId.ToString());
                    if (response.IsSuccessStatusCode)
                    {
                        var materijal = response.Content.ReadAsAsync<Materijal>().Result;

                        var file = File.Create(fileLocaiton+"\\"+materijal.Naslov+materijal.TipFila,
                                               materijal.Materijal1.Length);
                        file.Write(materijal.Materijal1, 0, materijal.Materijal1.Length);
                        file.Close();
                        MessageBox.Show("Dokument skinut");
                    }
                }
            }
        }

        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            BindForm();
        }

        private void izbrisiBtn_Click(object sender, EventArgs e)
        {
            if (fileGridView.SelectedRows.Count != 0)
            {
                int materijalId = Convert.ToInt32(fileGridView.SelectedRows[0].Cells[0].Value);
                var response = materijalService.DeleteResponse(materijalId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Materijal izbrisan.");
                    BindForm();
                }
            }
        }
    }
}
