using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SayısalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void btnRastgele_Click(object sender, EventArgs e)
        {

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ListBox)
                {
                    ListBox lst = (ListBox)ctrl;
                    lst.Items.Clear();
                   
                    for (int i = 1; i <= 6; i++)
                    {
                        int rastgele = rnd.Next(1, 50);
                        lst.Items.Add(rastgele);


                    }
                }
                


            }
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                {
                    Label lbl = (Label)ctrl;
                    lbl.Text = "";

                    for (int i = 0; i <6; i++)
                    {
                        int rastgele = rnd.Next(1,50);
                        if (lbl.Text == rastgele.ToString())
                        {
                            i--;
                            continue;
                        }
                        else
                        {
                            lbl.Text = rastgele.ToString();
                        }
                    }
                }
            }
        }
    }
}
