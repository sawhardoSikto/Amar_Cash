using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amar_Cash
{

    public partial class AgentHome : Form
    {
        string num;
        public AgentHome(string num)
        {

            InitializeComponent();
            this.num = num;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();    
            CashIN cashIN = new CashIN(num);   
            cashIN.ShowDialog();    

        }
        private void ShowBalance(string num)
        {
            int balance;
            try
            {
                SqlConnection con = new SqlConnection("Data Source=HPENVY-X360-13\\SQLEXPRESS;Initial Catalog=Amar_Cash;Integrated Security=True;");


                con.Open();
                string query = "SELECT * FROM agenttbl WHERE agentphoneno = @accPhoneNumber";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@accPhoneNumber", num);



                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                Console.WriteLine(dt.Rows.Count);
                foreach (DataRow dr in dt.Rows)
                {
                    balancelbl.Text = dr["AgentCash"].ToString();
                    balance = Convert.ToInt32(dr["AgentCash"].ToString());
                }


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void AgentHome_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowBalance(num);
        }
    }
}
