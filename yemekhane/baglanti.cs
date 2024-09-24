using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace yemekhane
{
    internal class baglanti
    {
        public SqlConnection baglantisql()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-8HEO5MMP\\SQLEXPRESS01;Initial Catalog=euas;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
