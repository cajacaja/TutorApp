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
            TutorForm tutori = new TutorForm();
            tutori.Show();
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
    }
}
