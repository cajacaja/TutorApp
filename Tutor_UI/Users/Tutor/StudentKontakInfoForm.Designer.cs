namespace Tutor_UI.Users.Tutor
{
    partial class StudentKontakInfoForm
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
            this.studentPictureBox = new System.Windows.Forms.PictureBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.TelefonInput = new System.Windows.Forms.TextBox();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.AdresaInput = new System.Windows.Forms.TextBox();
            this.adresaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // studentPictureBox
            // 
            this.studentPictureBox.Location = new System.Drawing.Point(12, 12);
            this.studentPictureBox.Name = "studentPictureBox";
            this.studentPictureBox.Size = new System.Drawing.Size(73, 98);
            this.studentPictureBox.TabIndex = 0;
            this.studentPictureBox.TabStop = false;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailLabel.Location = new System.Drawing.Point(116, 29);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(41, 13);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email:";
            // 
            // EmailInput
            // 
            this.EmailInput.BackColor = System.Drawing.SystemColors.Control;
            this.EmailInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailInput.Location = new System.Drawing.Point(167, 29);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(161, 13);
            this.EmailInput.TabIndex = 2;
            // 
            // TelefonInput
            // 
            this.TelefonInput.BackColor = System.Drawing.SystemColors.Control;
            this.TelefonInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TelefonInput.Location = new System.Drawing.Point(167, 55);
            this.TelefonInput.Name = "TelefonInput";
            this.TelefonInput.Size = new System.Drawing.Size(161, 13);
            this.TelefonInput.TabIndex = 4;
            // 
            // telefonLabel
            // 
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.telefonLabel.Location = new System.Drawing.Point(107, 58);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(54, 13);
            this.telefonLabel.TabIndex = 3;
            this.telefonLabel.Text = "Telefon:";
            // 
            // AdresaInput
            // 
            this.AdresaInput.BackColor = System.Drawing.SystemColors.Control;
            this.AdresaInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdresaInput.Location = new System.Drawing.Point(167, 83);
            this.AdresaInput.Name = "AdresaInput";
            this.AdresaInput.Size = new System.Drawing.Size(161, 13);
            this.AdresaInput.TabIndex = 6;
            // 
            // adresaLabel
            // 
            this.adresaLabel.AutoSize = true;
            this.adresaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adresaLabel.Location = new System.Drawing.Point(111, 83);
            this.adresaLabel.Name = "adresaLabel";
            this.adresaLabel.Size = new System.Drawing.Size(50, 13);
            this.adresaLabel.TabIndex = 5;
            this.adresaLabel.Text = "Adresa:";
            // 
            // StudentKontakInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 166);
            this.Controls.Add(this.AdresaInput);
            this.Controls.Add(this.adresaLabel);
            this.Controls.Add(this.TelefonInput);
            this.Controls.Add(this.telefonLabel);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.studentPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentKontakInfoForm";
            this.ShowIcon = false;
            this.Text = "Kontak info";
            ((System.ComponentModel.ISupportInitialize)(this.studentPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox studentPictureBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.TextBox TelefonInput;
        private System.Windows.Forms.Label telefonLabel;
        private System.Windows.Forms.TextBox AdresaInput;
        private System.Windows.Forms.Label adresaLabel;
    }
}