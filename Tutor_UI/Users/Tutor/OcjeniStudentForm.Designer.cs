namespace Tutor_UI.Users.Tutor
{
    partial class OcjeniStudentForm
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
            this.ocjenaInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.komentarInput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OcjeniBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ocjenaInput)).BeginInit();
            this.SuspendLayout();
            // 
            // ocjenaInput
            // 
            this.ocjenaInput.Location = new System.Drawing.Point(55, 23);
            this.ocjenaInput.Name = "ocjenaInput";
            this.ocjenaInput.Size = new System.Drawing.Size(75, 20);
            this.ocjenaInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(2, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ocjena";
            // 
            // komentarInput
            // 
            this.komentarInput.Location = new System.Drawing.Point(1, 75);
            this.komentarInput.Name = "komentarInput";
            this.komentarInput.Size = new System.Drawing.Size(320, 91);
            this.komentarInput.TabIndex = 2;
            this.komentarInput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(2, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Komentar";
            // 
            // OcjeniBtn
            // 
            this.OcjeniBtn.Location = new System.Drawing.Point(235, 185);
            this.OcjeniBtn.Name = "OcjeniBtn";
            this.OcjeniBtn.Size = new System.Drawing.Size(75, 28);
            this.OcjeniBtn.TabIndex = 4;
            this.OcjeniBtn.Text = "Ocjeni";
            this.OcjeniBtn.UseVisualStyleBackColor = true;
            this.OcjeniBtn.Click += new System.EventHandler(this.OcjeniBtn_Click);
            // 
            // OcjeniStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 225);
            this.Controls.Add(this.OcjeniBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.komentarInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ocjenaInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OcjeniStudentForm";
            this.ShowIcon = false;
            this.Text = "Ocjeni studenta";
            ((System.ComponentModel.ISupportInitialize)(this.ocjenaInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ocjenaInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox komentarInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OcjeniBtn;
    }
}