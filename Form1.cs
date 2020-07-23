using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class LogIn : Form
    {
        private string user = "admin";
        private string password = "admin";
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(US.Text == user && PW.Text == password)
            {
                MainSchedule frm2 = new MainSchedule();
                this.Hide();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản và mật khẩu");
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
