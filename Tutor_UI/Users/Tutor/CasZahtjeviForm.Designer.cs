namespace Tutor_UI.Users.Tutor
{
    partial class CasZahtjeviForm
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
            this.neProcitanoGridView = new System.Windows.Forms.DataGridView();
            this.ZahtjevId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipStudenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumSlanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojCasova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zahtjeviTerminiTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.terminiGridView = new System.Windows.Forms.DataGridView();
            this.OdbijBtn = new System.Windows.Forms.Button();
            this.PregledBtn = new System.Windows.Forms.Button();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipStudentaT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodineS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemePocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.neProcitanoGridView)).BeginInit();
            this.zahtjeviTerminiTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.terminiGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // neProcitanoGridView
            // 
            this.neProcitanoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.neProcitanoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZahtjevId,
            this.Student,
            this.TipStudenta,
            this.Godine,
            this.DatumSlanja,
            this.BrojCasova,
            this.Ocjena});
            this.neProcitanoGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.neProcitanoGridView.Location = new System.Drawing.Point(3, 3);
            this.neProcitanoGridView.Name = "neProcitanoGridView";
            this.neProcitanoGridView.Size = new System.Drawing.Size(553, 266);
            this.neProcitanoGridView.TabIndex = 0;
            // 
            // ZahtjevId
            // 
            this.ZahtjevId.DataPropertyName = "ZahtjevId";
            this.ZahtjevId.HeaderText = "ZahtjevId";
            this.ZahtjevId.Name = "ZahtjevId";
            this.ZahtjevId.ReadOnly = true;
            this.ZahtjevId.Visible = false;
            // 
            // Student
            // 
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // TipStudenta
            // 
            this.TipStudenta.DataPropertyName = "TipStudenta";
            this.TipStudenta.HeaderText = "TipStudenta";
            this.TipStudenta.Name = "TipStudenta";
            this.TipStudenta.ReadOnly = true;
            // 
            // Godine
            // 
            this.Godine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Godine.DataPropertyName = "Godine";
            this.Godine.HeaderText = "Godine";
            this.Godine.Name = "Godine";
            this.Godine.ReadOnly = true;
            this.Godine.Width = 66;
            // 
            // DatumSlanja
            // 
            this.DatumSlanja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DatumSlanja.DataPropertyName = "DatumSlanja";
            this.DatumSlanja.HeaderText = "DatumSlanja";
            this.DatumSlanja.Name = "DatumSlanja";
            this.DatumSlanja.ReadOnly = true;
            this.DatumSlanja.Width = 92;
            // 
            // BrojCasova
            // 
            this.BrojCasova.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.BrojCasova.DataPropertyName = "BrojCasova";
            this.BrojCasova.HeaderText = "BrojCasova";
            this.BrojCasova.Name = "BrojCasova";
            this.BrojCasova.ReadOnly = true;
            this.BrojCasova.Width = 86;
            // 
            // Ocjena
            // 
            this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            this.Ocjena.Width = 66;
            // 
            // zahtjeviTerminiTabControl
            // 
            this.zahtjeviTerminiTabControl.Controls.Add(this.tabPage1);
            this.zahtjeviTerminiTabControl.Controls.Add(this.tabPage2);
            this.zahtjeviTerminiTabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.zahtjeviTerminiTabControl.Location = new System.Drawing.Point(0, 0);
            this.zahtjeviTerminiTabControl.Name = "zahtjeviTerminiTabControl";
            this.zahtjeviTerminiTabControl.SelectedIndex = 0;
            this.zahtjeviTerminiTabControl.Size = new System.Drawing.Size(567, 298);
            this.zahtjeviTerminiTabControl.TabIndex = 1;
            this.zahtjeviTerminiTabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.zahtjeviTerminiTabControl_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.neProcitanoGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(559, 272);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zahtjevi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.terminiGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(559, 272);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Termini";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // terminiGridView
            // 
            this.terminiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.terminiGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.ImePrezime,
            this.TipStudentaT,
            this.GodineS,
            this.DanNaziv,
            this.VrijemePocetka,
            this.DatumCasa});
            this.terminiGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.terminiGridView.Location = new System.Drawing.Point(3, 3);
            this.terminiGridView.Name = "terminiGridView";
            this.terminiGridView.Size = new System.Drawing.Size(553, 266);
            this.terminiGridView.TabIndex = 1;
            // 
            // OdbijBtn
            // 
            this.OdbijBtn.Location = new System.Drawing.Point(589, 79);
            this.OdbijBtn.Name = "OdbijBtn";
            this.OdbijBtn.Size = new System.Drawing.Size(93, 30);
            this.OdbijBtn.TabIndex = 2;
            this.OdbijBtn.Text = "Odbij";
            this.OdbijBtn.UseVisualStyleBackColor = true;
            this.OdbijBtn.Click += new System.EventHandler(this.OdbijBtn_Click);
            // 
            // PregledBtn
            // 
            this.PregledBtn.Location = new System.Drawing.Point(589, 25);
            this.PregledBtn.Name = "PregledBtn";
            this.PregledBtn.Size = new System.Drawing.Size(93, 35);
            this.PregledBtn.TabIndex = 3;
            this.PregledBtn.Text = "Pregled";
            this.PregledBtn.UseVisualStyleBackColor = true;
            this.PregledBtn.Click += new System.EventHandler(this.PregledBtn_Click);
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
            // TipStudentaT
            // 
            this.TipStudentaT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TipStudentaT.DataPropertyName = "TipStudenta";
            this.TipStudentaT.HeaderText = "Tip studenta";
            this.TipStudentaT.Name = "TipStudentaT";
            this.TipStudentaT.ReadOnly = true;
            this.TipStudentaT.Width = 91;
            // 
            // GodineS
            // 
            this.GodineS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GodineS.DataPropertyName = "Godine";
            this.GodineS.HeaderText = "Broj godina";
            this.GodineS.Name = "GodineS";
            this.GodineS.ReadOnly = true;
            this.GodineS.Width = 65;
            // 
            // DanNaziv
            // 
            this.DanNaziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DanNaziv.DataPropertyName = "DanNaziv";
            this.DanNaziv.HeaderText = "Dan";
            this.DanNaziv.Name = "DanNaziv";
            this.DanNaziv.ReadOnly = true;
            // 
            // VrijemePocetka
            // 
            this.VrijemePocetka.DataPropertyName = "VrijemePocetka";
            this.VrijemePocetka.HeaderText = "Vrijem pocetka casa";
            this.VrijemePocetka.Name = "VrijemePocetka";
            this.VrijemePocetka.ReadOnly = true;
            // 
            // DatumCasa
            // 
            this.DatumCasa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DatumCasa.DataPropertyName = "DatumCasa";
            this.DatumCasa.HeaderText = "Datum casa";
            this.DatumCasa.Name = "DatumCasa";
            this.DatumCasa.ReadOnly = true;
            this.DatumCasa.Width = 82;
            // 
            // CasZahtjeviForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 298);
            this.Controls.Add(this.PregledBtn);
            this.Controls.Add(this.OdbijBtn);
            this.Controls.Add(this.zahtjeviTerminiTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CasZahtjeviForm";
            this.ShowIcon = false;
            this.Text = "Casovi";
            ((System.ComponentModel.ISupportInitialize)(this.neProcitanoGridView)).EndInit();
            this.zahtjeviTerminiTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.terminiGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView neProcitanoGridView;
        private System.Windows.Forms.TabControl zahtjeviTerminiTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView terminiGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZahtjevId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipStudenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godine;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumSlanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojCasova;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.Button OdbijBtn;
        private System.Windows.Forms.Button PregledBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipStudentaT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodineS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemePocetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumCasa;
    }
}