namespace Tutor_UI.Users
{
    partial class TutorPrijaveDetailsForm
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
            this.StudentInput = new System.Windows.Forms.TextBox();
            this.TutorInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tutorBtn = new System.Windows.Forms.Button();
            this.studentBtn = new System.Windows.Forms.Button();
            this.RazlogRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.DatumPrijaveInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StudentInput
            // 
            this.StudentInput.BackColor = System.Drawing.SystemColors.Control;
            this.StudentInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentInput.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StudentInput.Location = new System.Drawing.Point(12, 45);
            this.StudentInput.Name = "StudentInput";
            this.StudentInput.ReadOnly = true;
            this.StudentInput.Size = new System.Drawing.Size(151, 18);
            this.StudentInput.TabIndex = 0;
            this.StudentInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TutorInput
            // 
            this.TutorInput.BackColor = System.Drawing.SystemColors.Control;
            this.TutorInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TutorInput.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TutorInput.Location = new System.Drawing.Point(12, 102);
            this.TutorInput.Name = "TutorInput";
            this.TutorInput.ReadOnly = true;
            this.TutorInput.Size = new System.Drawing.Size(151, 18);
            this.TutorInput.TabIndex = 1;
            this.TutorInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(39, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prijavio";
            // 
            // tutorBtn
            // 
            this.tutorBtn.Location = new System.Drawing.Point(327, 140);
            this.tutorBtn.Name = "tutorBtn";
            this.tutorBtn.Size = new System.Drawing.Size(121, 31);
            this.tutorBtn.TabIndex = 3;
            this.tutorBtn.Text = "Profil tutora";
            this.tutorBtn.UseVisualStyleBackColor = true;
            this.tutorBtn.Click += new System.EventHandler(this.tutorBtn_Click);
            // 
            // studentBtn
            // 
            this.studentBtn.Location = new System.Drawing.Point(182, 140);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(121, 31);
            this.studentBtn.TabIndex = 4;
            this.studentBtn.Text = "Profil studenta";
            this.studentBtn.UseVisualStyleBackColor = true;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
            // 
            // RazlogRichTxtBox
            // 
            this.RazlogRichTxtBox.Location = new System.Drawing.Point(182, 5);
            this.RazlogRichTxtBox.Name = "RazlogRichTxtBox";
            this.RazlogRichTxtBox.ReadOnly = true;
            this.RazlogRichTxtBox.Size = new System.Drawing.Size(276, 115);
            this.RazlogRichTxtBox.TabIndex = 5;
            this.RazlogRichTxtBox.Text = "";
            // 
            // DatumPrijaveInput
            // 
            this.DatumPrijaveInput.BackColor = System.Drawing.SystemColors.Control;
            this.DatumPrijaveInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatumPrijaveInput.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatumPrijaveInput.Location = new System.Drawing.Point(12, 12);
            this.DatumPrijaveInput.Name = "DatumPrijaveInput";
            this.DatumPrijaveInput.ReadOnly = true;
            this.DatumPrijaveInput.Size = new System.Drawing.Size(151, 17);
            this.DatumPrijaveInput.TabIndex = 6;
            this.DatumPrijaveInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TutorPrijaveDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 198);
            this.Controls.Add(this.DatumPrijaveInput);
            this.Controls.Add(this.RazlogRichTxtBox);
            this.Controls.Add(this.studentBtn);
            this.Controls.Add(this.tutorBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TutorInput);
            this.Controls.Add(this.StudentInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TutorPrijaveDetailsForm";
            this.ShowIcon = false;
            this.Text = "Prijavljeni tutori od strane studenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StudentInput;
        private System.Windows.Forms.TextBox TutorInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tutorBtn;
        private System.Windows.Forms.Button studentBtn;
        private System.Windows.Forms.RichTextBox RazlogRichTxtBox;
        private System.Windows.Forms.TextBox DatumPrijaveInput;
    }
}