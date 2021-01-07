using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace MoyeeApp
{
    class AnaEkran 
    {
        public string rapor1 = "";
        public string rapor2 = "";
        public string rapor3 = "";
        public string rapor4 = "";
        public ArrayList raporlar = new ArrayList();
        DataBase db = new DataBase();
        public DataTable rapor1_Listele()
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand personellerAl = new SqlCommand("SELECT registryID, ad, soyad, kimlikNo, iletisimID, CalismaDurumu.calismaDurumu, PersonelGrubu.personelGrubu, Departmanlar.departman, Pozisyonlar.pozisyon, Unvanlar.unvan, bagliOlduguMudur, bagliOlduguDirektor, bagliOlduguCeo, iseGirisTarihi, dogumTarihi, cinsiyet, maas FROM Personeller left join Pozisyonlar on Pozisyonlar.pozisyonID=Personeller.pozisyonID left join Departmanlar on Departmanlar.departmanID=Personeller.departmanID left join Unvanlar on Unvanlar.unvanID=Personeller.unvanID left join CalismaDurumu on CalismaDurumu.calismaDurumuID=Personeller.calismaDurumuID left join PersonelGrubu on PersonelGrubu.personelGrubuID=Personeller.personelGrubuID", db.baglanti);
                SqlDataAdapter adaptor = new SqlDataAdapter(personellerAl);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }
        public DataTable rapor2_Listele()
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand personelAl = new SqlCommand("SELECT ad,soyad,Pozisyonlar.pozisyon,iseGirisTarihi,dogumTarihi,cinsiyet,maas FROM Personeller full join Pozisyonlar on Pozisyonlar.pozisyonID=Personeller.pozisyonID WHERE maas>=4000", db.baglanti);
                SqlDataAdapter adaptor = new SqlDataAdapter(personelAl);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }

        public DataTable rapor3_Listele()
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand personelAl = new SqlCommand("SELECT ad, soyad, Musteriler.musteri, Departmanlar.departman, Pozisyonlar.pozisyon, Unvanlar.unvan, dogumTarihi, cinsiyet FROM Operasyon left join Personeller on Operasyon.registryID=Personeller.registryID left join Departmanlar on Departmanlar.departmanID=Personeller.departmanID left join Pozisyonlar on Pozisyonlar.pozisyonID=Personeller.pozisyonID left join Unvanlar on Unvanlar.unvanID=Personeller.unvanID full join Musteriler on Musteriler.musteriID=Operasyon.musteriID order by dogumTarihi desc", db.baglanti);
                SqlDataAdapter adaptor = new SqlDataAdapter(personelAl);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }
        public DataTable rapor4_Listele()
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand personelAl = new SqlCommand("SELECT ad, soyad, Musteriler.musteri, Vardiyalar.baslangicSaati, Vardiyalar.bitisSaati FROM Operasyon left join Personeller on Operasyon.registryID=Personeller.registryID full join Musteriler on Musteriler.musteriID=Operasyon.musteriID inner join Vardiyalar on Vardiyalar.musteriID=Musteriler.musteriID WHERE unvanID=9", db.baglanti);
                SqlDataAdapter adaptor = new SqlDataAdapter(personelAl);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }
        public DataTable veriGetirRapor1(string ad)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand getir = new SqlCommand("select * from Personeller where ad LIKE '%'+@ad+'%'", db.baglanti);
                getir.Parameters.AddWithValue("@ad", ad);
                SqlDataAdapter adaptor = new SqlDataAdapter(getir);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }
        public DataTable veriGetirRapor2(string ad)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand getir = new SqlCommand("select * from Personeller where ad  LIKE '%'+@ad+'%'", db.baglanti);
                getir.Parameters.AddWithValue("@ad", ad);
                SqlDataAdapter adaptor = new SqlDataAdapter(getir);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }
        public DataTable veriGetirRapor3(string ad)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand getir = new SqlCommand("select * from Personeller where ad  LIKE '%'+@ad+'%'", db.baglanti);
                getir.Parameters.AddWithValue("@ad", ad);
                SqlDataAdapter adaptor = new SqlDataAdapter(getir);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }
        public DataTable veriGetirRapor4(string ad)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand getir = new SqlCommand("select * from Personeller where ad LIKE '%'+@ad+'%'", db.baglanti);
                getir.Parameters.AddWithValue("@ad", ad);
                SqlDataAdapter adaptor = new SqlDataAdapter(getir);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }

    }
}
