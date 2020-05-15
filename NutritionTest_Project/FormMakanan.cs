using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionTest_Project
{
    public partial class FormMakanan : Form
    {
        DataTable dt;
        public FormMakanan()
        {
            InitializeComponent();
        }

        private void btn_Cari_Click(object sender, EventArgs e)
        {
            lb_Berat.Text = "-";
            lbl_Protein.Text = "-";
            lbl_Lemak.Text = "-";
            lbl_Karbo.Text = "-";
            lbl_Kalori.Text = "-";

             for (int i = 0; i < 22; i++)
            {
                if (cb_Cari.SelectedItem.ToString() == dt.Rows[i].Field<string>("NamaMakanan"))
                {
                    
                    lb_Berat.Text = dt.Rows[i].Field<string>("Berat");
                    lbl_Kalori.Text = dt.Rows[i].Field<string>("Kalori");
                    lbl_Karbo.Text = dt.Rows[i].Field<string>("Karbohidrat");
                    lbl_Protein.Text = dt.Rows[i].Field<string>("Protein");
                    lbl_Lemak.Text = dt.Rows[i].Field<string>("Lemak");

                    break;
                }
            }
            

        }


        private void btn_Closess_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FormMakanan_Load(object sender, EventArgs e)
        {
            // Connection Object
            SQLiteConnection con = new SQLiteConnection(@"Data Source = .\data.db");
            con.Open();
            // Commond Object
            string query = "SELECT * from tabelMakanan";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            // adapter
            // datatable
            dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
        }


        
    }
}
