using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Person__Customer__Preferred_Customer
{
    public partial class PreferredCustomerForm : Form
    {
        public PreferredCustomerForm()
        {
            InitializeComponent();
        }

        private void addPreferredCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Instantiates a null PreferredCustomer object
                PreferredCustomer cust1 = new PreferredCustomer(); //Instantiates a null PreferredCustomer object

                //Assigns name and address
                cust1.Name = nameInputTextBox.Text;
                cust1.Address = addressInputTextBox.Text;

                //Assigns phone number and customer number, after parsing
                cust1.PhoneNumber = Int64.Parse(phoneNumberInputTextBox.Text);
                cust1.CustomerNumber = int.Parse(numberInputTextBox.Text);

                //Assigns Boolean based on if the applicable check box is checked
                if (mailingListCheckBox.Checked)
                {
                    cust1.MailingList = true;
                }

                //Assigns purchases total, after parsing
                cust1.Purchases = Double.Parse(purchasesInputTextBox.Text);

                //Displays message box showcasing all of the properties of newly created PreferredCustomer object
                MessageBox.Show("Added Customer: " + cust1.Name + "\nAddress: " + cust1.Address + "\nPhone Number: "
                    + String.Format("{0:(###) ###-####}", cust1.PhoneNumber) + "\nCustomer Number: " + cust1.CustomerNumber.ToString()
                    + "\nMailing List: " + cust1.MailingList + "\nTotal Purchases: " + cust1.Purchases.ToString("c") + "\nPercentage Discount: " 
                    + cust1.Discount.ToString("p"));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameInputTextBox.Text = "";
            addressInputTextBox.Text = "";
            phoneNumberInputTextBox.Text = "";
            numberInputTextBox.Text = "";
            mailingListCheckBox.Checked = false;
            purchasesInputTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
