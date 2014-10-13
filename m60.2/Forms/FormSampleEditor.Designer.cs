namespace m60._2.Forms
{
    partial class FormSampleEditor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addcolumn = new System.Windows.Forms.Button();
            this.btn_addrow = new System.Windows.Forms.Button();
            this.dgw_samplelist = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_new = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_samplelist)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btn_addcolumn);
            this.panel1.Controls.Add(this.btn_addrow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 32);
            this.panel1.TabIndex = 0;
            // 
            // btn_addcolumn
            // 
            this.btn_addcolumn.Location = new System.Drawing.Point(341, 6);
            this.btn_addcolumn.Name = "btn_addcolumn";
            this.btn_addcolumn.Size = new System.Drawing.Size(110, 23);
            this.btn_addcolumn.TabIndex = 3;
            this.btn_addcolumn.Text = "Add New Column";
            this.btn_addcolumn.UseVisualStyleBackColor = true;
            this.btn_addcolumn.Click += new System.EventHandler(this.btn_addcolumn_Click);
            // 
            // btn_addrow
            // 
            this.btn_addrow.Location = new System.Drawing.Point(12, 6);
            this.btn_addrow.Name = "btn_addrow";
            this.btn_addrow.Size = new System.Drawing.Size(110, 23);
            this.btn_addrow.TabIndex = 2;
            this.btn_addrow.Text = "Add New Row";
            this.btn_addrow.UseVisualStyleBackColor = true;
            this.btn_addrow.Click += new System.EventHandler(this.btn_addrow_Click);
            // 
            // dgw_samplelist
            // 
            this.dgw_samplelist.AllowUserToAddRows = false;
            this.dgw_samplelist.AllowUserToDeleteRows = false;
            this.dgw_samplelist.AllowUserToResizeColumns = false;
            this.dgw_samplelist.AllowUserToResizeRows = false;
            this.dgw_samplelist.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgw_samplelist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgw_samplelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_samplelist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_samplelist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgw_samplelist.Location = new System.Drawing.Point(0, 24);
            this.dgw_samplelist.Name = "dgw_samplelist";
            this.dgw_samplelist.RowHeadersWidth = 51;
            this.dgw_samplelist.Size = new System.Drawing.Size(463, 210);
            this.dgw_samplelist.TabIndex = 1;
            this.dgw_samplelist.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_samplelist_CellValueChanged);
            this.dgw_samplelist.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgw_samplelist_CurrentCellDirtyStateChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_new,
            this.menu_open,
            this.menu_save,
            this.toolStripSeparator1,
            this.menu_exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menu_new
            // 
            this.menu_new.Name = "menu_new";
            this.menu_new.Size = new System.Drawing.Size(167, 22);
            this.menu_new.Text = "New Sample List";
            this.menu_new.Click += new System.EventHandler(this.menu_new_Click);
            // 
            // menu_open
            // 
            this.menu_open.Name = "menu_open";
            this.menu_open.Size = new System.Drawing.Size(167, 22);
            this.menu_open.Text = "Open Sample List";
            this.menu_open.Click += new System.EventHandler(this.menu_open_Click);
            // 
            // menu_save
            // 
            this.menu_save.Name = "menu_save";
            this.menu_save.Size = new System.Drawing.Size(167, 22);
            this.menu_save.Text = "Save Sample List";
            this.menu_save.Click += new System.EventHandler(this.menu_save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(167, 22);
            this.menu_exit.Text = "Exit";
            this.menu_exit.Click += new System.EventHandler(this.menu_exit_Click);
            // 
            // FormSampleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 266);
            this.Controls.Add(this.dgw_samplelist);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSampleEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sample Editor";
            this.Load += new System.EventHandler(this.FormSampleEditor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_samplelist)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgw_samplelist;
        private System.Windows.Forms.Button btn_addcolumn;
        private System.Windows.Forms.Button btn_addrow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_new;
        private System.Windows.Forms.ToolStripMenuItem menu_open;
        private System.Windows.Forms.ToolStripMenuItem menu_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
    }
}