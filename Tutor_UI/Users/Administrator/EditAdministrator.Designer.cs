namespace Tutor_UI.Users
{
    partial class EditAdministrator
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
            this.SacuvajBtn = new System.Windows.Forms.Button();
            this.TelefonInput = new System.Windows.Forms.MaskedTextBox();
            this.LozinkaInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.KorisnickoImeInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PrezimeInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ImeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // SacuvajBtn
            // 
            this.SacuvajBtn.Location = new System.Drawing.Point(66, 330);
            this.SacuvajBtn.Name = "SacuvajBtn";
            this.SacuvajBtn.Size = new System.Drawing.Size(110, 28);
            this.SacuvajBtn.TabIndex = 21;
            this.SacuvajBtn.Text = "Sacuvaj";
            this.SacuvajBtn.UseVisualStyleBackColor = true;
            this.SacuvajBtn.Click += new System.EventHandler(this.SacuvajBtn_Click);
            // 
            // TelefonInput
            // 
            this.TelefonInput.Location = new System.Drawing.Point(31, 191);
            this.TelefonInput.Mask = "+387(00)000-000";
            this.TelefonInput.Name = "TelefonInput";
            this.TelefonInput.Size = new System.Drawing.Size(189, 20);
            this.TelefonInput.TabIndex = 16;
            this.TelefonInput.Validating += new System.ComponentModel.CancelEventHandler(this.TelefonInput_Validating);
            // 
            // LozinkaInput
            // 
            this.LozinkaInput.Location = new System.Drawing.Point(31, 289);
            this.LozinkaInput.Name = "LozinkaInput";
            this.LozinkaInput.PasswordChar = '*';
            this.LozinkaInput.Size = new System.Drawing.Size(189, 20);
            this.LozinkaInput.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Lozinka";
            // 
            // KorisnickoImeInput
            // 
            this.KorisnickoImeInput.Location = new System.Drawing.Point(31, 250);
            this.KorisnickoImeInput.Name = "KorisnickoImeInput";
            this.KorisnickoImeInput.Size = new System.Drawing.Size(189, 20);
            this.KorisnickoImeInput.TabIndex = 18;
            this.KorisnickoImeInput.Validating += new System.ComponentModel.CancelEventHandler(this.KorisnickoImeInput_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Korisnicko ime";
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(31, 152);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(189, 20);
            this.EmailInput.TabIndex = 15;
            this.EmailInput.Validating += new System.ComponentModel.CancelEventHandler(this.EmailInput_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Telefon";
            // 
            // PrezimeInput
            // 
            this.PrezimeInput.Location = new System.Drawing.Point(31, 96);
            this.PrezimeInput.Name = "PrezimeInput";
            this.PrezimeInput.Size = new System.Drawing.Size(189, 20);
            this.PrezimeInput.TabIndex = 13;
            this.PrezimeInput.Validating += new System.ComponentModel.CancelEventHandler(this.PrezimeInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Prezime";
            // 
            // ImeInput
            // 
            this.ImeInput.Location = new System.Drawing.Point(31, 56);
            this.ImeInput.Name = "ImeInput";
            this.ImeInput.Size = new System.Drawing.Size(189, 20);
            this.ImeInput.TabIndex = 12;
            this.ImeInput.Validating += new System.ComponentModel.CancelEventHandler(this.ImeInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ime";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EditAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 391);
            this.Controls.Add(this.SacuvajBtn);
            this.Controls.Add(this.TelefonInput);
            this.Controls.Add(this.LozinkaInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.KorisnickoImeInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrezimeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImeInput);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditAdministrator";
            this.ShowIcon = false;
            this.Text = "Edit administrator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SacuvajBtn;
        private System.Windows.Forms.MaskedTextBox TelefonInput;
        private System.Windows.Forms.TextBox LozinkaInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox KorisnickoImeInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrezimeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ImeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}