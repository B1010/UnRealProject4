using System;
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

            textBox10.Text = Convert.ToString(finder.handmadeFinder(richTextBox1.Text, textBox9.Text));

            textBox1.Text = Convert.ToString(finder.eMailFinder(richTextBox1.Text));
            textBox4.Text = Convert.ToString(finder.ipv4Finder(richTextBox1.Text));
            textBox5.Text = Convert.ToString(finder.ipv6Finder(richTextBox1.Text));
            textBox2.Text = Convert.ToString(finder.mobileFinder(richTextBox1.Text));
            textBox7.Text = Convert.ToString(finder.engcharFinder(richTextBox1.Text));
            textBox8.Text = Convert.ToString(finder.ruscharFinder(richTextBox1.Text));
            textBox6.Text = Convert.ToString(finder.numbersFinder(richTextBox1.Text));
            textBox11.Text = Convert.ToString(finder.wordsFinder(richTextBox1.Text));
        }
    }
}
