namespace _02_GenericCollections
{
    partial class frmDictionary
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
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstKeyValue = new System.Windows.Forms.ListBox();
            this.btnVeri = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnParacik = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(114, 43);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(148, 24);
            this.txtKey.TabIndex = 0;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(114, 85);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(148, 24);
            this.txtValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "KEY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "VALUE:";
            // 
            // lstKeyValue
            // 
            this.lstKeyValue.FormattingEnabled = true;
            this.lstKeyValue.ItemHeight = 18;
            this.lstKeyValue.Location = new System.Drawing.Point(32, 152);
            this.lstKeyValue.Name = "lstKeyValue";
            this.lstKeyValue.Size = new System.Drawing.Size(230, 220);
            this.lstKeyValue.TabIndex = 4;
            // 
            // btnVeri
            // 
            this.btnVeri.Location = new System.Drawing.Point(297, 40);
            this.btnVeri.Name = "btnVeri";
            this.btnVeri.Size = new System.Drawing.Size(230, 31);
            this.btnVeri.TabIndex = 5;
            this.btnVeri.Text = "Veri Dictionary";
            this.btnVeri.UseVisualStyleBackColor = true;
            this.btnVeri.Click += new System.EventHandler(this.btnVeri_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(297, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 31);
            this.button4.TabIndex = 8;
            this.button4.Text = "Temizle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(297, 304);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(230, 31);
            this.button5.TabIndex = 9;
            this.button5.Text = "O Keyi İçeriyor Mu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(297, 267);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(230, 31);
            this.button6.TabIndex = 10;
            this.button6.Text = "O Degeri İçeriyor Mu";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(297, 230);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(230, 31);
            this.button7.TabIndex = 11;
            this.button7.Text = "Kaç Eleman Var?";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Location = new System.Drawing.Point(297, 82);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(230, 31);
            this.btnOgrenci.TabIndex = 12;
            this.btnOgrenci.Text = "Öğrenci Dictionary";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnParacik
            // 
            this.btnParacik.Location = new System.Drawing.Point(297, 119);
            this.btnParacik.Name = "btnParacik";
            this.btnParacik.Size = new System.Drawing.Size(230, 31);
            this.btnParacik.TabIndex = 13;
            this.btnParacik.Text = "Paracıklar Dictionary";
            this.btnParacik.UseVisualStyleBackColor = true;
            this.btnParacik.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(297, 156);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(230, 31);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Eleman Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(297, 193);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(230, 31);
            this.btnsil.TabIndex = 15;
            this.btnsil.Text = "Eleman Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // frmDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 444);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnParacik);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnVeri);
            this.Controls.Add(this.lstKeyValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtKey);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDictionary";
            this.Text = "frmDictionary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstKeyValue;
        private System.Windows.Forms.Button btnVeri;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnParacik;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnsil;
    }
}