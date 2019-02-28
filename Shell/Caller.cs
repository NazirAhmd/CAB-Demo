using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.ObjectBuilder;

namespace Shell
{
    public class Caller
    {
        private Callee callee;

        [InjectionConstructor]
        public Caller([ComponentDependency("CalleeId")]Callee callee)
        {
            this.callee = callee;
        }

        //[CreateNew]
        //public Callee Callee
        //{
        //    set
        //    {
        //        callee = value;
        //    }
        //}

        //[ComponentDependency("CalleeId")]
        //public Callee Callee
        //{
        //    set
        //    {
        //        callee = value;
        //    }
        //}

        //[ServiceDependency]
        //public Callee Callee
        //{
        //    set
        //    {
        //        callee = value;
        //    }
        //}

        public void Print()
        {
            callee.Display();
        }
    }
}
