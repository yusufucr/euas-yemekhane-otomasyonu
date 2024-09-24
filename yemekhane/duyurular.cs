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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yemekhane
{
    public partial class duyurular : Form
    {
        public duyurular()
        {
            InitializeComponent();
        }

        baglanti bgl = new baglanti();

        private void duyurular_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from duyurular", bgl.baglantisql());
            using (SqlDataReader dr = komut.ExecuteReader())
            {
                while (dr.Read())
                {

                    listBox1.Items.Add(dr["duyuru"].ToString());

                }

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
