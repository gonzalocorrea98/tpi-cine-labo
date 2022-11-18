namespace Cine.Reportes
{
    partial class frmClasificacionesMasVistas
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
            this.dtClasificaiconesMasVistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtClasificaiconesMasVistasTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtClasificaiconesMasVistasTableAdapter();
            this.dtRecurrentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtClasificaiconesMasVistasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClasificaiconesMasVistasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRecurrentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClasificaiconesMasVistasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsClasificacionesMasVistas";
            reportDataSource1.Value = this.dtClasificaiconesMasVistasBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptClasificacionesMasVistas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(177, 28);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(496, 400);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsCine
            // 
            this.dsCine.DataSetName = "dsCine";
            this.dsCine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtClasificaiconesMasVistasBindingSource
            // 
            this.dtClasificaiconesMasVistasBindingSource.DataMember = "dtClasificaiconesMasVistas";
            this.dtClasificaiconesMasVistasBindingSource.DataSource = this.dsCine;
            // 
            // dtClasificaiconesMasVistasTableAdapter
            // 
            this.dtClasificaiconesMasVistasTableAdapter.ClearBeforeFill = true;
            // 
            // dtRecurrentesBindingSource
            // 
            this.dtRecurrentesBindingSource.DataMember = "dtRecurrentes";
            this.dtRecurrentesBindingSource.DataSource = this.dsCine;
            // 
            // dsCineBindingSource
            // 
            this.dsCineBindingSource.DataSource = this.dsCine;
            this.dsCineBindingSource.Position = 0;
            // 
            // dtClasificaiconesMasVistasBindingSource1
            // 
            this.dtClasificaiconesMasVistasBindingSource1.DataMember = "dtClasificaiconesMasVistas";
            this.dtClasificaiconesMasVistasBindingSource1.DataSource = this.dsCineBindingSource;
            // 
            // frmClasificacionesMasVistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 466);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmClasificacionesMasVistas";
            this.Text = "frmClasificacionesMasVistas";
            this.Load += new System.EventHandler(this.frmClasificacionesMasVistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClasificaiconesMasVistasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRecurrentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClasificaiconesMasVistasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsCine dsCine;
        private System.Windows.Forms.BindingSource dtClasificaiconesMasVistasBindingSource;
        private dsCineTableAdapters.dtClasificaiconesMasVistasTableAdapter dtClasificaiconesMasVistasTableAdapter;
        private System.Windows.Forms.BindingSource dtRecurrentesBindingSource;
        private System.Windows.Forms.BindingSource dtClasificaiconesMasVistasBindingSource1;
        private System.Windows.Forms.BindingSource dsCineBindingSource;
    }
}