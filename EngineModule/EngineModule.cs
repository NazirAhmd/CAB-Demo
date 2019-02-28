using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.Commands;

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
        }

        [CommandHandler("EngineClick")]
        public void engineModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form shellForm = (Form)_parentWorkItem.Items.Get("ShellForm");
            EngineForm engineForm = new EngineForm();
            engineForm.MdiParent = shellForm;
            engineForm.Show();
        }
    }
}
