namespace m60._2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_new = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_fileopen = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_filesave = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_basiconeanalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exportresultscsv = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_editorsamplelist = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_lauchagfileeditor = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_launchsamplelisteditor = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pb_xmlreader = new System.Windows.Forms.ToolStripProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tv_tree = new System.Windows.Forms.TreeView();
            this.rtb_status = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbp_plot = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.menu_editorsamplelist});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1268, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_new,
            this.menu_fileopen,
            this.closeProjectToolStripMenuItem,
            this.toolStripSeparator1,
            this.menu_filesave,
            this.menu_saveas,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menu_new
            // 
            this.menu_new.Name = "menu_new";
            this.menu_new.Size = new System.Drawing.Size(163, 22);
            this.menu_new.Text = "New Project";
            this.menu_new.Click += new System.EventHandler(this.menu_new_Click);
            // 
            // menu_fileopen
            // 
            this.menu_fileopen.Name = "menu_fileopen";
            this.menu_fileopen.Size = new System.Drawing.Size(163, 22);
            this.menu_fileopen.Text = "Open Project";
            this.menu_fileopen.Click += new System.EventHandler(this.menu_fileopen_Click);
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.closeProjectToolStripMenuItem.Text = "Close Project";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // menu_filesave
            // 
            this.menu_filesave.Name = "menu_filesave";
            this.menu_filesave.Size = new System.Drawing.Size(163, 22);
            this.menu_filesave.Text = "Save Project";
            this.menu_filesave.Click += new System.EventHandler(this.menu_filesave_Click);
            // 
            // menu_saveas
            // 
            this.menu_saveas.Enabled = false;
            this.menu_saveas.Name = "menu_saveas";
            this.menu_saveas.Size = new System.Drawing.Size(163, 22);
            this.menu_saveas.Text = "Save Project As...";
            this.menu_saveas.Click += new System.EventHandler(this.menu_saveas_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(160, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_basiconeanalysis,
            this.menu_exportresultscsv});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.analysisToolStripMenuItem.Text = "Analysis";
            // 
            // menu_basiconeanalysis
            // 
            this.menu_basiconeanalysis.Name = "menu_basiconeanalysis";
            this.menu_basiconeanalysis.Size = new System.Drawing.Size(200, 22);
            this.menu_basiconeanalysis.Text = "Basic One Chip Analysis";
            this.menu_basiconeanalysis.Click += new System.EventHandler(this.menu_basiconeanalysis_Click);
            // 
            // menu_exportresultscsv
            // 
            this.menu_exportresultscsv.Name = "menu_exportresultscsv";
            this.menu_exportresultscsv.Size = new System.Drawing.Size(200, 22);
            this.menu_exportresultscsv.Text = "Export Results to CSV";
            this.menu_exportresultscsv.Click += new System.EventHandler(this.menu_exportresultscsv_Click);
            // 
            // menu_editorsamplelist
            // 
            this.menu_editorsamplelist.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_lauchagfileeditor,
            this.menu_launchsamplelisteditor});
            this.menu_editorsamplelist.Name = "menu_editorsamplelist";
            this.menu_editorsamplelist.Size = new System.Drawing.Size(50, 20);
            this.menu_editorsamplelist.Text = "Editor";
            // 
            // menu_lauchagfileeditor
            // 
            this.menu_lauchagfileeditor.Name = "menu_lauchagfileeditor";
            this.menu_lauchagfileeditor.Size = new System.Drawing.Size(208, 22);
            this.menu_lauchagfileeditor.Text = "Launch Ag file Editor";
            this.menu_lauchagfileeditor.Click += new System.EventHandler(this.menu_lauchagfileeditor_Click);
            // 
            // menu_launchsamplelisteditor
            // 
            this.menu_launchsamplelisteditor.Name = "menu_launchsamplelisteditor";
            this.menu_launchsamplelisteditor.Size = new System.Drawing.Size(208, 22);
            this.menu_launchsamplelisteditor.Text = "Launch Sample file Editor";
            this.menu_launchsamplelisteditor.Click += new System.EventHandler(this.menu_launchsamplelisteditor_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.pb_xmlreader});
            this.statusStrip1.Location = new System.Drawing.Point(0, 652);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1268, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel1.Text = "Progress:";
            // 
            // pb_xmlreader
            // 
            this.pb_xmlreader.MarqueeAnimationSpeed = 0;
            this.pb_xmlreader.Name = "pb_xmlreader";
            this.pb_xmlreader.Size = new System.Drawing.Size(100, 16);
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1268, 628);
            this.splitContainer1.SplitterDistance = 422;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tv_tree);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.rtb_status);
            this.splitContainer2.Size = new System.Drawing.Size(422, 628);
            this.splitContainer2.SplitterDistance = 330;
            this.splitContainer2.TabIndex = 0;
            // 
            // tv_tree
            // 
            this.tv_tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_tree.Location = new System.Drawing.Point(0, 0);
            this.tv_tree.Name = "tv_tree";
            this.tv_tree.Size = new System.Drawing.Size(418, 326);
            this.tv_tree.TabIndex = 0;
            this.tv_tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_tree_NodeMouseClick);
            // 
            // rtb_status
            // 
            this.rtb_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_status.Location = new System.Drawing.Point(0, 0);
            this.rtb_status.Name = "rtb_status";
            this.rtb_status.Size = new System.Drawing.Size(418, 290);
            this.rtb_status.TabIndex = 0;
            this.rtb_status.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbp_plot);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(838, 624);
            this.tabControl1.TabIndex = 0;
            // 
            // tbp_plot
            // 
            this.tbp_plot.Location = new System.Drawing.Point(4, 22);
            this.tbp_plot.Name = "tbp_plot";
            this.tbp_plot.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_plot.Size = new System.Drawing.Size(830, 598);
            this.tbp_plot.TabIndex = 0;
            this.tbp_plot.Text = "Plot";
            this.tbp_plot.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "project.png");
            this.imageList1.Images.SetKeyName(1, "record.png");
            this.imageList1.Images.SetKeyName(2, "chip.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 674);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DiaChip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_new;
        private System.Windows.Forms.ToolStripMenuItem menu_fileopen;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menu_filesave;
        private System.Windows.Forms.ToolStripMenuItem menu_saveas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        public System.Windows.Forms.TreeView tv_tree;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar pb_xmlreader;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_editorsamplelist;
        private System.Windows.Forms.ToolStripMenuItem menu_lauchagfileeditor;
        private System.Windows.Forms.ToolStripMenuItem menu_launchsamplelisteditor;
        private System.Windows.Forms.RichTextBox rtb_status;
        private System.Windows.Forms.ToolStripMenuItem menu_basiconeanalysis;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbp_plot;
        private System.Windows.Forms.ToolStripMenuItem menu_exportresultscsv;
    }
}

