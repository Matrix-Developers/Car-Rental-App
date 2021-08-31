
namespace LocadoraDeVeiculos.WindowsApp.Features.Devolucoes
{
    partial class TelaDevolucaoForm
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.brnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gBoxLocacao = new System.Windows.Forms.GroupBox();
            this.txtKmInicial = new System.Windows.Forms.TextBox();
            this.lblServicosSelecionados = new System.Windows.Forms.Label();
            this.lblKmInicial = new System.Windows.Forms.Label();
            this.cLBoxServicosSelecionados = new System.Windows.Forms.CheckedListBox();
            this.txtDataDevolucao = new System.Windows.Forms.TextBox();
            this.txtDataLocacao = new System.Windows.Forms.TextBox();
            this.txtCondutor = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtPlano = new System.Windows.Forms.TextBox();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.lblPlano = new System.Windows.Forms.Label();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.lblDataDevolucao = new System.Windows.Forms.Label();
            this.lblDataLocacao = new System.Windows.Forms.Label();
            this.lblCondutor = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.gBoxDevolucao = new System.Windows.Forms.GroupBox();
            this.txtValorInicial = new System.Windows.Forms.TextBox();
            this.lblValorInicial = new System.Windows.Forms.Label();
            this.lblEncerrar = new System.Windows.Forms.Label();
            this.dtDevolucao = new System.Windows.Forms.DateTimePicker();
            this.rBtn01 = new System.Windows.Forms.RadioButton();
            this.lblFull = new System.Windows.Forms.Label();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.rBtn11 = new System.Windows.Forms.RadioButton();
            this.rBtn34 = new System.Windows.Forms.RadioButton();
            this.rBtn12 = new System.Windows.Forms.RadioButton();
            this.rBtn14 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKmFinal = new System.Windows.Forms.Label();
            this.txtKmFinal = new System.Windows.Forms.TextBox();
            this.lblServicos = new System.Windows.Forms.Label();
            this.btnSelecionarServicos = new System.Windows.Forms.Button();
            this.lblQtdTanque = new System.Windows.Forms.Label();
            this.cBoxQtdTanque = new System.Windows.Forms.ComboBox();
            this.lblValorCombustivel = new System.Windows.Forms.Label();
            this.txtValorCombustivel = new System.Windows.Forms.TextBox();
            this.gBoxLocacao.SuspendLayout();
            this.gBoxDevolucao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(476, 42);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Devolução de Veículo";
            // 
            // brnConfirmar
            // 
            this.brnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.brnConfirmar.Location = new System.Drawing.Point(972, 502);
            this.brnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.brnConfirmar.Name = "brnConfirmar";
            this.brnConfirmar.Size = new System.Drawing.Size(100, 28);
            this.brnConfirmar.TabIndex = 22;
            this.brnConfirmar.Text = "Confirmar";
            this.brnConfirmar.UseVisualStyleBackColor = true;
            this.brnConfirmar.Click += new System.EventHandler(this.brnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(1080, 502);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gBoxLocacao
            // 
            this.gBoxLocacao.Controls.Add(this.txtKmInicial);
            this.gBoxLocacao.Controls.Add(this.lblServicosSelecionados);
            this.gBoxLocacao.Controls.Add(this.lblKmInicial);
            this.gBoxLocacao.Controls.Add(this.cLBoxServicosSelecionados);
            this.gBoxLocacao.Controls.Add(this.txtDataDevolucao);
            this.gBoxLocacao.Controls.Add(this.txtDataLocacao);
            this.gBoxLocacao.Controls.Add(this.txtCondutor);
            this.gBoxLocacao.Controls.Add(this.txtCliente);
            this.gBoxLocacao.Controls.Add(this.txtPlano);
            this.gBoxLocacao.Controls.Add(this.txtVeiculo);
            this.gBoxLocacao.Controls.Add(this.txtFuncionario);
            this.gBoxLocacao.Controls.Add(this.lblPlano);
            this.gBoxLocacao.Controls.Add(this.lblVeiculo);
            this.gBoxLocacao.Controls.Add(this.lblDataDevolucao);
            this.gBoxLocacao.Controls.Add(this.lblDataLocacao);
            this.gBoxLocacao.Controls.Add(this.lblCondutor);
            this.gBoxLocacao.Controls.Add(this.lblCliente);
            this.gBoxLocacao.Controls.Add(this.lblFuncionario);
            this.gBoxLocacao.Controls.Add(this.lblId);
            this.gBoxLocacao.Controls.Add(this.txtId);
            this.gBoxLocacao.Enabled = false;
            this.gBoxLocacao.Location = new System.Drawing.Point(16, 102);
            this.gBoxLocacao.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxLocacao.Name = "gBoxLocacao";
            this.gBoxLocacao.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxLocacao.Size = new System.Drawing.Size(577, 384);
            this.gBoxLocacao.TabIndex = 20;
            this.gBoxLocacao.TabStop = false;
            this.gBoxLocacao.Text = "Dados da locação";
            // 
            // txtKmInicial
            // 
            this.txtKmInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKmInicial.Enabled = false;
            this.txtKmInicial.Location = new System.Drawing.Point(379, 23);
            this.txtKmInicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtKmInicial.Name = "txtKmInicial";
            this.txtKmInicial.Size = new System.Drawing.Size(187, 22);
            this.txtKmInicial.TabIndex = 25;
            // 
            // lblServicosSelecionados
            // 
            this.lblServicosSelecionados.AutoSize = true;
            this.lblServicosSelecionados.Location = new System.Drawing.Point(47, 251);
            this.lblServicosSelecionados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServicosSelecionados.Name = "lblServicosSelecionados";
            this.lblServicosSelecionados.Size = new System.Drawing.Size(62, 17);
            this.lblServicosSelecionados.TabIndex = 31;
            this.lblServicosSelecionados.Text = "Serviços";
            // 
            // lblKmInicial
            // 
            this.lblKmInicial.AutoSize = true;
            this.lblKmInicial.Location = new System.Drawing.Point(301, 27);
            this.lblKmInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKmInicial.Name = "lblKmInicial";
            this.lblKmInicial.Size = new System.Drawing.Size(67, 17);
            this.lblKmInicial.TabIndex = 24;
            this.lblKmInicial.Text = "Km Inicial";
            // 
            // cLBoxServicosSelecionados
            // 
            this.cLBoxServicosSelecionados.FormattingEnabled = true;
            this.cLBoxServicosSelecionados.Location = new System.Drawing.Point(119, 251);
            this.cLBoxServicosSelecionados.Margin = new System.Windows.Forms.Padding(4);
            this.cLBoxServicosSelecionados.Name = "cLBoxServicosSelecionados";
            this.cLBoxServicosSelecionados.Size = new System.Drawing.Size(449, 106);
            this.cLBoxServicosSelecionados.TabIndex = 30;
            // 
            // txtDataDevolucao
            // 
            this.txtDataDevolucao.Location = new System.Drawing.Point(379, 215);
            this.txtDataDevolucao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataDevolucao.Name = "txtDataDevolucao";
            this.txtDataDevolucao.Size = new System.Drawing.Size(189, 22);
            this.txtDataDevolucao.TabIndex = 25;
            // 
            // txtDataLocacao
            // 
            this.txtDataLocacao.Location = new System.Drawing.Point(119, 215);
            this.txtDataLocacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataLocacao.Name = "txtDataLocacao";
            this.txtDataLocacao.Size = new System.Drawing.Size(160, 22);
            this.txtDataLocacao.TabIndex = 29;
            // 
            // txtCondutor
            // 
            this.txtCondutor.Location = new System.Drawing.Point(119, 183);
            this.txtCondutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtCondutor.Name = "txtCondutor";
            this.txtCondutor.Size = new System.Drawing.Size(449, 22);
            this.txtCondutor.TabIndex = 28;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(119, 151);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(449, 22);
            this.txtCliente.TabIndex = 27;
            // 
            // txtPlano
            // 
            this.txtPlano.Location = new System.Drawing.Point(119, 119);
            this.txtPlano.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlano.Name = "txtPlano";
            this.txtPlano.Size = new System.Drawing.Size(449, 22);
            this.txtPlano.TabIndex = 26;
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(119, 87);
            this.txtVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(449, 22);
            this.txtVeiculo.TabIndex = 25;
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(119, 55);
            this.txtFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(449, 22);
            this.txtFuncionario.TabIndex = 16;
            // 
            // lblPlano
            // 
            this.lblPlano.AutoSize = true;
            this.lblPlano.Location = new System.Drawing.Point(65, 123);
            this.lblPlano.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlano.Name = "lblPlano";
            this.lblPlano.Size = new System.Drawing.Size(44, 17);
            this.lblPlano.TabIndex = 13;
            this.lblPlano.Text = "Plano";
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Location = new System.Drawing.Point(52, 91);
            this.lblVeiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(54, 17);
            this.lblVeiculo.TabIndex = 12;
            this.lblVeiculo.Text = "Veículo";
            // 
            // lblDataDevolucao
            // 
            this.lblDataDevolucao.AutoSize = true;
            this.lblDataDevolucao.Location = new System.Drawing.Point(307, 219);
            this.lblDataDevolucao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataDevolucao.Name = "lblDataDevolucao";
            this.lblDataDevolucao.Size = new System.Drawing.Size(63, 17);
            this.lblDataDevolucao.TabIndex = 11;
            this.lblDataDevolucao.Text = "Previsao";
            // 
            // lblDataLocacao
            // 
            this.lblDataLocacao.AutoSize = true;
            this.lblDataLocacao.Location = new System.Drawing.Point(45, 219);
            this.lblDataLocacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataLocacao.Name = "lblDataLocacao";
            this.lblDataLocacao.Size = new System.Drawing.Size(62, 17);
            this.lblDataLocacao.TabIndex = 10;
            this.lblDataLocacao.Text = "Locação";
            // 
            // lblCondutor
            // 
            this.lblCondutor.AutoSize = true;
            this.lblCondutor.Location = new System.Drawing.Point(44, 187);
            this.lblCondutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCondutor.Name = "lblCondutor";
            this.lblCondutor.Size = new System.Drawing.Size(66, 17);
            this.lblCondutor.TabIndex = 9;
            this.lblCondutor.Text = "Condutor";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(59, 155);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 17);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(28, 59);
            this.lblFuncionario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(82, 17);
            this.lblFuncionario.TabIndex = 7;
            this.lblFuncionario.Text = "Funcionário";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(87, 27);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 17);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(119, 23);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(160, 22);
            this.txtId.TabIndex = 2;
            this.txtId.Text = "0";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(436, 342);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(132, 22);
            this.txtTotal.TabIndex = 17;
            this.txtTotal.Text = "0";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(287, 342);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(141, 20);
            this.lblValorTotal.TabIndex = 2;
            this.lblValorTotal.Text = "Preço Total: R$";
            // 
            // gBoxDevolucao
            // 
            this.gBoxDevolucao.Controls.Add(this.txtValorInicial);
            this.gBoxDevolucao.Controls.Add(this.lblValorInicial);
            this.gBoxDevolucao.Controls.Add(this.lblEncerrar);
            this.gBoxDevolucao.Controls.Add(this.dtDevolucao);
            this.gBoxDevolucao.Controls.Add(this.rBtn01);
            this.gBoxDevolucao.Controls.Add(this.lblFull);
            this.gBoxDevolucao.Controls.Add(this.lblEmpty);
            this.gBoxDevolucao.Controls.Add(this.rBtn11);
            this.gBoxDevolucao.Controls.Add(this.rBtn34);
            this.gBoxDevolucao.Controls.Add(this.rBtn12);
            this.gBoxDevolucao.Controls.Add(this.rBtn14);
            this.gBoxDevolucao.Controls.Add(this.pictureBox1);
            this.gBoxDevolucao.Controls.Add(this.lblKmFinal);
            this.gBoxDevolucao.Controls.Add(this.txtKmFinal);
            this.gBoxDevolucao.Controls.Add(this.lblServicos);
            this.gBoxDevolucao.Controls.Add(this.btnSelecionarServicos);
            this.gBoxDevolucao.Controls.Add(this.lblQtdTanque);
            this.gBoxDevolucao.Controls.Add(this.cBoxQtdTanque);
            this.gBoxDevolucao.Controls.Add(this.lblValorCombustivel);
            this.gBoxDevolucao.Controls.Add(this.txtValorCombustivel);
            this.gBoxDevolucao.Controls.Add(this.txtTotal);
            this.gBoxDevolucao.Controls.Add(this.lblValorTotal);
            this.gBoxDevolucao.Location = new System.Drawing.Point(601, 102);
            this.gBoxDevolucao.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxDevolucao.Name = "gBoxDevolucao";
            this.gBoxDevolucao.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxDevolucao.Size = new System.Drawing.Size(577, 384);
            this.gBoxDevolucao.TabIndex = 24;
            this.gBoxDevolucao.TabStop = false;
            this.gBoxDevolucao.Text = "Devolução";
            // 
            // txtValorInicial
            // 
            this.txtValorInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtValorInicial.Enabled = false;
            this.txtValorInicial.Location = new System.Drawing.Point(436, 310);
            this.txtValorInicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorInicial.Name = "txtValorInicial";
            this.txtValorInicial.Size = new System.Drawing.Size(132, 22);
            this.txtValorInicial.TabIndex = 35;
            this.txtValorInicial.Text = "0";
            // 
            // lblValorInicial
            // 
            this.lblValorInicial.AutoSize = true;
            this.lblValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorInicial.Location = new System.Drawing.Point(287, 312);
            this.lblValorInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorInicial.Name = "lblValorInicial";
            this.lblValorInicial.Size = new System.Drawing.Size(144, 20);
            this.lblValorInicial.TabIndex = 34;
            this.lblValorInicial.Text = "Valor Inicial: R$";
            // 
            // lblEncerrar
            // 
            this.lblEncerrar.AutoSize = true;
            this.lblEncerrar.Location = new System.Drawing.Point(11, 267);
            this.lblEncerrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncerrar.Name = "lblEncerrar";
            this.lblEncerrar.Size = new System.Drawing.Size(75, 17);
            this.lblEncerrar.TabIndex = 33;
            this.lblEncerrar.Text = "Devolução";
            // 
            // dtDevolucao
            // 
            this.dtDevolucao.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDevolucao.Location = new System.Drawing.Point(97, 263);
            this.dtDevolucao.Margin = new System.Windows.Forms.Padding(4);
            this.dtDevolucao.Name = "dtDevolucao";
            this.dtDevolucao.Size = new System.Drawing.Size(171, 22);
            this.dtDevolucao.TabIndex = 32;
            // 
            // rBtn01
            // 
            this.rBtn01.AutoSize = true;
            this.rBtn01.Location = new System.Drawing.Point(150, 195);
            this.rBtn01.Margin = new System.Windows.Forms.Padding(4);
            this.rBtn01.Name = "rBtn01";
            this.rBtn01.Size = new System.Drawing.Size(17, 16);
            this.rBtn01.TabIndex = 25;
            this.rBtn01.TabStop = true;
            this.rBtn01.UseVisualStyleBackColor = true;
            this.rBtn01.CheckedChanged += new System.EventHandler(this.rBtn01_CheckedChanged);
            // 
            // lblFull
            // 
            this.lblFull.AutoSize = true;
            this.lblFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFull.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFull.Location = new System.Drawing.Point(169, 218);
            this.lblFull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFull.Name = "lblFull";
            this.lblFull.Size = new System.Drawing.Size(20, 20);
            this.lblFull.TabIndex = 31;
            this.lblFull.Text = "F";
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblEmpty.Location = new System.Drawing.Point(420, 212);
            this.lblEmpty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(21, 20);
            this.lblEmpty.TabIndex = 30;
            this.lblEmpty.Text = "E";
            // 
            // rBtn11
            // 
            this.rBtn11.AutoSize = true;
            this.rBtn11.Location = new System.Drawing.Point(432, 195);
            this.rBtn11.Margin = new System.Windows.Forms.Padding(4);
            this.rBtn11.Name = "rBtn11";
            this.rBtn11.Size = new System.Drawing.Size(17, 16);
            this.rBtn11.TabIndex = 29;
            this.rBtn11.TabStop = true;
            this.rBtn11.UseVisualStyleBackColor = true;
            this.rBtn11.CheckedChanged += new System.EventHandler(this.rBtn11_CheckedChanged);
            // 
            // rBtn34
            // 
            this.rBtn34.AutoSize = true;
            this.rBtn34.Location = new System.Drawing.Point(372, 144);
            this.rBtn34.Margin = new System.Windows.Forms.Padding(4);
            this.rBtn34.Name = "rBtn34";
            this.rBtn34.Size = new System.Drawing.Size(17, 16);
            this.rBtn34.TabIndex = 28;
            this.rBtn34.TabStop = true;
            this.rBtn34.UseVisualStyleBackColor = true;
            this.rBtn34.CheckedChanged += new System.EventHandler(this.rBtn34_CheckedChanged);
            // 
            // rBtn12
            // 
            this.rBtn12.AutoSize = true;
            this.rBtn12.Location = new System.Drawing.Point(291, 125);
            this.rBtn12.Margin = new System.Windows.Forms.Padding(4);
            this.rBtn12.Name = "rBtn12";
            this.rBtn12.Size = new System.Drawing.Size(17, 16);
            this.rBtn12.TabIndex = 27;
            this.rBtn12.TabStop = true;
            this.rBtn12.UseVisualStyleBackColor = true;
            this.rBtn12.CheckedChanged += new System.EventHandler(this.rBtn12_CheckedChanged);
            // 
            // rBtn14
            // 
            this.rBtn14.AutoSize = true;
            this.rBtn14.Location = new System.Drawing.Point(211, 144);
            this.rBtn14.Margin = new System.Windows.Forms.Padding(4);
            this.rBtn14.Name = "rBtn14";
            this.rBtn14.Size = new System.Drawing.Size(17, 16);
            this.rBtn14.TabIndex = 26;
            this.rBtn14.TabStop = true;
            this.rBtn14.UseVisualStyleBackColor = true;
            this.rBtn14.CheckedChanged += new System.EventHandler(this.rBtn14_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LocadoraDeVeiculos.WindowsApp.Properties.Resources.FuelGauge1;
            this.pictureBox1.Location = new System.Drawing.Point(163, 141);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lblKmFinal
            // 
            this.lblKmFinal.AutoSize = true;
            this.lblKmFinal.Location = new System.Drawing.Point(11, 58);
            this.lblKmFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKmFinal.Name = "lblKmFinal";
            this.lblKmFinal.Size = new System.Drawing.Size(77, 17);
            this.lblKmFinal.TabIndex = 25;
            this.lblKmFinal.Text = "Km rodado";
            // 
            // txtKmFinal
            // 
            this.txtKmFinal.Location = new System.Drawing.Point(96, 55);
            this.txtKmFinal.Margin = new System.Windows.Forms.Padding(4);
            this.txtKmFinal.Name = "txtKmFinal";
            this.txtKmFinal.Size = new System.Drawing.Size(187, 22);
            this.txtKmFinal.TabIndex = 24;
            this.txtKmFinal.Text = "0";
            this.txtKmFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKmFinal_KeyPress);
            // 
            // lblServicos
            // 
            this.lblServicos.AutoSize = true;
            this.lblServicos.Location = new System.Drawing.Point(320, 58);
            this.lblServicos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServicos.Name = "lblServicos";
            this.lblServicos.Size = new System.Drawing.Size(130, 17);
            this.lblServicos.TabIndex = 23;
            this.lblServicos.Text = "Serviços Adicionais";
            // 
            // btnSelecionarServicos
            // 
            this.btnSelecionarServicos.Location = new System.Drawing.Point(458, 53);
            this.btnSelecionarServicos.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionarServicos.Name = "btnSelecionarServicos";
            this.btnSelecionarServicos.Size = new System.Drawing.Size(100, 28);
            this.btnSelecionarServicos.TabIndex = 22;
            this.btnSelecionarServicos.Text = "Selecionar";
            this.btnSelecionarServicos.UseVisualStyleBackColor = true;
            this.btnSelecionarServicos.Click += new System.EventHandler(this.btnSelecionarServicos_Click);
            // 
            // lblQtdTanque
            // 
            this.lblQtdTanque.AutoSize = true;
            this.lblQtdTanque.Location = new System.Drawing.Point(362, 98);
            this.lblQtdTanque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdTanque.Name = "lblQtdTanque";
            this.lblQtdTanque.Size = new System.Drawing.Size(88, 17);
            this.lblQtdTanque.TabIndex = 21;
            this.lblQtdTanque.Text = "Qtd. Tanque";
            // 
            // cBoxQtdTanque
            // 
            this.cBoxQtdTanque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxQtdTanque.FormattingEnabled = true;
            this.cBoxQtdTanque.Items.AddRange(new object[] {
            "0/1",
            "1/4",
            "1/2",
            "3/4",
            "1/1"});
            this.cBoxQtdTanque.Location = new System.Drawing.Point(458, 98);
            this.cBoxQtdTanque.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxQtdTanque.Name = "cBoxQtdTanque";
            this.cBoxQtdTanque.Size = new System.Drawing.Size(99, 24);
            this.cBoxQtdTanque.TabIndex = 20;
            this.cBoxQtdTanque.SelectedIndexChanged += new System.EventHandler(this.cBoxQtdTanque_SelectedIndexChanged);
            // 
            // lblValorCombustivel
            // 
            this.lblValorCombustivel.AutoSize = true;
            this.lblValorCombustivel.Location = new System.Drawing.Point(11, 98);
            this.lblValorCombustivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorCombustivel.Name = "lblValorCombustivel";
            this.lblValorCombustivel.Size = new System.Drawing.Size(163, 17);
            this.lblValorCombustivel.TabIndex = 19;
            this.lblValorCombustivel.Text = "Valor do Combustivel R$";
            // 
            // txtValorCombustivel
            // 
            this.txtValorCombustivel.Location = new System.Drawing.Point(182, 98);
            this.txtValorCombustivel.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorCombustivel.Name = "txtValorCombustivel";
            this.txtValorCombustivel.Size = new System.Drawing.Size(99, 22);
            this.txtValorCombustivel.TabIndex = 18;
            this.txtValorCombustivel.Text = "0";
            this.txtValorCombustivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorCombustivel_KeyPress);
            // 
            // TelaDevolucaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 545);
            this.Controls.Add(this.gBoxDevolucao);
            this.Controls.Add(this.brnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gBoxLocacao);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaDevolucaoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "TelaDevolucaoForm";
            this.gBoxLocacao.ResumeLayout(false);
            this.gBoxLocacao.PerformLayout();
            this.gBoxDevolucao.ResumeLayout(false);
            this.gBoxDevolucao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button brnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gBoxLocacao;
        private System.Windows.Forms.Label lblServicosSelecionados;
        private System.Windows.Forms.CheckedListBox cLBoxServicosSelecionados;
        private System.Windows.Forms.TextBox txtDataDevolucao;
        private System.Windows.Forms.TextBox txtDataLocacao;
        private System.Windows.Forms.TextBox txtCondutor;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtPlano;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Label lblPlano;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label lblDataDevolucao;
        private System.Windows.Forms.Label lblDataLocacao;
        private System.Windows.Forms.Label lblCondutor;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.GroupBox gBoxDevolucao;
        private System.Windows.Forms.Label lblServicos;
        private System.Windows.Forms.Button btnSelecionarServicos;
        private System.Windows.Forms.Label lblQtdTanque;
        private System.Windows.Forms.ComboBox cBoxQtdTanque;
        private System.Windows.Forms.Label lblValorCombustivel;
        private System.Windows.Forms.TextBox txtValorCombustivel;
        private System.Windows.Forms.TextBox txtKmInicial;
        private System.Windows.Forms.Label lblKmInicial;
        private System.Windows.Forms.Label lblKmFinal;
        private System.Windows.Forms.TextBox txtKmFinal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFull;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.RadioButton rBtn01;
        private System.Windows.Forms.RadioButton rBtn14;
        private System.Windows.Forms.RadioButton rBtn12;
        private System.Windows.Forms.RadioButton rBtn34;
        private System.Windows.Forms.RadioButton rBtn11;
        private System.Windows.Forms.Label lblEncerrar;
        private System.Windows.Forms.DateTimePicker dtDevolucao;
        private System.Windows.Forms.Label lblValorInicial;
        private System.Windows.Forms.TextBox txtValorInicial;
    }
}