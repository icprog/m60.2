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
using System.IO;
using m60._2.Classes;
using m60._2.DataTables;

namespace m60._2.Forms
{
    public partial class FormChipSettings : Form
    {
        public delegate void NewChipUpdateHandler(object sender, NewChipUpdateEventArgs e);
        //public delegate void VerifyChipsSamplesDelegate(DataSet ds, DataTable dt);

        // add an event of the delegate type
        public event NewChipUpdateHandler NewChipUpdated;       
        private string ppath;
        public Form1 parent;

        public FormChipSettings()
        {
            InitializeComponent();
        }

        public FormChipSettings(string projfolder)
        {
            InitializeComponent();
            this.ppath = projfolder;
            tb_chipid.Text = "not specified";
            
        }

        public FormChipSettings(string projfolder, ChipInfo ci)
        {
            InitializeComponent();
            this.ppath = projfolder;
            tb_chipname.Text = ci.chipname;
            tb_chipid.Text = ci.chipid;
            tb_xmlfilename.Text = ci.xmlfilename;
            tb_samplefilename.Text = ci.samplelistfilename;
            

            if (ci.invlocalhandling == "Yes") rbtn_invyes.Checked = true;
            else rbtn_invno.Checked = true;
        }

        

        private void FormChipSettings_Load(object sender, EventArgs e)
        {
            
            btn_ok.Enabled = false;
            
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.TextChanged += new EventHandler(c_TextChanged);
                    if (c.Text.Length > 0) btn_ok.Enabled = true;
                        
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

        private void btn_browsexml_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = this.ppath;
            ofd.Filter = "XML Files (*.xml)|*.xml";
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
                    if (cb_copyxml.Checked == false)
                    {
                        this.tb_xmlfilename.Text = ofd.FileName;
                        
                    }
                    else
                    {
                        string src, dest;

                        src = ofd.FileName;
                        dest = this.ppath + "\\XML\\" + Path.GetFileName(ofd.FileName);
                        if (src == dest)
                        {
                            MessageBox.Show("Source and destination files are the same.",
                                        "File Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                            return;
                        }
                        File.Copy(src, dest, true);

                        this.tb_xmlfilename.Text = dest;
                       
                    }
                }
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = this.ppath;
            ofd.Filter = "XML Files (*.xml)|*.xml";
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
                        this.tb_samplefilename.Text = ofd.FileName;

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

                        this.tb_samplefilename.Text = dest;
                    }
                }
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
         
            string inv;
            

            if (rbtn_invyes.Checked == true) inv = "Yes";
            else inv = "No";

            // instance the event args and pass it each value
            NewChipUpdateEventArgs args = new NewChipUpdateEventArgs(tb_chipname.Text,
                                                                        tb_chipid.Text,
                                                                        tb_xmlfilename.Text, 
                                                                        tb_samplefilename.Text,
                                                                       // dt,
                                                                        inv);

            // raise the event with the updated arguments

            NewChipUpdated(this, args);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }

    public class NewChipUpdateEventArgs : System.EventArgs
    {
        // add local member variables to hold text

        private string mchipname;
        private string mchipid;
        private string mxmlfilename;
        private string msamplefilename;
      //  private DataTable mxmltable;
        private string minvglobal;
        


        // class constructor
        public NewChipUpdateEventArgs(  string schipname,
                                        string schipid,
                                        string sxmlfilename,
                                        string ssamplefilename,
        //                                DataTable sxmltable,
                                        string sinvglobal)
        {
            this.mchipname = schipname;
            this.mchipid = schipid;
            this.mxmlfilename = sxmlfilename;
            this.msamplefilename = ssamplefilename;
         //   this.mxmltable = sxmltable;
            this.minvglobal = sinvglobal;


        }

        // Properties - Viewable by each listener
        public string ChipName
        {
            get
            {
                return mchipname;
            }
        }

        public string ChipID
        {
            get
            {
                return mchipid;
            }
        }


        public string XMLFileName
        {
            get
            {
                return mxmlfilename;
            }
        }

        public string SampleFileName
        {
            get
            {
                return msamplefilename;
            }
        }

        //public DataTable XMLTable
        //{
        //    get
        //    {
        //        return mxmltable;
        //    }
        //}


        public string InvHandling
        {
            get
            {
                return minvglobal;
            }
        }



    }//class VCPUpdate
}
