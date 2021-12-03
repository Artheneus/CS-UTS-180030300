using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace uts_180030300
{
    public partial class Form1 : Form
    {
        double tUntung, biayaBang, Luas, bTambahan, upahU, upahPmb, jumHari, jumTukang, jumPembantu;
        string biayaBangun;
        CultureInfo negara = new CultureInfo("id-ID");
        string pilih1;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public double totalKeuntungan()
        {
            pilih1 = cB_lantai.SelectedItem.ToString();
            if (pilih1 == "1")
            {
                biayaBangun = "Rp 1000";
            }
            else if (pilih1 == "2")
            {
                biayaBangun = "Rp 1500";
            }
            else
            {
                biayaBangun = "Rp 2000";
            }

            Luas = double.Parse(tB_Luas.Text);
            biayaBang = double.Parse(biayaBangun, NumberStyles.Currency, negara) * Luas;

            jumHari = double.Parse(tb_hari.Text);
            jumTukang = double.Parse(tb_tukang.Text);
            jumPembantu = double.Parse(tb_bantu.Text);
            tUntung = 0;


            /*if (jenis_Borongan.Checked == true)
            {
                string value = "";
                bool isChecked = jenis_Borongan.Checked;
                if (isChecked)
                    value = jenis_Borongan.Text;

                if (value == "Borongan")
                {
                    bTambahan = 0.1 * biayaBang;
                    upahU = 0.3 * biayaBang;
                    upahPmb = 0.2 * biayaBang;
                    tUntung = biayaBang + bTambahan - upahU - upahPmb;
                }
            }

            if(jenis_Harian.Checked == true)
            {
                string value = "";
                bool isChecked = jenis_Harian.Checked;
                if (isChecked)
                    value = jenis_Harian.Text;

                if (value == "Harian")
                {
                    bTambahan = 0.05 * biayaBang;
                    upahU = 150 * jumTukang * jumHari;
                    upahPmb = 100 * jumPembantu * jumHari;
                    tUntung = biayaBang + bTambahan - upahU - upahPmb;
                }
            }*/

            if (jenis_Borongan.Checked == true)
            {
                string value = "";
                bool isChecked = jenis_Borongan.Checked;
                if (isChecked)
                    value = jenis_Borongan.Text;

                if (value == "Borongan")
                {
                    bTambahan = 0.1 * biayaBang;
                    upahU = 0.3 * biayaBang;
                    upahPmb = 0.2 * biayaBang;
                    tUntung = biayaBang + bTambahan - upahU - upahPmb;
                }
            }
            else
            {
                string value = "";
                bool isChecked = jenis_Harian.Checked;
                if (isChecked)
                    value = jenis_Harian.Text;

                if (value == "Harian")
                {
                    bTambahan = 0.05 * biayaBang;
                    upahU = 150 * jumTukang * jumHari;
                    upahPmb = 100 * jumPembantu * jumHari;
                    tUntung = biayaBang + bTambahan - upahU - upahPmb;
                }
            }

            if (cB_ac.Checked == true)
            {
                tUntung = tUntung + 5000;
            }

            if (cB_heater.Checked == true)
            {
                tUntung = tUntung + 3000;
            }

            if (cB_wifi.Checked == true)
            {
                tUntung = tUntung + 4000;
            }

            label8.Text = tUntung.ToString("C", negara);
            return tUntung;
        }

        public void biayaBangunan()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalKeuntungan();
        }
    }
}
