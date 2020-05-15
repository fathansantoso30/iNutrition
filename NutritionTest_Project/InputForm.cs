using Project_myCalorie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionTest_Project
{
    public partial class InputForm : Form
    {
        private KalkulasiIBM bmiCalc = new KalkulasiIBM();
        public InputForm()
        {
            InitializeComponent();
        }
        private void btn_Hasil_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBMI();
            if (ok)
            {
                DisplayResults(); 
            }

        }
        private void ReadNama()
        {
            if (string.IsNullOrEmpty(tb_Nama.Text.Trim()))
            { 
                bmiCalc.SetNama("Tidak Bernama");
            }
            else 
            {
                bmiCalc.SetNama(tb_Nama.Text.Trim());
            }
        }
        private bool ReadTinggi()
        {
            double tinggi = 0;

            bool ok = double.TryParse(tb_TinggiBadan.Text.Trim(), out tinggi);
            if (ok && (tinggi > 0)) 
            {
                bmiCalc.SetTinggi(tinggi / 100.0); 
            }
            else
            {
                MessageBox.Show("Mohon Masukkan Tinggi anda dengan benar!");
                return false;
            }

            return ok;
        } 

        private bool ReadBerat()
        {
            double outValue = 0;
            bool ok = double.TryParse(tb_BeratBadan.Text.Trim(), out outValue);

           
            if (ok && (outValue > 0))
            {
                bmiCalc.SetBerat(outValue);
            }
            else
            {
                MessageBox.Show("Mohon masukkan berat anda dengan benar!");
                return false;
            }

            return ok;
        } 

        private bool ReadInputBMI()
        {
            ReadNama();

            return ReadTinggi() && ReadBerat();
        } 

        private void DisplayResults()
        {
            lbl_Nama.Text = tb_Nama.Text;
            lbl_JenisKelamin.Text = cb_JenisKelamin.Text;
            lbl_Umur.Text = tb_Umur.Text +" Tahun";
            lbl_BMI.Text = bmiCalc.HitungBMI().ToString("f2");
            lbl_Kategori.Text = bmiCalc.BMIKategori().ToString();
            lbl_BeratIdeal.Text = bmiCalc.HitungBerat(18.50).ToString("f2");
            lbl_BeratIdeal2.Text = bmiCalc.HitungBerat(24.9).ToString("f2");
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lbl_Nama.Text = "-";
            lbl_JenisKelamin.Text = "-";
            lbl_Umur.Text = "-";
            lbl_BMI.Text = "-";
            lbl_Kategori.Text = "-";
            lbl_BeratIdeal.Text = "-";
            lbl_BeratIdeal2.Text = "-";

            tb_Nama.Text = "Nama";
            cb_JenisKelamin.Text = "Jenis Kelamin";
            tb_Umur.Text = "Umur";
            tb_BeratBadan.Text = "Berat Badan";
            tb_TinggiBadan.Text = "Tinggi Badan";

        }

        private void btn_Ajukan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sedang Dalam Perbaikan");
        }
    }
}
