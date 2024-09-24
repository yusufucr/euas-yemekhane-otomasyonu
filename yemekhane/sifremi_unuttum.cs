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

namespace yemekhane
{
    public partial class sifremi_unuttum : Form
    {
        public sifremi_unuttum()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        baglanti bgl=new baglanti();
        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("UPDATE kullanicilar SET sifre=@p1 WHERE tc=@p2", bgl.baglantisql());
            komut.Parameters.AddWithValue("@p1", kullanicisifre.Text);
            komut.Parameters.AddWithValue("@p2", kullanicitc.Text);

            komut.ExecuteNonQuery();
            bgl.baglantisql().Close();

            MessageBox.Show("Şifre Değiştirildi");
            this.Close();


        }
    }
}
