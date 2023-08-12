namespace WinFormsCoreImob
{
    partial class FrmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta));
            this.grdConsulta = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.VoltartoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.SairtoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltrarValor = new System.Windows.Forms.Button();
            this.txtValorMax = new System.Windows.Forms.TextBox();
            this.txtValorMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.btnFiltrarNome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdConsulta
            // 
            this.grdConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdConsulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsulta.Location = new System.Drawing.Point(12, 146);
            this.grdConsulta.MultiSelect = false;
            this.grdConsulta.Name = "grdConsulta";
            this.grdConsulta.ReadOnly = true;
            this.grdConsulta.RowTemplate.Height = 25;
            this.grdConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdConsulta.Size = new System.Drawing.Size(962, 503);
            this.grdConsulta.TabIndex = 5;
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
            this.toolStrip1.TabIndex = 4;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltrarValor);
            this.groupBox1.Controls.Add(this.txtValorMax);
            this.groupBox1.Controls.Add(this.txtValorMin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFiltrar);
            this.groupBox1.Controls.Add(this.btnFiltrarNome);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 111);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procurar";
            // 
            // btnFiltrarValor
            // 
            this.btnFiltrarValor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFiltrarValor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFiltrarValor.Location = new System.Drawing.Point(644, 53);
            this.btnFiltrarValor.Name = "btnFiltrarValor";
            this.btnFiltrarValor.Size = new System.Drawing.Size(113, 24);
            this.btnFiltrarValor.TabIndex = 4;
            this.btnFiltrarValor.Text = "Procurar";
            this.btnFiltrarValor.UseVisualStyleBackColor = false;
            this.btnFiltrarValor.Click += new System.EventHandler(this.btnFiltrarValor_Click);
            // 
            // txtValorMax
            // 
            this.txtValorMax.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtValorMax.Location = new System.Drawing.Point(506, 55);
            this.txtValorMax.Name = "txtValorMax";
            this.txtValorMax.Size = new System.Drawing.Size(96, 23);
            this.txtValorMax.TabIndex = 3;
            // 
            // txtValorMin
            // 
            this.txtValorMin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtValorMin.Location = new System.Drawing.Point(397, 55);
            this.txtValorMin.Name = "txtValorMin";
            this.txtValorMin.Size = new System.Drawing.Size(100, 23);
            this.txtValorMin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pesquisar por valor \"mínimo\" e \"máximo\":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pesquisar por \"nome do cliente\" ou \"nome do imovel\":";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFiltrar.Location = new System.Drawing.Point(397, 25);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(205, 23);
            this.txtFiltrar.TabIndex = 0;
            // 
            // btnFiltrarNome
            // 
            this.btnFiltrarNome.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFiltrarNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFiltrarNome.Location = new System.Drawing.Point(644, 23);
            this.btnFiltrarNome.Name = "btnFiltrarNome";
            this.btnFiltrarNome.Size = new System.Drawing.Size(113, 24);
            this.btnFiltrarNome.TabIndex = 1;
            this.btnFiltrarNome.Text = "Procurar";
            this.btnFiltrarNome.UseVisualStyleBackColor = false;
            this.btnFiltrarNome.Click += new System.EventHandler(this.btnFiltrarNome_Click);
            // 
            // FrmConsulta
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grdConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsulta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar clientes cadastrados";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdConsulta;
        private ToolStrip toolStrip1;
        private ToolStripButton VoltartoolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton SairtoolStripButton1;
        private GroupBox groupBox1;
        private Button btnFiltrarValor;
        private TextBox txtValorMax;
        private TextBox txtValorMin;
        private Label label2;
        private Label label1;
        private TextBox txtFiltrar;
        private Button btnFiltrarNome;
    }
}