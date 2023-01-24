using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSSAassignment5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginLabl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int attempts = 3;
        private void entrBtn1_Click(object sender, EventArgs e)
        {
            string login = loginTxtBx1.Text;
            string pass = passwrdTxtBx1.Text;
            string correctLog = "Teacher";
            string correctPass = "Admin";
            


            if (login == correctLog && pass == correctPass)
            {
                MessageBox.Show("Your credentials have been validated.");
                attempts = 3;
                this.WindowState = FormWindowState.Minimized;

                Form2 for2 = new Form2();
                for2.ShowDialog();
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                loginTxtBx1.Clear();
                passwrdTxtBx1.Clear();
                MessageBox.Show("You have entered the wrong credentials, please try again. \nYou have " + attempts + " attempts remaining.");
                attempts--;
                if (attempts == 0)
                {
                    MessageBox.Show("You have exceeded the max amount of attempts. Goodbye.");
                    this.Close();
                }
            }




        }

    }
}
