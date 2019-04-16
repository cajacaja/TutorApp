﻿using System;
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
    public partial class StudentPrijaveDetailsForm : Form
    {
        private WebAPIHelper banTutorService = new WebAPIHelper(Global.URI, Global.BanTutorRoute);
        private BanPrijavaTutor_SelectOne_Result prijava;
        public StudentPrijaveDetailsForm(int id)
        {
            
            InitializeComponent();
            HttpResponseMessage response = banTutorService.GetResponse(id.ToString());
            prijava = response.Content.ReadAsAsync<BanPrijavaTutor_SelectOne_Result>().Result;
            StudentInput.Text = prijava.Student;
            TutorInput.Text = prijava.Tutor;
            RazlogRichTxtBox.Text = prijava.Razlog;
            DatumPrijaveInput.Text = prijava.DatumPrijave.ToShortDateString();

            BanPrijavaTutor prijavaUpdate = new BanPrijavaTutor()
            {
                PrijavaTutorId = id,
                StudentId = prijava.StudentId,
                TutorId = prijava.TutorId,
                Razlog = prijava.Razlog,
                DatumPrijave = prijava.DatumPrijave,
                IsRead = true
            };

            var response2 = banTutorService.PutResponse(id, prijavaUpdate);
        }

        private void StudentPrijaveDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tutor_UI.Users.TutorDetalj tutor = new TutorDetalj(prijava.TutorId);
            tutor.Show();
        }

        
    }
}
