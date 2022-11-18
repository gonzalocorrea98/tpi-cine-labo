namespace Cine.Reportes
{
    partial class frmRecaudacionSpielberg
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
            this.dtRecaudacionSpielbergBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtRecaudacionSpielbergTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtRecaudacionSpielbergTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRecaudacionSpielbergBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsRecaudacionSpielberg";
            reportDataSource1.Value = this.dtRecaudacionSpielbergBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptRecaudacionSpielberg.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(114, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(531, 351);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsCine
            // 
            this.dsCine.DataSetName = "dsCine";
            this.dsCine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtRecaudacionSpielbergBindingSource
            // 
            this.dtRecaudacionSpielbergBindingSource.DataMember = "dtRecaudacionSpielberg";
            this.dtRecaudacionSpielbergBindingSource.DataSource = this.dsCine;
            // 
            // dtRecaudacionSpielbergTableAdapter
            // 
            this.dtRecaudacionSpielbergTableAdapter.ClearBeforeFill = true;
            // 
            // frmRecaudacionSpielberg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRecaudacionSpielberg";
            this.Text = "frmRecaudacionSpielberg";
            this.Load += new System.EventHandler(this.frmRecaudacionSpielberg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRecaudacionSpielbergBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsCine dsCine;
        private System.Windows.Forms.BindingSource dtRecaudacionSpielbergBindingSource;
        private dsCineTableAdapters.dtRecaudacionSpielbergTableAdapter dtRecaudacionSpielbergTableAdapter;
    }
}