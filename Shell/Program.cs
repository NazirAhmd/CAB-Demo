using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.WinForms;

namespace Shell
{
    public class Program : FormShellApplication<WorkItem, ShellForm>
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new Program().Run();
        }

        protected override void AfterShellCreated()
        {
            base.AfterShellCreated();

            this.Shell.IsMdiContainer = true;

            RootWorkItem.Items.Add(this.Shell,"ShellForm");
        }
    }
}
