namespace _85_Forms_Not_Hesaplama_Projesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_birinci = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ikinci = new System.Windows.Forms.TextBox();
            this.btn_ortalama = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Not Girin";
            // 
            // txt_birinci
            // 
            this.txt_birinci.Location = new System.Drawing.Point(155, 75);
            this.txt_birinci.Name = "txt_birinci";
            this.txt_birinci.Size = new System.Drawing.Size(106, 22);
            this.txt_birinci.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(35, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "2. Not Girin";
            // 
            // txt_ikinci
            // 
            this.txt_ikinci.Location = new System.Drawing.Point(155, 103);
            this.txt_ikinci.Name = "txt_ikinci";
            this.txt_ikinci.Size = new System.Drawing.Size(106, 22);
            this.txt_ikinci.TabIndex = 4;
            // 
            // btn_ortalama
            // 
            this.btn_ortalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ortalama.Location = new System.Drawing.Point(39, 140);
            this.btn_ortalama.Name = "btn_ortalama";
            this.btn_ortalama.Size = new System.Drawing.Size(222, 23);
            this.btn_ortalama.TabIndex = 5;
            this.btn_ortalama.Text = "Ortalama Bul";
            this.btn_ortalama.UseVisualStyleBackColor = true;
            this.btn_ortalama.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ortalama Notu :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sonuc.Location = new System.Drawing.Point(181, 200);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(19, 20);
            this.lbl_sonuc.TabIndex = 6;
            this.lbl_sonuc.Text = "0";
            this.lbl_sonuc.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 233);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ortalama);
            this.Controls.Add(this.txt_ikinci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_birinci);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_birinci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ikinci;
        private System.Windows.Forms.Button btn_ortalama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

