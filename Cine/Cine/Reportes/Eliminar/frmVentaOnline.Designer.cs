namespace Cine.Reportes
{
    partial class frmVentaOnline
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
            this.dtVentaOnlineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCine = new Cine.Reportes.dsCine();
            this.dtVentaOnlineTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtVentaOnlineTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtVentaOnlineBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtVentaOnlineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentaOnlineBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtVentaOnlineBindingSource
            // 
            this.dtVentaOnlineBindingSource.DataMember = "dtVentaOnline";
            this.dtVentaOnlineBindingSource.DataSource = this.dsCine;
            // 
            // dsCine
            // 
            this.dsCine.DataSetName = "dsCine";
            this.dsCine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtVentaOnlineTableAdapter
            // 
            this.dtVentaOnlineTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsVentaOnline";
            reportDataSource1.Value = this.dtVentaOnlineBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptVentaOnline.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(108, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(550, 344);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtVentaOnlineBindingSource1
            // 
            this.dtVentaOnlineBindingSource1.DataMember = "dtVentaOnline";
            this.dtVentaOnlineBindingSource1.DataSource = this.dsCine;
            // 
            // frmVentaOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmVentaOnline";
            this.Text = "frmVentaOnline";
            this.Load += new System.EventHandler(this.frmVentaOnline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtVentaOnlineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentaOnlineBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private dsCine dsCine;
        private System.Windows.Forms.BindingSource dtVentaOnlineBindingSource;
        private dsCineTableAdapters.dtVentaOnlineTableAdapter dtVentaOnlineTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtVentaOnlineBindingSource1;
    }
}