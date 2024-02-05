using System;
using System.Windows.Forms;

namespace MedicoV2
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        //important codes//important codes//important codes
        //important codes//important codes//important codes

        private void button1_Click(object sender, EventArgs e)
        {
            //Username Password btn//Username Password btn//Username Password btn

            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "Admin" && password == "Admin")
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
            }
            else if (username == "" && password == "")
            {
                MessageBox.Show("Please Enter Username & Password To Proceed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Username Password btn//Username Password btn//Username Password btn
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            //Close The Entire Application//Close The Entire Application//Close The Entire Application

            System.Windows.Forms.Application.Exit();

            //Close The Entire Application//Close The Entire Application//Close The Entire Application
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //userrole//userrole//userrole

            this.Hide();
            UserRole userRole = new UserRole();
            userRole.ShowDialog();

            //userrole//userrole//userrole
        }

        //important codes//important codes//important codes
        //important codes//important codes//important codes
    }
}
