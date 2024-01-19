namespace BookStock
{
    partial class frmUrunListeleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SatisFiyatTxt = new System.Windows.Forms.TextBox();
            this.MiktarTxt = new System.Windows.Forms.TextBox();
            this.AlisFiyatTxt = new System.Windows.Forms.TextBox();
            this.BarkodNoTxt = new System.Windows.Forms.TextBox();
            this.KategoriTxt = new System.Windows.Forms.TextBox();
            this.UrunAdiTxt = new System.Windows.Forms.TextBox();
            this.YazarTxt = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtBarkodNoAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMarkaGüncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(358, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(732, 332);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(235, 309);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(94, 46);
            this.btnGüncelle.TabIndex = 14;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 272);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 16);
            this.label15.TabIndex = 28;
            this.label15.Text = "Satış Fiyatı";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 239);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 29;
            this.label16.Text = "Alış Fiyatı";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(53, 206);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 16);
            this.label17.TabIndex = 30;
            this.label17.Text = "Miktarı";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 170);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 16);
            this.label18.TabIndex = 31;
            this.label18.Text = "Ürün Adı";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(54, 138);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 16);
            this.label19.TabIndex = 32;
            this.label19.Text = "Yazar";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(42, 106);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 16);
            this.label20.TabIndex = 33;
            this.label20.Text = "Kategori";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label21.Location = new System.Drawing.Point(27, 73);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 16);
            this.label21.TabIndex = 34;
            this.label21.Text = "BarkodNo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(99, 266);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 16);
            this.label14.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(99, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(99, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(99, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(99, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(99, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 21;
            // 
            // SatisFiyatTxt
            // 
            this.SatisFiyatTxt.Location = new System.Drawing.Point(105, 266);
            this.SatisFiyatTxt.Name = "SatisFiyatTxt";
            this.SatisFiyatTxt.Size = new System.Drawing.Size(224, 22);
            this.SatisFiyatTxt.TabIndex = 19;
            // 
            // MiktarTxt
            // 
            this.MiktarTxt.Location = new System.Drawing.Point(105, 200);
            this.MiktarTxt.Name = "MiktarTxt";
            this.MiktarTxt.Size = new System.Drawing.Size(224, 22);
            this.MiktarTxt.TabIndex = 18;
            // 
            // AlisFiyatTxt
            // 
            this.AlisFiyatTxt.Location = new System.Drawing.Point(105, 233);
            this.AlisFiyatTxt.Name = "AlisFiyatTxt";
            this.AlisFiyatTxt.Size = new System.Drawing.Size(224, 22);
            this.AlisFiyatTxt.TabIndex = 17;
            // 
            // BarkodNoTxt
            // 
            this.BarkodNoTxt.Location = new System.Drawing.Point(105, 73);
            this.BarkodNoTxt.Name = "BarkodNoTxt";
            this.BarkodNoTxt.Size = new System.Drawing.Size(224, 22);
            this.BarkodNoTxt.TabIndex = 16;
            // 
            // KategoriTxt
            // 
            this.KategoriTxt.Location = new System.Drawing.Point(105, 101);
            this.KategoriTxt.Name = "KategoriTxt";
            this.KategoriTxt.ReadOnly = true;
            this.KategoriTxt.Size = new System.Drawing.Size(224, 22);
            this.KategoriTxt.TabIndex = 15;
            // 
            // UrunAdiTxt
            // 
            this.UrunAdiTxt.Location = new System.Drawing.Point(105, 167);
            this.UrunAdiTxt.Name = "UrunAdiTxt";
            this.UrunAdiTxt.Size = new System.Drawing.Size(224, 22);
            this.UrunAdiTxt.TabIndex = 20;
            // 
            // YazarTxt
            // 
            this.YazarTxt.Location = new System.Drawing.Point(105, 134);
            this.YazarTxt.Name = "YazarTxt";
            this.YazarTxt.ReadOnly = true;
            this.YazarTxt.Size = new System.Drawing.Size(224, 22);
            this.YazarTxt.TabIndex = 13;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(886, 423);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(125, 55);
            this.btnSil.TabIndex = 35;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtBarkodNoAra
            // 
            this.txtBarkodNoAra.Location = new System.Drawing.Point(505, 32);
            this.txtBarkodNoAra.Name = "txtBarkodNoAra";
            this.txtBarkodNoAra.Size = new System.Drawing.Size(576, 22);
            this.txtBarkodNoAra.TabIndex = 36;
            this.txtBarkodNoAra.TextChanged += new System.EventHandler(this.txtBarkodNoAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "BarkodNo ya Göre Ara";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboKategori
            // 
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Location = new System.Drawing.Point(488, 415);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(173, 24);
            this.comboKategori.TabIndex = 38;
            this.comboKategori.SelectedIndexChanged += new System.EventHandler(this.comboKategori_SelectedIndexChanged);
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(488, 460);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(173, 24);
            this.comboMarka.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Yazar";
            // 
            // btnMarkaGüncelle
            // 
            this.btnMarkaGüncelle.Location = new System.Drawing.Point(713, 423);
            this.btnMarkaGüncelle.Name = "btnMarkaGüncelle";
            this.btnMarkaGüncelle.Size = new System.Drawing.Size(138, 55);
            this.btnMarkaGüncelle.TabIndex = 14;
            this.btnMarkaGüncelle.Text = "Kategori ve Yazar Güncelle";
            this.btnMarkaGüncelle.UseVisualStyleBackColor = true;
            this.btnMarkaGüncelle.Click += new System.EventHandler(this.btnMarkaGüncelle_Click);
            // 
            // frmUrunListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1102, 501);
            this.Controls.Add(this.comboMarka);
            this.Controls.Add(this.comboKategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkodNoAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnMarkaGüncelle);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SatisFiyatTxt);
            this.Controls.Add(this.MiktarTxt);
            this.Controls.Add(this.AlisFiyatTxt);
            this.Controls.Add(this.BarkodNoTxt);
            this.Controls.Add(this.KategoriTxt);
            this.Controls.Add(this.UrunAdiTxt);
            this.Controls.Add(this.YazarTxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmUrunListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmUrunListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SatisFiyatTxt;
        private System.Windows.Forms.TextBox MiktarTxt;
        private System.Windows.Forms.TextBox AlisFiyatTxt;
        private System.Windows.Forms.TextBox BarkodNoTxt;
        private System.Windows.Forms.TextBox KategoriTxt;
        private System.Windows.Forms.TextBox UrunAdiTxt;
        private System.Windows.Forms.TextBox YazarTxt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtBarkodNoAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMarkaGüncelle;
    }
}