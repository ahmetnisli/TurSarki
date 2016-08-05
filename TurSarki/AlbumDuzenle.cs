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
    public partial class AlbumDuzenle : Form
    {
        public AlbumDuzenle()
        {
            InitializeComponent();
        }
        string ConnectionString = "Server=.;Database=SarkiAlbumUygulama;Integrated Security=true";
        
        private void AlbumDuzenle_Load(object sender, EventArgs e)
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
            cmbSarkici.Items.Clear();
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
                cmbSarkici.Items.Add(sarkici);
            }
            lstAlbumler.Items.Clear();
        }

        private void cmbSarkici_SelectedIndexChanged(object sender, EventArgs e)
        {
            SarkiciAlbumleriniGetir();
        }

        private void SarkiciAlbumleriniGetir()
        {
            lstAlbumler.Items.Clear();
            AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
            Sarkici sarkici = cmbSarkici.SelectedItem as Sarkici;
            DataTable dt = ado.getProc("procAlbumGetir", new SqlParameter("@SarkiciID", sarkici.SarkiciID));
            foreach (DataRow dr in dt.Rows)
            {
                Album album = new Album();
                album.AlbumID = (int)dr["AlbumID"];
                album.AlbumAdi = dr["AlbumAdi"].ToString();
                album.AlbumAciklama = dr["AlbumAciklama"].ToString();
                album.AlbumSarkiciID = (int)dr["AlbumSarkiciID"];
                lstAlbumler.Items.Add(album);

            }
           
        }

        private void lstAlbumler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAlbumler.SelectedIndex > -1)
            {
                Album album = lstAlbumler.SelectedItem as Album;
                txtAlbumAdi.Text = album.AlbumAdi;
                txtAlbumAciklama.Text = album.AlbumAciklama;
            }
        }

        private void btnAlbumEkle_Click(object sender, EventArgs e)
        {
            AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
            Album album = lstAlbumler.SelectedItem as Album;
            ado.RunProc("procAlbumEkle", new SqlParameter("@AlbumAdi", txtAlbumAdi.Text), new SqlParameter("@AlbumAciklama", txtAlbumAciklama.Text), new SqlParameter("@SarkiciID", album.AlbumSarkiciID));
            SarkiciAlbumleriniGetir();
        }

        private void btnAlbumSil_Click(object sender, EventArgs e)
        {
            AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
            Album album = lstAlbumler.SelectedItem as Album;
            ado.RunProc("procAlbumSil", new SqlParameter("@AlbumID",album.AlbumID));
            SarkiciAlbumleriniGetir();
        }

        private void btnAlbumGuncelle_Click(object sender, EventArgs e)
        {
            AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
            Album album = lstAlbumler.SelectedItem as Album;
            ado.RunProc("procAlbumGuncelle", new SqlParameter("@AlbumAdi", txtAlbumAdi.Text), new SqlParameter("@AlbumAciklama", txtAlbumAciklama.Text), new SqlParameter("@SarkiciID", album.AlbumSarkiciID), new SqlParameter("@AlbumID", album.AlbumID));
            SarkiciAlbumleriniGetir();
        }

        private void lstAlbumler_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstAlbumler.SelectedIndex > -1)
            {
                Album album = lstAlbumler.SelectedItem as Album;
                txtAlbumAdi.Text = album.AlbumAdi;
                txtAlbumAciklama.Text = album.AlbumAciklama;
            }
        }
    }
}
