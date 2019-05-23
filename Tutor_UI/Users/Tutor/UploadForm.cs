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
    public partial class UploadForm : Form
    {
        private WebAPIHelper materijalService = new WebAPIHelper(Global.URI, Global.MaterialRoute);

        private int idUcionice =0;
        public UploadForm(int UcionicaId)
        {
            InitializeComponent();
            idUcionice = UcionicaId;
        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePathInput.Text = openFileDialog1.FileName;
                
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            var ms = File.ReadAllBytes(filePathInput.Text);
            string extension = Path.GetExtension(filePathInput.Text);

            Materijal noviMaterijal = new Materijal()
            {
                UcionicaId = idUcionice,
                Materijal1 = ms,
                TipFila = extension,
                DatumPostavljanja = DateTime.Today,
                Naslov = naslovInput.Text
            };

            HttpResponseMessage resposne = materijalService.PostResponse(noviMaterijal);
            if (resposne.IsSuccessStatusCode) MessageBox.Show("Materijal dodan!");
        }
    }
}
