using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_myCalorie
{
    class KalkulasiIBM
    {
        #region Variabel
        private string nama = "Tidak Bernama";
        private double tinggi = 0;
        private double berat = 0;
        #endregion

        #region Getter
        public string GetNama()
        {
            return nama;
        }
        public double GetTinggi()
        {
            return tinggi;
        }
        public double GetBerat()
        {
            return berat;
        }
        #endregion

        #region Setter
        public void SetNama(string value)
        {
            // Before setting the name, make sure it is valid
            if (!string.IsNullOrEmpty(value))
            {
                nama = value;
            }
        }
        public void SetTinggi(double value)
        {
            if (value > 0)
            {
                tinggi = value;
            }
        }
        public void SetBerat(double value)
        {
            // Weight must be greater than zero
            if (value > 0)
            {
                berat = value;
            }
        }
        #endregion

        public string BMIKategori()
        {
            // Calculate the BMI
            double bmi = HitungBMI();

            // Based on the BMI Range
            // Return Category
            if (bmi > 40)
            {
                return "Overweight (Obesitas kelas III)";
            }
            else if (35.0 <= bmi)
            {
                return "Overweight (Obesitas kelas II)";
            }
            else if (30.0 <= bmi)
            {
                return "Overweight (Obesitas kelas I)";
            }
            else if (25.0 <= bmi)
            {
                return "Overweight (Pra-Obesitas)";
            }
            else if (18.5 <= bmi)
            {
                return "Normal weight";
            }
            else
            {
                return "Underweight";
            }
        } // end of BMIKategori()

        public double HitungBMI()
        {
            double bmi = 0.0;
            bmi = berat / (tinggi * tinggi);

            return bmi;
        } // end of HitungBMI()

        public double HitungBerat(double bmi)
        {
            double berat = 0.0;
            berat = bmi * (this.GetTinggi() * this.GetTinggi());
            return berat;
        } // end of HitungBerat(double bmi)

    }
}
