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
    public partial class DoktorDetaylıHasta : Form
    {
        string id = "";
        public DoktorDetaylıHasta(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void DoktorDetaylıHasta_Load(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    dataGridView1.DataSource = nesne.DetayliHastaListele(int.Parse(id));
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Hastatanı hasta = new Hastatanı(id);
            hasta.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GirisEkranı grs = new GirisEkranı();
            grs.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DoktorSecim secim = new DoktorSecim(id);
            secim.Show();
            this.Hide();
        }
    }
}
