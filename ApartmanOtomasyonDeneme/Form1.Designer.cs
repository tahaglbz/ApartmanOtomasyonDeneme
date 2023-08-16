namespace ApartmanOtomasyonDeneme
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
            this.btn_giderler = new System.Windows.Forms.Button();
            this.btn_gelirler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_giderler
            // 
            this.btn_giderler.BackColor = System.Drawing.Color.Yellow;
            this.btn_giderler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_giderler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giderler.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_giderler.Location = new System.Drawing.Point(516, 65);
            this.btn_giderler.Name = "btn_giderler";
            this.btn_giderler.Size = new System.Drawing.Size(153, 356);
            this.btn_giderler.TabIndex = 1;
            this.btn_giderler.Text = "Giderler";
            this.btn_giderler.UseVisualStyleBackColor = false;
            this.btn_giderler.Click += new System.EventHandler(this.btn_giderler_Click);
            // 
            // btn_gelirler
            // 
            this.btn_gelirler.BackColor = System.Drawing.Color.Yellow;
            this.btn_gelirler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gelirler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gelirler.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_gelirler.Location = new System.Drawing.Point(211, 65);
            this.btn_gelirler.Name = "btn_gelirler";
            this.btn_gelirler.Size = new System.Drawing.Size(153, 356);
            this.btn_gelirler.TabIndex = 2;
            this.btn_gelirler.Text = "Gelirler";
            this.btn_gelirler.UseVisualStyleBackColor = false;
            this.btn_gelirler.Click += new System.EventHandler(this.btn_gelirler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(872, 520);
            this.Controls.Add(this.btn_gelirler);
            this.Controls.Add(this.btn_giderler);
            this.ForeColor = System.Drawing.Color.Chartreuse;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_giderler;
        private System.Windows.Forms.Button btn_gelirler;
    }
}

