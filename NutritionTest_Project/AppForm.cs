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
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private void btn_Closes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TestStatus_Click(object sender, EventArgs e)
        {
            InputForm inputform = new InputForm();
            inputform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMakanan formmakanan = new FormMakanan();
            formmakanan.ShowDialog();
        }

        private void btn_Developer_Click(object sender, EventArgs e)
        {
            Developer developer = new Developer();
            developer.ShowDialog();
        }

        private void btn_Closes_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
