namespace Tutor_UI.Users
{
    partial class ReportTutora
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
            this.Tutor_SelectBest_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gradCmb = new System.Windows.Forms.ComboBox();
            this.datumOdDatePicker = new System.Windows.Forms.DateTimePicker();
            this.oblastCmb = new System.Windows.Forms.ComboBox();
            this.datumDoDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.izbrisiDatumBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tutor_SelectBest_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Tutor_SelectBest_ResultBindingSource
            // 
            this.Tutor_SelectBest_ResultBindingSource.DataSource = typeof(Tutor_API.Models.Tutor_SelectBest_Result);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Left;
            reportDataSource1.Name = "dsBestTutor";
            reportDataSource1.Value = this.Tutor_SelectBest_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Tutor_UI.Report.BestTutorReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(394, 408);
            this.reportViewer1.TabIndex = 0;
            // 
            // gradCmb
            // 
            this.gradCmb.FormattingEnabled = true;
            this.gradCmb.Location = new System.Drawing.Point(410, 25);
            this.gradCmb.Name = "gradCmb";
            this.gradCmb.Size = new System.Drawing.Size(121, 21);
            this.gradCmb.TabIndex = 1;
            // 
            // datumOdDatePicker
            // 
            this.datumOdDatePicker.Location = new System.Drawing.Point(410, 106);
            this.datumOdDatePicker.Name = "datumOdDatePicker";
            this.datumOdDatePicker.Size = new System.Drawing.Size(124, 20);
            this.datumOdDatePicker.TabIndex = 2;
            this.datumOdDatePicker.ValueChanged += new System.EventHandler(this.datumOdDatePicker_ValueChanged);
            // 
            // oblastCmb
            // 
            this.oblastCmb.FormattingEnabled = true;
            this.oblastCmb.Location = new System.Drawing.Point(410, 65);
            this.oblastCmb.Name = "oblastCmb";
            this.oblastCmb.Size = new System.Drawing.Size(121, 21);
            this.oblastCmb.TabIndex = 3;
            // 
            // datumDoDatePicker
            // 
            this.datumDoDatePicker.Location = new System.Drawing.Point(410, 147);
            this.datumDoDatePicker.Name = "datumDoDatePicker";
            this.datumDoDatePicker.Size = new System.Drawing.Size(124, 20);
            this.datumDoDatePicker.TabIndex = 4;
            this.datumDoDatePicker.ValueChanged += new System.EventHandler(this.datumDoDatePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Oblast";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datum od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Datum do";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(410, 173);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(197, 30);
            this.refreshBtn.TabIndex = 9;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // izbrisiDatumBtn
            // 
            this.izbrisiDatumBtn.Location = new System.Drawing.Point(540, 123);
            this.izbrisiDatumBtn.Name = "izbrisiDatumBtn";
            this.izbrisiDatumBtn.Size = new System.Drawing.Size(57, 29);
            this.izbrisiDatumBtn.TabIndex = 10;
            this.izbrisiDatumBtn.Text = "Izbrisi";
            this.izbrisiDatumBtn.UseVisualStyleBackColor = true;
            this.izbrisiDatumBtn.Click += new System.EventHandler(this.izbrisiDatumBtn_Click);
            // 
            // ReportTutora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 408);
            this.Controls.Add(this.izbrisiDatumBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datumDoDatePicker);
            this.Controls.Add(this.oblastCmb);
            this.Controls.Add(this.datumOdDatePicker);
            this.Controls.Add(this.gradCmb);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportTutora";
            this.ShowIcon = false;
            this.Text = "Report tutora";
            this.Load += new System.EventHandler(this.ReportTutora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tutor_SelectBest_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox gradCmb;
        private System.Windows.Forms.DateTimePicker datumOdDatePicker;
        private System.Windows.Forms.ComboBox oblastCmb;
        private System.Windows.Forms.DateTimePicker datumDoDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button izbrisiDatumBtn;
        private System.Windows.Forms.BindingSource Tutor_SelectBest_ResultBindingSource;
    }
}