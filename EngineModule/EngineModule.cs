using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI;

namespace EngineModule
{
    public class EngineModule:ModuleInit
    {
        private WorkItem _parentWorkItem;

        [ServiceDependency]
        public WorkItem ParentWorkItem
        {
            set { _parentWorkItem = value; }
        }

        public override void Load()
        {
            base.Load();
            Form shellForm = (Form)_parentWorkItem.Items.Get("ShellForm");
            EngineForm engineForm=new EngineForm();
            engineForm.MdiParent = shellForm;
            engineForm.Show();
        }
    }
}
