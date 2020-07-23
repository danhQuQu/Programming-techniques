using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class Ins : Form
    {
        scheduleEntities1 SE = new scheduleEntities1();
        //----------------------------------------------Data----------------------------------------//
        private string[] ShowId = new string[100];
        private string[] ShowSj = new string[100];
        public string[] ShowName = new string[100];
        private string[] ShowGender = new string[100];
        private string[] ShowContact = new string[100];
        private int len = 0;
        //----------------------------------------------Data----------------------------------------//
        //---------------------------------------------------------------------------------------------//
        public Ins()
        {
            InitializeComponent();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            ShowHeader();
            var result = from c in SE.Lecturers select new { ID = c.ID, Name = c.Name, sub = c.Subject, gen = c.Gender, con = c.Contact };
            var data = result.ToList();
            for (int i = 0; i < data.Count; i++)
            {
                this.ShowId[i] = Convert.ToString(data[i].ID);
                this.ShowName[i] = data[i].Name;
                this.ShowSj[i] = data[i].sub;
                this.ShowGender[i] = data[i].gen;
                this.ShowContact[i] = data[i].con;
            }
            for (int i = 0; i < data.Count; i++)
            {
                ListViewItem eVent = new ListViewItem(ShowId[i]);
                eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, ShowName[i]));
                eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, ShowSj[i]));
                 eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, ShowGender[i]));
                eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, ShowContact[i]));
                
                this.listView1.Items.Add(eVent);
            }
            Program pr = new Program();
            for(int i = 0; i < 4; i++)
            {
                pr.tenGv(ShowName[i]);
            }
        }


        //--------------------------UPDATE EVENT--------------------------------------//
        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.txtID.Text);
            Lecturer lt = SE.Lecturers.Find(id);
            lt.Subject= this.txtSubject.Text;
            lt.Name = this.txtName.Text;
            lt.Gender = this.txtGender.Text;
            lt.Contact = this.txtContact.Text;
            SE.SaveChanges();

            this.listView1.SelectedItems[0].SubItems[0].Text = this.txtID.Text;
            this.listView1.SelectedItems[0].SubItems[2].Text = this.txtSubject.Text;
            this.listView1.SelectedItems[0].SubItems[1].Text = this.txtName.Text;
            this.listView1.SelectedItems[0].SubItems[3].Text = this.txtGender.Text;
            this.listView1.SelectedItems[0].SubItems[4].Text = this.txtContact.Text;

            Clear();

        }
        private void listView1_Click(object sender, EventArgs e)
        {
            this.txtID.Text = this.listView1.SelectedItems[0].SubItems[0].Text;
            this.txtSubject.Text = this.listView1.SelectedItems[0].SubItems[2].Text;
            this.txtName.Text = this.listView1.SelectedItems[0].SubItems[1].Text;
            this.txtGender.Text = this.listView1.SelectedItems[0].SubItems[3].Text;
            this.txtContact.Text = this.listView1.SelectedItems[0].SubItems[4].Text;
        }

        //----------------------------DELETE BUTTON----------------------------------------//
        private void button3_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32(this.txtID.Text);
            Lecturer lt = SE.Lecturers.Find(id);
            SE.Lecturers.Remove(lt);
            SE.SaveChanges();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                    i--;
                }
            }
            Clear();
        }
        //--------------------------------------------------------------------------------//
        //---------------------------------ADD ROWS AND COLUMN----------------------------//
        private void ShowHeader()
        {
            this.listView1.Columns.Add("Faculity ID", 100, HorizontalAlignment.Left);
            this.listView1.Columns.Add("Name", 100, HorizontalAlignment.Left);
            this.listView1.Columns.Add("Subject", 100, HorizontalAlignment.Left);
            this.listView1.Columns.Add("Gender", 100, HorizontalAlignment.Left);
            this.listView1.Columns.Add("Contact", 100, HorizontalAlignment.Left);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            //ADD to DATABASE
            Lecturer lt = new Lecturer() { Name =this.txtName.Text,Subject= this.txtSubject.Text,Gender=this.txtGender.Text,Contact=this.txtContact.Text};      
            SE.Lecturers.Add(lt);
            SE.SaveChanges();

            int id = lt.ID;
            ListViewItem eVent = new ListViewItem(Convert.ToString(id));
            eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, this.txtName.Text));
            eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, this.txtSubject.Text));
            eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, this.txtGender.Text));
            eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, this.txtContact.Text));
            this.listView1.Items.Add(eVent);

            Clear();
        }
        //--------------------------------------------------------------------------------//
        //---------------------------------- --CLEAR TEXT----------------------------------//
        private void Clear()
        {
            this.txtID.Text = "";
            this.txtName.Text = "";
            this.txtGender.Text = "";
            this.txtContact.Text = "";
            this.txtSubject.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
