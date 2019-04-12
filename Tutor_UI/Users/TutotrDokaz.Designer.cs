namespace Tutor_UI.Users
{
    partial class TutotrDokaz
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
            this.dokazPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dokazPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dokazPictureBox
            // 
            this.dokazPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dokazPictureBox.Location = new System.Drawing.Point(0, 0);
            this.dokazPictureBox.Name = "dokazPictureBox";
            this.dokazPictureBox.Size = new System.Drawing.Size(120, 0);
            this.dokazPictureBox.TabIndex = 0;
            this.dokazPictureBox.TabStop = false;
            // 
            // TutotrDokaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(120, 0);
            this.Controls.Add(this.dokazPictureBox);
            this.Name = "TutotrDokaz";
            this.Text = "TutotrDokaz";
            ((System.ComponentModel.ISupportInitialize)(this.dokazPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dokazPictureBox;
    }
}