
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
            this.inícioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBoxAcoes = new System.Windows.Forms.ToolStrip();
            this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnFiltrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.labelTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            this.panelRegistros = new System.Windows.Forms.Panel();
            this.statusStripRodape = new System.Windows.Forms.StatusStrip();
            this.labelRodape = new System.Windows.Forms.ToolStripStatusLabel();
            this.descontosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuponsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parceirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolBoxAcoes.SuspendLayout();
            this.statusStripRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(309, 3);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(182, 20);
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
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem1.Text = "Cadastros";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.FuncionariosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.ServicosToolStripMenuItem_Click);
            // 
            // veiculosToolStripMenuItem
            // 
            this.veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
            this.veiculosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.veiculosToolStripMenuItem.Text = "Veiculos";
            this.veiculosToolStripMenuItem.Click += new System.EventHandler(this.VeiculosToolStripMenuItem_Click);
            // 
            // grupoDeVeículosToolStripMenuItem
            // 
            this.grupoDeVeículosToolStripMenuItem.Name = "grupoDeVeículosToolStripMenuItem";
            this.grupoDeVeículosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grupoDeVeículosToolStripMenuItem.Text = "Grupo de Veículos";
            this.grupoDeVeículosToolStripMenuItem.Click += new System.EventHandler(this.GrupoDeVeículosToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inícioToolStripMenuItem,
            this.toolStripMenuItem1,
            this.locaçaoToolStripMenuItem,
            this.descontosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inícioToolStripMenuItem
            // 
            this.inícioToolStripMenuItem.Name = "inícioToolStripMenuItem";
            this.inícioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inícioToolStripMenuItem.Text = "Início";
            this.inícioToolStripMenuItem.Click += new System.EventHandler(this.InícioToolStripMenuItem_Click);
            // 
            // locaçaoToolStripMenuItem
            // 
            this.locaçaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locarToolStripMenuItem,
            this.devoluçãoToolStripMenuItem});
            this.locaçaoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.locaçaoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.locaçaoToolStripMenuItem.Name = "locaçaoToolStripMenuItem";
            this.locaçaoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.locaçaoToolStripMenuItem.Text = "Locaçao";
            // 
            // locarToolStripMenuItem
            // 
            this.locarToolStripMenuItem.Name = "locarToolStripMenuItem";
            this.locarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.locarToolStripMenuItem.Text = "Locações";
            this.locarToolStripMenuItem.Click += new System.EventHandler(this.LocarToolStripMenuItem_Click);
            // 
            // devoluçãoToolStripMenuItem
            // 
            this.devoluçãoToolStripMenuItem.Name = "devoluçãoToolStripMenuItem";
            this.devoluçãoToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.devoluçãoToolStripMenuItem.Text = "Devoluções";
            this.devoluçãoToolStripMenuItem.Click += new System.EventHandler(this.DevoluçãoToolStripMenuItem_Click);
            // 
            // toolBoxAcoes
            // 
            this.toolBoxAcoes.AutoSize = false;
            this.toolBoxAcoes.BackColor = System.Drawing.SystemColors.Control;
            this.toolBoxAcoes.Enabled = false;
            this.toolBoxAcoes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolBoxAcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdicionar,
            this.btnEditar,
            this.btnExcluir,
            this.btnFiltrar,
            this.toolStripSeparador,
            this.labelTipoCadastro});
            this.toolBoxAcoes.Location = new System.Drawing.Point(0, 24);
            this.toolBoxAcoes.Name = "toolBoxAcoes";
            this.toolBoxAcoes.Size = new System.Drawing.Size(795, 45);
            this.toolBoxAcoes.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdicionar.Image = global::LocadoraDeVeiculos.WindowsApp.Properties.Resources._36x1;
            this.btnAdicionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(40, 42);
            this.btnAdicionar.Text = "btnAdicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
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
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
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
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFiltrar.Image = global::LocadoraDeVeiculos.WindowsApp.Properties.Resources.outline_filter_alt_black_36dp;
            this.btnFiltrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(40, 42);
            this.btnFiltrar.Text = "toolStripButton1";
            this.btnFiltrar.ToolTipText = "Filtrar elemento";
            this.btnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // toolStripSeparador
            // 
            this.toolStripSeparador.Name = "toolStripSeparador";
            this.toolStripSeparador.Size = new System.Drawing.Size(6, 45);
            // 
            // labelTipoCadastro
            // 
            this.labelTipoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelTipoCadastro.Name = "labelTipoCadastro";
            this.labelTipoCadastro.Size = new System.Drawing.Size(157, 42);
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
            this.panelRegistros.Size = new System.Drawing.Size(795, 491);
            this.panelRegistros.TabIndex = 6;
            // 
            // statusStripRodape
            // 
            this.statusStripRodape.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripRodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelRodape});
            this.statusStripRodape.Location = new System.Drawing.Point(0, 563);
            this.statusStripRodape.Name = "statusStripRodape";
            this.statusStripRodape.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStripRodape.Size = new System.Drawing.Size(795, 22);
            this.statusStripRodape.TabIndex = 7;
            this.statusStripRodape.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            this.labelRodape.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelRodape.Name = "labelRodape";
            this.labelRodape.Size = new System.Drawing.Size(73, 17);
            this.labelRodape.Text = "Tudo certo :D";
            // 
            // descontosToolStripMenuItem
            // 
            this.descontosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuponsToolStripMenuItem,
            this.parceirosToolStripMenuItem});
            this.descontosToolStripMenuItem.Name = "descontosToolStripMenuItem";
            this.descontosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.descontosToolStripMenuItem.Text = "Descontos";
            // 
            // cuponsToolStripMenuItem
            // 
            this.cuponsToolStripMenuItem.Name = "cuponsToolStripMenuItem";
            this.cuponsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cuponsToolStripMenuItem.Text = "Cupons";
            this.cuponsToolStripMenuItem.Click += new System.EventHandler(this.CuponsToolStripMenuItem_Click);
            // 
            // parceirosToolStripMenuItem
            // 
            this.parceirosToolStripMenuItem.Name = "parceirosToolStripMenuItem";
            this.parceirosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.parceirosToolStripMenuItem.Text = "Parceiros";
            this.parceirosToolStripMenuItem.Click += new System.EventHandler(this.ParceirosToolStripMenuItem_Click);
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(795, 585);
            this.Controls.Add(this.statusStripRodape);
            this.Controls.Add(this.panelRegistros);
            this.Controls.Add(this.toolBoxAcoes);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TelaPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripButton btnFiltrar;
        private System.Windows.Forms.ToolStripMenuItem inícioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descontosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuponsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parceirosToolStripMenuItem;
    }
}

