using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn
{
    class Controller
       
    {
        scheduleEntities1 SE = new scheduleEntities1();
        public void edit(string id, string phong, string cap,string note)
        {
             int id1 = Convert.ToInt32(id);
            Room room = SE.Rooms.Where(b => b.ID == id1 ).FirstOrDefault();
            room.Phong = phong;
            room.Note = cap;
            room.Capacity = cap;
            SE.SaveChanges();
        }

    }
}
