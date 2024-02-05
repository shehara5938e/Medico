using System;
using System.Windows.Forms;

namespace MedicoV2
{
    public partial class UserRole : Form
    {
        public UserRole()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //admin login//admin login//admin login

            this.Hide();
            Admin admin = new Admin();
            admin.ShowDialog();

            //admin login//admin login//admin login
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Close The Entire Application//Close The Entire Application//Close The Entire Application

            System.Windows.Forms.Application.Exit();

            //Close The Entire Application//Close The Entire Application//Close The Entire Application
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Under Developing//Under Developing//Under Developing

            MessageBox.Show("This Portal Is Currently Unavailable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //Under Developing//Under Developing//Under Developing
        }
    }
}
