using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using m60._2.Classes;
using m60._2.DataTables;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms.DataVisualization.Charting;
using m60._2.Forms;

namespace m60._2
{
    public partial class Form1 : Form
    {

        ProjectTable Project = new ProjectTable();
        RecTable Records = new RecTable();
        ChipTable Chips = new ChipTable();
        SubChipTable SubChips = new SubChipTable();
        private TreeNode LastRightClickedNode = new TreeNode();

        enum MessageColor
        {
            Normal,
            Warning,
            Error
        };

        public Form1()
        {
            InitializeComponent();

            
        }

        private void tv_tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                
                LastRightClickedNode = tv_tree.GetNodeAt(e.X, e.Y);
                
            }
        }

        public void StartMarqueeBar()
        {
            pb_xmlreader.Style = ProgressBarStyle.Marquee;
            pb_xmlreader.MarqueeAnimationSpeed = 100;
        }

        public void StopMarqueeBar()
        {
            pb_xmlreader.Style = ProgressBarStyle.Marquee;
            pb_xmlreader.Value = 0;
            pb_xmlreader.MarqueeAnimationSpeed = 0;
        }

        public void SetProgressBar(int max)
        {
            pb_xmlreader.Style = ProgressBarStyle.Continuous;
            pb_xmlreader.Minimum = 0;
            pb_xmlreader.Maximum = max;
        }

        public void ResetProgressBar()
        {
            pb_xmlreader.Style = ProgressBarStyle.Continuous;
            pb_xmlreader.Value = 0;
        }

        public void UpdateProgressBar(int val)
        {
            pb_xmlreader.Value = val;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SubChips.parent = this;
            
        }

        private void menu_basiconeanalysis_Click(object sender, EventArgs e)
        {
            FormBasicOneChipSettings frm_BasicOne = new FormBasicOneChipSettings(/*esetleges Form1-ből jövő paraméterek*/);
            frm_BasicOne.BasicOneChipUpdated += new FormBasicOneChipSettings.BasicOneChipUpdateHandler(frm_BasicOne_BasicOneUpdated);
            frm_BasicOne.records = Records.GetRecords();
            frm_BasicOne.chips = Chips.GetChips();
            frm_BasicOne.subchips = SubChips.GetSubChips();
            frm_BasicOne.ShowDialog();



            ////tbp_plotparam.Controls.AddRange(AddBasicOneChipAnalysisControls(Chips.GetChips(), SubChips.GetSubChips(), Records.GetRecords()));
            //Chart plot = new Chart();
            //int[] x = { 1, 2, 3 };
            //int[] y = { 4, 5, 6 };

            //plot.Dock = DockStyle.Fill;
            //tbp_plot.Controls.Add(plot);

            //Series SeriesB = new Series();
            //Series SeriesR = new Series();
            //plot.Series.Add(SeriesB);
            //plot.Series.Add(SeriesR);


            //ChartArea blue = new ChartArea("ChartBlue");
            //ChartArea red = new ChartArea("ChartRed");

            //plot.ChartAreas.Add(blue);
            //plot.ChartAreas.Add(red);

            //SeriesB.ChartArea = "ChartBlue";
            //SeriesR.ChartArea = "ChartRed";
            //SeriesB.ChartType = SeriesChartType.Column;
            //SeriesR.ChartType = SeriesChartType.Column;

            //Random r = new Random();

            //for (int i = 0; i < 16; i++)
            //{
            //    // Add series.
            //    //Series series = this.chart1.Series.Add(seriesArray[i]);

            //    // Add point.

                

            //    int k = r.Next(1,10);
            //    double f = 1.00/(double) k;
            //    SeriesB.Points.Add(f);
            //    k = r.Next(1,10);
            //    f = 1.00/(double) k;
            //    SeriesR.Points.Add(f);
            //}
          
        }

        private void frm_BasicOne_BasicOneUpdated(object sender, BasicOneChipEventArgs e)
        {

           //List<mSpotValue> msv = new List<mSpotValue>();

            DataTable dt = new DataTable();

            string mm; //Records.GetInvalidGlobalHandling(e.RecName);

            if (Chips.GetInvalidLocalHandling(e.ChipName) == "No" || Records.GetInvalidGlobalHandling(e.RecName) == "No")
                mm = "No";
            else mm = "Yes";


            dt = SubChips.GetSubChipsmCSM(e.RecName, e.ChipName, Records.GetGlobalMeanMethod(e.RecName), mm);
            //msv = SubChips.CalculatemCSM(SubChips.GetSubChipID(e.RecName, e.ChipName, e.Ag), 
            //                                Records.GetGlobalMeanMethod(e.RecName), 
            //                                mm);
            tbp_plot.Controls.Clear();

            Chart plot = new Chart();
          
            plot.Dock = DockStyle.Fill;
            tbp_plot.Controls.Add(plot);

            Series SeriesB = new Series();
            Series SeriesR = new Series();
            plot.Series.Add(SeriesB);
            plot.Series.Add(SeriesR);

            //SeriesB.ToolTip = "Value: #VALY\r\nSample: #LABEL";
            //SeriesR.ToolTip = "Value: #VALY\r\nSample: #LABEL";
            ChartArea blue = new ChartArea("ChartBlue");
            ChartArea red = new ChartArea("ChartRed");

            blue.AxisX.Title = "samples";
            red.AxisX.Title = "samples";

            plot.ChartAreas.Add(blue);
            plot.ChartAreas.Add(red);

            SeriesB.ChartArea = "ChartBlue";
            SeriesR.ChartArea = "ChartRed";
            SeriesB.ChartType = SeriesChartType.Column;
            SeriesR.ChartType = SeriesChartType.Column;
            

            int i;
            int agid, agnormid;
            

            agid = Records.GetAntigeneID(e.RecName, e.Ag);
           
            foreach (DataRow dr in dt.Rows)
            {
                mSpotValue msvag = (mSpotValue)dr[agid];
                
                double agnormb, agnormr;
                if (e.AgNorm == "---") 
                {

                    string tooltip;
                    DataPoint b = new DataPoint();
                    DataPoint r = new DataPoint();
                    b.SetValueY(msvag.bvalue * 0xFFFF);
                    b.AxisLabel = msvag.subchipID;
                    tooltip = "Value: #VALY\r\nSample: " + msvag.samplename + "\r\nSpots used: ";
                    if (msvag.bvalid == false) b.Color = Color.LightBlue;
                    else b.Color = Color.Blue;
                    tooltip += msvag.bspotsused.ToString();
                    b.ToolTip = tooltip;
                    blue.AxisY.Title = e.Ag;
                    blue.AxisX.Interval = 1;
                    

                    r.SetValueY(msvag.rvalue * 0xFFFF);
                    r.AxisLabel = msvag.subchipID;
                    tooltip = "Value: #VALY\r\nSample: " + msvag.samplename + "\r\nSpots used: ";
                    if (msvag.bvalid == false) r.Color = Color.LightCoral;
                    else r.Color = Color.Red;
                    tooltip += msvag.bspotsused.ToString();

                    r.ToolTip = tooltip;
                    
                    red.AxisY.Title = e.Ag;
                    red.AxisX.Interval = 1;
                    
                    SeriesB.Points.Add(b);
                    SeriesR.Points.Add(r);
                }
                else 
                {
                    agnormid = Records.GetAntigeneID(e.RecName, e.AgNorm);
                    mSpotValue msvagnorm = (mSpotValue)dr[agnormid];
                    agnormb = msvagnorm.bvalue;
                    agnormr = msvagnorm.rvalue;

                    SeriesB.Points.Add(msvag.bvalue / agnormb);
                    blue.AxisY.Title = e.Ag + " / " + e.AgNorm;
                    SeriesR.Points.Add(msvag.rvalue / agnormr);
                    red.AxisY.Title = e.Ag + " / " + e.AgNorm;
                }

                
            }

         
                //int k = r.Next(1, 10);
                //double f = 1.00 / (double)k;
                //SeriesB.Points.Add(f);
                //k = r.Next(1, 10);
                //f = 1.00 / (double)k;
                //SeriesR.Points.Add(f);
            }

    }
}
