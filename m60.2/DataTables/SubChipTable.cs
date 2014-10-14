using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Xml;
using System.Windows.Forms;


namespace m60._2
{
    public class SubChipTable
    {
        private DataTable Data = new DataTable();
        public string ProjectRoot;
        public Form1 parent;
        private delegate void SetProgressBarDelegate (int val);
        

 
        public SubChipTable()
        {
            this.ProjectRoot = String.Empty;

            Data.TableName = "SubChipData";
            Data.Columns.Add("subchipID", typeof(string));//1...16 darab subchip ID (A1,A2,B1,B2...H2) per hozzáadott chip
            Data.Columns.Add("samplename", typeof(string));//a subchiphez tartozó sample neve
            Data.Columns.Add("chipname", typeof(string));//user által adott chipnév
            Data.Columns.Add("recordname", typeof(string));//user által adott recordnév
            

            int i;
            //for (i = 0; i < 156; ++i) Data.Columns.Add("CSMb" + i.ToString(), typeof(SpotValue));
            //for (i = 0; i < 156; ++i) Data.Columns.Add("CSMr" + i.ToString(), typeof(SpotValue));   
       
            /*Teszt*/
            for (i = 0; i < 156; ++i) Data.Columns.Add("CSMb" + i.ToString(), typeof(double));
            for (i = 0; i < 156; ++i) Data.Columns.Add("CSMr" + i.ToString(), typeof(double));

            Data.Columns.Add("Cutoffb", typeof(double)); // Számított cutoff a blue csatornán
            Data.Columns.Add("Cutoffr", typeof(double)); // Számított cutoff a red csatornán
        }

        

