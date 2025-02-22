using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] yemekler = { "İskender", "Kebap", "Köfte", "Tavuk Pilav", "Tantuni", "Beyti" };
            foreach(string Y in yemekler)
            {
                listBox1.Items.Add(Y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayi = { 1, 2, 4, 7, 8, 5, 99, 67, 56, 46, 44, 24, 64, 56, 34, 12, 128, 216, 512, 521, 1000 };
            int toplam = 0;

            foreach(int S in sayi)
            {
                if(S % 4 == 0 && S < 100)
                {
                    listBox2.Items.Add(S);
                    toplam = toplam + S;
                }
            }
            label1.Text = "Toplamı = " + toplam;
        }
    }
}
