using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using m60._2;

namespace m60._2
{
    public class NodeProj
    {
        public TreeNode Node = new TreeNode();
        private ContextMenuStrip CMS = new ContextMenuStrip();
        ToolStripMenuItem AddRecordLabel = new ToolStripMenuItem();

        public NodeProj()
        {
            //this.Node.Text = "Project";
            this.Node.NodeFont =new Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold);
            this.Node.ContextMenuStrip = CMS;
            this.AddRecordLabel.Text = "Add Record";
            //AddRecordLabel.Enabled = false;
            CMS.Items.Add(AddRecordLabel);

        }


    }
}
