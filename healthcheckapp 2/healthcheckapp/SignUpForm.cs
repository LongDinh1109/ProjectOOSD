using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace healthcheckapp
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account newAccount= new Account
                                .AccountBuilder(this.txtName.Text)
                                .withAddress(this.txtAddress.Text)
                                .withMail(this.txtEmail.Text)
                                .withPhone(this.txtPhone.Text)
                                .build();
            MessageBox.Show(newAccount.ToString());
              

        }

        
    }
}
