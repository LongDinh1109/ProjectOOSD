using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace healthcheckapp
{
    public partial class BuyProduct : Form
    {
        public BuyProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbPay.SelectedItem.ToString() == "Cash")
                MessageBox.Show(AccountFacade.getInstance().buyProductByCash(txtEmail.Text));
            else if (cbPay.SelectedItem.ToString() == "Paypal")
                MessageBox.Show(AccountFacade.getInstance().buyProductByPaypal(txtEmail.Text, txtPhone.Text));
            if (cbType.SelectedItem.ToString() == "SMember")
            {
                MemberType sMember = AccountFactory.getAccount(AccountType.SMEMBER);
                MessageBox.Show(sMember.OpenAccount());
            }
            else if (cbType.SelectedItem.ToString() == "SSMember")
            {
                MemberType ssMember = AccountFactory.getAccount(AccountType.SSMEMBER);
                MessageBox.Show(ssMember.OpenAccount());
            }
        }
    }
}
