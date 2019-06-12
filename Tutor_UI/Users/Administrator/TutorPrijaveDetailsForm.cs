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

namespace Tutor_UI.Users
{
    public partial class TutorPrijaveDetailsForm : Form
    {
        //Prijavljeni tutori od strane studenata
        private WebAPIHelper banStudentService = new WebAPIHelper("BanPrijavaStudent");
        private BanPrijavaStudente_SelectOne_Result prijava;

        public TutorPrijaveDetailsForm(int id)
        {
           
           
            InitializeComponent();
            HttpResponseMessage response = banStudentService.GetResponse(id.ToString());
            prijava = response.Content.ReadAsAsync<BanPrijavaStudente_SelectOne_Result>().Result;
            if (response.IsSuccessStatusCode)
            {
                StudentInput.Text = prijava.Student;
                TutorInput.Text = prijava.Tutor;
                RazlogRichTxtBox.Text = prijava.RazlogPrijave;
                DatumPrijaveInput.Text = prijava.DatumPrijave.ToShortDateString();
            }
        

            BanPrijavaStudent prijavaUpdate = new BanPrijavaStudent()
            {
               PrijavaStudentId=id,
               StudentId=prijava.StudentId,
               TutorId=prijava.TutorId,
               RazlogPrijave=prijava.RazlogPrijave,
               DatumPrijave=prijava.DatumPrijave,
               IsRead=true
            };

            var response2 = banStudentService.PutResponse(id, prijavaUpdate);

        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            StudentDetalj student = new StudentDetalj(prijava.StudentId);
            student.ShowDialog();
        }

        private void tutorBtn_Click(object sender, EventArgs e)
        {
            Tutor_UI.Users.TutorDetalj tutor = new TutorDetalj(prijava.TutorId);
            tutor.ShowDialog();
        }







    }
}
