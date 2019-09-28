using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TableResults : Form
    {
        public TableResults(double y5, double y6, double y16, double y17, double y9, double y10, double y12, double y20, double y13, int unit, int ch1, int ch2, int vso, double y7, int pso, double y18, double y19)//Data Passed
        {
            InitializeComponent();
            label30.Visible = false;
            label31.Visible = false;
            label35.Visible = false;
            panel3.Visible = false;
            panel2.Visible = false;

            //Inputs
            textBox1.Text = y5.ToString();
            if (y16 != -1)
            {
                textBox3.Text = y16.ToString(); //"0.000"
            }
            else
            {
                textBox3.Text = "N/A";
            }

            if (y9 != -1)
            {
                textBox4.Text = y9.ToString();
            }
            else
            {
                textBox4.Text = "N/A";
            }
            textBox5.Text = y12.ToString();
            textBox6.Text = y13.ToString();
            textBox9.Text = y17.ToString();
            if (y10 != -1)
            {
                textBox8.Text = y10.ToString();
            }
            else
            {
                textBox8.Text = "N/A";
            }
            if (y17 != -1)
            {
                textBox7.Text = y20.ToString();
            }
            else
            {
                textBox7.Text = "N/A";
            }

            if (pso == 1)
            {
                panel2.Visible = true;
                if (y18 != -1)
                {
                    textBox11.Text = y18.ToString();
                }
                else
                {
                    textBox11.Text = "N/A";
                }
            }

            if (unit == 1)
            {
                txt4.Text = "[oz·in    ] ";
                label6.Text = "[lb·in]";
                label11.Text = "[lb·in]";
                label15.Text = "[lb·in]";
                label37.Text = "[lb·in]";
                panel1.Visible = true;
                if (pso == 1)
                {
                    panel3.Visible = true;
                    if (y19 != -1)
                    {
                        textBox14.Text = y19.ToString();
                    }
                    else
                    {
                        textBox14.Text = "N/A";
                    }
                }

            }
            else if (unit == 2)
            {
                txt4.Text = "[kg·m   ] ";
                label6.Text = "[N·m]";
                label11.Text = "[N·m]";
                label15.Text = "[N·m]";
                label37.Text = "[N·m]";
                panel1.Visible = false;
            }

            if (ch1 == 1)
            {
                label30.Visible = true;
            }
            if (ch2 == 1)
            {
                label31.Visible = true;
                if (ch1 != 1)
                {
                    label31.Location = new Point(160, 208);
                }
                else
                {
                    label31.Location = new Point(160, 223);
                }
            }

            if (vso == 1)
            {
                label35.Visible = true;

                if (double.IsInfinity(System.Convert.ToDouble(y7)))
                {
                    textBox2.Text = "Infinity";
                }
                else
                {
                    textBox2.Text = y7.ToString();
                }

            }
            else
            {
                if (double.IsInfinity(System.Convert.ToDouble(y6)))
                {
                    textBox2.Text = "Infinity";
                }
                else
                {
                    textBox2.Text = y6.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose(false);
        }
    }
}
