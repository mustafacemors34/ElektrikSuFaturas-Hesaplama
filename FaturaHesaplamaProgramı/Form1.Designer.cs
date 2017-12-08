namespace FaturaHesaplamaProgramı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblPuantTuketim = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblFaturaTutari = new System.Windows.Forms.Label();
            this.txtTuketimGunduz = new System.Windows.Forms.TextBox();
            this.txtTuketimGece = new System.Windows.Forms.TextBox();
            this.txtTuketimPuant = new System.Windows.Forms.TextBox();
            this.lblGeceTuketim = new System.Windows.Forms.Label();
            this.lblGunduzTuketim = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTemizleme = new System.Windows.Forms.Button();
            this.btnHesaplama = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtToplamDeger = new System.Windows.Forms.TextBox();
            this.txtAtik = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtTuketim = new System.Windows.Forms.TextBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblAtikSuBedeli = new System.Windows.Forms.Label();
            this.lblTuketimTutari = new System.Windows.Forms.Label();
            this.lblTuketimMiktari = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAbone = new System.Windows.Forms.ComboBox();
            this.txtSonEndeks = new System.Windows.Forms.TextBox();
            this.txtİlkEndeks = new System.Windows.Forms.TextBox();
            this.lblIlkEndeks = new System.Windows.Forms.Label();
            this.lblSonEndeks = new System.Windows.Forms.Label();
            this.lblSayacTip = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1201, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnHesapla);
            this.tabPage1.Controls.Add(this.btnTemizle);
            this.tabPage1.Controls.Add(this.lblPuantTuketim);
            this.tabPage1.Controls.Add(this.lblToplamTutar);
            this.tabPage1.Controls.Add(this.lblFaturaTutari);
            this.tabPage1.Controls.Add(this.txtTuketimGunduz);
            this.tabPage1.Controls.Add(this.txtTuketimGece);
            this.tabPage1.Controls.Add(this.txtTuketimPuant);
            this.tabPage1.Controls.Add(this.lblGeceTuketim);
            this.tabPage1.Controls.Add(this.lblGunduzTuketim);
            this.tabPage1.ForeColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1193, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Elektrik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(174, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(780, 38);
            this.label2.TabIndex = 23;
            this.label2.Text = "ELEKTRİK FATURASI HESAPLAMA PROGRAMI";
            // 
            // btnHesapla
            // 
            this.btnHesapla.ForeColor = System.Drawing.Color.Blue;
            this.btnHesapla.Location = new System.Drawing.Point(774, 317);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(4);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(145, 58);
            this.btnHesapla.TabIndex = 22;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ForeColor = System.Drawing.Color.Blue;
            this.btnTemizle.Location = new System.Drawing.Point(927, 317);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(145, 58);
            this.btnTemizle.TabIndex = 21;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblPuantTuketim
            // 
            this.lblPuantTuketim.AutoSize = true;
            this.lblPuantTuketim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuantTuketim.ForeColor = System.Drawing.Color.Blue;
            this.lblPuantTuketim.Location = new System.Drawing.Point(417, 100);
            this.lblPuantTuketim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuantTuketim.Name = "lblPuantTuketim";
            this.lblPuantTuketim.Size = new System.Drawing.Size(292, 25);
            this.lblPuantTuketim.TabIndex = 15;
            this.lblPuantTuketim.Text = "Puant Tüketim(17.00-22.00)       ";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Blue;
            this.lblToplamTutar.Location = new System.Drawing.Point(298, 331);
            this.lblToplamTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(52, 25);
            this.lblToplamTutar.TabIndex = 20;
            this.lblToplamTutar.Text = "0 TL";
            // 
            // lblFaturaTutari
            // 
            this.lblFaturaTutari.AutoSize = true;
            this.lblFaturaTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFaturaTutari.ForeColor = System.Drawing.Color.Blue;
            this.lblFaturaTutari.Location = new System.Drawing.Point(62, 331);
            this.lblFaturaTutari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFaturaTutari.Name = "lblFaturaTutari";
            this.lblFaturaTutari.Size = new System.Drawing.Size(123, 25);
            this.lblFaturaTutari.TabIndex = 19;
            this.lblFaturaTutari.Text = "Fatura Tutarı";
            // 
            // txtTuketimGunduz
            // 
            this.txtTuketimGunduz.Location = new System.Drawing.Point(58, 172);
            this.txtTuketimGunduz.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuketimGunduz.Name = "txtTuketimGunduz";
            this.txtTuketimGunduz.Size = new System.Drawing.Size(268, 22);
            this.txtTuketimGunduz.TabIndex = 13;
            // 
            // txtTuketimGece
            // 
            this.txtTuketimGece.Location = new System.Drawing.Point(804, 172);
            this.txtTuketimGece.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuketimGece.Name = "txtTuketimGece";
            this.txtTuketimGece.Size = new System.Drawing.Size(268, 22);
            this.txtTuketimGece.TabIndex = 18;
            // 
            // txtTuketimPuant
            // 
            this.txtTuketimPuant.Location = new System.Drawing.Point(422, 172);
            this.txtTuketimPuant.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuketimPuant.Name = "txtTuketimPuant";
            this.txtTuketimPuant.Size = new System.Drawing.Size(268, 22);
            this.txtTuketimPuant.TabIndex = 17;
            // 
            // lblGeceTuketim
            // 
            this.lblGeceTuketim.AutoSize = true;
            this.lblGeceTuketim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGeceTuketim.ForeColor = System.Drawing.Color.Blue;
            this.lblGeceTuketim.Location = new System.Drawing.Point(799, 100);
            this.lblGeceTuketim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeceTuketim.Name = "lblGeceTuketim";
            this.lblGeceTuketim.Size = new System.Drawing.Size(288, 25);
            this.lblGeceTuketim.TabIndex = 16;
            this.lblGeceTuketim.Text = "Gece Tüketim(22.00-06.00)       ";
            // 
            // lblGunduzTuketim
            // 
            this.lblGunduzTuketim.AutoSize = true;
            this.lblGunduzTuketim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGunduzTuketim.ForeColor = System.Drawing.Color.Blue;
            this.lblGunduzTuketim.Location = new System.Drawing.Point(53, 100);
            this.lblGunduzTuketim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGunduzTuketim.Name = "lblGunduzTuketim";
            this.lblGunduzTuketim.Size = new System.Drawing.Size(290, 25);
            this.lblGunduzTuketim.TabIndex = 14;
            this.lblGunduzTuketim.Text = "Gündüz Tüketim(06.00-17.00)   ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Teal;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnTemizleme);
            this.tabPage2.Controls.Add(this.btnHesaplama);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.ForeColor = System.Drawing.Color.Blue;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1193, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Su";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(240, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "SU FATURASI HESAPLAMA PROGRAMI";
            // 
            // btnTemizleme
            // 
            this.btnTemizleme.ForeColor = System.Drawing.Color.Blue;
            this.btnTemizleme.Location = new System.Drawing.Point(909, 330);
            this.btnTemizleme.Name = "btnTemizleme";
            this.btnTemizleme.Size = new System.Drawing.Size(129, 49);
            this.btnTemizleme.TabIndex = 13;
            this.btnTemizleme.Text = "TEMİZLE";
            this.btnTemizleme.UseVisualStyleBackColor = true;
            this.btnTemizleme.Click += new System.EventHandler(this.btnTemizleme_Click);
            // 
            // btnHesaplama
            // 
            this.btnHesaplama.Location = new System.Drawing.Point(774, 329);
            this.btnHesaplama.Name = "btnHesaplama";
            this.btnHesaplama.Size = new System.Drawing.Size(129, 50);
            this.btnHesaplama.TabIndex = 12;
            this.btnHesaplama.Text = "HESAPLA";
            this.btnHesaplama.UseVisualStyleBackColor = true;
            this.btnHesaplama.Click += new System.EventHandler(this.btnHesaplama_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtToplamDeger);
            this.groupBox2.Controls.Add(this.txtAtik);
            this.groupBox2.Controls.Add(this.txtTutar);
            this.groupBox2.Controls.Add(this.txtTuketim);
            this.groupBox2.Controls.Add(this.lblToplam);
            this.groupBox2.Controls.Add(this.lblAtikSuBedeli);
            this.groupBox2.Controls.Add(this.lblTuketimTutari);
            this.groupBox2.Controls.Add(this.lblTuketimMiktari);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(621, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 218);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ücretler";
            // 
            // txtToplamDeger
            // 
            this.txtToplamDeger.Enabled = false;
            this.txtToplamDeger.Location = new System.Drawing.Point(171, 167);
            this.txtToplamDeger.Name = "txtToplamDeger";
            this.txtToplamDeger.Size = new System.Drawing.Size(180, 27);
            this.txtToplamDeger.TabIndex = 10;
            // 
            // txtAtik
            // 
            this.txtAtik.Enabled = false;
            this.txtAtik.Location = new System.Drawing.Point(171, 124);
            this.txtAtik.Name = "txtAtik";
            this.txtAtik.Size = new System.Drawing.Size(180, 27);
            this.txtAtik.TabIndex = 9;
            // 
            // txtTutar
            // 
            this.txtTutar.Enabled = false;
            this.txtTutar.Location = new System.Drawing.Point(171, 75);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(180, 27);
            this.txtTutar.TabIndex = 8;
            // 
            // txtTuketim
            // 
            this.txtTuketim.Enabled = false;
            this.txtTuketim.Location = new System.Drawing.Point(171, 32);
            this.txtTuketim.Name = "txtTuketim";
            this.txtTuketim.Size = new System.Drawing.Size(180, 27);
            this.txtTuketim.TabIndex = 7;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(23, 170);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(69, 20);
            this.lblToplam.TabIndex = 3;
            this.lblToplam.Text = "Toplam:";
            // 
            // lblAtikSuBedeli
            // 
            this.lblAtikSuBedeli.AutoSize = true;
            this.lblAtikSuBedeli.Location = new System.Drawing.Point(23, 127);
            this.lblAtikSuBedeli.Name = "lblAtikSuBedeli";
            this.lblAtikSuBedeli.Size = new System.Drawing.Size(119, 20);
            this.lblAtikSuBedeli.TabIndex = 2;
            this.lblAtikSuBedeli.Text = "Atık Su Bedeli:";
            // 
            // lblTuketimTutari
            // 
            this.lblTuketimTutari.AutoSize = true;
            this.lblTuketimTutari.Location = new System.Drawing.Point(23, 82);
            this.lblTuketimTutari.Name = "lblTuketimTutari";
            this.lblTuketimTutari.Size = new System.Drawing.Size(146, 20);
            this.lblTuketimTutari.TabIndex = 1;
            this.lblTuketimTutari.Text = "Tüketim Tutarı:     ";
            // 
            // lblTuketimMiktari
            // 
            this.lblTuketimMiktari.AutoSize = true;
            this.lblTuketimMiktari.Location = new System.Drawing.Point(22, 39);
            this.lblTuketimMiktari.Name = "lblTuketimMiktari";
            this.lblTuketimMiktari.Size = new System.Drawing.Size(128, 20);
            this.lblTuketimMiktari.TabIndex = 0;
            this.lblTuketimMiktari.Text = "Tüketim Miktari:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAbone);
            this.groupBox1.Controls.Add(this.txtSonEndeks);
            this.groupBox1.Controls.Add(this.txtİlkEndeks);
            this.groupBox1.Controls.Add(this.lblIlkEndeks);
            this.groupBox1.Controls.Add(this.lblSonEndeks);
            this.groupBox1.Controls.Add(this.lblSayacTip);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(71, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 218);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Girdiler";
            // 
            // cmbAbone
            // 
            this.cmbAbone.FormattingEnabled = true;
            this.cmbAbone.Items.AddRange(new object[] {
            "Abone Türü Seçiniz",
            "Ev",
            "Dükkan"});
            this.cmbAbone.Location = new System.Drawing.Point(143, 127);
            this.cmbAbone.Name = "cmbAbone";
            this.cmbAbone.Size = new System.Drawing.Size(197, 28);
            this.cmbAbone.TabIndex = 2;
            // 
            // txtSonEndeks
            // 
            this.txtSonEndeks.Location = new System.Drawing.Point(143, 82);
            this.txtSonEndeks.Name = "txtSonEndeks";
            this.txtSonEndeks.Size = new System.Drawing.Size(197, 27);
            this.txtSonEndeks.TabIndex = 6;
            this.txtSonEndeks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSonEndeks_KeyPress);
            // 
            // txtİlkEndeks
            // 
            this.txtİlkEndeks.Location = new System.Drawing.Point(143, 40);
            this.txtİlkEndeks.Name = "txtİlkEndeks";
            this.txtİlkEndeks.Size = new System.Drawing.Size(197, 27);
            this.txtİlkEndeks.TabIndex = 5;
            this.txtİlkEndeks.TextChanged += new System.EventHandler(this.txtİlkEndeks_TextChanged);
            this.txtİlkEndeks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtİlkEndeks_KeyPress);
            // 
            // lblIlkEndeks
            // 
            this.lblIlkEndeks.AutoSize = true;
            this.lblIlkEndeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlkEndeks.Location = new System.Drawing.Point(16, 43);
            this.lblIlkEndeks.Name = "lblIlkEndeks";
            this.lblIlkEndeks.Size = new System.Drawing.Size(90, 20);
            this.lblIlkEndeks.TabIndex = 2;
            this.lblIlkEndeks.Text = "İlk Endeks:";
            // 
            // lblSonEndeks
            // 
            this.lblSonEndeks.AutoSize = true;
            this.lblSonEndeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonEndeks.Location = new System.Drawing.Point(16, 86);
            this.lblSonEndeks.Name = "lblSonEndeks";
            this.lblSonEndeks.Size = new System.Drawing.Size(103, 20);
            this.lblSonEndeks.TabIndex = 3;
            this.lblSonEndeks.Text = "Son Endeks:";
            // 
            // lblSayacTip
            // 
            this.lblSayacTip.AutoSize = true;
            this.lblSayacTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayacTip.Location = new System.Drawing.Point(16, 132);
            this.lblSayacTip.Name = "lblSayacTip";
            this.lblSayacTip.Size = new System.Drawing.Size(100, 20);
            this.lblSayacTip.TabIndex = 4;
            this.lblSayacTip.Text = "Abone Türü:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 473);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Elektrik ve Su Faturası Hesaplama Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblPuantTuketim;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblFaturaTutari;
        private System.Windows.Forms.TextBox txtTuketimGunduz;
        private System.Windows.Forms.TextBox txtTuketimGece;
        private System.Windows.Forms.TextBox txtTuketimPuant;
        private System.Windows.Forms.Label lblGeceTuketim;
        private System.Windows.Forms.Label lblGunduzTuketim;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTemizleme;
        private System.Windows.Forms.Button btnHesaplama;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtToplamDeger;
        private System.Windows.Forms.TextBox txtAtik;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtTuketim;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblAtikSuBedeli;
        private System.Windows.Forms.Label lblTuketimTutari;
        private System.Windows.Forms.Label lblTuketimMiktari;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbAbone;
        private System.Windows.Forms.TextBox txtSonEndeks;
        private System.Windows.Forms.TextBox txtİlkEndeks;
        private System.Windows.Forms.Label lblIlkEndeks;
        private System.Windows.Forms.Label lblSonEndeks;
        private System.Windows.Forms.Label lblSayacTip;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label2;
    }
}

