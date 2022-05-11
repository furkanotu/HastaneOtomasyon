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
    public partial class VezneGiris : Form
    {
        public VezneGiris()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GirisEkranı grsekrn = new GirisEkranı();
            grsekrn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)//Giriş kontrol ve randevu ekranına id gönderme
        {
            string cevap = "";
            string id = "";

            using (BLL2 nesne = new BLL2())
            {              
               cevap = nesne.SifreKontroVezneDB(textBox1.Text, textBox2.Text).ToString();
                if (cevap=="d")
                {
                    id = nesne.VezneIdAraDB(textBox1.Text, textBox2.Text);
                    RandevuAlmacs rnd = new RandevuAlmacs(id);
                    rnd.Show();
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
