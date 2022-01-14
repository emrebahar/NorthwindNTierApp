namespace NTierApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUrunListele = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UrunEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UrunGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UrunSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageUrunGuncelle = new System.Windows.Forms.TabPage();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.nudGuncellemeStok = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbGuncellemeKategoriler = new System.Windows.Forms.ComboBox();
            this.txtGuncellemeFiyat = new System.Windows.Forms.TextBox();
            this.txtGuncellemeUrunAd = new System.Windows.Forms.TextBox();
            this.tabPageUrunEkle = new System.Windows.Forms.TabPage();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.nudEklemeStok = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUrunEklemeKategorler = new System.Windows.Forms.ComboBox();
            this.txtEklemeFiyat = new System.Windows.Forms.TextBox();
            this.txtEklemeUrunAd = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageUrunListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPageUrunGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuncellemeStok)).BeginInit();
            this.tabPageUrunEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEklemeStok)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUrunListele);
            this.tabControl1.Controls.Add(this.tabPageUrunGuncelle);
            this.tabControl1.Controls.Add(this.tabPageUrunEkle);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1063, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageUrunListele
            // 
            this.tabPageUrunListele.Controls.Add(this.dataGridView1);
            this.tabPageUrunListele.Controls.Add(this.comboBox1);
            this.tabPageUrunListele.Controls.Add(this.label1);
            this.tabPageUrunListele.Location = new System.Drawing.Point(4, 25);
            this.tabPageUrunListele.Name = "tabPageUrunListele";
            this.tabPageUrunListele.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrunListele.Size = new System.Drawing.Size(1055, 428);
            this.tabPageUrunListele.TabIndex = 0;
            this.tabPageUrunListele.Text = "ÜRÜN LİSTELEME";
            this.tabPageUrunListele.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(72, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(864, 327);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UrunEkleToolStripMenuItem,
            this.UrunGuncelleToolStripMenuItem,
            this.UrunSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 76);
            // 
            // UrunEkleToolStripMenuItem
            // 
            this.UrunEkleToolStripMenuItem.Name = "UrunEkleToolStripMenuItem";
            this.UrunEkleToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.UrunEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.UrunEkleToolStripMenuItem.Click += new System.EventHandler(this.UrunEkleToolStripMenuItem_Click);
            // 
            // UrunGuncelleToolStripMenuItem
            // 
            this.UrunGuncelleToolStripMenuItem.Name = "UrunGuncelleToolStripMenuItem";
            this.UrunGuncelleToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.UrunGuncelleToolStripMenuItem.Text = "Ürün Güncelle";
            this.UrunGuncelleToolStripMenuItem.Click += new System.EventHandler(this.UrunGuncelleToolStripMenuItem_Click);
            // 
            // UrunSilToolStripMenuItem
            // 
            this.UrunSilToolStripMenuItem.Name = "UrunSilToolStripMenuItem";
            this.UrunSilToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.UrunSilToolStripMenuItem.Text = "Ürün Sil";
            this.UrunSilToolStripMenuItem.Click += new System.EventHandler(this.UrunSilToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(331, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lütfen Bir Kategori Seçiniz:";
            // 
            // tabPageUrunGuncelle
            // 
            this.tabPageUrunGuncelle.Controls.Add(this.btnGuncelle);
            this.tabPageUrunGuncelle.Controls.Add(this.nudGuncellemeStok);
            this.tabPageUrunGuncelle.Controls.Add(this.label6);
            this.tabPageUrunGuncelle.Controls.Add(this.label7);
            this.tabPageUrunGuncelle.Controls.Add(this.label8);
            this.tabPageUrunGuncelle.Controls.Add(this.label9);
            this.tabPageUrunGuncelle.Controls.Add(this.cmbGuncellemeKategoriler);
            this.tabPageUrunGuncelle.Controls.Add(this.txtGuncellemeFiyat);
            this.tabPageUrunGuncelle.Controls.Add(this.txtGuncellemeUrunAd);
            this.tabPageUrunGuncelle.Location = new System.Drawing.Point(4, 25);
            this.tabPageUrunGuncelle.Name = "tabPageUrunGuncelle";
            this.tabPageUrunGuncelle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrunGuncelle.Size = new System.Drawing.Size(1055, 428);
            this.tabPageUrunGuncelle.TabIndex = 1;
            this.tabPageUrunGuncelle.Text = "ÜRÜN GÜNCELLEME";
            this.tabPageUrunGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(245, 276);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(396, 97);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // nudGuncellemeStok
            // 
            this.nudGuncellemeStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudGuncellemeStok.Location = new System.Drawing.Point(403, 129);
            this.nudGuncellemeStok.Margin = new System.Windows.Forms.Padding(4);
            this.nudGuncellemeStok.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudGuncellemeStok.Name = "nudGuncellemeStok";
            this.nudGuncellemeStok.Size = new System.Drawing.Size(237, 28);
            this.nudGuncellemeStok.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(241, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Kategori :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(241, 131);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ürün Stok :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(241, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ürün Fiyat :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(241, 59);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ürün Ad :";
            // 
            // cmbGuncellemeKategoriler
            // 
            this.cmbGuncellemeKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGuncellemeKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGuncellemeKategoriler.FormattingEnabled = true;
            this.cmbGuncellemeKategoriler.Location = new System.Drawing.Point(403, 190);
            this.cmbGuncellemeKategoriler.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGuncellemeKategoriler.Name = "cmbGuncellemeKategoriler";
            this.cmbGuncellemeKategoriler.Size = new System.Drawing.Size(236, 30);
            this.cmbGuncellemeKategoriler.TabIndex = 16;
            // 
            // txtGuncellemeFiyat
            // 
            this.txtGuncellemeFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuncellemeFiyat.Location = new System.Drawing.Point(403, 92);
            this.txtGuncellemeFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuncellemeFiyat.Name = "txtGuncellemeFiyat";
            this.txtGuncellemeFiyat.Size = new System.Drawing.Size(236, 28);
            this.txtGuncellemeFiyat.TabIndex = 14;
            // 
            // txtGuncellemeUrunAd
            // 
            this.txtGuncellemeUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuncellemeUrunAd.Location = new System.Drawing.Point(403, 55);
            this.txtGuncellemeUrunAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuncellemeUrunAd.Name = "txtGuncellemeUrunAd";
            this.txtGuncellemeUrunAd.Size = new System.Drawing.Size(236, 28);
            this.txtGuncellemeUrunAd.TabIndex = 15;
            // 
            // tabPageUrunEkle
            // 
            this.tabPageUrunEkle.Controls.Add(this.btnKaydet);
            this.tabPageUrunEkle.Controls.Add(this.nudEklemeStok);
            this.tabPageUrunEkle.Controls.Add(this.label4);
            this.tabPageUrunEkle.Controls.Add(this.label3);
            this.tabPageUrunEkle.Controls.Add(this.label5);
            this.tabPageUrunEkle.Controls.Add(this.label2);
            this.tabPageUrunEkle.Controls.Add(this.cmbUrunEklemeKategorler);
            this.tabPageUrunEkle.Controls.Add(this.txtEklemeFiyat);
            this.tabPageUrunEkle.Controls.Add(this.txtEklemeUrunAd);
            this.tabPageUrunEkle.Location = new System.Drawing.Point(4, 25);
            this.tabPageUrunEkle.Name = "tabPageUrunEkle";
            this.tabPageUrunEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrunEkle.Size = new System.Drawing.Size(1055, 428);
            this.tabPageUrunEkle.TabIndex = 2;
            this.tabPageUrunEkle.Text = "ÜRÜN EKLEME";
            this.tabPageUrunEkle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(245, 277);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(396, 97);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // nudEklemeStok
            // 
            this.nudEklemeStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudEklemeStok.Location = new System.Drawing.Point(404, 129);
            this.nudEklemeStok.Margin = new System.Windows.Forms.Padding(4);
            this.nudEklemeStok.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudEklemeStok.Name = "nudEklemeStok";
            this.nudEklemeStok.Size = new System.Drawing.Size(237, 28);
            this.nudEklemeStok.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(241, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kategori :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(241, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ürün Stok :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(241, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ürün Fiyat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(241, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ürün Ad :";
            // 
            // cmbUrunEklemeKategorler
            // 
            this.cmbUrunEklemeKategorler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunEklemeKategorler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunEklemeKategorler.FormattingEnabled = true;
            this.cmbUrunEklemeKategorler.Location = new System.Drawing.Point(404, 190);
            this.cmbUrunEklemeKategorler.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUrunEklemeKategorler.Name = "cmbUrunEklemeKategorler";
            this.cmbUrunEklemeKategorler.Size = new System.Drawing.Size(236, 30);
            this.cmbUrunEklemeKategorler.TabIndex = 7;
            // 
            // txtEklemeFiyat
            // 
            this.txtEklemeFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEklemeFiyat.Location = new System.Drawing.Point(404, 92);
            this.txtEklemeFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtEklemeFiyat.Name = "txtEklemeFiyat";
            this.txtEklemeFiyat.Size = new System.Drawing.Size(236, 28);
            this.txtEklemeFiyat.TabIndex = 5;
            // 
            // txtEklemeUrunAd
            // 
            this.txtEklemeUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEklemeUrunAd.Location = new System.Drawing.Point(404, 55);
            this.txtEklemeUrunAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtEklemeUrunAd.Name = "txtEklemeUrunAd";
            this.txtEklemeUrunAd.Size = new System.Drawing.Size(236, 28);
            this.txtEklemeUrunAd.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 471);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageUrunListele.ResumeLayout(false);
            this.tabPageUrunListele.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPageUrunGuncelle.ResumeLayout(false);
            this.tabPageUrunGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuncellemeStok)).EndInit();
            this.tabPageUrunEkle.ResumeLayout(false);
            this.tabPageUrunEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEklemeStok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUrunListele;
        private System.Windows.Forms.TabPage tabPageUrunGuncelle;
        private System.Windows.Forms.TabPage tabPageUrunEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.NumericUpDown nudGuncellemeStok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbGuncellemeKategoriler;
        private System.Windows.Forms.TextBox txtGuncellemeFiyat;
        private System.Windows.Forms.TextBox txtGuncellemeUrunAd;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.NumericUpDown nudEklemeStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUrunEklemeKategorler;
        private System.Windows.Forms.TextBox txtEklemeFiyat;
        private System.Windows.Forms.TextBox txtEklemeUrunAd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UrunEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UrunGuncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UrunSilToolStripMenuItem;
    }
}

