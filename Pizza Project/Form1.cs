using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public int Sum = 0;
        public new String Size = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Toppings_Extra_Chees.Checked)
            {
                lbl_Toppings_Answere.Text += " Extra Chees ";
                Sum += int.Parse(ckb_Toppings_Extra_Chees.Tag.ToString());
                lbl_Total_Price_Number.Text = "$" + Sum;
            }
            else
            {
                string topping = " Extra Chees ";
                if (lbl_Toppings_Answere.Text.Contains(topping))
                {
                    int index = lbl_Toppings_Answere.Text.IndexOf(topping);
                    lbl_Toppings_Answere.Text = lbl_Toppings_Answere.Text.Remove(index, topping.Length);
                    Sum -= int.Parse(ckb_Toppings_Extra_Chees.Tag.ToString());
                    lbl_Total_Price_Number.Text = "$" + Sum;
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb_Plase_In.Checked)
            {
                Sum += 5;
                lbl_Total_Price_Number.Text = "$" + Sum;
                lbl_Where_To_Eat.Text = "Indore";

            }
            else
            {
                Sum -= 5;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Toppings_Tomatoes.Checked)
            {
                lbl_Toppings_Answere.Text += " Tomatoes ";
                Sum += int.Parse(ckb_Toppings_Tomatoes.Tag.ToString());
                lbl_Total_Price_Number.Text = "$" + Sum;
            }
            else
            {
                string topping = " Tomatoes ";
                if (lbl_Toppings_Answere.Text.Contains(topping))
                {
                    int index = lbl_Toppings_Answere.Text.IndexOf(topping);
                    lbl_Toppings_Answere.Text = lbl_Toppings_Answere.Text.Remove(index, topping.Length);
                    Sum -= int.Parse(ckb_Toppings_Tomatoes.Tag.ToString());
                    lbl_Total_Price_Number.Text = "$" + Sum;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Toppings_Mashrooms.Checked)
            {
                lbl_Toppings_Answere.Text += " Mashrooms ";
                Sum += int.Parse(ckb_Toppings_Mashrooms.Tag.ToString());
                lbl_Total_Price_Number.Text = "$" + Sum;
            }
            else
            {
                string topping = " Mashrooms ";
                if (lbl_Toppings_Answere.Text.Contains(topping))
                {
                    int index = lbl_Toppings_Answere.Text.IndexOf(topping);
                    lbl_Toppings_Answere.Text = lbl_Toppings_Answere.Text.Remove(index, topping.Length);
                    Sum -= int.Parse(ckb_Toppings_Mashrooms.Tag.ToString());
                    lbl_Total_Price_Number.Text = "$" + Sum;
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Size_Answere.Text = " Large";
            if (rdb_Size_Large.Checked)
            {
                Sum += int.Parse(rdb_Size_Large.Tag.ToString());
                lbl_Total_Price_Number.Text = "$" + Sum;
            }
            else
            {
                Sum -= int.Parse(rdb_Size_Large.Tag.ToString());
                lbl_Total_Price_Number.Text = "$" + Sum;

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Cust_Then.Checked)
            {
                label2.Text = "Then";
                Sum += int.Parse(rdb_Cust_Then.Tag.ToString());
                lbl_Total_Price_Number.Text = "$" + Sum;


            }
            else
            {
                Sum -= int.Parse(rdb_Cust_Then.Tag.ToString());
                lbl_Total_Price_Number.Text = "$" + Sum;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Cust_Think.Checked)
            {
                label2.Text = "Think";
                Sum += int.Parse(rdb_Cust_Think.Tag.ToString());
                lbl_Total_Price_Number.Text = "$" + Sum;
            }
            else
            {
                Sum -= int.Parse(rdb_Cust_Think.Tag.ToString());
                lbl_Total_Price_Number.Text = "$" + Sum;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Size_Answere.Text = " Small";
            if (rdb_Size_Small.Checked)
            {
                Sum += int.Parse(rdb_Size_Small.Tag.ToString());
                lbl_Total_Price_Number.Text = "$" + Sum;
            }
            else
            {
                Sum -= int.Parse(rdb_Size_Small.Tag.ToString());
                lbl_Total_Price_Number.Text = "$" + Sum;

            }

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Plase_Out.Checked)
            {
                lbl_Where_To_Eat.Text = "Outdoor";
            }
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            grp_Cust.Enabled = false;
            grp_Place.Enabled = false;
            grp_Size.Enabled = false;
            grp_Toppers.Enabled = false;
            MessageBox.Show("Order has Successfully done", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Rest_Form_Click(object sender, EventArgs e)
        {
            // Enable all groups
            grp_Cust.Enabled = true;
            grp_Place.Enabled = true;
            grp_Size.Enabled = true;
            grp_Toppers.Enabled = true;
            

            // Reset all radio buttons and checkboxes
            foreach (Control group in new[] { grp_Cust, grp_Place, grp_Size, grp_Toppers })
            {
                foreach (Control ctrl in group.Controls)
                {
                    if (ctrl is RadioButton rb)
                        rb.Checked = false;
                    if (ctrl is CheckBox cb)
                        cb.Checked = false;
                }
            }

            // Reset labels
            lbl_Toppings_Answere.Text = "";
            lbl_Size_Answere.Text = "";
            lbl_Where_To_Eat.Text = "";
            label2.Text = "";
            lbl_Total_Price_Number.Text = "$0";

            // Reset sum and size
            Sum = 0;
            Size = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Size_Click(object sender, EventArgs e)
        {
            
        }

        private void rdb_Size_Med_CheckedChanged(object sender, EventArgs e)
        {
           lbl_Size_Answere.Text= " Meduim";
            if (rdb_Size_Med.Checked)
            {
                Sum += int.Parse(rdb_Size_Med.Tag.ToString());
                lbl_Total_Price_Number.Text = "$" + Sum;
            }
            else
            {
                Sum -= int.Parse(rdb_Size_Med.Tag.ToString());
                lbl_Total_Price_Number.Text = "$" + Sum;

            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void ckb_Toppings_Onion_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Toppings_Onion.Checked)
            {
                lbl_Toppings_Answere.Text += " Onion ";
                Sum += int.Parse(ckb_Toppings_Onion.Tag.ToString());
                lbl_Total_Price_Number.Text =       "$" + Sum;
            }
            else
            {
                string topping = " Onion ";
                if (lbl_Toppings_Answere.Text.Contains(topping))
                {
                    int index = lbl_Toppings_Answere.Text.IndexOf(topping);
                    lbl_Toppings_Answere.Text = lbl_Toppings_Answere.Text.Remove(index, topping.Length);
                    Sum -= int.Parse(ckb_Toppings_Onion.Tag.ToString());
                    lbl_Total_Price_Number.Text = "$" + Sum;
                }
            }
        }

        private void lbl_Toppings_Answere_Click(object sender, EventArgs e)
        {

        }

        private void ckb_Toppings_Olives_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Toppings_Olives.Checked)
            {
                lbl_Toppings_Answere.Text += " Olives ";
                Sum += int.Parse(ckb_Toppings_Olives.Tag.ToString());
                lbl_Total_Price_Number.Text = "$" + Sum;
            }
            else
            {
                string topping = " Olives ";
                if (lbl_Toppings_Answere.Text.Contains(topping))
                {
                    int index = lbl_Toppings_Answere.Text.IndexOf(topping);
                    lbl_Toppings_Answere.Text = lbl_Toppings_Answere.Text.Remove(index, topping.Length);
                    Sum -= int.Parse(ckb_Toppings_Olives.Tag.ToString());
                    lbl_Total_Price_Number.Text = "$" + Sum;
                }
            }
        }

        private void ckb_Toppings_Green_Peppers_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Toppings_Green_Peppers.Checked)
            {
                lbl_Toppings_Answere.Text += " Green Peppers ";
                Sum += int.Parse(ckb_Toppings_Green_Peppers.Tag.ToString());
                lbl_Total_Price_Number.Text = "$" + Sum;
            }
            else
            {
                string topping = " Green Peppers ";
                if (lbl_Toppings_Answere.Text.Contains(topping))
                {
                    int index = lbl_Toppings_Answere.Text.IndexOf(topping);
                    lbl_Toppings_Answere.Text = lbl_Toppings_Answere.Text.Remove(index, topping.Length);
                    Sum -= int.Parse(ckb_Toppings_Green_Peppers.Tag.ToString());
                    lbl_Total_Price_Number.Text = "$" + Sum;
                }
            }
        }

        private void lbl_Total_Price_Number_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void lbl_Where_To_Eatr_Click(object sender, EventArgs e)
        {

        }

        private void btn_Rest_Mouse_Down(object sender, MouseEventArgs e)
        {
           
        }
    }
}
