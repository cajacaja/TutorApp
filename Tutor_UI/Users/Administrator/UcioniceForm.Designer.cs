namespace Tutor_UI.Users
{
    partial class UcioniceForm
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
            System.Windows.Forms.TabPage tabPage1;
            this.actUcioniceGridView = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tezina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxBrojPolaznika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UcionicaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.strUcioniceGridView = new System.Windows.Forms.DataGridView();
            this.UcionicaIdstr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutorStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PredmetStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumZavrsetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TezinaStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxBrojPolaznikaStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gradstr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OblastCmb = new System.Windows.Forms.ComboBox();
            this.GradCmb = new System.Windows.Forms.ComboBox();
            this.TraziBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.pageNumLabel = new System.Windows.Forms.Label();
            this.ForwardBtn = new System.Windows.Forms.Button();
            this.DetaljiBtn = new System.Windows.Forms.Button();
            this.testBtn = new System.Windows.Forms.Button();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actUcioniceGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strUcioniceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(this.actUcioniceGridView);
            tabPage1.Location = new System.Drawing.Point(4, 22);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(731, 291);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Aktivne ucionice";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // actUcioniceGridView
            // 
            this.actUcioniceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actUcioniceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.Predmet,
            this.DatumPocetka,
            this.Tezina,
            this.Cijena,
            this.MaxBrojPolaznika,
            this.UcionicaId,
            this.Grad});
            this.actUcioniceGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actUcioniceGridView.Location = new System.Drawing.Point(3, 3);
            this.actUcioniceGridView.Name = "actUcioniceGridView";
            this.actUcioniceGridView.Size = new System.Drawing.Size(725, 285);
            this.actUcioniceGridView.TabIndex = 0;
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "ImePrezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            this.ImePrezime.Width = 86;
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            this.Predmet.Width = 71;
            // 
            // DatumPocetka
            // 
            this.DatumPocetka.DataPropertyName = "DatumPocetka";
            this.DatumPocetka.HeaderText = "DatumPocetka";
            this.DatumPocetka.Name = "DatumPocetka";
            this.DatumPocetka.ReadOnly = true;
            this.DatumPocetka.Width = 85;
            // 
            // Tezina
            // 
            this.Tezina.DataPropertyName = "Tezina";
            this.Tezina.HeaderText = "Tezina";
            this.Tezina.Name = "Tezina";
            this.Tezina.ReadOnly = true;
            this.Tezina.Width = 75;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena(KM)";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Width = 65;
            // 
            // MaxBrojPolaznika
            // 
            this.MaxBrojPolaznika.DataPropertyName = "MaxBrojPolaznika";
            this.MaxBrojPolaznika.HeaderText = "MaxBrojPolaznika";
            this.MaxBrojPolaznika.Name = "MaxBrojPolaznika";
            this.MaxBrojPolaznika.ReadOnly = true;
            // 
            // UcionicaId
            // 
            this.UcionicaId.DataPropertyName = "UcionicaId";
            this.UcionicaId.HeaderText = "UcionicaId";
            this.UcionicaId.Name = "UcionicaId";
            this.UcionicaId.ReadOnly = true;
            this.UcionicaId.Visible = false;
            // 
            // Grad
            // 
            this.Grad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Grad.DataPropertyName = "Grad";
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(739, 317);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.strUcioniceGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(731, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stare ucionice";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // strUcioniceGridView
            // 
            this.strUcioniceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.strUcioniceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UcionicaIdstr,
            this.TutorStr,
            this.PredmetStr,
            this.DatumZavrsetka,
            this.TezinaStr,
            this.CijenaStr,
            this.MaxBrojPolaznikaStr,
            this.Gradstr});
            this.strUcioniceGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strUcioniceGridView.Location = new System.Drawing.Point(3, 3);
            this.strUcioniceGridView.Name = "strUcioniceGridView";
            this.strUcioniceGridView.Size = new System.Drawing.Size(725, 285);
            this.strUcioniceGridView.TabIndex = 0;
            // 
            // UcionicaIdstr
            // 
            this.UcionicaIdstr.DataPropertyName = "UcionicaId";
            this.UcionicaIdstr.HeaderText = "UcionicaId";
            this.UcionicaIdstr.Name = "UcionicaIdstr";
            this.UcionicaIdstr.ReadOnly = true;
            this.UcionicaIdstr.Visible = false;
            // 
            // TutorStr
            // 
            this.TutorStr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TutorStr.DataPropertyName = "ImePrezime";
            this.TutorStr.HeaderText = "Tutor";
            this.TutorStr.Name = "TutorStr";
            this.TutorStr.ReadOnly = true;
            this.TutorStr.Width = 57;
            // 
            // PredmetStr
            // 
            this.PredmetStr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PredmetStr.DataPropertyName = "Predmet";
            this.PredmetStr.HeaderText = "Predmet";
            this.PredmetStr.Name = "PredmetStr";
            this.PredmetStr.ReadOnly = true;
            this.PredmetStr.Width = 71;
            // 
            // DatumZavrsetka
            // 
            this.DatumZavrsetka.DataPropertyName = "DatumZavrsetka";
            this.DatumZavrsetka.HeaderText = "Datum zavrsetka";
            this.DatumZavrsetka.Name = "DatumZavrsetka";
            this.DatumZavrsetka.ReadOnly = true;
            this.DatumZavrsetka.Width = 85;
            // 
            // TezinaStr
            // 
            this.TezinaStr.DataPropertyName = "Tezina";
            this.TezinaStr.HeaderText = "Tezina";
            this.TezinaStr.Name = "TezinaStr";
            this.TezinaStr.ReadOnly = true;
            this.TezinaStr.Width = 75;
            // 
            // CijenaStr
            // 
            this.CijenaStr.DataPropertyName = "Cijena";
            this.CijenaStr.HeaderText = "Cijena(KM)";
            this.CijenaStr.Name = "CijenaStr";
            this.CijenaStr.ReadOnly = true;
            this.CijenaStr.Width = 75;
            // 
            // MaxBrojPolaznikaStr
            // 
            this.MaxBrojPolaznikaStr.DataPropertyName = "MaxBrojPolaznika";
            this.MaxBrojPolaznikaStr.HeaderText = "Maximalni broj polaznika";
            this.MaxBrojPolaznikaStr.Name = "MaxBrojPolaznikaStr";
            this.MaxBrojPolaznikaStr.ReadOnly = true;
            // 
            // Gradstr
            // 
            this.Gradstr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gradstr.DataPropertyName = "Grad";
            this.Gradstr.HeaderText = "Grad";
            this.Gradstr.Name = "Gradstr";
            this.Gradstr.ReadOnly = true;
            // 
            // OblastCmb
            // 
            this.OblastCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OblastCmb.FormattingEnabled = true;
            this.OblastCmb.Location = new System.Drawing.Point(4, 12);
            this.OblastCmb.Name = "OblastCmb";
            this.OblastCmb.Size = new System.Drawing.Size(121, 21);
            this.OblastCmb.TabIndex = 1;
            // 
            // GradCmb
            // 
            this.GradCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GradCmb.FormattingEnabled = true;
            this.GradCmb.Location = new System.Drawing.Point(145, 12);
            this.GradCmb.Name = "GradCmb";
            this.GradCmb.Size = new System.Drawing.Size(121, 21);
            this.GradCmb.TabIndex = 2;
            // 
            // TraziBtn
            // 
            this.TraziBtn.Location = new System.Drawing.Point(296, 12);
            this.TraziBtn.Name = "TraziBtn";
            this.TraziBtn.Size = new System.Drawing.Size(100, 23);
            this.TraziBtn.TabIndex = 3;
            this.TraziBtn.Text = "Trazi";
            this.TraziBtn.UseVisualStyleBackColor = true;
            this.TraziBtn.Click += new System.EventHandler(this.TraziBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 54);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(43, 23);
            this.BackBtn.TabIndex = 4;
            this.BackBtn.Text = "<";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // pageNumLabel
            // 
            this.pageNumLabel.AutoSize = true;
            this.pageNumLabel.Location = new System.Drawing.Point(71, 59);
            this.pageNumLabel.Name = "pageNumLabel";
            this.pageNumLabel.Size = new System.Drawing.Size(24, 13);
            this.pageNumLabel.TabIndex = 5;
            this.pageNumLabel.Text = "0/0";
            // 
            // ForwardBtn
            // 
            this.ForwardBtn.Location = new System.Drawing.Point(116, 54);
            this.ForwardBtn.Name = "ForwardBtn";
            this.ForwardBtn.Size = new System.Drawing.Size(43, 23);
            this.ForwardBtn.TabIndex = 6;
            this.ForwardBtn.Text = ">";
            this.ForwardBtn.UseVisualStyleBackColor = true;
            this.ForwardBtn.Click += new System.EventHandler(this.ForwardBtn_Click);
            // 
            // DetaljiBtn
            // 
            this.DetaljiBtn.Location = new System.Drawing.Point(516, 12);
            this.DetaljiBtn.Name = "DetaljiBtn";
            this.DetaljiBtn.Size = new System.Drawing.Size(100, 23);
            this.DetaljiBtn.TabIndex = 7;
            this.DetaljiBtn.Text = "Detalji";
            this.DetaljiBtn.UseVisualStyleBackColor = true;
            this.DetaljiBtn.Click += new System.EventHandler(this.DetaljiBtn_Click);
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(366, 54);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(100, 23);
            this.testBtn.TabIndex = 8;
            this.testBtn.Text = "Test Ucionica";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // UcioniceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 405);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.DetaljiBtn);
            this.Controls.Add(this.ForwardBtn);
            this.Controls.Add(this.pageNumLabel);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.TraziBtn);
            this.Controls.Add(this.GradCmb);
            this.Controls.Add(this.OblastCmb);
            this.Controls.Add(this.tabControl1);
            this.Name = "UcioniceForm";
            this.Text = "UcioniceForm";
            this.Load += new System.EventHandler(this.UcioniceForm_Load);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.actUcioniceGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.strUcioniceGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView actUcioniceGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox OblastCmb;
        private System.Windows.Forms.ComboBox GradCmb;
        private System.Windows.Forms.Button TraziBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label pageNumLabel;
        private System.Windows.Forms.Button ForwardBtn;
        private System.Windows.Forms.DataGridView strUcioniceGridView;
        private System.Windows.Forms.Button DetaljiBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPocetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tezina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxBrojPolaznika;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcionicaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcionicaIdstr;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn PredmetStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumZavrsetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn TezinaStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxBrojPolaznikaStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gradstr;
        private System.Windows.Forms.Button testBtn;
    }
}