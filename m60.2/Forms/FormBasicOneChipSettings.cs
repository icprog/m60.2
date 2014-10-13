using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace m60._2.Forms
{
    public partial class FormBasicOneChipSettings : Form
    {
        public DataTable records;
        public DataTable chips;
        public DataTable subchips;
        public delegate void BasicOneChipUpdateHandler(object sender, BasicOneChipEventArgs e);
        public event BasicOneChipUpdateHandler BasicOneChipUpdated;

        public FormBasicOneChipSettings()
        {
            InitializeComponent();
        }

        private void FormBasicOneChipSettings_Load(object sender, EventArgs e)
        {
            cmb_selrec.Items.Add("---");
            cmb_selchip.Enabled = false;
            cmb_selAg.Enabled = false;
            cmb_selAgnorm.Enabled = false;
            

            foreach (DataRow dr in records.Rows)
            {
                cmb_selrec.Items.Add(dr["RecordName"].ToString());
            }

            cmb_selrec.SelectedIndex = 0;
        }

        private void cmb_selrec_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_selrec.SelectedIndex > 0)
            {
                cmb_selchip.Enabled = true;
                cmb_selAg.Enabled = true;
                cmb_selAgnorm.Enabled = true;
                foreach (DataRow dr in chips.Rows)
                {
                    if (dr["Owner"].ToString().Contains(cmb_selrec.SelectedItem.ToString()) == true)
                    {
                        cmb_selchip.Items.Add(dr["ChipName"].ToString());
                    }
                }
                if (cmb_selchip.Items.Count>0) cmb_selchip.SelectedIndex = 0;

                int i = 0;
                cmb_selAgnorm.Items.Add("---");
                for (i = 0; i < 52; ++i)
                {
                    cmb_selAg.Items.Add(records.Rows[0][5 + i].ToString());
                    cmb_selAgnorm.Items.Add(records.Rows[0][5 + i].ToString());
                }

                if (cmb_selAg.Items.Count > 0) cmb_selAg.SelectedIndex = 0;
                if (cmb_selAgnorm.Items.Count > 0) cmb_selAgnorm.SelectedIndex = 0;
                
            }
        }

        private void btn_plot_Click(object sender, EventArgs e)
        {
            BasicOneChipEventArgs args = new BasicOneChipEventArgs(cmb_selrec.SelectedItem.ToString(),
                                                                    cmb_selchip.SelectedItem.ToString(),
                                                                    cmb_selAg.SelectedItem.ToString(),
                                                                    cmb_selAgnorm.SelectedItem.ToString());
            BasicOneChipUpdated(this, args);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

    public class BasicOneChipEventArgs : System.EventArgs
    {
        // add local member variables to hold text

        private string mrecordname;
        private string mchipname;
        private string mag;
        private string magnorm;
       


        // class constructor
        public BasicOneChipEventArgs(string srecordname,
                                        string schipname,
                                        string sag,
                                        string sagnorm)
                                       
        {
            this.mrecordname = srecordname;
            this.mchipname = schipname;
            this.mag = sag;
            this.magnorm = sagnorm;
            

        }

        // Properties - Viewable by each listener

        public string RecName
        {
            get
            {
                return mrecordname;
            }
        }

        public string ChipName
        {
            get
            {
                return mchipname;
            }
        }

        public string Ag
        {
            get
            {
                return mag;
            }
        }

        public string AgNorm
        {
            get
            {
                return magnorm;
            }
        }


    }//class updateeventargs
}
