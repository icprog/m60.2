using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace m60._2
{

    public partial class Form1 : Form
    {

        private void menu_filesave_Click(object sender, EventArgs e)
        {
            #region Finding (or creating if it doesn't exist) DiaChip folder in Application Data

            // The folder for the roaming current user 
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // Combine the base folder with your specific folder....
            string specificFolder = Path.Combine(folder, "DiaChip");

            // Check if folder exists and if not, create it
            if (!Directory.Exists(specificFolder))
                Directory.CreateDirectory(specificFolder);
            #endregion

            //string file = @"C:\program files\myapp\file.txt";
            //File.Copy(file. Path.Combine(specificFolder, Path.GetFileName(file));



            DataSet ds = new DataSet();

            ds.DataSetName = "ProjectData";
            ds.Tables.Add(Project.GetProjects().Copy());
            ds.Tables.Add(Records.GetRecords().Copy());
            ds.Tables.Add(Chips.GetChips().Copy());
            ds.Tables.Add(SubChips.GetSubChips().Copy());

            ds.WriteXml(this.ProjectRoot + "\\" + Project.GetProjectName() + ".proj");

            //még hasznalható kód

            //SaveFileDialog sd = new SaveFileDialog();
            //sd.Filter = "Project files (*.proj)|*.proj|All files (*.*)|*.*";
            //DialogResult result = sd.ShowDialog();

            //if (result == DialogResult.Cancel) return;
            //else
            //{
            //    // Save to disk
            //    if (sd.FileName.Length > 0)
            //        ds.WriteXml(sd.FileName);
            //    Project.IsModified = false;
            //}


        }
        
       
    }

}