
namespace maaş_hesaplama
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Ad_txt = new System.Windows.Forms.TextBox();
            this.Soyad_txt = new System.Windows.Forms.TextBox();
            this.Maas_txt = new System.Windows.Forms.TextBox();
            this.Msaati_txt = new System.Windows.Forms.TextBox();
            this.hesaplaBtn = new System.Windows.Forms.Button();
            this.gunduz_rbt = new System.Windows.Forms.RadioButton();
            this.Gece_rbt = new System.Windows.Forms.RadioButton();
            this.sonuc_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maaşı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mesai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mesai Saati";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sonuç";
            // 
            // Ad_txt
            // 
            this.Ad_txt.Location = new System.Drawing.Point(196, 55);
            this.Ad_txt.Name = "Ad_txt";
            this.Ad_txt.Size = new System.Drawing.Size(100, 20);
            this.Ad_txt.TabIndex = 7;
            // 
            // Soyad_txt
            // 
            this.Soyad_txt.Location = new System.Drawing.Point(196, 81);
            this.Soyad_txt.Name = "Soyad_txt";
            this.Soyad_txt.Size = new System.Drawing.Size(100, 20);
            this.Soyad_txt.TabIndex = 8;
            // 
            // Maas_txt
            // 
            this.Maas_txt.Location = new System.Drawing.Point(196, 107);
            this.Maas_txt.Name = "Maas_txt";
            this.Maas_txt.Size = new System.Drawing.Size(100, 20);
            this.Maas_txt.TabIndex = 9;
            // 
            // Msaati_txt
            // 
            this.Msaati_txt.Location = new System.Drawing.Point(196, 219);
            this.Msaati_txt.Name = "Msaati_txt";
            this.Msaati_txt.Size = new System.Drawing.Size(100, 20);
            this.Msaati_txt.TabIndex = 11;
            // 
            // hesaplaBtn
            // 
            this.hesaplaBtn.Location = new System.Drawing.Point(119, 288);
            this.hesaplaBtn.Name = "hesaplaBtn";
            this.hesaplaBtn.Size = new System.Drawing.Size(75, 23);
            this.hesaplaBtn.TabIndex = 12;
            this.hesaplaBtn.Text = "Hesapla";
            this.hesaplaBtn.UseVisualStyleBackColor = true;
            this.hesaplaBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // gunduz_rbt
            // 
            this.gunduz_rbt.AutoSize = true;
            this.gunduz_rbt.Location = new System.Drawing.Point(196, 188);
            this.gunduz_rbt.Name = "gunduz_rbt";
            this.gunduz_rbt.Size = new System.Drawing.Size(62, 17);
            this.gunduz_rbt.TabIndex = 13;
            this.gunduz_rbt.TabStop = true;
            this.gunduz_rbt.Text = "Gündüz";
            this.gunduz_rbt.UseVisualStyleBackColor = true;
            // 
            // Gece_rbt
            // 
            this.Gece_rbt.AutoSize = true;
            this.Gece_rbt.Location = new System.Drawing.Point(287, 188);
            this.Gece_rbt.Name = "Gece_rbt";
            this.Gece_rbt.Size = new System.Drawing.Size(51, 17);
            this.Gece_rbt.TabIndex = 14;
            this.Gece_rbt.TabStop = true;
            this.Gece_rbt.Text = "Gece";
            this.Gece_rbt.UseVisualStyleBackColor = true;
            // 
            // sonuc_lbl
            // 
            this.sonuc_lbl.AutoSize = true;
            this.sonuc_lbl.Location = new System.Drawing.Point(193, 330);
            this.sonuc_lbl.Name = "sonuc_lbl";
            this.sonuc_lbl.Size = new System.Drawing.Size(16, 13);
            this.sonuc_lbl.TabIndex = 15;
            this.sonuc_lbl.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sonuc_lbl);
            this.Controls.Add(this.Gece_rbt);
            this.Controls.Add(this.gunduz_rbt);
            this.Controls.Add(this.hesaplaBtn);
            this.Controls.Add(this.Msaati_txt);
            this.Controls.Add(this.Maas_txt);
            this.Controls.Add(this.Soyad_txt);
            this.Controls.Add(this.Ad_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Ad_txt;
        private System.Windows.Forms.TextBox Soyad_txt;
        private System.Windows.Forms.TextBox Maas_txt;
        private System.Windows.Forms.TextBox Msaati_txt;
        private System.Windows.Forms.Button hesaplaBtn;
        private System.Windows.Forms.RadioButton gunduz_rbt;
        private System.Windows.Forms.RadioButton Gece_rbt;
        private System.Windows.Forms.Label sonuc_lbl;
    }
}

