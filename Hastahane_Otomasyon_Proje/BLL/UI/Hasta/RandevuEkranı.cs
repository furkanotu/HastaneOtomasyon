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
    public partial class KisiselBilgiler : Form
    {
        string id = "";
        public KisiselBilgiler(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void RandevuEkranı_Load(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    dataGridView1.DataSource=nesne.HastaBilgiListele(id);
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void saat7btn_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HastaGirisi htgris = new HastaGirisi();
            htgris.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HastaGirisiSecim scm = new HastaGirisiSecim(id);
            scm.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            GirisEkranı grs = new GirisEkranı();
            grs.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    MessageBox.Show(nesne.GuncelleHastaDB(int.Parse(id), textBox1.Text, textBox2.Text, maskedTextBox3.Text, textBox4.Text, textBox3.Text));
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
                textBox1.Text = row.Cells["HastaAd"].Value.ToString();
                textBox2.Text = row.Cells["HastaSoyad"].Value.ToString();
                maskedTextBox3.Text = row.Cells["HastaTelefon"].Value.ToString();
                textBox3.Text = row.Cells["HkullaniciAd"].Value.ToString();
                textBox4.Text = row.Cells["HastaSifre"].Value.ToString();
            }
        }
    }
}
