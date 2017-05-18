using System;
using System.Drawing;
using System.Text.RegularExpressions;
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
            MatchCollection eMailFinder = Regex.Matches(richTextBox1.Text, @"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)");
            MatchCollection ipv4Finder = Regex.Matches(richTextBox1.Text, @"\b(?:(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9])\.(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9])\.(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9])\.(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9]))\b");
            MatchCollection ipv6Finder = Regex.Matches(richTextBox1.Text, @"(?:^|(?<=\s))(([0-9a-fA-F]{1,4}:){7,7}[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,7}:|([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}|([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}|([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}|([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}|[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|:((:[0-9a-fA-F]{1,4}){1,7}|:)|fe80:(:[0-9a-fA-F]{0,4}){0,4}%[0-9a-zA-Z]{1,}|::(ffff(:0{1,4}){0,1}:){0,1}((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])|([0-9a-fA-F]{1,4}:){1,4}:((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]))(?=\s|$)");
            MatchCollection mobileFinder = Regex.Matches(richTextBox1.Text, @"((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}");
            MatchCollection htmlFinder = Regex.Matches(richTextBox1.Text, @"<.*html>");


            foreach (Match ip in eMailFinder)
            {
                richTextBox1.SelectionStart = ip.Index;
                richTextBox1.SelectionLength = ip.Length;
                richTextBox1.SelectionBackColor = Color.FromArgb(255, 160, 122);
            }

            foreach (Match ip in ipv4Finder)
            {
                richTextBox1.SelectionStart = ip.Index;
                richTextBox1.SelectionLength = ip.Length;
                richTextBox1.SelectionBackColor = Color.FromArgb(0, 77, 255);
            }

            foreach (Match ip in ipv6Finder)
            {
                richTextBox1.SelectionStart = ip.Index;
                richTextBox1.SelectionLength = ip.Length;
                richTextBox1.SelectionBackColor = Color.FromArgb(80, 200, 120);
            }

            foreach (Match ip in mobileFinder)
            {
                richTextBox1.SelectionStart = ip.Index;
                richTextBox1.SelectionLength = ip.Length;
                richTextBox1.SelectionBackColor = Color.FromArgb(255, 223, 0);
            }

            foreach (Match ip in htmlFinder)
            {
                richTextBox1.SelectionStart = ip.Index;
                richTextBox1.SelectionLength = ip.Length;
                richTextBox1.SelectionBackColor = Color.FromArgb(0, 191, 255);
            }
        }

    }
}
