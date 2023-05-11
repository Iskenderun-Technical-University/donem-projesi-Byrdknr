using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // sql baglantısı
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace byrdknr_hastane_otomasyon
{
    public partial class Form3 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adaptor;
        public DataSet ds = new DataSet();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            doktorBolumEkle();
        }
        public void textTemizle()
        {
            for(int i = 0; i < this.Controls.Count;i++)
            {
                if (this.Controls[i] is System.Windows.Forms.ComboBox) this.Controls[i].Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//geri buttonu
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {// randevu kayıt buttonu
            
            MessageBox.Show("RANDEVUNUZ BAŞARIYLA OLUŞTURULMUŞTUR", "RANDEVU BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textTemizle();
        }

        void doktorBolumEkle()
        {
            comboBox1.Items.Add("Pedoloji");
            comboBox1.Items.Add("Genel Cerrahisi");
            comboBox1.Items.Add("Dermatoloji");
            comboBox1.Items.Add("Nefroloji");
            comboBox1.Items.Add("Göğüs Hastalıkları");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string selectedItem = comboBox1.SelectedItem.ToString();

            switch(selectedItem)
            {
                case "Pedoloji":
                    comboBox2.Items.Add("Kasım Ada");
                    comboBox2.Items.Add("Mehmet Çınar");

                    break;

                case "Dermatoloji":
                    comboBox2.Items.Add("Tolga Ay");
                    comboBox2.Items.Add("Ulaş Çoban");

                    break;
                case "Genel Cerrahisi":
                    comboBox2.Items.Add("Akiif Yıldız");
                    comboBox2.Items.Add("Talha Sağır");
                    break;
                case "Nefroloji":
                    comboBox2.Items.Add("Enes Belibağlı");
                    comboBox2.Items.Add("Yusuf Gümüşbaş");
                      
                    break;
                case "Göğüs Hastalıkları":
                    comboBox2.Items.Add("Salih Kaçar");
                    comboBox2.Items.Add("Alperen Armut");

                    break;


            }
        }
    }
}
