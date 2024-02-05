using System;
using System.Windows.Forms;

namespace MedicoV2
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        //Important Codes//Important Codes//Important Codes
        //Important Codes//Important Codes//Important Codes

        private void button6_Click(object sender, EventArgs e)
        {
            //logout btn//logout btn//logout btn

            this.Hide();
            Admin admin = new Admin();
            admin.ShowDialog();

            //logout btn//logout btn//logout btn
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            //Close The Entire Application//Close The Entire Application//Close The Entire Application

            System.Windows.Forms.Application.Exit();

            //Close The Entire Application//Close The Entire Application//Close The Entire Application
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //medicines btn//medicines btn//medicines btn

            this.Hide();
            Medicines medicines = new Medicines();
            medicines.ShowDialog();

            //medicines btn//medicines btn//medicines btn
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //already opened//already opened//already opened

            MessageBox.Show("The Windows Is Already Opened.");

            //already opened//already opened//already opened
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //customers btn//customers btn//customers btn

            this.Hide();
            Customers customers = new Customers();
            customers.ShowDialog();

            //customers btn//customers btn//customers btn
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Users btn//Users btn//Users btn

            this.Hide();
            Users Users = new Users();
            Users.ShowDialog();

            //Users btn//Users btn//Users btn
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //manu btn//manu btn//manu btn

            this.Hide();
            Manufacturer manufacturer = new Manufacturer();
            manufacturer.ShowDialog();

            //manu btn//manu btn//manu btn
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //sell btn//sell btn//sell btn

            this.Hide();
            Sell sell = new Sell();
            sell.ShowDialog();

            //sell btn//sell btn//sell btn
        }

        //Important Codes//Important Codes//Important Codes
        //Important Codes//Important Codes//Important Codes
    }
}
