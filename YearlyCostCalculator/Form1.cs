using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YearlyCostCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, double> admissionFee = new Dictionary<int, double> { };
        Dictionary<int, double> monthlyFee = new Dictionary<int, double> { };




        private void button1_Click(object sender, EventArgs e)
        {
            admissionFee.Add(1, 10000);
            admissionFee.Add(2, 10000);
            admissionFee.Add(3, 10000);
            admissionFee.Add(4, 10000);
            admissionFee.Add(5, 10000);
            admissionFee.Add(6, 12000);
            admissionFee.Add(7, 12000);
            admissionFee.Add(8, 12000);
            admissionFee.Add(9, 15000);
            admissionFee.Add(10, 15000);
            admissionFee.Add(11, 150000);
            admissionFee.Add(12, 150000);

            monthlyFee.Add(1, 500);
            monthlyFee.Add(2, 500);
            monthlyFee.Add(3, 1000);
            monthlyFee.Add(4, 1000);
            monthlyFee.Add(5, 1000);
            monthlyFee.Add(6, 1500);
            monthlyFee.Add(7, 1500);
            monthlyFee.Add(8, 1500);
            monthlyFee.Add(9, 2000);
            monthlyFee.Add(10, 2000);
            monthlyFee.Add(11, 2700);
            monthlyFee.Add(12, 2700);

            if (classContainerComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a class . ");
            }
            else
            {

                for (int i = 1; 1 <= 12; i++)
                {
                    if (classContainerComboBox.SelectedIndex == i)
                    {
                        double totalAmount = admissionFee[i] + (monthlyFee[i] * 12);
                        if (discountCheckBox.Checked == false)
                        {
                            MessageBox.Show("The total amoun is :" + totalAmount);
                        }
                        else
                        {
                            double amountWithDiscount = totalAmount - (totalAmount * 0.05);
                            MessageBox.Show("The total amount with discount :" + amountWithDiscount);

                        }

                    }

                }




            }
        }
    }
}
