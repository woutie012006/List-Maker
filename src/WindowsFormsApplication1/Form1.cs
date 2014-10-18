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
            string tag = textBox1.Text;
            String s=String.Empty;
            String Output="";

            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Please make sure there is text in atleast one textbox","Error");
            }
            else
            {


                for (int i = 0; i < textBox2.Lines.Length; i++)
                {
                    if (i == 0)
                    {
                        s = textBox2.Lines[i];
                        Output += "<" + tag + ">" + textBox2.Lines[i] + "</" + tag + ">";
                    }
                    else if (textBox2.Lines[i] == "")
                    {

                    }
                    else
                    {

                        s = textBox2.Lines[i];
                        Output += "\n" + "<" + tag + ">" + textBox2.Lines[i] + "</" + tag + ">";
                    }

                }
                textBox2.Text = Output;
            }       }
        
    }
}
