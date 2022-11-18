namespace Cine.Formularios
{
    partial class FrmPeliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPeliculas));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtClasificaiconesMasVistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCine = new Cine.Reportes.dsCine();
            this.dtRecaudacionSpielbergBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSpielberg = new Cine.Botones.buttonPersonalizado();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMasVistas = new Cine.Botones.buttonPersonalizado();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rptMasVistas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.dtClasificaiconesMasVistasTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtClasificaiconesMasVistasTableAdapter();
            this.dtRecaudacionSpielbergBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtRecaudacionSpielbergBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtRecaudacionSpielbergTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtRecaudacionSpielbergTableAdapter();
            this.rptSpielberg = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnPeliculas = new Cine.Botones.buttonPersonalizado();
            this.rptPeliculas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsTodasLasPeliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTodasLasPeliculasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsTodasLasPeliculasTableAdapter = new Cine.Reportes.dsCineTableAdapters.dsTodasLasPeliculasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtClasificaiconesMasVistasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRecaudacionSpielbergBindingSource2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRecaudacionSpielbergBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRecaudacionSpielbergBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTodasLasPeliculasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTodasLasPeliculasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtClasificaiconesMasVistasBindingSource
            // 
            this.dtClasificaiconesMasVistasBindingSource.DataMember = "dtClasificaiconesMasVistas";
            this.dtClasificaiconesMasVistasBindingSource.DataSource = this.dsCine;
            // 
            // dsCine
            // 
            this.dsCine.DataSetName = "dsCine";
            this.dsCine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtRecaudacionSpielbergBindingSource2
            // 
            this.dtRecaudacionSpielbergBindingSource2.DataMember = "dtRecaudacionSpielberg";
            this.dtRecaudacionSpielbergBindingSource2.DataSource = this.dsCine;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btnSpielberg);
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
            this.panel1.TabIndex = 8;
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
            this.panel6.Controls.Add(this.btnMasVistas);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 235);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 53);
            this.panel6.TabIndex = 16;
            // 
            // btnSpielberg
            // 
            this.btnSpielberg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btnSpielberg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnSpielberg.BorderRadius = 3;
            this.btnSpielberg.BorderSize = 1;
            this.btnSpielberg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpielberg.FlatAppearance.BorderSize = 0;
            this.btnSpielberg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.btnSpielberg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.btnSpielberg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpielberg.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnSpielberg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnSpielberg.Location = new System.Drawing.Point(0, 302);
            this.btnSpielberg.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpielberg.Name = "btnSpielberg";
            this.btnSpielberg.Size = new System.Drawing.Size(250, 53);
            this.btnSpielberg.TabIndex = 12;
            this.btnSpielberg.Text = "Spielberg";
            this.btnSpielberg.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnSpielberg.UseVisualStyleBackColor = false;
            this.btnSpielberg.Click += new System.EventHandler(this.btnSpielberg_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 223);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 12);
            this.panel5.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPeliculas);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 170);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 53);
            this.panel4.TabIndex = 14;
            // 
            // btnMasVistas
            // 
            this.btnMasVistas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btnMasVistas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnMasVistas.BorderRadius = 3;
            this.btnMasVistas.BorderSize = 1;
            this.btnMasVistas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasVistas.FlatAppearance.BorderSize = 0;
            this.btnMasVistas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.btnMasVistas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.btnMasVistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasVistas.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnMasVistas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnMasVistas.Location = new System.Drawing.Point(0, 0);
            this.btnMasVistas.Margin = new System.Windows.Forms.Padding(2);
            this.btnMasVistas.Name = "btnMasVistas";
            this.btnMasVistas.Size = new System.Drawing.Size(250, 53);
            this.btnMasVistas.TabIndex = 11;
            this.btnMasVistas.Text = "Más Vistas";
            this.btnMasVistas.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnMasVistas.UseVisualStyleBackColor = false;
            this.btnMasVistas.Click += new System.EventHandler(this.btnMasVistas_Click);
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
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // rptMasVistas
            // 
            reportDataSource1.Name = "dsClasificacionesMasVistas";
            reportDataSource1.Value = this.dtClasificaiconesMasVistasBindingSource;
            this.rptMasVistas.LocalReport.DataSources.Add(reportDataSource1);
            this.rptMasVistas.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptClasificacionesMasVistas.rdlc";
            this.rptMasVistas.Location = new System.Drawing.Point(256, 31);
            this.rptMasVistas.Name = "rptMasVistas";
            this.rptMasVistas.ServerReport.BearerToken = null;
            this.rptMasVistas.Size = new System.Drawing.Size(813, 564);
            this.rptMasVistas.TabIndex = 9;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1056, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(13, 13);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dtClasificaiconesMasVistasTableAdapter
            // 
            this.dtClasificaiconesMasVistasTableAdapter.ClearBeforeFill = true;
            // 
            // dtRecaudacionSpielbergBindingSource
            // 
            this.dtRecaudacionSpielbergBindingSource.DataMember = "dtRecaudacionSpielberg";
            this.dtRecaudacionSpielbergBindingSource.DataSource = this.dsCine;
            // 
            // dtRecaudacionSpielbergBindingSource1
            // 
            this.dtRecaudacionSpielbergBindingSource1.DataMember = "dtRecaudacionSpielberg";
            this.dtRecaudacionSpielbergBindingSource1.DataSource = this.dsCine;
            // 
            // dtRecaudacionSpielbergTableAdapter
            // 
            this.dtRecaudacionSpielbergTableAdapter.ClearBeforeFill = true;
            // 
            // rptSpielberg
            // 
            this.rptSpielberg.DocumentMapWidth = 44;
            reportDataSource2.Name = "dsRecaudacionSpielberg";
            reportDataSource2.Value = this.dtRecaudacionSpielbergBindingSource2;
            this.rptSpielberg.LocalReport.DataSources.Add(reportDataSource2);
            this.rptSpielberg.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptRecaudacionSpielberg.rdlc";
            this.rptSpielberg.Location = new System.Drawing.Point(256, 31);
            this.rptSpielberg.Name = "rptSpielberg";
            this.rptSpielberg.ServerReport.BearerToken = null;
            this.rptSpielberg.Size = new System.Drawing.Size(813, 564);
            this.rptSpielberg.TabIndex = 11;
            // 
            // btnPeliculas
            // 
            this.btnPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btnPeliculas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnPeliculas.BorderRadius = 3;
            this.btnPeliculas.BorderSize = 1;
            this.btnPeliculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeliculas.FlatAppearance.BorderSize = 0;
            this.btnPeliculas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.btnPeliculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.btnPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeliculas.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnPeliculas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnPeliculas.Location = new System.Drawing.Point(0, 0);
            this.btnPeliculas.Margin = new System.Windows.Forms.Padding(2);
            this.btnPeliculas.Name = "btnPeliculas";
            this.btnPeliculas.Size = new System.Drawing.Size(250, 53);
            this.btnPeliculas.TabIndex = 12;
            this.btnPeliculas.Text = "Películas";
            this.btnPeliculas.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnPeliculas.UseVisualStyleBackColor = false;
            this.btnPeliculas.Click += new System.EventHandler(this.btnPeliculas_Click);
            // 
            // rptPeliculas
            // 
            reportDataSource3.Name = "dsTodasLasPeliculas";
            reportDataSource3.Value = this.dsTodasLasPeliculasBindingSource1;
            this.rptPeliculas.LocalReport.DataSources.Add(reportDataSource3);
            this.rptPeliculas.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptTodasLasPeliculas.rdlc";
            this.rptPeliculas.Location = new System.Drawing.Point(256, 31);
            this.rptPeliculas.Name = "rptPeliculas";
            this.rptPeliculas.ServerReport.BearerToken = null;
            this.rptPeliculas.Size = new System.Drawing.Size(813, 564);
            this.rptPeliculas.TabIndex = 12;
            // 
            // dsTodasLasPeliculasBindingSource
            // 
            this.dsTodasLasPeliculasBindingSource.DataMember = "dsTodasLasPeliculas";
            this.dsTodasLasPeliculasBindingSource.DataSource = this.dsCine;
            // 
            // dsTodasLasPeliculasBindingSource1
            // 
            this.dsTodasLasPeliculasBindingSource1.DataMember = "dsTodasLasPeliculas";
            this.dsTodasLasPeliculasBindingSource1.DataSource = this.dsCine;
            // 
            // dsTodasLasPeliculasTableAdapter
            // 
            this.dsTodasLasPeliculasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1075, 601);
            this.Controls.Add(this.rptPeliculas);
            this.Controls.Add(this.rptSpielberg);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.rptMasVistas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPeliculas";
            this.Load += new System.EventHandler(this.FrmPeliculas_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmPeliculas_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtClasificaiconesMasVistasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRecaudacionSpielbergBindingSource2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRecaudacionSpielbergBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRecaudacionSpielbergBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTodasLasPeliculasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTodasLasPeliculasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private Botones.buttonPersonalizado btnSpielberg;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private Botones.buttonPersonalizado btnMasVistas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rptMasVistas;
        private System.Windows.Forms.PictureBox btnCerrar;
        private Reportes.dsCine dsCine;
        private System.Windows.Forms.BindingSource dtClasificaiconesMasVistasBindingSource;
        private Reportes.dsCineTableAdapters.dtClasificaiconesMasVistasTableAdapter dtClasificaiconesMasVistasTableAdapter;
        private System.Windows.Forms.BindingSource dtRecaudacionSpielbergBindingSource;
        private System.Windows.Forms.BindingSource dtRecaudacionSpielbergBindingSource1;
        private Reportes.dsCineTableAdapters.dtRecaudacionSpielbergTableAdapter dtRecaudacionSpielbergTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rptSpielberg;
        private System.Windows.Forms.BindingSource dtRecaudacionSpielbergBindingSource2;
        private System.Windows.Forms.PictureBox btnLogout;
        private Botones.buttonPersonalizado btnPeliculas;
        private Microsoft.Reporting.WinForms.ReportViewer rptPeliculas;
        private System.Windows.Forms.BindingSource dsTodasLasPeliculasBindingSource;
        private System.Windows.Forms.BindingSource dsTodasLasPeliculasBindingSource1;
        private Reportes.dsCineTableAdapters.dsTodasLasPeliculasTableAdapter dsTodasLasPeliculasTableAdapter;
    }
}