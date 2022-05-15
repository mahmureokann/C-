using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_CalculatorTryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sayi1;
        double sayi2;
        double sonuc;
        private void Form1_Load(object sender, EventArgs e)
        {
            lblHata.Visible = false;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            try
            {
                sayi1 = Convert.ToInt32(txtSayi1.Text);
                sayi2 = Convert.ToInt32(txtSayi2.Text);
                sonuc = sayi1 + sayi2;
                string format = "toplama işlemi :" + sonuc;
                listBox1.Items.Add(format);
                lblSonuc.Text = sonuc.ToString();
            }
            catch (FormatException ex)
            {
                lblHata.Visible = true;
                lblHata.Text = ex.Message;
                listBox2.Items.Add(txtSayi1.Text + " " + txtSayi2.Text + " " + ex.Message);
            }
            catch(OverflowException ex)
            {
                lblHata.Visible = true;
                lblHata.Text = ex.Message;
                listBox2.Items.Add(txtSayi1.Text + " " + txtSayi2.Text + " " + ex.Message);
            }
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            try
            {
                sayi1 = Convert.ToInt32(txtSayi1.Text);
                sayi2 = Convert.ToInt32(txtSayi2.Text);
                sonuc = sayi1 - sayi2;
                string format = "çıkarma işlemi :" + sonuc;
                listBox1.Items.Add(format);
                lblSonuc.Text = sonuc.ToString();
            }
            catch(Exception ex)
            {
                lblHata.Visible = true;
                lblHata.Text = ex.Message;
                listBox2.Items.Add(txtSayi1.Text + " " + txtSayi2.Text + " " + ex.Message);
            }
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            try
            {
                sayi1 = Convert.ToInt32(txtSayi1.Text);
                sayi2 = Convert.ToInt32(txtSayi2.Text);
                sonuc = sayi1 * sayi2;
                string format = "çarpma işlemi :" + sonuc;
                listBox1.Items.Add(format);
                lblSonuc.Text = sonuc.ToString();
            }
            catch (Exception ex)
            {
                lblHata.Visible = true;
                lblHata.Text = ex.Message;
                listBox2.Items.Add(txtSayi1.Text + " " + txtSayi2.Text + " " + ex.Message);
            }
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            //işlem sonucu eğer ondalıklı bir veri dönecekse dönüştürme işlemiini "double" tipinde tanımlamak daha mantıklı olacaktır. Örn aşağıdaki gibi...
            try
            {
                sayi1 = Convert.ToDouble(txtSayi1.Text);
                sayi2 = Convert.ToDouble(txtSayi2.Text);
                sonuc = sayi1 / sayi2;
                string format = "bölme işlemi :" + sonuc;
                listBox1.Items.Add(format);
                lblSonuc.Text = sonuc.ToString();
            }
            catch (Exception ex)
            {
                lblHata.Visible = true;
                lblHata.Text = ex.Message;
                listBox2.Items.Add(txtSayi1.Text + " " + txtSayi2.Text + " " + ex.Message);
            }
        }

        private void lblSonuc_Click(object sender, EventArgs e)
        {

        }
    }
}
