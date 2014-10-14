using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using m60._2.Classes;
using m60._2.Forms;

namespace m60._2
{
    public partial class Form1 : Form
    {
        

        private void menu_new_Click(object sender, EventArgs e)
        {
            

            FormNewProj frm_NewProj = new FormNewProj(/*esetleges Form1-ből jövő paraméterek*/);
            frm_NewProj.NewProjUpdated += new FormNewProj.NewProjUpdateHandler(frm_NewProj_NewProjUpdated);
            frm_NewProj.ShowDialog();

        }


        private void frm_NewProj_NewProjUpdated(object sender, NewProjUpdateEventArgs e)
        {

            ProjInfo pi = new ProjInfo();

            string newprojdirname = e.ProjDate.ToString("yyyyMMdd") + "_" + e.ProjName + "_" + e.ProjOwner;
            pi.projectpath = e.ProjPath + "\\" + newprojdirname; //ez a vegleges
            //pi.projectpath = e.ProjPath; //de most tesztelunk

            if (Directory.Exists(pi.projectpath)) 
            {
                MessageBox.Show("The folder already exists.", "Folder Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //uj verzio
                pi.projectname = e.ProjName;
                pi.projectowner = e.ProjOwner;
                pi.projectdate = e.ProjDate;
                pi.projectcomments = e.ProjComments;
                Project.AddNewProject(pi);
                CreateEmptyProject(pi.projectpath, pi.projectname);
                this.ProjectRoot = pi.projectpath;//abszolút projektelérés gyökérkönyvtár
                UpdateTreeView();

                DisplayStatusMessage("A new project has been created.", MessageColor.Normal);
            }
        }

        private void CreateEmptyProject(string pp, string projectname)
        {
            try
            {
      
                // Try to create the directory.
                Directory.CreateDirectory(pp);

                Directory.CreateDirectory(pp + "\\Data");
                Directory.CreateDirectory(pp + "\\Info");
                Directory.CreateDirectory(pp + "\\XML");

                DataSet ds = new DataSet();

                ds.DataSetName = "ProjectData";
                ds.Tables.Add(Project.GetProjects().Copy());
                ds.Tables.Add(Records.GetRecords().Copy());
                ds.Tables.Add(Chips.GetChips().Copy());
                ds.Tables.Add(SubChips.GetSubChips().Copy());


                ds.WriteXml(pp + "\\"+ projectname+".proj");

            }
            catch (Exception ex)
            {
                //
            }
            finally { }

        }

    }
}