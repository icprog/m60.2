using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using m60._2;

namespace m60._2
{
    public class NodeRec
    {
        public TreeNode Node = new TreeNode();
        private ContextMenuStrip CMS = new ContextMenuStrip();
        ToolStripMenuItem AddChipLabel = new ToolStripMenuItem();
        ToolStripMenuItem EditRecordLabel = new ToolStripMenuItem();
        ToolStripMenuItem DeleteRecord = new ToolStripMenuItem();
        public NodeRec()
        {
            
            this.Node.NodeFont = new Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold);
            this.Node.ContextMenuStrip = CMS;
            this.EditRecordLabel.Text = "Edit Record Settings";
            this.EditRecordLabel.Enabled = false;
            this.AddChipLabel.Text = "Add Chip";
            this.DeleteRecord.Text = "Delete Record";
            this.DeleteRecord.Enabled = false;
            CMS.Items.AddRange(new ToolStripMenuItem[] { AddChipLabel, EditRecordLabel, DeleteRecord });
        }


    }
}
