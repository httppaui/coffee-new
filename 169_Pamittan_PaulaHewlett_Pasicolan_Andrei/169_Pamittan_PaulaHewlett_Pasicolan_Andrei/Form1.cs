using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _169_Pamittan_PaulaHewlett_Pasicolan_Andrei
{
    public partial class frmScarbats : Form
    {
        int item1 = 120, item2 = 110, item3 = 125, item4 = 150, item5 = 90, item6 = 135, item7 = 155, item8 = 162;

        private void chkCreamyCaramel_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkCreamyCaramel.Checked)
            {
                nuD1.Enabled = false;
                nuD1.Value = 0;
            }
            else
            {
                nuD1.Enabled = true;
                nuD1.Value = 1;
            }
        }

        private void chkSaltedCaramel_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSaltedCaramel.Checked)
            {
                nuD2.Enabled = false;
                nuD2.Value = 0;
            }
            else
            {
                nuD2.Enabled = true;
                nuD2.Value = 1;
            }
        }

        private void chkVanilla_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkVanilla.Checked)
            {
                nuD3.Enabled = false;
                nuD3.Value = 0;
            }
            else
            {
                nuD3.Enabled = true;
                nuD3.Value = 1;
            }
        }

        private void chkBurnt_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBurnt.Checked)
            {
                nuD4.Enabled = false;
                nuD4.Value = 0;
            }
            else
            {
                nuD4.Enabled = true;
                nuD4.Value = 1;
            }
        }

        private void chkHotBrewed_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkHotBrewed.Checked)
            {
                nuD5.Enabled = false;
                nuD5.Value = 0;
            }
            else
            {
                nuD5.Enabled = true;
                nuD5.Value = 1;
            }
        }

        private void chkIcedCaramel_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkIcedCaramel.Checked)
            {
                nuD6.Enabled = false;
                nuD6.Value = 0;
            }
            else
            {
                nuD6.Enabled = true;
                nuD6.Value = 1;
            }
        }

        private void chkGreenTea_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkGreenTea.Checked)
            {
                nuD7.Enabled = false;
                nuD7.Value = 0;
            }
            else
            {
                nuD7.Enabled = true;
                nuD7.Value = 1;
            }
        }

        private void chkJava_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkJava.Checked)
            {
                nuD8.Enabled = false;
                nuD8.Value = 0;
            }
            else
            {
                nuD8.Enabled = true;
                nuD8.Value = 1;
            }
        }

        private void chkMember_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdHere_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdToGo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Uncheck all checkboxes
            chkCreamyCaramel.Checked = false;
            chkSaltedCaramel.Checked = false;
            chkVanilla.Checked = false;
            chkBurnt.Checked = false;
            chkHotBrewed.Checked = false;
            chkIcedCaramel.Checked = false;
            chkGreenTea.Checked = false;
            chkJava.Checked = false;
            chkMember.Checked = false;
            rdHere.Checked = false;
            rdToGo.Checked = false;

            // Reset numeric up-down controls to 0
            nuD1.Value = 0;
            nuD2.Value = 0;
            nuD3.Value = 0;
            nuD4.Value = 0;
            nuD5.Value = 0;
            nuD6.Value = 0;
            nuD7.Value = 0;
            nuD8.Value = 0;

        }

        private void nuD1_ValueChanged(object sender, EventArgs e)
        {

        }

        int discount = 50;
        int addFee = 10;
        double pts;

        public frmScarbats()
        {
            InitializeComponent();
        }

        private void frmScarbats_Load(object sender, EventArgs e)
        {



        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            double total = 0;
            double pts = 0.03;

            DataTable dt = new DataTable();

            dt.Columns.Add("Item");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Total");

            if (chkCreamyCaramel.Checked)
            {
                total += item1 * (int)nuD1.Value;
                dt.Rows.Add("Creamy Caramel", nuD1.Value, nuD1.Value * item1);
            }
            if (chkSaltedCaramel.Checked)
            {
                total += item2 * (int)nuD2.Value;
                dt.Rows.Add("Salted Caramel", nuD2.Value, nuD2.Value * item2);
            }
            if (chkVanilla.Checked)
            {
                total += item3 * (int)nuD3.Value;
                dt.Rows.Add("Vanilla Sweet Cream Cold Brew", nuD3.Value, nuD3.Value * item3);
            }
            if (chkBurnt.Checked)
            {
                total += item4 * (int)nuD4.Value;
                dt.Rows.Add("Burnt Caramel Oatmilk Latte", nuD4.Value, nuD4.Value * item4);
            }
            if (chkHotBrewed.Checked)
            {
                total += item5 * (int)nuD5.Value;
                dt.Rows.Add("How Brewed Coffee", nuD5.Value, nuD5.Value * item5);
            }
            if (chkIcedCaramel.Checked)
            {
                total += item6 * (int)nuD6.Value;
                dt.Rows.Add("Iced Caramel Macchiato", nuD6.Value, nuD6.Value * item6);
            }
            if (chkGreenTea.Checked)
            {
                total += item7 * (int)nuD7.Value;
                dt.Rows.Add("Green Tea Cream Frappucino", nuD7.Value, nuD4.Value * item7);
            }
            if (chkJava.Checked)
            {
                total += item8 * (int)nuD8.Value;
                dt.Rows.Add("Java Chip Frappucino", nuD8.Value, nuD8.Value * item8);
            }
            // You can also add the discount and additional fee here

            if (chkMember.Checked)
            {
                if (rdHere.Checked)
                {
                    total -= discount;
                }
                else
                {
                    total -= discount;
                    total += addFee;
                }
            }
            else
            {
                if (rdToGo.Checked)
                {
                    total += addFee;
                }
            }




            // Update the total price label or textbox
            if (!chkCreamyCaramel.Checked && !chkSaltedCaramel.Checked && !chkVanilla.Checked && !chkBurnt.Checked && !chkHotBrewed.Checked && !chkIcedCaramel.Checked && !chkGreenTea.Checked && !chkJava.Checked)
            {
                MessageBox.Show("Please select an item from the menu.", "Select item.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (chkMember.Checked)
                {
                    if (rdHere.Checked || rdToGo.Checked)
                    {
                        Form2 frm2 = new Form2(total, dt, pts, chkMember.Checked, rdHere.Checked);
                        frm2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please select dining method.", "Select dining method.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {

                    if (rdHere.Checked || rdToGo.Checked)
                    {
                        Form2 frm2 = new Form2(total, dt, pts, chkMember.Checked, rdHere.Checked);
                        frm2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please select dining method.", "Select dining method.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            // Uncheck all checkboxes
            chkCreamyCaramel.Checked = false;
            chkSaltedCaramel.Checked = false;
            chkVanilla.Checked = false;
            chkBurnt.Checked = false;
            chkHotBrewed.Checked = false;
            chkIcedCaramel.Checked = false;
            chkGreenTea.Checked = false;
            chkJava.Checked = false;
            chkMember.Checked = false;
            rdHere.Checked = false;
            rdToGo.Checked = false;

            // Reset numeric up-down controls to 0
            nuD1.Value = 0;
            nuD2.Value = 0;
            nuD3.Value = 0;
            nuD4.Value = 0;
            nuD5.Value = 0;
            nuD6.Value = 0;
            nuD7.Value = 0;
            nuD8.Value = 0;

        }
            }
        }
