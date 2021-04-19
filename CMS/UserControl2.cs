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
    public partial class UserControl2 : UserControl
    {
        SqlConnection con = new SqlConnection();
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True";
        SqlCommand cmd;

        public UserControl2()
        {
            InitializeComponent();

        }
        private void disP()
        {

            con = new SqlConnection(conString);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            empView.DataSource = dt;
            con.Close();
        }
        
        private void disP1()
        {

            con = new SqlConnection(conString);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }

        private void empAdd_Click(object sender, EventArgs e)
        {
            if (firstnameTextBox.Text.Length > 0 && lastnameTextBox.Text.Length > 0 && positionTextBox.Text.Length > 0 && emailTextBox.Text.Length > 0)
            {
                con = new SqlConnection(conString);
                con.Open();
                SqlDataAdapter da= new SqlDataAdapter("SELECT FirstName,LastName from Employee WHERE FirstName ='"+firstnameTextBox.Text+ "' UNION SELECT LastName, LastName from Employee WHERE FirstName = '"+lastnameTextBox.Text+"' ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                    if(dt.Rows.Count >= 1)
                    { 
                    MessageBox.Show("Employee "+firstnameTextBox.Text+ ""+lastnameTextBox.Text+" has already been added");
                    con.Close();
                    return;
                    }
                    else
                    {
                        con = new SqlConnection(conString);
                        con.Open();
                        cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into Employee( FirstName, LastName, Position, Email) VALUES ('" + firstnameTextBox.Text + "', '" + lastnameTextBox.Text + "','" + positionTextBox.Text + "','" + emailTextBox.Text + "')";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        disP();

                        MessageBox.Show("Data inserted");
                        firstnameTextBox.Clear();
                        lastnameTextBox.Clear();
                        positionTextBox.Clear();
                        emailTextBox.Clear();
                        firstnameTextBox.Focus();

                    }
                
               
                con.Close();
            }

            else
            {
                MessageBox.Show("Please add value");
            }
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            disP();
            disP1();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (firstnameTextBox.Text.Length > 0 && lastnameTextBox.Text.Length > 0 && positionTextBox.Text.Length > 0 && emailTextBox.Text.Length > 0)
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Employee where Id = '" + idTextBox.Text + "' ";
                cmd.ExecuteNonQuery();
                con.Close();
                disP();

                MessageBox.Show("Data deleted");
                firstnameTextBox.Clear();
                lastnameTextBox.Clear();
                positionTextBox.Clear();
                emailTextBox.Clear();
                idTextBox.Clear();
                firstnameTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Please select data");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (firstnameTextBox.Text.Length > 0 && lastnameTextBox.Text.Length > 0 && positionTextBox.Text.Length > 0 && emailTextBox.Text.Length > 0)
            {
                cmd = new SqlCommand("UPDATE Employee SET FirstName = @firstname, LastName = @lastname, Position = @position, Email = @Email WHERE Id = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", idTextBox.Text);
                cmd.Parameters.AddWithValue("@firstname", firstnameTextBox.Text);
                cmd.Parameters.AddWithValue("@lastname", lastnameTextBox.Text);
                cmd.Parameters.AddWithValue("@position", positionTextBox.Text);
                cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                disP();

                MessageBox.Show("Data updated");
                firstnameTextBox.Clear();
                lastnameTextBox.Clear();
                positionTextBox.Clear();
                emailTextBox.Clear();
                firstnameTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Please select data");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            firstnameTextBox.Clear();
            lastnameTextBox.Clear();
            positionTextBox.Clear();
            emailTextBox.Clear();
            idTextBox.Clear();
            firstnameTextBox.Focus();
        }

        private void empView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (empView.Rows.Count > 0)
            {
                idTextBox.Text = empView.SelectedRows[0].Cells[0].Value.ToString();
                firstnameTextBox.Text = empView.SelectedRows[0].Cells[1].Value.ToString();
                lastnameTextBox.Text = empView.SelectedRows[0].Cells[2].Value.ToString();
                positionTextBox.Text = empView.SelectedRows[0].Cells[3].Value.ToString();
                emailTextBox.Text = empView.SelectedRows[0].Cells[4].Value.ToString();

            }
            else
            {
                MessageBox.Show("Error no data selected!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NewGUID = System.Guid.NewGuid().ToString().Replace(".", "").ToUpper();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

