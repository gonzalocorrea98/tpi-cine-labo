namespace Cine.Reportes
{
    partial class frmDescuentoTarjeta
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
            this.dsDescuentoTarjetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDescuentoTarjetaTableAdapter = new Cine.Reportes.dsCineTableAdapters.dsDescuentoTarjetaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDescuentoTarjetaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsDescuentoTarjeta";
            reportDataSource1.Value = this.dsDescuentoTarjetaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptDescuentoTarjeta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(116, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(479, 369);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsCine
            // 
            this.dsCine.DataSetName = "dsCine";
            this.dsCine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsDescuentoTarjetaBindingSource
            // 
            this.dsDescuentoTarjetaBindingSource.DataMember = "dsDescuentoTarjeta";
            this.dsDescuentoTarjetaBindingSource.DataSource = this.dsCine;
            // 
            // dsDescuentoTarjetaTableAdapter
            // 
            this.dsDescuentoTarjetaTableAdapter.ClearBeforeFill = true;
            // 
            // frmDescuentoTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmDescuentoTarjeta";
            this.Text = "frmDescuentoTarjeta";
            this.Load += new System.EventHandler(this.frmDescuentoTarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDescuentoTarjetaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsCine dsCine;
        private System.Windows.Forms.BindingSource dsDescuentoTarjetaBindingSource;
        private dsCineTableAdapters.dsDescuentoTarjetaTableAdapter dsDescuentoTarjetaTableAdapter;
    }
}