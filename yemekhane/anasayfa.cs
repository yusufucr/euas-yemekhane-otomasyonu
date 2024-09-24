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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            iletisim fr= new iletisim();
            fr.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        baglanti bgl = new baglanti();

        private void anasayfa_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from yemek_listesi where tarih=@p1",bgl.baglantisql());
            komut.Parameters.AddWithValue("@p1", dateTimePicker1.Value.Date);
            using (SqlDataReader dr = komut.ExecuteReader())
            {
                if (dr.Read())
                {
                    
                    labelyemek1.Text = dr["yemek1"].ToString();
                    labelyemek2.Text = dr["yemek2"].ToString();
                    labelyemek3.Text = dr["yemek3"].ToString();
                    labelyemek4.Text = dr["yemek4"].ToString();
                }
                else
                {
                    
                    labelyemek1.Text = "-----";
                    labelyemek2.Text = "------";
                    labelyemek3.Text = "-----";
                    labelyemek4.Text = "-----";
                }
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from yemek_listesi where tarih=@p1", bgl.baglantisql());
            komut.Parameters.AddWithValue("@p1", dateTimePicker1.Value.Date);
            using (SqlDataReader dr = komut.ExecuteReader())
            {
                if (dr.Read())
                {
                    
                    labelyemek1.Text = dr["yemek1"].ToString();
                    labelyemek2.Text = dr["yemek2"].ToString();
                    labelyemek3.Text = dr["yemek3"].ToString();
                    labelyemek4.Text = dr["yemek4"].ToString();
                }
                else
                {
                    
                    labelyemek1.Text = "-----";
                    labelyemek2.Text = "------";
                    labelyemek3.Text = "-----";
                    labelyemek4.Text = "-----";
                }
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            duyurular fr = new duyurular();
            fr.Show();
        }
    }
}
