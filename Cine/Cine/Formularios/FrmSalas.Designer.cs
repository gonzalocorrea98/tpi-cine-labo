namespace Cine.Formularios
{
    partial class FrmSalas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalas));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dsButacasVipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCine = new Cine.Reportes.dsCine();
            this.dtMenos10ButacasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnButacasVip = new Cine.Botones.buttonPersonalizado();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMenosDe10 = new Cine.Botones.buttonPersonalizado();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rptButacasVip = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsDescuentoTarjetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDescuentoTarjetaTableAdapter = new Cine.Reportes.dsCineTableAdapters.dsDescuentoTarjetaTableAdapter();
            this.dsButacasVipTableAdapter = new Cine.Reportes.dsCineTableAdapters.dsButacasVipTableAdapter();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.rptMenosDe10 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtMenos10ButacasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtMenos10ButacasTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtMenos10ButacasTableAdapter();
            this.btnSalas = new Cine.Botones.buttonPersonalizado();
            this.rptSalas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtTodasLasSalasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtTodasLasSalasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtTodasLasSalasTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtTodasLasSalasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsButacasVipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMenos10ButacasBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDescuentoTarjetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMenos10ButacasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodasLasSalasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodasLasSalasBindingSource1)).BeginInit();
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
            // dtMenos10ButacasBindingSource1
            // 
            this.dtMenos10ButacasBindingSource1.DataMember = "dtMenos10Butacas";
            this.dtMenos10ButacasBindingSource1.DataSource = this.dsCine;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
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
            this.btnLogout.TabIndex = 20;
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
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 727);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 53);
            this.panel6.TabIndex = 16;
            // 
            // btnButacasVip
            // 
            this.btnButacasVip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btnButacasVip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnButacasVip.BorderRadius = 3;
            this.btnButacasVip.BorderSize = 1;
            this.btnButacasVip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnButacasVip.FlatAppearance.BorderSize = 0;
            this.btnButacasVip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.btnButacasVip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.btnButacasVip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnButacasVip.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnButacasVip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnButacasVip.Location = new System.Drawing.Point(0, 313);
            this.btnButacasVip.Margin = new System.Windows.Forms.Padding(2);
            this.btnButacasVip.Name = "btnButacasVip";
            this.btnButacasVip.Size = new System.Drawing.Size(250, 53);
            this.btnButacasVip.TabIndex = 12;
            this.btnButacasVip.Text = "Butacas VIP";
            this.btnButacasVip.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnButacasVip.UseVisualStyleBackColor = false;
            this.btnButacasVip.Click += new System.EventHandler(this.btnButacasVip_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 715);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 12);
            this.panel5.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 662);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 53);
            this.panel4.TabIndex = 14;
            // 
            // btnMenosDe10
            // 
            this.btnMenosDe10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btnMenosDe10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnMenosDe10.BorderRadius = 3;
            this.btnMenosDe10.BorderSize = 1;
            this.btnMenosDe10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenosDe10.FlatAppearance.BorderSize = 0;
            this.btnMenosDe10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.btnMenosDe10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.btnMenosDe10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenosDe10.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnMenosDe10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnMenosDe10.Location = new System.Drawing.Point(0, 245);
            this.btnMenosDe10.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenosDe10.Name = "btnMenosDe10";
            this.btnMenosDe10.Size = new System.Drawing.Size(250, 53);
            this.btnMenosDe10.TabIndex = 11;
            this.btnMenosDe10.Text = "Menos Frecuentes";
            this.btnMenosDe10.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnMenosDe10.UseVisualStyleBackColor = false;
            this.btnMenosDe10.Click += new System.EventHandler(this.btnMenosDe10_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 638);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 24);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSalas);
            this.panel2.Controls.Add(this.btnButacasVip);
            this.panel2.Controls.Add(this.btnMenosDe10);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 638);
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
            // rptButacasVip
            // 
            this.rptButacasVip.DocumentMapWidth = 38;
            reportDataSource4.Name = "dsButacasVip";
            reportDataSource4.Value = this.dsButacasVipBindingSource;
            this.rptButacasVip.LocalReport.DataSources.Add(reportDataSource4);
            this.rptButacasVip.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptButacasVip.rdlc";
            this.rptButacasVip.Location = new System.Drawing.Point(256, 31);
            this.rptButacasVip.Name = "rptButacasVip";
            this.rptButacasVip.ServerReport.BearerToken = null;
            this.rptButacasVip.Size = new System.Drawing.Size(813, 564);
            this.rptButacasVip.TabIndex = 10;
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
            // dsButacasVipTableAdapter
            // 
            this.dsButacasVipTableAdapter.ClearBeforeFill = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1056, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(13, 13);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // rptMenosDe10
            // 
            this.rptMenosDe10.DocumentMapWidth = 42;
            reportDataSource5.Name = "dsMenos10Entradas";
            reportDataSource5.Value = this.dtMenos10ButacasBindingSource1;
            this.rptMenosDe10.LocalReport.DataSources.Add(reportDataSource5);
            this.rptMenosDe10.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptMenos10Entradas.rdlc";
            this.rptMenosDe10.Location = new System.Drawing.Point(255, 31);
            this.rptMenosDe10.Name = "rptMenosDe10";
            this.rptMenosDe10.ServerReport.BearerToken = null;
            this.rptMenosDe10.Size = new System.Drawing.Size(813, 564);
            this.rptMenosDe10.TabIndex = 12;
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
            // btnSalas
            // 
            this.btnSalas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btnSalas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnSalas.BorderRadius = 3;
            this.btnSalas.BorderSize = 1;
            this.btnSalas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalas.FlatAppearance.BorderSize = 0;
            this.btnSalas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.btnSalas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.btnSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalas.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnSalas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnSalas.Location = new System.Drawing.Point(0, 177);
            this.btnSalas.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalas.Name = "btnSalas";
            this.btnSalas.Size = new System.Drawing.Size(250, 53);
            this.btnSalas.TabIndex = 13;
            this.btnSalas.Text = "Salas";
            this.btnSalas.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnSalas.UseVisualStyleBackColor = false;
            this.btnSalas.Click += new System.EventHandler(this.btnSalas_Click);
            // 
            // rptSalas
            // 
            reportDataSource6.Name = "dsTodasLasSalas";
            reportDataSource6.Value = this.dtTodasLasSalasBindingSource1;
            this.rptSalas.LocalReport.DataSources.Add(reportDataSource6);
            this.rptSalas.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptTodasLasSalas.rdlc";
            this.rptSalas.Location = new System.Drawing.Point(255, 31);
            this.rptSalas.Name = "rptSalas";
            this.rptSalas.ServerReport.BearerToken = null;
            this.rptSalas.Size = new System.Drawing.Size(813, 564);
            this.rptSalas.TabIndex = 13;
            // 
            // dtTodasLasSalasBindingSource
            // 
            this.dtTodasLasSalasBindingSource.DataMember = "dtTodasLasSalas";
            this.dtTodasLasSalasBindingSource.DataSource = this.dsCine;
            // 
            // dtTodasLasSalasBindingSource1
            // 
            this.dtTodasLasSalasBindingSource1.DataMember = "dtTodasLasSalas";
            this.dtTodasLasSalasBindingSource1.DataSource = this.dsCine;
            // 
            // dtTodasLasSalasTableAdapter
            // 
            this.dtTodasLasSalasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1075, 601);
            this.Controls.Add(this.rptSalas);
            this.Controls.Add(this.rptMenosDe10);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.rptButacasVip);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSalas";
            this.Load += new System.EventHandler(this.FrmSalas_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmSalas_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dsButacasVipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMenos10ButacasBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDescuentoTarjetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMenos10ButacasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodasLasSalasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodasLasSalasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private Botones.buttonPersonalizado btnButacasVip;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private Botones.buttonPersonalizado btnMenosDe10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rptButacasVip;
        private Reportes.dsCine dsCine;
        private System.Windows.Forms.BindingSource dsDescuentoTarjetaBindingSource;
        private Reportes.dsCineTableAdapters.dsDescuentoTarjetaTableAdapter dsDescuentoTarjetaTableAdapter;
        private System.Windows.Forms.BindingSource dsButacasVipBindingSource;
        private Reportes.dsCineTableAdapters.dsButacasVipTableAdapter dsButacasVipTableAdapter;
        private System.Windows.Forms.PictureBox btnCerrar;
        private Microsoft.Reporting.WinForms.ReportViewer rptMenosDe10;
        private System.Windows.Forms.BindingSource dtMenos10ButacasBindingSource;
        private System.Windows.Forms.BindingSource dtMenos10ButacasBindingSource1;
        private Reportes.dsCineTableAdapters.dtMenos10ButacasTableAdapter dtMenos10ButacasTableAdapter;
        private System.Windows.Forms.PictureBox btnLogout;
        private Botones.buttonPersonalizado btnSalas;
        private Microsoft.Reporting.WinForms.ReportViewer rptSalas;
        private System.Windows.Forms.BindingSource dtTodasLasSalasBindingSource;
        private System.Windows.Forms.BindingSource dtTodasLasSalasBindingSource1;
        private Reportes.dsCineTableAdapters.dtTodasLasSalasTableAdapter dtTodasLasSalasTableAdapter;
    }
}