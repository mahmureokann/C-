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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnMenuOlustur_Click(object sender, EventArgs e)
        {
            if (txtMenu.Text != "" && nudMenuFiyat.Value>0)
            {
                Menuler burgerMenu = new Menuler();
                burgerMenu.Ad = txtMenu.Text;
                burgerMenu.Fiyat = Convert.ToInt32(nudMenuFiyat.Value);
                Menuler.menuListesi.Add(burgerMenu);
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün ve fiyat ekle!");
            }


            if (txtEkstra.Text!=""&& nudEkstraFiyat.Value>0)
            {
                Ekstralar ekstra = new Ekstralar();
                ekstra.Ad = txtEkstra.Text;
                ekstra.Fiyat = Convert.ToInt32(nudEkstraFiyat.Value);
                Ekstralar.ekstraListesi.Add(ekstra);
            }
            else
            {
                MessageBox.Show("Lütfen bir ekstra ve fiyat ekle!");
            }

           
            

            
            
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
