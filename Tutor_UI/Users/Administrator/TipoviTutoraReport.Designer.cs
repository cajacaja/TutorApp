namespace Tutor_UI.Users.Administrator
{
    partial class TipoviTutoraReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Report_TipoviStudenta_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gradCmb = new System.Windows.Forms.ComboBox();
            this.datumOdDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DatumDoDatePicker = new System.Windows.Forms.DateTimePicker();
            this.resetBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Report_TipoviStudenta_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Report_TipoviStudenta_ResultBindingSource
            // 
            this.Report_TipoviStudenta_ResultBindingSource.DataSource = typeof(Tutor_API.Models.Report_TipoviStudenta_Result);
            // 
            // Report
            // 
            this.Report.Dock = System.Windows.Forms.DockStyle.Left;
            reportDataSource2.Name = "tipoviStudenta";
            reportDataSource2.Value = this.Report_TipoviStudenta_ResultBindingSource;
            this.Report.LocalReport.DataSources.Add(reportDataSource2);
            this.Report.LocalReport.ReportEmbeddedResource = "Tutor_UI.Report.TipoviTutora.rdlc";
            this.Report.Location = new System.Drawing.Point(0, 0);
            this.Report.Name = "Report";
            this.Report.ServerReport.BearerToken = null;
            this.Report.Size = new System.Drawing.Size(396, 450);
            this.Report.TabIndex = 0;
            // 
            // gradCmb
            // 
            this.gradCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradCmb.FormattingEnabled = true;
            this.gradCmb.Location = new System.Drawing.Point(418, 27);
            this.gradCmb.Name = "gradCmb";
            this.gradCmb.Size = new System.Drawing.Size(121, 21);
            this.gradCmb.TabIndex = 1;
            // 
            // datumOdDatePicker
            // 
            this.datumOdDatePicker.Location = new System.Drawing.Point(418, 72);
            this.datumOdDatePicker.Name = "datumOdDatePicker";
            this.datumOdDatePicker.Size = new System.Drawing.Size(121, 20);
            this.datumOdDatePicker.TabIndex = 2;
            this.datumOdDatePicker.ValueChanged += new System.EventHandler(this.datumOdDatePicker_ValueChanged);
            // 
            // DatumDoDatePicker
            // 
            this.DatumDoDatePicker.Location = new System.Drawing.Point(418, 110);
            this.DatumDoDatePicker.Name = "DatumDoDatePicker";
            this.DatumDoDatePicker.Size = new System.Drawing.Size(121, 20);
            this.DatumDoDatePicker.TabIndex = 3;
            this.DatumDoDatePicker.ValueChanged += new System.EventHandler(this.DatumDoDatePicker_ValueChanged);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(545, 107);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(418, 145);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(202, 29);
            this.RefreshBtn.TabIndex = 8;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // TipoviTutoraReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.DatumDoDatePicker);
            this.Controls.Add(this.datumOdDatePicker);
            this.Controls.Add(this.gradCmb);
            this.Controls.Add(this.Report);
            this.Name = "TipoviTutoraReport";
            this.Text = "TipoviTutoraReport";
            this.Load += new System.EventHandler(this.TipoviTutoraReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Report_TipoviStudenta_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Report;
        private System.Windows.Forms.ComboBox gradCmb;
        private System.Windows.Forms.DateTimePicker datumOdDatePicker;
        private System.Windows.Forms.DateTimePicker DatumDoDatePicker;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.BindingSource Report_TipoviStudenta_ResultBindingSource;
    }
}