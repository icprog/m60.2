using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using m60._2.Classes;

namespace m60._2.DataTables
{
    public class ChipTable
    {
          private DataTable Data = new DataTable();
          //public string ProjectRoot;

          public ChipTable()
        {
            Data.TableName = "ChipInfo";
            
            Data.Columns.Add("ChipName", typeof(string));
            Data.Columns.Add("Owner", typeof(string));
            Data.Columns.Add("ID", typeof(string));
            Data.Columns.Add("XMLFile", typeof(string));
            Data.Columns.Add("SampleListFile", typeof(string));
            Data.Columns.Add("NumSubChips", typeof(int));
            Data.Columns.Add("InvLocalHandling", typeof(string));
        }

        public void AddNewChip(ChipInfo ci)
        {
            DataRow dr = Data.NewRow();

            dr["ChipName"] = ci.chipname;
            dr["Owner"] = ci.owner;
            dr["ID"] = ci.chipid;
            dr["XMLFile"] = ci.xmlfilename;
            dr["SampleListFile"] = ci.samplelistfilename;
            dr["NumSubChips"] = ci.numsubchips;
            dr["InvLocalHandling"] = ci.invlocalhandling;

            Data.Rows.Add(dr);

        }

        public void UpdateChip(string chipname, ChipInfo ci)
        {
            
            int rowindex = FindChipIndexByName(chipname);

            Data.Rows[rowindex]["ChipName"] = ci.chipname;
            Data.Rows[rowindex]["ID"] = ci.chipid;
            Data.Rows[rowindex]["XMLFile"] = ci.xmlfilename;
            Data.Rows[rowindex]["SampleListFile"] = ci.samplelistfilename;
            Data.Rows[rowindex]["NumSubChips"] = ci.numsubchips;
            Data.Rows[rowindex]["InvLocalHandling"] = ci.invlocalhandling;

        }

        public string GetLastChipName()
        {
            return Data.Rows[Data.Rows.Count - 1]["ChipName"].ToString();
        }

        public ChipInfo GetChipInfo(string chipname)
        {
            ChipInfo ci = new ChipInfo();

            int rowindex = FindChipIndexByName(chipname);

            ci.chipname = Data.Rows[rowindex]["ChipName"].ToString();
            ci.chipid = Data.Rows[rowindex]["ID"].ToString();
            ci.xmlfilename = Data.Rows[rowindex]["XMLFile"].ToString();
            ci.samplelistfilename = Data.Rows[rowindex]["SampleListFile"].ToString();
            ci.numsubchips = Convert.ToInt32(Data.Rows[rowindex]["NumSubChips"]);
            ci.invlocalhandling = Data.Rows[rowindex]["InvLocalHandling"].ToString();

            return ci;
        }

        private int FindChipIndexByName(string chipname)
        {
            int rowindex = 0;

            /* Remove "Chip - " substring */
            chipname = chipname.Substring(7);

            foreach (DataRow dr in Data.Rows)
            {

                if (dr["ChipName"].ToString() == chipname) break;
                else rowindex++;
            }

            return rowindex;
        }

        public DataTable GetChips()
        {
            DataTable dt = new DataTable();

            dt = Data.Copy();
            return dt;
        }

        public void SetChips(DataTable dt)
        {
            Data = dt.Copy();
        }

        public string GetInvalidLocalHandling(string rn)
        {

            foreach (DataRow dr in Data.Rows)
            {
                if (dr["ChipName"].ToString() == rn) return dr["InvLocalHandling"].ToString();

            }

            return "";
        }

       
    }
}
