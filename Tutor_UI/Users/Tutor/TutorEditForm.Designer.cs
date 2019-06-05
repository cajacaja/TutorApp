namespace Tutor_UI.Users.Tutor
{
    partial class TutorEditForm
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
            this.tutorPictureBox = new System.Windows.Forms.PictureBox();
            this.GradCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TelefonInput = new System.Windows.Forms.MaskedTextBox();
            this.AdresaInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ZaposlenostiCmb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TitulaCmb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NazivObjektaInput = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.PredmetCmb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ObimListBox = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CijenaInput = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.LozinkaInput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SlikaTutorInput = new System.Windows.Forms.TextBox();
            this.SlikaBtn = new System.Windows.Forms.Button();
            this.SnimiBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tutorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CijenaInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tutorPictureBox
            // 
            this.tutorPictureBox.Location = new System.Drawing.Point(413, 27);
            this.tutorPictureBox.Name = "tutorPictureBox";
            this.tutorPictureBox.Size = new System.Drawing.Size(100, 134);
            this.tutorPictureBox.TabIndex = 80;
            this.tutorPictureBox.TabStop = false;
            // 
            // GradCmb
            // 
            this.GradCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GradCmb.FormattingEnabled = true;
            this.GradCmb.Location = new System.Drawing.Point(14, 97);
            this.GradCmb.Name = "GradCmb";
            this.GradCmb.Size = new System.Drawing.Size(144, 21);
            this.GradCmb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Grad";
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(12, 49);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(144, 20);
            this.EmailInput.TabIndex = 0;
            this.EmailInput.Validating += new System.ComponentModel.CancelEventHandler(this.EmailInput_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Telefon";
            // 
            // TelefonInput
            // 
            this.TelefonInput.Location = new System.Drawing.Point(186, 49);
            this.TelefonInput.Mask = "+387(00)000-000";
            this.TelefonInput.Name = "TelefonInput";
            this.TelefonInput.Size = new System.Drawing.Size(144, 20);
            this.TelefonInput.TabIndex = 1;
            this.TelefonInput.Validating += new System.ComponentModel.CancelEventHandler(this.TelefonInput_Validating);
            // 
            // AdresaInput
            // 
            this.AdresaInput.Location = new System.Drawing.Point(186, 97);
            this.AdresaInput.Name = "AdresaInput";
            this.AdresaInput.Size = new System.Drawing.Size(144, 20);
            this.AdresaInput.TabIndex = 3;
            this.AdresaInput.Validating += new System.ComponentModel.CancelEventHandler(this.AdresaInput_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Adresa";
            // 
            // ZaposlenostiCmb
            // 
            this.ZaposlenostiCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ZaposlenostiCmb.FormattingEnabled = true;
            this.ZaposlenostiCmb.ItemHeight = 13;
            this.ZaposlenostiCmb.Location = new System.Drawing.Point(13, 47);
            this.ZaposlenostiCmb.Name = "ZaposlenostiCmb";
            this.ZaposlenostiCmb.Size = new System.Drawing.Size(127, 21);
            this.ZaposlenostiCmb.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Stanje zaposlenosti";
            // 
            // TitulaCmb
            // 
            this.TitulaCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TitulaCmb.FormattingEnabled = true;
            this.TitulaCmb.ItemHeight = 13;
            this.TitulaCmb.Location = new System.Drawing.Point(180, 47);
            this.TitulaCmb.Name = "TitulaCmb";
            this.TitulaCmb.Size = new System.Drawing.Size(144, 21);
            this.TitulaCmb.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Titula tutora";
            // 
            // NazivObjektaInput
            // 
            this.NazivObjektaInput.Location = new System.Drawing.Point(13, 103);
            this.NazivObjektaInput.Name = "NazivObjektaInput";
            this.NazivObjektaInput.Size = new System.Drawing.Size(144, 20);
            this.NazivObjektaInput.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "Naziv fakulteta/posla";
            // 
            // PredmetCmb
            // 
            this.PredmetCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PredmetCmb.FormattingEnabled = true;
            this.PredmetCmb.Location = new System.Drawing.Point(7, 35);
            this.PredmetCmb.Name = "PredmetCmb";
            this.PredmetCmb.Size = new System.Drawing.Size(144, 21);
            this.PredmetCmb.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 64;
            this.label11.Text = "Predmet";
            // 
            // ObimListBox
            // 
            this.ObimListBox.FormattingEnabled = true;
            this.ObimListBox.Location = new System.Drawing.Point(7, 75);
            this.ObimListBox.Name = "ObimListBox";
            this.ObimListBox.Size = new System.Drawing.Size(143, 79);
            this.ObimListBox.TabIndex = 9;
            this.ObimListBox.Validating += new System.ComponentModel.CancelEventHandler(this.ObimListBox_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 66;
            this.label12.Text = "Odabir studenta";
            // 
            // CijenaInput
            // 
            this.CijenaInput.DecimalPlaces = 2;
            this.CijenaInput.Location = new System.Drawing.Point(176, 35);
            this.CijenaInput.Name = "CijenaInput";
            this.CijenaInput.Size = new System.Drawing.Size(144, 20);
            this.CijenaInput.TabIndex = 8;
            this.CijenaInput.Validating += new System.ComponentModel.CancelEventHandler(this.CijenaInput_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(173, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 68;
            this.label13.Text = "Cijena casa";
            // 
            // LozinkaInput
            // 
            this.LozinkaInput.Location = new System.Drawing.Point(176, 74);
            this.LozinkaInput.Name = "LozinkaInput";
            this.LozinkaInput.PasswordChar = '*';
            this.LozinkaInput.Size = new System.Drawing.Size(144, 20);
            this.LozinkaInput.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(173, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 72;
            this.label15.Text = "Lozinka";
            // 
            // SlikaTutorInput
            // 
            this.SlikaTutorInput.Location = new System.Drawing.Point(413, 167);
            this.SlikaTutorInput.Name = "SlikaTutorInput";
            this.SlikaTutorInput.ReadOnly = true;
            this.SlikaTutorInput.Size = new System.Drawing.Size(100, 20);
            this.SlikaTutorInput.TabIndex = 73;
            // 
            // SlikaBtn
            // 
            this.SlikaBtn.Location = new System.Drawing.Point(413, 199);
            this.SlikaBtn.Name = "SlikaBtn";
            this.SlikaBtn.Size = new System.Drawing.Size(100, 23);
            this.SlikaBtn.TabIndex = 11;
            this.SlikaBtn.Text = " Promjeni";
            this.SlikaBtn.UseVisualStyleBackColor = true;
            this.SlikaBtn.Click += new System.EventHandler(this.SlikaBtn_Click);
            // 
            // SnimiBtn
            // 
            this.SnimiBtn.Location = new System.Drawing.Point(413, 439);
            this.SnimiBtn.Name = "SnimiBtn";
            this.SnimiBtn.Size = new System.Drawing.Size(118, 36);
            this.SnimiBtn.TabIndex = 12;
            this.SnimiBtn.Text = "Snimi";
            this.SnimiBtn.UseVisualStyleBackColor = true;
            this.SnimiBtn.Click += new System.EventHandler(this.SnimiBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EmailInput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TelefonInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.GradCmb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.AdresaInput);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(15, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 128);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontak podaci";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.ZaposlenostiCmb);
            this.groupBox2.Controls.Add(this.TitulaCmb);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.NazivObjektaInput);
            this.groupBox2.Location = new System.Drawing.Point(15, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 135);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Privatni podaci";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.PredmetCmb);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.CijenaInput);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.ObimListBox);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.LozinkaInput);
            this.groupBox3.Location = new System.Drawing.Point(15, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 168);
            this.groupBox3.TabIndex = 83;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Profil podaci";
            // 
            // TutorEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 496);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tutorPictureBox);
            this.Controls.Add(this.SnimiBtn);
            this.Controls.Add(this.SlikaBtn);
            this.Controls.Add(this.SlikaTutorInput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TutorEditForm";
            this.ShowIcon = false;
            this.Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)(this.tutorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CijenaInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tutorPictureBox;
        private System.Windows.Forms.ComboBox GradCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox TelefonInput;
        private System.Windows.Forms.TextBox AdresaInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ZaposlenostiCmb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox TitulaCmb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NazivObjektaInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button SnimiBtn;
        private System.Windows.Forms.Button SlikaBtn;
        private System.Windows.Forms.TextBox SlikaTutorInput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox LozinkaInput;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown CijenaInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox ObimListBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox PredmetCmb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}