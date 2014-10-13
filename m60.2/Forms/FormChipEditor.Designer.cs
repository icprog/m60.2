namespace m60._2.Forms
{
    partial class FormChipEditor
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_newagfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_openagfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_saveagfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgw_spotlist = new System.Windows.Forms.DataGridView();
            this.dgw_spots = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_spotlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_spots)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1192, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_newagfile,
            this.toolStripSeparator2,
            this.menu_openagfile,
            this.menu_saveagfile,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menu_newagfile
            // 
            this.menu_newagfile.Name = "menu_newagfile";
            this.menu_newagfile.Size = new System.Drawing.Size(146, 22);
            this.menu_newagfile.Text = "New Ag File";
            this.menu_newagfile.Click += new System.EventHandler(this.menu_newagfile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // menu_openagfile
            // 
            this.menu_openagfile.Name = "menu_openagfile";
            this.menu_openagfile.Size = new System.Drawing.Size(146, 22);
            this.menu_openagfile.Text = "Open Ag File";
            this.menu_openagfile.Click += new System.EventHandler(this.menu_openagfile_Click);
            // 
            // menu_saveagfile
            // 
            this.menu_saveagfile.Name = "menu_saveagfile";
            this.menu_saveagfile.Size = new System.Drawing.Size(146, 22);
            this.menu_saveagfile.Text = "Save Ag File";
            this.menu_saveagfile.Click += new System.EventHandler(this.menu_saveagfile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgw_spotlist);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgw_spots);
            this.splitContainer1.Size = new System.Drawing.Size(1192, 542);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgw_spotlist
            // 
            this.dgw_spotlist.AllowUserToAddRows = false;
            this.dgw_spotlist.AllowUserToDeleteRows = false;
            this.dgw_spotlist.AllowUserToResizeColumns = false;
            this.dgw_spotlist.AllowUserToResizeRows = false;
            this.dgw_spotlist.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgw_spotlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgw_spotlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgw_spotlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_spotlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_spotlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgw_spotlist.Location = new System.Drawing.Point(0, 0);
            this.dgw_spotlist.Name = "dgw_spotlist";
            this.dgw_spotlist.Size = new System.Drawing.Size(396, 538);
            this.dgw_spotlist.TabIndex = 0;
            this.dgw_spotlist.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_spotlist_CellValueChanged);
            // 
            // dgw_spots
            // 
            this.dgw_spots.AllowUserToAddRows = false;
            this.dgw_spots.AllowUserToDeleteRows = false;
            this.dgw_spots.AllowUserToResizeColumns = false;
            this.dgw_spots.AllowUserToResizeRows = false;
            this.dgw_spots.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgw_spots.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgw_spots.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgw_spots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_spots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_spots.Location = new System.Drawing.Point(0, 0);
            this.dgw_spots.MultiSelect = false;
            this.dgw_spots.Name = "dgw_spots";
            this.dgw_spots.ReadOnly = true;
            this.dgw_spots.RowHeadersWidth = 61;
            this.dgw_spots.Size = new System.Drawing.Size(784, 538);
            this.dgw_spots.TabIndex = 0;
            // 
            // FormChipEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 566);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormChipEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chip Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_spotlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_spots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_newagfile;
        private System.Windows.Forms.ToolStripMenuItem menu_openagfile;
        private System.Windows.Forms.ToolStripMenuItem menu_saveagfile;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgw_spots;
        private System.Windows.Forms.DataGridView dgw_spotlist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}