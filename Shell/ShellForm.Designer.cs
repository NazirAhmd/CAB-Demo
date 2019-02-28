namespace Shell
{
    partial class ShellForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wheelsModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engineModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wheelsModuleToolStripMenuItem,
            this.engineModuleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wheelsModuleToolStripMenuItem
            // 
            this.wheelsModuleToolStripMenuItem.Name = "wheelsModuleToolStripMenuItem";
            this.wheelsModuleToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.wheelsModuleToolStripMenuItem.Text = "Wheels Module";
            // 
            // engineModuleToolStripMenuItem
            // 
            this.engineModuleToolStripMenuItem.Name = "engineModuleToolStripMenuItem";
            this.engineModuleToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.engineModuleToolStripMenuItem.Text = "Engine Module";
            // 
            // ShellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ShellForm";
            this.Text = "Shell Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem wheelsModuleToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem engineModuleToolStripMenuItem;
    }
}

