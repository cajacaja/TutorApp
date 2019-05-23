namespace Tutor_UI.Users.Tutor
{
    partial class UcionicaPrijaveForm
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
            this.prijaveGridView = new System.Windows.Forms.DataGridView();
            this.PrijavaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipStudenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPrijave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prihvatiBtn = new System.Windows.Forms.Button();
            this.pregledBtn = new System.Windows.Forms.Button();
            this.odbijBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prijaveGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prijaveGridView
            // 
            this.prijaveGridView.AllowUserToAddRows = false;
            this.prijaveGridView.AllowUserToDeleteRows = false;
            this.prijaveGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prijaveGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrijavaId,
            this.StudentId,
            this.ImePrezime,
            this.TipStudenta,
            this.Godine,
            this.Spol,
            this.DatumPrijave,
            this.Ocjena});
            this.prijaveGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.prijaveGridView.Location = new System.Drawing.Point(0, 0);
            this.prijaveGridView.Name = "prijaveGridView";
            this.prijaveGridView.ReadOnly = true;
            this.prijaveGridView.Size = new System.Drawing.Size(458, 310);
            this.prijaveGridView.TabIndex = 0;
            // 
            // PrijavaId
            // 
            this.PrijavaId.DataPropertyName = "PrijavaId";
            this.PrijavaId.HeaderText = "PrijavaId";
            this.PrijavaId.Name = "PrijavaId";
            this.PrijavaId.ReadOnly = true;
            this.PrijavaId.Visible = false;
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
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Student";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // TipStudenta
            // 
            this.TipStudenta.DataPropertyName = "TipStudenta";
            this.TipStudenta.HeaderText = "Tip studenta";
            this.TipStudenta.Name = "TipStudenta";
            this.TipStudenta.ReadOnly = true;
            this.TipStudenta.Width = 75;
            // 
            // Godine
            // 
            this.Godine.DataPropertyName = "Godine";
            this.Godine.HeaderText = "Godine";
            this.Godine.Name = "Godine";
            this.Godine.ReadOnly = true;
            this.Godine.Width = 65;
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            this.Spol.ReadOnly = true;
            this.Spol.Width = 50;
            // 
            // DatumPrijave
            // 
            this.DatumPrijave.DataPropertyName = "DatumPrijave";
            this.DatumPrijave.HeaderText = "Datum prijave";
            this.DatumPrijave.Name = "DatumPrijave";
            this.DatumPrijave.ReadOnly = true;
            this.DatumPrijave.Width = 75;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            this.Ocjena.Width = 50;
            // 
            // prihvatiBtn
            // 
            this.prihvatiBtn.Location = new System.Drawing.Point(480, 12);
            this.prihvatiBtn.Name = "prihvatiBtn";
            this.prihvatiBtn.Size = new System.Drawing.Size(75, 33);
            this.prihvatiBtn.TabIndex = 1;
            this.prihvatiBtn.Text = "Prihvati";
            this.prihvatiBtn.UseVisualStyleBackColor = true;
            this.prihvatiBtn.Click += new System.EventHandler(this.prihvatiBtn_Click);
            // 
            // pregledBtn
            // 
            this.pregledBtn.Location = new System.Drawing.Point(480, 51);
            this.pregledBtn.Name = "pregledBtn";
            this.pregledBtn.Size = new System.Drawing.Size(159, 30);
            this.pregledBtn.TabIndex = 2;
            this.pregledBtn.Text = "Pregled ocjena";
            this.pregledBtn.UseVisualStyleBackColor = true;
            this.pregledBtn.Click += new System.EventHandler(this.pregledBtn_Click);
            // 
            // odbijBtn
            // 
            this.odbijBtn.Location = new System.Drawing.Point(564, 12);
            this.odbijBtn.Name = "odbijBtn";
            this.odbijBtn.Size = new System.Drawing.Size(75, 33);
            this.odbijBtn.TabIndex = 3;
            this.odbijBtn.Text = "Odbij";
            this.odbijBtn.UseVisualStyleBackColor = true;
            this.odbijBtn.Click += new System.EventHandler(this.odbijBtn_Click);
            // 
            // UcionicaPrijaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 310);
            this.Controls.Add(this.odbijBtn);
            this.Controls.Add(this.pregledBtn);
            this.Controls.Add(this.prihvatiBtn);
            this.Controls.Add(this.prijaveGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UcionicaPrijaveForm";
            this.ShowIcon = false;
            this.Text = "Prijave";
            this.Enter += new System.EventHandler(this.UcionicaPrijaveForm_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.prijaveGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView prijaveGridView;
        private System.Windows.Forms.Button prihvatiBtn;
        private System.Windows.Forms.Button pregledBtn;
        private System.Windows.Forms.Button odbijBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrijavaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipStudenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPrijave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
    }
}