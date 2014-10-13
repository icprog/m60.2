using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using m60._2.Forms;
using m60._2.Classes;
using m60._2.DataTables;


namespace m60._2
{
    public partial class Form1 : Form
    {

        private void UpdateTreeView()
        {
            tv_tree.Nodes.Clear();
            tv_tree.ImageList = imageList1;
            //Add projects to treeview
            foreach (DataRow drp in Project.GetProjects().Rows)
            {
                NodeProj np = new NodeProj();
                tv_tree.Nodes.Add(np.Node);
                // set text after adding it to treeview to prevent truncation bug
                np.Node.Text =/* "Project - " + */drp["ProjectName"].ToString()/* + " - " + drp["ProjectOwner"].ToString()*/;
                np.Node.ImageIndex = 0;
                np.Node.SelectedImageIndex = 0;
                np.Node.ContextMenuStrip.ItemClicked += new ToolStripItemClickedEventHandler(ProjNodeMenu_ItemClicked);

                string owner;

                foreach (DataRow drr in Records.GetRecords().Rows)
                {
                    //get the owner of the record
                    //owner = this.ExtractProjectName(drr["Owner"].ToString());
                    owner = drr["Owner"].ToString();

                    
                    if (owner == drp["ProjectName"].ToString())
                    {
                        NodeRec nr = new NodeRec();
                        np.Node.Nodes.Add(nr.Node);

                        // set text after adding it to treeview to prevent truncation bug
                        nr.Node.Text =/* "Record - " +*/ drr["RecordName"].ToString();
                        nr.Node.ImageIndex = 1;
                        nr.Node.SelectedImageIndex = 1;
                        nr.Node.ContextMenuStrip.ItemClicked += new ToolStripItemClickedEventHandler(RecNodeMenu_ItemClicked);

                        foreach (DataRow drc in Chips.GetChips().Rows)
                        {
                            //owner = this.ExtractRecordName(drc["Owner"].ToString());
                            owner = drc["Owner"].ToString();

                            if (owner == drr["RecordName"].ToString())
                            {
                                NodeChip nc = new NodeChip();
                                nr.Node.Nodes.Add(nc.Node);

                                // set text after adding it to treeview to prevent truncation bug
                                nc.Node.Text = /*"Chip - " +*/ drc["ChipName"].ToString();
                                nc.Node.ImageIndex = 2;
                                nc.Node.SelectedImageIndex = 2;
                                nc.Node.ContextMenuStrip.ItemClicked += new ToolStripItemClickedEventHandler(ChipNodeMenu_ItemClicked);
                            }

                        }
                    }
                }

            }

            tv_tree.ExpandAll();
        }

        private string ExtractProjectName(string pn)
        {

            string projectname = pn.Substring(10);

            projectname = projectname.Remove(projectname.IndexOf(' '));

            return projectname;
        }

        private string ExtractRecordName(string pn)
        {

            string recordname = pn.Substring(9);

            //projectname = projectname.Remove(projectname.IndexOf(' '));

            return recordname;
        }

        private void DisplayStatusMessage(string msg, MessageColor col)
        {
            rtb_status.AppendText(DateTime.Now.ToShortTimeString() + " >> ");
            switch (col)
            {
                case MessageColor.Normal:
                    rtb_status.SelectionColor = Color.Black;
                    rtb_status.AppendText(msg + "\r\n");
                    break;
                case MessageColor.Warning:
                    rtb_status.SelectionColor = Color.Orange;
                    rtb_status.AppendText(msg + "\r\n");
                    break;
                case MessageColor.Error:
                    rtb_status.SelectionColor = Color.Red;
                    rtb_status.AppendText(msg + "\r\n");
                    break;
            }
        }
        

    }

}