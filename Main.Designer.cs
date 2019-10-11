namespace WorkingWithLists
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.workingWithListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_list_manager = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecordToProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataToListProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workingWithListsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // workingWithListsToolStripMenuItem
            // 
            this.workingWithListsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_list_manager,
            this.addRecordToProductToolStripMenuItem,
            this.importDataToListProductToolStripMenuItem});
            this.workingWithListsToolStripMenuItem.Name = "workingWithListsToolStripMenuItem";
            this.workingWithListsToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.workingWithListsToolStripMenuItem.Text = "Working With Lists";
            // 
            // mnu_list_manager
            // 
            this.mnu_list_manager.Name = "mnu_list_manager";
            this.mnu_list_manager.Size = new System.Drawing.Size(211, 22);
            this.mnu_list_manager.Text = "List Manager";
            this.mnu_list_manager.Click += new System.EventHandler(this.Mnu_list_manager_Click);
            // 
            // addRecordToProductToolStripMenuItem
            // 
            this.addRecordToProductToolStripMenuItem.Name = "addRecordToProductToolStripMenuItem";
            this.addRecordToProductToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.addRecordToProductToolStripMenuItem.Text = "Add record to Product";
            this.addRecordToProductToolStripMenuItem.Click += new System.EventHandler(this.AddRecordToProductToolStripMenuItem_Click);
            // 
            // importDataToListProductToolStripMenuItem
            // 
            this.importDataToListProductToolStripMenuItem.Name = "importDataToListProductToolStripMenuItem";
            this.importDataToListProductToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.importDataToListProductToolStripMenuItem.Text = "ImportDataToList Product";
            this.importDataToListProductToolStripMenuItem.Click += new System.EventHandler(this.ImportDataToListProductToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WorkingWithLists.Properties.Resources.SharePoint_Back;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem workingWithListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_list_manager;
        private System.Windows.Forms.ToolStripMenuItem addRecordToProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDataToListProductToolStripMenuItem;
    }
}