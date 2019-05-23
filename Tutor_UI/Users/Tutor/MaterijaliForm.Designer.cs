namespace Tutor_UI.Users.Tutor
{
    partial class MaterijaliForm
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
            this.fileGridView = new System.Windows.Forms.DataGridView();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.izbrisiBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.MaterijalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPostavljanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fileGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fileGridView
            // 
            this.fileGridView.AllowUserToAddRows = false;
            this.fileGridView.AllowUserToDeleteRows = false;
            this.fileGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterijalId,
            this.Naslov,
            this.DatumPostavljanja});
            this.fileGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.fileGridView.Location = new System.Drawing.Point(0, 0);
            this.fileGridView.Name = "fileGridView";
            this.fileGridView.ReadOnly = true;
            this.fileGridView.Size = new System.Drawing.Size(244, 308);
            this.fileGridView.TabIndex = 0;
            // 
            // downloadBtn
            // 
            this.downloadBtn.Location = new System.Drawing.Point(250, 12);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(75, 23);
            this.downloadBtn.TabIndex = 1;
            this.downloadBtn.Text = "Download";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(331, 12);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(75, 23);
            this.uploadBtn.TabIndex = 2;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // izbrisiBtn
            // 
            this.izbrisiBtn.Location = new System.Drawing.Point(250, 41);
            this.izbrisiBtn.Name = "izbrisiBtn";
            this.izbrisiBtn.Size = new System.Drawing.Size(75, 23);
            this.izbrisiBtn.TabIndex = 3;
            this.izbrisiBtn.Text = "Izbrisi";
            this.izbrisiBtn.UseVisualStyleBackColor = true;
            this.izbrisiBtn.Click += new System.EventHandler(this.izbrisiBtn_Click);
            // 
            // MaterijalId
            // 
            this.MaterijalId.DataPropertyName = "MaterijalId";
            this.MaterijalId.HeaderText = "MaterijalId";
            this.MaterijalId.Name = "MaterijalId";
            this.MaterijalId.ReadOnly = true;
            this.MaterijalId.Visible = false;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // DatumPostavljanja
            // 
            this.DatumPostavljanja.DataPropertyName = "DatumPostavljanja";
            this.DatumPostavljanja.HeaderText = "Datum postavljanja";
            this.DatumPostavljanja.Name = "DatumPostavljanja";
            this.DatumPostavljanja.ReadOnly = true;
            // 
            // MaterijaliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 308);
            this.Controls.Add(this.izbrisiBtn);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.fileGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaterijaliForm";
            this.ShowIcon = false;
            this.Text = "Materijali";
            ((System.ComponentModel.ISupportInitialize)(this.fileGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView fileGridView;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Button izbrisiBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterijalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPostavljanja;
    }
}