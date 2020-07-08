namespace Proekt_Georgi_Dimitrov_1901682009
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
			this.btnEnterInfo = new System.Windows.Forms.Button();
			this.btnCloseForm = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.aboutInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnEnterInfo
			// 
			this.btnEnterInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnEnterInfo.Location = new System.Drawing.Point(60, 33);
			this.btnEnterInfo.Name = "btnEnterInfo";
			this.btnEnterInfo.Size = new System.Drawing.Size(186, 73);
			this.btnEnterInfo.TabIndex = 0;
			this.btnEnterInfo.Text = "Enter Information";
			this.btnEnterInfo.UseVisualStyleBackColor = false;
			this.btnEnterInfo.Click += new System.EventHandler(this.btnEnterInfo_Click);
			// 
			// btnCloseForm
			// 
			this.btnCloseForm.BackColor = System.Drawing.Color.Silver;
			this.btnCloseForm.Location = new System.Drawing.Point(60, 140);
			this.btnCloseForm.Name = "btnCloseForm";
			this.btnCloseForm.Size = new System.Drawing.Size(186, 73);
			this.btnCloseForm.TabIndex = 1;
			this.btnCloseForm.Text = "Close!";
			this.btnCloseForm.UseVisualStyleBackColor = false;
			this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.LemonChiffon;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutInfoToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(331, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// aboutInfoToolStripMenuItem
			// 
			this.aboutInfoToolStripMenuItem.Name = "aboutInfoToolStripMenuItem";
			this.aboutInfoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.aboutInfoToolStripMenuItem.Text = "Author";
			this.aboutInfoToolStripMenuItem.Click += new System.EventHandler(this.aboutInfoToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(331, 250);
			this.Controls.Add(this.btnCloseForm);
			this.Controls.Add(this.btnEnterInfo);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Rent a car";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterInfo;
        private System.Windows.Forms.Button btnCloseForm;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem aboutInfoToolStripMenuItem;
	}
}

