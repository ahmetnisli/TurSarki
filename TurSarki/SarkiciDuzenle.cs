using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurSarki
{
    public partial class SarkiciDuzenle : Form
    {
        public SarkiciDuzenle()
        {
            InitializeComponent();
        }
        string ConnectionString = "Server=.;Database=SarkiAlbumUygulama;Integrated Security=true";
        private void SarkiciDuzenle_Load(object sender, EventArgs e)
        {
            TurleriGetir();
        }

        private void TurleriGetir()
        {
            cmbTurler.Items.Clear();
            AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
            DataTable dt = ado.getProc("procTurGetir", new List<SqlParameter>());
            foreach (DataRow dr in dt.Rows)
            {
                Tur tur = new Tur();
                tur.TurID = (int)dr["TurID"];
                tur.TurAdi = dr["TurAdi"].ToString();
                tur.TurAciklama = dr["TurAciklama"].ToString();
                cmbTurler.Items.Add(tur);
            }
        }

        private void cmbTurler_SelectedIndexChanged(object sender, EventArgs e)
        {
            TurSarkicilariniGetir();
        }

        private void TurSarkicilariniGetir()
        {
            lstSarkicilar.Items.Clear();
            AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
            Tur tur = cmbTurler.SelectedItem as Tur;
            DataTable dt = ado.getProc("procSarkiciGetir", new SqlParameter("@TurID", tur.TurID));
            foreach (DataRow dr in dt.Rows)
            {
                Sarkici sarkici = new Sarkici();
                sarkici.SarkiciID = (int)dr["SarkiciID"];
                sarkici.SarkiciAdi = dr["SarkiciAdi"].ToString();
                sarkici.SarkiciSoyadi = dr["SarkiciSoyadi"].ToString();
                sarkici.SarkiciTurID = (int)dr["SarkiciTurID"];
                lstSarkicilar.Items.Add(sarkici);
            }
        }

        private void lstSarkicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSarkicilar.SelectedIndex > -1)
            {
                Sarkici srkc = lstSarkicilar.SelectedItem as Sarkici;
                txtSarkiciAdi.Text = srkc.SarkiciAdi;
                txtSarkiciSoyadi.Text = srkc.SarkiciSoyadi;
            }
        }

        private void btnSarkiciEkle_Click(object sender, EventArgs e)
        {
            AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
            Sarkici sarkici = lstSarkicilar.SelectedItem as Sarkici;
            ado.RunProc("procSarkiciEkle", new SqlParameter("@SarkiciAdi", txtSarkiciAdi.Text), new SqlParameter("@SarkiciSoyadi", txtSarkiciSoyadi.Text),new SqlParameter("@TurId",sarkici.SarkiciTurID));
            TurSarkicilariniGetir();
        }

        private void btnSarkiciSil_Click(object sender, EventArgs e)
        {
            AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
            Sarkici sarkici = lstSarkicilar.SelectedItem as Sarkici;
            ado.RunProc("procSarkiciSil", new SqlParameter("@SarkiciID", sarkici.SarkiciID));
            TurSarkicilariniGetir();
        }

        private void btnSarkiciGuncelle_Click(object sender, EventArgs e)
        {
            AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
            Sarkici sarkici = lstSarkicilar.SelectedItem as Sarkici;
            ado.RunProc("procSarkiciGuncelle", new SqlParameter("@SarkiciAdi", txtSarkiciAdi.Text), new SqlParameter("@SarkiciSoyadi", txtSarkiciSoyadi.Text), new SqlParameter("@TurId", sarkici.SarkiciTurID), new SqlParameter("@SarkiciID", sarkici.SarkiciID));
            TurSarkicilariniGetir();
        }
    }
}
