using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace racfollow
{
    public partial class addcar : Form
    {
        public addcar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=racfollow_maindb;Integrated Security=True");
        private void carid_Click(object sender, EventArgs e)
        {

        }

        private void arabaekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into arabalar_bilgi(marka,model,sanziman,plaka,yakitturu,renk,uretimyili,kilometre,kiraucreti) values (@marka,@model,@sanziman,@plaka,@yakitturu,@renk,@uretimyili,@kilometre,@kiraucreti)", baglanti);
            komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut2.Parameters.AddWithValue("@model", txtModel.Text);
            komut2.Parameters.AddWithValue("@sanziman", txtSanziman.Text);
            komut2.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut2.Parameters.AddWithValue("@yakitturu", txtYakitturu.Text);
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@uretimyili", txtUretimyili.Text);
            komut2.Parameters.AddWithValue("@kilometre", txtKilometre.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", txtKiraucreti.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Araba Kaydı Eklendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void Add_Cargb_Enter(object sender, EventArgs e)
        {

        }
    }
}
