using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace byrdknr_hastane_otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {// giriş buttonu

            string sifre = "asdf1234";
            string tcno = "123456";
            if (textBox1.Text.Trim() == String.Empty || textBox2.Text.Trim() == String.Empty)
            {
                MessageBox.Show("LÜTFEN BOŞLUKLARI DOLDURUZ","GEREKLİ ALANLARI DOLDURUNUZ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if (textBox1.Text == tcno && textBox2.Text ==sifre)
                {
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("KULLANICININ T.C. VEYA ŞİFRESİ HATALIDIR", "HATALI GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar= '*';
        }
        
        private void Form1_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}