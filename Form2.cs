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
    public partial class MainSchedule : Form
    {
        scheduleEntities1 SE = new scheduleEntities1();
        public MainSchedule()
        {
            InitializeComponent();
        }

       

        private void btnRoom_Click(object sender, EventArgs e)
        {
            Class cl = new Class();
            cl.Show();
            
        }
        private void btnIns_Click(object sender, EventArgs e)
        {
            Ins inst = new Ins();
            inst.Show();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
        }
        private void MainSchedule_Load(object sender, EventArgs e)
        {
        }

        private void btnSche_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CHỨC NĂNG ĐANG BẢO TRÌ @@");
        }
    }
}
