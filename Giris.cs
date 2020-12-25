using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MoyeeApp
{
    class Giris
    {
        DataBase db = new DataBase(); //DataBase sınıfından db isimli nesne oluştururuz
        public string kullaniciAdi_Tut { get; set; }
        public string kullaniciSifre_Tut { get; set; }
        public string girisDurumu { get; set; }

        public void girisYap(string loginName, string password, DateTime tarih)
        {
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try //programın hata vermemesi için yazılan try-catch blokları
            {
                db.baglanti.Open();
                SqlCommand login = new SqlCommand("select loginName from Users where loginName = @kulAdi", db.baglanti);
                login.Parameters.AddWithValue("@kulAdi", loginName); //kullanıcı adını parametre olarak aldırdım
                SqlDataReader kulAdi_Oku = login.ExecuteReader();
                if (kulAdi_Oku.Read())
                {
                    kullaniciAdi_Tut = kulAdi_Oku["loginName"].ToString();
                    SqlCommand loginPw = new SqlCommand("select password from Users where password = @sifre", db.baglanti);
                    loginPw.Parameters.AddWithValue("@sifre", password); //kullanıcı şifresini parametre olarak aldırıdım
                    SqlDataReader loginPw_Oku = loginPw.ExecuteReader();
                    if (loginPw_Oku.Read())
                    {
                        kullaniciSifre_Tut = loginPw_Oku["password"].ToString();
                        girisDurumu = kullaniciAdi_Tut + " " + kullaniciSifre_Tut;
                        SqlCommand dateUpdate = new SqlCommand("update Users set girisTarihi=@tarih where kullaniciAdi = @kulAdi AND kullaniciSifre = @sifre", db.baglanti); //giriş tarihini sürekli güncellemesi için
                        dateUpdate.Parameters.AddWithValue("@tarih", tarih);
                        dateUpdate.Parameters.AddWithValue("@kulAdi", kullaniciAdi_Tut);
                        dateUpdate.Parameters.AddWithValue("@sifre", kullaniciSifre_Tut);
                        dateUpdate.ExecuteNonQuery();
                        dateUpdate.Dispose(); //ramden kaldırıyoruz
                    }
                    else
                    {
                        MessageBox.Show("Şifreyi yanlış girdiniz.", "HATA | Moyee Database System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    loginPw.Dispose();//ramden kaldırıyoruz
                    loginPw_Oku.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adını yanlış girdiniz.", "HATA | Moyee Database System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                login.Dispose();//ramden kaldırıyoruz
                kulAdi_Oku.Close();
                db.baglanti.Close();
            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }

        }
    }
}
