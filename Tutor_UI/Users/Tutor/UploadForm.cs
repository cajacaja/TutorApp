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
        private WebAPIHelper materijalService = new WebAPIHelper("Materijal");

        private int idUcionice =0;
        private byte[] ms;
        public UploadForm(int UcionicaId)
        {
            InitializeComponent();
            idUcionice = UcionicaId;
            openFileDialog1.Filter = "Files (.pdf,.docx,.txt)|*.pdf;*.docx;*.txt;";
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
           
            try
            {
                 ms = File.ReadAllBytes(filePathInput.Text);
            }

            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
                MessageBox.Show("File koji ste odabrali je prevelik!");
                this.Close();
            }
           
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
            if (resposne.IsSuccessStatusCode)
            {
                MessageBox.Show("Materijal dodan!");
                this.Close();
            } 
            else
            {
                MessageBox.Show("File koji ste odabrali je prevelik!");                
                this.Close();
            }
        }
    }
}
