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
    public partial class GirisEkranı : Form
    {
        public GirisEkranı()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            HastaGirisi hsta = new HastaGirisi();
            hsta.Show();
            this.Hide();
        }

        private void veznebtn_Click(object sender, EventArgs e)
        {
            VezneGiris vzngrs = new VezneGiris();
            vzngrs.Show();
            this.Hide();
        }

        private void YonetimBtn_Click(object sender, EventArgs e)
        {
            YönetimGiris yntm = new YönetimGiris();
            yntm.Show();
            this.Hide();
        }

        private void doktorbtn_Click(object sender, EventArgs e)
        {
            DoktorGiris dr = new DoktorGiris();
            dr.Show();
            this.Hide();
        }
    }
}
