namespace Tutor_UI.Users.Tutor
{
    partial class OdrediTermin
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
            this.DatumCasaDatePicker = new System.Windows.Forms.DateTimePicker();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.terminiGridView = new System.Windows.Forms.DataGridView();
            this.TerminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZahtjevId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemePocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZakaziBtn = new System.Windows.Forms.Button();
            this.BrojTerminaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.terminiGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DatumCasaDatePicker
            // 
            this.DatumCasaDatePicker.Location = new System.Drawing.Point(12, 39);
            this.DatumCasaDatePicker.Name = "DatumCasaDatePicker";
            this.DatumCasaDatePicker.Size = new System.Drawing.Size(200, 20);
            this.DatumCasaDatePicker.TabIndex = 0;
            // 
            // TimePicker
            // 
            this.TimePicker.Location = new System.Drawing.Point(233, 39);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(75, 20);
            this.TimePicker.TabIndex = 1;
            // 
            // terminiGridView
            // 
            this.terminiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.terminiGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TerminId,
            this.ZahtjevId,
            this.DatumCasa,
            this.VrijemePocetka,
            this.DanNaziv});
            this.terminiGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.terminiGridView.Location = new System.Drawing.Point(0, 135);
            this.terminiGridView.Name = "terminiGridView";
            this.terminiGridView.Size = new System.Drawing.Size(344, 157);
            this.terminiGridView.TabIndex = 2;
            // 
            // TerminId
            // 
            this.TerminId.DataPropertyName = "TerminId";
            this.TerminId.HeaderText = "TerminId";
            this.TerminId.Name = "TerminId";
            this.TerminId.ReadOnly = true;
            this.TerminId.Visible = false;
            // 
            // ZahtjevId
            // 
            this.ZahtjevId.DataPropertyName = "ZahtjevId";
            this.ZahtjevId.HeaderText = "ZahtjevId";
            this.ZahtjevId.Name = "ZahtjevId";
            this.ZahtjevId.ReadOnly = true;
            this.ZahtjevId.Visible = false;
            // 
            // DatumCasa
            // 
            this.DatumCasa.DataPropertyName = "DatumCasa";
            this.DatumCasa.HeaderText = "DatumCasa";
            this.DatumCasa.Name = "DatumCasa";
            this.DatumCasa.ReadOnly = true;
            // 
            // VrijemePocetka
            // 
            this.VrijemePocetka.DataPropertyName = "VrijemePocetka";
            this.VrijemePocetka.HeaderText = "VrijemePocetka";
            this.VrijemePocetka.Name = "VrijemePocetka";
            this.VrijemePocetka.ReadOnly = true;
            // 
            // DanNaziv
            // 
            this.DanNaziv.DataPropertyName = "DanNaziv";
            this.DanNaziv.HeaderText = "DanNaziv";
            this.DanNaziv.Name = "DanNaziv";
            this.DanNaziv.ReadOnly = true;
            // 
            // ZakaziBtn
            // 
            this.ZakaziBtn.Location = new System.Drawing.Point(233, 77);
            this.ZakaziBtn.Name = "ZakaziBtn";
            this.ZakaziBtn.Size = new System.Drawing.Size(75, 23);
            this.ZakaziBtn.TabIndex = 3;
            this.ZakaziBtn.Text = "Zakazi";
            this.ZakaziBtn.UseVisualStyleBackColor = true;
            this.ZakaziBtn.Click += new System.EventHandler(this.ZakaziBtn_Click);
            // 
            // BrojTerminaLabel
            // 
            this.BrojTerminaLabel.AutoSize = true;
            this.BrojTerminaLabel.Location = new System.Drawing.Point(151, 87);
            this.BrojTerminaLabel.Name = "BrojTerminaLabel";
            this.BrojTerminaLabel.Size = new System.Drawing.Size(35, 13);
            this.BrojTerminaLabel.TabIndex = 4;
            this.BrojTerminaLabel.Text = "label1";
            // 
            // OdrediTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 292);
            this.Controls.Add(this.BrojTerminaLabel);
            this.Controls.Add(this.ZakaziBtn);
            this.Controls.Add(this.terminiGridView);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.DatumCasaDatePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OdrediTermin";
            this.ShowIcon = false;
            this.Text = "Odredi termin";
            ((System.ComponentModel.ISupportInitialize)(this.terminiGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatumCasaDatePicker;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.DataGridView terminiGridView;
        private System.Windows.Forms.Button ZakaziBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZahtjevId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumCasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemePocetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanNaziv;
        private System.Windows.Forms.Label BrojTerminaLabel;
    }
}