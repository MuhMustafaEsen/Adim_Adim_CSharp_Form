namespace _01_Collections
{
    partial class frmHashTable
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
            this.btnListele = new System.Windows.Forms.Button();
            this.lstHashTable = new System.Windows.Forms.ListBox();
            this.btnValue = new System.Windows.Forms.Button();
            this.btnKey = new System.Windows.Forms.Button();
            this.btnkeyeBak = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(54, 36);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(151, 23);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lstHashTable
            // 
            this.lstHashTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstHashTable.FormattingEnabled = true;
            this.lstHashTable.Location = new System.Drawing.Point(305, 0);
            this.lstHashTable.Name = "lstHashTable";
            this.lstHashTable.Size = new System.Drawing.Size(223, 450);
            this.lstHashTable.TabIndex = 1;
            // 
            // btnValue
            // 
            this.btnValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnValue.Location = new System.Drawing.Point(54, 83);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(151, 23);
            this.btnValue.TabIndex = 2;
            this.btnValue.Text = "Value";
            this.btnValue.UseVisualStyleBackColor = true;
            this.btnValue.Click += new System.EventHandler(this.btnValue_Click);
            // 
            // btnKey
            // 
            this.btnKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKey.Location = new System.Drawing.Point(54, 129);
            this.btnKey.Name = "btnKey";
            this.btnKey.Size = new System.Drawing.Size(151, 23);
            this.btnKey.TabIndex = 3;
            this.btnKey.Text = "Key";
            this.btnKey.UseVisualStyleBackColor = true;
            this.btnKey.Click += new System.EventHandler(this.btnKey_Click);
            // 
            // btnkeyeBak
            // 
            this.btnkeyeBak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkeyeBak.Location = new System.Drawing.Point(54, 175);
            this.btnkeyeBak.Name = "btnkeyeBak";
            this.btnkeyeBak.Size = new System.Drawing.Size(151, 23);
            this.btnkeyeBak.TabIndex = 4;
            this.btnkeyeBak.Text = "Keyi İçeriyor Mu";
            this.btnkeyeBak.UseVisualStyleBackColor = true;
            this.btnkeyeBak.Click += new System.EventHandler(this.btnkeyeBak_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(54, 228);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmHashTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnkeyeBak);
            this.Controls.Add(this.btnKey);
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.lstHashTable);
            this.Controls.Add(this.btnListele);
            this.Name = "frmHashTable";
            this.Text = "frmHashSet";
            this.Load += new System.EventHandler(this.frmHashTable_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ListBox lstHashTable;
        private System.Windows.Forms.Button btnValue;
        private System.Windows.Forms.Button btnKey;
        private System.Windows.Forms.Button btnkeyeBak;
        private System.Windows.Forms.Button button5;
    }
}