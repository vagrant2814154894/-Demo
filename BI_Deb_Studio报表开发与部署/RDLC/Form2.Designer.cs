using Microsoft.Reporting.WinForms;
namespace RDLC
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ETC_OutVehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EtcCenter_testingDataSet = new RDLC.EtcCenter_testingDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ETC_OutVehicleTableAdapter = new RDLC.EtcCenter_testingDataSetTableAdapters.ETC_OutVehicleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ETC_OutVehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EtcCenter_testingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ETC_OutVehicleBindingSource
            // 
            this.ETC_OutVehicleBindingSource.DataMember = "ETC_OutVehicle";
            this.ETC_OutVehicleBindingSource.DataSource = this.EtcCenter_testingDataSet;
            // 
            // EtcCenter_testingDataSet
            // 
            this.EtcCenter_testingDataSet.DataSetName = "EtcCenter_testingDataSet";
            this.EtcCenter_testingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "EtcCenter_testingDataSet_ETC_OutVehicle";
            reportDataSource1.Value = this.ETC_OutVehicleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RDLC.报表页眉页脚和传参.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(643, 440);
           
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ETC_OutVehicleTableAdapter
            // 
            this.ETC_OutVehicleTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 440);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ETC_OutVehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EtcCenter_testingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ETC_OutVehicleBindingSource;
        private EtcCenter_testingDataSet EtcCenter_testingDataSet;
        private RDLC.EtcCenter_testingDataSetTableAdapters.ETC_OutVehicleTableAdapter ETC_OutVehicleTableAdapter;
    }
}