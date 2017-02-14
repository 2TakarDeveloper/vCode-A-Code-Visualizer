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
        public List<string> LocalVariables { get; set; }
        public List<string> ScopeVariables { get; set; }


        public Scope()
        {
            Items=new Queue<VCode>();
            LocalVariables=new List<string>();
            ScopeVariables=new List<string>();
       
        }

        public void UpdateAccessibleVariableNames()
        {
            LocalVariables.Clear();
            foreach (var item in Items)
            {

                if (item.VType == Enums.VType.Variable)
                {
                    Variable v = (Variable) item;
                    LocalVariables.Add(v.Name);
                }
               
            }

            foreach (var variable in ScopeVariables)
            {
                LocalVariables.Add(variable);                
            }


        }

       


    }
}
