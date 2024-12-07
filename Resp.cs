using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRD
{
    public class Resp
    {
        public string FIO;
        public string id;
        public Resp(string id, string FIO) {
            this.FIO = FIO;
            this.id = id;
        }   
    }
}
