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
    public partial class OcjeniStudentForm : Form
    {
        private WebAPIHelper ocjenaService = new WebAPIHelper("OcjenaStudent");
        int StudentId = 0;
        int tutorId = Global.prijavljeniTutor.TutorId;
        public OcjeniStudentForm(int studentId)
        {
            InitializeComponent();
            StudentId = studentId;
            ocjenaInput.Minimum = 1;
            ocjenaInput.Maximum = 5;
        }

        private void OcjeniBtn_Click(object sender, EventArgs e)
        {
            OcjenaStudent ocjena = new OcjenaStudent()
            {
                TutorId = tutorId,
                StudentId=StudentId,
                Ocjena=(int)ocjenaInput.Value,
                Komentar=komentarInput.Text,
                Datum=DateTime.Today
               
            };

            HttpResponseMessage response = ocjenaService.PostResponse(ocjena);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Student ocjenjen.");
                this.Close();
            }
        }
    }
}
