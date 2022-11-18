namespace Cine.Formularios
{
    partial class FrmClientes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtRecurrentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCine = new Cine.Reportes.dsCine();
            this.dtTodosLosClientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dtClientesAgostoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dtClientesAgostoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtClientesAgostoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtTodosLosClientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtTodosLosClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptFrecuentes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtRecurrentesTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtRecurrentesTableAdapter();
            this.dtClientesAgostoTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtClientesAgostoTableAdapter();
            this.rptTodos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtTodosLosClientesTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtTodosLosClientesTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnDeAgosto = new Cine.Botones.buttonPersonalizado();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnFrecuentes = new Cine.Botones.buttonPersonalizado();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTodos = new Cine.Botones.buttonPersonalizado();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.rptClientesAgosto = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dtRecurrentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodosLosClientesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesAgostoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesAgostoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesAgostoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodosLosClientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodosLosClientesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtRecurrentesBindingSource
            // 
            this.dtRecurrentesBindingSource.DataMember = "dtRecurrentes";
            this.dtRecurrentesBindingSource.DataSource = this.dsCine;
            // 
            // dsCine
            // 
            this.dsCine.DataSetName = "dsCine";
            this.dsCine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtTodosLosClientesBindingSource2
            // 
            this.dtTodosLosClientesBindingSource2.DataMember = "dtTodosLosClientes";
            this.dtTodosLosClientesBindingSource2.DataSource = this.dsCine;
            // 
            // dtClientesAgostoBindingSource2
            // 
            this.dtClientesAgostoBindingSource2.DataMember = "dtClientesAgosto";
            this.dtClientesAgostoBindingSource2.DataSource = this.dsCine;
            // 
            // dtClientesAgostoBindingSource
            // 
            this.dtClientesAgostoBindingSource.DataMember = "dtClientesAgosto";
            this.dtClientesAgostoBindingSource.DataSource = this.dsCine;
            // 
            // dtClientesAgostoBindingSource1
            // 
            this.dtClientesAgostoBindingSource1.DataMember = "dtClientesAgosto";
            this.dtClientesAgostoBindingSource1.DataSource = this.dsCine;
            // 
            // dtTodosLosClientesBindingSource1
            // 
            this.dtTodosLosClientesBindingSource1.DataMember = "dtTodosLosClientes";
            this.dtTodosLosClientesBindingSource1.DataSource = this.dsCine;
            // 
            // dtTodosLosClientesBindingSource
            // 
            this.dtTodosLosClientesBindingSource.DataMember = "dtTodosLosClientes";
            this.dtTodosLosClientesBindingSource.DataSource = this.dsCine;
            // 
            // rptFrecuentes
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dtRecurrentesBindingSource;
            this.rptFrecuentes.LocalReport.DataSources.Add(reportDataSource1);
            this.rptFrecuentes.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptRecurrentes.rdlc";
            this.rptFrecuentes.Location = new System.Drawing.Point(256, 31);
            this.rptFrecuentes.Name = "rptFrecuentes";
            this.rptFrecuentes.ServerReport.BearerToken = null;
            this.rptFrecuentes.Size = new System.Drawing.Size(813, 564);
            this.rptFrecuentes.TabIndex = 2;
            // 
            // dtRecurrentesTableAdapter
            // 
            this.dtRecurrentesTableAdapter.ClearBeforeFill = true;
            // 
            // dtClientesAgostoTableAdapter
            // 
            this.dtClientesAgostoTableAdapter.ClearBeforeFill = true;
            // 
            // rptTodos
            // 
            reportDataSource2.Name = "DSTodosLosClientes";
            reportDataSource2.Value = this.dtTodosLosClientesBindingSource2;
            this.rptTodos.LocalReport.DataSources.Add(reportDataSource2);
            this.rptTodos.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptTodosLosClientes.rdlc";
            this.rptTodos.Location = new System.Drawing.Point(255, 31);
            this.rptTodos.Name = "rptTodos";
            this.rptTodos.ServerReport.BearerToken = null;
            this.rptTodos.Size = new System.Drawing.Size(813, 564);
            this.rptTodos.TabIndex = 6;
            // 
            // dtTodosLosClientesTableAdapter
            // 
            this.dtTodosLosClientesTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 601);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnLogout.TabIndex = 19;
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
            // panel8
            // 
            this.panel8.Controls.Add(this.btnDeAgosto);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 300);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(250, 53);
            this.panel8.TabIndex = 18;
            // 
            // btnDeAgosto
            // 
            this.btnDeAgosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btnDeAgosto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnDeAgosto.BorderRadius = 3;
            this.btnDeAgosto.BorderSize = 1;
            this.btnDeAgosto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeAgosto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeAgosto.FlatAppearance.BorderSize = 0;
            this.btnDeAgosto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.btnDeAgosto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.btnDeAgosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeAgosto.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnDeAgosto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnDeAgosto.Location = new System.Drawing.Point(0, 0);
            this.btnDeAgosto.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeAgosto.Name = "btnDeAgosto";
            this.btnDeAgosto.Size = new System.Drawing.Size(250, 53);
            this.btnDeAgosto.TabIndex = 12;
            this.btnDeAgosto.Text = "De Agosto";
            this.btnDeAgosto.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnDeAgosto.UseVisualStyleBackColor = false;
            this.btnDeAgosto.Click += new System.EventHandler(this.btnDeAgosto_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 288);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 12);
            this.panel7.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnFrecuentes);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 235);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 53);
            this.panel6.TabIndex = 16;
            // 
            // btnFrecuentes
            // 
            this.btnFrecuentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btnFrecuentes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnFrecuentes.BorderRadius = 3;
            this.btnFrecuentes.BorderSize = 1;
            this.btnFrecuentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrecuentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFrecuentes.FlatAppearance.BorderSize = 0;
            this.btnFrecuentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.btnFrecuentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.btnFrecuentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrecuentes.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnFrecuentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnFrecuentes.Location = new System.Drawing.Point(0, 0);
            this.btnFrecuentes.Margin = new System.Windows.Forms.Padding(2);
            this.btnFrecuentes.Name = "btnFrecuentes";
            this.btnFrecuentes.Size = new System.Drawing.Size(250, 53);
            this.btnFrecuentes.TabIndex = 12;
            this.btnFrecuentes.Text = "Frecuentes";
            this.btnFrecuentes.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnFrecuentes.UseVisualStyleBackColor = false;
            this.btnFrecuentes.Click += new System.EventHandler(this.btnFrecuentes_Click);
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
            this.panel4.Controls.Add(this.btnTodos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 170);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 53);
            this.panel4.TabIndex = 14;
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btnTodos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnTodos.BorderRadius = 3;
            this.btnTodos.BorderSize = 1;
            this.btnTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTodos.FlatAppearance.BorderSize = 0;
            this.btnTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.btnTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnTodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnTodos.Location = new System.Drawing.Point(0, 0);
            this.btnTodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(250, 53);
            this.btnTodos.TabIndex = 11;
            this.btnTodos.Text = "Clientes";
            this.btnTodos.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
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
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // rptClientesAgosto
            // 
            this.rptClientesAgosto.DocumentMapWidth = 6;
            reportDataSource3.Name = "dtsClientesDeAgosto";
            reportDataSource3.Value = this.dtClientesAgostoBindingSource2;
            this.rptClientesAgosto.LocalReport.DataSources.Add(reportDataSource3);
            this.rptClientesAgosto.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptClientesDeAgosto.rdlc";
            this.rptClientesAgosto.Location = new System.Drawing.Point(255, 31);
            this.rptClientesAgosto.Name = "rptClientesAgosto";
            this.rptClientesAgosto.ServerReport.BearerToken = null;
            this.rptClientesAgosto.Size = new System.Drawing.Size(814, 564);
            this.rptClientesAgosto.TabIndex = 10;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1075, 601);
            this.Controls.Add(this.rptClientesAgosto);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.rptTodos);
            this.Controls.Add(this.rptFrecuentes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmClientes_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtRecurrentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodosLosClientesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesAgostoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesAgostoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesAgostoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodosLosClientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodosLosClientesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rptFrecuentes;
        private Reportes.dsCine dsCine;
        private System.Windows.Forms.BindingSource dtRecurrentesBindingSource;
        private Reportes.dsCineTableAdapters.dtRecurrentesTableAdapter dtRecurrentesTableAdapter;
        private System.Windows.Forms.BindingSource dtClientesAgostoBindingSource;
        private System.Windows.Forms.BindingSource dtClientesAgostoBindingSource1;
        private Reportes.dsCineTableAdapters.dtClientesAgostoTableAdapter dtClientesAgostoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rptTodos;
        private System.Windows.Forms.BindingSource dtTodosLosClientesBindingSource;
        private System.Windows.Forms.BindingSource dtTodosLosClientesBindingSource1;
        private Reportes.dsCineTableAdapters.dtTodosLosClientesTableAdapter dtTodosLosClientesTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private Botones.buttonPersonalizado btnTodos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private Botones.buttonPersonalizado btnDeAgosto;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private Botones.buttonPersonalizado btnFrecuentes;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.BindingSource dtTodosLosClientesBindingSource2;
        private Microsoft.Reporting.WinForms.ReportViewer rptClientesAgosto;
        private System.Windows.Forms.BindingSource dtClientesAgostoBindingSource2;
        private System.Windows.Forms.PictureBox btnLogout;
    }
}