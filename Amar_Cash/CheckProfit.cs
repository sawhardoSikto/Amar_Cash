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
    public partial class CheckProfit : Form
    {
        public CheckProfit()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=HPENVY-X360-13\\SQLEXPRESS;Initial Catalog=Amar_Cash;Integrated Security=True;");

        private void DisplayAccounts()
        {
            try
            {

                con.Open();
                string strCommand = "SELECT [AdminID]\r\n      ,[Password]\r\n      ,[Profit]\r\n      ,[AdminName]\r\n  FROM [dbo].[Admin]\r\n ";
                SqlCommand objCommand = new SqlCommand(strCommand, con);
                //bind data with  ui
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

        private void CheckProfit_Load(object sender, EventArgs e)
        {
            DisplayAccounts();
        }
    }
}
