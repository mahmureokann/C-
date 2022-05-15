using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Barbut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        
        private void btnZar1_Click(object sender, EventArgs e)
        {

            int zar1 = rnd.Next(1, 7);
            lblZar1.Text = zar1.ToString();
            btnZar1.Enabled = false;
            btnZar2.Enabled = true;



        }
        decimal cekilecekTutar1;
        decimal katıl1;
        decimal katıl2;
        int zar1;
        int zar2;
        decimal guncelBakiye1 = 500m;
        decimal guncelBakiye2 = 500m;
        decimal sonuc1;
        decimal sonuc2;
        decimal orta;
        decimal toplamPuan;
        decimal toplamPuan2;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            btnZar1.Enabled = false;
            btnZar2.Enabled = false;   
        }

        private void btnOrtaya1_Click(object sender, EventArgs e)
        {
            katıl1 = nudKatıl1.Value;
            guncelBakiye1 -= katıl1;
            lblBakiye.Text = guncelBakiye1.ToString();
            lblOrta.Text = katıl1.ToString();
        }

        private void btnOrtaya2_Click(object sender, EventArgs e)
        {
            katıl2 = nudKatıl2.Value;
            guncelBakiye2 -= katıl2;
            lblBakiye2.Text = guncelBakiye2.ToString();
            lblOrta.Text = katıl2.ToString();
            lblOrta.Text = (katıl1 + katıl2).ToString();
            btnZar1.Enabled = true;

        }
        
        private void btnZar2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int zar2 = rnd.Next(1,7);
            
            lblZar2.Text = zar2.ToString();
           
            btnZar2.Enabled = false;
            sonuc1 = Convert.ToDecimal(lblBakiye.Text);
            orta = Convert.ToDecimal(lblOrta.Text);
            sonuc2 = Convert.ToDecimal(lblBakiye2.Text);

            if (zar1>zar2)
            {
                lblSonuc.Text = "1.Oyuncu Kazandı!";
                guncelBakiye1 += orta;
                lblBakiye.Text = guncelBakiye1.ToString();
                
                
                
            }
           if (zar1==zar2)
           {
                lblSonuc.Text = "Beraberlik!";
                btnZar1.Enabled=true;
                btnZar2.Enabled=true;
                
           }
            if (zar1<zar2) ;
            {
                lblSonuc.Text = "2.Oyuncu Kazandı!".ToString();
                guncelBakiye2 += orta;
                lblBakiye2.Text = guncelBakiye2.ToString();
                
                
                
            }
            
        }
    }
}
