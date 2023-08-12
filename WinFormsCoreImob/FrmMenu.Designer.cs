namespace WinFormsCoreImob
{
    partial class FrmMenu
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
            this.btnTelaConsulta = new System.Windows.Forms.Button();
            this.btnTelaBuscar = new System.Windows.Forms.Button();
            this.btnTelaCadastro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTelaConsulta
            // 
            this.btnTelaConsulta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTelaConsulta.Location = new System.Drawing.Point(81, 143);
            this.btnTelaConsulta.Name = "btnTelaConsulta";
            this.btnTelaConsulta.Size = new System.Drawing.Size(181, 32);
            this.btnTelaConsulta.TabIndex = 1;
            this.btnTelaConsulta.Text = "Consultar todos os clientes";
            this.btnTelaConsulta.UseVisualStyleBackColor = false;
            this.btnTelaConsulta.Click += new System.EventHandler(this.btnTelaConsulta_Click);
            // 
            // btnTelaBuscar
            // 
            this.btnTelaBuscar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTelaBuscar.Location = new System.Drawing.Point(81, 193);
            this.btnTelaBuscar.Name = "btnTelaBuscar";
            this.btnTelaBuscar.Size = new System.Drawing.Size(181, 32);
            this.btnTelaBuscar.TabIndex = 2;
            this.btnTelaBuscar.Text = "Encontrar compradores";
            this.btnTelaBuscar.UseVisualStyleBackColor = false;
            this.btnTelaBuscar.Click += new System.EventHandler(this.btnTelaBuscar_Click);
            // 
            // btnTelaCadastro
            // 
            this.btnTelaCadastro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTelaCadastro.Location = new System.Drawing.Point(81, 93);
            this.btnTelaCadastro.Name = "btnTelaCadastro";
            this.btnTelaCadastro.Size = new System.Drawing.Size(181, 32);
            this.btnTelaCadastro.TabIndex = 0;
            this.btnTelaCadastro.Text = "Cadastro de clientes";
            this.btnTelaCadastro.UseVisualStyleBackColor = false;
            this.btnTelaCadastro.Click += new System.EventHandler(this.btnTelaCadastro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imobiliária";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSair.Location = new System.Drawing.Point(81, 243);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(181, 32);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair do programa";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmMenu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(339, 310);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTelaConsulta);
            this.Controls.Add(this.btnTelaBuscar);
            this.Controls.Add(this.btnTelaCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTelaConsulta;
        private Button btnTelaBuscar;
        private Button btnTelaCadastro;
        private Label label1;
        private Button btnSair;
    }
}