using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Threading;
using m60._2.Classes;

namespace m60._2.Forms
{
    public partial class FormRecSettings : Form
    {
        public delegate void NewRecUpdateHandler(object sender, NewRecUpdateEventArgs e);
        // add an event of the delegate type
        public event NewRecUpdateHandler NewRecUpdated;
        
        private delegate void SetControlPropertyThreadSafeDelegate(Control control, string propertyName, object propertyValue);

        private string ppath;
        

        public FormRecSettings()
        {
            InitializeComponent();
        }

        public FormRecSettings(string projfolder)
        {
            InitializeComponent();
            this.ppath = projfolder;
        }

        public FormRecSettings(string projfolder, RecInfo ri)
        {
            InitializeComponent();
            this.ppath = projfolder;
            tb_recdatetime.Text = ri.recordname.Substring(0, 8);
            tb_recsuffix.Text = ri.recordname.Substring(9);
            tb_filename.Text = ri.antigenelistfile;
            if (ri.meanmethod == "UK") rbtn_UK.Checked = true;
            else rbtn_DE.Checked = true;

            if (ri.invglobalhandling == "Yes") rbtn_invyes.Checked = true;
            else rbtn_invno.Checked = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void FormRecSettings_Load(object sender, EventArgs e)
        {
            this.tb_recdatetime.Text = DateTime.Today.ToString("yyyyMMdd") + "_";
            btn_ok.Enabled = false;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.TextChanged += new EventHandler(c_TextChanged);
                    if (c.Text.Length > 0 && (c.Name != "tb_recdatetime")) btn_ok.Enabled = true;

                }
            }
            
        }

        void c_TextChanged(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrEmpty(c.Text))
                    {
                        this.btn_ok.Enabled = false;
                        return;
                    }
                }
            }

            this.btn_ok.Enabled = true;
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = this.ppath;
            ofd.Filter = "XML (*.xml)|*.xml";
            ofd.FilterIndex = 0;
            ofd.DefaultExt = ".xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!String.Equals(Path.GetExtension(ofd.FileName),
                                    ".xml",
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
                    if (cb_copy.Checked == false)
                    {
                        this.tb_filename.Text = ofd.FileName;
                       
                    }
                    else
                    {
                        string src, dest;

                        src = ofd.FileName;
                        dest = this.ppath + "\\Info\\" + Path.GetFileName(ofd.FileName);
                        if (src == dest)
                        {
                            MessageBox.Show("Source and destination files are the same.",
                                        "File Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                            return;
                        }
                        File.Copy(src, dest, true);

                        this.tb_filename.Text = dest;
                        
                    }
                    
                }
            }

        }

        
        private void btn_ok_Click(object sender, EventArgs e)
        {
           
            string mm, inv;

            if (rbtn_UK.Checked == true) mm = "UK";
            else mm = "DE";

            if (rbtn_invyes.Checked == true) inv = "Yes";
            else inv = "No";

            // instance the event args and pass it each value
            NewRecUpdateEventArgs args = new NewRecUpdateEventArgs(tb_recdatetime.Text+tb_recsuffix.Text, tb_filename.Text, mm,
                                                                        inv);

            // raise the event with the updated arguments

            NewRecUpdated(this, args);
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }

    public class NewRecUpdateEventArgs : System.EventArgs
    {
        // add local member variables to hold text

        private string mrecname;
        private string mantigenelistfile;
        private string mmeanglobal;
        private string minvglobal;
        


        // class constructor
        public NewRecUpdateEventArgs(string srecname,
                                        string santigenelistfile,
                                        string smeanglobal,
                                        string sinvglobal)
                                       
        {
            this.mrecname = srecname;
            this.mantigenelistfile = santigenelistfile;
            this.mmeanglobal = smeanglobal;
            this.minvglobal = sinvglobal;
            

        }

        // Properties - Viewable by each listener

        public string RecName
        {
            get
            {
                return mrecname;
            }
        }

        public string AntigeneListFile
        {
            get
            {
                return mantigenelistfile;
            }
        }

        public string MeanMethod
        {
            get
            {
                return mmeanglobal;
            }
        }

        public string InvHandling
        {
            get
            {
                return minvglobal;
            }
        }

       

    }//class VCPUpdate
}
