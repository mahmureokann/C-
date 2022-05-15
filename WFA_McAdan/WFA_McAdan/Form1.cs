using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string format
            
            string menu = "whooper";
            string ebat = "orta";
            string ekstralar = "(ketçap mayonez)";
            decimal fiyat = 30;
            string format = string.Format("{0} {1} {2} {3}TL", menu,ebat,ekstralar,fiyat);
        }
    }
}
