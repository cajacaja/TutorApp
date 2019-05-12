namespace Tutor_UI.Users
{
    partial class AdministratorForm
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
            this.searchInput = new System.Windows.Forms.TextBox();
            this.TraziBtn = new System.Windows.Forms.Button();
            this.DodajBtn = new System.Windows.Forms.Button();
            this.administratorGrid = new System.Windows.Forms.DataGridView();
            this.EditBtn = new System.Windows.Forms.Button();
            this.brojListe = new System.Windows.Forms.Label();
            this.FowardBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.AdministratorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDodavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.administratorGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(12, 12);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(274, 20);
            this.searchInput.TabIndex = 0;
            // 
            // TraziBtn
            // 
            this.TraziBtn.Location = new System.Drawing.Point(324, 12);
            this.TraziBtn.Name = "TraziBtn";
            this.TraziBtn.Size = new System.Drawing.Size(75, 23);
            this.TraziBtn.TabIndex = 1;
            this.TraziBtn.Text = "Trazi";
            this.TraziBtn.UseVisualStyleBackColor = true;
            this.TraziBtn.Click += new System.EventHandler(this.TraziBtn_Click);
            // 
            // DodajBtn
            // 
            this.DodajBtn.Location = new System.Drawing.Point(544, 12);
            this.DodajBtn.Name = "DodajBtn";
            this.DodajBtn.Size = new System.Drawing.Size(75, 27);
            this.DodajBtn.TabIndex = 2;
            this.DodajBtn.Text = "Dodaj";
            this.DodajBtn.UseVisualStyleBackColor = true;
            this.DodajBtn.Click += new System.EventHandler(this.DodajBtn_Click);
            // 
            // administratorGrid
            // 
            this.administratorGrid.AllowUserToAddRows = false;
            this.administratorGrid.AllowUserToDeleteRows = false;
            this.administratorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.administratorGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdministratorId,
            this.Ime,
            this.Prezime,
            this.KorisnickoIme,
            this.DatumDodavanja,
            this.Email,
            this.Telefon});
            this.administratorGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.administratorGrid.Location = new System.Drawing.Point(0, 102);
            this.administratorGrid.Name = "administratorGrid";
            this.administratorGrid.ReadOnly = true;
            this.administratorGrid.Size = new System.Drawing.Size(724, 176);
            this.administratorGrid.TabIndex = 3;
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(625, 12);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 27);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // brojListe
            // 
            this.brojListe.AutoSize = true;
            this.brojListe.Location = new System.Drawing.Point(346, 62);
            this.brojListe.Name = "brojListe";
            this.brojListe.Size = new System.Drawing.Size(24, 13);
            this.brojListe.TabIndex = 10;
            this.brojListe.Text = "0/0";
            // 
            // FowardBtn
            // 
            this.FowardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FowardBtn.Location = new System.Drawing.Point(458, 56);
            this.FowardBtn.Name = "FowardBtn";
            this.FowardBtn.Size = new System.Drawing.Size(31, 23);
            this.FowardBtn.TabIndex = 9;
            this.FowardBtn.Text = ">";
            this.FowardBtn.UseVisualStyleBackColor = true;
            this.FowardBtn.Click += new System.EventHandler(this.FowardBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackBtn.Location = new System.Drawing.Point(239, 56);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(31, 23);
            this.BackBtn.TabIndex = 8;
            this.BackBtn.Text = "<";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AdministratorId
            // 
            this.AdministratorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AdministratorId.DataPropertyName = "AdministratorId";
            this.AdministratorId.HeaderText = "AdministratorId";
            this.AdministratorId.Name = "AdministratorId";
            this.AdministratorId.ReadOnly = true;
            this.AdministratorId.Visible = false;
            this.AdministratorId.Width = 101;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 49;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.Width = 69;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisnicko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // DatumDodavanja
            // 
            this.DatumDodavanja.DataPropertyName = "DatumDodavanja";
            this.DatumDodavanja.HeaderText = "Datum dodavanja";
            this.DatumDodavanja.Name = "DatumDodavanja";
            this.DatumDodavanja.ReadOnly = true;
            this.DatumDodavanja.Width = 85;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 57;
            // 
            // Telefon
            // 
            this.Telefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 278);
            this.Controls.Add(this.brojListe);
            this.Controls.Add(this.FowardBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.administratorGrid);
            this.Controls.Add(this.DodajBtn);
            this.Controls.Add(this.TraziBtn);
            this.Controls.Add(this.searchInput);
            this.Name = "AdministratorForm";
            this.Text = "AdministratorForm";
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
            this.Enter += new System.EventHandler(this.AdministratorForm_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.administratorGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button TraziBtn;
        private System.Windows.Forms.Button DodajBtn;
        private System.Windows.Forms.DataGridView administratorGrid;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label brojListe;
        private System.Windows.Forms.Button FowardBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdministratorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumDodavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
    }
}