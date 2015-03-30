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

        private void goButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Please make sure there is text in atleast one textbox","Error");
            }
            else
            {
                //maybe not the best variable name
                List<string> strings = new List<string>();

                foreach (string line in textBox2.Lines)
                {
                    strings.Add(line);
                }
                //might later add option to delete spaces.
                if (!textBox2.Text.Contains(String.Format("<{0}>", textBox1.Text)))
                {
                    textBox2.Text = "";

                    if (checkBox1.Checked == true)
                    {
                        textBox2.AppendText("<ul>\n");
                        textBox1.Text = "li";
                    }
                    
                    foreach (string line in strings)
                    {

                        if (!line.Contains(String.Format("<{0}>{1}</{2}>\r\n", textBox1.Text, line, textBox1.Text)) &&
                            line != "")
                        {

                            if (textBox1.Text == "li")
                                textBox2.AppendText("\t");

                            textBox2.AppendText(String.Format("<{0}>{1}</{2}>\r\n", textBox1.Text, line, textBox1.Text));
                        }
                        else if (line == "")
                            textBox2.AppendText("\r\n");
                    }

                    if(checkBox1.Checked)
                        textBox2.AppendText(@"</ul>");
                    
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox1.Enabled = false;
            else
                textBox1.Enabled = true;
        }
    }
}
