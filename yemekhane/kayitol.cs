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
    public partial class kayitol : Form
    {
        public kayitol()
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
            SqlCommand komut = new SqlCommand("insert into kullanicilar (eposta,sifre,tc) values (@p1,@p2,@p3) ",bgl.baglantisql());
            komut.Parameters.AddWithValue("@p1", kullanicieposta.Text);
            komut.Parameters.AddWithValue("@p2", kullanicisifre.Text);
            komut.Parameters.AddWithValue("@p3", kullanicitc.Text);
            komut.ExecuteNonQuery();
            bgl.baglantisql().Close();
            MessageBox.Show("Kayıt Başarılı");
            this.Hide();

            

        }

        
    }
}
