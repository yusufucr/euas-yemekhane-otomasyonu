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
    public partial class yetkili_anasayfa : Form
    {
        public yetkili_anasayfa()
        {
            InitializeComponent();
        }

        baglanti bgl = new baglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert  into  yemek_listesi (tarih,yemek1,yemek2,yemek3,yemek4) values  (@p1,@p2,@p3,@p4,@p5)", bgl.baglantisql());
            komut.Parameters.AddWithValue("@p1", dateTimePicker1.Value.Date);
            komut.Parameters.AddWithValue("@p2", textBoxy1.Text);
            komut.Parameters.AddWithValue("@p3", textBoxy2.Text);
            komut.Parameters.AddWithValue("@p4", textBoxy3.Text);
            komut.Parameters.AddWithValue("@p5", textBoxy4.Text);
            komut.ExecuteNonQuery();
            bgl.baglantisql().Close();
            MessageBox.Show("Kayıt Başarılı");
            textBoxy1.Text = "";
            textBoxy2.Text = "";
            textBoxy3.Text = "";
            textBoxy4.Text = "";


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("select * from yemek_listesi where tarih=@p1", bgl.baglantisql());
            komut.Parameters.AddWithValue("@p1", dateTimePicker1.Value.Date);
            using (SqlDataReader dr = komut.ExecuteReader())
            {
                if (dr.Read())
                {

                    textBoxy1.Text = dr["yemek1"].ToString();
                    textBoxy2.Text = dr["yemek2"].ToString();
                    textBoxy3.Text = dr["yemek3"].ToString();
                    textBoxy4.Text = dr["yemek4"].ToString();
                }
                else
                {

                    textBoxy1.Text = "";
                    textBoxy2.Text = "";
                    textBoxy3.Text = "";
                    textBoxy4.Text = "";


                }




            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("UPDATE yemek_listesi SET yemek1=@p1,yemek2=@p2,yemek3=@p3,yemek4=@p4 WHERE tarih=@p5", bgl.baglantisql());
            komut.Parameters.AddWithValue("@p1",textBoxy1.Text);
            komut.Parameters.AddWithValue("@p2", textBoxy2.Text);
            komut.Parameters.AddWithValue("@p3", textBoxy3.Text);
            komut.Parameters.AddWithValue("@p4", textBoxy4.Text);
            komut.Parameters.AddWithValue("@p5", dateTimePicker1.Value.Date);

            komut.ExecuteNonQuery();
            bgl.baglantisql().Close();

            MessageBox.Show("Liste Güncellendi");
            

        }

        private void buttonduyuru_Click(object sender, EventArgs e)
        {

            duyuruekle fr = new duyuruekle();
            fr.Show();


        }


    }
}
