namespace Tutor_UI.Users
{
    partial class PrijaveStudentForm
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
            this.PregledBtn = new System.Windows.Forms.Button();
            this.ProcitanePrijaveGridView = new System.Windows.Forms.DataGridView();
            this.StaraPrijavaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutorProcitano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentProcitano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPrijaveProcitano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JelProcitano = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NovePrijaveGridView = new System.Windows.Forms.DataGridView();
            this.PrijavaTutorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPrijave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRead = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.IzbrisiBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProcitanePrijaveGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NovePrijaveGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PregledBtn
            // 
            this.PregledBtn.Location = new System.Drawing.Point(6, 37);
            this.PregledBtn.Name = "PregledBtn";
            this.PregledBtn.Size = new System.Drawing.Size(140, 42);
            this.PregledBtn.TabIndex = 4;
            this.PregledBtn.Text = "Pregled";
            this.PregledBtn.UseVisualStyleBackColor = true;
            this.PregledBtn.Click += new System.EventHandler(this.PregledBtn_Click);
            // 
            // ProcitanePrijaveGridView
            // 
            this.ProcitanePrijaveGridView.AllowUserToAddRows = false;
            this.ProcitanePrijaveGridView.AllowUserToDeleteRows = false;
            this.ProcitanePrijaveGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcitanePrijaveGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaraPrijavaId,
            this.TutorProcitano,
            this.StudentProcitano,
            this.DatumPrijaveProcitano,
            this.JelProcitano});
            this.ProcitanePrijaveGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcitanePrijaveGridView.Location = new System.Drawing.Point(3, 3);
            this.ProcitanePrijaveGridView.Name = "ProcitanePrijaveGridView";
            this.ProcitanePrijaveGridView.ReadOnly = true;
            this.ProcitanePrijaveGridView.Size = new System.Drawing.Size(443, 319);
            this.ProcitanePrijaveGridView.TabIndex = 0;
            // 
            // StaraPrijavaId
            // 
            this.StaraPrijavaId.DataPropertyName = "PrijavaTutorId";
            this.StaraPrijavaId.HeaderText = "StaraPrijavaId";
            this.StaraPrijavaId.Name = "StaraPrijavaId";
            this.StaraPrijavaId.ReadOnly = true;
            this.StaraPrijavaId.Visible = false;
            // 
            // TutorProcitano
            // 
            this.TutorProcitano.DataPropertyName = "Tutor";
            this.TutorProcitano.HeaderText = "Tutor(Prijavio)";
            this.TutorProcitano.Name = "TutorProcitano";
            this.TutorProcitano.ReadOnly = true;
            // 
            // StudentProcitano
            // 
            this.StudentProcitano.DataPropertyName = "Student";
            this.StudentProcitano.HeaderText = "Student(Prijavljen)";
            this.StudentProcitano.Name = "StudentProcitano";
            this.StudentProcitano.ReadOnly = true;
            // 
            // DatumPrijaveProcitano
            // 
            this.DatumPrijaveProcitano.DataPropertyName = "DatumPrijave";
            this.DatumPrijaveProcitano.HeaderText = "Datum prijave";
            this.DatumPrijaveProcitano.Name = "DatumPrijaveProcitano";
            this.DatumPrijaveProcitano.ReadOnly = true;
            // 
            // JelProcitano
            // 
            this.JelProcitano.DataPropertyName = "IsRead";
            this.JelProcitano.HeaderText = "Procitana prijava";
            this.JelProcitano.Name = "JelProcitano";
            this.JelProcitano.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ProcitanePrijaveGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(449, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stare prijave";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NovePrijaveGridView
            // 
            this.NovePrijaveGridView.AllowUserToAddRows = false;
            this.NovePrijaveGridView.AllowUserToDeleteRows = false;
            this.NovePrijaveGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NovePrijaveGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrijavaTutorId,
            this.Tutor,
            this.Student,
            this.DatumPrijave,
            this.IsRead});
            this.NovePrijaveGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NovePrijaveGridView.Location = new System.Drawing.Point(3, 3);
            this.NovePrijaveGridView.Name = "NovePrijaveGridView";
            this.NovePrijaveGridView.ReadOnly = true;
            this.NovePrijaveGridView.Size = new System.Drawing.Size(443, 319);
            this.NovePrijaveGridView.TabIndex = 0;
            // 
            // PrijavaTutorId
            // 
            this.PrijavaTutorId.DataPropertyName = "PrijavaTutorId";
            this.PrijavaTutorId.HeaderText = "PrijavaTutorId";
            this.PrijavaTutorId.Name = "PrijavaTutorId";
            this.PrijavaTutorId.ReadOnly = true;
            this.PrijavaTutorId.Visible = false;
            // 
            // Tutor
            // 
            this.Tutor.DataPropertyName = "Tutor";
            this.Tutor.HeaderText = "Tutor(Prijavio)";
            this.Tutor.Name = "Tutor";
            this.Tutor.ReadOnly = true;
            // 
            // Student
            // 
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student(Prijavljen)";
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // DatumPrijave
            // 
            this.DatumPrijave.DataPropertyName = "DatumPrijave";
            this.DatumPrijave.HeaderText = "DatumPrijave";
            this.DatumPrijave.Name = "DatumPrijave";
            this.DatumPrijave.ReadOnly = true;
            // 
            // IsRead
            // 
            this.IsRead.DataPropertyName = "IsRead";
            this.IsRead.HeaderText = "Prijava procitana";
            this.IsRead.Name = "IsRead";
            this.IsRead.ReadOnly = true;
            this.IsRead.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsRead.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NovePrijaveGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(449, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nove prijave";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(164, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(457, 351);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // IzbrisiBtn
            // 
            this.IzbrisiBtn.Location = new System.Drawing.Point(6, 99);
            this.IzbrisiBtn.Name = "IzbrisiBtn";
            this.IzbrisiBtn.Size = new System.Drawing.Size(140, 42);
            this.IzbrisiBtn.TabIndex = 5;
            this.IzbrisiBtn.Text = "Izbrisi";
            this.IzbrisiBtn.UseVisualStyleBackColor = true;
            this.IzbrisiBtn.Click += new System.EventHandler(this.IzbrisiBtn_Click);
            // 
            // PrijaveStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 351);
            this.Controls.Add(this.PregledBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.IzbrisiBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrijaveStudentForm";
            this.ShowIcon = false;
            this.Text = "Ban prijave od strane tutora";
            this.Load += new System.EventHandler(this.PrijaveStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcitanePrijaveGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NovePrijaveGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PregledBtn;
        private System.Windows.Forms.DataGridView ProcitanePrijaveGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView NovePrijaveGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrijavaTutorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPrijave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsRead;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button IzbrisiBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaraPrijavaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorProcitano;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentProcitano;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPrijaveProcitano;
        private System.Windows.Forms.DataGridViewCheckBoxColumn JelProcitano;
    }
}