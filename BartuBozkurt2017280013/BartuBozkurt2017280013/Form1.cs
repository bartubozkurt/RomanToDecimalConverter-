using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BartuBozkurt2017280013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);
            int birler = 0, onlar = 0, yuzler = 0, binler = 0;

            if (sayi < 10)
                birler = sayi;

            if(sayi > 9 && sayi < 100)
            {
                onlar = sayi / 10;
                birler = sayi - (onlar * 10);
            }
            if(sayi > 99 && sayi < 1000)
            {
                yuzler = sayi / 100;
                onlar = (sayi - (yuzler * 100)) / 10;
                birler = sayi - ((yuzler * 100) + (onlar * 10));
            }
            if(sayi>999 && sayi < 10000)
            {
                binler = sayi / 1000;
                yuzler = (sayi - (binler * 1000)) / 100;
                onlar = (sayi - ((binler * 1000) + (yuzler * 100))) / 10;
                birler = sayi % 10;
            }
            string[] dbirler = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] donlar = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] dyuzler = { "", "C", "CC","CCC","CD","D","DC","DCC","DCCC","CM"};
            string[] dbinler = { "", "M", "MM", "MMM" };
            label3.Text += dbinler[binler] + " ";
            label3.Text += dyuzler[yuzler] + " ";
            label3.Text += donlar[onlar];
            label3.Text += " " + dbirler[birler];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string rs = textBox2.Text;
            int sayi = 0, k1 = 0, k2, k3;
            for (int i = 0; i < rs.Length; i++)
            {
                k2 = k1;

                switch (rs[i])
                {
                    case 'I': k1 = 1;    break;
                    case 'V': k1 = 5;    break;
                    case 'X': k1 = 10;   break;
                    case 'L': k1 = 50;   break;
                    case 'C': k1 = 100;  break;
                    case 'D': k1 = 500;  break;
                    case 'M': k1 = 1000; break;
                    default:
                        break;
                }
                if (k1 > k2)
                {
                    k3 = -2 * k2;
                }
                else
                {
                    k3 = 0;
                }
                sayi += k1 + k3;
            }
            label6.Text = sayi.ToString();
        }
    }
}
