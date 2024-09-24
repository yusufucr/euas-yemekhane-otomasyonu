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
    public partial class personelgiris : Form
    {
        public personelgiris()
        {
            InitializeComponent();
        }

        private void personelgiris_Load(object sender, EventArgs e)
        {

        }

        baglanti bgl = new baglanti();
        private void button1_Click(object sender, EventArgs e)
        {
           
                SqlCommand komut = new SqlCommand("select * from kullanicilar where eposta = @p1 and sifre = @p2", bgl.baglantisql());   
                komut.Parameters.AddWithValue("@p1", textBoxeposta.Text);
                komut.Parameters.AddWithValue("@p2", textBoxsifre.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    anasayfa frm = new anasayfa();
                    
                    frm.Show();                                      
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı E-Posta veya Şifre!!!");         
                }
                bgl.baglantisql().Close();
            
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            kayitol fr=new kayitol();
            fr.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            sifremi_unuttum fr=new sifremi_unuttum();
            fr.Show();
        }
    }
}
