﻿namespace Tutor_UI.Users.Tutor
{
    partial class AddUcionicu
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
            this.naslovnaPictureBox = new System.Windows.Forms.PictureBox();
            this.datumZavrsetkaDatePicker = new System.Windows.Forms.DateTimePicker();
            this.datumPocetkaDatePicker = new System.Windows.Forms.DateTimePicker();
            this.brojCasovaInput = new System.Windows.Forms.NumericUpDown();
            this.brojUcenikaInput = new System.Windows.Forms.NumericUpDown();
            this.CijenaInput = new System.Windows.Forms.NumericUpDown();
            this.NaslovInput = new System.Windows.Forms.TextBox();
            this.opisInput = new System.Windows.Forms.RichTextBox();
            this.nivoTezineCmb = new System.Windows.Forms.ComboBox();
            this.adresaInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.slikaInput = new System.Windows.Forms.TextBox();
            this.naslovnaSlikaBtn = new System.Windows.Forms.Button();
            this.BtnSnimi = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.terminiDataGridView = new System.Windows.Forms.DataGridView();
            this.TerminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UcionicaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ucionica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PocetakCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SnimiBtn = new System.Windows.Forms.Button();
            this.ObrisiBtn = new System.Windows.Forms.Button();
            this.vrijemeInput = new System.Windows.Forms.DateTimePicker();
            this.daniCmb = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.naslovnaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojCasovaInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojUcenikaInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CijenaInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // naslovnaPictureBox
            // 
            this.naslovnaPictureBox.Location = new System.Drawing.Point(273, 22);
            this.naslovnaPictureBox.Name = "naslovnaPictureBox";
            this.naslovnaPictureBox.Size = new System.Drawing.Size(243, 148);
            this.naslovnaPictureBox.TabIndex = 0;
            this.naslovnaPictureBox.TabStop = false;
            // 
            // datumZavrsetkaDatePicker
            // 
            this.datumZavrsetkaDatePicker.Location = new System.Drawing.Point(283, 276);
            this.datumZavrsetkaDatePicker.Name = "datumZavrsetkaDatePicker";
            this.datumZavrsetkaDatePicker.Size = new System.Drawing.Size(125, 20);
            this.datumZavrsetkaDatePicker.TabIndex = 1;
            // 
            // datumPocetkaDatePicker
            // 
            this.datumPocetkaDatePicker.Location = new System.Drawing.Point(283, 230);
            this.datumPocetkaDatePicker.Name = "datumPocetkaDatePicker";
            this.datumPocetkaDatePicker.Size = new System.Drawing.Size(125, 20);
            this.datumPocetkaDatePicker.TabIndex = 2;
            // 
            // brojCasovaInput
            // 
            this.brojCasovaInput.Location = new System.Drawing.Point(107, 276);
            this.brojCasovaInput.Name = "brojCasovaInput";
            this.brojCasovaInput.Size = new System.Drawing.Size(55, 20);
            this.brojCasovaInput.TabIndex = 3;
            this.brojCasovaInput.Validating += new System.ComponentModel.CancelEventHandler(this.brojCasovaInput_Validating);
            // 
            // brojUcenikaInput
            // 
            this.brojUcenikaInput.Location = new System.Drawing.Point(18, 320);
            this.brojUcenikaInput.Name = "brojUcenikaInput";
            this.brojUcenikaInput.Size = new System.Drawing.Size(78, 20);
            this.brojUcenikaInput.TabIndex = 4;
            this.brojUcenikaInput.Validating += new System.ComponentModel.CancelEventHandler(this.brojUcenikaInput_Validating);
            // 
            // CijenaInput
            // 
            this.CijenaInput.DecimalPlaces = 2;
            this.CijenaInput.Location = new System.Drawing.Point(18, 276);
            this.CijenaInput.Name = "CijenaInput";
            this.CijenaInput.Size = new System.Drawing.Size(65, 20);
            this.CijenaInput.TabIndex = 5;
            this.CijenaInput.Validating += new System.ComponentModel.CancelEventHandler(this.CijenaInput_Validating);
            // 
            // NaslovInput
            // 
            this.NaslovInput.Location = new System.Drawing.Point(18, 25);
            this.NaslovInput.Name = "NaslovInput";
            this.NaslovInput.Size = new System.Drawing.Size(157, 20);
            this.NaslovInput.TabIndex = 6;
            this.NaslovInput.Validating += new System.ComponentModel.CancelEventHandler(this.NaslovInput_Validating);
            // 
            // opisInput
            // 
            this.opisInput.Location = new System.Drawing.Point(12, 74);
            this.opisInput.Name = "opisInput";
            this.opisInput.Size = new System.Drawing.Size(243, 96);
            this.opisInput.TabIndex = 7;
            this.opisInput.Text = "";
            this.opisInput.Validating += new System.ComponentModel.CancelEventHandler(this.opisInput_Validating);
            // 
            // nivoTezineCmb
            // 
            this.nivoTezineCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nivoTezineCmb.FormattingEnabled = true;
            this.nivoTezineCmb.Location = new System.Drawing.Point(18, 230);
            this.nivoTezineCmb.Name = "nivoTezineCmb";
            this.nivoTezineCmb.Size = new System.Drawing.Size(157, 21);
            this.nivoTezineCmb.TabIndex = 8;
            // 
            // adresaInput
            // 
            this.adresaInput.Location = new System.Drawing.Point(18, 191);
            this.adresaInput.Name = "adresaInput";
            this.adresaInput.Size = new System.Drawing.Size(157, 20);
            this.adresaInput.TabIndex = 9;
            this.adresaInput.Validating += new System.ComponentModel.CancelEventHandler(this.adresaInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Naslov";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Opis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(15, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cijena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(104, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Broj caova";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(13, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Broj ucenika";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(280, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Datum pocetka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(280, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Datum zavrsetka";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(15, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Nivo tezine";
            // 
            // slikaInput
            // 
            this.slikaInput.Location = new System.Drawing.Point(273, 178);
            this.slikaInput.Name = "slikaInput";
            this.slikaInput.ReadOnly = true;
            this.slikaInput.Size = new System.Drawing.Size(141, 20);
            this.slikaInput.TabIndex = 19;
            this.slikaInput.Validating += new System.ComponentModel.CancelEventHandler(this.slikaInput_Validating);
            // 
            // naslovnaSlikaBtn
            // 
            this.naslovnaSlikaBtn.Location = new System.Drawing.Point(430, 176);
            this.naslovnaSlikaBtn.Name = "naslovnaSlikaBtn";
            this.naslovnaSlikaBtn.Size = new System.Drawing.Size(96, 23);
            this.naslovnaSlikaBtn.TabIndex = 20;
            this.naslovnaSlikaBtn.Text = "Naslovna slika";
            this.naslovnaSlikaBtn.UseVisualStyleBackColor = true;
            this.naslovnaSlikaBtn.Click += new System.EventHandler(this.naslovnaSlikaBtn_Click);
            // 
            // BtnSnimi
            // 
            this.BtnSnimi.Location = new System.Drawing.Point(430, 470);
            this.BtnSnimi.Name = "BtnSnimi";
            this.BtnSnimi.Size = new System.Drawing.Size(96, 36);
            this.BtnSnimi.TabIndex = 21;
            this.BtnSnimi.Text = "Snimi";
            this.BtnSnimi.UseVisualStyleBackColor = true;
            this.BtnSnimi.Click += new System.EventHandler(this.BtnSnimi_Click);
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
            this.terminiDataGridView.TabIndex = 22;
            this.terminiDataGridView.Validating += new System.ComponentModel.CancelEventHandler(this.terminiDataGridView_Validating);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(261, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Dan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(369, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Vrijeme pocetka";
            // 
            // SnimiBtn
            // 
            this.SnimiBtn.Location = new System.Drawing.Point(264, 398);
            this.SnimiBtn.Name = "SnimiBtn";
            this.SnimiBtn.Size = new System.Drawing.Size(82, 23);
            this.SnimiBtn.TabIndex = 27;
            this.SnimiBtn.Text = "Snimi termin";
            this.SnimiBtn.UseVisualStyleBackColor = true;
            this.SnimiBtn.Click += new System.EventHandler(this.SnimiBtn_Click);
            // 
            // ObrisiBtn
            // 
            this.ObrisiBtn.Location = new System.Drawing.Point(372, 398);
            this.ObrisiBtn.Name = "ObrisiBtn";
            this.ObrisiBtn.Size = new System.Drawing.Size(85, 23);
            this.ObrisiBtn.TabIndex = 28;
            this.ObrisiBtn.Text = "Obrisi termin";
            this.ObrisiBtn.UseVisualStyleBackColor = true;
            this.ObrisiBtn.Click += new System.EventHandler(this.ObrisiBtn_Click);
            // 
            // vrijemeInput
            // 
            this.vrijemeInput.Location = new System.Drawing.Point(372, 372);
            this.vrijemeInput.Name = "vrijemeInput";
            this.vrijemeInput.Size = new System.Drawing.Size(95, 20);
            this.vrijemeInput.TabIndex = 29;
            // 
            // daniCmb
            // 
            this.daniCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.daniCmb.FormattingEnabled = true;
            this.daniCmb.Location = new System.Drawing.Point(264, 372);
            this.daniCmb.Name = "daniCmb";
            this.daniCmb.Size = new System.Drawing.Size(102, 21);
            this.daniCmb.TabIndex = 30;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddUcionicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 515);
            this.Controls.Add(this.daniCmb);
            this.Controls.Add(this.vrijemeInput);
            this.Controls.Add(this.ObrisiBtn);
            this.Controls.Add(this.SnimiBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.terminiDataGridView);
            this.Controls.Add(this.BtnSnimi);
            this.Controls.Add(this.naslovnaSlikaBtn);
            this.Controls.Add(this.slikaInput);
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
            this.Name = "AddUcionicu";
            this.ShowIcon = false;
            this.Text = "Dodaj ucionicu";
            ((System.ComponentModel.ISupportInitialize)(this.naslovnaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojCasovaInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojUcenikaInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CijenaInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox naslovnaPictureBox;
        private System.Windows.Forms.DateTimePicker datumZavrsetkaDatePicker;
        private System.Windows.Forms.DateTimePicker datumPocetkaDatePicker;
        private System.Windows.Forms.NumericUpDown brojCasovaInput;
        private System.Windows.Forms.NumericUpDown brojUcenikaInput;
        private System.Windows.Forms.NumericUpDown CijenaInput;
        private System.Windows.Forms.TextBox NaslovInput;
        private System.Windows.Forms.RichTextBox opisInput;
        private System.Windows.Forms.ComboBox nivoTezineCmb;
        private System.Windows.Forms.TextBox adresaInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox slikaInput;
        private System.Windows.Forms.Button naslovnaSlikaBtn;
        private System.Windows.Forms.Button BtnSnimi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView terminiDataGridView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SnimiBtn;
        private System.Windows.Forms.Button ObrisiBtn;
        private System.Windows.Forms.DateTimePicker vrijemeInput;
        private System.Windows.Forms.ComboBox daniCmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcionicaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ucionica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dan;
        private System.Windows.Forms.DataGridViewTextBoxColumn PocetakCasa;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}