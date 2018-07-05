namespace RDLC
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EtcCenter_testingDataSet = new RDLC.EtcCenter_testingDataSet();
            this.GA_DebitVehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GA_DebitVehicleTableAdapter = new RDLC.EtcCenter_testingDataSetTableAdapters.GA_DebitVehicleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EtcCenter_testingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GA_DebitVehicleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "EtcCenter_testingDataSet_GA_DebitVehicle";
            reportDataSource1.Value = this.GA_DebitVehicleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RDLC.基础使用尝试.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(39, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(682, 328);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // EtcCenter_testingDataSet
            // 
            this.EtcCenter_testingDataSet.DataSetName = "EtcCenter_testingDataSet";
            this.EtcCenter_testingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GA_DebitVehicleBindingSource
            // 
            this.GA_DebitVehicleBindingSource.DataMember = "GA_DebitVehicle";
            this.GA_DebitVehicleBindingSource.DataSource = this.EtcCenter_testingDataSet;
            // 
            // GA_DebitVehicleTableAdapter
            // 
            this.GA_DebitVehicleTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 352);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EtcCenter_testingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GA_DebitVehicleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GA_DebitVehicleBindingSource;
        private EtcCenter_testingDataSet EtcCenter_testingDataSet;
        private RDLC.EtcCenter_testingDataSetTableAdapters.GA_DebitVehicleTableAdapter GA_DebitVehicleTableAdapter;
    }
}

