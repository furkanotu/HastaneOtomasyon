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
    public partial class HastaGirisi : Form
    {
        public HastaGirisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cevap = "";
            string id = "";
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    id = nesne.HastaIdAra1DB(textBox1.Text, textBox2.Text);
                    cevap = nesne.SifreKontrolHastaDB(textBox1.Text, textBox2.Text).ToString();
                    if (cevap == "d")
                    {
                        HastaGirisiSecim hastasecim = new HastaGirisiSecim(id);
                        hastasecim.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen KUllanıcı Adı Veya Şifreyi Kontrol Ediniz");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
           
            #region Giris
            //HastaGirisiSecim src = new HastaGirisiSecim();
            //src.Show();
            //this.Hide();


            #endregion

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HastaKayit hstkayit = new HastaKayit();
            hstkayit.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
       
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GirisEkranı giris = new GirisEkranı();
            giris.Show();
            this.Hide();
        }
    }
}
