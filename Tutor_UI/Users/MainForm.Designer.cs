namespace Tutor_UI.Users
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
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prijaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaBanovanihKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prijavljeniTutoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prijavljeniStudentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administratorToolStripMenuItem,
            this.tutorToolStripMenuItem,
            this.prijaveToolStripMenuItem,
            this.studentiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.administratorToolStripMenuItem.Text = "Administrator";
            this.administratorToolStripMenuItem.Click += new System.EventHandler(this.administratorToolStripMenuItem_Click);
            // 
            // tutorToolStripMenuItem
            // 
            this.tutorToolStripMenuItem.Name = "tutorToolStripMenuItem";
            this.tutorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.tutorToolStripMenuItem.Text = "Tutor";
            this.tutorToolStripMenuItem.Click += new System.EventHandler(this.tutorToolStripMenuItem_Click);
            // 
            // prijaveToolStripMenuItem
            // 
            this.prijaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaBanovanihKorisnikaToolStripMenuItem,
            this.prijavljeniTutoriToolStripMenuItem,
            this.prijavljeniStudentiToolStripMenuItem});
            this.prijaveToolStripMenuItem.Name = "prijaveToolStripMenuItem";
            this.prijaveToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.prijaveToolStripMenuItem.Text = "Prijave";
            // 
            // listaBanovanihKorisnikaToolStripMenuItem
            // 
            this.listaBanovanihKorisnikaToolStripMenuItem.Name = "listaBanovanihKorisnikaToolStripMenuItem";
            this.listaBanovanihKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.listaBanovanihKorisnikaToolStripMenuItem.Text = "Lista banovanih korisnika";
            this.listaBanovanihKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.listaBanovanihKorisnikaToolStripMenuItem_Click);
            // 
            // prijavljeniTutoriToolStripMenuItem
            // 
            this.prijavljeniTutoriToolStripMenuItem.Name = "prijavljeniTutoriToolStripMenuItem";
            this.prijavljeniTutoriToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.prijavljeniTutoriToolStripMenuItem.Text = "Prijavljeni studenti";
            this.prijavljeniTutoriToolStripMenuItem.Click += new System.EventHandler(this.prijavljeniTutoriToolStripMenuItem_Click);
            // 
            // prijavljeniStudentiToolStripMenuItem
            // 
            this.prijavljeniStudentiToolStripMenuItem.Name = "prijavljeniStudentiToolStripMenuItem";
            this.prijavljeniStudentiToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.prijavljeniStudentiToolStripMenuItem.Text = "Prijavljeni tutori";
            this.prijavljeniStudentiToolStripMenuItem.Click += new System.EventHandler(this.prijavljeniStudentiToolStripMenuItem_Click);
            // 
            // studentiToolStripMenuItem
            // 
            this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            this.studentiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.studentiToolStripMenuItem.Text = "Studenti";
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
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prijaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaBanovanihKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prijavljeniTutoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prijavljeniStudentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem;
    }
}