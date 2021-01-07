using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MoyeeApp
{
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m) //pencereyi mousela hareket ettirebilmek için yazılan kod bloğu
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                AnaEkran anaEkran = new AnaEkran();
                dataGridView1.DataSource = anaEkran.rapor1_Listele();
                anaEkran.rapor1 = "Personeller";
                anaEkran.rapor2 = "";
                anaEkran.rapor3 = "";
                anaEkran.rapor4 = "";

            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            if (radioButton1.Checked == true)
            {
                dataGridView1.DataSource = anaEkran.veriGetirRapor1(txtAra.Text);
            }
            if (radioButton2.Checked == true)
            {
                dataGridView1.DataSource = anaEkran.veriGetirRapor2(txtAra.Text);
            }
            if (radioButton3.Checked == true)
            {
                dataGridView1.DataSource = anaEkran.veriGetirRapor3(txtAra.Text);
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                AnaEkran anaEkran = new AnaEkran();
                dataGridView1.DataSource = anaEkran.rapor2_Listele();
                anaEkran.rapor1 = "";
                anaEkran.rapor2 = "Personeller";
                anaEkran.rapor3 = "";
                anaEkran.rapor4 = "";
            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                AnaEkran anaEkran = new AnaEkran();
                dataGridView1.DataSource = anaEkran.rapor3_Listele();
                anaEkran.rapor1 = "";
                anaEkran.rapor2 = "";
                anaEkran.rapor3 = "Operasyon";
                anaEkran.rapor4 = "";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                AnaEkran anaEkran = new AnaEkran();
                dataGridView1.DataSource = anaEkran.rapor4_Listele();
                anaEkran.rapor1 = "";
                anaEkran.rapor2 = "";
                anaEkran.rapor3 = "";
                anaEkran.rapor4 = "Operasyon";
            }
        }
    }
}
