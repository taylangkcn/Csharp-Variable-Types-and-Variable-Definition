using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class sifre_kontrol : UserControl
    {
        public sifre_kontrol()
        {
            InitializeComponent();
        }
        private string kul_adi;
        private string sifre;

        public string Kul_adi
        {//özellik penceresine gelicek.
            get { return kul_adi; }
            set { kul_adi = value; }
        }

        public  string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }





        private void giris_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==kul_adi&&textBox2.Text==sifre)
            {
                MessageBox.Show("Hoşgeldin");
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptın");
            }
        }
    }
}
