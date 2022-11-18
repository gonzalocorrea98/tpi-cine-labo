namespace Cine.Reportes
{
    partial class frmTop5Agosto
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
            this.dtTo5VendidasAgostoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtTo5VendidasAgostoTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtTo5VendidasAgostoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo5VendidasAgostoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsTop5VendidasAgosto";
            reportDataSource1.Value = this.dtTo5VendidasAgostoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptTop5VendidasAgosto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(52, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(545, 371);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsCine
            // 
            this.dsCine.DataSetName = "dsCine";
            this.dsCine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtTo5VendidasAgostoBindingSource
            // 
            this.dtTo5VendidasAgostoBindingSource.DataMember = "dtTo5VendidasAgosto";
            this.dtTo5VendidasAgostoBindingSource.DataSource = this.dsCine;
            // 
            // dtTo5VendidasAgostoTableAdapter
            // 
            this.dtTo5VendidasAgostoTableAdapter.ClearBeforeFill = true;
            // 
            // frmTop5Agosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmTop5Agosto";
            this.Text = "frmTop5Agosto";
            this.Load += new System.EventHandler(this.frmTop5Agosto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo5VendidasAgostoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsCine dsCine;
        private System.Windows.Forms.BindingSource dtTo5VendidasAgostoBindingSource;
        private dsCineTableAdapters.dtTo5VendidasAgostoTableAdapter dtTo5VendidasAgostoTableAdapter;
    }
}