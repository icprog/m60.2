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

        public void ProjNodeMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            switch (e.ClickedItem.ToString())
            {
                case "Add Record":
                    FormRecSettings frm_NewRec = new FormRecSettings(Project.GetProjectPath());
                    frm_NewRec.NewRecUpdated += new FormRecSettings.NewRecUpdateHandler(frm_NewRec_NewRecUpdated);
                    
                    if (frm_NewRec.ShowDialog() == DialogResult.OK)
                    {
                        UpdateTreeView();
                        DisplayStatusMessage("A new record has been added.", MessageColor.Normal);
                    } 
                    break;
                
            }
        }

        private void frm_NewRec_NewRecUpdated(object sender, NewRecUpdateEventArgs e)
        {

            RecInfo ri = new RecInfo();
            //string ProjName = ExtractProjectName(LastRightClickedNode.Text);
            string ProjName = LastRightClickedNode.Text;

            ri.recordname = e.RecName;
            ri.owner = ProjName;
            ri.antigenelistfile = e.AntigeneListFile;
            ri.meanmethod = e.MeanMethod;
            ri.invglobalhandling = e.InvHandling;

            Records.AddNewRecord(ri);

            
        }
    }

}