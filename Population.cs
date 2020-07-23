using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace schedule
{
    class Population
    {
        public string professor;
        public Course course;
        public string room;

        public object Course { get; internal set; }

        public Population(string Professor, Course course, string room)
        {
            professor = Professor;
            this.course = course;
            this.room = room;



        }
        public Population() { }
    }
}
