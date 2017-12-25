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
    public partial class sayi_kutusu : UserControl
    {
        public sayi_kutusu()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)==false && char.IsControl(e.KeyChar)==false)
            {
                e.Handled = true; //true ysa yaz değilse yazma
            }
        }
    }
}
