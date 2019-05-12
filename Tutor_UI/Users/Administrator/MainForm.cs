using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutor_UI.Users
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            IsMdiContainer = true;           
            WindowState = FormWindowState.Maximized;
        }

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministratorForm administrator = new AdministratorForm();
            administrator.Show();
            administrator.MdiParent = this;
        }

        private void tutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            TutorForm tutori = new TutorForm();
            tutori.Show();
            Cursor = Cursors.Arrow;
            tutori.MdiParent = this;

        }

        private void listaBanovanihKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var banovani = new BanovaniKorisniciForm();
            banovani.Show();
            banovani.MdiParent = this;
        }

        private void prijavljeniTutoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var prijavljeniTutori = new PrijaveStudentForm();
            prijavljeniTutori.Show();
            prijavljeniTutori.MdiParent = this;
        }

        private void prijavljeniStudentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var prijavljeniStudenti = new PrijaveTutorForm();
            prijavljeniStudenti.Show();
            prijavljeniStudenti.MdiParent = this;
        }

        private void studentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studentiForm = new StudentForm();
            studentiForm.Show();
            studentiForm.MdiParent = this;
        }

        private void ucioniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UcioniceForm ucionice = new UcioniceForm();
            ucionice.Show();
            ucionice.MdiParent = this;
        }

        private void najpopularnijiPredmetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportPredmet reportPredmet = new ReportPredmet();
            reportPredmet.Show();
            reportPredmet.MdiParent = this;
        }

        private void najpopularnijiTutoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportTutora reportTutor = new ReportTutora();
            reportTutor.Show();
            reportTutor.MdiParent = this;
        }

       
    }
}
