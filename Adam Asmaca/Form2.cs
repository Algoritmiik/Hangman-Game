using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_Asmaca
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form3 frm3 = new Form3();
        string[] kelimeler = { "GALATA", "CİMBOM", "WESLEY", "FALCAO", "LEMİNA", "KEWELL", "DROGBA", "YILDIZ", "AĞLAMA", "KAZDAL" };
        Random rnd = new Random();
        int rastgele, sayac1 = 0, sayac2 = 0, yanlis = 1;
        public static int puan = 0;
        char[] kelime;
        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Form1 frm1 = new Form1();
            rastgele = rnd.Next(0, 10);
            kelime = kelimeler[rastgele].ToCharArray();
            label2.Text = Form1.ad;
            label4.Text = kelime[0].ToString(); label5.Text = kelime[1].ToString(); label6.Text = kelime[2].ToString(); label7.Text = kelime[3].ToString(); label8.Text = kelime[4].ToString(); label9.Text = kelime[5].ToString();
            label4.Hide(); label5.Hide(); label6.Hide(); label7.Hide(); label8.Hide(); label9.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var lbl in Controls.OfType<Label>())
            {
                if (lbl.Text == textBox1.Text)
                {
                    lbl.Show();
                    sayac1++;
                    puan += 100;
                    if (puan == 600)
                    {
                        textBox1.Hide();
                        frm3.Show();
                    }
                }
            }
            if (sayac1 > sayac2)
            {
                sayac2 = sayac1;
            }
            else
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\" + yanlis + ".jpeg");
                yanlis++;
                if (yanlis == 8)
                {
                    textBox1.Hide();
                    frm3.Show();
                }
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
