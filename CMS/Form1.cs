using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(user.Text =="user" && Pass.Text =="123") 
            {
                new Form2().Show();
                this.Hide();
            }
            if (user.Text == "admin" && Pass.Text == "1234")
            {
                new Form3().Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("The user name or password is incorrect");
                user.Clear();
                Pass.Clear();
                user.Focus();
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            user.Clear();
            Pass.Clear();
            user.Focus();
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
