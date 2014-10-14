using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace m60._2.Classes
{
    public class ProjectTable
    {
        //uj verzio
        private DataTable Data = new DataTable();

        //regi verzio mezoi
        //public string ProjectPath;      
        public string ProjectName;
        public string ProjectOwner;
        public string ProjectComments;
        public DateTime ProjectDate;     
        public bool IsModified;

        public ProjectTable()
        {
            Data.TableName = "ProjectInfo";

            Data.Columns.Add("ProjectName", typeof(string));
            //Data.Columns.Add("ProjectPath", typeof(string));
            Data.Columns.Add("ProjectOwner", typeof(string));
            Data.Columns.Add("ProjectComments", typeof(string));
            Data.Columns.Add("ProjectDate", typeof(DateTime));
            Data.Columns.Add("Modified", typeof(bool));
            this.IsModified = false;
        }

        public void AddNewProject(ProjInfo pi)
        {
            DataRow dr = Data.NewRow();

            dr["ProjectName"] = pi.projectname;
            //dr["ProjectPath"] = pi.projectpath;
            dr["ProjectOwner"] = pi.projectowner;
            dr["ProjectComments"] = pi.projectcomments;
            dr["ProjectDate"] = pi.projectdate;
            dr["Modified"] = pi.modified;

            Data.Rows.Add(dr);

        }

        public DataTable GetProjects()
        {
            DataTable dt = new DataTable();

            dt = Data.Copy();
            return dt;
        }

        public void SetProjects(DataTable dt)
        {
            Data = dt.Copy();           
        }

        //public string GetProjectPath()
        //{
        //    return Data.Rows[0]["ProjectPath"].ToString();
        //}

        public string GetProjectName()
        {
            return Data.Rows[0]["ProjectName"].ToString();
        }

        //public void UpdateProjectPath(string p)
        //{
        //    Data.Rows[0]["ProjectPath"] = p;
        //}

        public void UpdateProjectName(string p)
        {
            Data.Rows[0]["ProjectName"] = p;
        }

        

    }
}
