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
    public partial class AdminYönetim : Form
    {
        public AdminYönetim()
        {
            InitializeComponent();
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    MessageBox.Show(nesne.KaydetYonetimDB(adtxt.Text, soyadtxt.Text, telmsk.Text,(mailtxt.Text+mailcmb.Text),sifretxt.Text, kulladtxt.Text));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            AdminYönetim_Load(this, null);
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    MessageBox.Show(nesne.GuncelleYonetimDB(int.Parse(label6.Text), (("AAAA") + adtxt.Text), soyadtxt.Text, telmsk.Text, (mailtxt.Text+mailcmb.Text), sifretxt.Text, kulladtxt.Text));
                    AdminYönetim_Load(this, null);

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
                    MessageBox.Show(nesne.GuncelleYonetimDB(int.Parse(label6.Text), adtxt.Text, soyadtxt.Text, telmsk.Text, (mailtxt.Text + mailcmb.Text), sifretxt.Text, kulladtxt.Text));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            AdminYönetim_Load(this, null);
        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    dataGridView1.DataSource = nesne.AraYonetimDB(adtxt.Text);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AdminYönetim_Load(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    dataGridView1.DataSource = nesne.YönetimListele();
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
                label6.Text = row.Cells["YonetimId"].Value.ToString();
                adtxt.Text = row.Cells["YonetimAd"].Value.ToString();
                soyadtxt.Text = row.Cells["YonetimSoyad"].Value.ToString();
                telmsk.Text = row.Cells["YonetimTel"].Value.ToString();
                label8.Text = row.Cells["YonetimMail"].Value.ToString();
                if (label8.Text == null || label8.Text == "")
                {
                    label8.Text = "example@gmail.com";
                }
                string[] mail = (label8.Text).Split('@');
                mailtxt.Text = mail[0].ToString();
                mailcmb.Text = "@"+mail[1].ToString();
                sifretxt.Text = row.Cells["YonetimSifre"].Value.ToString();
                kulladtxt.Text = row.Cells["YonetimKullaniciAd"].Value.ToString();
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
            AdminEkran admin = new AdminEkran();
            admin.Show();
            this.Hide();
        }
    }
}
