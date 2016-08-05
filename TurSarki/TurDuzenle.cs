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
    public partial class TurDuzenle : Form
    {
        string ConnectionString = "Server=.;Database=SarkiAlbumUygulama;Integrated Security=true";
        public TurDuzenle()
        {
            InitializeComponent();
        }

        private void TurDuzenle_Load(object sender, EventArgs e)
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

        private void btnTurEkle_Click(object sender, EventArgs e)
        {
            AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
            ado.RunProc("procTurEkle", new SqlParameter("@TurAdi", txtTurAdı.Text), new SqlParameter("@TurAciklama", txtTurAciklama.Text));
            TurleriGetir();
            cmbTurler.SelectedIndex = cmbTurler.Items.Count-1;
        }

        private void btnTurSil_Click(object sender, EventArgs e)
        {
            AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
            Tur tur = cmbTurler.SelectedItem as Tur;
            ado.RunProc("procTurSil", new SqlParameter("@TurID", tur.TurID));
            TurleriGetir();
            cmbTurler.SelectedIndex = 0;
        }

        private void btnTurGuncelle_Click(object sender, EventArgs e)
        {
            AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
            Tur tur = cmbTurler.SelectedItem as Tur;
            int index = cmbTurler.SelectedIndex;
            ado.RunProc("procTurGuncelle", new SqlParameter("@TurAdi", txtTurAdı.Text), new SqlParameter("@TurAciklama", txtTurAciklama.Text), new SqlParameter("@TurID", tur.TurID));
            TurleriGetir();
            cmbTurler.SelectedIndex = index;
        }

        private void cmbTurler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTurler.SelectedIndex > -1)
            {
                Tur tur = cmbTurler.SelectedItem as Tur;
                txtTurAdı.Text = tur.TurAdi;
                txtTurAciklama.Text = tur.TurAciklama;
            }
        }
    }
}
