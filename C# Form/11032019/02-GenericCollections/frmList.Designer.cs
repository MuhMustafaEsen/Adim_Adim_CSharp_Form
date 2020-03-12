namespace _02_GenericCollections
{
    partial class frmList
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
            this.btnIsimler = new System.Windows.Forms.Button();
            this.btnreverse = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSayilar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.btnContains = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIsimler
            // 
            this.btnIsimler.Location = new System.Drawing.Point(27, 84);
            this.btnIsimler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIsimler.Name = "btnIsimler";
            this.btnIsimler.Size = new System.Drawing.Size(112, 32);
            this.btnIsimler.TabIndex = 0;
            this.btnIsimler.Text = "İSİMLER";
            this.btnIsimler.UseVisualStyleBackColor = true;
            this.btnIsimler.Click += new System.EventHandler(this.btnIsimler_Click);
            // 
            // btnreverse
            // 
            this.btnreverse.Location = new System.Drawing.Point(27, 404);
            this.btnreverse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnreverse.Name = "btnreverse";
            this.btnreverse.Size = new System.Drawing.Size(112, 32);
            this.btnreverse.TabIndex = 1;
            this.btnreverse.Text = "Reverse";
            this.btnreverse.UseVisualStyleBackColor = true;
            this.btnreverse.Click += new System.EventHandler(this.btnreverse_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(27, 124);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(112, 32);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "İsim Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSayilar
            // 
            this.btnSayilar.Location = new System.Drawing.Point(27, 164);
            this.btnSayilar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSayilar.Name = "btnSayilar";
            this.btnSayilar.Size = new System.Drawing.Size(112, 32);
            this.btnSayilar.TabIndex = 3;
            this.btnSayilar.Text = "Sayılar";
            this.btnSayilar.UseVisualStyleBackColor = true;
            this.btnSayilar.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(27, 364);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 32);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(27, 204);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 32);
            this.button6.TabIndex = 5;
            this.button6.Text = "Sayi Ekle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(27, 244);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(112, 32);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(27, 284);
            this.btnCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(112, 32);
            this.btnCount.TabIndex = 7;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(27, 324);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(112, 32);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(185, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 436);
            this.listBox1.TabIndex = 9;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(420, 44);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(195, 436);
            this.listBox2.TabIndex = 10;
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(27, 11);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(112, 24);
            this.txtIsim.TabIndex = 11;
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(27, 444);
            this.btnContains.Margin = new System.Windows.Forms.Padding(4);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(112, 32);
            this.btnContains.TabIndex = 12;
            this.btnContains.Text = "Cointains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "AddRange";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 483);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSayilar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnreverse);
            this.Controls.Add(this.btnIsimler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmList";
            this.Text = "frmList";
            this.Load += new System.EventHandler(this.frmList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIsimler;
        private System.Windows.Forms.Button btnreverse;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSayilar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button button1;
    }
}