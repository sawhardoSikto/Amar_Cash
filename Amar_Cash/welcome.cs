using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amar_Cash
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); 
            form1.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close ();  
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this .Close (); 
        }

        private void welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
