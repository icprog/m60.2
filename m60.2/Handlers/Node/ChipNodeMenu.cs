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

        public void ChipNodeMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


            switch (e.ClickedItem.ToString())
            {
         
                case "Edit Chip Settings":

                    FormChipSettings frm_EditChip = new FormChipSettings(Project.ProjectPath, Chips.GetChipInfo(LastRightClickedNode.Text));
                    //frm_EditChip.EditChipUpdated += new FormChipSettings.NewChipUpdateHandler(frm_EditChip_EditChipUpdated);
                    frm_EditChip.NewChipUpdated += new FormChipSettings.NewChipUpdateHandler(frm_EditChip_EditChipUpdated);
                    
                    if (frm_EditChip.ShowDialog() == DialogResult.OK)
                    {
                        LastRightClickedNode.Text = "Chip - " + Chips.GetLastChipName();
                    }


                    break;

                case "Delete Chip":
                    break;
            }
        }

        

        private void frm_EditChip_EditChipUpdated(object sender, NewChipUpdateEventArgs e)
        {

            ChipInfo ci = new ChipInfo();

            ci.chipname = e.ChipName;
            ci.chipid = e.ChipID;
            ci.xmlfilename = e.XMLFileName;
            ci.samplelistfilename = e.SampleFileName;        
            ci.invlocalhandling = e.InvHandling;

            Chips.UpdateChip(LastRightClickedNode.Text, ci);
        }


    }

}