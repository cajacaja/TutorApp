namespace Tutor_UI.Users.Tutor
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tutorProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zahtjeviZaCasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mojiStudentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucioniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorProfilToolStripMenuItem,
            this.zahtjeviZaCasToolStripMenuItem,
            this.mojiStudentiToolStripMenuItem,
            this.ucioniceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tutorProfilToolStripMenuItem
            // 
            this.tutorProfilToolStripMenuItem.Name = "tutorProfilToolStripMenuItem";
            this.tutorProfilToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.tutorProfilToolStripMenuItem.Text = "Tutor profil";
            this.tutorProfilToolStripMenuItem.Click += new System.EventHandler(this.tutorProfilToolStripMenuItem_Click);
            // 
            // zahtjeviZaCasToolStripMenuItem
            // 
            this.zahtjeviZaCasToolStripMenuItem.Name = "zahtjeviZaCasToolStripMenuItem";
            this.zahtjeviZaCasToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.zahtjeviZaCasToolStripMenuItem.Text = "Zahtjevi za cas";
            this.zahtjeviZaCasToolStripMenuItem.Click += new System.EventHandler(this.zahtjeviZaCasToolStripMenuItem_Click);
            // 
            // mojiStudentiToolStripMenuItem
            // 
            this.mojiStudentiToolStripMenuItem.Name = "mojiStudentiToolStripMenuItem";
            this.mojiStudentiToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.mojiStudentiToolStripMenuItem.Text = "Moji studenti";
            this.mojiStudentiToolStripMenuItem.Click += new System.EventHandler(this.mojiStudentiToolStripMenuItem_Click);
            // 
            // ucioniceToolStripMenuItem
            // 
            this.ucioniceToolStripMenuItem.Name = "ucioniceToolStripMenuItem";
            this.ucioniceToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ucioniceToolStripMenuItem.Text = "Ucionice";
            this.ucioniceToolStripMenuItem.Click += new System.EventHandler(this.ucioniceToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tutorProfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zahtjeviZaCasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mojiStudentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ucioniceToolStripMenuItem;
    }
}