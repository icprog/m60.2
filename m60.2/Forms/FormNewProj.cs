using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;

namespace m60._2.Forms
{
    public partial class FormNewProj : Form
    {
        public delegate void NewProjUpdateHandler(object sender, NewProjUpdateEventArgs e);
        // add an event of the delegate type
        public event NewProjUpdateHandler NewProjUpdated;
        

        public FormNewProj()
        {
            InitializeComponent();
        }
        private void FormNewProj_Load(object sender, EventArgs e)
        {
            //tb_newprojname.Text = "Test Project";
            tb_newprojowner.Text = "John Smith";
            tb_newprojcomments.Text = "Some comments may be written here.";
            dtp_newprojdate.Value = DateTime.Today;

           
        }

        

      

        

      



        private void btn_cancel_Click(object sender, EventArgs e)
        {
         
            this.Close();
        }

        

        private void btn_create_Click(object sender, EventArgs e)
        {
          

            
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();


            // instance the event args and pass it each value
            NewProjUpdateEventArgs args = new NewProjUpdateEventArgs(tb_newprojname.Text, tb_newprojowner.Text, folderDlg.SelectedPath,
                                                                        tb_newprojcomments.Text, dtp_newprojdate.Value);

            // raise the event with the updated arguments
            
            NewProjUpdated(this, args);
            
            //this.Dispose();
            this.Close();
        }

        
    }

    public class NewProjUpdateEventArgs : System.EventArgs
    {
        // add local member variables to hold text

        private string mprojname;
        private string mprojowner;
        private string mselectedpath;
        private string mprojcomments;
        private DateTime mprojdate;


        // class constructor
        public NewProjUpdateEventArgs(string sprojname,
                                        string sprojowner,
                                        string sselectedpath,
                                        string sprojcomments,
                                        DateTime sprojdate)
        {
            this.mprojname = sprojname;
            this.mprojowner = sprojowner;
            this.mselectedpath = sselectedpath;
            this.mprojcomments = sprojcomments;
            this.mprojdate = sprojdate;

        }

        // Properties - Viewable by each listener

        public string ProjName
        {
            get
            {
                return mprojname;
            }
        }

        public string ProjOwner
        {
            get
            {
                return mprojowner;
            }
        }

        public string ProjPath
        {
            get
            {
                return mselectedpath;
            }
        }

        public string ProjComments
        {
            get
            {
                return mprojcomments;
            }
        }

        public DateTime ProjDate
        {
            get
            {
                return mprojdate;
            }
        }

    }//class VCPUpdate
}
