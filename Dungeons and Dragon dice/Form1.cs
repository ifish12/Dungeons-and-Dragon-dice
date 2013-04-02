using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeons_and_Dragon_dice
{
    public partial class Form1 : Form
    {
        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            Random D4Rand = new Random();
            int D4 = D4Rand.Next(1, 5);

            label1.Text = D4.ToString();
        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            Random D6Rand = new Random();
            int D6 = D6Rand.Next(1, 7);

            label2.Text = D6.ToString();
        }

        private void btnD20_Click(object sender, EventArgs e)
        {
            Random D20Rand = new Random();
            int D20 = D20Rand.Next(1, 21);

            label3.Text = D20.ToString();
        }

        private void btnD10_Click(object sender, EventArgs e)
        {
            Random D10Rand = new Random();
            int D10 = D10Rand.Next(1, 11);

            label4.Text = D10.ToString();
        }

        private void btnD12_Click(object sender, EventArgs e)
        {
            Random D12Rand = new Random();
            int D12 = D12Rand.Next(1, 13);

            label5.Text = D12.ToString();
        }

        
        

        private void btnD8_Click(object sender, EventArgs e)
        {
            Random D8Rand = new Random();
            int D8 = D8Rand.Next(1, 9);

            label6.Text = D8.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            int val1 = 0;
            int val2 = 0;

            val1 = int.Parse(txt1.Text);
            val2 = int.Parse(txt2.Text);

            Random DXRand = new Random();
            int DX = DXRand.Next(val1, val2+1);

            label9.Text = DX.ToString();
        }
    }
}
