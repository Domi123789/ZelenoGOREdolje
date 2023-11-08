using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZelenoGOREdolje
{
    public partial class Form1 : Form
    {
        int current = 1;
        public Form1()
        {
            InitializeComponent();
            textBox1.BackColor = Color.GreenYellow;

        }

        private void Gore_Click(object sender, EventArgs e)
        {
            switch (current)
            {
                case 1:
                    textBox9.BackColor = Color.GreenYellow;
                    textBox1.BackColor = Color.White;
                    current = 9;
                    break;
                case 2:
                    textBox10.BackColor = Color.GreenYellow;
                    textBox2.BackColor = Color.White;
                    current = 10;
                    break;
                case 3:
                    textBox11.BackColor = Color.GreenYellow;
                    textBox3.BackColor = Color.White;
                    current = 11;
                    break;
                case 4:
                    textBox12.BackColor = Color.GreenYellow;
                    textBox4.BackColor = Color.White;
                    current = 12;
                    break;
                case 5:
                    textBox1.BackColor = Color.GreenYellow;
                    textBox5.BackColor = Color.White;
                    current = 1;
                    break;
                case 6:
                    textBox2.BackColor = Color.GreenYellow;
                    textBox6.BackColor = Color.White;
                    current = 2;
                    break;
                case 7:
                    textBox3.BackColor = Color.GreenYellow;
                    textBox7.BackColor = Color.White;
                    current = 3;
                    break;
                case 8:
                    textBox4.BackColor = Color.GreenYellow;
                    textBox8.BackColor = Color.White;
                    current = 4;
                    break;
                case 9:
                    textBox5.BackColor = Color.GreenYellow;
                    textBox9.BackColor = Color.White;
                    current = 5;
                    break;
                case 10:
                    textBox6.BackColor = Color.GreenYellow;
                    textBox10.BackColor = Color.White;
                    current = 6;
                    break;
                case 11:
                    textBox7.BackColor = Color.GreenYellow;
                    textBox11.BackColor = Color.White;
                    current = 7;
                    break;
                case 12:
                    textBox8.BackColor = Color.GreenYellow;
                    textBox12.BackColor = Color.White;
                    current = 8;
                    break;
                default: break;
            }


        }

        private void Dolje_Click(object sender, EventArgs e)
        {
            switch (current)
            {
                case 1:
                    textBox5.BackColor = Color.GreenYellow;
                    textBox1.BackColor = Color.White;
                    current = 5;
                    break;
                case 2:
                    textBox6.BackColor = Color.GreenYellow;
                    textBox2.BackColor = Color.White;
                    current = 6;
                    break;
                case 3:
                    textBox7.BackColor = Color.GreenYellow;
                    textBox3.BackColor = Color.White;
                    current = 7;
                    break;
                case 4:
                    textBox8.BackColor = Color.GreenYellow;
                    textBox4.BackColor = Color.White;
                    current = 8;
                    break;
                case 5:
                    textBox9.BackColor = Color.GreenYellow;
                    textBox5.BackColor = Color.White;
                    current = 9;
                    break;
                case 6:
                    textBox10.BackColor = Color.GreenYellow;
                    textBox6.BackColor = Color.White;
                    current = 10;
                    break;
                case 7:
                    textBox11.BackColor = Color.GreenYellow;
                    textBox7.BackColor = Color.White;
                    current = 11;
                    break;
                case 8:
                    textBox12.BackColor = Color.GreenYellow;
                    textBox8.BackColor = Color.White;
                    current = 12;
                    break;
                case 9:
                    textBox1.BackColor = Color.GreenYellow;
                    textBox9.BackColor = Color.White;
                    current = 1;
                    break;
                case 10:
                    textBox2.BackColor = Color.GreenYellow;
                    textBox10.BackColor = Color.White;
                    current = 2;
                    break;
                case 11:
                    textBox3.BackColor = Color.GreenYellow;
                    textBox11.BackColor = Color.White;
                    current = 3;
                    break;
                case 12:
                    textBox4.BackColor = Color.GreenYellow;
                    textBox12.BackColor = Color.White;
                    current = 4;
                    break;
                default: break;
            }

        }

        private void Desno_Click(object sender, EventArgs e)
        {
            switch (current)
            {
                case 1:
                    textBox2.BackColor = Color.GreenYellow;
                    textBox1.BackColor = Color.White;
                    current = 2;
                    break;
                case 2:
                    textBox3.BackColor = Color.GreenYellow;
                    textBox2.BackColor = Color.White;
                    current = 3;
                    break;
                case 3:
                    textBox4.BackColor = Color.GreenYellow;
                    textBox3.BackColor = Color.White;
                    current = 4;
                    break;
                case 4:
                    textBox1.BackColor = Color.GreenYellow;
                    textBox4.BackColor = Color.White;
                    current = 1;
                    break;
                case 5:
                    textBox6.BackColor = Color.GreenYellow;
                    textBox5.BackColor = Color.White;
                    current = 6;
                    break;
                case 6:
                    textBox7.BackColor = Color.GreenYellow;
                    textBox6.BackColor = Color.White;
                    current = 7;
                    break;
                case 7:
                    textBox8.BackColor = Color.GreenYellow;
                    textBox7.BackColor = Color.White;
                    current = 8;
                    break;
                case 8:
                    textBox5.BackColor = Color.GreenYellow;
                    textBox8.BackColor = Color.White;
                    current = 5;
                    break;
                case 9:
                    textBox10.BackColor = Color.GreenYellow;
                    textBox9.BackColor = Color.White;
                    current = 10;
                    break;
                case 10:
                    textBox11.BackColor = Color.GreenYellow;
                    textBox10.BackColor = Color.White;
                    current = 11;
                    break;
                case 11:
                    textBox12.BackColor = Color.GreenYellow;
                    textBox11.BackColor = Color.White;
                    current = 12;
                    break;
                case 12:
                    textBox9.BackColor = Color.GreenYellow;
                    textBox12.BackColor = Color.White;
                    current = 9;
                    break;
            default : break;
            }


        }

        private void Lijevo_Click(object sender, EventArgs e)
        {
            switch (current)
            {
                case 1:
                    textBox4.BackColor = Color.GreenYellow;
                    textBox1.BackColor = Color.White;
                    current = 4;
                    break;
                case 2:
                    textBox1.BackColor = Color.GreenYellow;
                    textBox2.BackColor = Color.White;
                    current = 1;
                    break;
                case 3:
                    textBox2.BackColor = Color.GreenYellow;
                    textBox3.BackColor = Color.White;
                    current = 2;
                    break;
                case 4:
                    textBox3.BackColor = Color.GreenYellow;
                    textBox4.BackColor = Color.White;
                    current = 3;
                    break;
                case 5:
                    textBox8.BackColor = Color.GreenYellow;
                    textBox5.BackColor = Color.White;
                    current = 8;
                    break;
                case 6:
                    textBox5.BackColor = Color.GreenYellow;
                    textBox6.BackColor = Color.White;
                    current = 5;
                    break;
                case 7:
                    textBox6.BackColor = Color.GreenYellow;
                    textBox7.BackColor = Color.White;
                    current = 6;
                    break;
                case 8:
                    textBox7.BackColor = Color.GreenYellow;
                    textBox8.BackColor = Color.White;
                    current = 7;
                    break;
                case 9:
                    textBox12.BackColor = Color.GreenYellow;
                    textBox9.BackColor = Color.White;
                    current = 12;
                    break;
                case 10:
                    textBox9.BackColor = Color.GreenYellow;
                    textBox10.BackColor = Color.White;
                    current = 9;
                    break;
                case 11:
                    textBox10.BackColor = Color.GreenYellow;
                    textBox11.BackColor = Color.White;
                    current = 10;
                    break;
                case 12:
                    textBox11.BackColor = Color.GreenYellow;
                    textBox12.BackColor = Color.White;
                    current = 11;
                    break;
                default: break;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

