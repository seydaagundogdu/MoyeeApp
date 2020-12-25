using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace MoyeeApp
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                    {
                        m.Result = (IntPtr)0x2;
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            FrmAnaEkran anaEkran = new FrmAnaEkran();
            if (txtKullaniciAdi.Text == string.Empty || txtSifre.Text == string.Empty)
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifreyi giriniz.", "HATA | Moyee Database System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                grs.girisYap(txtKullaniciAdi.Text, txtSifre.Text, DateTime.Now);
                string bilgiTut = txtKullaniciAdi.Text + " " + txtSifre.Text.ToString();
                if (grs.girisDurumu == bilgiTut)
                {
                    anaEkran.Show();
                    this.Hide();
                }

            }
        }
    

    private void label1_Click(object sender, EventArgs e)
    {

    }
}
}
