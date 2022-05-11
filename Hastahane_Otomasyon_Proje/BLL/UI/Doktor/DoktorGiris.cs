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
    public partial class DoktorGiris : Form
    {
        public DoktorGiris()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GirisEkranı grs = new GirisEkranı();
            grs.Show();
            this.Hide();
        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "";
                
                using (BLL2 nesne = new BLL2())
                {
                    id = nesne.DoktorIdAraDoktorDB(textBox1.Text, textBox2.Text);
                    string cevap = nesne.SifreKontrolDoktorDB(textBox1.Text, textBox2.Text).ToString();
                    if (cevap == "d")
                    {
                        DoktorSecim doktorsecim = new DoktorSecim(id);
                        doktorsecim.Show();
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
           
        }
    }
}
