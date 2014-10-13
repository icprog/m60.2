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

        private void menu_fileopen_Click(object sender, EventArgs e)
        {          
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Project Files (*.proj)|*.proj";
            ofd.FilterIndex = 0;
            ofd.DefaultExt = "proj";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!String.Equals(Path.GetExtension(ofd.FileName),
                                   ".proj",
                                   StringComparison.OrdinalIgnoreCase))
                {
                    // Invalid file type selected; display an error.
                    MessageBox.Show("The type of the selected file is not supported by this application. You must select an XML file.",
                                    "Invalid File Type",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    // Optionally, force the user to select another file.
                    // ...
                }
                else
                {
                    // The selected file is good; do something with it.
                    // ...
                    DataSet dataSet = new DataSet();
                    if (ofd.FileName.Length > 0)
                        dataSet.ReadXml(ofd.FileName);

                    Project.SetProjects(dataSet.Tables["ProjectInfo"].Copy());
                    if (dataSet.Tables.Contains("RecordInfo") == true) Records.SetRecords(dataSet.Tables["RecordInfo"].Copy());
                    if (dataSet.Tables.Contains("ChipInfo") == true) Chips.SetChips(dataSet.Tables["ChipInfo"].Copy());
                    if (dataSet.Tables.Contains("SubChipData") == true) SubChips.SetSubChips(dataSet.Tables["SubChipData"].Copy());

                    string p = Path.GetDirectoryName(ofd.FileName);
                    //string n = Path.GetFileNameWithoutExtension(ofd.FileName);

                    if (Project.GetProjectPath() != p) 
                        Project.UpdateProjectPath(p);

                    UpdateTreeView();
                    DisplayStatusMessage("The project has been opened.", MessageColor.Normal);
                }
            }
        }

        private void UpdateProjectPath(string fn)
        {

        }

    }//Class vege

}