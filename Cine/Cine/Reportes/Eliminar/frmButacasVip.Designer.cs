namespace Cine.Reportes
{
    partial class frmButacasVip
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
            this.dsButacasVipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCine = new Cine.Reportes.dsCine();
            this.dsButacasVipTableAdapter = new Cine.Reportes.dsCineTableAdapters.dsButacasVipTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dsButacasVipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).BeginInit();
            this.SuspendLayout();
            // 
            // dsButacasVipBindingSource
            // 
            this.dsButacasVipBindingSource.DataMember = "dsButacasVip";
            this.dsButacasVipBindingSource.DataSource = this.dsCine;
            // 
            // dsCine
            // 
            this.dsCine.DataSetName = "dsCine";
            this.dsCine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsButacasVipTableAdapter
            // 
            this.dsButacasVipTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsButacasVip";
            reportDataSource1.Value = this.dsButacasVipBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptButacasVip.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(111, 27);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(863, 477);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmButacasVip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmButacasVip";
            this.Text = "frmButacasVip";
            this.Load += new System.EventHandler(this.frmButacasVip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsButacasVipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private dsCine dsCine;
        private System.Windows.Forms.BindingSource dsButacasVipBindingSource;
        private dsCineTableAdapters.dsButacasVipTableAdapter dsButacasVipTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}