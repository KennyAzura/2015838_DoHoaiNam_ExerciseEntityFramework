using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingADO.NET
{
    class ManageStudents
    {
        private List<Students> listSD;

        public ManageStudents()
        {
            listSD = new List<Students>();
        }

        public void AddStudent(Students sd)
        {
            listSD.Add(sd);
        }

        public List<Students> GetListStudent()
        {
            return listSD;
        }

        public void Clear()
        {
            listSD.Clear();
        }

        public List<Students> FindSDName(string HoTen)
        {
            return listSD.FindAll(sv => {
                return sv.HoTen.ToLower().Contains(HoTen.ToLower());
            });
        }

        public Students FindSDID(int id)
        {
            return listSD.Find(sv => sv.ID == id);
        }
    }
}
