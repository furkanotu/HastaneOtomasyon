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
    public partial class RandevuAlmacs : Form
    {
        
        public RandevuAlmacs(string id)
        {
            InitializeComponent();
            this.vezneid = id;
        }
        string vezneid = "";
        string doktorad = "";
        string doktorsoyad = "";
        string doktorid = "";
        string hastaid = "";
        string saat = "";
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            VezneGiris grs = new VezneGiris();
            grs.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GirisEkranı grs = new GirisEkranı();
            grs.Show();
            this.Hide();
        }

        private void RandevuAlmacs_Load(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    List<string> liste = new List<string>();
                    liste = nesne.Doktorsecim();
                    foreach(string item in liste)
                    {
                        doktorcmb.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void doktorcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] adsoyad = (doktorcmb.Text).Split(' ');
            doktorad = adsoyad[0];
            doktorsoyad = adsoyad[1];
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    doktorid = nesne.DoktorIdAraDB(doktorad, doktorsoyad);
                    List<string> liste = new List<string>();
                    liste = nesne.DoktorRandevuSaatDB(doktorid,dateTimePicker1.Text);
                    if (liste.Contains("07:00"))
                    {
                        saat7btn.Enabled = false;
                        saat7btn.BackColor = Color.Red;
                    }
                    else
                    {
                        saat7btn.BackColor = Color.Blue;
                    }
                    if (liste.Contains("08:00"))
                    {
                        saat8btn.Enabled = false;
                        saat8btn.BackColor = Color.Red;
                    }
                    else
                    {
                        saat8btn.BackColor = Color.Blue;
                    }
                    if (liste.Contains("09:00"))
                    {
                        saat9btn.Enabled = false;
                        saat9btn.BackColor = Color.Red;
                    }
                    else
                    {
                        saat9btn.BackColor = Color.Blue;
                    }
                    if (liste.Contains("10:00"))
                    {
                        saat10btn.Enabled = false;
                        saat10btn.BackColor = Color.Red;
                    }
                    else
                    {
                        saat10btn.BackColor = Color.Blue;
                    }
                    if (liste.Contains("11:00"))
                    {
                        saat11btn.Enabled = false;
                        saat11btn.BackColor = Color.Red;
                    }
                    else
                    {
                        saat11btn.BackColor = Color.Blue;
                    }
                    if (liste.Contains("12:00"))
                    {
                        saat12btn.Enabled = false;
                        saat12btn.BackColor = Color.Red;
                    }
                    else
                    {
                        saat12btn.BackColor = Color.Blue;
                    }
                    if (liste.Contains("14:00"))
                    {
                        saat14btn.Enabled = false;
                        saat14btn.BackColor = Color.Red;
                    }
                    else
                    {
                        saat14btn.BackColor = Color.Blue;
                    }
                    if (liste.Contains("15:00"))
                    {
                        saat15btn.Enabled = false;
                        saat15btn.BackColor = Color.Red;
                    }
                    else
                    {
                        saat15btn.BackColor = Color.Blue;
                    }
                    if (liste.Contains("16:00"))
                    {
                        saat16btn.Enabled = false;
                        saat16btn.BackColor = Color.Red;
                    }
                    else
                    {
                        saat16btn.BackColor = Color.Blue;
                    }
                    if (liste.Contains("17:00"))
                    {
                        onyedibtn.Enabled = false;
                        onyedibtn.BackColor = Color.Red;
                    }
                    else
                    {
                        onyedibtn.BackColor = Color.Blue;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaKayit hasta = new HastaKayit();
            hasta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    hastaid = nesne.HastaIdAraDB(textBox1.Text, textBox2.Text, maskedTextBox3.Text);
                    if (hastaid != "")
                    {
                        doktorid = nesne.DoktorIdAraDB(doktorad, doktorsoyad);
                        if (doktorid != "")
                        {
                            MessageBox.Show(nesne.KaydetRandevuDB(dateTimePicker1.Text, doktorid, hastaid, vezneid, saat));
                            List<string> liste = new List<string>();
                            liste = nesne.DoktorRandevuSaatDB(doktorid, dateTimePicker1.Text);
                            if (liste.Contains("07:00"))
                            {
                                saat7btn.Enabled = false;
                                saat7btn.BackColor = Color.Red;
                            }
                            else
                            {
                                saat7btn.BackColor = Color.Blue;
                            }
                            if (liste.Contains("08:00"))
                            {
                                saat8btn.Enabled = false;
                                saat8btn.BackColor = Color.Red;
                            }
                            else
                            {
                                saat8btn.BackColor = Color.Blue;
                            }
                            if (liste.Contains("09:00"))
                            {
                                saat9btn.Enabled = false;
                                saat9btn.BackColor = Color.Red;
                            }
                            else
                            {
                                saat9btn.BackColor = Color.Blue;
                            }
                            if (liste.Contains("10:00"))
                            {
                                saat10btn.Enabled = false;
                                saat10btn.BackColor = Color.Red;
                            }
                            else
                            {
                                saat10btn.BackColor = Color.Blue;
                            }
                            if (liste.Contains("11:00"))
                            {
                                saat11btn.Enabled = false;
                                saat11btn.BackColor = Color.Red;
                            }
                            else
                            {
                                saat11btn.BackColor = Color.Blue;
                            }
                            if (liste.Contains("12:00"))
                            {
                                saat12btn.Enabled = false;
                                saat12btn.BackColor = Color.Red;
                            }
                            else
                            {
                                saat12btn.BackColor = Color.Blue;
                            }
                            if (liste.Contains("14:00"))
                            {
                                saat14btn.Enabled = false;
                                saat14btn.BackColor = Color.Red;
                            }
                            else
                            {
                                saat14btn.BackColor = Color.Blue;
                            }
                            if (liste.Contains("15:00"))
                            {
                                saat15btn.Enabled = false;
                                saat15btn.BackColor = Color.Red;
                            }
                            else
                            {
                                saat15btn.BackColor = Color.Blue;
                            }
                            if (liste.Contains("16:00"))
                            {
                                saat16btn.Enabled = false;
                                saat16btn.BackColor = Color.Red;
                            }
                            else
                            {
                                saat16btn.BackColor = Color.Blue;
                            }
                            if (liste.Contains("17:00"))
                            {
                                onyedibtn.Enabled = false;
                                onyedibtn.BackColor = Color.Red;
                            }
                            else
                            {
                                onyedibtn.BackColor = Color.Blue;
                            }

                        }
                    }
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show("Böyle Bir Kayıt Bulunamadı");
            }
        }//Hasta Kayıtlı mı kontrol kayıtlıysa id alma

        private void saat7btn_Click(object sender, EventArgs e)
        {
            saat = "07:00";
        }

        private void saat8btn_Click(object sender, EventArgs e)
        {
            saat = "08:00";
        }

        private void saat9btn_Click(object sender, EventArgs e)
        {
            saat = "09:00";
        }

        private void saat10btn_Click(object sender, EventArgs e)
        {
            saat = "10:00";
        }

        private void saat11btn_Click(object sender, EventArgs e)
        {
            saat = "11:00";
        }

        private void saat12btn_Click(object sender, EventArgs e)
        {
            saat = "12:00";
        }

        private void saat14btn_Click(object sender, EventArgs e)
        {
            saat = "14:00";
        }

        private void saat15btn_Click(object sender, EventArgs e)
        {
            saat = "15:00";
        }

        private void saat16btn_Click(object sender, EventArgs e)
        {
            saat = "16:00";
        }

        private void onyedibtn_Click(object sender, EventArgs e)
        {
            saat = "17:00";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (BLL2 nesne = new BLL2())
                {
                    doktorid = nesne.DoktorIdAraDB(doktorad, doktorsoyad);
                    List<string> liste = new List<string>();
                    liste = nesne.DoktorRandevuSaatDB(doktorid, dateTimePicker1.Text);
                    if (liste.Contains("07:00"))
                    {
                        saat7btn.Enabled = false;
                        saat7btn.BackColor = Color.Red;
                    }
                    else
                    {
                        saat7btn.BackColor = Color.Blue;
                    }
                    if (liste.Contains("08:00"))
                    {
                        saat8btn.Enabled = false;
                        saat8btn.BackColor = Color.Red;
                    }
                    else
                    {
                        saat8btn.BackColor = Color.Blue;
                    }
                    if (liste.Contains("09:00"))
                    {
                        saat9btn.Enabled = false;
                        saat9btn.BackColor = Color.Red;
                    }
                    else
                    {
                        saat9btn.BackColor = Color.Blue;
                    }
                    if (liste.Contains("10:00"))
                    {
                        saat10btn.Enabled = false;
                        saat10btn.BackColor = Color.Red;
                    }
                    else
                    {
                        saat10btn.BackColor = Color.Blue;
                    }
                    if (liste.Contains("11:00"))
                    {
                        saat11btn.Enabled = false;
                        saat11btn.BackColor = Color.Red;
                    }
                    else
                    {
                        saat11btn.BackColor = Color.Blue;
                    }
                    if (liste.Contains("12:00"))
                    {
                        saat12btn.Enabled = false;
                        saat12btn.BackColor = Color.Red;
                    }
                    else
                    {
                        saat12btn.BackColor = Color.Blue;
                    }
                    if (liste.Contains("14:00"))
                    {
                        saat14btn.Enabled = false;
                        saat14btn.BackColor = Color.Red;
                    }
                    else
                    {
                        saat14btn.BackColor = Color.Blue;
                    }
                    if (liste.Contains("15:00"))
                    {
                        saat15btn.Enabled = false;
                        saat15btn.BackColor = Color.Red;
                    }
                    else
                    {
                        saat15btn.BackColor = Color.Blue;
                    }
                    if (liste.Contains("16:00"))
                    {
                        saat16btn.Enabled = false;
                        saat16btn.BackColor = Color.Red;
                    }
                    else
                    {
                        saat16btn.BackColor = Color.Blue;
                    }
                    if (liste.Contains("17:00"))
                    {
                        onyedibtn.Enabled = false;
                        onyedibtn.BackColor = Color.Red;
                    }
                    else
                    {
                        onyedibtn.BackColor = Color.Blue;
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
