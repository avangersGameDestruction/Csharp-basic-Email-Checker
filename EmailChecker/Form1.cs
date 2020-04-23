using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailChecker
{
    public partial class Form1 : Form
    {
        private const string EmailEncoding = @"^[a-zA-A][\w\.-]{2,28}[a-zA-z0-9]@[\w\.-]*[a-zA-z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_Validating(object sender, CancelEventArgs e)
        {
            Regex Email = new Regex(EmailEncoding);
            if (textBox1.Text.Length > 0)
            {
                if (!Email.IsMatch(textBox1.Text))
                {
                    MessageBox.Show("invalid email adress", "Error");
                    textBox1.SelectAll();
                    e.Cancel = true;
                }
            }
        }
    }
}
