using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yemekhane
{
    public partial class acilisekrani : Form
    {
        public acilisekrani()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           personelgiris fr= new personelgiris();
            fr.Show();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            kayitol fr= new kayitol();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yetkiligiris fr=new yetkiligiris();
            fr.Show();
        }
    }
}
