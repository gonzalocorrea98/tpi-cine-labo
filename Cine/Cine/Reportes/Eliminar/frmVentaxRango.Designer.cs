namespace Cine.Reportes
{
    partial class frmVentaxRango
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
            this.dsCine = new Cine.Reportes.dsCine();
            this.dtVentasxRangoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtVentasxRangoTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtVentasxRangoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentasxRangoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsVentasxRango";
            reportDataSource1.Value = this.dtVentasxRangoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptVentasxRango.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(103, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(566, 347);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsCine
            // 
            this.dsCine.DataSetName = "dsCine";
            this.dsCine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtVentasxRangoBindingSource
            // 
            this.dtVentasxRangoBindingSource.DataMember = "dtVentasxRango";
            this.dtVentasxRangoBindingSource.DataSource = this.dsCine;
            // 
            // dtVentasxRangoTableAdapter
            // 
            this.dtVentasxRangoTableAdapter.ClearBeforeFill = true;
            // 
            // frmVentaxRango
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmVentaxRango";
            this.Text = "frmVentaxRango";
            this.Load += new System.EventHandler(this.frmVentaxRango_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentasxRangoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsCine dsCine;
        private System.Windows.Forms.BindingSource dtVentasxRangoBindingSource;
        private dsCineTableAdapters.dtVentasxRangoTableAdapter dtVentasxRangoTableAdapter;
    }
}