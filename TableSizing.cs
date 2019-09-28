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
    public partial class TableSizing : Form
    {
        public TableSizing()
        {
            InitializeComponent();
            numericUpDown36.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            label150.Text = "";
            label151.Text = "";
            numericUpDown3.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown10.Enabled = false;
            numericUpDown11.Enabled = false;
            numericUpDown12.Enabled = false;
            numericUpDown13.Enabled = false;
            numericUpDown14.Enabled = false;
            numericUpDown15.Enabled = false;
            numericUpDown8.Enabled = false;
            comboBox3.Enabled = false;

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer10_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer8_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            //pictureBox13.Visible = true;
        }
        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox13.Visible = false;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            double ratio;
            double t1; // t1 is used in calculating Y[9] and Y[10]. It is the Acceleration/Deceleration input value based on the operating condition selected.
            int vso = 0;
            int pso = 0;
            int ch1 = 0, ch2 = 0;  

            //Outputs
            double y1, y2, y3, y4, y5, y6, y7 = 0, y8=0, y9, y10 = 0, y11, y12, y13 = 0, y14, y15, y16, y17, y18, y19, y20=0;

            //Inputs
            int x1 = 0; //Unit
            double x2 = 0; //Table Type
            double x3 = System.Convert.ToDouble(numericUpDown1.Value); // Diameter
            double x4 = System.Convert.ToDouble(numericUpDown3.Value); // Width
            double x5 = System.Convert.ToDouble(numericUpDown2.Value); // Depth
            double x6 = System.Convert.ToDouble(numericUpDown4.Value); // Weight/Mass
            double x7 = System.Convert.ToDouble(numericUpDown5.Value); // Thickness
            double x8 = 0; // Material
            double x9 = System.Convert.ToDouble(numericUpDown9.Value); // Shaft Diameter
            double x10 = System.Convert.ToDouble(numericUpDown7.Value); // Shaft Weight/Mass
            double x11 = System.Convert.ToDouble(numericUpDown6.Value); // Sahft Lenght
            double x12 = 0; // Shaft Material
            double x13 = 0; // Load Type
            double x14 = System.Convert.ToDouble(numericUpDown12.Value); // Load Diameter
            double x15 = System.Convert.ToDouble(numericUpDown13.Value); // Load Width
            double x16 = System.Convert.ToDouble(numericUpDown11.Value); // Load Depth
            double x17 = System.Convert.ToDouble(numericUpDown10.Value); // Distance from the table center to the load center
            double x18 = System.Convert.ToDouble(numericUpDown14.Value); // Number of Loads
            double x19 = System.Convert.ToDouble(numericUpDown15.Value); // Load Weight/Mass
            double x20 = System.Convert.ToDouble(numericUpDown8.Value); // Load Height
            double x21 = 0; //Load Material
            double x22 = 0; //Friction coefficient between the table and the supporting mechanism
            double x24 = System.Convert.ToDouble(numericUpDown16.Value); // Distance from the table center to the supporting mechanism
            double x25 = System.Convert.ToDouble(numericUpDown17.Value); // System Efficiency
            double x26 = System.Convert.ToDouble(numericUpDown23.Value); // Primary pulley (gear) pitch circle diameter (PCD) or diameter
            double x27 = System.Convert.ToDouble(numericUpDown22.Value); // Primary pulley (gear) weight/mass
            double x28 = System.Convert.ToDouble(numericUpDown19.Value); // Primary pulley (gear) thickness
            double x29 = 0; // Primary pulley (gear) material
            double x30 = System.Convert.ToDouble(numericUpDown21.Value); // Secondary pulley (gear) pitch circle diameter (PCD) or diameter
            double x31 = System.Convert.ToDouble(numericUpDown20.Value); // Secondary pulley (gear) weight/mass
            double x32 = System.Convert.ToDouble(numericUpDown18.Value); //Secondary pulley (gear) thickness
            double x33 = 0; // Secondary pulley (gear) material
            double x34 = 0; // Mechanism Condition
            double x35 = 0; // It is necessary to hold the load even after the Power supply is turned off
            double x36 = 0; // It is necessary to hold the load after the motor is stopped, but not necessary to hold after the Power supply is turned off
            double x37 = 0; // Operating Conditions
            double x38 = System.Convert.ToDouble(numericUpDown35.Value); // Operating speed V1
            double x39 = System.Convert.ToDouble(numericUpDown34.Value); // Acceleration/Deceleration
            double x40 = System.Convert.ToDouble(numericUpDown33.Value); // Operating speed V1
            double x41 = System.Convert.ToDouble(numericUpDown31.Value); // Operating Speed V2
            double x42 = System.Convert.ToDouble(numericUpDown32.Value); // Acceleration/Deceleration
            double x43 = System.Convert.ToDouble(numericUpDown30.Value); // Rotor inertia
            double x44 = System.Convert.ToDouble(numericUpDown29.Value); // Gear Ratio
            double x45 = System.Convert.ToDouble(numericUpDown28.Value); // Positioning Distance
            double x46 = System.Convert.ToDouble(numericUpDown24.Value); // Positioning Time
            double x47 = System.Convert.ToDouble(numericUpDown25.Value); // Stopping Time
            double x48 = System.Convert.ToDouble(numericUpDown26.Value); // A specific acceleration / deceleration time is required
            double x49 = System.Convert.ToDouble(numericUpDown27.Value); // A specific operating speed is required
            double x50 = System.Convert.ToDouble(numericUpDown38.Value); // Stopping accuracy (deg)
            double x51 = System.Convert.ToDouble(numericUpDown37.Value); // Stopping accuracy (in/mm)
            double x52 = 0; //Safety factor

            // **********************************************************************************
            // *                                     ERRORS                                     *
            // **********************************************************************************
            int error = 0;

            if (x3 == 0 && radioButton2.Checked)
            {
                MessageBox.Show("Please select the table diameter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if(radioButton1.Checked && x4 ==0)
            {
                MessageBox.Show("Please enter the table size A", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (radioButton1.Checked && x5 == 0)
            {
                MessageBox.Show("Please enter the table size B", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x6 == 0 && x7 == 0)
            {
                MessageBox.Show("Please enter the table weight or the table thickness", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x6 == 0 && x7 != 0 && comboBox2.SelectedIndex == 0)
            {
                MessageBox.Show("Please choose the table material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x9 == 0)
            {
                MessageBox.Show("Please choose the shaft diameter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x9 == 0)
            {
                MessageBox.Show("Please choose the shaft diameter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x10 == 0 && x11 == 0)
            {
                MessageBox.Show("Please choose the shaft weight or length", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x10 == 0 && x11 != 0 && comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Please choose the shaft material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (radioButton5.Checked || radioButton3.Checked)
            {
                if (x14 == 0 && radioButton5.Checked)
                {
                    MessageBox.Show("Please enter the load diameter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error = 1;
                }
                else if (x15 == 0 && radioButton3.Checked)
                {
                    MessageBox.Show("Please enter the load size A", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error = 1;
                }
                else if (x16 == 0 && radioButton3.Checked)
                {
                    MessageBox.Show("Please enter the load size B", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error = 1;
                }
                else if (x17 == 0)
                {
                    MessageBox.Show("Please enter the distance from the table center to the load center", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error = 1;
                }
                else if (x18 == 0)
                {
                    MessageBox.Show("Please enter the number of loads", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error = 1;
                }
                else if (x19 == 0 && x20 == 0)
                {
                    MessageBox.Show("Please choose the load weight or length", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error = 1;
                }
                else if (x19 == 0 && x20 != 0 && comboBox3.SelectedIndex == 0)
                {
                    MessageBox.Show("Please choose the load material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error = 1;
                }
            }
            else if (comboBox4.SelectedIndex == 0 || (comboBox4.SelectedIndex == 5 && numericUpDown36.Value == 0))
            {
                MessageBox.Show("Please select the friction coefficient of the guide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x24 == 0)
            {
                MessageBox.Show("Please enter the distance from the table center to the suporting mechanism", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x25 == 0)
            {
                MessageBox.Show("Please enter the system efficiency", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x26 != 0 && x27 == 0 && x28 == 0)
            {
                MessageBox.Show("Please enter the primary pulley (gear) weight or the primary pulley (gear) thickness", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x26 != 0 && x27 == 0 && x28 != 0 && comboBox6.SelectedIndex == 0)
            {
                MessageBox.Show("Please select the primary pulley (gear) material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x26 != 0 && x30 == 0)
            {
                MessageBox.Show("Please enter both primary and secondary pulley diameter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x30 != 0 && x31 == 0 && x32 == 0)
            {
                MessageBox.Show("Please enter the primary pulley (gear) weight or the primary pulley (gear) thickness", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (x30 != 0 && x31 == 0 && x32 != 0 && comboBox5.SelectedIndex == 0)
            {
                MessageBox.Show("Please select the primary pulley (gear) material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (radioButton10.Checked)
            {
                if (x38 == 0)
                {
                    MessageBox.Show("Please enter the operating speed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error = 1;
                }
                else if (x39 == 0)
                {
                    MessageBox.Show("Please enter the Accelearation/Deceleration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error = 1;
                }
            }
            else if (radioButton9.Checked)
            {
                if (x40 == 0)
                {
                    MessageBox.Show("Please enter the operating speed V1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error = 1;
                }
                else if (x41 == 0)
                {
                    MessageBox.Show("Please enter the operating speed V2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error = 1;
                }
                else if (x42 == 0)
                {
                    MessageBox.Show("Please enter the Accelearation/Deceleration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error = 1;
                }
            }
            else if (radioButton8.Checked)
            {
                if (x45 == 0 && x49 == 0)
                {
                    MessageBox.Show("Please enter the operating distance or the specific operating speed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error = 1;
                }
                else if (x45 != 0 && x46 == 0)
                {
                    MessageBox.Show("Please enter the positioning time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error = 1;
                }
            }
            else if (x50 == 0 && x51 == 0)
            {
                MessageBox.Show("Please enter the Stopping Accuracy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }
            else if (comboBox7.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a safety factor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error = 1;
            }

            if (error == 0)
            {
                // **********************************************************************************
                // *                                 CALCULATIONS                                   *
                // **********************************************************************************

                //Transmission Gear Diameter Ratio
                ratio = ((x26 != 0) && (x30 != 0)) ? (x26 / x30) : 1;

                //Densities
                if (Imperial.Checked)
                {
                    x1 = 1;

                    // Material 1
                    if (comboBox2.SelectedIndex == 1)
                    {
                        x8 = 0.284;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        x8 = 0.289;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {
                        x8 = 0.098;
                    }
                    else if (comboBox2.SelectedIndex == 4)
                    {
                        x8 = 0.31;
                    }
                    else if (comboBox2.SelectedIndex == 5)
                    {
                        x8 = 0.06;
                    }

                    //Material 2
                    if (comboBox3.SelectedIndex == 1)
                    {
                        x21 = 0.284;
                    }
                    else if (comboBox3.SelectedIndex == 2)
                    {
                        x21 = 0.289;
                    }
                    else if (comboBox3.SelectedIndex == 3)
                    {
                        x21 = 0.098;
                    }
                    else if (comboBox3.SelectedIndex == 4)
                    {
                        x21 = 0.31;
                    }
                    else if (comboBox3.SelectedIndex == 5)
                    {
                        x21 = 0.06;
                    }

                    //Material 3
                    if (comboBox1.SelectedIndex == 1)
                    {
                        x12 = 0.284;
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        x12 = 0.289;
                    }
                    else if (comboBox1.SelectedIndex == 3)
                    {
                        x12 = 0.098;
                    }
                    else if (comboBox1.SelectedIndex == 4)
                    {
                        x12 = 0.31;
                    }
                    else if (comboBox1.SelectedIndex == 5)
                    {
                        x12 = 0.06;
                    }

                    //Material 4
                    if (comboBox6.SelectedIndex == 1)
                    {
                        x29 = 0.284;
                    }
                    else if (comboBox6.SelectedIndex == 2)
                    {
                        x29 = 0.289;
                    }
                    else if (comboBox6.SelectedIndex == 3)
                    {
                        x29 = 0.098;
                    }
                    else if (comboBox6.SelectedIndex == 4)
                    {
                        x29 = 0.31;
                    }
                    else if (comboBox6.SelectedIndex == 5)
                    {
                        x29 = 0.06;
                    }

                    //Material 5
                    if (comboBox5.SelectedIndex == 1)
                    {
                        x33 = 0.284;
                    }
                    else if (comboBox5.SelectedIndex == 2)
                    {
                        x33 = 0.289;
                    }
                    else if (comboBox5.SelectedIndex == 3)
                    {
                        x33 = 0.098;
                    }
                    else if (comboBox5.SelectedIndex == 4)
                    {
                        x33 = 0.31;
                    }
                    else if (comboBox5.SelectedIndex == 5)
                    {
                        x33 = 0.06;
                    }
                }
                else if (Metric.Checked)
                {
                    x1 = 2;

                    // Material 1
                    if (comboBox2.SelectedIndex == 1)
                    {
                        x8 = 7849.8;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        x8 = 7999.493;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {
                        x8 = 2712.631;
                    }
                    else if (comboBox2.SelectedIndex == 4)
                    {
                        x8 = 8580.771;
                    }
                    else if (comboBox2.SelectedIndex == 5)
                    {
                        x8 = 1660.794;
                    }

                    // Material 2
                    if (comboBox3.SelectedIndex == 1)
                    {
                        x21 = 7849.8;
                    }
                    else if (comboBox3.SelectedIndex == 2)
                    {
                        x21 = 7999.493;
                    }
                    else if (comboBox3.SelectedIndex == 3)
                    {
                        x21 = 2712.631;
                    }
                    else if (comboBox3.SelectedIndex == 4)
                    {
                        x21 = 8580.771;
                    }
                    else if (comboBox3.SelectedIndex == 5)
                    {
                        x21 = 1660.794;
                    }

                    // Material 3
                    if (comboBox1.SelectedIndex == 1)
                    {
                        x12 = 7849.8;
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        x12 = 7999.493;
                    }
                    else if (comboBox1.SelectedIndex == 3)
                    {
                        x12 = 2712.631;
                    }
                    else if (comboBox1.SelectedIndex == 4)
                    {
                        x12 = 8580.771;
                    }
                    else if (comboBox1.SelectedIndex == 5)
                    {
                        x12 = 1660.794;
                    }

                    // Material 4
                    if (comboBox6.SelectedIndex == 1)
                    {
                        x29 = 7849.8;
                    }
                    else if (comboBox6.SelectedIndex == 2)
                    {
                        x29 = 7999.493;
                    }
                    else if (comboBox6.SelectedIndex == 3)
                    {
                        x29 = 2712.631;
                    }
                    else if (comboBox6.SelectedIndex == 4)
                    {
                        x29 = 8580.771;
                    }
                    else if (comboBox6.SelectedIndex == 5)
                    {
                        x29 = 1660.794;
                    }

                    // Material 5
                    if (comboBox5.SelectedIndex == 1)
                    {
                        x33 = 7849.8;
                    }
                    else if (comboBox5.SelectedIndex == 2)
                    {
                        x33 = 7999.493;
                    }
                    else if (comboBox5.SelectedIndex == 3)
                    {
                        x33 = 2712.631;
                    }
                    else if (comboBox5.SelectedIndex == 4)
                    {
                        x33 = 8580.771;
                    }
                    else if (comboBox5.SelectedIndex == 5)
                    {
                        x33 = 1660.794;
                    }

                }

                //friction coefficience
                if (comboBox4.SelectedIndex == 1)
                {
                    x22 = 0.05;
                }
                else if (comboBox4.SelectedIndex == 2)
                {
                    x22 = 0.1;
                }
                else if (comboBox4.SelectedIndex == 3)
                {
                    x22 = 0.3;
                }
                else if (comboBox4.SelectedIndex == 4)
                {
                    x22 = 0.5;
                }
                else if (comboBox4.SelectedIndex == 5)
                {
                    x22 = System.Convert.ToDouble(numericUpDown36.Value);
                }

                //Safety Factor

                //y1
                if (radioButton2.Checked)
                {
                    //Round Table
                    if (x6 != 0)
                    {
                        y1 = (1 / 8) * (x6 * 16) * Math.Pow(x3, 2);
                        y1 = (Metric.Checked) ? y1 / (16 * Math.Pow(10, 6)) : y1;
                    }
                    else
                    {
                        y1 = (pi / 32) * x8 * x7 * Math.Pow(x3, 4);
                        y1 = (Metric.Checked) ? y1 / (Math.Pow(10, 15)) : y1;
                    }
                }
                else
                {
                    //Rectangular table 
                    if (x6 != 0)
                    {
                        y1 = (1 / 12) * (x6 * 16) * (Math.Pow(x4, 2) + Math.Pow(x5, 2));
                        y1 = (Metric.Checked) ? y1 / (16 * (Math.Pow(10, 6))) : y1;
                    }
                    else
                    {
                        y1 = (1 / 12) * x8 * x4 * x5 * x7 * (Math.Pow(x4, 2) + Math.Pow(x5, 2));
                        y1 = (Metric.Checked) ? y1 / (Math.Pow(10, 15)) : y1;
                    }
                }


                if (x10 != 0)
                {
                    y2 = (1 / 8) * (x10 * 16) * Math.Pow(x9, 2);
                    y2 = (Metric.Checked) ? y2 / (16 * (Math.Pow(10, 6))) : y2;
                }
                else
                {
                    y2 = (pi / 32) * x12 * x11 * Math.Pow(x9, 4);
                    y2 = (Metric.Checked) ? y2 / (Math.Pow(10, 15)) : y2;
                }

                if (radioButton4.Checked)
                {
                    //No Additional Load
                    y3 = 0;
                }
                else if (radioButton5.Checked)
                {
                    if (x19 != 0)
                    {
                        //Cylinder Type
                        y3 = ((1 / 8) * (x19 * 16) * Math.Pow(x14, 2) + (x19 * 16) * Math.Pow(x17, 2)) * x18;
                        y3 = (Metric.Checked) ? y3 / (16 * (Math.Pow(10, 6))) : y3;
                    }
                    else
                    {
                        y3 = ((pi / 32) * x21 * x20 * Math.Pow(x14, 4) + (pi / 4) * x21 * x20 * Math.Pow(x14, 2) * Math.Pow(x17, 2)) * x18;
                        y3 = (Metric.Checked) ? y3 / (Math.Pow(10, 15)) : y3;
                    }
                }
                else
                {
                    if (x19 != 0)
                    {
                        y3 = (1 / 12) * (x19 * 16) * (Math.Pow(x15, 2) + Math.Pow(x16, 2) + 12 * Math.Pow(x17, 2)) * x18;
                        y3 = (Metric.Checked) ? y3 / (16 * (Math.Pow(10, 6))) : y3;
                    }
                    else
                    {
                        y3 = (1 / 12) * (x21 * x15 * x16 * x20) * (Math.Pow(x15, 2) + Math.Pow(x16, 2) + 12 * Math.Pow(x17, 2)) * x18;
                        y3 = (Metric.Checked) ? y3 / (Math.Pow(10, 15)) : y3;
                    }
                }

                if (x26 == 0 || x30 == 0)
                {
                    y4 = 0;
                    y5 = 0;
                    y6 = y1 + y2 + y3;
                }
                else
                {
                    if (x27 != 0)
                    {
                        y4 = (1 / 8) * (x27) * 16 * Math.Pow(x26, 2);
                        y4 = (Metric.Checked) ? y4 / (16 * (Math.Pow(10, 6))) : y4;
                    }
                    else
                    {
                        y4 = (pi / 32) * x29 * x28 * Math.Pow(x26, 4);
                        y4 = (Metric.Checked) ? y4 / (Math.Pow(10, 15)) : y4;
                    }

                    if (x31 != 0)
                    {
                        y5 = (1 / 8) * (x31) * 16 * Math.Pow(x30, 2);
                        y5 = (Metric.Checked) ? y5 / (16 * (Math.Pow(10, 6))) : y5;
                    }
                    else
                    {
                        y5 = (pi / 32) * (x33) * (x32) * Math.Pow(x30, 4);
                        y5 = (Metric.Checked) ? y5 / Math.Pow(10, 15) : y5;
                    }

                    y6 = (y1 + y2 + y3 + y5) * Math.Pow(x26 / x30, 2) + y4;
                }

                if (radioButton10.Checked)
                {
                    //Fixed Speed Operation
                    y7 = x38 / ratio;
                    t1 = x39;
                    y10 = (y6 / 386) * (y7 / (9.55 * x39)) * (1 / 16);
                }
                else if (radioButton8.Checked)
                {
                    //Positioning Operation   
                    pso = 1;
                    x48 = (x48 != 0) ? x48 : x46 * 0.25;
                    //setValue("X48", X[48]);
                    if (x49 != 0)
                    {
                        y7 = x49 / ratio;
                    }
                    else if (x45 != 0)
                    {
                        y7 = (x45 / 360) * (60 / (x46 - x48)) / ratio;
                    }

                    if ((x44 == 0) && (x43 == 0))
                    {
                        y10 = ((1.2 * y6) / 386) * (y7 / (9.55 * x48)) * (1 / 16);
                    }
                    else if (x44 == 0)
                    {
                        y10 = ((x43 + y6) / 386) * (y7 / (9.55 * x48)) * (1 / 16);
                    }
                    else
                    {
                        y10 = ((x43 * Math.Pow(x44, 2) + y6) / 386) * (y7 / (9.55 * x48)) * (1 / 16);
                    }
                }
                else if (radioButton9.Checked)
                {
                    //Variable Speed Operation
                    vso = 1;
                    y8 = x40 / ratio;
                    y9 = x41 / ratio;
                    if (y8 > y9)
                    {
                        y10 = (y6 / 386) * (y8 / (9.55 * x42)) * (1 / 16);
                    }
                    else
                    {
                        y10 = (y6 / 386) * (y9 / (9.55 * x42)) * (1 / 16);
                    }
                }
                y10 = (Metric.Checked) ? (y10 * 386 * 16) : y10;
                // y11 is only for Imperial
                y11 = (Metric.Checked) ? 0 : y10 * 16;

                //y12 is y11 in Metric
                if (x6 != 0)
                {
                    y12 = x6;
                }
                else if (radioButton2.Checked)
                {
                    //Round Table
                    y12 = (1 / 16) * (pi / 4) * x8 * x7 * Math.Pow(x3, 2);
                    y12 = (Metric.Checked) ? y12 * 16 / (Math.Pow(10, 9)) : y12;
                }
                else
                {
                    //Rectangular table 
                    y12 = (1 / 16) * x8 * x4 * x5 * x7;
                    y12 = (Metric.Checked) ? y12 * 16 / (Math.Pow(10, 9)) : y12;
                }

                //y13 is y12 in metric
                if (radioButton4.Checked)
                {
                    //No additional load
                    y13 = 0;
                }
                else if (x19 != 0)
                {
                    y13 = x19 * x18;
                }
                else if (radioButton5.Checked && x20 != 0)
                {
                    //Cylinder type
                    y13 = (1 / 16) * (pi / 4) * x21 * x20 * Math.Pow(x14, 2) * x18;
                    y13 = (Metric.Checked) ? y13 * 16 / (Math.Pow(10, 9)) : y13;
                }
                else if (radioButton5.Checked && x20 != 0)
                {
                    //Rectangular pillar type
                    y13 = (1 / 16) * x21 * x15 * x16 * x20 * x18;
                    y13 = (Metric.Checked) ? y13 * 16 / (Math.Pow(10, 9)) : y13;
                }

                //y14 is y13 in metric
                if (radioButton7.Checked)
                {
                    //Horizontal operation
                    y14 = (y12 + y13) * x22 * x24 * (1 / (x25 * 0.01)) * ratio;
                    y14 = (Metric.Checked) ? y14 * 9.8 / (Math.Pow(10, 3)) : y14;
                }
                else
                {
                    //Vertical operation
                    y14 = (y13 / 2) * x17 * (1 / (x25 * 0.01)) * ratio;
                    y14 = (Metric.Checked) ? y14 * 9.8 / (Math.Pow(10, 3)) : y14;
                }

                //y15 is only for Imperial
                y15 = (Metric.Checked) ? 0 : y14 * 16;

                y16 = (y10 + y14) * x52;

                //y17 is only for Imperial
                y17 = (Metric.Checked) ? 0 : y16 * 16;

                if (radioButton8.Checked)
                {
                    //Positioning Operation
                    y18 = Math.Sqrt((((Math.Pow((y10 + y14), 2) * x48)) + (Math.Pow(y14, 2) * (x46 - 2 * x48)) + (Math.Pow(y10 - y14, 2) * x48)) / (x46 + x47)) * x52;
                    y19 = (Metric.Checked) ? 0 : y18 * 16;
                }
                else
                {
                    y18 = -1; //"N/A"
                    y19 = -1; //"N/A"
                }

                // y20 is y16 in Metric
                if (x50 != 0)
                {
                    y20 = x50 / ratio;
                }
                else if (x51 != 0)
                {
                    if (radioButton2.Checked && radioButton4.Checked)
                    {
                        y20 = x51 * (360 / (pi * x3)) / ratio;
                    }
                    else
                    {
                        y20 = x51 * (360 / (2 * pi * x17)) / ratio;
                    }

                    /*if (Y[7] && Y[7] != "N/A")
                    {
                        setValue("Y7Y8", Y[7]);
                    }
                    else
                    {
                        setValue("Y7Y8", Y[8]);
                    }*/
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

                //Pressing Button Actions
                TableResults frm = new TableResults(y6, y7, y16, y17, y10, y11, y14, y15, y20, x1, ch1, ch2, vso, y8, pso, y18, y19);
                frm.Show();
                //this.Hide();

            } //End of no Error
        } //End of Calculations

        private void radioButton8_CheckedChanged_1(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
                //Expand Panel 2
                splitContainer9.Height = 800;


            }
            panel3.Visible = false;
            panel1.Visible = false;
        }

        private void Imperial_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "in";
            label11.Text = "in";
            label15.Text = "in";
            label26.Text = "in";
            label19.Text = "in";
            label48.Text = "in";
            label42.Text = "in";
            label40.Text = "in";
            label53.Text = "in";
            label67.Text = "in";
            label36.Text = "in";
            label147.Text = "in";
            txt4.Text = "in";
            txt9.Text = "in";
            txt13.Text = "in";
            txt18.Text = "in";
            txt20.Text = "in";
            label13.Text = "lb";
            label22.Text = "lb";
            txt12.Text = "lb";
            txt16.Text = "lb";
            label5.Text = "Table weight ";
            label6.Text = "If you are not sure about the weight ";
            label14.Text = "W =";
            label31.Text = "Shaft weight ";
            label23.Text = "W   =";
            label59.Text = "Weight of load ";
            label58.Text = "W  =";
            label57.Text = "lb/pc";
            txt10.Text = "Primary pulley (gear) weight ";
            txt14.Text = "Secondary pulley (gear) weight ";
            txt11.Text = "W   =";
            txt15.Text = "W   =";
            txt17.Text = "If you are not sure about the Weight";
            txt19.Text = "If you are not sure about the Weight";
            txt21.Text = "in/s";
            txt22.Text = "in/s";
            txt23.Text = "in/s";
            txt24.Text = "oz · in";
            txt26.Text = "in/s";
        }

        private void Metric_CheckedChanged_1(object sender, EventArgs e)
        {
            label9.Text = "mm";
            label11.Text = "mm";
            label15.Text = "mm";
            label26.Text = "mm";
            label19.Text = "mm";
            label48.Text = "mm";
            label42.Text = "mm";
            label40.Text = "mm";
            label53.Text = "mm";
            label67.Text = "mm";
            label36.Text = "mm";
            label147.Text = "mm";
            txt4.Text = "mm";
            txt9.Text = "mm";
            txt13.Text = "mm";
            txt18.Text = "mm";
            txt20.Text = "mm";
            label13.Text = "kg";
            label22.Text = "kg";
            txt12.Text = "kg";
            txt16.Text = "kg";
            label5.Text = "Table mass ";
            label6.Text = "If you are not sure about the mass ";
            label14.Text = "m =";
            label31.Text = "Shaft mass ";
            label23.Text = "m   =";
            label59.Text = "Mass of load ";
            label58.Text = "m  =";
            label57.Text = "kg/pc";
            txt10.Text = "Primary pulley (gear) mass ";
            txt14.Text = "Secondary pulley (gear) mass ";
            txt11.Text = "m   =";
            txt15.Text = "m   =";
            txt17.Text = "If you are not sure about the mass";
            txt19.Text = "If you are not sure about the mass";
            txt21.Text = "r/min";
            txt22.Text = "r/min";
            txt23.Text = "r/min";
            txt24.Text = "kg · m";
            txt26.Text = "r/min";
        }

        private void radioButton10_CheckedChanged_1(object sender, EventArgs e)
        {
            splitContainer9.Height = 275;
            panel3.Visible = true;
            panel2.Visible = false;
            panel1.Visible = false;
        }

        private void radioButton9_CheckedChanged_1(object sender, EventArgs e)
        {
            splitContainer9.Height = 275;
            panel3.Visible = false;
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void radioButton8_CheckedChanged_2(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
                //Expand Panel 2
                splitContainer9.Height = 800;


            }
            panel3.Visible = false;
            panel1.Visible = false;
        }

        private void numericUpDown36_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 5)
            {
                label150.Text = "Please enter the friction coefficient";
                label151.Text = "μ =";
                numericUpDown36.Visible = true;
            }
            else
            {
                label150.Text = " ";
                label151.Text = " ";
                numericUpDown36.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TableSizing NewForm = new TableSizing();
            NewForm.Show();
            this.Dispose(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main NewForm = new Main();
            NewForm.Show();
            this.Dispose(false);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown3.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown1.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown3.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown1.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown10.Enabled = false;
            numericUpDown11.Enabled = false;
            numericUpDown12.Enabled = false;
            numericUpDown13.Enabled = false;
            numericUpDown14.Enabled = false;
            numericUpDown15.Enabled = false;
            numericUpDown8.Enabled = false;
            comboBox3.Enabled = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown10.Enabled = true;
            numericUpDown11.Enabled = false;
            numericUpDown12.Enabled = true;
            numericUpDown13.Enabled = false;
            numericUpDown14.Enabled = true;
            numericUpDown15.Enabled = true;
            numericUpDown8.Enabled = true;
            comboBox3.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown10.Enabled = true;
            numericUpDown11.Enabled = true;
            numericUpDown12.Enabled = false;
            numericUpDown13.Enabled = true;
            numericUpDown14.Enabled = true;
            numericUpDown15.Enabled = true;
            numericUpDown8.Enabled = true;
            comboBox3.Enabled = true;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown4.Value != 0)
            {
                numericUpDown5.Enabled = false;
                comboBox2.Enabled = false;
            }
            else if (numericUpDown4.Value.Equals(0))
            {
                numericUpDown5.Enabled = true;
                comboBox2.Enabled = true;
            }
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown7.Value != 0)
            {
                numericUpDown6.Enabled = false;
                comboBox1.Enabled = false;
            }
            else if (numericUpDown7.Value.Equals(0))
            {
                numericUpDown6.Enabled = true;
                comboBox1.Enabled = true;
            }
        }

        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown15.Value != 0)
            {
                numericUpDown8.Enabled = false;
                comboBox3.Enabled = false;
            }
            else if (numericUpDown15.Value.Equals(0))
            {
                numericUpDown8.Enabled = true;
                comboBox3.Enabled = true;
            }
        }

        private void numericUpDown22_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown22.Value != 0)
            {
                numericUpDown19.Enabled = false;
                comboBox6.Enabled = false;
            }
            else if (numericUpDown22.Value.Equals(0))
            {
                numericUpDown19.Enabled = true;
                comboBox6.Enabled = true;
            }
        }

        private void numericUpDown20_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown20.Value != 0)
            {
                numericUpDown18.Enabled = false;
                comboBox5.Enabled = false;
            }
            else if (numericUpDown20.Value.Equals(0))
            {
                numericUpDown18.Enabled = true;
                comboBox5.Enabled = true;
            }
        }

        private void numericUpDown28_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown28.Value != 0)
            {
                numericUpDown27.Enabled = false;
            }
            else if (numericUpDown28.Value.Equals(0))
            {
                numericUpDown27.Enabled = true;
            }
        }

        private void numericUpDown27_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown27.Value != 0)
            {
                numericUpDown28.Enabled = false;
                numericUpDown24.Enabled = false;
            }
            else if (numericUpDown27.Value.Equals(0))
            {
                numericUpDown28.Enabled = true;
                numericUpDown24.Enabled = true;
            }
        }

        private void numericUpDown38_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown38.Value != 0)
            {
                numericUpDown37.Enabled = false;
            }
            else if (numericUpDown38.Value.Equals(0))
            {
                numericUpDown37.Enabled = true;
            }
        }

        private void numericUpDown37_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown37.Value != 0)
            {
                numericUpDown38.Enabled = false;
            }
            else if (numericUpDown37.Value.Equals(0))
            {
                numericUpDown38.Enabled = true;
            }
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown5.Value != 0)
            {
                numericUpDown4.Enabled = false;
            }
            else if (numericUpDown5.Value.Equals(0))
            {
                numericUpDown4.Enabled = true;
            }
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown6.Value != 0)
            {
                numericUpDown7.Enabled = false;
            }
            else if (numericUpDown6.Value.Equals(0))
            {
                numericUpDown7.Enabled = true;
            }
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown8.Value != 0)
            {
                numericUpDown15.Enabled = false;
            }
            else if (numericUpDown8.Value.Equals(0))
            {
                numericUpDown15.Enabled = true;
            }
        }

        private void numericUpDown19_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown19.Value != 0)
            {
                numericUpDown22.Enabled = false;
            }
            else if (numericUpDown19.Value.Equals(0))
            {
                numericUpDown22.Enabled = true;
            }
        }

        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown18.Value != 0)
            {
                numericUpDown20.Enabled = false;
            }
            else if (numericUpDown18.Value.Equals(0))
            {
                numericUpDown20.Enabled = true;
            }
        }
    }
}
