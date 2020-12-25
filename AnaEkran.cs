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
                SqlCommand personellerAl = new SqlCommand("select * from Personeller", db.baglanti);
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

    }
}
