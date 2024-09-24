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
    public partial class iletisim : Form
    {
        public iletisim()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        baglanti bgl=new baglanti();
        private void iletisim_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from tbl_yetkili",bgl.baglantisql());
            using (SqlDataReader dr = komut.ExecuteReader())
            {
                if (dr.Read())
                {

                    labelad.Text = dr["yetkili_isim"].ToString();
                    labelcep.Text = dr["yetkilitelefon"].ToString();
                    labeldahili.Text = dr["yetkilidahili"].ToString();
                }
                
            }


        }

        
    }
}
