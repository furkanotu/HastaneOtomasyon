using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class DoktorSecim : Form
    {
        string id = "";
        public DoktorSecim(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DoktorRandevularıcs rnd = new DoktorRandevularıcs(id);
            rnd.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DoktorDetaylıHasta hst = new DoktorDetaylıHasta(id);
            hst.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DoktorGiris grs = new DoktorGiris();
            grs.Show();
            this.Hide();
        }

        private void DoktorSecim_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GirisEkranı grs = new GirisEkranı();
            grs.Show();
            this.Hide();
        }
    }
}
