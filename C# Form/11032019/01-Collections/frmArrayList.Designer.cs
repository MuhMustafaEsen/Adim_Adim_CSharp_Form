namespace _01_Collections
{
    partial class frmArrayList
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
            this.lstOrijinal = new System.Windows.Forms.ListBox();
            this.lstOynanmıs = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnArrayList = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSirala = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnCapacity = new System.Windows.Forms.Button();
            this.btnAyar = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstOrijinal
            // 
            this.lstOrijinal.FormattingEnabled = true;
            this.lstOrijinal.ItemHeight = 18;
            this.lstOrijinal.Location = new System.Drawing.Point(13, 13);
            this.lstOrijinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstOrijinal.Name = "lstOrijinal";
            this.lstOrijinal.Size = new System.Drawing.Size(178, 400);
            this.lstOrijinal.TabIndex = 0;
            // 
            // lstOynanmıs
            // 
            this.lstOynanmıs.FormattingEnabled = true;
            this.lstOynanmıs.ItemHeight = 18;
            this.lstOynanmıs.Location = new System.Drawing.Point(211, 13);
            this.lstOynanmıs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstOynanmıs.Name = "lstOynanmıs";
            this.lstOynanmıs.Size = new System.Drawing.Size(178, 400);
            this.lstOynanmıs.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(414, 44);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Eleman Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(414, 124);
            this.btnContains.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(162, 32);
            this.btnContains.TabIndex = 3;
            this.btnContains.Text = "Elemanı İçeriyor Mu?";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(414, 84);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(162, 32);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Elemanı Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnArrayList
            // 
            this.btnArrayList.Location = new System.Drawing.Point(414, 204);
            this.btnArrayList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnArrayList.Name = "btnArrayList";
            this.btnArrayList.Size = new System.Drawing.Size(162, 32);
            this.btnArrayList.TabIndex = 6;
            this.btnArrayList.Text = "Boş Diziye Eleman Ekle";
            this.btnArrayList.UseVisualStyleBackColor = true;
            this.btnArrayList.Click += new System.EventHandler(this.btnArrayList_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(414, 164);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(162, 32);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Araya Eleman Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSirala
            // 
            this.btnSirala.Location = new System.Drawing.Point(414, 365);
            this.btnSirala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(162, 32);
            this.btnSirala.TabIndex = 8;
            this.btnSirala.Text = "Sehirleri Sırala";
            this.btnSirala.UseVisualStyleBackColor = true;
            this.btnSirala.Click += new System.EventHandler(this.btnSirala_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(414, 244);
            this.btnCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(162, 32);
            this.btnCount.TabIndex = 9;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnCapacity
            // 
            this.btnCapacity.Location = new System.Drawing.Point(414, 285);
            this.btnCapacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapacity.Name = "btnCapacity";
            this.btnCapacity.Size = new System.Drawing.Size(162, 32);
            this.btnCapacity.TabIndex = 10;
            this.btnCapacity.Text = "Capacity";
            this.btnCapacity.UseVisualStyleBackColor = true;
            this.btnCapacity.Click += new System.EventHandler(this.btnCapacity_Click);
            // 
            // btnAyar
            // 
            this.btnAyar.Location = new System.Drawing.Point(414, 325);
            this.btnAyar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAyar.Name = "btnAyar";
            this.btnAyar.Size = new System.Drawing.Size(162, 32);
            this.btnAyar.TabIndex = 11;
            this.btnAyar.Text = "Capacity Ayarı";
            this.btnAyar.UseVisualStyleBackColor = true;
            this.btnAyar.Click += new System.EventHandler(this.btnAyar_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(414, 13);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(162, 24);
            this.txtValue.TabIndex = 12;
            // 
            // frmArrayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 445);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnAyar);
            this.Controls.Add(this.btnCapacity);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnSirala);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnArrayList);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstOynanmıs);
            this.Controls.Add(this.lstOrijinal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmArrayList";
            this.Text = "frmArrayList";
            this.Load += new System.EventHandler(this.frmArrayList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOrijinal;
        private System.Windows.Forms.ListBox lstOynanmıs;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnArrayList;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSirala;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnCapacity;
        private System.Windows.Forms.Button btnAyar;
        private System.Windows.Forms.TextBox txtValue;
    }
}