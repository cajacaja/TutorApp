namespace Tutor_UI.Users
{
    partial class BanovaniKorisniciForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TutoriTab = new System.Windows.Forms.TabPage();
            this.BanovaniTutoriGridView = new System.Windows.Forms.DataGridView();
            this.TutorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeTutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrezimeTutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDodavanjaTutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradTutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuentiTab = new System.Windows.Forms.TabPage();
            this.BanStudentsGridView = new System.Windows.Forms.DataGridView();
            this.PregledBtn = new System.Windows.Forms.Button();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDodavanjaStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.TutoriTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BanovaniTutoriGridView)).BeginInit();
            this.StuentiTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BanStudentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TutoriTab);
            this.tabControl1.Controls.Add(this.StuentiTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 316);
            this.tabControl1.TabIndex = 0;
            // 
            // TutoriTab
            // 
            this.TutoriTab.Controls.Add(this.BanovaniTutoriGridView);
            this.TutoriTab.Location = new System.Drawing.Point(4, 22);
            this.TutoriTab.Name = "TutoriTab";
            this.TutoriTab.Padding = new System.Windows.Forms.Padding(3);
            this.TutoriTab.Size = new System.Drawing.Size(452, 290);
            this.TutoriTab.TabIndex = 0;
            this.TutoriTab.Text = "Tutori";
            this.TutoriTab.UseVisualStyleBackColor = true;
            // 
            // BanovaniTutoriGridView
            // 
            this.BanovaniTutoriGridView.AllowUserToAddRows = false;
            this.BanovaniTutoriGridView.AllowUserToDeleteRows = false;
            this.BanovaniTutoriGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BanovaniTutoriGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TutorId,
            this.ImeTutor,
            this.PrezimeTutor,
            this.DatumDodavanjaTutor,
            this.GradTutor,
            this.Predmet});
            this.BanovaniTutoriGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BanovaniTutoriGridView.Location = new System.Drawing.Point(3, 3);
            this.BanovaniTutoriGridView.Name = "BanovaniTutoriGridView";
            this.BanovaniTutoriGridView.ReadOnly = true;
            this.BanovaniTutoriGridView.Size = new System.Drawing.Size(446, 284);
            this.BanovaniTutoriGridView.TabIndex = 0;
            // 
            // TutorId
            // 
            this.TutorId.DataPropertyName = "TutorId";
            this.TutorId.HeaderText = "TutorId";
            this.TutorId.Name = "TutorId";
            this.TutorId.ReadOnly = true;
            this.TutorId.Visible = false;
            // 
            // ImeTutor
            // 
            this.ImeTutor.DataPropertyName = "Ime";
            this.ImeTutor.HeaderText = "Ime";
            this.ImeTutor.Name = "ImeTutor";
            this.ImeTutor.ReadOnly = true;
            // 
            // PrezimeTutor
            // 
            this.PrezimeTutor.DataPropertyName = "Prezime";
            this.PrezimeTutor.HeaderText = "Prezime";
            this.PrezimeTutor.Name = "PrezimeTutor";
            this.PrezimeTutor.ReadOnly = true;
            // 
            // DatumDodavanjaTutor
            // 
            this.DatumDodavanjaTutor.DataPropertyName = "DatumDodavanja";
            this.DatumDodavanjaTutor.HeaderText = "Datum dodavanja";
            this.DatumDodavanjaTutor.Name = "DatumDodavanjaTutor";
            this.DatumDodavanjaTutor.ReadOnly = true;
            // 
            // GradTutor
            // 
            this.GradTutor.DataPropertyName = "Grad";
            this.GradTutor.HeaderText = "Grad";
            this.GradTutor.Name = "GradTutor";
            this.GradTutor.ReadOnly = true;
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // StuentiTab
            // 
            this.StuentiTab.Controls.Add(this.BanStudentsGridView);
            this.StuentiTab.Location = new System.Drawing.Point(4, 22);
            this.StuentiTab.Name = "StuentiTab";
            this.StuentiTab.Padding = new System.Windows.Forms.Padding(3);
            this.StuentiTab.Size = new System.Drawing.Size(452, 290);
            this.StuentiTab.TabIndex = 1;
            this.StuentiTab.Text = "Studenti";
            this.StuentiTab.UseVisualStyleBackColor = true;
            // 
            // BanStudentsGridView
            // 
            this.BanStudentsGridView.AllowUserToAddRows = false;
            this.BanStudentsGridView.AllowUserToDeleteRows = false;
            this.BanStudentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BanStudentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.Ime,
            this.Prezime,
            this.DatumDodavanjaStudent,
            this.GradStudent});
            this.BanStudentsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BanStudentsGridView.Location = new System.Drawing.Point(3, 3);
            this.BanStudentsGridView.Name = "BanStudentsGridView";
            this.BanStudentsGridView.ReadOnly = true;
            this.BanStudentsGridView.Size = new System.Drawing.Size(446, 284);
            this.BanStudentsGridView.TabIndex = 0;
            // 
            // PregledBtn
            // 
            this.PregledBtn.Location = new System.Drawing.Point(466, 25);
            this.PregledBtn.Name = "PregledBtn";
            this.PregledBtn.Size = new System.Drawing.Size(92, 37);
            this.PregledBtn.TabIndex = 0;
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
            // DatumDodavanjaStudent
            // 
            this.DatumDodavanjaStudent.DataPropertyName = "DatumDodavanja";
            this.DatumDodavanjaStudent.HeaderText = "Datum dodavanja";
            this.DatumDodavanjaStudent.Name = "DatumDodavanjaStudent";
            this.DatumDodavanjaStudent.ReadOnly = true;
            // 
            // GradStudent
            // 
            this.GradStudent.DataPropertyName = "Grad";
            this.GradStudent.HeaderText = "Grad";
            this.GradStudent.Name = "GradStudent";
            this.GradStudent.ReadOnly = true;
            // 
            // BanovaniKorisniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 316);
            this.Controls.Add(this.PregledBtn);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BanovaniKorisniciForm";
            this.ShowIcon = false;
            this.Text = "Banovani korisnici";
            
            this.tabControl1.ResumeLayout(false);
            this.TutoriTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BanovaniTutoriGridView)).EndInit();
            this.StuentiTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BanStudentsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TutoriTab;
        private System.Windows.Forms.DataGridView BanovaniTutoriGridView;
        private System.Windows.Forms.TabPage StuentiTab;
        private System.Windows.Forms.DataGridView BanStudentsGridView;
        private System.Windows.Forms.Button PregledBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeTutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrezimeTutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumDodavanjaTutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradTutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumDodavanjaStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradStudent;
    }
}