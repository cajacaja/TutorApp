namespace Tutor_UI.Users.Tutor
{
    partial class UcionicaForm
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
            this.UcioniceTabControl = new System.Windows.Forms.TabControl();
            this.AktivneUcionice = new System.Windows.Forms.TabPage();
            this.aktivneDataGridView = new System.Windows.Forms.DataGridView();
            this.StareUcionice = new System.Windows.Forms.TabPage();
            this.stareDataGridView = new System.Windows.Forms.DataGridView();
            this.NovaUcionicaBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeactiveBtn = new System.Windows.Forms.Button();
            this.PregledBtn = new System.Windows.Forms.Button();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.TraziBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ForwardBtn = new System.Windows.Forms.Button();
            this.pageLable = new System.Windows.Forms.Label();
            this.UcionicaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumZavrsetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojCasova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tezina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPrijavaA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UcionicaIdS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaslovS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumZavrsetkaS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojCasovaS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TezinaS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPrijava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UcioniceTabControl.SuspendLayout();
            this.AktivneUcionice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aktivneDataGridView)).BeginInit();
            this.StareUcionice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stareDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UcioniceTabControl
            // 
            this.UcioniceTabControl.Controls.Add(this.AktivneUcionice);
            this.UcioniceTabControl.Controls.Add(this.StareUcionice);
            this.UcioniceTabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.UcioniceTabControl.Location = new System.Drawing.Point(0, 0);
            this.UcioniceTabControl.Name = "UcioniceTabControl";
            this.UcioniceTabControl.SelectedIndex = 0;
            this.UcioniceTabControl.Size = new System.Drawing.Size(496, 392);
            this.UcioniceTabControl.TabIndex = 0;
            this.UcioniceTabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UcioniceTabControl_MouseClick);
            // 
            // AktivneUcionice
            // 
            this.AktivneUcionice.Controls.Add(this.aktivneDataGridView);
            this.AktivneUcionice.Location = new System.Drawing.Point(4, 22);
            this.AktivneUcionice.Name = "AktivneUcionice";
            this.AktivneUcionice.Padding = new System.Windows.Forms.Padding(3);
            this.AktivneUcionice.Size = new System.Drawing.Size(488, 366);
            this.AktivneUcionice.TabIndex = 0;
            this.AktivneUcionice.Text = "Aktivne";
            this.AktivneUcionice.UseVisualStyleBackColor = true;
            // 
            // aktivneDataGridView
            // 
            this.aktivneDataGridView.AllowUserToAddRows = false;
            this.aktivneDataGridView.AllowUserToDeleteRows = false;
            this.aktivneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aktivneDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UcionicaId,
            this.Naslov,
            this.DatumPocetka,
            this.DatumZavrsetka,
            this.BrojCasova,
            this.Tezina,
            this.BrojPrijavaA});
            this.aktivneDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aktivneDataGridView.Location = new System.Drawing.Point(3, 3);
            this.aktivneDataGridView.Name = "aktivneDataGridView";
            this.aktivneDataGridView.ReadOnly = true;
            this.aktivneDataGridView.Size = new System.Drawing.Size(482, 360);
            this.aktivneDataGridView.TabIndex = 0;
            // 
            // StareUcionice
            // 
            this.StareUcionice.Controls.Add(this.stareDataGridView);
            this.StareUcionice.Location = new System.Drawing.Point(4, 22);
            this.StareUcionice.Name = "StareUcionice";
            this.StareUcionice.Padding = new System.Windows.Forms.Padding(3);
            this.StareUcionice.Size = new System.Drawing.Size(488, 366);
            this.StareUcionice.TabIndex = 1;
            this.StareUcionice.Text = "Stare";
            this.StareUcionice.UseVisualStyleBackColor = true;
            // 
            // stareDataGridView
            // 
            this.stareDataGridView.AllowUserToAddRows = false;
            this.stareDataGridView.AllowUserToDeleteRows = false;
            this.stareDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stareDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UcionicaIdS,
            this.NaslovS,
            this.DatumZavrsetkaS,
            this.BrojCasovaS,
            this.CijenaS,
            this.TezinaS,
            this.BrojPrijava});
            this.stareDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stareDataGridView.Location = new System.Drawing.Point(3, 3);
            this.stareDataGridView.Name = "stareDataGridView";
            this.stareDataGridView.ReadOnly = true;
            this.stareDataGridView.Size = new System.Drawing.Size(482, 360);
            this.stareDataGridView.TabIndex = 0;
            // 
            // NovaUcionicaBtn
            // 
            this.NovaUcionicaBtn.Location = new System.Drawing.Point(518, 308);
            this.NovaUcionicaBtn.Name = "NovaUcionicaBtn";
            this.NovaUcionicaBtn.Size = new System.Drawing.Size(92, 28);
            this.NovaUcionicaBtn.TabIndex = 1;
            this.NovaUcionicaBtn.Text = "Nova ucionica";
            this.NovaUcionicaBtn.UseVisualStyleBackColor = true;
            this.NovaUcionicaBtn.Click += new System.EventHandler(this.NovaUcionicaBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(635, 308);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(85, 28);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeactiveBtn
            // 
            this.DeactiveBtn.Location = new System.Drawing.Point(518, 354);
            this.DeactiveBtn.Name = "DeactiveBtn";
            this.DeactiveBtn.Size = new System.Drawing.Size(92, 27);
            this.DeactiveBtn.TabIndex = 3;
            this.DeactiveBtn.Text = "Deaktiviraj";
            this.DeactiveBtn.UseVisualStyleBackColor = true;
            this.DeactiveBtn.Click += new System.EventHandler(this.DeactiveBtn_Click);
            // 
            // PregledBtn
            // 
            this.PregledBtn.Location = new System.Drawing.Point(635, 353);
            this.PregledBtn.Name = "PregledBtn";
            this.PregledBtn.Size = new System.Drawing.Size(85, 28);
            this.PregledBtn.TabIndex = 4;
            this.PregledBtn.Text = "Pregled";
            this.PregledBtn.UseVisualStyleBackColor = true;
            this.PregledBtn.Click += new System.EventHandler(this.PregledBtn_Click);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(498, 22);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(140, 20);
            this.searchInput.TabIndex = 5;
            // 
            // TraziBtn
            // 
            this.TraziBtn.Location = new System.Drawing.Point(651, 21);
            this.TraziBtn.Name = "TraziBtn";
            this.TraziBtn.Size = new System.Drawing.Size(85, 21);
            this.TraziBtn.TabIndex = 6;
            this.TraziBtn.Text = "Trazi";
            this.TraziBtn.UseVisualStyleBackColor = true;
            this.TraziBtn.Click += new System.EventHandler(this.TraziBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackBtn.Location = new System.Drawing.Point(502, 173);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(56, 32);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "<";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ForwardBtn
            // 
            this.ForwardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForwardBtn.Location = new System.Drawing.Point(680, 173);
            this.ForwardBtn.Name = "ForwardBtn";
            this.ForwardBtn.Size = new System.Drawing.Size(56, 32);
            this.ForwardBtn.TabIndex = 8;
            this.ForwardBtn.Text = ">";
            this.ForwardBtn.UseVisualStyleBackColor = true;
            this.ForwardBtn.Click += new System.EventHandler(this.ForwardBtn_Click);
            // 
            // pageLable
            // 
            this.pageLable.AutoSize = true;
            this.pageLable.Location = new System.Drawing.Point(603, 183);
            this.pageLable.Name = "pageLable";
            this.pageLable.Size = new System.Drawing.Size(24, 13);
            this.pageLable.TabIndex = 9;
            this.pageLable.Text = "0/0";
            // 
            // UcionicaId
            // 
            this.UcionicaId.DataPropertyName = "UcionicaId";
            this.UcionicaId.HeaderText = "UcionicaId";
            this.UcionicaId.Name = "UcionicaId";
            this.UcionicaId.ReadOnly = true;
            this.UcionicaId.Visible = false;
            // 
            // Naslov
            // 
            this.Naslov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov ucionice";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            this.Naslov.Width = 99;
            // 
            // DatumPocetka
            // 
            this.DatumPocetka.DataPropertyName = "DatumPocetka";
            this.DatumPocetka.HeaderText = "Datum pocetka";
            this.DatumPocetka.Name = "DatumPocetka";
            this.DatumPocetka.ReadOnly = true;
            this.DatumPocetka.Width = 65;
            // 
            // DatumZavrsetka
            // 
            this.DatumZavrsetka.DataPropertyName = "DatumZavrsetka";
            this.DatumZavrsetka.HeaderText = "Datum zavrsetka";
            this.DatumZavrsetka.Name = "DatumZavrsetka";
            this.DatumZavrsetka.ReadOnly = true;
            this.DatumZavrsetka.Width = 65;
            // 
            // BrojCasova
            // 
            this.BrojCasova.DataPropertyName = "BrojCasova";
            this.BrojCasova.HeaderText = "Broj casova";
            this.BrojCasova.Name = "BrojCasova";
            this.BrojCasova.ReadOnly = true;
            this.BrojCasova.Width = 55;
            // 
            // Tezina
            // 
            this.Tezina.DataPropertyName = "Tezina";
            this.Tezina.HeaderText = "Tezina";
            this.Tezina.Name = "Tezina";
            this.Tezina.ReadOnly = true;
            this.Tezina.Width = 65;
            // 
            // BrojPrijavaA
            // 
            this.BrojPrijavaA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojPrijavaA.DataPropertyName = "BrojPrijava";
            this.BrojPrijavaA.HeaderText = "Broj prijava";
            this.BrojPrijavaA.Name = "BrojPrijavaA";
            this.BrojPrijavaA.ReadOnly = true;
            // 
            // UcionicaIdS
            // 
            this.UcionicaIdS.DataPropertyName = "UcionicaId";
            this.UcionicaIdS.HeaderText = "UcionicaId";
            this.UcionicaIdS.Name = "UcionicaIdS";
            this.UcionicaIdS.ReadOnly = true;
            this.UcionicaIdS.Visible = false;
            // 
            // NaslovS
            // 
            this.NaslovS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NaslovS.DataPropertyName = "Naslov";
            this.NaslovS.HeaderText = "Naslov";
            this.NaslovS.Name = "NaslovS";
            this.NaslovS.ReadOnly = true;
            this.NaslovS.Width = 65;
            // 
            // DatumZavrsetkaS
            // 
            this.DatumZavrsetkaS.DataPropertyName = "DatumZavrsetka";
            this.DatumZavrsetkaS.HeaderText = "Datum zavrsetka";
            this.DatumZavrsetkaS.Name = "DatumZavrsetkaS";
            this.DatumZavrsetkaS.ReadOnly = true;
            this.DatumZavrsetkaS.Width = 65;
            // 
            // BrojCasovaS
            // 
            this.BrojCasovaS.DataPropertyName = "BrojCasova";
            this.BrojCasovaS.HeaderText = "Broj casova";
            this.BrojCasovaS.Name = "BrojCasovaS";
            this.BrojCasovaS.ReadOnly = true;
            this.BrojCasovaS.Width = 58;
            // 
            // CijenaS
            // 
            this.CijenaS.DataPropertyName = "Cijena";
            this.CijenaS.HeaderText = "Cijena(KM)";
            this.CijenaS.Name = "CijenaS";
            this.CijenaS.ReadOnly = true;
            this.CijenaS.Width = 60;
            // 
            // TezinaS
            // 
            this.TezinaS.DataPropertyName = "Tezina";
            this.TezinaS.HeaderText = "Tezina";
            this.TezinaS.Name = "TezinaS";
            this.TezinaS.ReadOnly = true;
            this.TezinaS.Width = 70;
            // 
            // BrojPrijava
            // 
            this.BrojPrijava.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojPrijava.DataPropertyName = "BrojPrijava";
            this.BrojPrijava.HeaderText = "Broj prijava";
            this.BrojPrijava.Name = "BrojPrijava";
            this.BrojPrijava.ReadOnly = true;
            // 
            // UcionicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 392);
            this.Controls.Add(this.pageLable);
            this.Controls.Add(this.ForwardBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.TraziBtn);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.PregledBtn);
            this.Controls.Add(this.DeactiveBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.NovaUcionicaBtn);
            this.Controls.Add(this.UcioniceTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UcionicaForm";
            this.ShowIcon = false;
            this.Text = "Ucionice";
            this.UcioniceTabControl.ResumeLayout(false);
            this.AktivneUcionice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aktivneDataGridView)).EndInit();
            this.StareUcionice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stareDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl UcioniceTabControl;
        private System.Windows.Forms.TabPage AktivneUcionice;
        private System.Windows.Forms.TabPage StareUcionice;
        private System.Windows.Forms.DataGridView aktivneDataGridView;
        private System.Windows.Forms.DataGridView stareDataGridView;
        private System.Windows.Forms.Button NovaUcionicaBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeactiveBtn;
        private System.Windows.Forms.Button PregledBtn;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button TraziBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ForwardBtn;
        private System.Windows.Forms.Label pageLable;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcionicaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPocetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumZavrsetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojCasova;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tezina;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPrijavaA;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcionicaIdS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaslovS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumZavrsetkaS;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojCasovaS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TezinaS;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPrijava;
    }
}