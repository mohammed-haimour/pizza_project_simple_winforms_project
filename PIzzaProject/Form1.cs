using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIzzaProject
{
    public partial class PizzaWindow : Form
    {
        public PizzaWindow()
        {
            InitializeComponent();
        }

        private int totalPrice = 0;

        private List<string> toppingsList = new List<string>();

        void calculate(int number) {
            int quantity = 1 + int.Parse(numericUpDown1.Value.ToString());

            totalPrice = (totalPrice + number) * quantity;
            label8.Text = $"{totalPrice}$";
            label13.Text = string.Join(" , ",toppingsList);
            if (toppingsList.Count == 0)
            {
            }
            else { 
                label13.Text += ",";
            }
        }

        private void sizeSmallRadiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sizeSmallRadiobtn.Checked)
            {
                calculate(5);
                label9.Text = "Small";
            }
            else { 
                calculate(-5);
            }
        }

        private void sizeGroupbox_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                calculate(15);
                label9.Text = "Medium";

            }
            else
            {
                calculate(-15);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                calculate(30);
                label9.Text = "Large";
            }
            else
            {
                calculate(-30);
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                calculate(3);
                label10.Text = "Thin";
            }
            else
            {
                calculate(-3);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                calculate(6);
                label10.Text = "Thick";

            }
            else
            {
                calculate(-6);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = "Take Out";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = "Eat In";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            calculate(0);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                toppingsList.Add("Extra Chees");

                calculate(2);
            }
            else
            {
                toppingsList.Remove("Extra Chees");

                calculate(-2);

            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                toppingsList.Add("Mashroms");
                calculate(2);
            }
            else
            {
                toppingsList.Remove("Mashroms");
                calculate(-2);

            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                toppingsList.Add("Tomattos");
                calculate(2);
            }
            else
            {
                toppingsList.Remove("Tomattos");
                calculate(-2);

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                toppingsList.Add("Green papers");
                calculate(2);
            }
            else
            {
                toppingsList.Remove("Green papers");
                calculate(-2);

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                toppingsList.Add("Olive");
                calculate(2);
            }
            else
            {
                toppingsList.Remove("Olive");
                calculate(-2);

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                toppingsList.Add("Onion");
                calculate(2);
            }
            else
            {
                toppingsList.Remove("Onion");
                calculate(-2);

            }
        }
    }
}
