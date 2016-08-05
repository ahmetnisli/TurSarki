namespace TurSarki
{
    partial class TurDuzenle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTurAdı = new System.Windows.Forms.TextBox();
            this.txtTurAciklama = new System.Windows.Forms.TextBox();
            this.btnTurEkle = new System.Windows.Forms.Button();
            this.btnTurSil = new System.Windows.Forms.Button();
            this.btnTurGuncelle = new System.Windows.Forms.Button();
            this.cmbTurler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tur Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tur Açıklama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Türler :";
            // 
            // txtTurAdı
            // 
            this.txtTurAdı.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTurAdı.Location = new System.Drawing.Point(303, 31);
            this.txtTurAdı.Name = "txtTurAdı";
            this.txtTurAdı.Size = new System.Drawing.Size(181, 40);
            this.txtTurAdı.TabIndex = 4;
            // 
            // txtTurAciklama
            // 
            this.txtTurAciklama.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTurAciklama.Location = new System.Drawing.Point(303, 77);
            this.txtTurAciklama.Multiline = true;
            this.txtTurAciklama.Name = "txtTurAciklama";
            this.txtTurAciklama.Size = new System.Drawing.Size(181, 116);
            this.txtTurAciklama.TabIndex = 5;
            // 
            // btnTurEkle
            // 
            this.btnTurEkle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTurEkle.Location = new System.Drawing.Point(221, 210);
            this.btnTurEkle.Name = "btnTurEkle";
            this.btnTurEkle.Size = new System.Drawing.Size(75, 33);
            this.btnTurEkle.TabIndex = 6;
            this.btnTurEkle.Text = "Ekle";
            this.btnTurEkle.UseVisualStyleBackColor = true;
            this.btnTurEkle.Click += new System.EventHandler(this.btnTurEkle_Click);
            // 
            // btnTurSil
            // 
            this.btnTurSil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTurSil.Location = new System.Drawing.Point(303, 210);
            this.btnTurSil.Name = "btnTurSil";
            this.btnTurSil.Size = new System.Drawing.Size(75, 33);
            this.btnTurSil.TabIndex = 6;
            this.btnTurSil.Text = "Sil";
            this.btnTurSil.UseVisualStyleBackColor = true;
            this.btnTurSil.Click += new System.EventHandler(this.btnTurSil_Click);
            // 
            // btnTurGuncelle
            // 
            this.btnTurGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTurGuncelle.Location = new System.Drawing.Point(384, 210);
            this.btnTurGuncelle.Name = "btnTurGuncelle";
            this.btnTurGuncelle.Size = new System.Drawing.Size(100, 33);
            this.btnTurGuncelle.TabIndex = 6;
            this.btnTurGuncelle.Text = "Güncelle";
            this.btnTurGuncelle.UseVisualStyleBackColor = true;
            this.btnTurGuncelle.Click += new System.EventHandler(this.btnTurGuncelle_Click);
            // 
            // cmbTurler
            // 
            this.cmbTurler.BackColor = System.Drawing.Color.Snow;
            this.cmbTurler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurler.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTurler.FormattingEnabled = true;
            this.cmbTurler.Location = new System.Drawing.Point(12, 35);
            this.cmbTurler.Name = "cmbTurler";
            this.cmbTurler.Size = new System.Drawing.Size(164, 36);
            this.cmbTurler.TabIndex = 7;
            this.cmbTurler.SelectedIndexChanged += new System.EventHandler(this.cmbTurler_SelectedIndexChanged);
            // 
            // TurDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 281);
            this.Controls.Add(this.cmbTurler);
            this.Controls.Add(this.btnTurGuncelle);
            this.Controls.Add(this.btnTurSil);
            this.Controls.Add(this.btnTurEkle);
            this.Controls.Add(this.txtTurAciklama);
            this.Controls.Add(this.txtTurAdı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TurDuzenle";
            this.Text = "TurDuzenle";
            this.Load += new System.EventHandler(this.TurDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTurAdı;
        private System.Windows.Forms.TextBox txtTurAciklama;
        private System.Windows.Forms.Button btnTurEkle;
        private System.Windows.Forms.Button btnTurSil;
        private System.Windows.Forms.Button btnTurGuncelle;
        private System.Windows.Forms.ComboBox cmbTurler;
    }
}