using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using m60._2;

namespace m60._2
{
    public class NodeChip
    {
        public TreeNode Node = new TreeNode();
        private ContextMenuStrip CMS = new ContextMenuStrip();
        ToolStripMenuItem EditChip = new ToolStripMenuItem();
        ToolStripMenuItem DeleteChip = new ToolStripMenuItem();
        public NodeChip()
        {
            
            this.Node.NodeFont = new Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold);
            this.Node.ContextMenuStrip = CMS;
            this.EditChip.Text = "Edit Chip Settings";
            this.EditChip.Enabled = false;
            this.DeleteChip.Text = "Delete Chip";
            this.DeleteChip.Enabled = false;
            CMS.Items.AddRange(new ToolStripMenuItem[]{EditChip, DeleteChip});
        }


    }
}
