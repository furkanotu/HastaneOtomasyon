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
    public partial class AdminSekreter : Form
    {
        public AdminSekreter()
        {
            InitializeComponent();
        }

      

        private void eklebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using(BLL2 nesne = new BLL2())
                {
                    MessageBox.Show(nesne.KaydetVezneDB(adtxt.Text, soyadtxt.Text, sifretxt.Text, kulladtxt.Text));
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

        }

        private void AdminSekreter_Load(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    dataGridView1.DataSource = nesne.VezneListele();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    MessageBox.Show(nesne.GuncelleVezneDB(int.Parse(labelid.Text), (("AAAA")+adtxt.Text), soyadtxt.Text, sifretxt.Text, kulladtxt.Text));
                }
            }
            catch (Exception)
            {

                throw;
            }
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
