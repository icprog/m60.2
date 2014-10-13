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
    public partial class FormSampleEditor : Form
    {
        DataTable SampleList = new DataTable();
        bool IsModified;
        public FormSampleEditor()
        {
            InitializeComponent();
        }

        private void menu_exit_Click(object sender, EventArgs e)
        {
            if (this.IsModified == false) this.Close();
            else
            {
                DialogResult result = MessageBox.Show("Exit without saving?", "Warning", MessageBoxButtons.YesNo);

                if (result == DialogResult.No) return;
                else this.Close();
            }
        }

        private void menu_new_Click(object sender, EventArgs e)
        {
           
            SampleList = CreateDefaultSampleListTable().Copy();
            dgw_samplelist.DataSource = SampleList;
            MakeNonSortable();
            btn_addrow.Enabled = true;
            btn_addcolumn.Enabled = true;           
        }

        private void btn_addrow_Click(object sender, EventArgs e)
        {
            if (SampleList.Rows.Count < 8)
            {
                DataRow dr = SampleList.NewRow();
                SampleList.Rows.Add(dr);
                dgw_samplelist.DataSource = SampleList;
                NumberRowHeaders();
                this.IsModified = true;
            }
            else MessageBox.Show("You've reached the maximum number of rows.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            
        }

        private void FormSampleEditor_Load(object sender, EventArgs e)
        {
            btn_addrow.Enabled = false;
            btn_addcolumn.Enabled = false;
            this.IsModified = false;
            
        }

        private DataTable CreateDefaultSampleListTable()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("1", typeof(string));
            dt.Columns.Add("2", typeof(string));
            dt.TableName = "Data";
            this.IsModified = true;
            return dt;

        }


        private void MakeNonSortable()
        {
            foreach (DataGridViewColumn dgc in dgw_samplelist.Columns)
            {
                dgc.SortMode = DataGridViewColumnSortMode.NotSortable;

            }
        }

        private void NumberRowHeaders()
        {
            foreach (DataGridViewRow row in dgw_samplelist.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void btn_addcolumn_Click(object sender, EventArgs e)
        {
            int lastcolnum;

            lastcolnum = Convert.ToInt32(dgw_samplelist.Columns[dgw_samplelist.Columns.Count - 1].Name);

            SampleList.Columns.Add((lastcolnum + 1).ToString(), typeof(string));
            NumberRowHeaders();
            this.IsModified = true;

        }

        private void menu_save_Click(object sender, EventArgs e)
        {
            //dgw_samplelist.CommitEdit(DataGridViewDataErrorContexts.Commit);

            if (VerifySampleIDInput() == false) return;
            if (VerifySampleNameInput() == false) return;

            DataSet dataSet = new DataSet();
            dataSet.DataSetName = "Sample_List_File";
            DataTable dt = new DataTable();
            

            //Ez azert mert maskulonben a a tabla masolasakor lemarad az utolsonak modositott cella erteke
            SampleList.AcceptChanges();

            
            dt = SampleList.Copy();
            dataSet.Tables.Add(dt);

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            DialogResult result = sd.ShowDialog();

            if (result == DialogResult.Cancel) return;
            else
            {
                // Save to disk
                if (sd.FileName.Length > 0)
                    dataSet.WriteXml(sd.FileName);
                this.IsModified = false;
            }

        }

        private bool VerifySampleIDInput()
        {
            char[] s;
            int count = 1;

            foreach (DataRow dr in SampleList.Rows)
            {
                s = dr["ID"].ToString().ToCharArray();
                if (s.Length > 1 || (s.Length > 0 && (s[0] < 'A' || s[0] > 'H')))
                {
                    MessageBox.Show("Unknown ID symbol in row " + count.ToString() + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                count++;
            }

            return true;
        }

        private bool VerifySampleNameInput()
        {
            int count = 1;

            foreach (DataRow dr in SampleList.Rows)
            {
                if (dr["ID"].ToString().Length > 0)
                {

                    foreach (DataColumn dc in SampleList.Columns)
                    {
                        if (dr[dc].ToString().Length == 0)
                        {
                            MessageBox.Show("Missing sample name in row " + count.ToString() + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
                count++;
            }

            return true;
        }

        private void dgw_samplelist_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgw_samplelist.IsCurrentCellDirty)
            {
                dgw_samplelist.CommitEdit(DataGridViewDataErrorContexts.Commit);
              
            }
        }

        private void dgw_samplelist_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.IsModified = true;
        }

        private void menu_open_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.DataSetName = "Sample_List_File";
            

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.Cancel) return;
            else
            {
                // Save to disk
                if (ofd.FileName.Length > 0)
                    dataSet.ReadXml(ofd.FileName);
            }

            SampleList = dataSet.Tables[0].Copy();
            dgw_samplelist.DataSource = SampleList;
            
            this.IsModified = false;
        }
    }
}
