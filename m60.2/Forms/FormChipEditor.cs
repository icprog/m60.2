using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using m60._2;

namespace m60._2.Forms
{
    public partial class FormChipEditor : Form
    {
        private int NumCol;
        private int NumSpots;

        private int NumMeanSpots;
        private string MeanMethod;

        private string ProjPath;
        private bool IsModified;
        static Random r = new Random();
        Color oldcol = new Color();

        DataTable dt_list = new DataTable();
        DataTable dt_spots = new DataTable();

        public FormChipEditor()
        {
            InitializeComponent();
        }

        public FormChipEditor(string projpath)
        {
            //this.ProjPath = projpath;
            this.IsModified = false;
            InitializeComponent();
        }

        private void menu_newagfile_Click(object sender, EventArgs e)
        {
            FormChipEditorSettings frm_chipeditorsettings = new FormChipEditorSettings();
            frm_chipeditorsettings.NewChipSettingsUpdated += new FormChipEditorSettings.NewChipSettingsUpdateHandler(frm_chipeditorsettings_Updated);
            frm_chipeditorsettings.ShowDialog();
        }

        private void frm_chipeditorsettings_Updated(object sender, NewChipSettingsUpdateEventArgs e)
        {
            

            NumCol = e.NumCol;
            NumSpots = e.NumSpots;
            NumMeanSpots = e.NumMeanSpots;
            MeanMethod = e.MeanMethod;
            

            dt_spots = CreateEmptyChipTable(NumCol, NumSpots);
            dgw_spots.DataSource = dt_spots;

            dt_list = CreateEmptyChipList(NumSpots / NumMeanSpots);
            dgw_spotlist.DataSource = dt_list;

            foreach (DataGridViewColumn dgc in dgw_spots.Columns)
            {
                dgc.SortMode = DataGridViewColumnSortMode.NotSortable;

            }

            foreach (DataGridViewRow row in dgw_spots.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }

            foreach (DataGridViewColumn dgc in dgw_spotlist.Columns)
            {
                dgc.SortMode = DataGridViewColumnSortMode.NotSortable;

            }

            this.IsModified = true;

        }

        private DataTable CreateEmptyChipTable(int cols, int spots)
        {
            DataTable dt = new DataTable();
            int i = 0, j = 0;

            for (i = 0; i < cols; ++i) dt.Columns.Add((i+1).ToString(), typeof(string));

            int numrow = spots / cols;

            for (i = 0; i < numrow; ++i)
            {
                DataRow dr = dt.NewRow();
                for (j = 0; j < cols; ++j) dr[j] = "---";
                dt.Rows.Add(dr);
            }


            return dt;
        }

        private DataTable CreateEmptyChipList(int rows)
        {
            DataTable dt = new DataTable();
            int i;

            dt.Columns.Add("Spot Position", typeof(string));
            dt.Columns.Add("Spot Name", typeof(string));
            dt.Columns.Add("Spot ID", typeof(string));

            for (i = 0; i < rows; ++i)
            {
                DataRow dr = dt.NewRow();
                /* (i+1) kerül a stringbe mert az első spot indexe 1 és nem nulla*/
                dr["Spot Position"] = (i+1).ToString();

                dt.Rows.Add(dr);
            }


            return dt;
        }

        private void dgw_spotlist_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int spotpos = 0;
            string name;

            if (e.ColumnIndex == 1)
            {
                spotpos = Convert.ToInt32(dgw_spotlist.Rows[e.RowIndex].Cells["Spot Position"].Value);
                name = dgw_spotlist.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                UpdateChipTable(spotpos, name);
                this.IsModified = true;
               
            }
            
        }

