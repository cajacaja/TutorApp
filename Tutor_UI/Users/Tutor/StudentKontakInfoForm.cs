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
using Tutor_API.Models;
using Tutor_UI.Util;

namespace Tutor_UI.Users.Tutor
{
    public partial class StudentKontakInfoForm : Form
    {
        private WebAPIHelper studentService = new WebAPIHelper("Student");
        private WebAPIHelper kontakService = new WebAPIHelper("KontaktInfo");

        public StudentKontakInfoForm(int StudentId)
        {
            InitializeComponent();

            BindForm(StudentId);
        }

        private void BindForm(int studentId)
        {
            HttpResponseMessage response = studentService.GetResponse(studentId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var student = response.Content.ReadAsAsync<Student>().Result;

                var ms = new MemoryStream(student.StudentskaSlika);
                PripremiSliku( Image.FromStream(ms));
                
                var response2 = kontakService.GetResponse(student.KontaktInfoId.ToString());

                if (response2.IsSuccessStatusCode)
                {
                    var kontakInfo = response2.Content.ReadAsAsync<KontaktInfo>().Result;
                    EmailInput.Text = kontakInfo.Email;
                    TelefonInput.Text = kontakInfo.Telefon;
                    AdresaInput.Text = kontakInfo.Adresa;
                }

            }
        }

        private void PripremiSliku(Image orignalImage)
        {



            int resizedImageWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImageWidth"]);
            int resizedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImageHeight"]);
            int cropedImageWidth = Convert.ToInt32(ConfigurationManager.AppSettings["cropedImageWidth"]);
            int cropedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["cropedImageHeight"]);

            if (orignalImage.Width > resizedImageWidth)
            {
                Image resizedImage = UIHelper.ResizeImage(orignalImage, new Size(resizedImageWidth, resizedImageHeight));
                studentPictureBox.Image = orignalImage;
                Image cropedImage = resizedImage;


                if (resizedImageWidth >= cropedImageWidth && resizedImageHeight >= cropedImageHeight)
                {
                    int croppedXPosition = (resizedImageWidth - cropedImageWidth) / 2;
                    int croppedYPosition = 20;

                    cropedImage = UIHelper.CropImage(resizedImage, new Rectangle(croppedXPosition, croppedYPosition,
                                                    cropedImageWidth - croppedXPosition,
                                                    cropedImageHeight - croppedYPosition));



                    studentPictureBox.Image = cropedImage;
                }

            }
            else
            {
                studentPictureBox.Image = orignalImage;
            }
        }

       
    }


}
