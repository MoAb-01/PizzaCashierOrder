using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderYourPizza
{
    public partial class FrmMain: Form
    {
        public FrmMain()
        {
            InitializeComponent();
            
        }
        //---- price modifiers-----
        float GetSelectedSizePrice()
        {
            if (Rad_small.Checked)
            {
                return Convert.ToSingle(Rad_small.Tag);
            }
            else if (Rad_med.Checked)
            {
                return Convert.ToSingle(Rad_med.Tag);
            }
            else if (Rad_Larg.Checked)
            {
                return Convert.ToSingle(Rad_Larg.Tag);
            }
            return 0;
           
        }

        private float GetSelectedToppingsPrice()
        {

            float toppingsTotalPrice = 0; // cuz we have many options to choose from not radio
            if (chk_cheese.Checked)
            {
                toppingsTotalPrice += Convert.ToSingle(chk_cheese.Tag);
            }

            if (chk_mush.Checked)
            {
                toppingsTotalPrice += Convert.ToSingle(chk_mush.Tag);
            }
            if(chk_olives.Checked)
            {
                toppingsTotalPrice += Convert.ToSingle(chk_olives.Tag);
            }

            if (chk_onion.Checked)
            {
                toppingsTotalPrice += Convert.ToSingle(chk_onion.Tag);

            }
            if (chk_tomatoes.Checked)
            {
                toppingsTotalPrice += Convert.ToSingle(chk_tomatoes.Tag);
            }
            return toppingsTotalPrice;
        }
        
       float  GetSelectedCrustPrice()
        {
            if(Rad_thick.Checked)
            {
                return Convert.ToSingle(Rad_thick.Tag);

            }
            else
            {
                return Convert.ToSingle(Rad_thick.Tag);
            }
        }
        private float GetQuantity()
        {
            return Convert.ToSingle(numericUpDown1.Tag);
        }
        private float CalculateTotalPrice()
        {
            return  GetQuantity() * ( GetSelectedSizePrice() + GetSelectedToppingsPrice() + GetSelectedCrustPrice() );
        }
        private void UpdateTotalPrice()
        {
            lblPrice.Text = "$" + CalculateTotalPrice().ToString();
        }
        


        //------------ Toppings label change--------


        private void UpdateQuantity()
        {
            UpdateTotalPrice();

        }
        private void UpdateToppings()
        {
            //price updated automatically by checking what is currently checked for each part
            UpdateTotalPrice();
            string sToppings = "";
            if (chk_cheese.Checked)
            {
                sToppings += "* Extra-Cheese\n";
            }

            if (chk_mush.Checked)
            {
                sToppings += "* Mushroom\n";
            }
            if (chk_olives.Checked)
            {
                sToppings += "* Olives\n";
            }

            if (chk_onion.Checked)
            {
                sToppings += "* Onions\n";
            }
            if (chk_tomatoes.Checked)
            {
                sToppings += "* Tomatoes\n";
            }
            if (chk_GreenPepper.Checked)
            {
                sToppings += "* Green Peppers\n";
            }

            //handle edge cases
            if (sToppings == "")
            {
                sToppings = "No Toppings";
            }
            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim(); //substring(start indx, length)
            }
            lblToppings.Text ="Toppings:\n"+ sToppings;
        }

        //------------ size label change--------

        private void UpdateSize()
        {
            UpdateTotalPrice();
            if (Rad_small.Checked)
            {
                lblSize.Text = "Size: Small";
                return;
            }

            if (Rad_med.Checked)
            {
                lblSize.Text = "Size: Medium";
                return;
            }
            if (Rad_Larg.Checked)
            {
                lblSize.Text = "Size: Large";
                return;
            }
        }

        // -------- Update Crust ------
        private void updateCrust()
        {
            UpdateTotalPrice();
            if (Rad_thick.Checked)
            {
                lblSize.Text = "Curst: Thick";
                return;
            }
            if (Rad_think.Checked)
            {
                lblSize.Text = "Curst: Think";
            }
            
        }
        private void btn_ShowForm1_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_showForm2_Click(object sender, EventArgs e)
        {
         
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }
        private void update_label3(object sender,EventArgs e)
        {
            
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            welcome wlcmform=new welcome();
            wlcmform.Close();
            numericUpDown1.Maximum = 5;
        }

        private void gb_size_Enter(object sender, EventArgs e)
        {

        }

        private void Rad_small_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void Rad_med_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void Rad_Larg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void Rad_thick_CheckedChanged(object sender, EventArgs e)
        {
            updateCrust();
        }

        private void Rad_think_CheckedChanged(object sender, EventArgs e)
        {
            updateCrust();
        }

        private void chk_cheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chk_mush_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chk_tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void gb_toppings_Enter(object sender, EventArgs e)
        {
            
        }

        private void chk_onion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chk_olives_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void lblSize_Click(object sender, EventArgs e)
        {
          
        }

        private void lbl3_changeText()
        {
        }

        private void lblToppings_Click(object sender, EventArgs e)
        {

        }

        private void lblEat_Click(object sender, EventArgs e)
        {

        }

        private void Rad_Eatin_CheckedChanged(object sender, EventArgs e)
        {
            if (Rad_Eatin.Checked)
            {
                lblEat.Text = "Where To Eat,\n    " + Rad_Eatin.Text;
            }
        }

        private void Rad_Eatout_CheckedChanged(object sender, EventArgs e)
        {
            if (Rad_Eatout.Checked)
            {
                lblEat.Text = "Where To Eat,\n    " + Rad_Eatout.Text;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

            // Enabling the groups
            gb_eat.Enabled = true;
            gb_size.Enabled = true;
            gb_toppings.Enabled = true;
            gb_crust.Enabled = true;
            //disabling the toppings
            chk_cheese.Checked = false;
            chk_mush.Checked = false;
            chk_olives.Checked = false;
            chk_onion.Checked = false;
            chk_tomatoes.Checked = false;
            chk_GreenPepper.Checked = false;
            
            Rad_Eatin.Checked = true;
            Rad_Eatout.Checked = false;

            btn_Order.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(numericUpDown1.Value<=0)
            {
                errorProvider1.SetError(numericUpDown1, "Qunatity Can Not Be Less than zero");
                return;
            }
            else
            {
                errorProvider1.SetError(numericUpDown1, ""); //clear to the error icon
            }

            

            if (MessageBox.Show("Are You Sure You Want To Confirm The Order? ", "Order Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                gb_eat.Enabled = false;
                gb_size.Enabled = false;
                gb_toppings.Enabled = false;
                gb_crust.Enabled = false;

                btn_Order.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Tag= numericUpDown1.Value;
            UpdateQuantity();
        }

        private void gb_box_quantity_Enter(object sender, EventArgs e)
        {

        }
    }
}
