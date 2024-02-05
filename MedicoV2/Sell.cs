using System;
using System.Windows.Forms;

namespace MedicoV2
{
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //already opened//already opened//already opened

            MessageBox.Show("The Window Is Already Opened.");

            //already opened//already opened//already opened
        }

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
            //close all//close all//close all

            System.Windows.Forms.Application.Exit();

            //close all//close all//close all
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dashboard btn//dashboard btn//dashboard btn

            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();

            //dashboard btn//dashboard btn//dashboard btn
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //medicines btn//medicines btn//medicines btn

            this.Hide();
            Medicines medicines = new Medicines();
            medicines.ShowDialog();

            //medicines btn//medicines btn//medicines btn
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
    }
}
