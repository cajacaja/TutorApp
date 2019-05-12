namespace Tutor_UI.Users
{
    partial class TutorForm
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
            this.searchNameInput = new System.Windows.Forms.TextBox();
            this.GradoviCmb = new System.Windows.Forms.ComboBox();
            this.TraziBtn = new System.Windows.Forms.Button();
            this.TutorGridView = new System.Windows.Forms.DataGridView();
            this.DodajBtn = new System.Windows.Forms.Button();
            this.PredmetCmb = new System.Windows.Forms.ComboBox();
            this.DetaljBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.brojListe = new System.Windows.Forms.Label();
            this.ForwardBtn = new System.Windows.Forms.Button();
            this.TutorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDodavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutorTumbnail = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TutorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchNameInput
            // 
            this.searchNameInput.Location = new System.Drawing.Point(12, 22);
            this.searchNameInput.Name = "searchNameInput";
            this.searchNameInput.Size = new System.Drawing.Size(209, 20);
            this.searchNameInput.TabIndex = 0;
            // 
            // GradoviCmb
            // 
            this.GradoviCmb.FormattingEnabled = true;
            this.GradoviCmb.Location = new System.Drawing.Point(227, 21);
            this.GradoviCmb.Name = "GradoviCmb";
            this.GradoviCmb.Size = new System.Drawing.Size(95, 21);
            this.GradoviCmb.TabIndex = 1;
            // 
            // TraziBtn
            // 
            this.TraziBtn.Location = new System.Drawing.Point(459, 22);
            this.TraziBtn.Name = "TraziBtn";
            this.TraziBtn.Size = new System.Drawing.Size(75, 23);
            this.TraziBtn.TabIndex = 2;
            this.TraziBtn.Text = "Pretraga";
            this.TraziBtn.UseVisualStyleBackColor = true;
            this.TraziBtn.Click += new System.EventHandler(this.TraziBtn_Click);
            // 
            // TutorGridView
            // 
            this.TutorGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.TutorGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TutorId,
            this.Ime,
            this.Prezime,
            this.Spol,
            this.DatumRodjenja,
            this.DatumDodavanja,
            this.Grad,
            this.Predmet,
            this.TutorTumbnail});
            this.TutorGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TutorGridView.Location = new System.Drawing.Point(0, 109);
            this.TutorGridView.Name = "TutorGridView";
            this.TutorGridView.Size = new System.Drawing.Size(857, 285);
            this.TutorGridView.TabIndex = 3;
            // 
            // DodajBtn
            // 
            this.DodajBtn.Location = new System.Drawing.Point(730, 22);
            this.DodajBtn.Name = "DodajBtn";
            this.DodajBtn.Size = new System.Drawing.Size(75, 23);
            this.DodajBtn.TabIndex = 4;
            this.DodajBtn.Text = "Dodaj";
            this.DodajBtn.UseVisualStyleBackColor = true;
            this.DodajBtn.Click += new System.EventHandler(this.DodajBtn_Click);
            // 
            // PredmetCmb
            // 
            this.PredmetCmb.FormattingEnabled = true;
            this.PredmetCmb.Location = new System.Drawing.Point(345, 22);
            this.PredmetCmb.Name = "PredmetCmb";
            this.PredmetCmb.Size = new System.Drawing.Size(94, 21);
            this.PredmetCmb.TabIndex = 5;
            // 
            // DetaljBtn
            // 
            this.DetaljBtn.Location = new System.Drawing.Point(649, 22);
            this.DetaljBtn.Name = "DetaljBtn";
            this.DetaljBtn.Size = new System.Drawing.Size(75, 23);
            this.DetaljBtn.TabIndex = 6;
            this.DetaljBtn.Text = "Detalji";
            this.DetaljBtn.UseVisualStyleBackColor = true;
            this.DetaljBtn.Click += new System.EventHandler(this.DetaljBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(284, 80);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(38, 23);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "<";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // brojListe
            // 
            this.brojListe.AutoSize = true;
            this.brojListe.Location = new System.Drawing.Point(404, 85);
            this.brojListe.Name = "brojListe";
            this.brojListe.Size = new System.Drawing.Size(24, 13);
            this.brojListe.TabIndex = 9;
            this.brojListe.Text = "0/0";
            // 
            // ForwardBtn
            // 
            this.ForwardBtn.Location = new System.Drawing.Point(518, 80);
            this.ForwardBtn.Name = "ForwardBtn";
            this.ForwardBtn.Size = new System.Drawing.Size(38, 23);
            this.ForwardBtn.TabIndex = 10;
            this.ForwardBtn.Text = ">";
            this.ForwardBtn.UseVisualStyleBackColor = true;
            this.ForwardBtn.Click += new System.EventHandler(this.ForwardBtn_Click);
            // 
            // TutorId
            // 
            this.TutorId.DataPropertyName = "TutorId";
            this.TutorId.HeaderText = "TutorId";
            this.TutorId.Name = "TutorId";
            this.TutorId.ReadOnly = true;
            this.TutorId.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            this.Spol.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "Datum rodjenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            // 
            // DatumDodavanja
            // 
            this.DatumDodavanja.DataPropertyName = "DatumDodavanja";
            this.DatumDodavanja.HeaderText = "Datum dodavanja";
            this.DatumDodavanja.Name = "DatumDodavanja";
            this.DatumDodavanja.ReadOnly = true;
            // 
            // Grad
            // 
            this.Grad.DataPropertyName = "Grad";
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // TutorTumbnail
            // 
            this.TutorTumbnail.DataPropertyName = "TutorTumbnail";
            this.TutorTumbnail.HeaderText = "Slika tutora";
            this.TutorTumbnail.Name = "TutorTumbnail";
            this.TutorTumbnail.ReadOnly = true;
            // 
            // TutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 394);
            this.Controls.Add(this.ForwardBtn);
            this.Controls.Add(this.brojListe);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DetaljBtn);
            this.Controls.Add(this.PredmetCmb);
            this.Controls.Add(this.DodajBtn);
            this.Controls.Add(this.TutorGridView);
            this.Controls.Add(this.TraziBtn);
            this.Controls.Add(this.GradoviCmb);
            this.Controls.Add(this.searchNameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TutorForm";
            this.ShowIcon = false;
            this.Text = "TutorForm";
            this.Load += new System.EventHandler(this.TutorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TutorGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchNameInput;
        private System.Windows.Forms.ComboBox GradoviCmb;
        private System.Windows.Forms.Button TraziBtn;
        private System.Windows.Forms.DataGridView TutorGridView;
        private System.Windows.Forms.Button DodajBtn;
        private System.Windows.Forms.ComboBox PredmetCmb;
        private System.Windows.Forms.Button DetaljBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label brojListe;
        private System.Windows.Forms.Button ForwardBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumDodavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewImageColumn TutorTumbnail;
    }
}