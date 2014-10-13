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
        private BackgroundWorker backgroundWorker2 = new BackgroundWorker();
        List<double> spl = new List<double>();
        //bool IsXMLReadInProgress = new bool();
        DataTable rawdata = new DataTable();

        public void RecNodeMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            

            switch (e.ClickedItem.ToString())
            {
                case "Add Chip":
                    FormChipSettings frm_NewChip = new FormChipSettings(Project.GetProjectPath());
                    frm_NewChip.parent = this;
                    frm_NewChip.NewChipUpdated += new FormChipSettings.NewChipUpdateHandler(frm_NewChip_NewChipUpdated);
                    
                    if (frm_NewChip.ShowDialog() == DialogResult.OK)
                    {
                        UpdateTreeView();
                        DisplayStatusMessage("A new chip has been added.", MessageColor.Normal);
                    }
                    
                    break;

                case "Edit Record Settings":

                    FormRecSettings frm_EditRec = new FormRecSettings(Project.GetProjectPath(), Records.GetRecordInfo(LastRightClickedNode.Text));
                    frm_EditRec.NewRecUpdated += new FormRecSettings.NewRecUpdateHandler(frm_EditRec_EditRecUpdated);
                    
                    if (frm_EditRec.ShowDialog() == DialogResult.OK)
                    {
                        LastRightClickedNode.Text = "Record - " + Records.GetLastRecordName();
                    }


                    break;

                case "Delete Record":
                    break;
            }
        }

        private void frm_NewChip_NewChipUpdated(object sender, NewChipUpdateEventArgs e)
        {
            //string RecName = ExtractRecordName(LastRightClickedNode.Text);

            string RecName = LastRightClickedNode.Text;

            if (SubChips.AddSubChipRows(e.XMLFileName, e.SampleFileName, e.ChipName, RecName)
                == true)
            {
                ChipInfo ci = new ChipInfo();

                ci.chipname = e.ChipName;
                ci.owner = RecName;
                ci.chipid = e.ChipID;
                ci.xmlfilename = e.XMLFileName;
                ci.samplelistfilename = e.SampleFileName;
                ci.invlocalhandling = e.InvHandling;
                Chips.AddNewChip(ci);
            }

            
                       
        }

        

       



        private void frm_EditRec_EditRecUpdated(object sender, NewRecUpdateEventArgs e)
        {

            RecInfo ri = new RecInfo();

            ri.recordname = e.RecName;
            ri.antigenelistfile = e.AntigeneListFile;
            ri.meanmethod = e.MeanMethod;
            ri.invglobalhandling = e.InvHandling;

            Records.UpdateRecord(LastRightClickedNode.Text, ri);
        }


    }

}