namespace Cine.Formularios
{
    partial class FrmFunciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFunciones));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtTo5VendidasAgostoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCine = new Cine.Reportes.dsCine();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDescuentoTarjeta = new Cine.Botones.buttonPersonalizado();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.dtTo5VendidasAgostoTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtTo5VendidasAgostoTableAdapter();
            this.rptTop5Agosto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rptFunciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtTodasLasFuncionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtTodasLasFuncionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtTodasLasFuncionesTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtTodasLasFuncionesTableAdapter();
            this.btnFunciones = new Cine.Botones.buttonPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo5VendidasAgostoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodasLasFuncionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodasLasFuncionesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTo5VendidasAgostoBindingSource
            // 
            this.dtTo5VendidasAgostoBindingSource.DataMember = "dtTo5VendidasAgosto";
            this.dtTo5VendidasAgostoBindingSource.DataSource = this.dsCine;
            // 
            // dsCine
            // 
            this.dsCine.DataSetName = "dsCine";
            this.dsCine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btnDescuentoTarjeta);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 601);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(89, 486);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(65, 71);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogout.TabIndex = 22;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(40, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "CinemaReport Alpha Version";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnFunciones);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 170);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 53);
            this.panel4.TabIndex = 14;
            // 
            // btnDescuentoTarjeta
            // 
            this.btnDescuentoTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btnDescuentoTarjeta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnDescuentoTarjeta.BorderRadius = 3;
            this.btnDescuentoTarjeta.BorderSize = 1;
            this.btnDescuentoTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescuentoTarjeta.FlatAppearance.BorderSize = 0;
            this.btnDescuentoTarjeta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.btnDescuentoTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.btnDescuentoTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescuentoTarjeta.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnDescuentoTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnDescuentoTarjeta.Location = new System.Drawing.Point(0, 238);
            this.btnDescuentoTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.btnDescuentoTarjeta.Name = "btnDescuentoTarjeta";
            this.btnDescuentoTarjeta.Size = new System.Drawing.Size(250, 53);
            this.btnDescuentoTarjeta.TabIndex = 11;
            this.btnDescuentoTarjeta.Text = "Top 5 De Agosto";
            this.btnDescuentoTarjeta.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnDescuentoTarjeta.UseVisualStyleBackColor = false;
            this.btnDescuentoTarjeta.Click += new System.EventHandler(this.btnDescuentoTarjeta_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 146);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 24);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 146);
            this.panel2.TabIndex = 12;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1056, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(13, 13);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dtTo5VendidasAgostoTableAdapter
            // 
            this.dtTo5VendidasAgostoTableAdapter.ClearBeforeFill = true;
            // 
            // rptTop5Agosto
            // 
            this.rptTop5Agosto.DocumentMapWidth = 8;
            reportDataSource1.Name = "dsTop5VendidasAgosto";
            reportDataSource1.Value = this.dtTo5VendidasAgostoBindingSource;
            this.rptTop5Agosto.LocalReport.DataSources.Add(reportDataSource1);
            this.rptTop5Agosto.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptTop5VendidasAgosto.rdlc";
            this.rptTop5Agosto.Location = new System.Drawing.Point(256, 31);
            this.rptTop5Agosto.Name = "rptTop5Agosto";
            this.rptTop5Agosto.ServerReport.BearerToken = null;
            this.rptTop5Agosto.Size = new System.Drawing.Size(813, 564);
            this.rptTop5Agosto.TabIndex = 21;
            // 
            // rptFunciones
            // 
            reportDataSource2.Name = "ds";
            reportDataSource2.Value = this.dtTodasLasFuncionesBindingSource1;
            this.rptFunciones.LocalReport.DataSources.Add(reportDataSource2);
            this.rptFunciones.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptTodasLasFunciones.rdlc";
            this.rptFunciones.Location = new System.Drawing.Point(256, 31);
            this.rptFunciones.Name = "rptFunciones";
            this.rptFunciones.ServerReport.BearerToken = null;
            this.rptFunciones.Size = new System.Drawing.Size(813, 564);
            this.rptFunciones.TabIndex = 22;
            // 
            // dtTodasLasFuncionesBindingSource
            // 
            this.dtTodasLasFuncionesBindingSource.DataMember = "dtTodasLasFunciones";
            this.dtTodasLasFuncionesBindingSource.DataSource = this.dsCine;
            // 
            // dtTodasLasFuncionesBindingSource1
            // 
            this.dtTodasLasFuncionesBindingSource1.DataMember = "dtTodasLasFunciones";
            this.dtTodasLasFuncionesBindingSource1.DataSource = this.dsCine;
            // 
            // dtTodasLasFuncionesTableAdapter
            // 
            this.dtTodasLasFuncionesTableAdapter.ClearBeforeFill = true;
            // 
            // btnFunciones
            // 
            this.btnFunciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btnFunciones.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnFunciones.BorderRadius = 3;
            this.btnFunciones.BorderSize = 1;
            this.btnFunciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFunciones.FlatAppearance.BorderSize = 0;
            this.btnFunciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.btnFunciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.btnFunciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunciones.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnFunciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnFunciones.Location = new System.Drawing.Point(0, 0);
            this.btnFunciones.Margin = new System.Windows.Forms.Padding(2);
            this.btnFunciones.Name = "btnFunciones";
            this.btnFunciones.Size = new System.Drawing.Size(250, 53);
            this.btnFunciones.TabIndex = 23;
            this.btnFunciones.Text = "Funciones";
            this.btnFunciones.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnFunciones.UseVisualStyleBackColor = false;
            this.btnFunciones.Click += new System.EventHandler(this.btnFunciones_Click);
            // 
            // FrmFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1075, 601);
            this.Controls.Add(this.rptFunciones);
            this.Controls.Add(this.rptTop5Agosto);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFunciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFunciones";
            this.Load += new System.EventHandler(this.FrmFunciones_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmFunciones_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtTo5VendidasAgostoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodasLasFuncionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodasLasFuncionesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private Botones.buttonPersonalizado btnDescuentoTarjeta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private Reportes.dsCine dsCine;
        private System.Windows.Forms.BindingSource dtTo5VendidasAgostoBindingSource;
        private Reportes.dsCineTableAdapters.dtTo5VendidasAgostoTableAdapter dtTo5VendidasAgostoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rptTop5Agosto;
        private System.Windows.Forms.PictureBox btnLogout;
        private Microsoft.Reporting.WinForms.ReportViewer rptFunciones;
        private System.Windows.Forms.BindingSource dtTodasLasFuncionesBindingSource;
        private System.Windows.Forms.BindingSource dtTodasLasFuncionesBindingSource1;
        private Reportes.dsCineTableAdapters.dtTodasLasFuncionesTableAdapter dtTodasLasFuncionesTableAdapter;
        private Botones.buttonPersonalizado btnFunciones;
    }
}