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
        public List<Variable> ScopeVariables { get; set; }


        public Scope()
        {
            Items=new Queue<VCode>();
            LocalVariables=new List<Variable>();
            ScopeVariables=new List<Variable>();
       
        }

        public void UpdateAccessibleVariableNames()
        {
            LocalVariables.Clear();
            foreach (var item in Items)
            {
                
                if (item.VType != Enums.VType.Variable) continue;
                Variable v = (Variable) item;
                LocalVariables.Add(v);
            }

            foreach (var variable in ScopeVariables)
            {
                LocalVariables.Add(variable);                
            }


        }

       


    }
}
