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
    public partial class YönetimYetki : Form
    {
        public YönetimYetki()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YönetimDoktor doktor = new YönetimDoktor();
            doktor.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YönetimHastaBilgi hasta = new YönetimHastaBilgi();
            hasta.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YönetimVezne vezne = new YönetimVezne();
            vezne.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GirisEkranı grs = new GirisEkranı();
            grs.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            YönetimGiris giris = new YönetimGiris();
            giris.Show();
            this.Hide();
        }
    }
}
