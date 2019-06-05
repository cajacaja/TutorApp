namespace Tutor_UI.Users.Tutor
{
    partial class UcionicaEdit
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
            this.components = new System.ComponentModel.Container();
            this.daniCmb = new System.Windows.Forms.ComboBox();
            this.BtnSnimi = new System.Windows.Forms.Button();
            this.naslovnaSlikaBtn = new System.Windows.Forms.Button();
            this.slikaInput = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.terminiDataGridView = new System.Windows.Forms.DataGridView();
            this.TerminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UcionicaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ucionica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PocetakCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeInput = new System.Windows.Forms.DateTimePicker();
            this.ObrisiBtn = new System.Windows.Forms.Button();
            this.SnimiBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adresaInput = new System.Windows.Forms.TextBox();
            this.nivoTezineCmb = new System.Windows.Forms.ComboBox();
            this.opisInput = new System.Windows.Forms.RichTextBox();
            this.NaslovInput = new System.Windows.Forms.TextBox();
            this.CijenaInput = new System.Windows.Forms.NumericUpDown();
            this.brojUcenikaInput = new System.Windows.Forms.NumericUpDown();
            this.brojCasovaInput = new System.Windows.Forms.NumericUpDown();
            this.datumPocetkaDatePicker = new System.Windows.Forms.DateTimePicker();
            this.datumZavrsetkaDatePicker = new System.Windows.Forms.DateTimePicker();
            this.naslovnaPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.terminiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CijenaInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojUcenikaInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojCasovaInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naslovnaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // daniCmb
            // 
            this.daniCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.daniCmb.FormattingEnabled = true;
            this.daniCmb.Location = new System.Drawing.Point(264, 372);
            this.daniCmb.Name = "daniCmb";
            this.daniCmb.Size = new System.Drawing.Size(102, 21);
            this.daniCmb.TabIndex = 10;
            // 
            // BtnSnimi
            // 
            this.BtnSnimi.Location = new System.Drawing.Point(430, 470);
            this.BtnSnimi.Name = "BtnSnimi";
            this.BtnSnimi.Size = new System.Drawing.Size(96, 36);
            this.BtnSnimi.TabIndex = 14;
            this.BtnSnimi.Text = "Snimi";
            this.BtnSnimi.UseVisualStyleBackColor = true;
            this.BtnSnimi.Click += new System.EventHandler(this.BtnSnimi_Click);
            // 
            // naslovnaSlikaBtn
            // 
            this.naslovnaSlikaBtn.Location = new System.Drawing.Point(430, 176);
            this.naslovnaSlikaBtn.Name = "naslovnaSlikaBtn";
            this.naslovnaSlikaBtn.Size = new System.Drawing.Size(96, 23);
            this.naslovnaSlikaBtn.TabIndex = 51;
            this.naslovnaSlikaBtn.Text = "Naslovna slika";
            this.naslovnaSlikaBtn.UseVisualStyleBackColor = true;
            this.naslovnaSlikaBtn.Click += new System.EventHandler(this.naslovnaSlikaBtn_Click);
            // 
            // slikaInput
            // 
            this.slikaInput.Location = new System.Drawing.Point(273, 178);
            this.slikaInput.Name = "slikaInput";
            this.slikaInput.ReadOnly = true;
            this.slikaInput.Size = new System.Drawing.Size(141, 20);
            this.slikaInput.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // terminiDataGridView
            // 
            this.terminiDataGridView.AllowUserToAddRows = false;
            this.terminiDataGridView.AllowUserToDeleteRows = false;
            this.terminiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.terminiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TerminId,
            this.UcionicaId,
            this.Ucionica,
            this.Dan,
            this.PocetakCasa});
            this.terminiDataGridView.Location = new System.Drawing.Point(12, 356);
            this.terminiDataGridView.Name = "terminiDataGridView";
            this.terminiDataGridView.ReadOnly = true;
            this.terminiDataGridView.Size = new System.Drawing.Size(243, 150);
            this.terminiDataGridView.TabIndex = 53;
            // 
            // TerminId
            // 
            this.TerminId.DataPropertyName = "TerminId";
            this.TerminId.HeaderText = "TerminId";
            this.TerminId.Name = "TerminId";
            this.TerminId.ReadOnly = true;
            this.TerminId.Visible = false;
            // 
            // UcionicaId
            // 
            this.UcionicaId.DataPropertyName = "UcionicaId";
            this.UcionicaId.HeaderText = "UcionicaId";
            this.UcionicaId.Name = "UcionicaId";
            this.UcionicaId.ReadOnly = true;
            this.UcionicaId.Visible = false;
            // 
            // Ucionica
            // 
            this.Ucionica.DataPropertyName = "Ucionica";
            this.Ucionica.HeaderText = "Ucionica";
            this.Ucionica.Name = "Ucionica";
            this.Ucionica.ReadOnly = true;
            this.Ucionica.Visible = false;
            // 
            // Dan
            // 
            this.Dan.DataPropertyName = "Dan";
            this.Dan.HeaderText = "Dan";
            this.Dan.Name = "Dan";
            this.Dan.ReadOnly = true;
            // 
            // PocetakCasa
            // 
            this.PocetakCasa.DataPropertyName = "PocetakCasa";
            this.PocetakCasa.HeaderText = "Pocetak";
            this.PocetakCasa.Name = "PocetakCasa";
            this.PocetakCasa.ReadOnly = true;
            // 
            // vrijemeInput
            // 
            this.vrijemeInput.Location = new System.Drawing.Point(372, 372);
            this.vrijemeInput.Name = "vrijemeInput";
            this.vrijemeInput.Size = new System.Drawing.Size(95, 20);
            this.vrijemeInput.TabIndex = 11;
            // 
            // ObrisiBtn
            // 
            this.ObrisiBtn.Location = new System.Drawing.Point(372, 398);
            this.ObrisiBtn.Name = "ObrisiBtn";
            this.ObrisiBtn.Size = new System.Drawing.Size(85, 23);
            this.ObrisiBtn.TabIndex = 13;
            this.ObrisiBtn.Text = "Obrisi termin";
            this.ObrisiBtn.UseVisualStyleBackColor = true;
            this.ObrisiBtn.Click += new System.EventHandler(this.ObrisiBtn_Click);
            // 
            // SnimiBtn
            // 
            this.SnimiBtn.Location = new System.Drawing.Point(264, 398);
            this.SnimiBtn.Name = "SnimiBtn";
            this.SnimiBtn.Size = new System.Drawing.Size(82, 23);
            this.SnimiBtn.TabIndex = 12;
            this.SnimiBtn.Text = "Snimi termin";
            this.SnimiBtn.UseVisualStyleBackColor = true;
            this.SnimiBtn.Click += new System.EventHandler(this.SnimiBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(369, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "Vrijeme pocetka";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(261, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Dan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(15, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Nivo tezine";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(280, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Datum zavrsetka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(280, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Datum pocetka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(13, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Broj ucenika";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(104, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Broj casova";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(15, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Cijena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Opis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Adresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Naslov";
            // 
            // adresaInput
            // 
            this.adresaInput.Location = new System.Drawing.Point(18, 191);
            this.adresaInput.Name = "adresaInput";
            this.adresaInput.Size = new System.Drawing.Size(157, 20);
            this.adresaInput.TabIndex = 2;
            // 
            // nivoTezineCmb
            // 
            this.nivoTezineCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nivoTezineCmb.FormattingEnabled = true;
            this.nivoTezineCmb.Location = new System.Drawing.Point(18, 230);
            this.nivoTezineCmb.Name = "nivoTezineCmb";
            this.nivoTezineCmb.Size = new System.Drawing.Size(157, 21);
            this.nivoTezineCmb.TabIndex = 1;
            // 
            // opisInput
            // 
            this.opisInput.Location = new System.Drawing.Point(12, 74);
            this.opisInput.Name = "opisInput";
            this.opisInput.Size = new System.Drawing.Size(243, 96);
            this.opisInput.TabIndex = 1;
            this.opisInput.Text = "";
            // 
            // NaslovInput
            // 
            this.NaslovInput.Location = new System.Drawing.Point(18, 25);
            this.NaslovInput.Name = "NaslovInput";
            this.NaslovInput.Size = new System.Drawing.Size(157, 20);
            this.NaslovInput.TabIndex = 0;
            // 
            // CijenaInput
            // 
            this.CijenaInput.DecimalPlaces = 2;
            this.CijenaInput.Location = new System.Drawing.Point(18, 276);
            this.CijenaInput.Name = "CijenaInput";
            this.CijenaInput.Size = new System.Drawing.Size(65, 20);
            this.CijenaInput.TabIndex = 5;
            // 
            // brojUcenikaInput
            // 
            this.brojUcenikaInput.Location = new System.Drawing.Point(18, 320);
            this.brojUcenikaInput.Name = "brojUcenikaInput";
            this.brojUcenikaInput.Size = new System.Drawing.Size(78, 20);
            this.brojUcenikaInput.TabIndex = 7;
            // 
            // brojCasovaInput
            // 
            this.brojCasovaInput.Location = new System.Drawing.Point(107, 276);
            this.brojCasovaInput.Name = "brojCasovaInput";
            this.brojCasovaInput.Size = new System.Drawing.Size(55, 20);
            this.brojCasovaInput.TabIndex = 6;
            // 
            // datumPocetkaDatePicker
            // 
            this.datumPocetkaDatePicker.Location = new System.Drawing.Point(283, 230);
            this.datumPocetkaDatePicker.Name = "datumPocetkaDatePicker";
            this.datumPocetkaDatePicker.Size = new System.Drawing.Size(125, 20);
            this.datumPocetkaDatePicker.TabIndex = 8;
            // 
            // datumZavrsetkaDatePicker
            // 
            this.datumZavrsetkaDatePicker.Location = new System.Drawing.Point(283, 276);
            this.datumZavrsetkaDatePicker.Name = "datumZavrsetkaDatePicker";
            this.datumZavrsetkaDatePicker.Size = new System.Drawing.Size(125, 20);
            this.datumZavrsetkaDatePicker.TabIndex = 9;
            // 
            // naslovnaPictureBox
            // 
            this.naslovnaPictureBox.Location = new System.Drawing.Point(273, 22);
            this.naslovnaPictureBox.Name = "naslovnaPictureBox";
            this.naslovnaPictureBox.Size = new System.Drawing.Size(243, 148);
            this.naslovnaPictureBox.TabIndex = 31;
            this.naslovnaPictureBox.TabStop = false;
            // 
            // UcionicaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 525);
            this.Controls.Add(this.daniCmb);
            this.Controls.Add(this.BtnSnimi);
            this.Controls.Add(this.naslovnaSlikaBtn);
            this.Controls.Add(this.slikaInput);
            this.Controls.Add(this.terminiDataGridView);
            this.Controls.Add(this.vrijemeInput);
            this.Controls.Add(this.ObrisiBtn);
            this.Controls.Add(this.SnimiBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adresaInput);
            this.Controls.Add(this.nivoTezineCmb);
            this.Controls.Add(this.opisInput);
            this.Controls.Add(this.NaslovInput);
            this.Controls.Add(this.CijenaInput);
            this.Controls.Add(this.brojUcenikaInput);
            this.Controls.Add(this.brojCasovaInput);
            this.Controls.Add(this.datumPocetkaDatePicker);
            this.Controls.Add(this.datumZavrsetkaDatePicker);
            this.Controls.Add(this.naslovnaPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UcionicaEdit";
            this.ShowIcon = false;
            this.Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)(this.terminiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CijenaInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojUcenikaInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojCasovaInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naslovnaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox daniCmb;
        private System.Windows.Forms.Button BtnSnimi;
        private System.Windows.Forms.Button naslovnaSlikaBtn;
        private System.Windows.Forms.TextBox slikaInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView terminiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcionicaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ucionica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dan;
        private System.Windows.Forms.DataGridViewTextBoxColumn PocetakCasa;
        private System.Windows.Forms.DateTimePicker vrijemeInput;
        private System.Windows.Forms.Button ObrisiBtn;
        private System.Windows.Forms.Button SnimiBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adresaInput;
        private System.Windows.Forms.ComboBox nivoTezineCmb;
        private System.Windows.Forms.RichTextBox opisInput;
        private System.Windows.Forms.TextBox NaslovInput;
        private System.Windows.Forms.NumericUpDown CijenaInput;
        private System.Windows.Forms.NumericUpDown brojUcenikaInput;
        private System.Windows.Forms.NumericUpDown brojCasovaInput;
        private System.Windows.Forms.DateTimePicker datumPocetkaDatePicker;
        private System.Windows.Forms.DateTimePicker datumZavrsetkaDatePicker;
        private System.Windows.Forms.PictureBox naslovnaPictureBox;
    }
}