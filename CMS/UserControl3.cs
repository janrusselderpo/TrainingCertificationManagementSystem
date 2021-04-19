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
    public partial class UserControl3 : UserControl
    {
        SqlConnection con = new SqlConnection();
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True";
        SqlCommand cmd;
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
            fcertView.DataSource = dt;
            con.Close();
        }

        public UserControl3()
        {
            InitializeComponent();
            certificateDueDateTimePicker.MinDate = DateTime.Now.Date;
            certificateDueDateTimePicker.MaxDate = DateTime.Now.AddDays(30);
            disP();
            fcertView.Refresh();
            firstNameComboBox.Refresh();
        }
        public void fill()
        {
            con = new SqlConnection(conString);
            string sql = "select * from Employee";
            cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string fname = reader.GetString(1);
                    firstNameComboBox.Items.Add(fname);
              
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("error");
            }
        }

        
        public void fill2()
        {
            con = new SqlConnection(conString);
            string sql = "select * from Employee";
            cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string lname = reader.GetString(2);
                    lastNameComboBox.Items.Add(lname);
             
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("error");
            }
        }
        public void fill3()
        {
            con = new SqlConnection(conString);
            string sql = "select * from Certificates";
            cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string abbrv = reader.GetString(2);
                    abbrvComboBox.Items.Add(abbrv);
             
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("error");
            }
        }
        private void UserControl3_Load(object sender, EventArgs e)
        {
            disP();
            fill();
            fill2();
            fill3();
            fcertView.Refresh();
            abbrvComboBox.Refresh();
            lastNameComboBox.Refresh();
            firstNameComboBox.Refresh();
        }

        private void firstNameComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            firstNameComboBox.Refresh();
            ComboBox cb = (ComboBox)sender;
            while (cb.FindString(cb.Text) < 0 && cb.Text.Length > 0)
            {
                String subStringText = cb.Text.Substring(0, cb.Text.Length - 1);
                cb.SelectedIndex = cb.FindString(subStringText);
                if (cb.SelectedIndex < 0) cb.Text = string.Empty;
                else cb.Select();
            }
        }

        private void lastNameComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            lastNameComboBox.Refresh();
            ComboBox cb = (ComboBox)sender;
            while (cb.FindString(cb.Text) < 0 && cb.Text.Length > 0)
            {
                String subStringText = cb.Text.Substring(0, cb.Text.Length - 1);
                cb.SelectedIndex = cb.FindString(subStringText);
                if (cb.SelectedIndex < 0) cb.Text = string.Empty;
                else cb.Select();
                
            }
        }

        private void abbrvComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            abbrvComboBox.Refresh();
            ComboBox cb = (ComboBox)sender;
            while (cb.FindString(cb.Text) < 0 && cb.Text.Length > 0)
            {
                String subStringText = cb.Text.Substring(0, cb.Text.Length - 1);
                cb.SelectedIndex = cb.FindString(subStringText);
                if (cb.SelectedIndex < 0) cb.Text = string.Empty;
                else cb.Select();
               

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
    
            if (firstNameComboBox.Text.Length > 0 && lastNameComboBox.Text.Length > 0 && abbrvComboBox.Text.Length > 0 && remarksTextBox.Text.Length > 0)
            { 
             
                    con = new SqlConnection(conString);
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into ForCertification( FirstName, LastName, CertificateDue, Type, Remarks) VALUES ('" + firstNameComboBox.Text + "', '" + lastNameComboBox.Text + "','"+ certificateDueDateTimePicker.Value.Date.ToString("yyyyMMdd")+"','" + abbrvComboBox.Text + "','" + remarksTextBox.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    disP();

                    MessageBox.Show("Data inserted");
                    idTextBox.Clear();
                    firstNameComboBox.Items.Clear();
                    lastNameComboBox.Items.Clear();
                    certificateDueDateTimePicker.MinDate = DateTime.Now.Date;
                    abbrvComboBox.Items.Clear();
                    remarksTextBox.Clear();
                    firstNameComboBox.Focus();
                    

            }

            else
            {
                MessageBox.Show("Please add value");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (firstNameComboBox.Text.Length > 0 && lastNameComboBox.Text.Length > 0 && abbrvComboBox.Text.Length > 0 && remarksTextBox.Text.Length > 0)
            {
                cmd = new SqlCommand("UPDATE ForCertification SET FirstName = @firstname, LastName = @lastname, CertificateDue = @certificatedue, Type = @type, Remarks = @remarks WHERE Id = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", idTextBox.Text);
                cmd.Parameters.AddWithValue("@firstname", firstNameComboBox.Text);
                cmd.Parameters.AddWithValue("@lastname", lastNameComboBox.Text);
                cmd.Parameters.AddWithValue("@certificatedue", certificateDueDateTimePicker.Value.Date.ToString("yyyyMMdd"));
                cmd.Parameters.AddWithValue("@type", abbrvComboBox.Text);
                cmd.Parameters.AddWithValue("@remarks", remarksTextBox.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                disP();
                

                MessageBox.Show("Data Updated");
                idTextBox.Clear();
                firstNameComboBox.Items.Clear();
                lastNameComboBox.Items.Clear();
                certificateDueDateTimePicker.MinDate = DateTime.Now.Date;
                abbrvComboBox.Items.Clear();
                remarksTextBox.Clear();
                firstNameComboBox.Focus();

            }
            else
            {
                MessageBox.Show("Please select data");
            }
          
        }



    private void button3_Click(object sender, EventArgs e)
        {
            if (firstNameComboBox.Text.Length > 0 && lastNameComboBox.Text.Length > 0 && abbrvComboBox.Text.Length > 0 && remarksTextBox.Text.Length > 0)
            {

                con = new SqlConnection(conString);
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from ForCertification where Id = '" + idTextBox.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                disP();
                fcertView.Refresh();

                MessageBox.Show("Data Deleted");
                idTextBox.Clear();
                firstNameComboBox.Items.Clear();
                lastNameComboBox.Items.Clear();
                certificateDueDateTimePicker.MinDate = DateTime.Now.Date;
                abbrvComboBox.Items.Clear();
                remarksTextBox.Clear();
                firstNameComboBox.Focus();

            }

            else
            {
                MessageBox.Show("Please add value");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            firstNameComboBox.Items.Clear();
            lastNameComboBox.Items.Clear();
            abbrvComboBox.Items.Clear();
            remarksTextBox.Clear();
        }

        private void fcertView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fcertView.Rows.Count > 0)
            {
                idTextBox.Text = fcertView.SelectedRows[0].Cells[0].Value.ToString();
                firstNameComboBox.Text = fcertView.SelectedRows[0].Cells[1].Value.ToString();
                lastNameComboBox.Text = fcertView.SelectedRows[0].Cells[2].Value.ToString();
                certificateDueDateTimePicker.Text = fcertView.SelectedRows[0].Cells[3].Value.ToString();
                abbrvComboBox.Text = fcertView.SelectedRows[0].Cells[4].Value.ToString();
                remarksTextBox.Text = fcertView.SelectedRows[0].Cells[5].Value.ToString();
                fcertView.Refresh();
            }
            else
            {
                MessageBox.Show("Error no data selected!");
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeTableAdapter.FillBy(this.cMSDataSet.Employee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

