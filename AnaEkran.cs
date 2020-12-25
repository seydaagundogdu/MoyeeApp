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
        public DataTable rapor2_Listele()
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand odaAl = new SqlCommand("select * from oda", db.baglanti);
                SqlDataAdapter adaptor = new SqlDataAdapter(odaAl);
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
        public DataTable veriGetirRapor1(string personelAdi)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand getir = new SqlCommand("select * from mutfak where adi LIKE '%'+@ad+'%'", db.baglanti);
                getir.Parameters.AddWithValue("@ad", personelAdi);
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
        public DataTable veriGetirRapor2(string urunAdi)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand getir = new SqlCommand("select * from oda where personelAdi  LIKE '%'+@ad+'%'", db.baglanti);
                getir.Parameters.AddWithValue("@ad", urunAdi);
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
        public DataTable veriGetirRapor3(string urunAdi)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand getir = new SqlCommand("select * from oda where personelAdi  LIKE '%'+@ad+'%'", db.baglanti);
                getir.Parameters.AddWithValue("@ad", urunAdi);
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
