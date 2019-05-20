﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutor_UI.Users.Tutor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
            WindowState = FormWindowState.Maximized;
        }

        private void tutorProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfilDetailsForm tutorProfil = new ProfilDetailsForm(Global.prijavljeniTutor.TutorId);
            tutorProfil.Show();
        }

        private void zahtjeviZaCasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CasZahtjeviForm zahtjevi = new CasZahtjeviForm();
            zahtjevi.Show();
            zahtjevi.MdiParent = this;
        }

        private void mojiStudentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentiForm studentiForm = new StudentiForm();
            studentiForm.Show();
            studentiForm.MdiParent = this;
        }

        private void ucioniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UcionicaForm ucionicaForm = new UcionicaForm();
            ucionicaForm.Show();
            ucionicaForm.MdiParent = this;
        }
    }
}
