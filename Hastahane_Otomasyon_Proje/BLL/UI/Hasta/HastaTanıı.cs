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
    public partial class HastaTanıı : Form
    {
        string id = "";
        public HastaTanıı(string id)
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            HastaGirisiSecim scm = new HastaGirisiSecim(id);
            scm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GirisEkranı grs = new GirisEkranı();
            grs.Show();
            this.Hide();
        }

        private void HastaTanıı_Load(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    dataGridView1.DataSource = nesne.HastaTanıListele(id);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
