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
    public partial class yetkiligiris : Form
    {
        public yetkiligiris()
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

            SqlCommand komut = new SqlCommand("select * from tbl_yetkili where yetkilieposta=@p1 and yetkilisifre=@p2",bgl.baglantisql());
            komut.Parameters.AddWithValue("@p1",textBoxeposta.Text);
            komut.Parameters.AddWithValue("@p2", textBoxsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                yetkili_anasayfa frm = new yetkili_anasayfa();

                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı E-Posta veya Şifre!!!");
            }
            bgl.baglantisql().Close();

        }
    }
}
