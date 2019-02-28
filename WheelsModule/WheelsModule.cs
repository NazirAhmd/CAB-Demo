using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.CompositeUI;

namespace WheelsModule
{
    public class WheelsModule:ModuleInit
    {
        public override void Load()
        {
            base.Load();
            WheelsForm form=new WheelsForm();
            form.Show();
        }
    }
}
