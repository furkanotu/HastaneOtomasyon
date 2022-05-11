using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class DAL2:IDisposable
    {
        string baglanticumlesi = "Data Source=PC\\SQLEXPRESS;Initial Catalog=HastaneOtomasyon;Integrated Security=True";
        public string KaydetHastaDB( string ad,string soyad,string telefon, string sifre,string kullaniciadi)
        {
            string mesaj = "";
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                
                baglanti.Open();
                using (SqlCommand kayit = new SqlCommand("HastaProcedure", baglanti))
                {
                    kayit.CommandType = CommandType.StoredProcedure;
                    kayit.Parameters.AddWithValue("@Action", "Insert");
                    kayit.Parameters.AddWithValue("@HastaAd", ad);
                    kayit.Parameters.AddWithValue("@HastaSoyad", soyad);
                    kayit.Parameters.AddWithValue("@Hastatel", telefon);
                    kayit.Parameters.AddWithValue("@HastaSifre", sifre);
                    kayit.Parameters.AddWithValue("@HkullaniciAd", kullaniciadi);
                    if (kayit.ExecuteNonQuery() > 0)
                        mesaj = ("Kayıt başarılı");
                    else
                        mesaj = ("Kayıt başarısız");
                }
                baglanti.Close();
            }
            return mesaj;
        }
        public string KaydetDoktorDB(string ad, string soyad, string telefon,string brans, string sifre, string kullaniciadi)
        {
            string mesaj = "";
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {

                baglanti.Open();
                using (SqlCommand kayit = new SqlCommand("DoktorProcedure", baglanti))
                {
                    kayit.CommandType = CommandType.StoredProcedure;
                    kayit.Parameters.AddWithValue("@Action", "Insert");
                    kayit.Parameters.AddWithValue("@DoktorAd", ad);
                    kayit.Parameters.AddWithValue("@DoktorSoyad", soyad);
                    kayit.Parameters.AddWithValue("@DoktorTel", telefon);
                    kayit.Parameters.AddWithValue("@DoktorBrans", brans);
                    kayit.Parameters.AddWithValue("@DoktorSifre", sifre);
                    kayit.Parameters.AddWithValue("@KullaniciAd", kullaniciadi);
                    if (kayit.ExecuteNonQuery() > 0)
                        mesaj = ("Kayıt başarılı");
                    else
                        mesaj = ("Kayıt başarısız");
                }
                baglanti.Close();
            }
            return mesaj;
        }
        public string KaydetVezneDB(string ad, string soyad, string sifre, string kullaniciadi)
        {
            string mesaj = "";
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {

                baglanti.Open();
                using (SqlCommand kayit = new SqlCommand("VezneProcedure", baglanti))
                {
                    kayit.CommandType = CommandType.StoredProcedure;
                    kayit.Parameters.AddWithValue("@Action", "Insert");
                    kayit.Parameters.AddWithValue("@CalısanAd", ad);
                    kayit.Parameters.AddWithValue("@CalısanSoyad", soyad);
                    kayit.Parameters.AddWithValue("@CalısanSifre", sifre);
                    kayit.Parameters.AddWithValue("@CalısanKullaniciAd", kullaniciadi);
                    if (kayit.ExecuteNonQuery() > 0)
                        mesaj = ("Kayıt başarılı");
                    else
                        mesaj = ("Kayıt başarısız");
                }
                baglanti.Close();
            }
            return mesaj;
        }
        public string KaydetYonetimDB(string ad, string soyad, string telefon, string mail, string sifre, string kullaniciadi)
        {
            string mesaj = "";
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                    
                baglanti.Open();
                using (SqlCommand kayit = new SqlCommand("YonetimProcedure", baglanti))
                {
                    kayit.CommandType = CommandType.StoredProcedure;
                    kayit.Parameters.AddWithValue("@Action", "Insert");
                    kayit.Parameters.AddWithValue("@YonetimAd", ad);
                    kayit.Parameters.AddWithValue("@YonetimSoyad", soyad);
                    kayit.Parameters.AddWithValue("@YonetimTel", telefon);
                    kayit.Parameters.AddWithValue("@YonetimMail", mail);
                    kayit.Parameters.AddWithValue("@YonetimSifre", sifre);
                    kayit.Parameters.AddWithValue("@YonetimKullaniciAd", kullaniciadi);
                    if (kayit.ExecuteNonQuery() > 0)
                        mesaj = ("Kayıt başarılı");
                    else
                        mesaj = ("Kayıt başarısız");
                }
                baglanti.Close();
            }
            return mesaj;
        }
        public string KaydetRandevuDB(string tarih, string doktorID, string hastaID, string calısanID, string randevuSaat)
        {
            string mesaj = "";
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {

                baglanti.Open();
                using (SqlCommand kayit = new SqlCommand("RandevuProcedure", baglanti))
                {
                    kayit.CommandType = CommandType.StoredProcedure;
                    kayit.Parameters.AddWithValue("@Action", "Insert");
                    kayit.Parameters.AddWithValue("@RandevuTarih", tarih);
                    kayit.Parameters.AddWithValue("@DoktorID", doktorID);
                    kayit.Parameters.AddWithValue("@HastaID", hastaID);
                    kayit.Parameters.AddWithValue("@CalısanID", calısanID);
                    kayit.Parameters.AddWithValue("@RandevuSaat", randevuSaat);
                    if (kayit.ExecuteNonQuery() > 0)
                        mesaj = ("Kayıt başarılı");
                    else
                        mesaj = ("Kayıt başarısız");
                }
                baglanti.Close();
            }
            return mesaj;
        }
        public string DoktorRandevuKaydetDB(string tarih, string doktorID, string hastaID, string calısanID, string randevuSaat)
        {
            string mesaj = "";
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {

                baglanti.Open();
                using (SqlCommand kayit = new SqlCommand("RandevuProcedure", baglanti))
                {
                    kayit.CommandType = CommandType.StoredProcedure;
                    kayit.Parameters.AddWithValue("@Action", "Insert");
                    kayit.Parameters.AddWithValue("@RandevuTarih", tarih);
                    kayit.Parameters.AddWithValue("@DoktorID", doktorID);
                    kayit.Parameters.AddWithValue("@HastaID", hastaID);
                    kayit.Parameters.AddWithValue("@CalısanID", calısanID);
                    kayit.Parameters.AddWithValue("@RandevuSaat", randevuSaat);
                    if (kayit.ExecuteNonQuery() > 0)
                        mesaj = ("Kayıt başarılı");
                    else
                        mesaj = ("Kayıt başarısız");
                }
                baglanti.Close();
            }
            return mesaj;
        }
        public string GuncelleYonetimDB(int id,string ad, string soyad, string telefon,
            string mail, string sifre, string kullaniciadi)
        {
            string mesaj = "";
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                baglanti.Open();
                using (SqlCommand guncelle = new SqlCommand("YonetimProcedure", baglanti))
                {
                    guncelle.CommandType = CommandType.StoredProcedure;
                    guncelle.Parameters.AddWithValue("@Action", "Update");
                    guncelle.Parameters.AddWithValue("@YonetimId",id);
                    guncelle.Parameters.AddWithValue("@YonetimAd", ad);
                    guncelle.Parameters.AddWithValue("@YonetimSoyad", soyad);
                    guncelle.Parameters.AddWithValue("@YonetimTel", telefon);
                    guncelle.Parameters.AddWithValue("@YonetimMail", mail);
                    guncelle.Parameters.AddWithValue("@YonetimSifre", sifre);
                    guncelle.Parameters.AddWithValue("@YonetimKullaniciAd", kullaniciadi);
                    if (guncelle.ExecuteNonQuery() > 0)
                        mesaj = ("Güncelleme başarılı");
                    else
                        mesaj = ("Güncelleme başarısız");
                }
                baglanti.Close();
            }
            return mesaj;
        }
        public string GuncelleVezneDB(int id,string ad, string soyad, string sifre, string kullaniciadi)
        {
            string mesaj = "";
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                baglanti.Open();
                using (SqlCommand guncelle = new SqlCommand("VezneProcedure", baglanti))
                {
                    guncelle.CommandType = CommandType.StoredProcedure;
                    guncelle.Parameters.AddWithValue("@Action", "Update");
                    guncelle.Parameters.AddWithValue("@CalısanAd", ad);
                    guncelle.Parameters.AddWithValue("@Calisanıd", id);
                    guncelle.Parameters.AddWithValue("@CalısanSoyad", soyad);
                    guncelle.Parameters.AddWithValue("@CalısanSifre", sifre);
                    guncelle.Parameters.AddWithValue("@CalısanKullaniciAd", kullaniciadi);
                    if (guncelle.ExecuteNonQuery() > 0)
                        mesaj = ("Güncelleme başarılı");
                    else
                        mesaj = ("Güncelleme başarısız");
                }
                baglanti.Close();
            }
            return mesaj;
        }
        public string GuncelleDoktorDB(int id,string ad, string soyad, string telefon,string brans,
            string sifre, string kullaniciadi)
        {
            string mesaj = "";
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {

                baglanti.Open();
                using (SqlCommand kayit = new SqlCommand("DoktorProcedure", baglanti))
                {
                    kayit.CommandType = CommandType.StoredProcedure;
                    kayit.Parameters.AddWithValue("@Action", "Update");
                    kayit.Parameters.AddWithValue("@Doktorıd", id);
                    kayit.Parameters.AddWithValue("@DoktorAd", ad);
                    kayit.Parameters.AddWithValue("@DoktorSoyad", soyad);
                    kayit.Parameters.AddWithValue("@DoktorTel", telefon);
                    kayit.Parameters.AddWithValue("@DoktorBrans", brans);
                    kayit.Parameters.AddWithValue("@DoktorSifre", sifre);
                    kayit.Parameters.AddWithValue("@KullaniciAd", kullaniciadi);
                    if (kayit.ExecuteNonQuery() > 0)
                        mesaj = ("İşlem başarılı");
                    else
                        mesaj = ("İşlem başarısız");
                }
                baglanti.Close();
            }
            return mesaj;
        }
        public string GuncelleRandevuDB(int id,string tarih, string doktorID, string hastaID, string calısanID, string randevuSaat)
        {
            string mesaj = "";
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {

                baglanti.Open();
                using (SqlCommand kayit = new SqlCommand("YonetimProcedure", baglanti))
                {
                    kayit.CommandType = CommandType.StoredProcedure;
                    kayit.Parameters.AddWithValue("@Action", "insert");
                    kayit.Parameters.AddWithValue("@RandevuTarih", tarih);
                    kayit.Parameters.AddWithValue("@DoktorID", tarih);
                    kayit.Parameters.AddWithValue("@HastaID", hastaID);
                    kayit.Parameters.AddWithValue("@CalısanID", calısanID);
                    kayit.Parameters.AddWithValue("@RandevuSaat", randevuSaat);
                    if (kayit.ExecuteNonQuery() > 0)
                        mesaj = ("Kayıt başarılı");
                    else
                        mesaj = ("Kayıt başarısız");
                }
                baglanti.Close();
            }
            return mesaj;
        }
        public string GuncelleHastaDB(int id,string ad, string soyad, string telefon,
         string sifre, string kullaniciadi)
        {
            string mesaj = "";
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                baglanti.Open();
                using (SqlCommand guncelle = new SqlCommand("HastaProcedure", baglanti))
                {
                    guncelle.CommandType = CommandType.StoredProcedure;
                    guncelle.Parameters.AddWithValue("@Action", "Update");
                    guncelle.Parameters.AddWithValue("@HastaAd", ad);
                    guncelle.Parameters.AddWithValue("@Hastaıd", id);
                    guncelle.Parameters.AddWithValue("@HastaSoyad", soyad);
                    guncelle.Parameters.AddWithValue("@Hastatel", telefon);
                    guncelle.Parameters.AddWithValue("@HastaSifre", sifre);
                    guncelle.Parameters.AddWithValue("@HkullaniciAd", kullaniciadi);
                    if (guncelle.ExecuteNonQuery() > 0)
                        mesaj = ("Güncelleme başarılı");
                    else
                        mesaj = ("Güncelleme başarısız");
                }
                baglanti.Close();
            }
            return mesaj;
        }
        public string GuncelleHastaTanıDB(int id, string tanı)
        {
            string mesaj = "";
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                baglanti.Open();
                using (SqlCommand guncelle = new SqlCommand("Update Hasta_TBl set HastaTani = @HastaTani where HastaId = @HastaId", baglanti))
                {   
                    guncelle.Parameters.AddWithValue("@HastaId", id);
                    guncelle.Parameters.AddWithValue("@HastaTani", tanı);
                    if (guncelle.ExecuteNonQuery() > 0)
                        mesaj = ("İşlem başarılı");
                    else
                        mesaj = ("İşlem başarısız");
                }
                baglanti.Close();
            }
            return mesaj;
        }
        public DataTable HastaListele()
        {
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                using (SqlCommand komut = new SqlCommand("Select * from Hasta_Tbl", baglanti))
                {
                    baglanti.Open();
                    using (SqlDataAdapter dt = new SqlDataAdapter(komut))
                    {
                        using (DataTable ds = new DataTable())
                        {
                            dt.Fill(ds);
                            baglanti.Close();
                            return ds;
                        }
                    }
                }
            }

        }
        public DataTable DoktorListele()
        {
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                using (SqlCommand komut = new SqlCommand("Select * from Doktor_Tbl", baglanti))
                {
                    baglanti.Open();
                    using (SqlDataAdapter dt = new SqlDataAdapter(komut))
                    {
                        using (DataTable ds = new DataTable())
                        {
                            dt.Fill(ds);
                            baglanti.Close();
                            return ds;
                        }
                    }
                }
            }

        }
        public DataTable VezneListele()
        {
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                using (SqlCommand komut = new SqlCommand("Select * from Vezne_Tbl", baglanti))
                {
                    baglanti.Open();
                    using (SqlDataAdapter dt = new SqlDataAdapter(komut))
                    {
                        using (DataTable ds = new DataTable())
                        {
                            dt.Fill(ds);
                            baglanti.Close();
                            return ds;
                        }
                    }
                }
            }

        }
        public DataTable RandevuListele()
        {
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                using (SqlCommand komut = new SqlCommand("Select * from Randevu_Tbl", baglanti))
                {
                    baglanti.Open();
                    using (SqlDataAdapter dt = new SqlDataAdapter(komut))
                    {
                        using (DataTable ds = new DataTable())
                        {
                            dt.Fill(ds);
                            baglanti.Close();
                            return ds;
                        }
                    }
                }
            }

        }
        public DataTable YönetimListele()
        {
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                using (SqlCommand komut = new SqlCommand("Select * from Yonetim_Tbl", baglanti))
                {
                    baglanti.Open();
                    using (SqlDataAdapter dt = new SqlDataAdapter(komut))
                    {
                        using (DataTable ds = new DataTable())
                        {
                            dt.Fill(ds);
                            baglanti.Close();
                            return ds;
                        }
                    }
                }
            }

        }
        public DataTable DetayliHastaListele(int id)
        {
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                using (SqlCommand komut = new SqlCommand($"Select h.HastaId,HastaAd,HastaSoyad,HastaTelefon,HastaTani from Hasta_TBl h inner join Randevu_Tbl t on h.HastaId=t.HastaID inner join Doktor_Tbl d on t.DoktorID = d.Doktorid where Doktorid=\'{id}\'", baglanti))
                {
                    baglanti.Open();
                    using (SqlDataAdapter dt = new SqlDataAdapter(komut))
                    {
                        using (DataTable ds = new DataTable())
                        {
                            dt.Fill(ds);
                            baglanti.Close();
                            return ds;
                        }
                    }
                }
            }

        }
        public DataTable HastaTanıListele(string id)
        {
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                using (SqlCommand komut = new SqlCommand($"select h.HastaTani,d.DoktorAd,d.DoktorBrans,r.RandevuTarih from Hasta_TBl h inner join Randevu_Tbl r on h.HastaId=r.HastaID inner join Doktor_Tbl d on r.DoktorID=d.Doktorid where h.HastaID =\'{id}\' ", baglanti))
                {
                    baglanti.Open();
                    using (SqlDataAdapter dt = new SqlDataAdapter(komut))
                    {
                        using (DataTable ds = new DataTable())
                        {
                            dt.Fill(ds);
                            baglanti.Close();
                            return ds;
                        }
                    }
                }
            }

        }
        public DataTable HastaBilgiListele(string id)
        {
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                using (SqlCommand komut = new SqlCommand($"Select * from Hasta_Tbl where HastaID =\'{id}\'  ", baglanti))
                {
                    baglanti.Open();
                    using (SqlDataAdapter dt = new SqlDataAdapter(komut))
                    {
                        using (DataTable ds = new DataTable())
                        {
                            dt.Fill(ds);
                            baglanti.Close();
                            return ds;
                        }
                    }
                }
            }

        }
        public string SilRandevuDB( int no)
        {
            string mesaj = "";
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                baglanti.Open();

                using (SqlCommand silme = new SqlCommand("delete * from Randevu_Tbl where RandevuID=@no", baglanti))
                {
                    silme.Parameters.AddWithValue("@no", no);

                    if (silme.ExecuteNonQuery() > 0)
                        mesaj = ("Kayıt silindi");
                    else
                        mesaj = ("Kayıt silinmedi");
                }
                baglanti.Close();
            }
            return mesaj;
        }
        public DataTable AraDoktorDB(string parametre)
        {
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                using (SqlDataAdapter da = new SqlDataAdapter($"select * from Doktor_Tbl where DoktorAd=\'{parametre}\'", baglanti))
                {
                    using (DataTable ds = new DataTable())
                    {
                        da.Fill(ds);
                        baglanti.Close();
                        return ds;
                    }
                }
            }
        }
        public DataTable AraHastaDB(string parametre)
        {
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                using (SqlDataAdapter da = new SqlDataAdapter($"select * from Hasta_Tbl where HastaID=\'{parametre}\'" , baglanti))
                {
                    using (DataTable ds = new DataTable())
                    {
                        da.Fill(ds);
                        baglanti.Close();
                        return ds;
                    }
                }
            }
        }
        public DataTable AraVezneDB(string parametre)
        {
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                using (SqlDataAdapter da = new SqlDataAdapter($"select * from Vezne_Tbl where CalisanAd=\'{parametre}\'", baglanti))
                {
                    using (DataTable ds = new DataTable())
                    {
                        da.Fill(ds);
                        baglanti.Close();
                        return ds;
                    }
                }
            }
        }
        public DataTable AraRandevuDB(string parametre)
        {
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                using (SqlDataAdapter da = new SqlDataAdapter($"select * from Randevu_Tbl where RandevuID=\'{parametre}\'", baglanti))
                {
                    using (DataTable ds = new DataTable())
                    {
                        da.Fill(ds);
                        baglanti.Close();
                        return ds;
                    }
                }
            }
        }
        public DataTable AraYonetimDB(string parametre)
        {
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                using (SqlDataAdapter da = new SqlDataAdapter($"select * from Yonetim_Tbl where YonetimID=\'{parametre}\'", baglanti))
                {
                    using (DataTable ds = new DataTable())
                    {
                        da.Fill(ds);
                        baglanti.Close();
                        return ds;
                    }
                }
            }
        }
        public string HastaIdAraDB(string ad,string soyad,string tel)
        {
            string id ="";
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                baglanti.Open();
                using (SqlCommand komut = new SqlCommand($"select HastaId from Hasta_TBl where HastaAd=\'{ad}\' and HastaSoyad=\'{soyad}\' and HastaTelefon=\'{tel}\'", baglanti))
                {
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        id = dr[0].ToString();
                    }
                    baglanti.Close();
                    return id;
                }
            }
        }
        public string HastaIdAra1DB(string kullanıcıad, string sifre)
        {
            string id = "";
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                baglanti.Open();
                using (SqlCommand komut = new SqlCommand($"select HastaId from Hasta_TBl where HkullaniciAd=\'{kullanıcıad}\' and HastaSifre=\'{sifre}\'", baglanti))
                {
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        id = dr[0].ToString();
                    }
                    baglanti.Close();
                    return id;
                }
            }
        }
        public string VezneIdAraDB(string kullaniciad, string sifre)
        {
            string id = "";
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                baglanti.Open();
                using (SqlCommand komut = new SqlCommand($"select CalisanId from Vezne_Tbl where CalisanKullaniciAd=\'{kullaniciad}\' and CalisanSifre=\'{sifre}\'", baglanti))
                {
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        id = dr[0].ToString();
                    }
                    baglanti.Close();
                    return id;
                }
            }
        }
        public string DoktorIdAraDB(string ad, string soyad)
        {
            string id = "";
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                baglanti.Open();
                using (SqlCommand komut = new SqlCommand($"select Doktorid from Doktor_Tbl where DoktorAd=\'{ad}\' and DoktorSoyad=\'{soyad}\'", baglanti))
                {
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        id = dr[0].ToString();
                    }
                    baglanti.Close();
                    return id;
                }
            }
        }
        public string DoktorIdAraDoktorDB(string kullnıcıAd, string sifre)
        {
            string id = "";
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                baglanti.Open();
                using (SqlCommand komut = new SqlCommand($"select Doktorid from Doktor_Tbl where KullaniciAd=\'{kullnıcıAd}\' and DoktorSifre=\'{sifre}\'", baglanti))
                {
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        id = dr[0].ToString();
                    }
                    baglanti.Close();
                    return id;
                }
            }
        }
        public List<string> DoktorRandevuSaatDB(string doktorid, string randevuTarih)
        {
            
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                baglanti.Open();
                using (SqlCommand komut = new SqlCommand($"select RandevuSaat from Randevu_Tbl r inner join Doktor_Tbl d on r.DoktorID=d.Doktorid where DoktorID=\'{doktorid}\' and RandevuTarih=\'{randevuTarih}\' ", baglanti))
                {
                    SqlDataReader rd = komut.ExecuteReader();
                    List<string> liste = new List<string>();
                    while (rd.Read())   
                    {
                        for (int i = 0; i < rd.FieldCount; i++)
                        {
                            liste.Add(rd[i].ToString());
                        }
                    }
                    baglanti.Close();
                    return liste;
                }
            }
        }
        public List<string> Doktorsecim()
        {
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                baglanti.Open();
                using (SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from Doktor_Tbl where DoktorAd not like 'AAAA%'", baglanti))
                {
                   
                    SqlDataReader rd = komut.ExecuteReader();
                    List<string> liste = new List<string>();
                    while (rd.Read())
                    {
                        for (int i = 0; i <rd.FieldCount; i=i+2)
                        {
                            liste.Add(rd[i].ToString()+" "+ rd[i + 1].ToString());
                        }
                    }
                    baglanti.Close();
                    return liste;
                    
                }
               
            }
        }
        public char SifreKontroVezneDB(string kullaniciad, string sifre)
        {
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                string dogrusifre;
                char cevap = 'b';

                baglanti.Open();
                using (SqlCommand komut = new SqlCommand($"select CalisanSifre from Vezne_Tbl where CalisanKullaniciAd=\'{kullaniciad}\'", baglanti))
                {
                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dogrusifre = dr[0].ToString();

                            if (sifre == dogrusifre)
                            {
                                cevap = 'd';
                            }
                            else
                            {
                                cevap = 'y';
                            }
                        }
                        baglanti.Close();
                    }
                }
                return cevap;
            }
        }
        public char SifreKontrolHastaDB(string kullaniciad, string sifre)
        {
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                string dogrusifre;
                char cevap = 'b';

                baglanti.Open();
                using (SqlCommand komut = new SqlCommand($"select HastaSifre from Hasta_TBl where HkullaniciAd=\'{kullaniciad}\'", baglanti))
                {
                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dogrusifre = dr[0].ToString();

                            if (sifre == dogrusifre)
                            {
                                cevap = 'd';
                            }
                            else
                            {
                                cevap = 'y';
                            }
                        }
                        baglanti.Close();
                    }
                }
                return cevap;
            }
        }
        public char SifreKontrolDoktorDB(string kullaniciad, string sifre)
        {
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                string dogrusifre;
                char cevap = 'b';

                baglanti.Open();
                using (SqlCommand komut = new SqlCommand($"select DoktorSifre from Doktor_Tbl where KullaniciAd=\'{kullaniciad}\'", baglanti))
                {
                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dogrusifre = dr[0].ToString();

                            if (sifre == dogrusifre)
                            {
                                cevap = 'd';
                            }
                            else
                            {
                                cevap = 'y';
                            }
                        }
                        baglanti.Close();
                    }
                }
                return cevap;
            }
        }
        public char SifreKontrolYonetimDB(string kullaniciad, string sifre)
        {
            using (SqlConnection baglanti = new SqlConnection(baglanticumlesi))
            {
                string dogrusifre;
                char cevap = 'b';

                baglanti.Open();
                using (SqlCommand komut = new SqlCommand($"select YonetimSifre from Yonetim_Tbl where YonetimKullaniciAd=\'{kullaniciad}\'", baglanti))
                {
                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dogrusifre = dr[0].ToString();

                            if (sifre == dogrusifre)
                            {
                                cevap = 'd';
                            }
                            else
                            {
                                cevap = 'y';
                            }
                        }
                        baglanti.Close();
                    }
                }
                return cevap;
            }
        }
        public void Dispose()
        {
           // throw new NotImplementedException();
        }
    }
}
