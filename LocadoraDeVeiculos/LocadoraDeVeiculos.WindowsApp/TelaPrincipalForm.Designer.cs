
namespace LocadoraDeVeiculos.WindowsApp
{
    partial class TelaPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoDeVeículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.locaçaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBoxAcoes = new System.Windows.Forms.ToolStrip();
            this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.labelTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            this.panelRegistros = new System.Windows.Forms.Panel();
            this.statusStripRodape = new System.Windows.Forms.StatusStrip();
            this.labelRodape = new System.Windows.Forms.ToolStripStatusLabel();
            this.locarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolBoxAcoes.SuspendLayout();
            this.statusStripRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Red;
            this.labelTitulo.Location = new System.Drawing.Point(267, 0);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(266, 29);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "Locadora de Veículos";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.serviçosToolStripMenuItem,
            this.veiculosToolStripMenuItem,
            this.grupoDeVeículosToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Red;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(72, 21);
            this.toolStripMenuItem1.Text = "Cadastros";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.servicosToolStripMenuItem_Click);
            // 
            // veiculosToolStripMenuItem
            // 
            this.veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
            this.veiculosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.veiculosToolStripMenuItem.Text = "Veiculos";
            this.veiculosToolStripMenuItem.Click += new System.EventHandler(this.veiculosToolStripMenuItem_Click);
            // 
            // grupoDeVeículosToolStripMenuItem
            // 
            this.grupoDeVeículosToolStripMenuItem.Name = "grupoDeVeículosToolStripMenuItem";
            this.grupoDeVeículosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.grupoDeVeículosToolStripMenuItem.Text = "Grupo de Veículos";
            this.grupoDeVeículosToolStripMenuItem.Click += new System.EventHandler(this.grupoDeVeículosToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.locaçaoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // locaçaoToolStripMenuItem
            // 
            this.locaçaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locarToolStripMenuItem,
            this.devoluçãoToolStripMenuItem});
            this.locaçaoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locaçaoToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.locaçaoToolStripMenuItem.Name = "locaçaoToolStripMenuItem";
            this.locaçaoToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.locaçaoToolStripMenuItem.Text = "Locaçao";
            // 
            // toolBoxAcoes
            // 
            this.toolBoxAcoes.AutoSize = false;
            this.toolBoxAcoes.BackColor = System.Drawing.Color.DarkGray;
            this.toolBoxAcoes.Enabled = false;
            this.toolBoxAcoes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolBoxAcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdicionar,
            this.btnEditar,
            this.btnExcluir,
            this.toolStripSeparador,
            this.labelTipoCadastro});
            this.toolBoxAcoes.Location = new System.Drawing.Point(0, 25);
            this.toolBoxAcoes.Name = "toolBoxAcoes";
            this.toolBoxAcoes.Size = new System.Drawing.Size(800, 45);
            this.toolBoxAcoes.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(40, 42);
            this.btnAdicionar.Text = "btnAdicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(40, 42);
            this.btnEditar.Text = "btnEditar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(40, 42);
            this.btnExcluir.Text = "toolStripButton1";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripSeparador
            // 
            this.toolStripSeparador.Name = "toolStripSeparador";
            this.toolStripSeparador.Size = new System.Drawing.Size(6, 45);
            // 
            // labelTipoCadastro
            // 
            this.labelTipoCadastro.Name = "labelTipoCadastro";
            this.labelTipoCadastro.Size = new System.Drawing.Size(174, 42);
            this.labelTipoCadastro.Text = "Cadastro Selecionado: Nenhum";
            // 
            // panelRegistros
            // 
            this.panelRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRegistros.Location = new System.Drawing.Point(0, 70);
            this.panelRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.panelRegistros.Name = "panelRegistros";
            this.panelRegistros.Size = new System.Drawing.Size(800, 421);
            this.panelRegistros.TabIndex = 6;
            // 
            // statusStripRodape
            // 
            this.statusStripRodape.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripRodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelRodape});
            this.statusStripRodape.Location = new System.Drawing.Point(0, 493);
            this.statusStripRodape.Name = "statusStripRodape";
            this.statusStripRodape.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStripRodape.Size = new System.Drawing.Size(800, 22);
            this.statusStripRodape.TabIndex = 7;
            this.statusStripRodape.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            this.labelRodape.Name = "labelRodape";
            this.labelRodape.Size = new System.Drawing.Size(78, 17);
            this.labelRodape.Text = "Tudo certo :D";
            // 
            // locarToolStripMenuItem
            // 
            this.locarToolStripMenuItem.Name = "locarToolStripMenuItem";
            this.locarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.locarToolStripMenuItem.Text = "Locações";
            this.locarToolStripMenuItem.Click += new System.EventHandler(this.locarToolStripMenuItem_Click);
            // 
            // devoluçãoToolStripMenuItem
            // 
            this.devoluçãoToolStripMenuItem.Name = "devoluçãoToolStripMenuItem";
            this.devoluçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.devoluçãoToolStripMenuItem.Text = "Devoluções";
            this.devoluçãoToolStripMenuItem.Click += new System.EventHandler(this.devoluçãoToolStripMenuItem_Click);
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.statusStripRodape);
            this.Controls.Add(this.panelRegistros);
            this.Controls.Add(this.toolBoxAcoes);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TelaPrincipalForm";
            this.Text = "Locadora de veículos ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolBoxAcoes.ResumeLayout(false);
            this.toolBoxAcoes.PerformLayout();
            this.statusStripRodape.ResumeLayout(false);
            this.statusStripRodape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolBoxAcoes;
        private System.Windows.Forms.ToolStripButton btnAdicionar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripMenuItem locaçaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoDeVeículosToolStripMenuItem;
        private System.Windows.Forms.Panel panelRegistros;
        private System.Windows.Forms.StatusStrip statusStripRodape;
        private System.Windows.Forms.ToolStripStatusLabel labelRodape;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparador;
        private System.Windows.Forms.ToolStripLabel labelTipoCadastro;
        private System.Windows.Forms.ToolStripMenuItem locarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devoluçãoToolStripMenuItem;
    }
}

