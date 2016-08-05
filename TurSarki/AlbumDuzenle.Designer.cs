namespace TurSarki
{
    partial class AlbumDuzenle
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSarkici = new System.Windows.Forms.ComboBox();
            this.cmbTurler = new System.Windows.Forms.ComboBox();
            this.btnAlbumGuncelle = new System.Windows.Forms.Button();
            this.btnAlbumSil = new System.Windows.Forms.Button();
            this.btnAlbumEkle = new System.Windows.Forms.Button();
            this.txtAlbumAciklama = new System.Windows.Forms.TextBox();
            this.txtAlbumAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstAlbumler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Albümler :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sarkici :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Turler :";
            // 
            // cmbSarkici
            // 
            this.cmbSarkici.BackColor = System.Drawing.Color.Snow;
            this.cmbSarkici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSarkici.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSarkici.FormattingEnabled = true;
            this.cmbSarkici.Location = new System.Drawing.Point(122, 61);
            this.cmbSarkici.Name = "cmbSarkici";
            this.cmbSarkici.Size = new System.Drawing.Size(164, 36);
            this.cmbSarkici.TabIndex = 6;
            this.cmbSarkici.SelectedIndexChanged += new System.EventHandler(this.cmbSarkici_SelectedIndexChanged);
            // 
            // cmbTurler
            // 
            this.cmbTurler.BackColor = System.Drawing.Color.Snow;
            this.cmbTurler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurler.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTurler.FormattingEnabled = true;
            this.cmbTurler.Location = new System.Drawing.Point(122, 15);
            this.cmbTurler.Name = "cmbTurler";
            this.cmbTurler.Size = new System.Drawing.Size(164, 36);
            this.cmbTurler.TabIndex = 5;
            this.cmbTurler.SelectedIndexChanged += new System.EventHandler(this.cmbTurler_SelectedIndexChanged);
            // 
            // btnAlbumGuncelle
            // 
            this.btnAlbumGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlbumGuncelle.Location = new System.Drawing.Point(497, 213);
            this.btnAlbumGuncelle.Name = "btnAlbumGuncelle";
            this.btnAlbumGuncelle.Size = new System.Drawing.Size(100, 33);
            this.btnAlbumGuncelle.TabIndex = 12;
            this.btnAlbumGuncelle.Text = "Güncelle";
            this.btnAlbumGuncelle.UseVisualStyleBackColor = true;
            this.btnAlbumGuncelle.Click += new System.EventHandler(this.btnAlbumGuncelle_Click);
            // 
            // btnAlbumSil
            // 
            this.btnAlbumSil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlbumSil.Location = new System.Drawing.Point(416, 213);
            this.btnAlbumSil.Name = "btnAlbumSil";
            this.btnAlbumSil.Size = new System.Drawing.Size(75, 33);
            this.btnAlbumSil.TabIndex = 13;
            this.btnAlbumSil.Text = "Sil";
            this.btnAlbumSil.UseVisualStyleBackColor = true;
            this.btnAlbumSil.Click += new System.EventHandler(this.btnAlbumSil_Click);
            // 
            // btnAlbumEkle
            // 
            this.btnAlbumEkle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlbumEkle.Location = new System.Drawing.Point(335, 213);
            this.btnAlbumEkle.Name = "btnAlbumEkle";
            this.btnAlbumEkle.Size = new System.Drawing.Size(75, 33);
            this.btnAlbumEkle.TabIndex = 14;
            this.btnAlbumEkle.Text = "Ekle";
            this.btnAlbumEkle.UseVisualStyleBackColor = true;
            this.btnAlbumEkle.Click += new System.EventHandler(this.btnAlbumEkle_Click);
            // 
            // txtAlbumAciklama
            // 
            this.txtAlbumAciklama.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlbumAciklama.Location = new System.Drawing.Point(446, 61);
            this.txtAlbumAciklama.Multiline = true;
            this.txtAlbumAciklama.Name = "txtAlbumAciklama";
            this.txtAlbumAciklama.Size = new System.Drawing.Size(151, 135);
            this.txtAlbumAciklama.TabIndex = 17;
            // 
            // txtAlbumAdi
            // 
            this.txtAlbumAdi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlbumAdi.Location = new System.Drawing.Point(446, 23);
            this.txtAlbumAdi.Name = "txtAlbumAdi";
            this.txtAlbumAdi.Size = new System.Drawing.Size(151, 35);
            this.txtAlbumAdi.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Albüm Açıklama :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Albüm Adi :";
            // 
            // lstAlbumler
            // 
            this.lstAlbumler.BackColor = System.Drawing.SystemColors.Menu;
            this.lstAlbumler.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstAlbumler.FormattingEnabled = true;
            this.lstAlbumler.ItemHeight = 28;
            this.lstAlbumler.Location = new System.Drawing.Point(122, 112);
            this.lstAlbumler.Name = "lstAlbumler";
            this.lstAlbumler.Size = new System.Drawing.Size(164, 144);
            this.lstAlbumler.TabIndex = 19;
            this.lstAlbumler.SelectedIndexChanged += new System.EventHandler(this.lstAlbumler_SelectedIndexChanged_1);
            // 
            // AlbumDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(665, 272);
            this.Controls.Add(this.lstAlbumler);
            this.Controls.Add(this.txtAlbumAciklama);
            this.Controls.Add(this.txtAlbumAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAlbumGuncelle);
            this.Controls.Add(this.btnAlbumSil);
            this.Controls.Add(this.btnAlbumEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSarkici);
            this.Controls.Add(this.cmbTurler);
            this.Name = "AlbumDuzenle";
            this.Text = "AlbumDuzenle";
            this.Load += new System.EventHandler(this.AlbumDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSarkici;
        private System.Windows.Forms.ComboBox cmbTurler;
        private System.Windows.Forms.Button btnAlbumGuncelle;
        private System.Windows.Forms.Button btnAlbumSil;
        private System.Windows.Forms.Button btnAlbumEkle;
        private System.Windows.Forms.TextBox txtAlbumAciklama;
        private System.Windows.Forms.TextBox txtAlbumAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstAlbumler;
    }
}