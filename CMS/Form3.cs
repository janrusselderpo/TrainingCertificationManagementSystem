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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            button5.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            userControl21.BringToFront();
            button5.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
            button5.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl31.BringToFront();
            button5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControl41.BringToFront();
            this.Show();
        }
    }
}
