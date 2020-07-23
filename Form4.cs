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
    public partial class Class : Form
    { scheduleEntities1 SE = new scheduleEntities1();
        private string[] ROOM = new string[100];
        private string[] SPACE = new string[100];
        private string[] NOTE = new string[100];
        private string[] ID = new string[100];
        private int lenRoom;
        int index = 0;
        public Class()
        {
            InitializeComponent();
        }
        
        private void Form4_Load(object sender, EventArgs e)
        {
            showHeader();
            var result = from c in SE.Rooms select new { phong = c.Phong, cap = c.Capacity, note = c.Note,id = c.ID };
            var data = result.ToList();
            for (int i = 0; i < data.Count; i++)
            {
                this.ROOM[i] = data[i].phong;
                this.SPACE[i] = data[i].cap;
                this.NOTE[i] = data[i].note;
                this.ID[i] = Convert.ToString(data[i].id);
            }
            for (int i = 0; i < data.Count; i++)
            {
                
                ListViewItem eVent = new ListViewItem(ID[i]);
                eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, ROOM[i]));
                eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, SPACE[i]));
                eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, NOTE[i]));
                
                this.lstRoom.Items.Add(eVent);
            }



        }
        private void showHeader()
        {
            this.lstRoom.Columns.Add("ID", 50, HorizontalAlignment.Left);
            this.lstRoom.Columns.Add("ROOM", 75, HorizontalAlignment.Left);
            this.lstRoom.Columns.Add("CAPACITY", 100, HorizontalAlignment.Left);
            this.lstRoom.Columns.Add("NOTE", 250, HorizontalAlignment.Left);
            
        }
        //---------------------------------Add Buttom---------------------------------------//
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //ADD to DATABASE
            Room room = new Room() { Phong = this.txtRoom.Text, Capacity = this.txtCapacity.Text, Note = txtNote.Text };
            SE.Rooms.Add(room);
            SE.SaveChanges();
            int id = room.ID;
            ListViewItem eVent = new ListViewItem(Convert.ToString(id));
            eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, this.txtRoom.Text));
            eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, this.txtCapacity.Text));
            eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, this.txtNote.Text));
            this.lstRoom.Items.Add(eVent);
            Clear();
            index++;
        }
        //--------------------------------------------------------------------------------//
        //---------------------------------Update Event-------------------------------------//
        
        private void listView1_Click(object sender, EventArgs e)
        {
            this.txtID.Text = this.lstRoom.SelectedItems[0].SubItems[0].Text;
            this.txtRoom.Text = this.lstRoom.SelectedItems[0].SubItems[1].Text;
            this.txtCapacity.Text = this.lstRoom.SelectedItems[0].SubItems[2].Text;
            this.txtNote.Text = this.lstRoom.SelectedItems[0].SubItems[3].Text;
            
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        //------------------------------------------------------------------------------------//
        //---------------------------------Clear text----------------------------------------//
        private void Clear()
        {
            this.txtRoom.Text = "";
            this.txtCapacity.Text = "";
            this.txtNote.Text = "";
            this.txtID.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.txtID.Text);
            Room room = SE.Rooms.Where(b => b.ID == id).FirstOrDefault();
            SE.Rooms.Remove(room);
            SE.SaveChanges();
            for (int i = 0; i < lstRoom.Items.Count; i++)
            {
                if (lstRoom.Items[i].Selected)
                {
                    lstRoom.Items[i].Remove();
                    i--;
                }
            }
            Clear();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Controller cl = new Controller();
            this.lstRoom.SelectedItems[0].SubItems[1].Text = this.txtRoom.Text;
            this.lstRoom.SelectedItems[0].SubItems[2].Text = this.txtCapacity.Text;
            this.lstRoom.SelectedItems[0].SubItems[3].Text = this.txtNote.Text;
            string phong = this.txtRoom.Text;
            string cap = this.txtCapacity.Text;
            string note = this.txtNote.Text;
            string id = this.txtID.Text;
            cl.edit(id, phong, cap, note);
            Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
