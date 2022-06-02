using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingADO.NET
{
    class Class
    {
        public int ID { get; set; }
        public string TenLop { get; set; }

        public Class()
        {

        }

        public Class(int id, string tl)
        {
            this.ID = id;
            this.TenLop = tl;
        }
    }
}
