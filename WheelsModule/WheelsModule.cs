using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.Commands;

namespace WheelsModule
{
    public class WheelsModule:ModuleInit
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

        [CommandHandler("WheelsClick")]
        public void wheelsModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form shellForm = (Form)_parentWorkItem.Items.Get("ShellForm");
            WheelsForm wheelForm = new WheelsForm();
            wheelForm.MdiParent = shellForm;
            wheelForm.Show();
        }
    }
}
