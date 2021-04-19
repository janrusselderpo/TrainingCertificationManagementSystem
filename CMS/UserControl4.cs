using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMS
{
    public partial class UserControl4 : UserControl
    {
        SqlConnection con = new SqlConnection();
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True";
        SqlCommand cmd;
        public UserControl4()
        {
            InitializeComponent();
            dateIssuedDateTimePicker.MinDate = DateTime.Now.Date;
            dateIssuedDateTimePicker.MaxDate = DateTime.Now.Date;
            expiryDateDateTimePicker.MinDate = DateTime.Now.Date;
            expiryDateDateTimePicker.MaxDate = DateTime.Now.Date;
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            disP();
            fill();
        }
        private void disP()
        {

            con = new SqlConnection(conString);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ForCertification";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            reqView.DataSource = dt;
            con.Close();
        }




        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (reqView.Rows.Count > 0)
            {

                idTextBox.Text = reqView.SelectedRows[0].Cells[0].Value.ToString();
                firstNameTextBox.Text = reqView.SelectedRows[0].Cells[1].Value.ToString();
                lastNameTextBox.Text = reqView.SelectedRows[0].Cells[2].Value.ToString();
                abbrvTextBox.Text = reqView.SelectedRows[0].Cells[4].Value.ToString();


            }
            else
            {
                MessageBox.Show("Error no data selected!");
            }

        }

        public void fill()
        {

            con = new SqlConnection(conString);
            string sql = "select * from ForCertification";
            cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String cert = reader.GetString(4);
                    certificateComboBox.Items.Add(cert);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("error");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
                
            con = new SqlConnection(conString);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Certification( FirstName, LastName, Certificate, Type, DateIssued, ExpiryDate ) VALUES ('" + firstNameTextBox.Text + "', '" + lastNameTextBox.Text + "', '" + certificateComboBox.Text + "' ,'" + abbrvTextBox.Text + "','" + dateIssuedDateTimePicker.Value.Date.ToString("yyyyMMdd") + "', '" + expiryDateDateTimePicker.Value.Date.ToString("yyyyMMdd") + "' )";
            cmd.ExecuteNonQuery();

            con.Close();
            disP();

            MessageBox.Show("Certificate Issued");
            idTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            abbrvTextBox.Clear();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from ForCertification where Id = '" + idTextBox.Text + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
            disP();

            MessageBox.Show("Request Deleted");
            idTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            abbrvTextBox.Clear();

        }


        private void certificateComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            while (cb.FindString(cb.Text) < 0 && cb.Text.Length > 0)
            {
                String subStringText = cb.Text.Substring(0, cb.Text.Length - 1);
                cb.SelectedIndex = cb.FindString(subStringText);
                if (cb.SelectedIndex < 0) cb.Text = string.Empty;
                else cb.Select();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            abbrvTextBox.Clear();
        }

        private void certificateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

