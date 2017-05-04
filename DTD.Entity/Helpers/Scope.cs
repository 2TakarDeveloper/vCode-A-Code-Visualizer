using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.Entity.Enum;
using DTD.Entity.vCodes;

namespace DTD.Entity.Helpers
{
    public class Scope
    {
        public Queue<VCode> Items { get; set; }
        public List<Variable> LocalVariables { get; set; }
        public List<Variable> ScopeAccessVariable { get; set; }


        public Scope()
        {
            Items=new Queue<VCode>();
            LocalVariables=new List<Variable>();
            ScopeAccessVariable=new List<Variable>();
       
        }

        public void UpdateLocalVariables()
        {
            LocalVariables.Clear();
            foreach (var item in Items)
            {
                if (item?.VType != Enums.VType.Variable) continue;
                Variable v = (Variable) item;
                LocalVariables.Add(v);
            }

            foreach (var variable in ScopeAccessVariable)
            {
                LocalVariables.Add(variable);                
            }


        }

       


    }
}
