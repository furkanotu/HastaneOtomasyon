using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class YönetimVezne : Form
    {
        public YönetimVezne()
        {
            InitializeComponent();
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    MessageBox.Show(nesne.KaydetVezneDB(adtxt.Text, soyadtxt.Text, sifretxt.Text, kulladtxt.Text));
                }
            }
            catch (Exception)
            {

                throw;
            }
            YönetimVezne_Load(this, null);
        }

        private void YönetimVezne_Load(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    dataGridView1.DataSource = nesne.VezneListele();
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    MessageBox.Show(nesne.GuncelleVezneDB(int.Parse(labelid.Text), adtxt.Text, soyadtxt.Text, sifretxt.Text, kulladtxt.Text));
                }
            }
            catch (Exception)
            {

                throw;
            }
            YönetimVezne_Load(this, null);
        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    dataGridView1.DataSource = nesne.AraVezneDB(adtxt.Text);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                adtxt.Text = row.Cells["CalisanAd"].Value.ToString();
                soyadtxt.Text = row.Cells["CalisanSoyad"].Value.ToString();
                kulladtxt.Text = row.Cells["CalisanKullaniciAd"].Value.ToString();
                sifretxt.Text = row.Cells["CalisanSifre"].Value.ToString();
                labelid.Text = row.Cells["CalisanId"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GirisEkranı grs = new GirisEkranı();
            grs.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            YönetimYetki yetki = new YönetimYetki();
            yetki.Show();
            this.Hide();
        }
    }
}
