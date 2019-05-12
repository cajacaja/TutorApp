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
    public partial class BanovaniKorisniciForm : Form
    {
        private WebAPIHelper tutorService = new WebAPIHelper(Global.URI, Global.TutorRoute);
        private WebAPIHelper studentService = new WebAPIHelper(Global.URI, Global.StudentRoute);
        public BanovaniKorisniciForm()
        {
            InitializeComponent();
            BanovaniTutori();
            BanovaniStudenti();
        }

        private void BanovaniStudenti()
        {
           
            HttpResponseMessage response = studentService.GetActionResponse("BanStudents");
            if (response.IsSuccessStatusCode)
            {

                var lstBanovanihStudenta = response.Content.ReadAsAsync<List<Student_BanStudents_Result>>().Result;
                BanStudentsGridView.DataSource = lstBanovanihStudenta;
                BanStudentsGridView.ClearSelection();
            }
        }

        private void BanovaniTutori()
        {
            HttpResponseMessage response = tutorService.GetActionResponse("BanovaniTutori");
            if (response.IsSuccessStatusCode)
            {

                var lstBanovanihTutora = response.Content.ReadAsAsync<List<Tutori_SelectBanTutor_Result>>().Result;
                BanovaniTutoriGridView.DataSource = lstBanovanihTutora;
                BanovaniTutoriGridView.ClearSelection();
            }
        }

        private void PregledBtn_Click(object sender, EventArgs e)
        {

            int TutorId = 0;
            int StudentId = 0;
            if (tabControl1.SelectedTab == tabControl1.TabPages["TutoriTab"])
            {
                if (BanovaniTutoriGridView.SelectedRows.Count != 0)
                {
                    TutorId = Convert.ToInt32(BanovaniTutoriGridView.SelectedRows[0].Cells[0].Value);
                    var detalji = new TutorDetalj(TutorId);
                    detalji.Show();
                    detalji.MdiParent = this.MdiParent;
                }
               
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["StuentiTab"])
            {
                if (BanStudentsGridView.SelectedRows.Count != 0) {
                    StudentId= Convert.ToInt32(BanStudentsGridView.SelectedRows[0].Cells[0].Value);
                    var studentDetalji = new StudentDetalj(StudentId);
                    studentDetalji.Show();
                    studentDetalji.MdiParent = this.MdiParent;
                }
               
            }
           
           
        }

        private void BanovaniKorisniciForm_Enter(object sender, EventArgs e)
        {
            BanovaniTutori();
            BanovaniStudenti();
        }
    }
}
