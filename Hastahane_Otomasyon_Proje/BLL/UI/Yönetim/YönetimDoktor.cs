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
    public partial class YönetimDoktor : Form
    {
        public YönetimDoktor()
        {
            InitializeComponent();
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using(BLL2 nesne = new BLL2())
                {
                    MessageBox.Show(nesne.KaydetDoktorDB(adtxt.Text,soyadtxt.Text,telmsk.Text,branscmb.Text,sifretxt.Text,kulladtxt.Text));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            YönetimDoktor_Load(this, null);
        }

        private void YönetimDoktor_Load(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    dataGridView1.DataSource = nesne.DoktorListele();
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                labelid.Text = row.Cells["Doktorid"].Value.ToString();
                adtxt.Text = row.Cells["DoktorAd"].Value.ToString();
                soyadtxt.Text = row.Cells["DoktorSoyad"].Value.ToString();
                branscmb.Text = row.Cells["DoktorBrans"].Value.ToString();
                telmsk.Text = row.Cells["DoktorTel"].Value.ToString();
                sifretxt.Text = row.Cells["DoktorSifre"].Value.ToString();
                kulladtxt.Text = row.Cells["KullaniciAd"].Value.ToString();

            }
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    MessageBox.Show(nesne.GuncelleDoktorDB(int.Parse(labelid.Text), adtxt.Text, soyadtxt.Text, telmsk.Text, branscmb.Text, sifretxt.Text, kulladtxt.Text));
                }
            }
            catch (Exception)
            {

                throw;
            }
            YönetimDoktor_Load(this, null);
        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    dataGridView1.DataSource=nesne.AraDoktorDB(adtxt.Text);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception)
            {

                throw;
            }
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
