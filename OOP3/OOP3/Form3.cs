using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = (Form1)this.Owner;
            string format;
            if(radioButton1.Checked)
            {
                format = "1";
            }
            else
            {
                if (radioButton2.Enabled)
                {
                    format = "2";
                }
                else
                {
                    format=textBox1.Text;
                }
            }
            
            f.takeFormat(format);
            this.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                button1.Enabled = false;
                textBox1.Enabled = true;
            }
            else
            {
                button1.Enabled = true;
                textBox1.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
                button1.Enabled = true;
        }
    }
}
