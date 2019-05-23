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
    public partial class KomentariForm : Form
    {
        private WebAPIHelper ocjenaService = new WebAPIHelper(Global.URI, Global.OcjenaStudentRoute);

        public KomentariForm(int studentId)
        {
            InitializeComponent();
            BindForm(studentId);
        }

        private void BindForm(int studentId)
        {
            HttpResponseMessage response = ocjenaService.GetActionResponse("GetOcjene", studentId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var lstOcjena = response.Content.ReadAsAsync<List<OcjenaStudent_SelectComments_Result>>().Result;
                komentariGridView.DataSource = lstOcjena;
                komentariGridView.ClearSelection();
            }
        }
    }
}
