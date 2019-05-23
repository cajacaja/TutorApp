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

namespace Tutor_UI.Users.Tutor
{
    public partial class UcionicaForm : Form
    {
        private WebAPIHelper tutorService = new WebAPIHelper(Global.URI,Global.TutorRoute);
        private WebAPIHelper ucionicaService = new WebAPIHelper(Global.URI, Global.UcionicaRoute);
        private int tutorID = Global.prijavljeniTutor.TutorId;

        int pageNummber = 1;
        IPagedList<Ucionica_SelectNonActive_Result> list;

        public async Task<IPagedList<Ucionica_SelectNonActive_Result>> GetPagedListAsync(int pageNummber = 1, int pageSize = 10)
        {


            return await Task.Factory.StartNew(() =>
            {

                var response = tutorService.GetActionResponse("NonActiveUcionica", tutorID.ToString() + "/" + searchInput.Text);
                return response.Content.ReadAsAsync<List<Ucionica_SelectNonActive_Result>>().Result.ToPagedList(pageNummber, pageSize);

            });
        }

        public UcionicaForm()
        {
            InitializeComponent();
            BindAktivneUcionie();
            BindNeAktivneUcionice();
        }

        private async void BindNeAktivneUcionice()
        {
           
            list = await GetPagedListAsync();
            stareDataGridView.DataSource = list.ToList();
            BackBtn.Enabled = list.HasPreviousPage;
            ForwardBtn.Enabled = list.HasNextPage;
            pageLable.Text = string.Format("{0}/{1}", pageNummber, list.PageCount);
            
        }

        private void BindAktivneUcionie()
        {
            HttpResponseMessage response = tutorService.GetActionResponse("ActiveUcionica",tutorID.ToString()+"/"+searchInput.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                var lstUcionica = response.Content.ReadAsAsync<List<Tutor_SelectActiveUcionica_Result>>().Result;
                aktivneDataGridView.DataSource = lstUcionica;
                aktivneDataGridView.ClearSelection();
            }
        }

        private void NovaUcionicaBtn_Click(object sender, EventArgs e)
        {
            AddUcionicu addUcionicu = new AddUcionicu();
            addUcionicu.Show();
            addUcionicu.MdiParent = this.MdiParent;
        }

        private void DeactiveBtn_Click(object sender, EventArgs e)
        {
            if (aktivneDataGridView.SelectedRows.Count != 0)
            {
                int UcionicaId = Convert.ToInt32(aktivneDataGridView.SelectedRows[0].Cells[0].Value);
                var response = ucionicaService.GetResponse(UcionicaId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    var ucionica = response.Content.ReadAsAsync<Ucionica>().Result;
                    ucionica.Aktivna = false;
                    response = ucionicaService.PutResponse(ucionica.UcionicaId,ucionica);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Ucionica dektivirana");
                        BindAktivneUcionie();
                        BindNeAktivneUcionice();
                    }
                }
            }
            
        }

        private void PregledBtn_Click(object sender, EventArgs e)
        {
            if (UcioniceTabControl.SelectedTab == UcioniceTabControl.TabPages["AktivneUcionice"])
            {
                if (aktivneDataGridView.SelectedRows.Count != 0)
                {
                    int UcionicaId = Convert.ToInt32(aktivneDataGridView.SelectedRows[0].Cells[0].Value);
                    UcionicaDetailsForm detaljiUcionice = new UcionicaDetailsForm(UcionicaId);
                    detaljiUcionice.Show();
                    detaljiUcionice.MdiParent = this.MdiParent;
                }
            }
            else if (UcioniceTabControl.SelectedTab == UcioniceTabControl.TabPages["StareUcionice"])
            {
                if (aktivneDataGridView.SelectedRows.Count != 0)
                {
                    int UcionicaId = Convert.ToInt32(stareDataGridView.SelectedRows[0].Cells[0].Value);
                    UcionicaDetailsForm detaljiUcionice = new UcionicaDetailsForm(UcionicaId);
                    detaljiUcionice.Show();
                    detaljiUcionice.MdiParent = this.MdiParent;
                }
            }

            
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (aktivneDataGridView.SelectedRows.Count != 0)
            {
                int UcionicaId = Convert.ToInt32(aktivneDataGridView.SelectedRows[0].Cells[0].Value);
                UcionicaEdit editUcionica = new UcionicaEdit(UcionicaId);
                editUcionica.Show();
                editUcionica.MdiParent = this.MdiParent;
            }
        }

        private void UcioniceTabControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (UcioniceTabControl.SelectedTab == UcioniceTabControl.TabPages["AktivneUcionice"])
            {
                BackBtn.Visible = false;
                ForwardBtn.Visible = false;
                pageLable.Visible = false;
                NovaUcionicaBtn.Enabled = true;
                EditBtn.Enabled = true;
                DeactiveBtn.Enabled = true;
            }
            else if (UcioniceTabControl.SelectedTab == UcioniceTabControl.TabPages["StareUcionice"])
            {
                BackBtn.Visible = true;
                ForwardBtn.Visible = true;
                pageLable.Visible = true;
                NovaUcionicaBtn.Enabled = false;
                EditBtn.Enabled = false;
                DeactiveBtn.Enabled = false;
            }
        }

        private async void BackBtn_Click(object sender, EventArgs e)
        {
            if (list.HasPreviousPage)
            {
                Cursor = Cursors.WaitCursor;
                BackBtn.Enabled = false;
                ForwardBtn.Enabled = false;
                list = await GetPagedListAsync(--pageNummber);
                stareDataGridView.DataSource = list.ToList();
                BackBtn.Enabled = list.HasPreviousPage;
                ForwardBtn.Enabled = list.HasNextPage;
                pageLable.Text = string.Format("{0}/{1}", pageNummber, list.PageCount);
                Cursor = Cursors.Arrow;
            }
        }

        private async void ForwardBtn_Click(object sender, EventArgs e)
        {
            if (list.HasNextPage)
            {               
                
                list = await GetPagedListAsync(++pageNummber);
                stareDataGridView.DataSource = list.ToList();
                BackBtn.Enabled = list.HasPreviousPage;
                ForwardBtn.Enabled = list.HasNextPage;
                pageLable.Text = string.Format("{0}/{1}", pageNummber, list.PageCount);               

            }
        }

        private void TraziBtn_Click(object sender, EventArgs e)
        {
            if (UcioniceTabControl.SelectedTab == UcioniceTabControl.TabPages["AktivneUcionice"])
            {
                BindAktivneUcionie();
            }
            else if (UcioniceTabControl.SelectedTab == UcioniceTabControl.TabPages["StareUcionice"])
            {
                BindNeAktivneUcionice();
            }
        }
    }
}
