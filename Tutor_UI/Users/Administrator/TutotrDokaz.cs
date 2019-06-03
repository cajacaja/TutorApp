using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutor_UI.Util;

namespace Tutor_UI.Users
{
    public partial class TutotrDokaz : Form
    {
        private WebAPIHelper tutorService = new WebAPIHelper("Tutor");

        public TutotrDokaz(int id)
        {
            InitializeComponent();
            var response = tutorService.GetActionResponse("Picture", id.ToString());

            if (response.IsSuccessStatusCode)
            {
                var Slika = response.Content.ReadAsAsync<byte[]>().Result;
                var ms = new MemoryStream(Slika);
                Image orignalImage = Image.FromStream(ms);

                int resizedImageWidth = 400;
                int resizedImageHeight = 300;
               

                if (orignalImage.Width > resizedImageWidth)
                {
                    Image resizedImage = UIHelper.ResizeImage(orignalImage, new Size(resizedImageWidth, resizedImageHeight));
                    dokazPictureBox.Image = resizedImage;
                    this.Width = resizedImage.Width+15;
                    this.Height = resizedImage.Height+30;

                }

            }
            else
            {
                MessageBox.Show("Slika ne postoji.");
            }
        }

        
    }
}
