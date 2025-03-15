namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double boy, kilo;
        double sonuc;
        string cinsiyet;

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Boy ve Kilo boþ mu kontrolü
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Lütfen Boy ve Kilo Deðerlerini Giriniz!");
                return;
            }

            // Boy ve Kilo verilerini al
            boy = Convert.ToDouble(textBox1.Text);
            kilo = Convert.ToDouble(textBox2.Text);
            sonuc = kilo / (boy * boy);

            // VKÝ hesaplamalarý
            if (sonuc < 18.5)
            {
                MessageBox.Show("VKÝ Sonucunuz : Zayýf");
            }
            else if (sonuc >= 18.5 && sonuc <= 24.9)
            {
                MessageBox.Show("VKÝ Sonucunuz : Normal");
            }
            else if (sonuc >= 25 && sonuc <= 29.9)
            {
                MessageBox.Show("VKÝ Sonucunuz : Kilolu");
            }
            else
            {
                MessageBox.Show("VKÝ Sonucunuz : Obez");
            }

            // VKÝ deðerini göster
            label3.Text = "VKÝ Deðeriniz = " + sonuc.ToString("0.000");

            // Boy deðeri boþsa uyarý
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Lütfen Boy Deðeri Giriniz!");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Tüm alanlarý temizle
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
            textBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string AdSoyad = textBox3.Text;

            // Cinsiyet kontrolü
            if (radioButton2.Checked)
            {
                cinsiyet = "Kadýn";
            }
            else if (radioButton1.Checked)
            {
                cinsiyet = "Erkek";
            }
            else
            {
                MessageBox.Show("Lütfen Cinsiyet Seçiniz!");
                return;
            }

            // ListBox'a ekleme
            listBox1.Items.Add(AdSoyad + " Cinsiyet: " + cinsiyet + " VKÝ DEÐERÝ: " + sonuc.ToString("0.000"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ListBox'ý temizle
            listBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoþgeldiniz! VKÝ Takip-Kayýt v1.0 - Uygulama geliþtirme aþamasýndadýr.",
                   "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
