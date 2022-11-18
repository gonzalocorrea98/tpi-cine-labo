namespace Cine.Reportes
{
    partial class frmMenos10Butacas
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
            this.dtMenos10ButacasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtMenos10ButacasTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtMenos10ButacasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMenos10ButacasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsMenos10Entradas";
            reportDataSource1.Value = this.dtMenos10ButacasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptMenos10Entradas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(193, 73);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsCine
            // 
            this.dsCine.DataSetName = "dsCine";
            this.dsCine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtMenos10ButacasBindingSource
            // 
            this.dtMenos10ButacasBindingSource.DataMember = "dtMenos10Butacas";
            this.dtMenos10ButacasBindingSource.DataSource = this.dsCine;
            // 
            // dtMenos10ButacasTableAdapter
            // 
            this.dtMenos10ButacasTableAdapter.ClearBeforeFill = true;
            // 
            // frmMenos10Butacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmMenos10Butacas";
            this.Text = "frmMenos10Butacas";
            this.Load += new System.EventHandler(this.frmMenos10Butacas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMenos10ButacasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsCine dsCine;
        private System.Windows.Forms.BindingSource dtMenos10ButacasBindingSource;
        private dsCineTableAdapters.dtMenos10ButacasTableAdapter dtMenos10ButacasTableAdapter;
    }
}