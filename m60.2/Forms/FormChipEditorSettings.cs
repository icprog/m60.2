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
    public partial class FormChipEditorSettings : Form
    {
        public delegate void NewChipSettingsUpdateHandler(object sender, NewChipSettingsUpdateEventArgs e);
        // add an event of the delegate type
        public event NewChipSettingsUpdateHandler NewChipSettingsUpdated;

        public FormChipEditorSettings()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;

            if (tabControl1.SelectedTab.Text == "Advanced")
            {

                if (tb_numspots.Text.Length == 0 || tb_columns.Text.Length == 0 || tb_numspotsmean.Text.Length == 0)
                {
                    MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK);
                }

                else if (tb_numspots.Text.Length > 0 && tb_columns.Text.Length > 0)
                {
                    if ((Convert.ToInt32(tb_numspots.Text) % (Convert.ToInt32(tb_columns.Text))) > 0)
                    MessageBox.Show("The number of spots doesn't match with the number of columns.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    string mm;
                    if (rbtn_uk.Checked == true) mm = "UK";
                    else mm = "DE";

                    NewChipSettingsUpdateEventArgs args = new NewChipSettingsUpdateEventArgs(
                                                        Convert.ToInt32(tb_numspots.Text),
                                                        Convert.ToInt32(tb_columns.Text),
                                                        Convert.ToInt32(tb_numspotsmean.Text),
                                                        mm
                                                     );
                    NewChipSettingsUpdated(this, args);
                    this.DialogResult = DialogResult.OK;
                }

            }

            else
            {
                string mm;
                switch (cmb_chiptype.SelectedIndex)
                {
                    case 0://IR
                        tb_numspots.Text = "156";
                        tb_columns.Text = "13";
                        mm = "UK"; 
                        break;
                    case 1://RA(UK)
                        tb_numspots.Text = "156";
                        tb_columns.Text = "13";
                        mm = "UK";
                        break;
                    case 2://RA(DE)
                        tb_numspots.Text = "156";
                        tb_columns.Text = "12";
                        mm = "DE";
                        break;
                    case 3://SLE(DE)
                        tb_numspots.Text = "156";
                        tb_columns.Text = "12";
                        mm = "DE";
                        break;
                    default:
                        tb_numspots.Text = "156";
                        tb_columns.Text = "13";
                        mm = "UK";
                        break;
                }

                tb_numspotsmean.Text = "3";

                NewChipSettingsUpdateEventArgs args = new NewChipSettingsUpdateEventArgs(
                                                        Convert.ToInt32(tb_numspots.Text),
                                                        Convert.ToInt32(tb_columns.Text),
                                                        Convert.ToInt32(tb_numspotsmean.Text),
                                                        mm
                                                     );
                NewChipSettingsUpdated(this, args);
                this.DialogResult = DialogResult.OK;
            }
         
            
            
            if (this.DialogResult == DialogResult.OK) this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormChipEditorSettings_Load(object sender, EventArgs e)
        {
            cmb_chiptype.SelectedIndex = 0;
        }
    }

    public class NewChipSettingsUpdateEventArgs : System.EventArgs
    {
        // add local member variables to hold text

        private int mnumspots;
        private int mnumcol;
        private int mspotmean;
        private string mmeanmethod;
        



        // class constructor
        public NewChipSettingsUpdateEventArgs(int snumspots,
                                        int snumcol,
                                        int sspotmean,
                                        string smeanmethod)
        {
            this.mnumspots = snumspots;
            this.mnumcol = snumcol;
            this.mspotmean = sspotmean;
            this.mmeanmethod = smeanmethod;
     


        }

        // Properties - Viewable by each listener
        public int NumSpots
        {
            get
            {
                return mnumspots;
            }
        }


        public int NumCol
        {
            get
            {
                return mnumcol;
            }
        }

        public int NumMeanSpots
        {
            get
            {
                return mspotmean;
            }
        }

       
        public string MeanMethod
        {
            get
            {
                return mmeanmethod;
            }
        }



    }//class VCPUpdate
}
