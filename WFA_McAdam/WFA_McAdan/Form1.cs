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
    internal partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string menu = "";
        string boy = "";
        string adet = "";
        string ekstra = "";
      
        int gelenDeger = 0;

        int toplamFiyat = 0;
        int genelFiyat=0;
        int toplam =0;
        internal void Form1_Load(object sender, EventArgs e)
        {
            foreach (Menuler menu in Menuler.menuListesi)
            {
                cmbMenu.Items.Add(menu);
            }
            foreach (Ekstralar ekstra in Ekstralar.ekstraListesi)
            {
                cmbEkstra.Items.Add(ekstra);
            }
            //cmbMenu.DataSource = Menuler.menuListesi.ToList();
            //cmbEkstra.DataSource = Ekstralar.ekstraListesi.ToList();

            btnHesapla.Enabled = false;
            cmbMenu.Items.Add("Whooper Menü");
            cmbMenu.Items.Add("Bigman Menü");
            cmbMenu.Items.Add("Bilge Adam Menü");
        }
        void Menu()
        {
            if (cmbMenu.SelectedItem == "Whooper Menü")
            {
                // listBox1.Items.Add("Whooper Menü: 25TL");
                menu = "Whooper Menü: 25TL";
                toplamFiyat += 25;
                lblToplam.Text = toplamFiyat.ToString();
            }
            else if (cmbMenu.SelectedItem == "Bigman Menü")
            {
                //listBox1.Items.Add("Bigman Menü: 35TL");
                menu = "Bigman Menü: 35TL";
                toplamFiyat += 35;
                lblToplam.Text = toplamFiyat.ToString();
            }
            else if (cmbMenu.SelectedItem == "Bilge Adam Menü")
            {
                //listBox1.Items.Add("Bilge Adam Menü: 20TL");
                menu = "Bilge Adam Menü: 20TL";
                toplamFiyat += 20;
                lblToplam.Text = toplamFiyat.ToString();
            }
            else if (cmbMenu.SelectedItem != "")
            {
                menu = "";
                toplamFiyat += 0;
                lblToplam.Text = toplamFiyat.ToString();
            }
            else
            {
                DialogResult dr = MessageBox.Show("En az bir adet menü seçilmesi gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        void Boy()
        {
            if (rbKucuk.Checked == true)
            {
                // listBox1.Items.Add("Küçük boy seçildi.");
                boy = "Küçük";
                toplamFiyat += 0;


            }
            else if (rbOrta.Checked == true)
            {
                //listBox1.Items.Add("Orta boy seçildi. +3TL eklendi.");
                boy = "Orta";
                toplamFiyat += 3;
                lblToplam.Text = toplamFiyat.ToString();

            }
            else if (rbBuyuk.Checked == true)
            {
                // listBox1.Items.Add("Büyük boy seçildi. +5TL eklendi.");
                boy = "Büyük";
                toplamFiyat += 5;
                lblToplam.Text = toplamFiyat.ToString();

            }
          

        }
        void Ekstra()
        {
            if (chkBuffalo.Checked)
            {
                ekstra += "Buffalo sos ";
                //listBox1.Items.Add("Buffalo Sos: 2TL");
                toplamFiyat += 2;
                lblToplam.Text = toplamFiyat.ToString();

            }
            if (chkChaddar.Checked == true)
            {
                ekstra += "Chaddar ";
               // listBox1.Items.Add("Chaddar: 2TL");
                toplamFiyat += 2;

            }
            if (chkKetcap.Checked == true)
            {
                ekstra += "Ketçap ";
                //listBox1.Items.Add("Ketçap: 2TL");
                toplamFiyat += 2;

            }
            if (chkMayonez.Checked == true)
            {
                ekstra += "Mayonez ";
               // listBox1.Items.Add("Mayonez: 2TL");
                toplamFiyat += 2;

            }
            if (chkRanch.Checked == true)
            {
                ekstra += "Ranch ";
                //listBox1.Items.Add("Ranch Sos: 2TL");
                toplamFiyat += 2;

            }
            if (chkSMayonez.Checked == true)
            {
                ekstra += "Sarımsaklı Mayonez ";
                //listBox1.Items.Add("Sarımsaklı Mayonez: 2TL");
                toplamFiyat += 2;

            }

        }
        void Adet()
        {
            int gelenDeger = Convert.ToInt32(nudAdet.Value.ToString());
            if (gelenDeger > 0)
            {
                adet = "Sipariş Adeti: " + gelenDeger;
                //listBox1.Items.Add("Sipariş Adeti: " + gelenDeger);
                toplamFiyat = gelenDeger * toplamFiyat;
                toplam += toplamFiyat;
                lblToplam.Text = toplam.ToString();
                
                string format = string.Format("{0},{1},{2},{3},{4}", menu, boy, ekstra, adet, toplamFiyat);
                listBox1.Items.Add(format);
                menu = "";
                boy = "";
                ekstra = "";
                adet = "";
                toplamFiyat = 0;

            }
            else
            {
                //MessageBox.Show("");
                DialogResult dr = MessageBox.Show("Lütfen adet giriniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                


            }
        }


        private void btnHesapla_Click(object sender, EventArgs e)
        {
          
                //menü
                Menu();

                //Radio Button BOY
                Boy();

                //CheckBox EKSTRA
                Ekstra();

                //Adet
                Adet();


        }

        private void rbKucuk_CheckedChanged(object sender, EventArgs e)
        {
            btnHesapla.Enabled = rbKucuk.Checked;

        }

        private void rbOrta_CheckedChanged(object sender, EventArgs e)
        {
            btnHesapla.Enabled = rbOrta.Checked;
        }

        private void rbBuyuk_CheckedChanged(object sender, EventArgs e)
        {
            btnHesapla.Enabled = rbBuyuk.Checked;
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            //Girilen verilerin listviewe eklenmesi...

            ListViewItem lvi = new ListViewItem();
            lvi.Text = cmbMenu.Text;
            if (rbBuyuk.Checked)
            {
                lvi.SubItems.Add(rbBuyuk.Text);
            }
            else if (rbOrta.Checked)
            {
                lvi.SubItems.Add(rbOrta.Text);
            }
            else if (rbKucuk.Checked)
            {
                lvi.SubItems.Add(rbKucuk.Text);
            }
            //Ekstralar
            if (chkKetcap.Checked)
            {
                lvi.SubItems.Add(chkKetcap.Text);
            }
            else if (chkBuffalo.Checked)
            {
                lvi.SubItems.Add(chkBuffalo.Text);
            }
            else if (chkChaddar.Checked)
            {
                lvi.SubItems.Add(chkChaddar.Text);
            }
            else if (chkMayonez.Checked)
            {
                lvi.SubItems.Add(chkMayonez.Text);
            }
            else if (chkRanch.Checked)
            {
                lvi.SubItems.Add(chkRanch.Text);
            }
            else if (chkSMayonez.Checked)
            {
                lvi.SubItems.Add(chkSMayonez.Text);
            }
            lvi.SubItems.Add(nudAdet.Value.ToString());
            lvi.SubItems.Add(lblToplam.Text);

            listView1.Items.Add(lvi);

            genelFiyat = Convert.ToInt32(lblGenelToplam.Text);

            lblGenelToplam.Text = toplamFiyat.ToString();
            toplamFiyat -= genelFiyat;
            lblToplam.Text = "0";
           

        }

        private void btnAdminFormü_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
                this.Hide();
        }
    }


}
