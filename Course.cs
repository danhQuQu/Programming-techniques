using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace schedule
{
    class Course
    {
        // public string subject;
        public int start;
        public int end;
        public string date;

        public Course(/*string subject,*/ int start, int end, string date)
        {
            //this.subject = subject;
            this.start = start;
            this.date = date;
            this.end = end;
        }
        public Course() { }
    }
}
