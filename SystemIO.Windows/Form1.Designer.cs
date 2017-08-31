namespace SystemIO.Windows
{
    partial class Form1
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateGPAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.AddStudentToolStripMenuItem,
            this.DeleteStudentToolStripMenuItem,
            this.UpdateGPAToolStripMenuItem,
            this.QuitToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "menuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(795, 24);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "toolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(86, 20);
            this.ToolStripMenuItem1.Text = "List Students";
            // 
            // addStudentToolStripMenuItem
            // 
            this.AddStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.AddStudentToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.AddStudentToolStripMenuItem.Text = "Add Student";
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.DeleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.DeleteStudentToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.DeleteStudentToolStripMenuItem.Text = "Delete Student";
            // 
            // updateGPAToolStripMenuItem
            // 
            this.UpdateGPAToolStripMenuItem.Name = "updateGPAToolStripMenuItem";
            this.UpdateGPAToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.UpdateGPAToolStripMenuItem.Text = "Update GPA";
            // 
            // quitToolStripMenuItem
            // 
            this.QuitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.QuitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.QuitToolStripMenuItem.Text = "Quit";
            this.QuitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 478);
            this.Controls.Add(this.MenuStrip1);
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "Form1";
            this.Text = "SMS Windows Version";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AddStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateGPAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuitToolStripMenuItem;
    }
}

