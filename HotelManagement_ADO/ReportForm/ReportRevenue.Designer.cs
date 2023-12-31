﻿namespace HotelManagement_ADO.ReportForm
{
    partial class ReportRevenue
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.revenueDataSet = new HotelManagement_ADO.RevenueDataSet();
            this.revenueDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.revenueTableAdapter = new HotelManagement_ADO.RevenueDataSetTableAdapters.RevenueTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.revenueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Revenue";
            reportDataSource1.Value = this.revenueDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HotelManagement_ADO.Report.ReportMonthlyRevenue.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1067, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // revenueDataSet
            // 
            this.revenueDataSet.DataSetName = "RevenueDataSet";
            this.revenueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // revenueDataSetBindingSource
            // 
            this.revenueDataSetBindingSource.DataMember = "Revenue";
            this.revenueDataSetBindingSource.DataSource = this.revenueDataSet;
            // 
            // revenueTableAdapter
            // 
            this.revenueTableAdapter.ClearBeforeFill = true;
            // 
            // ReportRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReportRevenue";
            this.Text = "ReportRevenue";
            this.Load += new System.EventHandler(this.ReportRevenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.revenueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource revenueDataSetBindingSource;
        private RevenueDataSet revenueDataSet;
        private RevenueDataSetTableAdapters.RevenueTableAdapter revenueTableAdapter;
    }
}