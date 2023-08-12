namespace WinFormsCoreImob
{
    partial class FrmBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscar));
            this.grdBuscar = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.VoltartoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.SairtoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscar)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdBuscar
            // 
            this.grdBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdBuscar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBuscar.Location = new System.Drawing.Point(11, 50);
            this.grdBuscar.MultiSelect = false;
            this.grdBuscar.Name = "grdBuscar";
            this.grdBuscar.ReadOnly = true;
            this.grdBuscar.RowTemplate.Height = 25;
            this.grdBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBuscar.Size = new System.Drawing.Size(962, 599);
            this.grdBuscar.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VoltartoolStripButton1,
            this.toolStripSeparator1,
            this.toolStripSeparator4,
            this.SairtoolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // VoltartoolStripButton1
            // 
            this.VoltartoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("VoltartoolStripButton1.Image")));
            this.VoltartoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VoltartoolStripButton1.Name = "VoltartoolStripButton1";
            this.VoltartoolStripButton1.Size = new System.Drawing.Size(91, 22);
            this.VoltartoolStripButton1.Text = "Voltar Menu";
            this.VoltartoolStripButton1.Click += new System.EventHandler(this.VoltartoolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // SairtoolStripButton1
            // 
            this.SairtoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("SairtoolStripButton1.Image")));
            this.SairtoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SairtoolStripButton1.Name = "SairtoolStripButton1";
            this.SairtoolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.SairtoolStripButton1.Text = "Sair";
            this.SairtoolStripButton1.Click += new System.EventHandler(this.SairtoolStripButton1_Click);
            // 
            // FrmBuscar
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grdBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encontrar clientes compativeis";
            this.Load += new System.EventHandler(this.FrmBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscar)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdBuscar;
        private ToolStrip toolStrip1;
        private ToolStripButton VoltartoolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton SairtoolStripButton1;
    }
}