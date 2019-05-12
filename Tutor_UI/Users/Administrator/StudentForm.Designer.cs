namespace Tutor_UI.Users
{
    partial class StudentForm
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
            this.TraziBtn = new System.Windows.Forms.Button();
            this.GradCmb = new System.Windows.Forms.ComboBox();
            this.StudentGridView = new System.Windows.Forms.DataGridView();
            this.DetaljiBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.FowardBtn = new System.Windows.Forms.Button();
            this.brojListe = new System.Windows.Forms.Label();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipStudenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDodavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchNameInput
            // 
            this.searchNameInput.Location = new System.Drawing.Point(12, 12);
            this.searchNameInput.Name = "searchNameInput";
            this.searchNameInput.Size = new System.Drawing.Size(185, 20);
            this.searchNameInput.TabIndex = 0;
            // 
            // TraziBtn
            // 
            this.TraziBtn.Location = new System.Drawing.Point(363, 12);
            this.TraziBtn.Name = "TraziBtn";
            this.TraziBtn.Size = new System.Drawing.Size(75, 23);
            this.TraziBtn.TabIndex = 1;
            this.TraziBtn.Text = "Trazi";
            this.TraziBtn.UseVisualStyleBackColor = true;
            this.TraziBtn.Click += new System.EventHandler(this.TraziBtn_Click);
            // 
            // GradCmb
            // 
            this.GradCmb.FormattingEnabled = true;
            this.GradCmb.Location = new System.Drawing.Point(215, 11);
            this.GradCmb.Name = "GradCmb";
            this.GradCmb.Size = new System.Drawing.Size(121, 21);
            this.GradCmb.TabIndex = 2;
            // 
            // StudentGridView
            // 
            this.StudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.Ime,
            this.Prezime,
            this.DatumRodjenja,
            this.DatumDodavanja,
            this.TipStudenta,
            this.Grad});
            this.StudentGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StudentGridView.Location = new System.Drawing.Point(0, 85);
            this.StudentGridView.Name = "StudentGridView";
            this.StudentGridView.Size = new System.Drawing.Size(620, 237);
            this.StudentGridView.TabIndex = 3;
            // 
            // DetaljiBtn
            // 
            this.DetaljiBtn.Location = new System.Drawing.Point(533, 12);
            this.DetaljiBtn.Name = "DetaljiBtn";
            this.DetaljiBtn.Size = new System.Drawing.Size(75, 23);
            this.DetaljiBtn.TabIndex = 4;
            this.DetaljiBtn.Text = "Detalji";
            this.DetaljiBtn.UseVisualStyleBackColor = true;
            this.DetaljiBtn.Click += new System.EventHandler(this.DetaljiBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackBtn.Location = new System.Drawing.Point(177, 56);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(31, 23);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "<";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // FowardBtn
            // 
            this.FowardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FowardBtn.Location = new System.Drawing.Point(396, 56);
            this.FowardBtn.Name = "FowardBtn";
            this.FowardBtn.Size = new System.Drawing.Size(31, 23);
            this.FowardBtn.TabIndex = 6;
            this.FowardBtn.Text = ">";
            this.FowardBtn.UseVisualStyleBackColor = true;
            this.FowardBtn.Click += new System.EventHandler(this.FowardBtn_Click);
            // 
            // brojListe
            // 
            this.brojListe.AutoSize = true;
            this.brojListe.Location = new System.Drawing.Point(284, 62);
            this.brojListe.Name = "brojListe";
            this.brojListe.Size = new System.Drawing.Size(24, 13);
            this.brojListe.TabIndex = 7;
            this.brojListe.Text = "0/0";
            // 
            // Grad
            // 
            this.Grad.DataPropertyName = "Grad";
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            // 
            // TipStudenta
            // 
            this.TipStudenta.DataPropertyName = "TipStudenta";
            this.TipStudenta.HeaderText = "Tip studenta";
            this.TipStudenta.Name = "TipStudenta";
            this.TipStudenta.ReadOnly = true;
            // 
            // DatumDodavanja
            // 
            this.DatumDodavanja.DataPropertyName = "DatumDodavanja";
            this.DatumDodavanja.HeaderText = "DatumDodavanja";
            this.DatumDodavanja.Name = "DatumDodavanja";
            this.DatumDodavanja.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "DatumRodjenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "StudentId";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Visible = false;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 322);
            this.Controls.Add(this.brojListe);
            this.Controls.Add(this.FowardBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DetaljiBtn);
            this.Controls.Add(this.StudentGridView);
            this.Controls.Add(this.GradCmb);
            this.Controls.Add(this.TraziBtn);
            this.Controls.Add(this.searchNameInput);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchNameInput;
        private System.Windows.Forms.Button TraziBtn;
        private System.Windows.Forms.ComboBox GradCmb;
        private System.Windows.Forms.DataGridView StudentGridView;
        private System.Windows.Forms.Button DetaljiBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button FowardBtn;
        private System.Windows.Forms.Label brojListe;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumDodavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipStudenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
    }
}