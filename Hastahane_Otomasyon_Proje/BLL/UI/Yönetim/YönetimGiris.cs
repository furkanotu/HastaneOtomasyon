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
    public partial class YönetimGiris : Form
    {
        public YönetimGiris()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GirisEkranı grs = new GirisEkranı();
            grs.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "ADMİN" || textBox1.Text == "admin") && (textBox2.Text == "12345"))
            {
                AdminEkran ekrn = new AdminEkran();
                ekrn.Show();
                this.Hide();
            }
            else
            {
                string cevap = "";
                

                using (BLL2 nesne = new BLL2())
                {
                    cevap = nesne.SifreKontrolYonetimDB(textBox1.Text, textBox2.Text).ToString();
                    if (cevap == "d")
                    {

                        YönetimYetki yetki = new YönetimYetki();
                        yetki.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen KUllanıcı Adı Veya Şifreyi Kontrol Ediniz");
                    }
                }

                
            }

        }
    }
}
