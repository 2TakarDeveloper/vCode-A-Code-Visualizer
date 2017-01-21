using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTD.Entity.Helpers
{
    public class Scope
    {
        public Queue<VCode> Items { get; set; }

        public Scope()
        {
            Items=new Queue<VCode>();
        }
    }
}