        //commented out
        public bool AddSubChipRows(string xmlfn, string sfn, string cn, string rn)
        {
            

            List<string> ids = new List<string>();
            List<double> spotlist = new List<double>();
            //List<SpotValue> spotlist = new List<SpotValue>();
            DataTable samplelist = new DataTable();
            DataSet dsxml = new DataSet("temp");


            double bg = new double();
            double spot = new double();
            int j = 0;

            dsxml.ReadXml(this.ProjectRoot + "\\XML\\" + xmlfn);
            ids = this.GetSubChipIDs(dsxml);
            samplelist = this.CreateSampleIDvsNameTable(sfn);

            if (this.VerifySubChipsBySampleNames(ids, samplelist) == false)
            {
                MessageBox.Show("Subchip ID and samplename mismatch.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            //parent.Invoke(new ResetStartStopDelegate(parent.StopMarqueeBar));

            parent.Invoke(new SetProgressBarDelegate(parent.SetProgressBar), dsxml.Tables[10].Rows.Count);

            foreach (DataRow dr in dsxml.Tables[10].Rows)
            {
                
                switch (dr[0].ToString())
                {

                    case "Bkg.Median":
                        bg = Convert.ToDouble(dr[2]);
                        break;
                    case "Spot.Median":
                        spot = Convert.ToDouble(dr[2]);
                        break;
                    case "Found":
                        if (Convert.ToBoolean(dr[2]) == true)
                        {
                            SpotValue sv = new SpotValue();
                            sv.value = spot - bg;
                            //sv.valid = true;
                            //spotlist.Add(sv);
                            /*Teszt*/
                            spotlist.Add(sv.value);
                        }

                        else
                        {
                            SpotValue sv = new SpotValue();
                            sv.value = spot - bg;
                            sv.value += 10;
                            //sv.valid = false;
                            //spotlist.Add(sv);
                            /*Teszt*/
                            spotlist.Add(sv.value);
                        }
                        break;
                }

                parent.Invoke(new SetProgressBarDelegate(parent.UpdateProgressBar), j);
                j++;
            }


            DataRow subchiprow = Data.NewRow();



            int i, startrange;
            //List<SpotValue> splb = new List<SpotValue>();
            //List<SpotValue> splr = new List<SpotValue>();
            /*Teszt*/
            List<double> splb = new List<double>();
            List<double> splr = new List<double>();

            parent.Invoke(new SetProgressBarDelegate(parent.SetProgressBar), ids.Count);
            startrange = 0;
            for (i = 0; i < ids.Count; ++i)
            {
                splb.Clear();
                splr.Clear();
                splb.AddRange(spotlist.GetRange(startrange, 156));
                splr.AddRange(spotlist.GetRange(startrange + 156, 156));
                this.CreateDataRow(ids[i], cn, rn, samplelist.Rows[i]["Name"].ToString(), splb, splr);
                startrange += 156 + 156;
                parent.Invoke(new SetProgressBarDelegate(parent.UpdateProgressBar), i);
            }

            parent.Invoke(new SetProgressBarDelegate(parent.UpdateProgressBar), 0);

            return true;
        }

        public bool AddSubChipRows2(string xmlfn, string sfn, string cn, string rn)
        {


            List<string> ids = new List<string>();

            List<double> spotmedian = new List<double>();
            List<double> bgmedian = new List<double>();
            List<double> csm = new List<double>();
            List<bool> found = new List<bool>();

            //List<SpotValue> spotlist = new List<SpotValue>();
            DataTable samplelist = new DataTable();
            DataSet dsxml = new DataSet("temp");

            

            dsxml.ReadXml(xmlfn);
            ids = this.GetSubChipIDs(dsxml);
            samplelist = this.CreateSampleIDvsNameTable(sfn);

            if (this.VerifySubChipsBySampleNames(ids, samplelist) == false)
            {
                MessageBox.Show("Subchip ID and samplename mismatch.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            

            parent.Invoke(new SetProgressBarDelegate(parent.SetProgressBar), dsxml.Tables[10].Rows.Count);

            int j = 0;
            double bg = 0;
            double spot = 0;
            bgmedian.Clear();
            spotmedian.Clear();
            found.Clear();
            csm.Clear();

            foreach (DataRow dr in dsxml.Tables[10].Rows)
            {

                switch (dr[0].ToString())
                {

                    case "Bkg.Median":
                        bg = Convert.ToDouble(dr[2]);
                        bgmedian.Add(Convert.ToDouble(dr[2]));                           
                        break;
                    case "Spot.Median":
                        spot = Convert.ToDouble(dr[2]);
                        spotmedian.Add(Convert.ToDouble(dr[2]));
                        break;
                    case "Found":
                        if (Convert.ToBoolean(dr[2]) == true) found.Add(true);
                        else found.Add(false);
                        break;
                }

                csm.Add(spot - bg);

                parent.Invoke(new SetProgressBarDelegate(parent.UpdateProgressBar), j);
                j++;
            }

            int i, startrange;
            double cutoffb, cutoffr;
            List<double> splb = new List<double>();
            List<double> splr = new List<double>();

            List<double> bgmedb = new List<double>();
            List<double> bgmedr = new List<double>();

            parent.Invoke(new SetProgressBarDelegate(parent.SetProgressBar), ids.Count);
            startrange = 0;
            for (i = 0; i < ids.Count; ++i)
            {
                splb.Clear();
                splr.Clear();
                bgmedb.Clear();
                bgmedr.Clear();

                splb.AddRange(csm.GetRange(startrange, 156));
                splr.AddRange(csm.GetRange(startrange + 156, 156));

                bgmedb.AddRange(bgmedian.GetRange(startrange, 156));
                bgmedr.AddRange(bgmedian.GetRange(startrange + 156, 156));



                cutoffb = this.CalculateCutOff(ref bgmedb);
                cutoffr = this.CalculateCutOff(ref bgmedr);



                startrange += 156 + 156;
                parent.Invoke(new SetProgressBarDelegate(parent.UpdateProgressBar), i);
            }


            //DataRow subchiprow = Data.NewRow();
            //int i, startrange;
            ////List<SpotValue> splb = new List<SpotValue>();
            ////List<SpotValue> splr = new List<SpotValue>();
            ///*Teszt*/
            //List<double> splb = new List<double>();
            //List<double> splr = new List<double>();

            //parent.Invoke(new SetProgressBarDelegate(parent.SetProgressBar), ids.Count);
            //startrange = 0;
            //for (i = 0; i < ids.Count; ++i)
            //{
            //    splb.Clear();
            //    splr.Clear();
            //    splb.AddRange(spotlist.GetRange(startrange, 156));
            //    splr.AddRange(spotlist.GetRange(startrange + 156, 156));
            //    this.CreateDataRow(ids[i], cn, rn, samplelist.Rows[i]["Name"].ToString(), splb, splr);
            //    startrange += 156 + 156;
            //    parent.Invoke(new SetProgressBarDelegate(parent.UpdateProgressBar), i);
            //}

            parent.Invoke(new SetProgressBarDelegate(parent.UpdateProgressBar), 0);

            return true;
        }

        private List<string> GetSubChipIDs(DataSet ds)
        {
            List<string> retlist = new List<string>();

            foreach (DataRow dr in ds.Tables["AssayResult"].Rows)
                retlist.Add(dr["ID"].ToString());


            return retlist;
        }

       


        private DataTable CreateSampleIDvsNameTable(string sfn)
        {
            //List<string> retlist = new List<string>(); 
            DataSet dss = new DataSet("temp");
            DataTable dt = new DataTable();
            dss.ReadXml(this.ProjectRoot + "\\Info\\" + sfn);

            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.TableName = "Data";

            int i = 0;
            foreach (DataRow dr in dss.Tables[0].Rows)
            {


                for (i = 1; i < dss.Tables[0].Columns.Count; ++i)
                {

                    DataRow dtr = dt.NewRow();
                    dtr["ID"] = dr["ID"].ToString() + i.ToString();
                    dtr["Name"] = dr[i].ToString();

                    dt.Rows.Add(dtr);
                }

            }

            return dt;
        }

        public bool VerifySubChipsBySampleNames(List<string> ids, DataTable samplenametable)
        {

           

            string a, b;
            a = "";
            b = "";
            foreach (DataRow dr in samplenametable.Rows) a += dr["ID"].ToString();
            foreach (string s in ids) b += s;

            //check if subchip IDs from chip xml are matching with the samples listed in
            //sample list file
            if (a == b) return true;
            
            else return false;
        }





        //private DataRow CreateDataRow(string id, string cn, string rn, string sn, List<SpotValue> splb, List<SpotValue> splr)
        /*Teszt*/
        private DataRow CreateDataRow(string id, string cn, string rn, string sn, List<double> splb, List<double> splr)
        {
            DataRow dr = Data.NewRow();
            int i;

            dr["subchipID"] = id;
            dr["chipname"] = cn;
            dr["recordname"] = rn;
            dr["samplename"] = sn;

            for (i = 0; i < 156; ++i) dr[dr.Table.Columns["CSMb0"].Ordinal + i] = splb[i];
            for (i = 0; i < 156; ++i) dr[dr.Table.Columns["CSMr0"].Ordinal + i] = splr[i];
           
            Data.Rows.Add(dr);

            return dr;
        }


        public DataTable GetSubChips()
        {
            DataTable dt = new DataTable();

            dt = Data.Copy();
            return dt;
        }

        public void SetSubChips(DataTable dt)
        {
            Data = dt.Copy();
        }

        public List<mSpotValue> CalculatemCSM(DataRow dr, string mm, string invh)
        {
            List<mSpotValue> retlist = new List<mSpotValue>();
            int i, j, k;
            double m1, m2, m3;
            
            //DataRow dr;

            //dr = Data.Rows[ID];            
            if (mm == "UK") k = 13;
            else k = 1;

            
            j = 0;
            for (i = 0; i < 52; ++i)
            {
                mSpotValue msv = new mSpotValue();

                //Blue channel
                m1 = Convert.ToDouble(dr[dr.Table.Columns["CSMb0"].Ordinal + j + 0 * k]);
                m2 = Convert.ToDouble(dr[dr.Table.Columns["CSMb0"].Ordinal + j + 1 * k]);
                m3 = Convert.ToDouble(dr[dr.Table.Columns["CSMb0"].Ordinal + j + 2 * k]);

                msv.bvalid = true;
                msv.bspotsused = 3;
                double mean = 0;
                int divisor = 0;

                if (m1 > 2)
                {
                    m1 = m1 - 10f;
                    msv.bspotsused--;
                    msv.bvalid = false;
                }
                else
                {
                    mean += m1;
                    divisor++;
                }

                if (m2 > 2)
                {
                    m2 = m2 - 10f;
                    msv.bspotsused--;
                    msv.bvalid = false;
                }
                else
                {
                    mean += m2;
                    divisor++;
                }

                if (m3 > 2)
                {
                    m3 = m3 - 10f;
                    msv.bspotsused--;
                    msv.bvalid = false;
                }
                else
                {
                    mean += m3;
                    divisor++;
                }

                //if (invh == "Yes") msv.bvalid = true;

                msv.bvalue = (m1 + m2 + m3) / 3;

                //Red channel

                m1 = Convert.ToDouble(dr[dr.Table.Columns["CSMr0"].Ordinal + j + 0 * k]);
                m2 = Convert.ToDouble(dr[dr.Table.Columns["CSMr0"].Ordinal + j + 1 * k]);
                m3 = Convert.ToDouble(dr[dr.Table.Columns["CSMr0"].Ordinal + j + 2 * k]);

                msv.rvalid = true;

                if (m1 > 2)
                {
                    m1 = m1 - 10f;
                    msv.rvalid = false;
                }
                if (m2 > 2)
                {
                    m2 = m2 - 10f;
                    msv.rvalid = false;
                }
                if (m3 > 2)
                {
                    m3 = m3 - 10f;
                    msv.rvalid = false;
                }

                //if (invh == "Yes") msv.rvalid = true;

                msv.rvalue = (m1 + m2 + m3) / 3;

                //add samplename and subchipID
                msv.samplename = dr["samplename"].ToString();
                msv.subchipID = dr["subchipID"].ToString();
                //add to list
                retlist.Add(msv);

                //next loop
                if (mm == "UK") j +=1;
                else j +=3;
            }

            
            return retlist;
        }

        public DataTable GetSubChipsmCSM(string rn, string cn, string mm, string invh)
        {
            DataTable dt = new DataTable();
            int i;
            for (i = 0; i < 52; ++i) dt.Columns.Add("mCSM" + i.ToString(), typeof(mSpotValue));
            //for (i = 0; i < 156; ++i) dt.Columns.Add("mCSMr" + i.ToString(), typeof(double));

            foreach (DataRow dr in Data.Rows)
            {
                if (dr["recordname"].ToString() == rn && dr["chipname"].ToString() == cn)
                {
                    dt.Rows.Add(CalculatemCSM(dr, mm, invh).ToArray<mSpotValue>());
                }
            }

            return dt;
        }

        public int GetSubChipID(string rn, string cn, string sn)
        {
            int i = 0;
            foreach (DataRow dr in Data.Rows)
            {
                if (dr["recordname"].ToString() == rn && dr["chipname"].ToString() == cn && dr["samplename"].ToString() == sn)
                    return i;

                i++;
            }

            return -1;
        }

        public double CalculateCutOff(ref List<double> bgmedian)
        {
            return GetMedian(ref bgmedian) + 2 * CalculateSD(ref bgmedian); 

        }

        public double GetMedian(ref List<double> array)
        {
            int q;
            
            quicksort(ref array, 0, array.Count - 1);

            q = (array.Count / 2);

            if ((array.Count & 0x01) == 0) return ((array[q] + array[q + 1]) / 2);
            else return array[q + 1];           
        }

        private double CalculateSD(ref List<double> array)
        {
            double N = (double) array.Count;

            double med = GetMedian(ref array);

            double buf = 0;

            foreach (double data in array)         
                buf = buf + Math.Pow((data - med), 2);

            return Math.Sqrt (buf / N);
                        
        }

        #region QuickSort

        private int quicksort(ref List<double> array, int p, int r)
        {
            int pivot_loc = 0;

            if (p < r)
            {
                pivot_loc = partition(ref array, p, r, 0, false);
                quicksort(ref array, p, pivot_loc - 1);
                quicksort(ref array, pivot_loc + 1, r);
            }

            return pivot_loc;
        }

        private int partition(ref List<double> array, int p, int r, int piv, bool rand)
        {
            double pivot;
            int  i, j;
            if (rand == false)
            {
                pivot = array[r];
                piv = r;
            }
            else pivot = array[piv];

            i = p - 1;
            for (j = p; j < r; ++j)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    swap(ref array, i, j);
                }

            }
            swap(ref array, i + 1, piv);
            return i + 1;
        }

        private void swap(ref List<double> array, int indexA, int indexB)
        {
            
            
            double tmp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = tmp;
            
           
        }
        #endregion


    }
}
