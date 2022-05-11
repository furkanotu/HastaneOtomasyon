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
    public partial class Hastatanı : Form
    {
        string id = "";
        public Hastatanı(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DoktorSecim s = new DoktorSecim(id);
            s.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GirisEkranı grs = new GirisEkranı();
            grs.Show();
            this.Hide();
        }
        private void Hastatanı_Load(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    dataGridView1.DataSource = nesne.DetayliHastaListele(int.Parse(id));
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.Columns[0].Visible = false;
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
                labelid.Text = row.Cells["HastaId"].Value.ToString();
                lblad.Text = row.Cells["HastaAd"].Value.ToString();
                lblsoyad.Text = row.Cells["HastaSoyad"].Value.ToString();
                lbltel.Text = row.Cells["HastaTelefon"].Value.ToString();
            }
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    MessageBox.Show(nesne.GuncelleHastaTanıDB(int.Parse(labelid.Text),textBox1.Text));
                }
            }
            catch (Exception)
            {

                throw;
            }
            Hastatanı_Load(this, null);
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    MessageBox.Show(nesne.GuncelleHastaTanıDB(int.Parse(labelid.Text), textBox1.Text));
                }
            }
            catch (Exception)
            {

                throw;
            }
            Hastatanı_Load(this, null);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            GirisEkranı grs = new GirisEkranı();
            grs.Show();
            this.Hide();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            DoktorDetaylıHasta hasta = new DoktorDetaylıHasta(id);
            hasta.Show();
            this.Hide();

        }
    }
}
