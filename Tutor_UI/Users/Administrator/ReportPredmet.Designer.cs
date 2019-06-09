namespace Tutor_UI.Users
{
    partial class ReportPredmet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GradCmb = new System.Windows.Forms.ComboBox();
            this.datumOdDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DatumDoDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.Predmet_Report_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Predmet_Report_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Left;
            reportDataSource1.Name = "PredmetDataSet";
            reportDataSource1.Value = this.Predmet_Report_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Tutor_UI.Report.ReportPredmet.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(321, 361);
            this.reportViewer1.TabIndex = 0;
            // 
            // GradCmb
            // 
            this.GradCmb.FormattingEnabled = true;
            this.GradCmb.Location = new System.Drawing.Point(330, 25);
            this.GradCmb.Name = "GradCmb";
            this.GradCmb.Size = new System.Drawing.Size(121, 21);
            this.GradCmb.TabIndex = 1;
            // 
            // datumOdDatePicker
            // 
            this.datumOdDatePicker.Location = new System.Drawing.Point(330, 77);
            this.datumOdDatePicker.Name = "datumOdDatePicker";
            this.datumOdDatePicker.Size = new System.Drawing.Size(121, 20);
            this.datumOdDatePicker.TabIndex = 2;
            this.datumOdDatePicker.ValueChanged += new System.EventHandler(this.datumOdDatePicker_ValueChanged);
            // 
            // DatumDoDatePicker
            // 
            this.DatumDoDatePicker.Location = new System.Drawing.Point(330, 124);
            this.DatumDoDatePicker.Name = "DatumDoDatePicker";
            this.DatumDoDatePicker.Size = new System.Drawing.Size(121, 20);
            this.DatumDoDatePicker.TabIndex = 3;
            this.DatumDoDatePicker.ValueChanged += new System.EventHandler(this.DatumDoDatePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Grad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum od";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum do";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(330, 166);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(184, 29);
            this.RefreshBtn.TabIndex = 7;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(468, 115);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(46, 29);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Predmet_Report_ResultBindingSource
            // 
            this.Predmet_Report_ResultBindingSource.DataSource = typeof(Tutor_API.Models.Predmet_Report_Result);
            // 
            // ReportPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 361);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatumDoDatePicker);
            this.Controls.Add(this.datumOdDatePicker);
            this.Controls.Add(this.GradCmb);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportPredmet";
            this.ShowIcon = false;
            this.Text = "Report predmeta";
            this.Load += new System.EventHandler(this.ReportPredmet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Predmet_Report_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox GradCmb;
        private System.Windows.Forms.DateTimePicker datumOdDatePicker;
        private System.Windows.Forms.DateTimePicker DatumDoDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.BindingSource Predmet_Report_ResultBindingSource;
    }
}