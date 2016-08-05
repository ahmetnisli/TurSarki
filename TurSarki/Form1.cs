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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
      string ConnectionString = "Server=.;Database=SarkiAlbumUygulama;Integrated Security=true";
        private void Form1_Load(object sender, EventArgs e)
        {
            TurleriGetir();

        }
        
        public void TurleriGetir()
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

        public void TurSarkicilariniGetir()
        {
            cmbSarkici.Items.Clear();
            AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
            Tur tur = (Tur)cmbTurler.SelectedItem;
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
            cmbAlbum.Items.Clear();
            lstSarkilar.Items.Clear();
        }

        private void cmbSarkici_SelectedIndexChanged(object sender, EventArgs e)
        {

            SarkiciAlbumleriGetir();
            
        }

        public void SarkiciAlbumleriGetir()
        {
            cmbAlbum.Items.Clear();
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
                cmbAlbum.Items.Add(album);

            }
            
                lstSarkilar.Items.Clear();
        }
        
        private void cmbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlbumSarkilariGetir();
           
        }

        public void AlbumSarkilariGetir()
        {
            lstSarkilar.Items.Clear();
            AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
            Album album = cmbAlbum.SelectedItem as Album;
            DataTable dt = ado.getProc("procSarkiGetir", new SqlParameter("@AlbumID", album.AlbumID));
            foreach (DataRow dr in dt.Rows)
            {
                Sarki sarki = new Sarki();
                sarki.SarkiID = (int)dr["SarkiID"];
                sarki.SarkiAdi = dr["SarkiAdi"].ToString();
                sarki.SarkiSozleri = dr["SarkiSozleri"].ToString();
                sarki.Besteci = dr["Besteci"].ToString();
                sarki.SozYazari = dr["SozYazari"].ToString();
                sarki.AlbumID = (int)dr["AlbumID"];
                sarki.CikisTarihi = (DateTime)dr["CikisTarihi"];
                lstSarkilar.Items.Add(sarki);
            }
            
        }

      

        private void btnSarkiEkle_Click(object sender, EventArgs e)
        {
            AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
            Sarki sarki = lstSarkilar.SelectedItem as Sarki;
            ado.RunProc("procSarkiEkle", new SqlParameter("@SarkiSozleri", txtSarkiSozu.Text), new SqlParameter("@SarkiAdi", txtSarkiAdi.Text), new SqlParameter("@Besteci", txtSarkiBesteci.Text), new SqlParameter("@SozYazari", txtSarkiSozYazari.Text), new SqlParameter("@AlbumID", sarki.AlbumID), new SqlParameter("@Cikis", dtpSarkiCikisTarihi.Value));
            AlbumSarkilariGetir();
          
        }

        private void btnSarkiSil_Click(object sender, EventArgs e)
        {
            AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
            Album album = cmbAlbum.SelectedItem as Album;
            Sarki sarki = lstSarkilar.SelectedItem as Sarki;
            ado.RunProc("procSarkiSil", new SqlParameter("@SarkiID", sarki.SarkiID));
            AlbumSarkilariGetir();
            
        }

        private void btnSarkiGuncelle_Click(object sender, EventArgs e)
        { 
            AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
            Sarki sarki = lstSarkilar.SelectedItem as Sarki;
            ado.RunProc("procSarkiGuncelle", new SqlParameter("@SarkiSozleri", txtSarkiSozu.Text), new SqlParameter("@SarkiAdi", txtSarkiAdi.Text), new SqlParameter("@Besteci", txtSarkiBesteci.Text), new SqlParameter("@SozYazari", txtSarkiSozYazari.Text), new SqlParameter("@AlbumID", sarki.AlbumID), new SqlParameter("@Cikis", dtpSarkiCikisTarihi.Value), new SqlParameter("@SarkiID", sarki.SarkiID));
            AlbumSarkilariGetir();
            
        }

        private void btnTurDuzenle_Click(object sender, EventArgs e)
        {
            TurDuzenle tur = new TurDuzenle();
            int index = cmbTurler.SelectedIndex;
            tur.ShowDialog();
            TurleriGetir();
            cmbTurler.SelectedIndex = index;
        }

        private void btnSarkiciDuzenle_Click(object sender, EventArgs e)
        {
            SarkiciDuzenle srk = new SarkiciDuzenle();
            srk.ShowDialog();
            TurSarkicilariniGetir();
        }

        private void btnAlbumDuzenle_Click(object sender, EventArgs e)
        {
            AlbumDuzenle albm = new AlbumDuzenle();
            albm.ShowDialog();
            SarkiciAlbumleriGetir();

        }


        private void lstSarkilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSarkilar.SelectedIndex > -1)
            {
                Sarki sarki = lstSarkilar.SelectedItem as Sarki;
                txtSarkiAdi.Text = sarki.SarkiAdi;
                txtSarkiBesteci.Text = sarki.Besteci;
                txtSarkiSozu.Text = sarki.SarkiSozleri;
                txtSarkiSozYazari.Text = sarki.SozYazari;
                dtpSarkiCikisTarihi.Value = sarki.CikisTarihi;
            }
        }
    }
}
