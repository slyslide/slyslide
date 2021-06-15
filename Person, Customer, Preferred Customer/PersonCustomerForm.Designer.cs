
namespace Person__Customer__Preferred_Customer
{
    partial class PersonCustomerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameInputLabel = new System.Windows.Forms.Label();
            this.addressInputLabel = new System.Windows.Forms.Label();
            this.phoneNumberInputLabel = new System.Windows.Forms.Label();
            this.nameInputTextBox = new System.Windows.Forms.TextBox();
            this.addressInputTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberInputTextBox = new System.Windows.Forms.TextBox();
            this.numberInputLabel = new System.Windows.Forms.Label();
            this.mailingListLabel = new System.Windows.Forms.Label();
            this.numberInputTextBox = new System.Windows.Forms.TextBox();
            this.mailingListInputCheckBox = new System.Windows.Forms.CheckBox();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameInputLabel
            // 
            this.nameInputLabel.AutoSize = true;
            this.nameInputLabel.Location = new System.Drawing.Point(121, 54);
            this.nameInputLabel.Name = "nameInputLabel";
            this.nameInputLabel.Size = new System.Drawing.Size(124, 15);
            this.nameInputLabel.TabIndex = 0;
            this.nameInputLabel.Text = "Input customer name:";
            // 
            // addressInputLabel
            // 
            this.addressInputLabel.AutoSize = true;
            this.addressInputLabel.Location = new System.Drawing.Point(121, 115);
            this.addressInputLabel.Name = "addressInputLabel";
            this.addressInputLabel.Size = new System.Drawing.Size(134, 15);
            this.addressInputLabel.TabIndex = 1;
            this.addressInputLabel.Text = "Input customer address:";
            // 
            // phoneNumberInputLabel
            // 
            this.phoneNumberInputLabel.AutoSize = true;
            this.phoneNumberInputLabel.Location = new System.Drawing.Point(121, 183);
            this.phoneNumberInputLabel.Name = "phoneNumberInputLabel";
            this.phoneNumberInputLabel.Size = new System.Drawing.Size(173, 15);
            this.phoneNumberInputLabel.TabIndex = 2;
            this.phoneNumberInputLabel.Text = "Input customer phone number:";
            // 
            // nameInputTextBox
            // 
            this.nameInputTextBox.Location = new System.Drawing.Point(554, 46);
            this.nameInputTextBox.Name = "nameInputTextBox";
            this.nameInputTextBox.Size = new System.Drawing.Size(100, 23);
            this.nameInputTextBox.TabIndex = 3;
            // 
            // addressInputTextBox
            // 
            this.addressInputTextBox.Location = new System.Drawing.Point(554, 107);
            this.addressInputTextBox.Name = "addressInputTextBox";
            this.addressInputTextBox.Size = new System.Drawing.Size(100, 23);
            this.addressInputTextBox.TabIndex = 4;
            // 
            // phoneNumberInputTextBox
            // 
            this.phoneNumberInputTextBox.Location = new System.Drawing.Point(554, 175);
            this.phoneNumberInputTextBox.Name = "phoneNumberInputTextBox";
            this.phoneNumberInputTextBox.Size = new System.Drawing.Size(100, 23);
            this.phoneNumberInputTextBox.TabIndex = 5;
            // 
            // numberInputLabel
            // 
            this.numberInputLabel.AutoSize = true;
            this.numberInputLabel.Location = new System.Drawing.Point(121, 250);
            this.numberInputLabel.Name = "numberInputLabel";
            this.numberInputLabel.Size = new System.Drawing.Size(140, 15);
            this.numberInputLabel.TabIndex = 6;
            this.numberInputLabel.Text = "Input Customer Number:";
            // 
            // mailingListLabel
            // 
            this.mailingListLabel.AutoSize = true;
            this.mailingListLabel.Location = new System.Drawing.Point(121, 315);
            this.mailingListLabel.Name = "mailingListLabel";
            this.mailingListLabel.Size = new System.Drawing.Size(301, 15);
            this.mailingListLabel.TabIndex = 7;
            this.mailingListLabel.Text = "Does the customer want to be added to the mailing list?";
            // 
            // numberInputTextBox
            // 
            this.numberInputTextBox.Location = new System.Drawing.Point(554, 242);
            this.numberInputTextBox.Name = "numberInputTextBox";
            this.numberInputTextBox.Size = new System.Drawing.Size(100, 23);
            this.numberInputTextBox.TabIndex = 8;
            // 
            // mailingListInputCheckBox
            // 
            this.mailingListInputCheckBox.AutoSize = true;
            this.mailingListInputCheckBox.Location = new System.Drawing.Point(554, 311);
            this.mailingListInputCheckBox.Name = "mailingListInputCheckBox";
            this.mailingListInputCheckBox.Size = new System.Drawing.Size(126, 19);
            this.mailingListInputCheckBox.TabIndex = 10;
            this.mailingListInputCheckBox.Text = "Select to add to list";
            this.mailingListInputCheckBox.UseVisualStyleBackColor = true;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(121, 380);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(107, 23);
            this.addCustomerButton.TabIndex = 11;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(358, 380);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(579, 380);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // PersonCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.mailingListInputCheckBox);
            this.Controls.Add(this.numberInputTextBox);
            this.Controls.Add(this.mailingListLabel);
            this.Controls.Add(this.numberInputLabel);
            this.Controls.Add(this.phoneNumberInputTextBox);
            this.Controls.Add(this.addressInputTextBox);
            this.Controls.Add(this.nameInputTextBox);
            this.Controls.Add(this.phoneNumberInputLabel);
            this.Controls.Add(this.addressInputLabel);
            this.Controls.Add(this.nameInputLabel);
            this.Name = "PersonCustomerForm";
            this.Text = "Person and Customer Class Test Driver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameInputLabel;
        private System.Windows.Forms.Label addressInputLabel;
        private System.Windows.Forms.Label phoneNumberInputLabel;
        private System.Windows.Forms.TextBox nameInputTextBox;
        private System.Windows.Forms.TextBox addressInputTextBox;
        private System.Windows.Forms.TextBox phoneNumberInputTextBox;
        private System.Windows.Forms.Label numberInputLabel;
        private System.Windows.Forms.Label mailingListLabel;
        private System.Windows.Forms.TextBox numberInputTextBox;
        private System.Windows.Forms.CheckBox mailingListInputCheckBox;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

