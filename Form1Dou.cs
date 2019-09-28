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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            numericUpDown2.Visible = false;
            label60.Visible = false;
            label64.Visible = false;
            label62.Visible = false;
            txt21.Visible = false;
            label61.Visible = false;
            label65.Visible = false;
            label67.Visible = false;
            label66.Visible = false;
            numericUpDown16.Visible = false;
            numericUpDown17.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            pictureBox7.Visible = false; 

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Text = "Total weight of loads and table ";
            txt2.Text = "W =";
            txt3.Text = "lb";
            txt4.Text = "in";
            txt5.Text = "in";
            txt6.Text = "in/rev";
            txt7.Text = "lb · in";
            txt8.Text = "lb";
            txt9.Text = "in";
            txt10.Text = "Primary pulley (gear) Weight";
            txt11.Text = "W";
            txt12.Text = "lb";
            txt13.Text = "in";
            txt14.Text = "Secondary pulley (gear) Weight";
            txt15.Text = "W";
            txt16.Text = "lb";
            txt17.Text = "If you are not sure about the Weight";
            txt18.Text = "in";
            txt19.Text = "If you are not sure about the Weight";
            txt20.Text = "in";
            txt21.Text = "in/s";
            txt22.Text = "in/s";
            txt23.Text = "in/s";
            txt24.Text = "oz · in";
            txt25.Text = "in";
            txt26.Text = "in/s";
            txt27.Text = "in";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Metric_b_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Text = "Total mass of loads and table ";
            txt2.Text = "m =";
            txt3.Text = "kg";
            txt4.Text = "mm";
            txt5.Text = "mm";
            txt6.Text = "mm/rev";
            txt7.Text = "N · m";
            txt8.Text = "N";
            txt9.Text = "mm";
            txt10.Text = "Primary pulley (gear) mass";
            txt11.Text = "m";
            txt12.Text = "kg";
            txt13.Text = "mm";
            txt14.Text = "Secondary pulley (gear) mass";
            txt15.Text = "m";
            txt16.Text = "kg";
            txt17.Text = "If you are not sure about the mass";
            txt18.Text = "mm";
            txt19.Text = "If you are not sure about the mass";
            txt20.Text = "mm";
            txt21.Text = "mm/s";
            txt22.Text = "mm/s";
            txt23.Text = "mm/s";
            txt24.Text = "kg · m";
            txt25.Text = "mm";
            txt26.Text = "mm/s";
            txt27.Text = "mm";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 5)
            {
                label7.Text = "Please enter the friction coefficient";
                label8.Text = "μ =";
                numericUpDown2.Visible = true;
            }
            else
            {
                label7.Text = " ";
                label8.Text = " ";
                numericUpDown2.Visible = false;
            }
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void text4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt7_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void txt9_Click(object sender, EventArgs e)
        {

        }

        private void txt11_Click(object sender, EventArgs e)
        {

        }

        private void txt21_Click(object sender, EventArgs e)
        {

        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
        {
            if (label60.Visible == false)
            {
                label60.Visible = true;
            }
            if (label64.Visible == false)
            {
                label64.Visible = true;
            }
            if (label62.Visible == false)
            {
                label62.Visible = true;
            }
            if (txt21.Visible == false)
            {
                txt21.Visible = true;
            }
            if (label61.Visible == false)
            {
                label61.Visible = true;
            }
            if (label65.Visible == false)
            {
                label65.Visible = true;
            }
            if (label67.Visible == false)
            {
                label67.Visible = true;
            }
            if (label66.Visible == false)
            {
                label66.Visible = true;
            }
            if (numericUpDown16.Visible == false)
            {
                numericUpDown16.Visible = true;
            }
            if (numericUpDown17.Visible == false)
            {
                numericUpDown17.Visible = true;
            }

            //radio button 2
            panel1.Visible = false;

            //radio button 3
            panel2.Visible = false;


            splitContainer8.Height = 275;
        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
    
            //radio button 2
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            //radio button 1
            label60.Visible = false;
            label64.Visible = false;
            label62.Visible = false;
            txt21.Visible = false;
            label61.Visible = false;
            label65.Visible = false;
            label67.Visible = false;
            label66.Visible = false;
            numericUpDown16.Visible = false;
            numericUpDown17.Visible = false;

            //radio button 3
            panel2.Visible = false;

            splitContainer8.Height = 275;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
                //Expand Panel 2
                splitContainer8.Height = 800;
                

            }

            //radio button 1
            label60.Visible = false;
            label64.Visible = false;
            label62.Visible = false;
            txt21.Visible = false;
            label61.Visible = false;
            label65.Visible = false;
            label67.Visible = false;
            label66.Visible = false;
            numericUpDown16.Visible = false;
            numericUpDown17.Visible = false;

            //radio button 2
            panel1.Visible = false;
        }

        private void splitContainer8_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label87_Click(object sender, EventArgs e)
        {

        }

        private void label92_Click(object sender, EventArgs e)
        {

        }

        private void label107_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer9_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer10_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
        }
        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
       
        }
        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            double X2 = 0;
            double totalinertia = 0;

            //Outputs
            double y1 = 0, y2 = 0, y3, y4 = 0, y5 = 0, y6 = 0, y7 = 0, y8 = 0, y16 = 0, y17 = 0, y13 = 0, y12 = 0, y11 = 0, y20 = 0, y9 = 0, y10 = 0, y18 = 0, y19 = 0;
            int unit = 0, ch1 = 0, ch2 = 0, vso = 0, pso = 0, tgreq=0;

            //Inputs
            double x3 = 0;
            double x36 = 0;
            double x2 = System.Convert.ToDouble(numericUpDown1.Value);
            double x7 = System.Convert.ToDouble(numericUpDown5.Value);
            double x9; ///// !MATERIAL!
            double x6 = System.Convert.ToDouble(numericUpDown4.Value);
            double x5 = System.Convert.ToDouble(numericUpDown3.Value);
            double x12 = System.Convert.ToDouble(numericUpDown9.Value);
            double x16 = System.Convert.ToDouble(numericUpDown12.Value);
            double x13 = System.Convert.ToDouble(numericUpDown10.Value);
            double x17 = System.Convert.ToDouble(numericUpDown11.Value);
            double x15; ///// !MATERIAL!
            double x14 = System.Convert.ToDouble(numericUpDown13.Value);
            double x19;///// !MATERIAL!
            double x18 = System.Convert.ToDouble(numericUpDown14.Value);
            double x24 = System.Convert.ToDouble(numericUpDown16.Value);
            double x26 = System.Convert.ToDouble(numericUpDown19.Value);
            double x27 = System.Convert.ToDouble(numericUpDown20.Value);
            double x34 = System.Convert.ToDouble(numericUpDown27.Value);
            double x30 = System.Convert.ToDouble(numericUpDown23.Value);
            double x31 = System.Convert.ToDouble(numericUpDown24.Value);
            double x33 = System.Convert.ToDouble(numericUpDown26.Value);
            double x35 = System.Convert.ToDouble(numericUpDown28.Value);
            double x11 = System.Convert.ToDouble(numericUpDown8.Value);
            double x20 = System.Convert.ToDouble(numericUpDown15.Value);
            double x10 = System.Convert.ToDouble(numericUpDown7.Value);
            double x8 = System.Convert.ToDouble(numericUpDown6.Value);
            double x25 = System.Convert.ToDouble(numericUpDown17.Value);
            double x37 = System.Convert.ToDouble(numericUpDown18.Value);
            double x32 = System.Convert.ToDouble(numericUpDown18.Value);
            double x28 = System.Convert.ToDouble(numericUpDown21.Value);
            double x29 = System.Convert.ToDouble(numericUpDown22.Value);


            // **********************************************************************************
            // *                                     ERRORS                                     *
            // **********************************************************************************
            int error = 0;

            if (x2 == 0)
            {
                MessageBox.Show("Please select the weight of the loads and table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (comboBox1.SelectedIndex == 0 || (comboBox1.SelectedIndex == 5 && numericUpDown2.Value == 0))
            {
                MessageBox.Show("Please select the friction coefficient of the guide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x5 == 0)
            {
                MessageBox.Show("Please enter the diameter for Ball/Lead screw", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x6 == 0)
            {
                MessageBox.Show("Please enter the total length for Ball/Lead screw", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x7 == 0)
            {
                MessageBox.Show("Please enter the Lead pitch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x8 == 0)
            {
                MessageBox.Show("Please enter the efficiency", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (comboBox2.SelectedIndex == 0)
            {
                MessageBox.Show("Please select the material for Ball/Lead screw", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x10 == 0)
            {
                MessageBox.Show("Please select the breakaway torque of the screw", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x11 == 0)
            {
                MessageBox.Show("Please enter external force", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x12 != 0 && (x13 == 0 && x14 == 0 && comboBox3.SelectedIndex == 0))
            {
                MessageBox.Show("Please fill all the required fields for the Primary Pulley", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if ((x13 != 0 || (x14 != 0 && comboBox3.SelectedIndex != 0)) && x12 == 0)
            {
                MessageBox.Show("Please fill all the required fields for the Primary Pulley", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x12 == 0 && (x16 != 0 || x17 != 0 || comboBox4.SelectedIndex != 0))
            {
                MessageBox.Show("Please fill all the required fields for the Primary Pulley", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x16 != 0 && (x17 == 0 && x18 == 0 && comboBox4.SelectedIndex == 0))
            {
                MessageBox.Show("Please fill all the required fields for the Secondary Pulley", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if ((x17 != 0 || (x18 != 0 && comboBox4.SelectedIndex != 0)) && x16 == 0)
            {
                MessageBox.Show("Please fill all the required fields for the Secondary Pulley", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x20 == 0)
            {
                MessageBox.Show("Please enter the Mechanism angle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Please choose an operating condition", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (radioButton1.Checked && numericUpDown16.Value == 0)
            {
                MessageBox.Show("Please enter the operating speed for Fixed speed operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (radioButton1.Checked && numericUpDown17.Value == 0)
            {
                MessageBox.Show("Please enter the Accelearation/Deceleration for Fixed speed operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (radioButton2.Checked && (numericUpDown19.Value == 0 || numericUpDown20.Value == 0))
            {
                MessageBox.Show("Please enter the operating speeds for Variable speed operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (radioButton2.Checked && numericUpDown18.Value == 0)
            {
                MessageBox.Show("Please enter the Accelearation/Deceleration for Variable speed operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (radioButton3.Checked && x30 == 0)
            {
                MessageBox.Show("Please enter the positioning distance for Positioning operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (radioButton3.Checked && x31 == 0)
            {
                MessageBox.Show("Please enter the positioning time for Positioning operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x35 == 0)
            {
                MessageBox.Show("Please enter the stopping accuracy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (comboBox5.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a safety factor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x34 != 0)
            { //specific operating speed is given.
              //if x[34] is entered, x[33] has to be entered too.
                if (x33 == 0)
                {
                    MessageBox.Show("Please enter the acceleration/deceleration time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error = 1;
                }
            }


                if (error == 0)
            {
                // **********************************************************************************
                // *                                 CALCULATIONS                                   *
                // **********************************************************************************

                //When transmission gear is required
                tgreq = (x12 !=0) && (x16 != 0) ? 1 : 0;
                double ratio = tgreq == 1 ? (x16 / x12) : 1;

                //Densities
                if (Imperial.Checked)
                {
                    unit = 1;

                    // Material 1
                    if (comboBox2.SelectedIndex == 1)
                    {
                        x9 = 0.284;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        x9 = 0.289;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {
                        x9 = 0.098;
                    }
                    else if (comboBox2.SelectedIndex == 4)
                    {
                        x9 = 0.31;
                    }
                    else if (comboBox2.SelectedIndex == 5)
                    {
                        x9 = 0.06;
                    }
                    else
                    {
                        x9 = 0;
                    }

                    //Material 2
                    if (comboBox3.SelectedIndex == 1)
                    {
                        x15 = 0.284;
                    }
                    else if (comboBox3.SelectedIndex == 2)
                    {
                        x15 = 0.289;
                    }
                    else if (comboBox3.SelectedIndex == 3)
                    {
                        x15 = 0.098;
                    }
                    else if (comboBox3.SelectedIndex == 4)
                    {
                        x15 = 0.31;
                    }
                    else if (comboBox3.SelectedIndex == 5)
                    {
                        x15 = 0.06;
                    }
                    else
                    {
                        x15 = 0;
                    }

                    //Material 3
                    if (comboBox4.SelectedIndex == 1)
                    {
                        x19 = 0.284;
                    }
                    else if (comboBox4.SelectedIndex == 2)
                    {
                        x19 = 0.289;
                    }
                    else if (comboBox4.SelectedIndex == 3)
                    {
                        x19 = 0.098;
                    }
                    else if (comboBox4.SelectedIndex == 4)
                    {
                        x19 = 0.31;
                    }
                    else if (comboBox4.SelectedIndex == 5)
                    {
                        x19 = 0.06;
                    }
                    else
                    {
                        x19 = 0;
                    }
                }
                else if (Metric.Checked)
                {
                    unit = 2;

                    // Material 1
                    if (comboBox2.SelectedIndex == 1)
                    {
                        x9 = 7849.8;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        x9 = 7999.493;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {
                        x9 = 2712.631;
                    }
                    else if (comboBox2.SelectedIndex == 4)
                    {
                        x9 = 8580.771;
                    }
                    else if (comboBox2.SelectedIndex == 5)
                    {
                        x9 = 1660.794;
                    }
                    else
                    {
                        x9 = 0;
                    }

                    // Material 2
                    if (comboBox3.SelectedIndex == 1)
                    {
                        x15 = 7849.8;
                    }
                    else if (comboBox3.SelectedIndex == 2)
                    {
                        x15 = 7999.493;
                    }
                    else if (comboBox3.SelectedIndex == 3)
                    {
                        x15 = 2712.631;
                    }
                    else if (comboBox3.SelectedIndex == 4)
                    {
                        x15 = 8580.771;
                    }
                    else if (comboBox3.SelectedIndex == 5)
                    {
                        x15 = 1660.794;
                    }
                    else
                    {
                        x15 = 0;
                    }

                    // Material 3
                    if (comboBox4.SelectedIndex == 1)
                    {
                        x19 = 7849.8;
                    }
                    else if (comboBox4.SelectedIndex == 2)
                    {
                        x19 = 7999.493;
                    }
                    else if (comboBox4.SelectedIndex == 3)
                    {
                        x19 = 2712.631;
                    }
                    else if (comboBox4.SelectedIndex == 4)
                    {
                        x19 = 8580.771;
                    }
                    else if (comboBox4.SelectedIndex == 5)
                    {
                        x19 = 1660.794;
                    }
                    else
                    {
                        x19 = 0;
                    }
                }
                else
                {
                    x9 = 0;
                    x15 = 0;
                    x19 = 0;
                }

                //friction coefficience
                if (comboBox1.SelectedIndex == 1)
                {
                    x3 = 0.05;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    x3 = 0.1;
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    x3 = 0.3;
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    x3 = 0.5;
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    x3 = System.Convert.ToDouble(numericUpDown2.Value);
                }

                //y1, y2, y3, y4, y5
                y1 = x2 * 16 * Math.Pow((x7 / (2 * pi)), 2);
                y1 = (Metric.Checked) ? y1 / (16 * 1000000) : y1; //FOR METRIC THERE IS NO '16' AND TO CONVERT IT FROM mm TO m, DIVIDE BY 1000

                y2 = (pi / 32) * (x9) * (x6) * Math.Pow(x5, 4);
                y2 = (Metric.Checked) ? y2 / Math.Pow(1000, 5) : y2; //convert x6 and x5 from mm to m

                if (tgreq == 1)
                {
                    // PRIMARY GEAR y3
                    if (x13 != 0)
                    {//user knows the primary pulley gear weight.

                        y3 = (1 / 8) * (x13) * 16 * Math.Pow(x12, 2);
                        y3 = (Metric.Checked) ? y3 / (16 * 1000000) : y3; // convert x12 to m and remove 16.
                    }
                    else
                    {//the user is not sure about the primary pulley gear weight, so we ask for thickness and the material type
                        y3 = (pi / 32) * (x15) * (x14) * Math.Pow(x12, 4);
                        y3 = (Metric.Checked) ? y3 / Math.Pow(1000, 5) : y3; //convert x14 &x12 to m.
                    }

                    // SECONDARY GEAR y4
                    if (x17 != 0)
                    {//user knows the secondary pulley gear weight.
                        y4 = (1 / 8) * x17 * 16 * Math.Pow(x16, 2);
                        y4 = (Metric.Checked) ? y4 / (16 * 1000000) : y4; //convert x16 to m.
                    }
                    else
                    {//the user is not sure about the secondary pulley gear weight, so we ask for thickness and the material type.
                        y4 = (pi / 32) * x19 * (x18) * Math.Pow(x16, 4);
                        y4 = (Metric.Checked) ? y4 / Math.Pow(1000, 5) : y4; //convert x18 & x16 to m.
                    }

                    y5 = (y1 + y2 + y4) * Math.Pow((x12 / x16), 2) + y3;
                }
                else
                {
                    y5 = y1 + y2;
                }

                //Required Speed
                if (radioButton1.Checked)
                {//Fixed Speed Operation - Y6
                    y6 = (x24) * (60 / x7) * ratio;

                    //Acceleration Torque (oz-in unit)
                    y9 = y5 * (y6 / (9.55 * x25));
                    y9 = (Metric.Checked) ? y9 : y9 / (386 * 16);
                    //return isNotApplicable(Ta);
                }
                else if (radioButton3.Checked)
                {//Positioning Operation - Y[6]
                    pso = 1;
                    if (x34 != 0)
                    { //specific operating speed is given.
                        y6 = (x34 / x7) * 60 * ratio;
                        y18 = -1;
                        y19 = -1;
                    }
                    else
                    {
                        x33 = x33 != 0 ? x33 : x31 * 0.25;
                        y6 = ((x30 * ratio) / (x31 - x33)) * (60 / x7);
                    }

                    //totalinertia
                    if ((x28 != 0) && (x29 != 0))
                    {
                        //when Jo and i are entered (JO*(i^2))
                        totalinertia = x28 * Math.Pow(x29, 2) + y5;
                    }
                    else if ((x28 != 0) && (x29 == 0))
                    {
                        // Jo is entered but i(rotor inertia) is entered but gear ratio empty
                        totalinertia = x28 + y5;
                    }
                    else
                    {
                        // When Jo not entered or both Jo and i not entered.
                        totalinertia = 1.2 * y5;
                    }

                    //Acceleration Torque (oz-in unit)
                    y9 = totalinertia * (y6 / (9.55 * x33));
                    y9 = (Metric.Checked) ? y9 : y9 / (386 * 16);
                }
                else if (radioButton3.Checked)
                {//Variable Speed Operation - Y[7], Y[8]
                    vso = 1;
                    y7 = x26 * (60 / x7) * ratio;
                    y8 = x27 * (60 / x7) * ratio;

                    double Vm = y6 = y7 > y8 ? y7 : y8;

                    //Acceleration Torque (oz-in unit)
                    y9 = y5 * (Vm / (9.55 * x37));
                    y9 = (Metric.Checked) ? y9 : y9 / (386 * 16);
                }

                //Acceleration Torque. 
                y10 = (y9 == -1) ? y9 : y9 * 16;//For imperial only converted to (lb-in unit)

                //Force
                X2 = (Metric.Checked) ? x2 * 9.8 : x2; //for metric x2 (which is mass), is multiplied by gravity(9.8).
                y11 = x11 + (X2 * Math.Sin(x20 * pi / 180)) + (x3 * Math.Cos(x20 * pi / 180));

                //Load Torque Tl (lb-in unit).  
                double leadPitch = (Metric.Checked) ? x7 / 1000 : x7; //convert to m for Metric unit.
                y12 = (((y11 * leadPitch) / (2 * pi)) * 1.1) + x10 * (1 / (x8 * 0.01)) * (1 / ratio);

                //Load Torque Tl (oz-in unit).  
                y20 = y12 * 16; //converting lb to oz

                //Required Stopping Accuracy
                y13 = x35 * (360 / x7) * (ratio);

                //Required Torque
                y16 = (y9 + y12) * x36;

                //Required Torque, (oz-in). Only for imperial.
                y17 = (y16 == -1) ? y16 : y16 * 16;

                if (radioButton3.Checked && (x34 == 0))
                {//specific operating speed is not required and we have t0, ts and L.
                    x32 = x32 !=0 ? x32 : 0;
                    //Root Mean Square(RMS)Torque, (lb-in), Y[18]
                    y18 = Math.Sqrt(((Math.Pow(y9 + y12, 2) * x33) + (Math.Pow(y12, 2) * (x31 - 2 * x33)) + (Math.Pow(y9 - y12, 2) * x33)) / (x31 + x32)) * x36;
                    if (!double.IsNaN(System.Convert.ToDouble(y18)) && !double.IsInfinity(System.Convert.ToDouble(y18)))
                    {
                        if (Imperial.Checked)
                        {
                            y19 = 16 * y18;
                        }
                    }
                    else
                    {
                        y18 = -1;
                        y19 = -1;
                    }
                    ////Root Mean Square(RMS)Torque, (oz-in), Y[19]. Only for imperial
                    //Y[19] = (Y[18] == "N/A") ? Y[18] : Number(Y[18]) * 16;
                }

                //Other Requirement(s)
                if (checkBox1.Checked)
                {
                    ch1 = 1;
                }
                if (checkBox2.Checked)
                {
                    ch2 = 1;
                }

                if (Metric.Checked)
                {
                    unit = 2;
                }
                else
                {
                    unit = 1;
                }

                //Pressing Button Actions
                Form2 frm2 = new Form2(y5, y6, y16, y17, y9, y10, y12, y20, y13, unit, ch1, ch2, vso, y7, y8, pso, y18, y19);
                frm2.Show();
                //this.Hide();
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown13.Enabled = false;
            comboBox3.Enabled = false;
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown14.Enabled = false;
            comboBox4.Enabled = false;
        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown19_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown20_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown28_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
 
        }
        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void numericUpDown23_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown27.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main NewForm = new Main();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}


////Densities
//if (Imperial.Checked)
//{
//    unit = 1;

//    // Material 1
//    if (comboBox2.SelectedIndex == 1)
//    {
//        x9 = 0.284m;
//    }
//    else if (comboBox2.SelectedIndex == 2)
//    {
//        x9 = 0.289m;
//    }
//    else if (comboBox2.SelectedIndex == 3)
//    {
//        x9 = 0.098m;
//    }
//    else if (comboBox2.SelectedIndex == 4)
//    {
//        x9 = 0.31m;
//    }
//    else if (comboBox2.SelectedIndex == 5)
//    {
//        x9 = 0.06m;
//    }
//    else
//    {
//        x9 = 0m;
//    }

//    //Material 2
//    if (comboBox3.SelectedIndex == 1)
//    {
//        x15 = 0.284m;
//    }
//    else if (comboBox3.SelectedIndex == 2)
//    {
//        x15 = 0.289m;
//    }
//    else if (comboBox3.SelectedIndex == 3)
//    {
//        x15 = 0.098m;
//    }
//    else if (comboBox3.SelectedIndex == 4)
//    {
//        x15 = 0.31m;
//    }
//    else if (comboBox3.SelectedIndex == 5)
//    {
//        x15 = 0.06m;
//    }
//    else
//    {
//        x15 = 0m;
//    }

//    //Material 3
//    if (comboBox4.SelectedIndex == 1)
//    {
//        x19 = 0.284m;
//    }
//    else if (comboBox4.SelectedIndex == 2)
//    {
//        x19 = 0.289m;
//    }
//    else if (comboBox4.SelectedIndex == 3)
//    {
//        x19 = 0.098m;
//    }
//    else if (comboBox4.SelectedIndex == 4)
//    {
//        x19 = 0.31m;
//    }
//    else if (comboBox4.SelectedIndex == 5)
//    {
//        x19 = 0.06m;
//    }
//    else
//    {
//        x19 = 0m;
//    }
//}
//else if (Metric.Checked)
//{
//    unit = 2;

//    // Material 1
//    if (comboBox2.SelectedIndex == 1)
//    {
//        x9 = 7849.8m;
//    }
//    else if (comboBox2.SelectedIndex == 2)
//    {
//        x9 = 7999.493m;
//    }
//    else if (comboBox2.SelectedIndex == 3)
//    {
//        x9 = 2712.631m;
//    }
//    else if (comboBox2.SelectedIndex == 4)
//    {
//        x9 = 8580.771m;
//    }
//    else if (comboBox2.SelectedIndex == 5)
//    {
//        x9 = 1660.794m;
//    }
//    else
//    {
//        x9 = 0m;
//    }

//    // Material 2
//    if (comboBox3.SelectedIndex == 1)
//    {
//        x15 = 7849.8m;
//    }
//    else if (comboBox3.SelectedIndex == 2)
//    {
//        x15 = 7999.493m;
//    }
//    else if (comboBox3.SelectedIndex == 3)
//    {
//        x15 = 2712.631m;
//    }
//    else if (comboBox3.SelectedIndex == 4)
//    {
//        x15 = 8580.771m;
//    }
//    else if (comboBox3.SelectedIndex == 5)
//    {
//        x15 = 1660.794m;
//    }
//    else
//    {
//        x15 = 0m;
//    }

//    // Material 3
//    if (comboBox4.SelectedIndex == 1)
//    {
//        x19 = 7849.8m;
//    }
//    else if (comboBox4.SelectedIndex == 2)
//    {
//        x19 = 7999.493m;
//    }
//    else if (comboBox4.SelectedIndex == 3)
//    {
//        x19 = 2712.631m;
//    }
//    else if (comboBox4.SelectedIndex == 4)
//    {
//        x19 = 8580.771m;
//    }
//    else if (comboBox4.SelectedIndex == 5)
//    {
//        x19 = 1660.794m;
//    }
//    else
//    {
//        x19 = 0m;
//    }
//}
//else
//{
//    x9 = 0m;
//    x15 = 0m;
//    x19 = 0m;
//}

//if (comboBox1.SelectedIndex == 1)
//{
//    x3 = 0.05m;
//}
//else if (comboBox1.SelectedIndex == 2)
//{
//    x3 = 0.1m;
//}
//else if (comboBox1.SelectedIndex == 3)
//{
//    x3 = 0.3m;
//}
//else if (comboBox1.SelectedIndex == 4)
//{
//    x3 = 0.5m;
//}
//else if (comboBox1.SelectedIndex == 5)
//{
//    x3 = numericUpDown2.Value;
//}

//if (comboBox5.SelectedIndex == 1)
//{
//    x36 = 1.5m;
//}
//else if (comboBox5.SelectedIndex == 2)
//{
//    x36 = 1.75m;
//}
//else if (comboBox5.SelectedIndex == 3)
//{
//    x36 = 2m;
//}

////Transmission Gear Diameter Ratio
//decimal ratio;
//if (x12 != 0 && x16 != 0)
//{
//    ratio = x16 / x12;
//}
//else
//{
//    ratio = 1;
//}

////Required Speed
//if (radioButton1.Checked)
//{
//    // Fixed Speed Operation
//    y6 = (x24) * (60 / x7) * ratio;
//}
//else if (radioButton2.Checked)
//{
//    //Variable Speed Operation 
//    vso = 1;
//    y7 = x26 * (60 / x7) * ratio;
//    y8 = x27 * (60 / x7) * ratio;

//    if (y7 > y8)
//    {
//        y6 = y7;
//    }
//    else
//    {
//        y6 = y8;
//    }
//}
//else if (radioButton3.Checked)
//{
//    //Positioning Operation
//    pso = 1;

//    if (x34 != 0)
//    {
//        y6 = (x34 / x7) * 60 * ratio;
//        y18 = -1;
//        y19 = -1;
//    }
//    else
//    {
//        if (x33 == 0)
//        {
//            x33 = x31 * 0.25m;
//        }
//        y6 = ((x30 * ratio) / (x31 - x33)) * (60 /x7);
//    }
//}


////Required Stopping Accuracy
//y13 = x35 * (360 / x7) * (ratio);

//if (Metric.Checked)
//{
//    X2 = 9.8m * x2;
//}
//else if (Imperial.Checked)
//{
//    X2 = x2;
//}
//y11 = x11 + (X2 * System.Convert.ToDecimal(Math.Sin(System.Convert.ToDouble(x20 * pi / 180)))) + (x3 * System.Convert.ToDecimal(Math.Cos(System.Convert.ToDouble(x20 * pi / 180))));
//if (Imperial.Checked)
//{
//    y1 = x2 * 16 * System.Convert.ToDecimal(Math.Pow((System.Convert.ToDouble(x7 / (2 * pi))), 2));
//    y2 = (pi / 32) * x9 * x6 * System.Convert.ToDecimal(Math.Pow(System.Convert.ToDouble(x5), 4));
//    if (x12 != 0)
//    {
//        //Primary Pulley
//        if (x13 != 0)
//        {
//            //Weight known
//            y3 = (1 / 8) * x13 * 16 * System.Convert.ToDecimal(Math.Pow(System.Convert.ToDouble(x12), 2));
//        }
//        else
//        {
//            y3 = (pi / 32) * x15 * x14 * System.Convert.ToDecimal(Math.Pow(System.Convert.ToDouble(x12), 4));
//        }
//    }
//    if (x16 != 0)
//    {
//        //Secondary Pulley
//        if (x17 != 0)
//        {
//            //Weight known
//            y4 = (1 / 8) * x17 * 16 * System.Convert.ToDecimal(Math.Pow(System.Convert.ToDouble(x16), 2));
//        }
//        else
//        {
//            y4 = (pi / 32) * x19 * x18 * System.Convert.ToDecimal(Math.Pow(System.Convert.ToDouble(x16), 4));
//        }
//    }

//    y12 = ((((y11 * x7) / (2 * pi)) * 1.1m) + x10) * (1 / (x8 * 0.01m)) * (1 / ratio);
//    y20 = y12 * 16;
//}
//else if (Metric.Checked)
//{
//    y1 = x2 * System.Convert.ToDecimal(Math.Pow((System.Convert.ToDouble(x7 / (2m * pi))), 2)) / 1000000;
//    y2 = (pi / 32) * x9 * x6 * System.Convert.ToDecimal(Math.Pow(System.Convert.ToDouble(x5), 4)) / System.Convert.ToDecimal(Math.Pow(1000, 5));
//    if (x12 != 0)
//    {
//        //Primary Pulley
//        if (x13 != 0)
//        {
//            //Weight known
//            y3 = (1 / 8) * x13 * System.Convert.ToDecimal(Math.Pow(System.Convert.ToDouble(x12), 2) / 1000000);
//        }
//        else
//        {
//            y3 = (pi / 32m) * x15 * x14 * System.Convert.ToDecimal(Math.Pow(System.Convert.ToDouble(x12), 4)) / (System.Convert.ToDecimal(Math.Pow(1000, 5)));
//        }
//    }
//    if (x16 != 0)
//    {
//        //Secondary Pulley
//        if (x17 != 0)
//        {
//            //Weight known
//            y4 = (1 / 8) * x17 * System.Convert.ToDecimal(Math.Pow(System.Convert.ToDouble(x16), 2)) / 1000000;
//        }
//        else
//        {
//            y4 = (pi / 32) * x19 * x18 * System.Convert.ToDecimal(Math.Pow(System.Convert.ToDouble(x16), 4)) / (System.Convert.ToDecimal(Math.Pow(1000, 5)));
//        }
//    }

//    y12 = ((((y11 * (x7 / 1000)) / (2 * pi)) * 1.1m) + x10) * (1 / (x8 * 0.01m)) * (1 / ratio);
//}

////Load Inertia
//if (x12 != 0 && x16 != 0)
//{
//    y5 = (y1 + y2 + y4) * System.Convert.ToDecimal(Math.Pow(System.Convert.ToDouble(x12/x16),2)) + x3;
//}
//else
//{
//    y5 = y1 + y2;
//}

////Acceleration Torque
//if (radioButton1.Checked)
//{
//    // Fixed Speed Operation
//    y9 = y5 * (y6 / (9.55m * x25));
//}
//else if (radioButton2.Checked)
//{
//    //Variable Speed Operation 
//    y9 = y5 * (y6 / (9.55m * x37));
//}
//else if (radioButton3.Checked)
//{
//    //Positioning Speed Operation
//    if (x28 != 0 && x29 != 0)
//    {
//        totalinertia = x28 * System.Convert.ToDecimal(Math.Pow(System.Convert.ToDouble(x29), 2)) + y5;
//    }
//    else if (x28 != 0 && x29 == 0)
//    {
//        totalinertia = x28 + y5;
//    }
//    else
//    {
//        totalinertia = 1.2m * y5;
//    }
//    y9 = totalinertia * (y6 / (9.55m * x33));
//}

//if (!double.IsNaN(System.Convert.ToDouble(y9)) && !double.IsInfinity(System.Convert.ToDouble(y9)))
//{
//    if (Imperial.Checked)
//    {
//        y9 = y9 / (16m * 386m);
//        y10 = 16m * y9;
//    }
//}
//else
//{
//    y9 = -1;
//    y10 = -1;
//}

////Required Torque
//if (y9 != -1)
//{
//    y16 = (y9 + y12) * x36;
//    if (!double.IsNaN(System.Convert.ToDouble(y16)) && !double.IsInfinity(System.Convert.ToDouble(y16)))
//    {
//        if (Imperial.Checked)
//        {
//            y17 = 16 * y16;
//        }
//    }
//    else
//    {
//        y16 = -1;
//        y17 = -1;
//    }
//}
//else
//{
//    y16 = -1;
//    y17 = -1;
//}


////RMS Torque
//if (y9 != -1)
//{
//    if (radioButton3.Checked && x34 == 0)
//    {
//        //Positioning Speed Operation
//        y18 = System.Convert.ToDecimal(Math.Sqrt(System.Convert.ToDouble((((System.Convert.ToDecimal(Math.Pow(System.Convert.ToDouble(y9 + y12), 2)) * x33) + (System.Convert.ToDecimal(Math.Pow(System.Convert.ToDouble(y12), 2)) * (x31 - 2m * x33)) + (System.Convert.ToDecimal(Math.Pow(System.Convert.ToDouble(y9) - System.Convert.ToDouble(y12), 2)) * x33)) / (x31 + x32))))) * x36;
//        if (!double.IsNaN(System.Convert.ToDouble(y18)) && !double.IsInfinity(System.Convert.ToDouble(y18)))
//        {
//            if (Imperial.Checked)
//            {
//                y19 = 16 * y18;
//            }
//        }
//        else
//        {
//            y18 = -1;
//            y19 = -1;
//        }
//    }
//}
//else
//{
//    y18 = -1;
//    y19 = -1;
//}


////Other Requirement(s)
//if (checkBox1.Checked)
//{
//    ch1 = 1;
//}
//if (checkBox2.Checked)
//{
//    ch2 = 1;
//}