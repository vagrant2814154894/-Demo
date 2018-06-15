using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Net;


namespace FormServerReport_报表控件调用服务器报表
{
    public partial class Form1 : Form
    {
        static Uri ServerUrl { get; set; }
        static NetworkCredential NetworkCredential { get; set; }
        public string ReportPath { get; set; }
        public List<ReportParameter> ReportParameters { get; private set; }

        public Form1()
        {
            InitializeComponent();
            ReportParameters = new List<ReportParameter>();

            //Init();
        }

        public void AddParameter(string name, DateTime value)
        {
            ReportParameters.Add(new ReportParameter(name, value.ToString("yyyy-MM-dd HH:mm:ss")));
        }

        public void AddParameter(string name, string value)
        {
            ReportParameters.Add(new ReportParameter(name, value));
        }

        public void SetReportName(string name)
        {
            ReportPath = "/EtcCenterReports/" + name;
        }

        //public static void Init()
        //{
        //    COMMON.CommonClass common = COMMON.CommonClass.GetInstance();
        //    if (ServerUrl == null)
        //    {
        //        ServerUrl = new Uri(EtcSysParamData.GetParam("N_ReportServer"));
        //    }
        //    if (NetworkCredential == null)
        //    {
        //        NetworkCredential = new NetworkCredential("EtcReporter", "etcsupercomputer");
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            //COMMON.CommonClass common = COMMON.CommonClass.GetInstance();
            //ServerReport report = this.reportViewer1.ServerReport;

            //report.ReportServerUrl = ServerUrl;
            //report.ReportPath = ReportPath;
            //report.ReportServerCredentials.NetworkCredentials = NetworkCredential;


            ServerReport report = this.reportViewer1.ServerReport;
            NetworkCredential = new NetworkCredential("EtcReporter", "etcsupercomputer");
            report.ReportServerUrl = ServerUrl;
            report.ReportPath = ReportPath;
            report.ReportServerCredentials.NetworkCredentials = NetworkCredential;
            if (ReportParameters.Count > 0)
            {
                report.SetParameters(ReportParameters);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
