namespace TurSarki
{
    partial class SarkiciDuzenle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTurler = new System.Windows.Forms.ComboBox();
            this.lstSarkicilar = new System.Windows.Forms.ListBox();
            this.btnSarkiciGuncelle = new System.Windows.Forms.Button();
            this.btnSarkiciSil = new System.Windows.Forms.Button();
            this.btnSarkiciEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSarkiciAdi = new System.Windows.Forms.TextBox();
            this.txtSarkiciSoyadi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sarkici :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Turler :";
            // 
            // cmbTurler
            // 
            this.cmbTurler.BackColor = System.Drawing.Color.Snow;
            this.cmbTurler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurler.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTurler.FormattingEnabled = true;
            this.cmbTurler.Location = new System.Drawing.Point(119, 23);
            this.cmbTurler.Name = "cmbTurler";
            this.cmbTurler.Size = new System.Drawing.Size(164, 36);
            this.cmbTurler.TabIndex = 4;
            this.cmbTurler.SelectedIndexChanged += new System.EventHandler(this.cmbTurler_SelectedIndexChanged);
            // 
            // lstSarkicilar
            // 
            this.lstSarkicilar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lstSarkicilar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSarkicilar.FormattingEnabled = true;
            this.lstSarkicilar.ItemHeight = 28;
            this.lstSarkicilar.Location = new System.Drawing.Point(119, 81);
            this.lstSarkicilar.Name = "lstSarkicilar";
            this.lstSarkicilar.Size = new System.Drawing.Size(164, 144);
            this.lstSarkicilar.TabIndex = 8;
            this.lstSarkicilar.SelectedIndexChanged += new System.EventHandler(this.lstSarkicilar_SelectedIndexChanged);
            // 
            // btnSarkiciGuncelle
            // 
            this.btnSarkiciGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSarkiciGuncelle.Location = new System.Drawing.Point(469, 192);
            this.btnSarkiciGuncelle.Name = "btnSarkiciGuncelle";
            this.btnSarkiciGuncelle.Size = new System.Drawing.Size(100, 33);
            this.btnSarkiciGuncelle.TabIndex = 9;
            this.btnSarkiciGuncelle.Text = "Güncelle";
            this.btnSarkiciGuncelle.UseVisualStyleBackColor = true;
            this.btnSarkiciGuncelle.Click += new System.EventHandler(this.btnSarkiciGuncelle_Click);
            // 
            // btnSarkiciSil
            // 
            this.btnSarkiciSil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSarkiciSil.Location = new System.Drawing.Point(388, 192);
            this.btnSarkiciSil.Name = "btnSarkiciSil";
            this.btnSarkiciSil.Size = new System.Drawing.Size(75, 33);
            this.btnSarkiciSil.TabIndex = 10;
            this.btnSarkiciSil.Text = "Sil";
            this.btnSarkiciSil.UseVisualStyleBackColor = true;
            this.btnSarkiciSil.Click += new System.EventHandler(this.btnSarkiciSil_Click);
            // 
            // btnSarkiciEkle
            // 
            this.btnSarkiciEkle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSarkiciEkle.Location = new System.Drawing.Point(306, 192);
            this.btnSarkiciEkle.Name = "btnSarkiciEkle";
            this.btnSarkiciEkle.Size = new System.Drawing.Size(75, 33);
            this.btnSarkiciEkle.TabIndex = 11;
            this.btnSarkiciEkle.Text = "Ekle";
            this.btnSarkiciEkle.UseVisualStyleBackColor = true;
            this.btnSarkiciEkle.Click += new System.EventHandler(this.btnSarkiciEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Şarkıcı Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Şarkıcı Soyadı :";
            // 
            // txtSarkiciAdi
            // 
            this.txtSarkiciAdi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSarkiciAdi.Location = new System.Drawing.Point(418, 93);
            this.txtSarkiciAdi.Name = "txtSarkiciAdi";
            this.txtSarkiciAdi.Size = new System.Drawing.Size(151, 35);
            this.txtSarkiciAdi.TabIndex = 13;
            // 
            // txtSarkiciSoyadi
            // 
            this.txtSarkiciSoyadi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSarkiciSoyadi.Location = new System.Drawing.Point(418, 131);
            this.txtSarkiciSoyadi.Name = "txtSarkiciSoyadi";
            this.txtSarkiciSoyadi.Size = new System.Drawing.Size(151, 35);
            this.txtSarkiciSoyadi.TabIndex = 13;
            // 
            // SarkiciDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 232);
            this.Controls.Add(this.txtSarkiciSoyadi);
            this.Controls.Add(this.txtSarkiciAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSarkiciGuncelle);
            this.Controls.Add(this.btnSarkiciSil);
            this.Controls.Add(this.btnSarkiciEkle);
            this.Controls.Add(this.lstSarkicilar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTurler);
            this.Name = "SarkiciDuzenle";
            this.Text = "SarkiciDuzenle";
            this.Load += new System.EventHandler(this.SarkiciDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTurler;
        private System.Windows.Forms.ListBox lstSarkicilar;
        private System.Windows.Forms.Button btnSarkiciGuncelle;
        private System.Windows.Forms.Button btnSarkiciSil;
        private System.Windows.Forms.Button btnSarkiciEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSarkiciAdi;
        private System.Windows.Forms.TextBox txtSarkiciSoyadi;
    }
}