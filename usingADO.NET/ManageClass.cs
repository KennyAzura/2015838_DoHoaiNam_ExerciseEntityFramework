using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingADO.NET
{
    class ManageClass
    {
        private List<Class> listClass;


        public ManageClass()
        {
            listClass = new List<Class>();
        }

        public List<Class> GetListClass()
        {
            return listClass;
        }

        public void AddClass(Class c)
        {
            listClass.Add(c);
        }

        public Class FindClassIDClass(int MaLop)
        {
            return listClass.Find(l => l.ID == MaLop);
        }

        public void Clear()
        {
            listClass.Clear();
        }
    }
}
