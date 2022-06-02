using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingADO.NET
{
    class Students
    {

        public int ID { get; set; }
        public string HoTen { get; set; }
        public int MaLop { get; set; }


        public Students() {}

        public Students(int id, string ht, int ml)
        {
            this.ID = id;
            this.HoTen = ht;
            this.MaLop = ml;
        }
    }
}
