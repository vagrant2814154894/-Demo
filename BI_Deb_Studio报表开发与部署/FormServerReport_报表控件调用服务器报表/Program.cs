using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FormServerReport_报表控件调用服务器报表
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            #region 灵活调用版

            string ReportPath = "";
            ReportPath = "终极报表测试";
            using (FormServerReport form = new FormServerReport())
            {
                form.SetReportName(ReportPath);
                form.AddParameter("StartTime", "2015-01-01");
                form.AddParameter("EndTime", "2016-01-01");
                form.AddParameter("StatMonth", "统计年份:2015年");
                form.AddParameter("PrintDateTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                form.AddParameter("OperatorName", "zyy打印");
                form.AddParameter("ReportType", "年");
                form.ShowDialog();
            }

            #endregion
            

        }


    }
}