        private void UpdateChipTable(int spotpos, string name)
        {
            int colindex = 0;
            int rowindex = 0;
            int i = 0;
            Color gencol = new Color();

            gencol = GetRandomColor();
            while (gencol == oldcol)
            {
                gencol = GetRandomColor();
            }
            oldcol = gencol;

            switch (MeanMethod)
            {

                case "UK":

                    rowindex = (int)(((double)spotpos / NumCol) - 1E-3) * NumMeanSpots;
                    colindex = (spotpos - 1) % NumCol;
                    
                    for (i = 0; i < NumMeanSpots; ++i)
                    {
                        dgw_spots.Rows[rowindex + i].Cells[colindex].Style.BackColor = gencol;
                        dgw_spots.Rows[rowindex+i].Cells[colindex].Value = name;
                    }                  
                    break;

                case "DE":
                    rowindex = (int)(((double)spotpos / (NumCol / NumMeanSpots)) - 1E-3);
                    colindex = ((spotpos - 1) % (NumCol / NumMeanSpots)) * NumMeanSpots;

                    for (i = 0; i < NumMeanSpots; ++i)
                    {
                        dgw_spots.Rows[rowindex].Cells[colindex + i].Style.BackColor = gencol;
                        dgw_spots.Rows[rowindex].Cells[colindex + i].Value = name;
                    }
                    break;
            }
        }

        private void menu_saveagfile_Click(object sender, EventArgs e)
        {
            
            //foreach (DataRow dr in dt_list.Rows)
            //{
            //    if (dr["Spot Name"].ToString().Length == 0)
            //    {
            //        MessageBox.Show(("Empty Name field at Spot Position " + dr["Spot Position"].ToString() + "."), "Missing fields", MessageBoxButtons.OK);
            //        return;
            //    }
            //}

            DataSet dataSet = new DataSet();
            dataSet.DataSetName = "Antigene List File";
            DataTable dt = new DataTable();
            dt.TableName = "Antigene List";

            dt = dt_list.Copy();
            dataSet.Tables.Add(dt);

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            DialogResult result = sd.ShowDialog();
                
            if (result == DialogResult.Cancel) return;
            else {
            // Save to disk
            if(sd.FileName.Length>0) 
                dataSet.WriteXml(sd.FileName);
                this.IsModified = false;
            }
        
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.IsModified == false) this.Close();
            else
            {
                DialogResult result = MessageBox.Show("Exit without saving?", "Warning", MessageBoxButtons.YesNo);

                if (result == DialogResult.No) return;
                else this.Close();
            }
            
        }

        private void menu_openagfile_Click(object sender, EventArgs e)
        {
            FormChipEditorSettings frm_chipeditorsettings = new FormChipEditorSettings();
            frm_chipeditorsettings.NewChipSettingsUpdated += new FormChipEditorSettings.NewChipSettingsUpdateHandler(frm_chipeditorsettings_Updated);

            if (frm_chipeditorsettings.ShowDialog() == DialogResult.OK)
            {

                DataSet dataSet = new DataSet();
                dataSet.DataSetName = "Antigene List File";

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                DialogResult result = ofd.ShowDialog();

                if (result == DialogResult.Cancel) return;
                else
                {
                    // Save to disk (ez vajon mi)
                    if (ofd.FileName.Length > 0)
                        dataSet.ReadXml(ofd.FileName);
                }

                dt_list = dataSet.Tables[0].Copy();
                dgw_spotlist.DataSource = dt_list;
                foreach (DataRow dr in dt_list.Rows)
                {
                    UpdateChipTable(Convert.ToInt32(dr["Spot Position"]), dr["Spot Name"].ToString());
                }
                this.IsModified = false;
            }
        }

        private Color GetRandomColor()
        {
            int b;
            Color col = new Color();
            

            b = r.Next(1, 10);

            switch (b)
            {
                case 1: col = Color.LightSteelBlue; break;
                case 2: col = Color.LightSkyBlue; break;
                case 3: col = Color.PaleGreen; break;
                case 4: col = Color.DarkGray; break;
                case 5: col = Color.SkyBlue; break;
                case 6: col = Color.Gainsboro; break;
                case 7: col = Color.DarkKhaki; break;
                case 8: col = Color.PaleGoldenrod; break;
                case 9: col = Color.SeaShell; break;
                case 10: col = Color.Aquamarine; break;
                default: col = Color.White; break;

            }

            return col;
        }
    }
}
