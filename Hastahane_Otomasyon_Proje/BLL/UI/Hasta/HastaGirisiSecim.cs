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
    public partial class HastaGirisiSecim : Form
    {
        string id = "";
        public HastaGirisiSecim(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            HastaGirisi hst = new HastaGirisi();
            hst.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            GirisEkranı grs = new GirisEkranı();
            grs.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HastaTanıı hsttani = new HastaTanıı(id);
            hsttani.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            KisiselBilgiler ks = new KisiselBilgiler(id);
            ks.Show();
            this.Hide();

        }

        private void HastaGirisiSecim_Load(object sender, EventArgs e)
        {

        }
    }
}
