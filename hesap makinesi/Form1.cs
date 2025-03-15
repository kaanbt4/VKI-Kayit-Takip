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
            // Boy ve Kilo bo� mu kontrol�
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("L�tfen Boy ve Kilo De�erlerini Giriniz!");
                return;
            }

            // Boy ve Kilo verilerini al
            boy = Convert.ToDouble(textBox1.Text);
            kilo = Convert.ToDouble(textBox2.Text);
            sonuc = kilo / (boy * boy);

            // VK� hesaplamalar�
            if (sonuc < 18.5)
            {
                MessageBox.Show("VK� Sonucunuz : Zay�f");
            }
            else if (sonuc >= 18.5 && sonuc <= 24.9)
            {
                MessageBox.Show("VK� Sonucunuz : Normal");
            }
            else if (sonuc >= 25 && sonuc <= 29.9)
            {
                MessageBox.Show("VK� Sonucunuz : Kilolu");
            }
            else
            {
                MessageBox.Show("VK� Sonucunuz : Obez");
            }

            // VK� de�erini g�ster
            label3.Text = "VK� De�eriniz = " + sonuc.ToString("0.000");

            // Boy de�eri bo�sa uyar�
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("L�tfen Boy De�eri Giriniz!");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // T�m alanlar� temizle
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

            // Cinsiyet kontrol�
            if (radioButton2.Checked)
            {
                cinsiyet = "Kad�n";
            }
            else if (radioButton1.Checked)
            {
                cinsiyet = "Erkek";
            }
            else
            {
                MessageBox.Show("L�tfen Cinsiyet Se�iniz!");
                return;
            }

            // ListBox'a ekleme
            listBox1.Items.Add(AdSoyad + " Cinsiyet: " + cinsiyet + " VK� DE�ER�: " + sonuc.ToString("0.000"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ListBox'� temizle
            listBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Ho�geldiniz! VK� Takip-Kay�t v1.0 - Uygulama geli�tirme a�amas�ndad�r.",
                   "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
