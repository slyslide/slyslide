using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Person__Customer__Preferred_Customer
{
    public partial class PersonCustomerForm : Form
    {
        public PersonCustomerForm()
        {
            InitializeComponent();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Instantiates a null Customer object
                Customer cust1 = new Customer();

                //Assigns name and address
                cust1.Name = nameInputTextBox.Text;
                cust1.Address = addressInputTextBox.Text;

                //Assigns phone number and customer number, after parsing
                cust1.PhoneNumber = Int64.Parse(phoneNumberInputTextBox.Text);
                cust1.CustomerNumber = int.Parse(numberInputTextBox.Text);

                //Assigns Boolean based on if the applicable check box is checked
                if (mailingListInputCheckBox.Checked)
                {
                    cust1.MailingList = true;
                }

                //Displays message box showcasing all of the properties of newly created PreferredCustomer object
                MessageBox.Show("Added Customer: " + cust1.Name + "\nAddress: " + cust1.Address + "\nPhone Number: " 
                    + String.Format("{0:(###) ###-####}", cust1.PhoneNumber) + "\nCustomer Number: " + cust1.CustomerNumber.ToString()
                    + "\nMailing List: " + cust1.MailingList);
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
            mailingListInputCheckBox.Checked = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
