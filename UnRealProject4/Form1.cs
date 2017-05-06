using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnRealProject4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegularExample finder = new RegularExample();

            textBox1.Text = Convert.ToString(finder.eMailFinder(richTextBox1.Text));
            textBox4.Text = Convert.ToString(finder.ipv4Finder(richTextBox1.Text));
            textBox5.Text = Convert.ToString(finder.ipv6Finder(richTextBox1.Text));
            textBox2.Text = Convert.ToString(finder.mobileFinder(richTextBox1.Text));
            textBox7.Text = Convert.ToString(finder.engchar(richTextBox1.Text));
            textBox6.Text = Convert.ToString(finder.numbers(richTextBox1.Text));
        }
    }
}
