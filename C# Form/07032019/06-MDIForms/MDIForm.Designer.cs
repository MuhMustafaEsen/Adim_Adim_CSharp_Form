namespace _06_MDIForms
{
    partial class MDIForm
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
            this.yeniFormOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hizalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yatayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dikeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sıralıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniFormOluşturToolStripMenuItem,
            this.hizalaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yeniFormOluşturToolStripMenuItem
            // 
            this.yeniFormOluşturToolStripMenuItem.Name = "yeniFormOluşturToolStripMenuItem";
            this.yeniFormOluşturToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.yeniFormOluşturToolStripMenuItem.Text = "Yeni Form Oluştur";
            this.yeniFormOluşturToolStripMenuItem.Click += new System.EventHandler(this.yeniFormOluşturToolStripMenuItem_Click);
            // 
            // hizalaToolStripMenuItem
            // 
            this.hizalaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yatayToolStripMenuItem,
            this.dikeyToolStripMenuItem,
            this.sıralıToolStripMenuItem});
            this.hizalaToolStripMenuItem.Name = "hizalaToolStripMenuItem";
            this.hizalaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.hizalaToolStripMenuItem.Text = "Hizala";
            // 
            // yatayToolStripMenuItem
            // 
            this.yatayToolStripMenuItem.Name = "yatayToolStripMenuItem";
            this.yatayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yatayToolStripMenuItem.Text = "Yatay";
            this.yatayToolStripMenuItem.Click += new System.EventHandler(this.yatayToolStripMenuItem_Click);
            // 
            // dikeyToolStripMenuItem
            // 
            this.dikeyToolStripMenuItem.Name = "dikeyToolStripMenuItem";
            this.dikeyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dikeyToolStripMenuItem.Text = "Dikey";
            this.dikeyToolStripMenuItem.Click += new System.EventHandler(this.dikeyToolStripMenuItem_Click);
            // 
            // sıralıToolStripMenuItem
            // 
            this.sıralıToolStripMenuItem.Name = "sıralıToolStripMenuItem";
            this.sıralıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sıralıToolStripMenuItem.Text = "Sıralı";
            this.sıralıToolStripMenuItem.Click += new System.EventHandler(this.sıralıToolStripMenuItem_Click);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 416);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIForm";
            this.Text = "MDIForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniFormOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hizalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yatayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dikeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sıralıToolStripMenuItem;
    }
}