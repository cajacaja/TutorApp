using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutor_API.Models;
using Tutor_UI.Util;

namespace Tutor_UI.Users.Tutor
{
    public partial class PrijavaForm : Form
    {
        private WebAPIHelper banService = new WebAPIHelper(Global.URI,Global.BanTutorRoute);
        private int studentId=0;
        private int tutorId = Global.prijavljeniTutor.TutorId;
        public PrijavaForm(int idStudenta)
        {
            InitializeComponent();
            studentId = idStudenta;
        }

        private void PrijavaBtn_Click(object sender, EventArgs e)
        {
            BanPrijavaTutor prijava = new BanPrijavaTutor()
            {
                DatumPrijave = DateTime.Today,
                TutorId = tutorId,
                StudentId = studentId,
                Razlog = PrijavaInput.Text,
                IsRead = false
            };

            var response = banService.PostResponse(prijava);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Uspjeno prijavljen");
                this.Close();
            }
        }
    }
}
