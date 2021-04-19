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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {
            if (codeTextBox.Text.Length > 0 && certificateTextBox.Text.Length > 0 && abbrvTextBox.Text.Length > 0 && validityTextBox.Text.Length > 0)
            {

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT FirstName,LastName from Employee WHERE FirstName ='" + codeTextBox.Text + "' UNION SELECT LastName, LastName from Employee WHERE FirstName = '" + certificateTextBox.Text + "' ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Code " +codeTextBox.Text+ " already Exists");
                    con.Close();
                    return;
                }
                else
                { 
                        con = new SqlConnection(conString);
                        con.Open();
                        cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into Certificates(Code, Certificate, Abbrv, Validity) VALUES ('" + codeTextBox.Text + "', '" + certificateTextBox.Text + "','" + abbrvTextBox.Text + "','" + validityTextBox.Text + "')";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        disP();

                        MessageBox.Show("Data inserted");
                        codeTextBox.Clear();
                        certificateTextBox.Clear();
                        abbrvTextBox.Clear();
                        validityTextBox.Clear();
                        certificateTextBox.Focus();
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please add value");
            }

        }
        private void disP2()
        {

            con = new SqlConnection(conString);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Certification";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            certEmpView.DataSource = dt;

            con.Close();


        }
        private void disP()
        {


            con = new SqlConnection(conString);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Certificates";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            certView.DataSource = dt;

            con.Close();
        }
        private void disP3()
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
            empCV.DataSource = dt;

            con.Close();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            disP();
            disP2();
            disP3();

        }

        private void certificatesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.certificatesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cMSDataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            if (codeTextBox.Text.Length > 0 && certificateTextBox.Text.Length > 0 && abbrvTextBox.Text.Length > 0 && validityTextBox.Text.Length > 0)
            {
                cmd = new SqlCommand("UPDATE Certificates SET Code = @code, Certificate = @certification, Abbrv = @abbrv, Validity = @validity WHERE Id = @id",con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", idTextBox.Text);
                cmd.Parameters.AddWithValue("@code", codeTextBox.Text);
                cmd.Parameters.AddWithValue("@certification", certificateTextBox.Text);
                cmd.Parameters.AddWithValue("@abbrv", abbrvTextBox.Text);
                cmd.Parameters.AddWithValue("@validity", validityTextBox.Text);

                cmd.ExecuteNonQuery();
                        con.Close();
                        disP();

                    MessageBox.Show("Data Updated");
                    codeTextBox.Clear();
                    certificateTextBox.Clear();
                    abbrvTextBox.Clear();
                    validityTextBox.Clear();
                    codeTextBox.Focus();

            }
            else
            {
                MessageBox.Show("Please add value");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (codeTextBox.Text.Length > 0 && certificateTextBox.Text.Length > 0 && abbrvTextBox.Text.Length > 0 && validityTextBox.Text.Length > 0)
            {
                con = new SqlConnection(conString);
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Certificates where Id = '" + idTextBox.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                disP();

                MessageBox.Show("Data deleted");
                codeTextBox.Clear();
                certificateTextBox.Clear();
                abbrvTextBox.Clear();
                validityTextBox.Clear();
                codeTextBox.Focus();
                idTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please add value");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            codeTextBox.Clear();
            certificateTextBox.Clear();
            abbrvTextBox.Clear();
            validityTextBox.Clear();
            idTextBox.Clear();
            codeTextBox.Focus();

        }


        private void certView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (certView.Rows.Count > 0)
            {
                idTextBox.Text = certView.SelectedRows[0].Cells[0].Value.ToString();
                codeTextBox.Text = certView.SelectedRows[0].Cells[1].Value.ToString();
                certificateTextBox.Text = certView.SelectedRows[0].Cells[2].Value.ToString();
                abbrvTextBox.Text = certView.SelectedRows[0].Cells[3].Value.ToString();
                validityTextBox.Text = certView.SelectedRows[0].Cells[4].Value.ToString();

            }
            else
            {
                MessageBox.Show("Error no data selected!");
            }    
        }


    }
}
