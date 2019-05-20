namespace Tutor_UI.Users.Tutor
{
    partial class PrijavaForm
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
            this.PrijavaInput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrijavaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrijavaInput
            // 
            this.PrijavaInput.Location = new System.Drawing.Point(1, 41);
            this.PrijavaInput.Name = "PrijavaInput";
            this.PrijavaInput.Size = new System.Drawing.Size(331, 96);
            this.PrijavaInput.TabIndex = 0;
            this.PrijavaInput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Razlog prijave";
            // 
            // PrijavaBtn
            // 
            this.PrijavaBtn.Location = new System.Drawing.Point(246, 143);
            this.PrijavaBtn.Name = "PrijavaBtn";
            this.PrijavaBtn.Size = new System.Drawing.Size(75, 30);
            this.PrijavaBtn.TabIndex = 2;
            this.PrijavaBtn.Text = "Prijavi";
            this.PrijavaBtn.UseVisualStyleBackColor = true;
            this.PrijavaBtn.Click += new System.EventHandler(this.PrijavaBtn_Click);
            // 
            // PrijavaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 185);
            this.Controls.Add(this.PrijavaBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrijavaInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrijavaForm";
            this.ShowIcon = false;
            this.Text = "Prijava studenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox PrijavaInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PrijavaBtn;
    }
}