using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using m60._2.Classes;

namespace m60._2.DataTables
{
    public class RecTable
    {
        private DataTable Data = new DataTable();

        public RecTable()
        {
            Data.TableName = "RecordInfo";
      
            Data.Columns.Add("RecordName", typeof(string));
            Data.Columns.Add("Owner", typeof(string));
            Data.Columns.Add("AntigeneListFile", typeof(string));
            Data.Columns.Add("MeanMethod", typeof(string));
            Data.Columns.Add("InvGlobalHandling", typeof(string));

            int i;
            for (i = 1; i < 53; ++i) Data.Columns.Add("Ag" + i.ToString(), typeof(string));
        }

        public void AddNewRecord(RecInfo ri)
        {
            DataRow dr = Data.NewRow();

            dr["RecordName"] = ri.recordname;
            dr["Owner"] = ri.owner;
            dr["AntigeneListFile"] = ri.antigenelistfile;
            dr["MeanMethod"] = ri.meanmethod;
            dr["InvGlobalHandling"] = ri.invglobalhandling;

            DataSet ds = new DataSet();
            ds.ReadXml(ri.antigenelistfile);

            int i = 0;
            foreach (DataRow drs in ds.Tables[0].Rows)
            {               
                dr[5 + i] = drs["Spot Name"].ToString();
                i++;             
            }
            Data.Rows.Add(dr);

        }

        public void UpdateRecord(string recordname, RecInfo ri)
        {
            
            int rowindex = FindRecordIndexByName(recordname);

            Data.Rows[rowindex]["RecordName"] = ri.recordname;
            Data.Rows[rowindex]["AntigeneListFile"] = ri.antigenelistfile;
            Data.Rows[rowindex]["MeanMethod"] = ri.meanmethod;
            Data.Rows[rowindex]["InvGlobalHandling"] = ri.invglobalhandling;

            DataSet ds = new DataSet();
            ds.ReadXml(ri.antigenelistfile);

            int i = 0;
            foreach (DataRow drs in ds.Tables[0].Rows)
            {
                Data.Rows[rowindex][5 + i] = drs["Spot Name"].ToString();
                i++;
            }

        }

        

        public string GetLastRecordName()
        {
            return Data.Rows[Data.Rows.Count - 1]["RecordName"].ToString();
        }

        public RecInfo GetRecordInfo(string recordname)
        {
            RecInfo ri = new RecInfo();

            int rowindex = FindRecordIndexByName(recordname);

            ri.recordname = Data.Rows[rowindex]["RecordName"].ToString();
            ri.antigenelistfile = Data.Rows[rowindex]["AntigeneListFile"].ToString();
            ri.meanmethod = Data.Rows[rowindex]["MeanMethod"].ToString();
            ri.invglobalhandling = Data.Rows[rowindex]["InvGlobalHandling"].ToString();

            return ri;
        }

        private int FindRecordIndexByName(string recordname)
        {
            int rowindex = 0;

            /* Remove "Record - " substring */
            recordname = recordname.Substring(9);

            foreach (DataRow dr in Data.Rows)
            {

                if (dr["RecordName"].ToString() == recordname) break;
                else rowindex++;
            }

            return rowindex;
        }

        public DataTable GetRecords()
        {
            DataTable dt = new DataTable();

            dt = Data.Copy();
            return dt;
        }

        public void SetRecords(DataTable dt)
        {
            Data = dt.Copy();
        }

        public string GetInvalidGlobalHandling(string rn)
        {
            
            foreach (DataRow dr in Data.Rows)
            {
                if (dr["RecordName"].ToString() == rn) return dr["InvGlobalHandling"].ToString();
                
            }

            return "";
        }

        public string GetGlobalMeanMethod(string rn)
        {

            foreach (DataRow dr in Data.Rows)
            {
                if (dr["RecordName"].ToString() == rn) return dr["MeanMethod"].ToString();

            }

            return "";
        }

        public int GetAntigeneID(string rn, string ag)
        {
            int i;
            foreach (DataRow dr in Data.Rows)
            {
                if (dr["RecordName"].ToString() == rn)
                {
                    for (i = 5; i < 52 + 5; ++i)
                    {
                        if (dr[i].ToString() == ag) return i-5;
                    }                   
                } 

            }

            return -1;//error
        }
    }
}
