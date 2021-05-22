using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace healthcheckapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Clear();
            }
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Clear();
                textBox2.PasswordChar = '*';
            }
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "admin")
            {
                if(textBox2.Text == "password")
                {
                    Dashboard ds = new Dashboard();
                    ds.Show();
                }
            }

            else
            {
                MessageBox.Show("Wrong USername or Password ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}