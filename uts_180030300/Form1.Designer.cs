
namespace uts_180030300
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cB_wifi = new System.Windows.Forms.CheckBox();
            this.cB_heater = new System.Windows.Forms.CheckBox();
            this.cB_ac = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_Luas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cB_lantai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_bantu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.jenis_Borongan = new System.Windows.Forms.RadioButton();
            this.tb_tukang = new System.Windows.Forms.TextBox();
            this.jenis_Harian = new System.Windows.Forms.RadioButton();
            this.tb_hari = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cB_wifi);
            this.groupBox1.Controls.Add(this.cB_heater);
            this.groupBox1.Controls.Add(this.cB_ac);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tB_Luas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cB_lantai);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rinci Bangunan";
            // 
            // cB_wifi
            // 
            this.cB_wifi.AutoSize = true;
            this.cB_wifi.Location = new System.Drawing.Point(205, 112);
            this.cB_wifi.Name = "cB_wifi";
            this.cB_wifi.Size = new System.Drawing.Size(47, 19);
            this.cB_wifi.TabIndex = 9;
            this.cB_wifi.Text = "Wifi";
            this.cB_wifi.UseVisualStyleBackColor = true;
            // 
            // cB_heater
            // 
            this.cB_heater.AutoSize = true;
            this.cB_heater.Location = new System.Drawing.Point(94, 112);
            this.cB_heater.Name = "cB_heater";
            this.cB_heater.Size = new System.Drawing.Size(95, 19);
            this.cB_heater.TabIndex = 8;
            this.cB_heater.Text = "Water Heater";
            this.cB_heater.UseVisualStyleBackColor = true;
            // 
            // cB_ac
            // 
            this.cB_ac.AutoSize = true;
            this.cB_ac.Location = new System.Drawing.Point(29, 112);
            this.cB_ac.Name = "cB_ac";
            this.cB_ac.Size = new System.Drawing.Size(42, 19);
            this.cB_ac.TabIndex = 7;
            this.cB_ac.Text = "AC";
            this.cB_ac.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fasilitas Pendukung : ";
            // 
            // tB_Luas
            // 
            this.tB_Luas.Location = new System.Drawing.Point(139, 52);
            this.tB_Luas.Name = "tB_Luas";
            this.tB_Luas.Size = new System.Drawing.Size(148, 23);
            this.tB_Luas.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jumlah Lantai : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Luas Bangunan : ";
            // 
            // cB_lantai
            // 
            this.cB_lantai.FormattingEnabled = true;
            this.cB_lantai.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cB_lantai.Location = new System.Drawing.Point(139, 20);
            this.cB_lantai.Name = "cB_lantai";
            this.cB_lantai.Size = new System.Drawing.Size(148, 23);
            this.cB_lantai.TabIndex = 2;
            this.cB_lantai.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jenis Pekerjaan : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_bantu);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.jenis_Borongan);
            this.groupBox2.Controls.Add(this.tb_tukang);
            this.groupBox2.Controls.Add(this.jenis_Harian);
            this.groupBox2.Controls.Add(this.tb_hari);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(344, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 165);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rincian Pengerjaan";
            // 
            // tb_bantu
            // 
            this.tb_bantu.Location = new System.Drawing.Point(129, 81);
            this.tb_bantu.Name = "tb_bantu";
            this.tb_bantu.Size = new System.Drawing.Size(143, 23);
            this.tb_bantu.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tukang Pembantu :";
            // 
            // jenis_Borongan
            // 
            this.jenis_Borongan.AutoSize = true;
            this.jenis_Borongan.Location = new System.Drawing.Point(173, 114);
            this.jenis_Borongan.Name = "jenis_Borongan";
            this.jenis_Borongan.Size = new System.Drawing.Size(77, 19);
            this.jenis_Borongan.TabIndex = 9;
            this.jenis_Borongan.TabStop = true;
            this.jenis_Borongan.Text = "Borongan";
            this.jenis_Borongan.UseVisualStyleBackColor = true;
            // 
            // tb_tukang
            // 
            this.tb_tukang.Location = new System.Drawing.Point(129, 52);
            this.tb_tukang.Name = "tb_tukang";
            this.tb_tukang.Size = new System.Drawing.Size(143, 23);
            this.tb_tukang.TabIndex = 6;
            // 
            // jenis_Harian
            // 
            this.jenis_Harian.AutoSize = true;
            this.jenis_Harian.Location = new System.Drawing.Point(107, 114);
            this.jenis_Harian.Name = "jenis_Harian";
            this.jenis_Harian.Size = new System.Drawing.Size(60, 19);
            this.jenis_Harian.TabIndex = 8;
            this.jenis_Harian.TabStop = true;
            this.jenis_Harian.Text = "Harian";
            this.jenis_Harian.UseVisualStyleBackColor = true;
            // 
            // tb_hari
            // 
            this.tb_hari.Location = new System.Drawing.Point(129, 22);
            this.tb_hari.Name = "tb_hari";
            this.tb_hari.Size = new System.Drawing.Size(143, 23);
            this.tb_hari.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Jumlah Hari :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tukang Utama : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(106, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 149);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rincian Keuntungan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(180, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 46);
            this.label8.TabIndex = 1;
            this.label8.Text = "Label";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(448, 67);
            this.button1.TabIndex = 9;
            this.button1.Text = "Proses";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cB_wifi;
        private System.Windows.Forms.CheckBox cB_heater;
        private System.Windows.Forms.CheckBox cB_ac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tB_Luas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cB_lantai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton jenis_Borongan;
        private System.Windows.Forms.TextBox tb_tukang;
        private System.Windows.Forms.RadioButton jenis_Harian;
        private System.Windows.Forms.TextBox tb_hari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_bantu;
        private System.Windows.Forms.Label label7;
    }
}

