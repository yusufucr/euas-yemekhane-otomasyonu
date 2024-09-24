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
    public partial class duyuruekle : Form
    {
        public duyuruekle()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        baglanti bgl=new baglanti();    

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("insert into duyurular (duyuru) values (@p1) ",bgl.baglantisql());
            komut.Parameters.AddWithValue("@p1", richTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglantisql().Close();
            MessageBox.Show("Kayıt Başarılı");
            this.Hide();


        }
    }
}
