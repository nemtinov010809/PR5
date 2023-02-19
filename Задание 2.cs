using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_2
{
    public partial class Form1 : Form
    {
        public int cek, min;
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            cek += 1;
            txtSeconds.Text = cek.ToString();
            if (cek == 60)
            {
                min += 1;
                txtMinutes.Text = min.ToString();
                cek = 0;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmrSecundomer.Stop();
            txtMinutes.Text = "0";
            txtSeconds.Text = "0";
            textBox1.Text = " ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
        }

        private void btmStart_Click(object sender, EventArgs e)
        {
            cek = 0;
            min = 0;
            tmrSecundomer.Start();
        }
    }
}
