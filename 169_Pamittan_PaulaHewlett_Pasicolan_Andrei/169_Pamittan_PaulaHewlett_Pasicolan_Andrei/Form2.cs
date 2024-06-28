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
    public partial class Form2 : Form
    {
        double total;
        double pts;
        bool member;
        bool dining;
        DataTable dt = new DataTable();
        public Form2(double _total, DataTable _dt, double _pts, bool _member, bool _dining)
        {
            InitializeComponent();
            total = _total;
            dt = _dt;
            pts = _pts;
            member = _member;
            dining = _dining;
        }

        private void Form2_Load(object sender, EventArgs e)
        { 

            lblTotal.Text = "Total: " + total.ToString(); //display total
            grdItems.DataSource = dt; //show the items in the datagrid
            
            if (member == true)
            {
                lblIsMember.Text = "Member: " + "Yes";
                lblPoints.Text = "Points: " + (total * pts).ToString();
            }
            else
            {
                lblIsMember.Text = "Member: " + "No";
                lblPoints.Text = "Points: " + "0";
            }

            if (dining == true)
            {
                lblDining.Text = "Dining: " + "For here";
            }
            else
            {
                lblDining.Text = "Dining: " + "To go";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            double change, payment = 0;

            if (!string.IsNullOrWhiteSpace(txtPayment.Text))
            {
                payment = int.Parse(txtPayment.Text);

                if (payment < total)
                {
                    DialogResult dlg = MessageBox.Show("Insufficient Amount", "Payment", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                    if (dlg == DialogResult.Retry)
                    {
                        txtPayment.Clear();
                        txtPayment.Focus();
                    }
                }
                else
                {
                    change = payment - total;
                    DialogResult dlg2 = MessageBox.Show("Item/s purchased successfully" +
                        "\nTotal Amount: " + total +
                        "\nPayment Amount: " + payment +
                        "\nChange: " + change, "Payment", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (dlg2 == DialogResult.OK)
                    {
                        this.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("Please enter payment amount", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
