using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Amar_Cash
{
    public partial class AddUserFromAdmin : Form
    {
        private readonly SqlConnection con = new SqlConnection("Data Source=HPENVY-X360-13\\SQLEXPRESS;Initial Catalog=Amar_Cash;Integrated Security=True;");
        private int key = 0;

        public AddUserFromAdmin()
        {
            InitializeComponent();
        }

        private void DisplayAccounts()
        {
            try
            {
                con.Open();
                string strCommand = "SELECT * FROM AccountTbl";
                SqlCommand objCommand = new SqlCommand(strCommand, con);
                DataSet objDataSet = new DataSet();
                SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
                objAdapter.Fill(objDataSet);
                dataGridView1.DataSource = objDataSet.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void AddUserFromAdmin_Load(object sender, EventArgs e)
        {
            DisplayAccounts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView1.SelectedRows[0].Cells["AccName"].Value.ToString();
            txtNumber.Text = dataGridView1.SelectedRows[0].Cells["AccPhoneNumber"].Value.ToString();
            txtGender.SelectedItem = dataGridView1.SelectedRows[0].Cells["AccGender"].Value.ToString();
            txtPass.Text = dataGridView1.SelectedRows[0].Cells["AccPass"].Value.ToString();
            key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AccPhoneNumber"].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPass.Text) && !string.IsNullOrEmpty(txtNumber.Text) && txtGender.SelectedItem != null)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO AccountTbl (AccName, AccPass, AccPhoneNumber, AccGender, AccBalance) VALUES (@AccName, @AccPass, @AccPhoneNumber, @AccGender, 0)", con);
                    cmd.Parameters.AddWithValue("@AccName", txtName.Text);
                    cmd.Parameters.AddWithValue("@AccPass", txtPass.Text);
                    cmd.Parameters.AddWithValue("@AccPhoneNumber", txtNumber.Text);
                    cmd.Parameters.AddWithValue("@AccGender", txtGender.SelectedItem.ToString());
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DisplayAccounts();
                    MessageBox.Show("Registration Successful");
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPass.Text) && !string.IsNullOrEmpty(txtNumber.Text) && txtGender.SelectedItem != null)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE AccountTbl SET AccName = @AccName, AccPass = @AccPass, AccGender = @AccGender WHERE AccPhoneNumber = @AccPhoneNumber", con);
                    cmd.Parameters.AddWithValue("@AccName", txtName.Text);
                    cmd.Parameters.AddWithValue("@AccPass", txtPass.Text);
                    cmd.Parameters.AddWithValue("@AccGender", txtGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AccPhoneNumber", txtNumber.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    reset();
                    DisplayAccounts();
                    MessageBox.Show("Update Successful");
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the item");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM AccountTbl WHERE AccPhoneNumber = @AccPhoneNumber", con);
                    cmd.Parameters.AddWithValue("@AccPhoneNumber", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account deleted");
                    con.Close();
                    reset();
                    DisplayAccounts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void reset()
        {
            txtName.Text = "";
            txtGender.SelectedIndex = -1;
            txtNumber.Text = "";
            txtPass.Text = "";
            key = 0;
        }
    }
}
