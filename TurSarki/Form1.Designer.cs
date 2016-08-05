namespace TurSarki
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
            this.cmbTurler = new System.Windows.Forms.ComboBox();
            this.cmbSarkici = new System.Windows.Forms.ComboBox();
            this.cmbAlbum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSarkiAdi = new System.Windows.Forms.TextBox();
            this.txtSarkiSozu = new System.Windows.Forms.TextBox();
            this.txtSarkiBesteci = new System.Windows.Forms.TextBox();
            this.txtSarkiSozYazari = new System.Windows.Forms.TextBox();
            this.dtpSarkiCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnSarkiEkle = new System.Windows.Forms.Button();
            this.btnSarkiSil = new System.Windows.Forms.Button();
            this.btnSarkiGuncelle = new System.Windows.Forms.Button();
            this.btnTurDuzenle = new System.Windows.Forms.Button();
            this.btnSarkiciDuzenle = new System.Windows.Forms.Button();
            this.btnAlbumDuzenle = new System.Windows.Forms.Button();
            this.lstSarkilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbTurler
            // 
            this.cmbTurler.BackColor = System.Drawing.Color.Snow;
            this.cmbTurler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurler.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTurler.FormattingEnabled = true;
            this.cmbTurler.Location = new System.Drawing.Point(139, 30);
            this.cmbTurler.Name = "cmbTurler";
            this.cmbTurler.Size = new System.Drawing.Size(164, 36);
            this.cmbTurler.TabIndex = 0;
            this.cmbTurler.SelectedIndexChanged += new System.EventHandler(this.cmbTurler_SelectedIndexChanged);
            // 
            // cmbSarkici
            // 
            this.cmbSarkici.BackColor = System.Drawing.Color.Snow;
            this.cmbSarkici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSarkici.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSarkici.FormattingEnabled = true;
            this.cmbSarkici.Location = new System.Drawing.Point(139, 76);
            this.cmbSarkici.Name = "cmbSarkici";
            this.cmbSarkici.Size = new System.Drawing.Size(164, 36);
            this.cmbSarkici.TabIndex = 1;
            this.cmbSarkici.SelectedIndexChanged += new System.EventHandler(this.cmbSarkici_SelectedIndexChanged);
            // 
            // cmbAlbum
            // 
            this.cmbAlbum.BackColor = System.Drawing.Color.Snow;
            this.cmbAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlbum.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAlbum.FormattingEnabled = true;
            this.cmbAlbum.Location = new System.Drawing.Point(139, 119);
            this.cmbAlbum.Name = "cmbAlbum";
            this.cmbAlbum.Size = new System.Drawing.Size(164, 36);
            this.cmbAlbum.TabIndex = 2;
            this.cmbAlbum.SelectedIndexChanged += new System.EventHandler(this.cmbAlbum_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turler :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sarkici :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Albümler :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Şarkılar :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Şarkı Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Şarkı Sözleri :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Besteci :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Söz Yazarı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Çıkış Tarihi :";
            // 
            // txtSarkiAdi
            // 
            this.txtSarkiAdi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSarkiAdi.Location = new System.Drawing.Point(464, 42);
            this.txtSarkiAdi.Name = "txtSarkiAdi";
            this.txtSarkiAdi.Size = new System.Drawing.Size(200, 35);
            this.txtSarkiAdi.TabIndex = 7;
            // 
            // txtSarkiSozu
            // 
            this.txtSarkiSozu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSarkiSozu.Location = new System.Drawing.Point(463, 85);
            this.txtSarkiSozu.Multiline = true;
            this.txtSarkiSozu.Name = "txtSarkiSozu";
            this.txtSarkiSozu.Size = new System.Drawing.Size(200, 92);
            this.txtSarkiSozu.TabIndex = 7;
            // 
            // txtSarkiBesteci
            // 
            this.txtSarkiBesteci.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSarkiBesteci.Location = new System.Drawing.Point(464, 183);
            this.txtSarkiBesteci.Name = "txtSarkiBesteci";
            this.txtSarkiBesteci.Size = new System.Drawing.Size(200, 35);
            this.txtSarkiBesteci.TabIndex = 7;
            // 
            // txtSarkiSozYazari
            // 
            this.txtSarkiSozYazari.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSarkiSozYazari.Location = new System.Drawing.Point(463, 225);
            this.txtSarkiSozYazari.Name = "txtSarkiSozYazari";
            this.txtSarkiSozYazari.Size = new System.Drawing.Size(200, 35);
            this.txtSarkiSozYazari.TabIndex = 7;
            // 
            // dtpSarkiCikisTarihi
            // 
            this.dtpSarkiCikisTarihi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpSarkiCikisTarihi.Location = new System.Drawing.Point(463, 271);
            this.dtpSarkiCikisTarihi.Name = "dtpSarkiCikisTarihi";
            this.dtpSarkiCikisTarihi.Size = new System.Drawing.Size(200, 35);
            this.dtpSarkiCikisTarihi.TabIndex = 8;
            // 
            // btnSarkiEkle
            // 
            this.btnSarkiEkle.Location = new System.Drawing.Point(388, 335);
            this.btnSarkiEkle.Name = "btnSarkiEkle";
            this.btnSarkiEkle.Size = new System.Drawing.Size(91, 41);
            this.btnSarkiEkle.TabIndex = 9;
            this.btnSarkiEkle.Text = "Ekle";
            this.btnSarkiEkle.UseVisualStyleBackColor = true;
            this.btnSarkiEkle.Click += new System.EventHandler(this.btnSarkiEkle_Click);
            // 
            // btnSarkiSil
            // 
            this.btnSarkiSil.Location = new System.Drawing.Point(485, 335);
            this.btnSarkiSil.Name = "btnSarkiSil";
            this.btnSarkiSil.Size = new System.Drawing.Size(84, 41);
            this.btnSarkiSil.TabIndex = 9;
            this.btnSarkiSil.Text = "Sil";
            this.btnSarkiSil.UseVisualStyleBackColor = true;
            this.btnSarkiSil.Click += new System.EventHandler(this.btnSarkiSil_Click);
            // 
            // btnSarkiGuncelle
            // 
            this.btnSarkiGuncelle.Location = new System.Drawing.Point(575, 335);
            this.btnSarkiGuncelle.Name = "btnSarkiGuncelle";
            this.btnSarkiGuncelle.Size = new System.Drawing.Size(89, 41);
            this.btnSarkiGuncelle.TabIndex = 9;
            this.btnSarkiGuncelle.Text = "Guncelle";
            this.btnSarkiGuncelle.UseVisualStyleBackColor = true;
            this.btnSarkiGuncelle.Click += new System.EventHandler(this.btnSarkiGuncelle_Click);
            // 
            // btnTurDuzenle
            // 
            this.btnTurDuzenle.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTurDuzenle.Location = new System.Drawing.Point(309, 30);
            this.btnTurDuzenle.Name = "btnTurDuzenle";
            this.btnTurDuzenle.Size = new System.Drawing.Size(46, 36);
            this.btnTurDuzenle.TabIndex = 10;
            this.btnTurDuzenle.Text = "+";
            this.btnTurDuzenle.UseVisualStyleBackColor = true;
            this.btnTurDuzenle.Click += new System.EventHandler(this.btnTurDuzenle_Click);
            // 
            // btnSarkiciDuzenle
            // 
            this.btnSarkiciDuzenle.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSarkiciDuzenle.Location = new System.Drawing.Point(309, 76);
            this.btnSarkiciDuzenle.Name = "btnSarkiciDuzenle";
            this.btnSarkiciDuzenle.Size = new System.Drawing.Size(46, 36);
            this.btnSarkiciDuzenle.TabIndex = 10;
            this.btnSarkiciDuzenle.Text = "+";
            this.btnSarkiciDuzenle.UseVisualStyleBackColor = true;
            this.btnSarkiciDuzenle.Click += new System.EventHandler(this.btnSarkiciDuzenle_Click);
            // 
            // btnAlbumDuzenle
            // 
            this.btnAlbumDuzenle.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlbumDuzenle.Location = new System.Drawing.Point(309, 119);
            this.btnAlbumDuzenle.Name = "btnAlbumDuzenle";
            this.btnAlbumDuzenle.Size = new System.Drawing.Size(46, 36);
            this.btnAlbumDuzenle.TabIndex = 10;
            this.btnAlbumDuzenle.Text = "+";
            this.btnAlbumDuzenle.UseVisualStyleBackColor = true;
            this.btnAlbumDuzenle.Click += new System.EventHandler(this.btnAlbumDuzenle_Click);
            // 
            // lstSarkilar
            // 
            this.lstSarkilar.BackColor = System.Drawing.SystemColors.Menu;
            this.lstSarkilar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSarkilar.FormattingEnabled = true;
            this.lstSarkilar.ItemHeight = 28;
            this.lstSarkilar.Location = new System.Drawing.Point(139, 170);
            this.lstSarkilar.Name = "lstSarkilar";
            this.lstSarkilar.Size = new System.Drawing.Size(216, 228);
            this.lstSarkilar.TabIndex = 11;
            this.lstSarkilar.SelectedIndexChanged += new System.EventHandler(this.lstSarkilar_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(739, 434);
            this.Controls.Add(this.lstSarkilar);
            this.Controls.Add(this.btnAlbumDuzenle);
            this.Controls.Add(this.btnSarkiciDuzenle);
            this.Controls.Add(this.btnTurDuzenle);
            this.Controls.Add(this.btnSarkiGuncelle);
            this.Controls.Add(this.btnSarkiSil);
            this.Controls.Add(this.btnSarkiEkle);
            this.Controls.Add(this.dtpSarkiCikisTarihi);
            this.Controls.Add(this.txtSarkiSozu);
            this.Controls.Add(this.txtSarkiSozYazari);
            this.Controls.Add(this.txtSarkiBesteci);
            this.Controls.Add(this.txtSarkiAdi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAlbum);
            this.Controls.Add(this.cmbSarkici);
            this.Controls.Add(this.cmbTurler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTurler;
        private System.Windows.Forms.ComboBox cmbSarkici;
        private System.Windows.Forms.ComboBox cmbAlbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSarkiAdi;
        private System.Windows.Forms.TextBox txtSarkiSozu;
        private System.Windows.Forms.TextBox txtSarkiBesteci;
        private System.Windows.Forms.TextBox txtSarkiSozYazari;
        private System.Windows.Forms.DateTimePicker dtpSarkiCikisTarihi;
        private System.Windows.Forms.Button btnSarkiEkle;
        private System.Windows.Forms.Button btnSarkiSil;
        private System.Windows.Forms.Button btnSarkiGuncelle;
        private System.Windows.Forms.Button btnTurDuzenle;
        private System.Windows.Forms.Button btnSarkiciDuzenle;
        private System.Windows.Forms.Button btnAlbumDuzenle;
        private System.Windows.Forms.ListBox lstSarkilar;
    }
}

