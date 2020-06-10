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
    public partial class Form1 : Form
    {
        Form2 frm2 = new Form2();
        public static string ad;

        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ad = textBox1.Text;
            frm2.Show();
        }
    }
}
