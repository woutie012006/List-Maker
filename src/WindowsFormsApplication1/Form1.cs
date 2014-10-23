using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

        private void goButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Please make sure there is text in atleast one textbox","Error");
            }
            else
            {
                foreach (string line in textBox2.Lines)
                {
                    if(!line.StartsWith("<"))
                        textBox2.AppendText(String.Format("\r\n<{0}>{1}</{2}>", textBox1.Text, line, textBox1.Text));
                }
            }       
        }
    }
}
