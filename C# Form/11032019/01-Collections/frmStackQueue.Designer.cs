namespace _01_Collections
{
    partial class frmStackQueue
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
            this.btnQueueEkle = new System.Windows.Forms.Button();
            this.btnenqueue = new System.Windows.Forms.Button();
            this.btnstackEkle = new System.Windows.Forms.Button();
            this.btnstackElemanlar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnQueueEkle
            // 
            this.btnQueueEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQueueEkle.Location = new System.Drawing.Point(29, 26);
            this.btnQueueEkle.Name = "btnQueueEkle";
            this.btnQueueEkle.Size = new System.Drawing.Size(257, 127);
            this.btnQueueEkle.TabIndex = 0;
            this.btnQueueEkle.Text = "Queue Eleman Ekle";
            this.btnQueueEkle.UseVisualStyleBackColor = true;
            this.btnQueueEkle.Click += new System.EventHandler(this.btnQueueEkle_Click);
            // 
            // btnenqueue
            // 
            this.btnenqueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnenqueue.Location = new System.Drawing.Point(29, 194);
            this.btnenqueue.Name = "btnenqueue";
            this.btnenqueue.Size = new System.Drawing.Size(257, 127);
            this.btnenqueue.TabIndex = 1;
            this.btnenqueue.Text = "Queue Elemanlar";
            this.btnenqueue.UseVisualStyleBackColor = true;
            this.btnenqueue.Click += new System.EventHandler(this.btnenqueue_Click);
            // 
            // btnstackEkle
            // 
            this.btnstackEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstackEkle.Location = new System.Drawing.Point(494, 26);
            this.btnstackEkle.Name = "btnstackEkle";
            this.btnstackEkle.Size = new System.Drawing.Size(257, 127);
            this.btnstackEkle.TabIndex = 2;
            this.btnstackEkle.Text = "Stack Eleman Ekle";
            this.btnstackEkle.UseVisualStyleBackColor = true;
            this.btnstackEkle.Click += new System.EventHandler(this.btnstackEkle_Click);
            // 
            // btnstackElemanlar
            // 
            this.btnstackElemanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstackElemanlar.Location = new System.Drawing.Point(494, 189);
            this.btnstackElemanlar.Name = "btnstackElemanlar";
            this.btnstackElemanlar.Size = new System.Drawing.Size(257, 127);
            this.btnstackElemanlar.TabIndex = 3;
            this.btnstackElemanlar.Text = "Stack Elemanlar";
            this.btnstackElemanlar.UseVisualStyleBackColor = true;
            this.btnstackElemanlar.Click += new System.EventHandler(this.btnstackElemanlar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(293, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 290);
            this.listBox1.TabIndex = 4;
            // 
            // frmStackQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnstackElemanlar);
            this.Controls.Add(this.btnstackEkle);
            this.Controls.Add(this.btnenqueue);
            this.Controls.Add(this.btnQueueEkle);
            this.Name = "frmStackQueue";
            this.Text = "frmStackQueue";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQueueEkle;
        private System.Windows.Forms.Button btnenqueue;
        private System.Windows.Forms.Button btnstackEkle;
        private System.Windows.Forms.Button btnstackElemanlar;
        private System.Windows.Forms.ListBox listBox1;
    }
}