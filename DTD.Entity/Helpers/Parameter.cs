using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DTD.Entity.Enum;

namespace DTD.Entity.Helpers
{
    public class Parameter
    {
        public string Type { get; set; }
        public string Name { get; set; }

        public Parameter()
        {
            Type = "int";
            Name = "New Parameter";
        }
        public Parameter(string type, string name)
        {
            this.Type = type;
            this.Name = name;
        }
        public Parameter(string name)
        {
            this.Type = null;
            this.Name = name;
        }
    }
}
