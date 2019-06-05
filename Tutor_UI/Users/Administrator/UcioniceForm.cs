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
using System.IO;
using System.Drawing.Imaging;

namespace Tutor_UI.Users
{
    public partial class UcioniceForm : Form
    {
        private WebAPIHelper ucionicaService = new WebAPIHelper("Ucionica");
        private WebAPIHelper oblastService = new WebAPIHelper("Oblast");
        private WebAPIHelper gradService = new WebAPIHelper("Grad");

        int pageNummber1 = 1;
        int pageNummber2 = 1;
        IPagedList<Ucionica_SelectActive_Result> list1;
        IPagedList<Ucionica_SelectStaro_Result> list2;

        //Prva page lista
        public async Task<IPagedList<Ucionica_SelectActive_Result>> GetPagedListActiveAsync(int pageNummber = 1, int pageSize = 10)
        {
            string parametar = OblastCmb.SelectedValue.ToString() + '/' + GradCmb.SelectedValue.ToString();


            return await Task.Factory.StartNew(() => {

                HttpResponseMessage response = ucionicaService.GetActionResponse("AktivneUcionice",parametar);
                return response.Content.ReadAsAsync<List<Ucionica_SelectActive_Result>>().Result.ToPagedList(pageNummber, pageSize);

            });
        }

        //Druga page lista

        public async Task<IPagedList<Ucionica_SelectStaro_Result>> GetPagedListStareAsync(int pageNummber = 1, int pageSize = 10)
        {
            string parametar = OblastCmb.SelectedValue.ToString() + '/' + GradCmb.SelectedValue.ToString();


            return await Task.Factory.StartNew(() => {

                HttpResponseMessage response = ucionicaService.GetActionResponse("StareUcionice", parametar);
                return response.Content.ReadAsAsync<List<Ucionica_SelectStaro_Result>>().Result.ToPagedList(pageNummber, pageSize);

            });
        }

        public UcioniceForm()
        {
            InitializeComponent();
            BindOblast();
            BindGrad();
            
        }

        private void BindGrad()
        {
            var response = gradService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                var nesto = response.Content.ReadAsAsync<List<Grad>>().Result;
                nesto.Insert(0, new Grad() { Naziv = "Odaberite grad" });
                GradCmb.DataSource = nesto;
                GradCmb.DisplayMember = "Naziv";
                GradCmb.ValueMember = "GradId";
            }
        }

        private void BindOblast()
        {
            HttpResponseMessage response = oblastService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
               
                var lstOblasti = response.Content.ReadAsAsync<List<Podkategorija>>().Result;
                lstOblasti.Insert(0, new Podkategorija() { Naziv = "Odaberite oblast" });
                OblastCmb.DataSource = lstOblasti;
                OblastCmb.DisplayMember = "Naziv";
                OblastCmb.ValueMember = "OblastId";
            }
        }

       

        private async void TraziBtn_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {

                list1 = await GetPagedListActiveAsync();
                actUcioniceGridView.DataSource = list1.ToList();
                BackBtn.Enabled = list1.HasPreviousPage;
                ForwardBtn.Enabled = list1.HasNextPage;
                pageNumLabel.Text = string.Format("{0}/{1}", pageNummber1, list1.PageCount);
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {

                list2 = await GetPagedListStareAsync();
                strUcioniceGridView.DataSource = list2.ToList();
                BackBtn.Enabled = list2.HasPreviousPage;
                ForwardBtn.Enabled = list2.HasNextPage;
                pageNumLabel.Text = string.Format("{0}/{1}", pageNummber2, list2.PageCount);
            }


        }

        private async void UcioniceForm_Load(object sender, EventArgs e)
        {
            //prvi tab
            list1 = await GetPagedListActiveAsync();
            actUcioniceGridView.DataSource = list1.ToList();

            //drugi tab
            list2 = await GetPagedListStareAsync();
            strUcioniceGridView.DataSource = list2.ToList();

           
           //promjena dugmadi tab1
           BackBtn.Enabled = list1.HasPreviousPage;
           ForwardBtn.Enabled = list1.HasNextPage;
           pageNumLabel.Text= string.Format("{0}/{1}", pageNummber1, list1.PageCount);
            

           
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {

                
                BackBtn.Enabled = list1.HasPreviousPage;
                ForwardBtn.Enabled = list1.HasNextPage;
                pageNumLabel.Text = string.Format("{0}/{1}", pageNummber1, list1.PageCount);
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {

               
                BackBtn.Enabled = list2.HasPreviousPage;
                ForwardBtn.Enabled = list2.HasNextPage;
                pageNumLabel.Text = string.Format("{0}/{1}", pageNummber2, list2.PageCount);
            }
        }

        private async void BackBtn_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {


                if (list1.HasPreviousPage)
                {
                    list1 = await GetPagedListActiveAsync(--pageNummber1);
                    BackBtn.Enabled = list1.HasPreviousPage;
                    ForwardBtn.Enabled = list1.HasNextPage;
                    actUcioniceGridView.DataSource = list1.ToList();
                    pageNumLabel.Text = string.Format("Page {0}/{1}", pageNummber1, list1.PageCount);

                }
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {


                if (list1.HasPreviousPage)
                {
                    list2 = await GetPagedListStareAsync(--pageNummber1);
                    BackBtn.Enabled = list2.HasPreviousPage;
                    ForwardBtn.Enabled = list2.HasNextPage;
                    strUcioniceGridView.DataSource = list2.ToList();
                    pageNumLabel.Text = string.Format("Page {0}/{1}", pageNummber2, list2.PageCount);

                }
            }
        }

        private async void ForwardBtn_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {


                if (list1.HasNextPage)
                {
                    list1 = await GetPagedListActiveAsync(++pageNummber1);
                    BackBtn.Enabled = list1.HasPreviousPage;
                    ForwardBtn.Enabled = list1.HasNextPage;
                    actUcioniceGridView.DataSource = list1.ToList();
                    pageNumLabel.Text = string.Format("Page {0}/{1}", pageNummber1, list1.PageCount);

                }
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {


                if (list1.HasNextPage)
                {
                    list2 = await GetPagedListStareAsync(++pageNummber1);
                    BackBtn.Enabled = list2.HasPreviousPage;
                    ForwardBtn.Enabled = list2.HasNextPage;
                    strUcioniceGridView.DataSource = list2.ToList();
                    pageNumLabel.Text = string.Format("Page {0}/{1}", pageNummber2, list2.PageCount);

                }
            }
        }

       

        private void DetaljiBtn_Click(object sender, EventArgs e)
        {

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {


                if (actUcioniceGridView.SelectedRows.Count != 0)
                {
                    UcionicaDetails ucionicaDetalj = new UcionicaDetails(Convert.ToInt32(actUcioniceGridView.SelectedRows[0].Cells[0].Value));
                    ucionicaDetalj.ShowDialog();
                    ucionicaDetalj.MdiParent = this.MdiParent;
                }
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {


                if (strUcioniceGridView.SelectedRows.Count != 0)
                {
                    UcionicaDetails ucionicaDetalj = new UcionicaDetails(Convert.ToInt32(strUcioniceGridView.SelectedRows[0].Cells[0].Value));
                    ucionicaDetalj.ShowDialog();
                    ucionicaDetalj.MdiParent = this.MdiParent;
                }
            }

        }
    }
}
