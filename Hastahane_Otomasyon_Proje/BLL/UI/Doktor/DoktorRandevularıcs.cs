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
    public partial class DoktorRandevularıcs : Form
    {
        string id = "";
        string saat = "";
        public DoktorRandevularıcs(string id)
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

        private void DoktorRandevularıcs_Load(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            saat = "07:00";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            saat = "08:00";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            saat = "09:00";
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            saat = "10:00";
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            saat = "11:00";
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            saat = "12:00";
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            saat = "14:00";
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            saat = "15:00";
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            saat = "16:00";
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            saat = "17:00";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    List<string> liste = new List<string>();
                    liste = nesne.DoktorRandevuSaatDB(id, dateTimePicker1.Text);
                    if (liste.Contains("07:00"))
                    {
                        btn7.Enabled = false;
                        btn7.BackColor = Color.Red;
                    }
                    else
                    {
                        btn7.BackColor = Color.Blue;
                    }
                    if (liste.Contains("08:00"))
                    {
                        btn8.Enabled = false;
                        btn8.BackColor = Color.Red;
                    }
                    else
                    {
                        btn8.BackColor = Color.Blue;
                    }
                    if (liste.Contains("09:00"))
                    {
                        button9.Enabled = false;
                        button9.BackColor = Color.Red;
                    }
                    else
                    {
                        button9.BackColor = Color.Blue;
                    }
                    if (liste.Contains("10:00"))
                    {
                        btn10.Enabled = false;
                        btn10.BackColor = Color.Red;
                    }
                    else
                    {
                        btn10.BackColor = Color.Blue;
                    }
                    if (liste.Contains("11:00"))
                    {
                        btn11.Enabled = false;
                        btn11.BackColor = Color.Red;
                    }
                    else
                    {
                        btn11.BackColor = Color.Blue;
                    }
                    if (liste.Contains("12:00"))
                    {
                        btn12.Enabled = false;
                        btn12.BackColor = Color.Red;
                    }
                    else
                    {
                        btn12.BackColor = Color.Blue;
                    }
                    if (liste.Contains("14:00"))
                    {
                        btn14.Enabled = false;
                        btn14.BackColor = Color.Red;
                    }
                    else
                    {
                        btn14.BackColor = Color.Blue;
                    }
                    if (liste.Contains("15:00"))
                    {
                        btn15.Enabled = false;
                        btn15.BackColor = Color.Red;
                    }
                    else
                    {
                        btn15.BackColor = Color.Blue;
                    }
                    if (liste.Contains("16:00"))
                    {
                        btn16.Enabled = false;
                        btn16.BackColor = Color.Red;
                    }
                    else
                    {
                        btn16.BackColor = Color.Blue;
                    }
                    if (liste.Contains("17:00"))
                    {
                        btn17.Enabled = false;
                        btn17.BackColor = Color.Red;
                    }
                    else
                    {
                        btn17.BackColor = Color.Blue;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
