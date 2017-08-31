namespace SystemIO.Selector
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
            this.btnConsole = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnWPF = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsole
            // 
            this.btnConsole.Location = new System.Drawing.Point(80, 42);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.Size = new System.Drawing.Size(125, 23);
            this.btnConsole.TabIndex = 0;
            this.btnConsole.Text = "Console App";
            this.btnConsole.UseVisualStyleBackColor = true;
            this.btnConsole.Click += new System.EventHandler(this.BtnConsole_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Windows App";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnWindows_Click);
            // 
            // BtnWPF
            // 
            this.BtnWPF.Location = new System.Drawing.Point(80, 144);
            this.BtnWPF.Name = "BtnWPF";
            this.BtnWPF.Size = new System.Drawing.Size(125, 23);
            this.BtnWPF.TabIndex = 2;
            this.BtnWPF.Text = "WPF App";
            this.BtnWPF.UseVisualStyleBackColor = true;
            this.BtnWPF.Click += new System.EventHandler(this.BtnWPF_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(80, 195);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(125, 23);
            this.BtnQuit.TabIndex = 3;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnWPF);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnConsole);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsole;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnWPF;
        private System.Windows.Forms.Button BtnQuit;
    }
}

