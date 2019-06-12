namespace Tutor_UI.Users.Tutor
{
    partial class StudentiForm
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
            this.studentiGridView = new System.Windows.Forms.DataGridView();
            this.BackBtn = new System.Windows.Forms.Button();
            this.FowardBtn = new System.Windows.Forms.Button();
            this.brojListe = new System.Windows.Forms.Label();
            this.PregledBtn = new System.Windows.Forms.Button();
            this.PrijaviBtn = new System.Windows.Forms.Button();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipStudenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdradjenihCasova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OcjenaStudenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentiGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentiGridView
            // 
            this.studentiGridView.AllowUserToAddRows = false;
            this.studentiGridView.AllowUserToDeleteRows = false;
            this.studentiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentiGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.ImePrezime,
            this.Spol,
            this.Godine,
            this.TipStudenta,
            this.OdradjenihCasova,
            this.OcjenaStudenta});
            this.studentiGridView.Location = new System.Drawing.Point(1, 0);
            this.studentiGridView.Name = "studentiGridView";
            this.studentiGridView.ReadOnly = true;
            this.studentiGridView.Size = new System.Drawing.Size(457, 289);
            this.studentiGridView.TabIndex = 0;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(103, 295);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(56, 26);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "<";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // FowardBtn
            // 
            this.FowardBtn.Location = new System.Drawing.Point(276, 295);
            this.FowardBtn.Name = "FowardBtn";
            this.FowardBtn.Size = new System.Drawing.Size(56, 26);
            this.FowardBtn.TabIndex = 2;
            this.FowardBtn.Text = ">";
            this.FowardBtn.UseVisualStyleBackColor = true;
            this.FowardBtn.Click += new System.EventHandler(this.FowardBtn_Click);
            // 
            // brojListe
            // 
            this.brojListe.AutoSize = true;
            this.brojListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brojListe.Location = new System.Drawing.Point(204, 302);
            this.brojListe.Name = "brojListe";
            this.brojListe.Size = new System.Drawing.Size(27, 13);
            this.brojListe.TabIndex = 3;
            this.brojListe.Text = "0/0";
            // 
            // PregledBtn
            // 
            this.PregledBtn.Location = new System.Drawing.Point(495, 12);
            this.PregledBtn.Name = "PregledBtn";
            this.PregledBtn.Size = new System.Drawing.Size(84, 33);
            this.PregledBtn.TabIndex = 4;
            this.PregledBtn.Text = "Pregled";
            this.PregledBtn.UseVisualStyleBackColor = true;
            this.PregledBtn.Click += new System.EventHandler(this.PregledBtn_Click);
            // 
            // PrijaviBtn
            // 
            this.PrijaviBtn.Location = new System.Drawing.Point(495, 51);
            this.PrijaviBtn.Name = "PrijaviBtn";
            this.PrijaviBtn.Size = new System.Drawing.Size(84, 32);
            this.PrijaviBtn.TabIndex = 5;
            this.PrijaviBtn.Text = "Prijavi";
            this.PrijaviBtn.UseVisualStyleBackColor = true;
            this.PrijaviBtn.Click += new System.EventHandler(this.PrijaviBtn_Click);
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "StudentId";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Visible = false;
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Student";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            this.ImePrezime.Width = 69;
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            this.Spol.ReadOnly = true;
            this.Spol.Width = 45;
            // 
            // Godine
            // 
            this.Godine.DataPropertyName = "Godine";
            this.Godine.HeaderText = "Godine";
            this.Godine.Name = "Godine";
            this.Godine.ReadOnly = true;
            this.Godine.Width = 47;
            // 
            // TipStudenta
            // 
            this.TipStudenta.DataPropertyName = "TipStudenta";
            this.TipStudenta.HeaderText = "Tip studenta";
            this.TipStudenta.Name = "TipStudenta";
            this.TipStudenta.ReadOnly = true;
            this.TipStudenta.Width = 85;
            // 
            // OdradjenihCasova
            // 
            this.OdradjenihCasova.DataPropertyName = "OdradjenihCasova";
            this.OdradjenihCasova.HeaderText = "Broj casova";
            this.OdradjenihCasova.Name = "OdradjenihCasova";
            this.OdradjenihCasova.ReadOnly = true;
            this.OdradjenihCasova.Width = 60;
            // 
            // OcjenaStudenta
            // 
            this.OcjenaStudenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OcjenaStudenta.DataPropertyName = "OcjenaStudenta";
            this.OcjenaStudenta.HeaderText = "Ocjena";
            this.OcjenaStudenta.Name = "OcjenaStudenta";
            this.OcjenaStudenta.ReadOnly = true;
            // 
            // StudentiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 329);
            this.Controls.Add(this.PrijaviBtn);
            this.Controls.Add(this.PregledBtn);
            this.Controls.Add(this.brojListe);
            this.Controls.Add(this.FowardBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.studentiGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentiForm";
            this.ShowIcon = false;
            this.Text = "Studenti";
            ((System.ComponentModel.ISupportInitialize)(this.studentiGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentiGridView;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button FowardBtn;
        private System.Windows.Forms.Label brojListe;
        private System.Windows.Forms.Button PregledBtn;
        private System.Windows.Forms.Button PrijaviBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godine;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipStudenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdradjenihCasova;
        private System.Windows.Forms.DataGridViewTextBoxColumn OcjenaStudenta;
    }
}