
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
            labelTitulo = new System.Windows.Forms.Label();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            veiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            grupoDeVeículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            inícioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            locaçaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            locarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            devoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            descontosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cuponsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            parceirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolBoxAcoes = new System.Windows.Forms.ToolStrip();
            btnAdicionar = new System.Windows.Forms.ToolStripButton();
            btnEditar = new System.Windows.Forms.ToolStripButton();
            btnExcluir = new System.Windows.Forms.ToolStripButton();
            btnFiltrar = new System.Windows.Forms.ToolStripButton();
            toolStripSeparador = new System.Windows.Forms.ToolStripSeparator();
            labelTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            panelRegistros = new System.Windows.Forms.Panel();
            statusStripRodape = new System.Windows.Forms.StatusStrip();
            labelRodape = new System.Windows.Forms.ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolBoxAcoes.SuspendLayout();
            statusStripRodape.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = System.Drawing.Color.Black;
            labelTitulo.Location = new System.Drawing.Point(412, 5);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new System.Drawing.Size(221, 25);
            labelTitulo.TabIndex = 3;
            labelTitulo.Text = "Locadora de Veículos";
            labelTitulo.UseWaitCursor = true;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { funcionáriosToolStripMenuItem, clientesToolStripMenuItem, serviçosToolStripMenuItem, veiculosToolStripMenuItem, grupoDeVeículosToolStripMenuItem });
            toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(86, 24);
            toolStripMenuItem1.Text = "Cadastros";
            // 
            // funcionáriosToolStripMenuItem
            // 
            funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            funcionáriosToolStripMenuItem.Text = "Funcionários";
            funcionáriosToolStripMenuItem.Click += FuncionariosToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += ClientesToolStripMenuItem_Click;
            // 
            // serviçosToolStripMenuItem
            // 
            serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            serviçosToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            serviçosToolStripMenuItem.Text = "Serviços";
            serviçosToolStripMenuItem.Click += ServicosToolStripMenuItem_Click;
            // 
            // veiculosToolStripMenuItem
            // 
            veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
            veiculosToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            veiculosToolStripMenuItem.Text = "Veiculos";
            veiculosToolStripMenuItem.Click += VeiculosToolStripMenuItem_Click;
            // 
            // grupoDeVeículosToolStripMenuItem
            // 
            grupoDeVeículosToolStripMenuItem.Name = "grupoDeVeículosToolStripMenuItem";
            grupoDeVeículosToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            grupoDeVeículosToolStripMenuItem.Text = "Grupo de Veículos";
            grupoDeVeículosToolStripMenuItem.Click += GrupoDeVeículosToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { inícioToolStripMenuItem, toolStripMenuItem1, locaçaoToolStripMenuItem, descontosToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(5, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1060, 30);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // inícioToolStripMenuItem
            // 
            inícioToolStripMenuItem.Name = "inícioToolStripMenuItem";
            inícioToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            inícioToolStripMenuItem.Text = "Início";
            inícioToolStripMenuItem.Click += InícioToolStripMenuItem_Click;
            // 
            // locaçaoToolStripMenuItem
            // 
            locaçaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { locarToolStripMenuItem, devoluçãoToolStripMenuItem });
            locaçaoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            locaçaoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            locaçaoToolStripMenuItem.Name = "locaçaoToolStripMenuItem";
            locaçaoToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            locaçaoToolStripMenuItem.Text = "Locaçao";
            // 
            // locarToolStripMenuItem
            // 
            locarToolStripMenuItem.Name = "locarToolStripMenuItem";
            locarToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            locarToolStripMenuItem.Text = "Locações";
            locarToolStripMenuItem.Click += LocarToolStripMenuItem_Click;
            // 
            // devoluçãoToolStripMenuItem
            // 
            devoluçãoToolStripMenuItem.Name = "devoluçãoToolStripMenuItem";
            devoluçãoToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            devoluçãoToolStripMenuItem.Text = "Devoluções";
            devoluçãoToolStripMenuItem.Click += DevoluçãoToolStripMenuItem_Click;
            // 
            // descontosToolStripMenuItem
            // 
            descontosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cuponsToolStripMenuItem, parceirosToolStripMenuItem });
            descontosToolStripMenuItem.Name = "descontosToolStripMenuItem";
            descontosToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            descontosToolStripMenuItem.Text = "Descontos";
            // 
            // cuponsToolStripMenuItem
            // 
            cuponsToolStripMenuItem.Name = "cuponsToolStripMenuItem";
            cuponsToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            cuponsToolStripMenuItem.Text = "Cupons";
            cuponsToolStripMenuItem.Click += CuponsToolStripMenuItem_Click;
            // 
            // parceirosToolStripMenuItem
            // 
            parceirosToolStripMenuItem.Name = "parceirosToolStripMenuItem";
            parceirosToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            parceirosToolStripMenuItem.Text = "Parceiros";
            parceirosToolStripMenuItem.Click += ParceirosToolStripMenuItem_Click;
            // 
            // toolBoxAcoes
            // 
            toolBoxAcoes.AutoSize = false;
            toolBoxAcoes.BackColor = System.Drawing.SystemColors.Control;
            toolBoxAcoes.Enabled = false;
            toolBoxAcoes.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolBoxAcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, btnFiltrar, toolStripSeparador, labelTipoCadastro });
            toolBoxAcoes.Location = new System.Drawing.Point(0, 30);
            toolBoxAcoes.Name = "toolBoxAcoes";
            toolBoxAcoes.Size = new System.Drawing.Size(1060, 69);
            toolBoxAcoes.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnAdicionar.Image = Properties.Resources._36x1;
            btnAdicionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new System.Drawing.Size(40, 66);
            btnAdicionar.Text = "btnAdicionar";
            btnAdicionar.Click += BtnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnEditar.Image = (System.Drawing.Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(40, 66);
            btnEditar.Text = "btnEditar";
            btnEditar.Click += BtnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = (System.Drawing.Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new System.Drawing.Size(40, 66);
            btnExcluir.Text = "toolStripButton1";
            btnExcluir.Click += BtnExcluir_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnFiltrar.Image = Properties.Resources.outline_filter_alt_black_36dp;
            btnFiltrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new System.Drawing.Size(40, 66);
            btnFiltrar.Text = "toolStripButton1";
            btnFiltrar.ToolTipText = "Filtrar elemento";
            btnFiltrar.Click += BtnFiltrar_Click;
            // 
            // toolStripSeparador
            // 
            toolStripSeparador.Name = "toolStripSeparador";
            toolStripSeparador.Size = new System.Drawing.Size(6, 69);
            // 
            // labelTipoCadastro
            // 
            labelTipoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            labelTipoCadastro.Name = "labelTipoCadastro";
            labelTipoCadastro.Size = new System.Drawing.Size(208, 66);
            labelTipoCadastro.Text = "Cadastro Selecionado: Nenhum";
            // 
            // panelRegistros
            // 
            panelRegistros.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelRegistros.Location = new System.Drawing.Point(0, 108);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new System.Drawing.Size(1060, 755);
            panelRegistros.TabIndex = 6;
            // 
            // statusStripRodape
            // 
            statusStripRodape.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStripRodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { labelRodape });
            statusStripRodape.Location = new System.Drawing.Point(0, 877);
            statusStripRodape.Name = "statusStripRodape";
            statusStripRodape.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            statusStripRodape.Size = new System.Drawing.Size(1060, 23);
            statusStripRodape.TabIndex = 7;
            statusStripRodape.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            labelRodape.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            labelRodape.Name = "labelRodape";
            labelRodape.Size = new System.Drawing.Size(95, 17);
            labelRodape.Text = "Tudo certo :D";
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(1060, 900);
            Controls.Add(statusStripRodape);
            Controls.Add(panelRegistros);
            Controls.Add(toolBoxAcoes);
            Controls.Add(labelTitulo);
            Controls.Add(menuStrip1);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "TelaPrincipalForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Locadora de veículos ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolBoxAcoes.ResumeLayout(false);
            toolBoxAcoes.PerformLayout();
            statusStripRodape.ResumeLayout(false);
            statusStripRodape.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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

