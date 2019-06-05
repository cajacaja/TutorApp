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
using PagedList;

namespace Tutor_UI.Users
{
    public partial class AdministratorForm : Form
    {
        private WebAPIHelper administratorService = new WebAPIHelper("Administrator");

        int pageNummber = 1;
        IPagedList<Administrator_NameSelect> list;

        public AdministratorForm()
        {
            InitializeComponent();
            
        }

        public async Task<IPagedList<Administrator_NameSelect>> GetPagedListAsync(int pageNummber = 1, int pageSize = 10)
        {



            return await Task.Factory.StartNew(() => {

                HttpResponseMessage response = administratorService.GetActionResponse("SearchByName");
                return response.Content.ReadAsAsync<List<Administrator_NameSelect>>().Result.ToPagedList(pageNummber, pageSize);

            });
        }

        private void DodajBtn_Click(object sender, EventArgs e)
        {
            var administratorDodajForm = new AdministratorAdd();
            administratorDodajForm.FormClosed += new FormClosedEventHandler(Form_Closed);
                administratorDodajForm.ShowDialog();
                administratorDodajForm.MdiParent = this.MdiParent;
                BindGrid();
            

        }

        private void BindGrid()
        {
            HttpResponseMessage response = administratorService.GetActionResponse("SearchByName", searchInput.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                var administratori = response.Content.ReadAsAsync<List<Administrator_NameSelect>>().Result;
                administratorGrid.DataSource = administratori;
                administratorGrid.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code:" + response.StatusCode + " Messagee-" + response.ReasonPhrase);
            }
        }

        private void TraziBtn_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
          
                
                if (administratorGrid.SelectedRows.Count!=0)
                {
                    var editForm = new EditAdministrator(Convert.ToInt32(administratorGrid.SelectedRows[0].Cells[0].Value));
                    editForm.FormClosed += new FormClosedEventHandler(Form_Closed);
                    editForm.ShowDialog();
                    editForm.MdiParent = this.MdiParent;
                    BindGrid();
                }
            

        }

        private async void AdministratorForm_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            BackBtn.Enabled = false;
            FowardBtn.Enabled = false;
            TraziBtn.Enabled = false;
            list = await GetPagedListAsync();
            administratorGrid.DataSource = list.ToList();
            BackBtn.Enabled = list.HasPreviousPage;
            FowardBtn.Enabled = list.HasNextPage;           
            brojListe.Text = string.Format("{0}/{1}", pageNummber, list.PageCount);
            Cursor = Cursors.Arrow;
            TraziBtn.Enabled = true;
        }

        private async void BackBtn_Click(object sender, EventArgs e)
        {
            if (list.HasPreviousPage)
            {
                Cursor = Cursors.WaitCursor;
                BackBtn.Enabled = false;
                FowardBtn.Enabled = false;
                list = await GetPagedListAsync(--pageNummber);                
                administratorGrid.DataSource = list.ToList();
                BackBtn.Enabled = list.HasPreviousPage;
                FowardBtn.Enabled = list.HasNextPage;
                brojListe.Text = string.Format("{0}/{1}", pageNummber, list.PageCount);
                Cursor = Cursors.Arrow;
            }

        }

        private async void FowardBtn_Click(object sender, EventArgs e)
        {
            if (list.HasNextPage)
            {
                Cursor = Cursors.WaitCursor;
                BackBtn.Enabled = false;
                FowardBtn.Enabled = false;
                list = await GetPagedListAsync(++pageNummber);
                administratorGrid.DataSource = list.ToList();
                BackBtn.Enabled = list.HasPreviousPage;
                FowardBtn.Enabled = list.HasNextPage;               
                brojListe.Text = string.Format("{0}/{1}", pageNummber, list.PageCount);
                Cursor = Cursors.Arrow;

            }
        }

        private async void AdministratorForm_Enter(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            BackBtn.Enabled = false;
            FowardBtn.Enabled = false;
            TraziBtn.Enabled = false;
            list = await GetPagedListAsync();
            administratorGrid.DataSource = list.ToList();
            BackBtn.Enabled = list.HasPreviousPage;
            FowardBtn.Enabled = list.HasNextPage;           
            brojListe.Text = string.Format("{0}/{1}", pageNummber, list.PageCount);
            Cursor = Cursors.Arrow;
            TraziBtn.Enabled = true;
        }

        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            BindGrid();
        }
    }
}
