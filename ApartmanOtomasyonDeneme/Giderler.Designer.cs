namespace ApartmanOtomasyonDeneme
{
    partial class Giderler
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
            this.chk_elektrik = new System.Windows.Forms.CheckBox();
            this.chk_Su = new System.Windows.Forms.CheckBox();
            this.chk_asansor = new System.Windows.Forms.CheckBox();
            this.chk_temizlik = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_eklee = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_elektrik
            // 
            this.chk_elektrik.AutoSize = true;
            this.chk_elektrik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chk_elektrik.Location = new System.Drawing.Point(41, 36);
            this.chk_elektrik.Name = "chk_elektrik";
            this.chk_elektrik.Size = new System.Drawing.Size(123, 33);
            this.chk_elektrik.TabIndex = 1;
            this.chk_elektrik.Text = "Elektrik";
            this.chk_elektrik.UseVisualStyleBackColor = true;
            // 
            // chk_Su
            // 
            this.chk_Su.AutoSize = true;
            this.chk_Su.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chk_Su.Location = new System.Drawing.Point(41, 75);
            this.chk_Su.Name = "chk_Su";
            this.chk_Su.Size = new System.Drawing.Size(66, 33);
            this.chk_Su.TabIndex = 2;
            this.chk_Su.Text = "Su";
            this.chk_Su.UseVisualStyleBackColor = true;
            // 
            // chk_asansor
            // 
            this.chk_asansor.AutoSize = true;
            this.chk_asansor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chk_asansor.Location = new System.Drawing.Point(41, 114);
            this.chk_asansor.Name = "chk_asansor";
            this.chk_asansor.Size = new System.Drawing.Size(129, 33);
            this.chk_asansor.TabIndex = 3;
            this.chk_asansor.Text = "Asansör";
            this.chk_asansor.UseVisualStyleBackColor = true;
            // 
            // chk_temizlik
            // 
            this.chk_temizlik.AutoSize = true;
            this.chk_temizlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chk_temizlik.Location = new System.Drawing.Point(41, 153);
            this.chk_temizlik.Name = "chk_temizlik";
            this.chk_temizlik.Size = new System.Drawing.Size(134, 33);
            this.chk_temizlik.TabIndex = 4;
            this.chk_temizlik.Text = "Temizlik";
            this.chk_temizlik.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(241, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(241, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tarih";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(340, 41);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(242, 22);
            this.numericUpDown1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(340, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btn_eklee
            // 
            this.btn_eklee.Location = new System.Drawing.Point(246, 136);
            this.btn_eklee.Name = "btn_eklee";
            this.btn_eklee.Size = new System.Drawing.Size(336, 50);
            this.btn_eklee.TabIndex = 9;
            this.btn_eklee.Text = "EKLE";
            this.btn_eklee.UseVisualStyleBackColor = true;
            this.btn_eklee.Click += new System.EventHandler(this.btn_eklee_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_eklee);
            this.groupBox1.Controls.Add(this.chk_elektrik);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.chk_Su);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.chk_asansor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chk_temizlik);
            this.groupBox1.Location = new System.Drawing.Point(87, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 204);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giderler";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(333, 254);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(124, 228);
            this.listBox1.TabIndex = 11;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(87, 254);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(124, 228);
            this.listBox2.TabIndex = 12;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(588, 254);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(124, 228);
            this.listBox3.TabIndex = 13;
            // 
            // Giderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(880, 526);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Giderler";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.Giderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_elektrik;
        private System.Windows.Forms.CheckBox chk_Su;
        private System.Windows.Forms.CheckBox chk_asansor;
        private System.Windows.Forms.CheckBox chk_temizlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_eklee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}