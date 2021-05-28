using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace healthcheckapp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void inputstatus_Click(object sender, EventArgs e)
        {
            healthstatus res = new healthstatus();
            res.Show();
        }

        private void viewstatus_Click(object sender, EventArgs e)
        {
            Viewhealthstatus res = new Viewhealthstatus();
            res.Show();
        }

        private void connectapp_Click(object sender, EventArgs e)
        {
            Countfootstep res = new Countfootstep();
            res.Show();
        }

        private void healthnews_Click(object sender, EventArgs e)
        {
            healthnews res = new healthnews();
            res.Show();
        }

        private void exercise_Click(object sender, EventArgs e)
        {
            exercise res = new exercise();
            res.Show();
        }

        private void diet_Click(object sender, EventArgs e)
        {
            Diet res = new Diet();
            res.Show();
        }

        private void health_Click(object sender, EventArgs e)
        {
           health res = new health();
            res.Show();
        }

        private void iprotect_Click(object sender, EventArgs e)
        {
            iprotect res = new iprotect();
            res.Show();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Home res = new Home();
            res.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountCommand account = new AccountCommand("khanh");

            Command open = new SignOut(account);
            Command close = new CloseAccount(account);
            HealthApp healthApp = new HealthApp(open, close);

            MessageBox.Show(healthApp.clickSignOutAccount());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frmBuy = new BuyProduct();
            frmBuy.Show();
        }
    }
}
