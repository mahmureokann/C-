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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        List<Kullanici> kullaniciList = new List<Kullanici>()
        {
            new Kullanici{KullaniciAd = "mahmure", KullaniciSifre = "1234", Role=Role.kullanici},
            new Kullanici{KullaniciAd = "okan",KullaniciSifre ="1234", Role=Role.admin}
        };


        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAd.Text.ToLower();
            string kullaniciSifre = txtSifre.Text;

            foreach (Kullanici kullanici in kullaniciList)
            {
                if (kullanici.KullaniciAd == kullaniciAdi && kullanici.KullaniciSifre == kullaniciSifre)
                {
                    switch (kullanici.Role)
                    {
                        case Role.admin:
                            AdminForm aForm = new AdminForm();
                            aForm.Show();
                            this.Hide();
                            break;
                        case Role.kullanici:
                            Form1 form1 = new Form1();
                            form1.Show();
                            this.Hide();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
