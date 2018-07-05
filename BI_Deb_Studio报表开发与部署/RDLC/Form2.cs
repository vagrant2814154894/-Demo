using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace RDLC
{
    //进度备注:传参调用失败，传参调用和多表、存储过程的使用等以后真的要用到的时候再研究。
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“EtcCenter_testingDataSet.ETC_OutVehicle”中。您可以根据需要移动或移除它。
           
            this.ETC_OutVehicleTableAdapter.Fill(this.EtcCenter_testingDataSet.ETC_OutVehicle);
            this.reportViewer1.LocalReport.ReportPath = "报表页眉页脚和传参.rdlc";
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
         
          
        }
    }
}
