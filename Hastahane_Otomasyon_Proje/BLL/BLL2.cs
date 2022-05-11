using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Collections;
namespace BLL
{
    public class BLL2:IDisposable
    {
        public string KaydetHastaDB(string ad, string soyad, string telefon, string sifre, string kullaniciadi)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    IsKuralları nesne1 = new IsKuralları();
                    nesne1.bos = ad;
                    nesne1.bos = soyad;
                    nesne1.bos = telefon;
                    nesne1.bos = sifre;
                    nesne1.bos = kullaniciadi;
                    nesne1.harf = ad;
                    nesne1.harf = soyad;
                    nesne1.tel = telefon;
                    nesne1._GirisKullanıcıad = kullaniciadi;
                    nesne1._GirisSifre = sifre;
                    return nesne.KaydetHastaDB(ad, soyad, telefon, sifre, kullaniciadi);
                }
            }
            catch (Exception)
            {
                throw;
            }
           
        }
        public string KaydetDoktorDB(string ad, string soyad, string telefon, string brans, string sifre, string kullaniciadi)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    IsKuralları nesne1 = new IsKuralları();
                    nesne1.bos = ad;
                    nesne1.bos = soyad;
                    nesne1.bos = telefon;
                    nesne1.bos = brans;
                    nesne1.bos = sifre;
                    nesne1.bos = kullaniciadi;
                    nesne1.harf = ad;
                    nesne1.harf = soyad;
                    nesne1.tel = telefon;
                    nesne1._GirisKullanıcıad = kullaniciadi;
                    nesne1._GirisSifre = sifre;
                    return nesne.KaydetDoktorDB(ad, soyad, telefon, brans, sifre, kullaniciadi);
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        public string KaydetVezneDB(string ad, string soyad, string sifre, string kullaniciadi)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    IsKuralları nesne1 = new IsKuralları();
                    nesne1.bos = ad;
                    nesne1.bos = soyad;
                    nesne1.bos = sifre;
                    nesne1.bos = kullaniciadi;
                    nesne1.harf = ad;
                    nesne1.harf = soyad;
                    nesne1._GirisKullanıcıad = kullaniciadi;
                    nesne1._GirisSifre = sifre;
                    return nesne.KaydetVezneDB(ad, soyad, sifre, kullaniciadi);
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        public string KaydetYonetimDB(string ad, string soyad, string telefon, string mail, string sifre, string kullaniciadi)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    IsKuralları nesne1 = new IsKuralları();
                    nesne1.bos = ad;
                    nesne1.bos = soyad;
                    nesne1.bos = sifre;
                    nesne1.bos = kullaniciadi;
                    nesne1.bos = mail;
                    nesne1.bos = telefon;
                    nesne1.harf = ad;
                    nesne1.harf = soyad;
                    nesne1.tel = telefon;
                    nesne1._GirisKullanıcıad = kullaniciadi;
                    nesne1._GirisSifre = sifre;
                    return nesne.KaydetYonetimDB(ad, soyad, telefon, mail, sifre, kullaniciadi);
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        public string KaydetRandevuDB(string tarih, string doktorID, string hastaID, string calısanID, string randevuSaat)
        {
            try
            {
                using(DAL2 nesne = new DAL2())
                {
                    IsKuralları nesne1 = new IsKuralları();
                    nesne1.bos = tarih;
                    nesne1.bos = doktorID;
                    nesne1.bos = hastaID;
                    nesne1.bos = calısanID;
                    nesne1.bos = randevuSaat;
                    return nesne.KaydetRandevuDB(tarih, doktorID, hastaID, calısanID, randevuSaat);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public string GuncelleYonetimDB(int id,string ad, string soyad, string telefon,
           string mail, string sifre, string kullaniciadi)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    IsKuralları nesne1 = new IsKuralları();
                    nesne1.bos = ad;
                    nesne1.bos = soyad;
                    nesne1.bos = sifre;
                    nesne1.bos = kullaniciadi;
                    nesne1.bos = mail;
                    nesne1.bos = telefon;
                    nesne1.harf = ad;
                    nesne1.harf = soyad;
                    nesne1.tel = telefon;
                    nesne1._GirisKullanıcıad = kullaniciadi;
                    nesne1._GirisSifre = sifre;
                    return nesne.GuncelleYonetimDB(id,ad, soyad, telefon, mail, sifre, kullaniciadi);
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        public string GuncelleVezneDB(int id,string ad, string soyad, string sifre, string kullaniciadi)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    IsKuralları nesne1 = new IsKuralları();
                    nesne1.bos = ad;
                    nesne1.bos = soyad;
                    nesne1.bos = sifre;
                    nesne1.bos = kullaniciadi;
                    nesne1.harf = ad;
                    nesne1.harf = soyad;
                    nesne1._GirisKullanıcıad = kullaniciadi;
                    nesne1._GirisSifre = sifre;
                    return nesne.GuncelleVezneDB(id,ad, soyad, sifre, kullaniciadi);
                }
            }
            catch (Exception)
            {

                throw;
            }
          
        }
        public string GuncelleDoktorDB(int id,string ad, string soyad, string telefon,
           string brans, string sifre, string kullaniciadi)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    IsKuralları nesne1 = new IsKuralları();
                    nesne1.bos = ad;
                    nesne1.bos = soyad;
                    nesne1.bos = telefon;
                    nesne1.bos = brans;
                    nesne1.bos = sifre;
                    nesne1.bos = kullaniciadi;
                    //nesne1.harf = ad;
                    nesne1.harf = soyad;
                    nesne1.tel = telefon;
                    nesne1._GirisKullanıcıad = kullaniciadi;
                    nesne1._GirisSifre = sifre;
                    return nesne.GuncelleDoktorDB(id,ad, soyad, telefon, brans, sifre, kullaniciadi);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string GuncelleHastaDB(int id,string ad, string soyad, string telefon,
         string sifre, string kullaniciadi)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    IsKuralları nesne1 = new IsKuralları();
                    nesne1.bos = ad;
                    nesne1.bos = soyad;
                    nesne1.bos = telefon;
                    nesne1.bos = sifre;
                    nesne1.bos = kullaniciadi;
                    nesne1.harf = ad;
                    nesne1.harf = soyad;
                    nesne1.tel = telefon;
                    nesne1._GirisKullanıcıad = kullaniciadi;
                    nesne1._GirisSifre = sifre;
                    return nesne.GuncelleHastaDB(id,ad, soyad, telefon, sifre, kullaniciadi);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string GuncelleRandevuDB(int id,string tarih, string doktorID, string hastaID, string calısanID, string randevuSaat)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    IsKuralları nesne1 = new IsKuralları();
                    nesne1.bos = tarih;
                    nesne1.bos = doktorID;
                    nesne1.bos = hastaID;
                    nesne1.bos = calısanID;
                    nesne1.bos = randevuSaat;
                    return nesne.GuncelleRandevuDB(id,tarih, doktorID, hastaID, calısanID, randevuSaat);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string GuncelleHastaTanıDB(int id, string tanı)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    return nesne.GuncelleHastaTanıDB(id, tanı);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable HastaListele()
        {
            using (DAL2 nesne = new DAL2())
            {
                return nesne.HastaListele();
            }
        }
        public DataTable DoktorListele()
        {
            using (DAL2 nesne = new DAL2())
            {
                return nesne.DoktorListele();
            }
        }
        public DataTable VezneListele()
        {
            using (DAL2 nesne = new DAL2())
            {
                return nesne.VezneListele();
            }
        }
        public DataTable RandevuListele()
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    return nesne.RandevuListele();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable YönetimListele()
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    return nesne.YönetimListele();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataTable DetayliHastaListele(int id)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    return nesne.DetayliHastaListele(id);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataTable HastaTanıListele(string id)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    return nesne.HastaTanıListele(id);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataTable HastaBilgiListele(string id)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    return nesne.HastaBilgiListele(id);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<string> DoktorRandevuSaatDB(string doktorid, string randevuTarih)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    return nesne.DoktorRandevuSaatDB(doktorid, randevuTarih);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<string> Doktorsecim()
        {
            try
            {
               using(DAL2 nesne = new DAL2())
               {
                 return nesne.Doktorsecim();
               }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable AraRandevuDB(string parametre)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    return nesne.AraRandevuDB(parametre);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable AraDoktorDB(string parametre)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    return nesne.AraDoktorDB(parametre);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable AraHastaDB(string parametre)
        {
            try
            {
                using (DAL2 nesne=new DAL2())
                {
                    return nesne.AraHastaDB(parametre);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable AraVezneDB(string parametre)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    return nesne.AraVezneDB(parametre);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable AraYonetimDB(string parametre)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    return nesne.AraYonetimDB(parametre);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string HastaIdAraDB(string ad, string soyad, string tel)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    return nesne.HastaIdAraDB(ad, soyad, tel);
                }
            }
            catch (Exception )
            {

                throw;
            }
        }
        public string VezneIdAraDB(string kullaniciad, string sifre)
        {
            try
            {
                using (DAL2 nesne=new DAL2())
                {
                    return nesne.VezneIdAraDB(kullaniciad,sifre);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string DoktorIdAraDB(string ad, string soyad)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    return nesne.DoktorIdAraDB(ad, soyad);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string DoktorIdAraDoktorDB(string kullnıcıAd, string sifre)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    return nesne.DoktorIdAraDoktorDB(kullnıcıAd, sifre);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string SilRandevuDB(int no)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    return nesne.SilRandevuDB(no);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public char SifreKontroVezneDB(string kullaniciad, string sifre)
        {
           
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    IsKuralları nesne1 = new IsKuralları();
                    nesne1._GirisKullanıcıad = kullaniciad;
                    nesne1.silinen = kullaniciad;
                    nesne1._GirisSifre = sifre;
                    return nesne.SifreKontroVezneDB(kullaniciad, sifre);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public char SifreKontrolHastaDB(string kullaniciad, string sifre)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    IsKuralları nesne1 = new IsKuralları();
                    nesne1.silinen = kullaniciad;
                    return nesne.SifreKontrolHastaDB(kullaniciad, sifre);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public char SifreKontrolDoktorDB(string kullaniciad, string sifre)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    IsKuralları nesne1 = new IsKuralları();
                    nesne1.silinen = kullaniciad;
                    return nesne.SifreKontrolDoktorDB(kullaniciad, sifre);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public char SifreKontrolYonetimDB(string kullaniciad, string sifre)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    IsKuralları nesne1 = new IsKuralları();
                    nesne1.silinen = kullaniciad;
                    return nesne.SifreKontrolYonetimDB(kullaniciad, sifre);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string HastaIdAra1DB(string kullanıcıad, string sifre)
        {
            try
            {
                using (DAL2 nesne = new DAL2())
                {
                    return nesne.HastaIdAra1DB(kullanıcıad, sifre);
                }
            }
            catch (Exception)
            {

                throw;
            }
        } 
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
