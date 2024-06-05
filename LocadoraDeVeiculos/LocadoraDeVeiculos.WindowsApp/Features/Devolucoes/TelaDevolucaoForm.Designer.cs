
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
            lblTitulo = new System.Windows.Forms.Label();
            brnConfirmar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            gBoxLocacao = new System.Windows.Forms.GroupBox();
            txtKmInicial = new System.Windows.Forms.TextBox();
            lblServicosSelecionados = new System.Windows.Forms.Label();
            lblKmInicial = new System.Windows.Forms.Label();
            cLBoxServicosSelecionados = new System.Windows.Forms.CheckedListBox();
            txtDataDevolucao = new System.Windows.Forms.TextBox();
            txtDataLocacao = new System.Windows.Forms.TextBox();
            txtCondutor = new System.Windows.Forms.TextBox();
            txtCliente = new System.Windows.Forms.TextBox();
            txtPlano = new System.Windows.Forms.TextBox();
            txtVeiculo = new System.Windows.Forms.TextBox();
            txtFuncionario = new System.Windows.Forms.TextBox();
            lblPlano = new System.Windows.Forms.Label();
            lblVeiculo = new System.Windows.Forms.Label();
            lblDataDevolucao = new System.Windows.Forms.Label();
            lblDataLocacao = new System.Windows.Forms.Label();
            lblCondutor = new System.Windows.Forms.Label();
            lblCliente = new System.Windows.Forms.Label();
            lblFuncionario = new System.Windows.Forms.Label();
            lblId = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            txtValorTotal = new System.Windows.Forms.TextBox();
            lblValorTotal = new System.Windows.Forms.Label();
            gBoxDevolucao = new System.Windows.Forms.GroupBox();
            txtValorInicial = new System.Windows.Forms.TextBox();
            lblValorInicial = new System.Windows.Forms.Label();
            lblEncerrar = new System.Windows.Forms.Label();
            dtDevolucao = new System.Windows.Forms.DateTimePicker();
            rBtn01 = new System.Windows.Forms.RadioButton();
            lblFull = new System.Windows.Forms.Label();
            lblEmpty = new System.Windows.Forms.Label();
            rBtn11 = new System.Windows.Forms.RadioButton();
            rBtn34 = new System.Windows.Forms.RadioButton();
            rBtn12 = new System.Windows.Forms.RadioButton();
            rBtn14 = new System.Windows.Forms.RadioButton();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblKmFinal = new System.Windows.Forms.Label();
            txtKmFinal = new System.Windows.Forms.TextBox();
            lblServicos = new System.Windows.Forms.Label();
            btnSelecionarServicos = new System.Windows.Forms.Button();
            lblQtdTanque = new System.Windows.Forms.Label();
            cBoxQtdTanque = new System.Windows.Forms.ComboBox();
            lblValorCombustivel = new System.Windows.Forms.Label();
            txtValorCombustivel = new System.Windows.Forms.TextBox();
            gBoxLocacao.SuspendLayout();
            gBoxDevolucao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitulo.Location = new System.Drawing.Point(483, 51);
            lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(192, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Vehicle Devolution";
            // 
            // brnConfirmar
            // 
            brnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            brnConfirmar.Location = new System.Drawing.Point(972, 628);
            brnConfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            brnConfirmar.Name = "brnConfirmar";
            brnConfirmar.Size = new System.Drawing.Size(100, 35);
            brnConfirmar.TabIndex = 22;
            brnConfirmar.Text = "Confirmar";
            brnConfirmar.UseVisualStyleBackColor = true;
            brnConfirmar.Click += BrnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancelar.Location = new System.Drawing.Point(1080, 628);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(100, 35);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gBoxLocacao
            // 
            gBoxLocacao.Controls.Add(txtKmInicial);
            gBoxLocacao.Controls.Add(lblServicosSelecionados);
            gBoxLocacao.Controls.Add(lblKmInicial);
            gBoxLocacao.Controls.Add(cLBoxServicosSelecionados);
            gBoxLocacao.Controls.Add(txtDataDevolucao);
            gBoxLocacao.Controls.Add(txtDataLocacao);
            gBoxLocacao.Controls.Add(txtCondutor);
            gBoxLocacao.Controls.Add(txtCliente);
            gBoxLocacao.Controls.Add(txtPlano);
            gBoxLocacao.Controls.Add(txtVeiculo);
            gBoxLocacao.Controls.Add(txtFuncionario);
            gBoxLocacao.Controls.Add(lblPlano);
            gBoxLocacao.Controls.Add(lblVeiculo);
            gBoxLocacao.Controls.Add(lblDataDevolucao);
            gBoxLocacao.Controls.Add(lblDataLocacao);
            gBoxLocacao.Controls.Add(lblCondutor);
            gBoxLocacao.Controls.Add(lblCliente);
            gBoxLocacao.Controls.Add(lblFuncionario);
            gBoxLocacao.Controls.Add(lblId);
            gBoxLocacao.Controls.Add(txtId);
            gBoxLocacao.Enabled = false;
            gBoxLocacao.Location = new System.Drawing.Point(16, 128);
            gBoxLocacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            gBoxLocacao.Name = "gBoxLocacao";
            gBoxLocacao.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            gBoxLocacao.Size = new System.Drawing.Size(577, 480);
            gBoxLocacao.TabIndex = 20;
            gBoxLocacao.TabStop = false;
            gBoxLocacao.Text = "Rental data";
            // 
            // txtKmInicial
            // 
            txtKmInicial.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            txtKmInicial.Enabled = false;
            txtKmInicial.Location = new System.Drawing.Point(406, 29);
            txtKmInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtKmInicial.Name = "txtKmInicial";
            txtKmInicial.Size = new System.Drawing.Size(160, 27);
            txtKmInicial.TabIndex = 25;
            // 
            // lblServicosSelecionados
            // 
            lblServicosSelecionados.AutoSize = true;
            lblServicosSelecionados.Location = new System.Drawing.Point(47, 314);
            lblServicosSelecionados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblServicosSelecionados.Name = "lblServicosSelecionados";
            lblServicosSelecionados.Size = new System.Drawing.Size(62, 20);
            lblServicosSelecionados.TabIndex = 31;
            lblServicosSelecionados.Text = "Services";
            // 
            // lblKmInicial
            // 
            lblKmInicial.AutoSize = true;
            lblKmInicial.Location = new System.Drawing.Point(300, 34);
            lblKmInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblKmInicial.Name = "lblKmInicial";
            lblKmInicial.Size = new System.Drawing.Size(104, 20);
            lblKmInicial.TabIndex = 24;
            lblKmInicial.Text = "Initial Mileage";
            // 
            // cLBoxServicosSelecionados
            // 
            cLBoxServicosSelecionados.FormattingEnabled = true;
            cLBoxServicosSelecionados.Location = new System.Drawing.Point(119, 314);
            cLBoxServicosSelecionados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cLBoxServicosSelecionados.Name = "cLBoxServicosSelecionados";
            cLBoxServicosSelecionados.Size = new System.Drawing.Size(449, 114);
            cLBoxServicosSelecionados.TabIndex = 30;
            // 
            // txtDataDevolucao
            // 
            txtDataDevolucao.Location = new System.Drawing.Point(406, 269);
            txtDataDevolucao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtDataDevolucao.Name = "txtDataDevolucao";
            txtDataDevolucao.Size = new System.Drawing.Size(162, 27);
            txtDataDevolucao.TabIndex = 25;
            // 
            // txtDataLocacao
            // 
            txtDataLocacao.Location = new System.Drawing.Point(119, 269);
            txtDataLocacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtDataLocacao.Name = "txtDataLocacao";
            txtDataLocacao.Size = new System.Drawing.Size(160, 27);
            txtDataLocacao.TabIndex = 29;
            // 
            // txtCondutor
            // 
            txtCondutor.Location = new System.Drawing.Point(119, 229);
            txtCondutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtCondutor.Name = "txtCondutor";
            txtCondutor.Size = new System.Drawing.Size(449, 27);
            txtCondutor.TabIndex = 28;
            // 
            // txtCliente
            // 
            txtCliente.Location = new System.Drawing.Point(119, 189);
            txtCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new System.Drawing.Size(449, 27);
            txtCliente.TabIndex = 27;
            // 
            // txtPlano
            // 
            txtPlano.Location = new System.Drawing.Point(119, 149);
            txtPlano.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPlano.Name = "txtPlano";
            txtPlano.Size = new System.Drawing.Size(449, 27);
            txtPlano.TabIndex = 26;
            // 
            // txtVeiculo
            // 
            txtVeiculo.Location = new System.Drawing.Point(119, 109);
            txtVeiculo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtVeiculo.Name = "txtVeiculo";
            txtVeiculo.Size = new System.Drawing.Size(449, 27);
            txtVeiculo.TabIndex = 25;
            // 
            // txtFuncionario
            // 
            txtFuncionario.Location = new System.Drawing.Point(119, 69);
            txtFuncionario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtFuncionario.Name = "txtFuncionario";
            txtFuncionario.Size = new System.Drawing.Size(449, 27);
            txtFuncionario.TabIndex = 16;
            // 
            // lblPlano
            // 
            lblPlano.AutoSize = true;
            lblPlano.Location = new System.Drawing.Point(65, 154);
            lblPlano.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPlano.Name = "lblPlano";
            lblPlano.Size = new System.Drawing.Size(46, 20);
            lblPlano.TabIndex = 13;
            lblPlano.Text = "Plano";
            // 
            // lblVeiculo
            // 
            lblVeiculo.AutoSize = true;
            lblVeiculo.Location = new System.Drawing.Point(53, 116);
            lblVeiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVeiculo.Name = "lblVeiculo";
            lblVeiculo.Size = new System.Drawing.Size(56, 20);
            lblVeiculo.TabIndex = 12;
            lblVeiculo.Text = "Vehicle";
            // 
            // lblDataDevolucao
            // 
            lblDataDevolucao.AutoSize = true;
            lblDataDevolucao.Location = new System.Drawing.Point(287, 274);
            lblDataDevolucao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDataDevolucao.Name = "lblDataDevolucao";
            lblDataDevolucao.Size = new System.Drawing.Size(117, 20);
            lblDataDevolucao.TabIndex = 11;
            lblDataDevolucao.Text = "Expected Return";
            // 
            // lblDataLocacao
            // 
            lblDataLocacao.AutoSize = true;
            lblDataLocacao.Location = new System.Drawing.Point(58, 274);
            lblDataLocacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDataLocacao.Name = "lblDataLocacao";
            lblDataLocacao.Size = new System.Drawing.Size(51, 20);
            lblDataLocacao.TabIndex = 10;
            lblDataLocacao.Text = "Rental";
            // 
            // lblCondutor
            // 
            lblCondutor.AutoSize = true;
            lblCondutor.Location = new System.Drawing.Point(31, 232);
            lblCondutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCondutor.Name = "lblCondutor";
            lblCondutor.Size = new System.Drawing.Size(78, 20);
            lblCondutor.TabIndex = 9;
            lblCondutor.Text = "Conductor";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new System.Drawing.Point(62, 196);
            lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new System.Drawing.Size(47, 20);
            lblCliente.TabIndex = 8;
            lblCliente.Text = "Client";
            // 
            // lblFuncionario
            // 
            lblFuncionario.AutoSize = true;
            lblFuncionario.Location = new System.Drawing.Point(34, 73);
            lblFuncionario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new System.Drawing.Size(75, 20);
            lblFuncionario.TabIndex = 7;
            lblFuncionario.Text = "Employee";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(87, 34);
            lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(24, 20);
            lblId.TabIndex = 6;
            lblId.Text = "ID";
            // 
            // txtId
            // 
            txtId.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            txtId.Enabled = false;
            txtId.Location = new System.Drawing.Point(119, 29);
            txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(160, 27);
            txtId.TabIndex = 2;
            txtId.Text = "0";
            // 
            // txtValorTotal
            // 
            txtValorTotal.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            txtValorTotal.Enabled = false;
            txtValorTotal.Location = new System.Drawing.Point(436, 428);
            txtValorTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new System.Drawing.Size(132, 27);
            txtValorTotal.TabIndex = 17;
            txtValorTotal.Text = "0";
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblValorTotal.Location = new System.Drawing.Point(287, 428);
            lblValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new System.Drawing.Size(139, 20);
            lblValorTotal.TabIndex = 2;
            lblValorTotal.Text = "Total Value: R$";
            // 
            // gBoxDevolucao
            // 
            gBoxDevolucao.Controls.Add(txtValorInicial);
            gBoxDevolucao.Controls.Add(lblValorInicial);
            gBoxDevolucao.Controls.Add(lblEncerrar);
            gBoxDevolucao.Controls.Add(dtDevolucao);
            gBoxDevolucao.Controls.Add(rBtn01);
            gBoxDevolucao.Controls.Add(lblFull);
            gBoxDevolucao.Controls.Add(lblEmpty);
            gBoxDevolucao.Controls.Add(rBtn11);
            gBoxDevolucao.Controls.Add(rBtn34);
            gBoxDevolucao.Controls.Add(rBtn12);
            gBoxDevolucao.Controls.Add(rBtn14);
            gBoxDevolucao.Controls.Add(pictureBox1);
            gBoxDevolucao.Controls.Add(lblKmFinal);
            gBoxDevolucao.Controls.Add(txtKmFinal);
            gBoxDevolucao.Controls.Add(lblServicos);
            gBoxDevolucao.Controls.Add(btnSelecionarServicos);
            gBoxDevolucao.Controls.Add(lblQtdTanque);
            gBoxDevolucao.Controls.Add(cBoxQtdTanque);
            gBoxDevolucao.Controls.Add(lblValorCombustivel);
            gBoxDevolucao.Controls.Add(txtValorCombustivel);
            gBoxDevolucao.Controls.Add(txtValorTotal);
            gBoxDevolucao.Controls.Add(lblValorTotal);
            gBoxDevolucao.Location = new System.Drawing.Point(601, 128);
            gBoxDevolucao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            gBoxDevolucao.Name = "gBoxDevolucao";
            gBoxDevolucao.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            gBoxDevolucao.Size = new System.Drawing.Size(577, 480);
            gBoxDevolucao.TabIndex = 24;
            gBoxDevolucao.TabStop = false;
            gBoxDevolucao.Text = "Return data";
            // 
            // txtValorInicial
            // 
            txtValorInicial.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            txtValorInicial.Enabled = false;
            txtValorInicial.Location = new System.Drawing.Point(436, 388);
            txtValorInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtValorInicial.Name = "txtValorInicial";
            txtValorInicial.Size = new System.Drawing.Size(132, 27);
            txtValorInicial.TabIndex = 35;
            txtValorInicial.Text = "0";
            // 
            // lblValorInicial
            // 
            lblValorInicial.AutoSize = true;
            lblValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblValorInicial.Location = new System.Drawing.Point(298, 388);
            lblValorInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblValorInicial.Name = "lblValorInicial";
            lblValorInicial.Size = new System.Drawing.Size(130, 20);
            lblValorInicial.TabIndex = 34;
            lblValorInicial.Text = "Initial Value: $";
            // 
            // lblEncerrar
            // 
            lblEncerrar.AutoSize = true;
            lblEncerrar.Location = new System.Drawing.Point(13, 336);
            lblEncerrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEncerrar.Name = "lblEncerrar";
            lblEncerrar.Size = new System.Drawing.Size(86, 20);
            lblEncerrar.TabIndex = 33;
            lblEncerrar.Text = "Return date";
            // 
            // dtDevolucao
            // 
            dtDevolucao.CustomFormat = "dd/MM/yyyy HH:mm";
            dtDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtDevolucao.Location = new System.Drawing.Point(107, 329);
            dtDevolucao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dtDevolucao.Name = "dtDevolucao";
            dtDevolucao.Size = new System.Drawing.Size(171, 27);
            dtDevolucao.TabIndex = 32;
            dtDevolucao.ValueChanged += DtDevolucao_ValueChanged;
            // 
            // rBtn01
            // 
            rBtn01.AutoSize = true;
            rBtn01.Location = new System.Drawing.Point(149, 243);
            rBtn01.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rBtn01.Name = "rBtn01";
            rBtn01.Size = new System.Drawing.Size(17, 16);
            rBtn01.TabIndex = 25;
            rBtn01.TabStop = true;
            rBtn01.UseVisualStyleBackColor = true;
            rBtn01.CheckedChanged += RBtn01_CheckedChanged;
            // 
            // lblFull
            // 
            lblFull.AutoSize = true;
            lblFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblFull.ForeColor = System.Drawing.SystemColors.ControlText;
            lblFull.Location = new System.Drawing.Point(393, 285);
            lblFull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFull.Name = "lblFull";
            lblFull.Size = new System.Drawing.Size(20, 20);
            lblFull.TabIndex = 31;
            lblFull.Text = "F";
            // 
            // lblEmpty
            // 
            lblEmpty.AutoSize = true;
            lblEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblEmpty.ForeColor = System.Drawing.Color.Red;
            lblEmpty.Location = new System.Drawing.Point(185, 285);
            lblEmpty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEmpty.Name = "lblEmpty";
            lblEmpty.Size = new System.Drawing.Size(21, 20);
            lblEmpty.TabIndex = 30;
            lblEmpty.Text = "E";
            // 
            // rBtn11
            // 
            rBtn11.AutoSize = true;
            rBtn11.Location = new System.Drawing.Point(432, 243);
            rBtn11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rBtn11.Name = "rBtn11";
            rBtn11.Size = new System.Drawing.Size(17, 16);
            rBtn11.TabIndex = 29;
            rBtn11.TabStop = true;
            rBtn11.UseVisualStyleBackColor = true;
            rBtn11.CheckedChanged += RBtn11_CheckedChanged;
            // 
            // rBtn34
            // 
            rBtn34.AutoSize = true;
            rBtn34.Location = new System.Drawing.Point(372, 180);
            rBtn34.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rBtn34.Name = "rBtn34";
            rBtn34.Size = new System.Drawing.Size(17, 16);
            rBtn34.TabIndex = 28;
            rBtn34.TabStop = true;
            rBtn34.UseVisualStyleBackColor = true;
            rBtn34.CheckedChanged += RBtn34_CheckedChanged;
            // 
            // rBtn12
            // 
            rBtn12.AutoSize = true;
            rBtn12.Location = new System.Drawing.Point(291, 157);
            rBtn12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rBtn12.Name = "rBtn12";
            rBtn12.Size = new System.Drawing.Size(17, 16);
            rBtn12.TabIndex = 27;
            rBtn12.TabStop = true;
            rBtn12.UseVisualStyleBackColor = true;
            rBtn12.CheckedChanged += RBtn12_CheckedChanged;
            // 
            // rBtn14
            // 
            rBtn14.AutoSize = true;
            rBtn14.Location = new System.Drawing.Point(211, 180);
            rBtn14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rBtn14.Name = "rBtn14";
            rBtn14.Size = new System.Drawing.Size(17, 16);
            rBtn14.TabIndex = 26;
            rBtn14.TabStop = true;
            rBtn14.UseVisualStyleBackColor = true;
            rBtn14.CheckedChanged += RBtn14_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FuelGauge1;
            pictureBox1.Location = new System.Drawing.Point(163, 177);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(283, 123);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // lblKmFinal
            // 
            lblKmFinal.AutoSize = true;
            lblKmFinal.Location = new System.Drawing.Point(28, 69);
            lblKmFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblKmFinal.Name = "lblKmFinal";
            lblKmFinal.Size = new System.Drawing.Size(63, 20);
            lblKmFinal.TabIndex = 25;
            lblKmFinal.Text = "Mileage";
            // 
            // txtKmFinal
            // 
            txtKmFinal.Location = new System.Drawing.Point(107, 70);
            txtKmFinal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtKmFinal.Name = "txtKmFinal";
            txtKmFinal.Size = new System.Drawing.Size(187, 27);
            txtKmFinal.TabIndex = 24;
            txtKmFinal.Text = "0";
            txtKmFinal.KeyPress += TxtKmFinal_KeyPress;
            // 
            // lblServicos
            // 
            lblServicos.AutoSize = true;
            lblServicos.Location = new System.Drawing.Point(320, 72);
            lblServicos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblServicos.Name = "lblServicos";
            lblServicos.Size = new System.Drawing.Size(136, 20);
            lblServicos.TabIndex = 23;
            lblServicos.Text = "Additional Services";
            // 
            // btnSelecionarServicos
            // 
            btnSelecionarServicos.Location = new System.Drawing.Point(459, 66);
            btnSelecionarServicos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnSelecionarServicos.Name = "btnSelecionarServicos";
            btnSelecionarServicos.Size = new System.Drawing.Size(100, 35);
            btnSelecionarServicos.TabIndex = 22;
            btnSelecionarServicos.Text = "Select";
            btnSelecionarServicos.UseVisualStyleBackColor = true;
            btnSelecionarServicos.Click += BtnSelecionarServicos_Click;
            // 
            // lblQtdTanque
            // 
            lblQtdTanque.AutoSize = true;
            lblQtdTanque.Location = new System.Drawing.Point(388, 126);
            lblQtdTanque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblQtdTanque.Name = "lblQtdTanque";
            lblQtdTanque.Size = new System.Drawing.Size(68, 20);
            lblQtdTanque.TabIndex = 21;
            lblQtdTanque.Text = "Fuel tank";
            // 
            // cBoxQtdTanque
            // 
            cBoxQtdTanque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cBoxQtdTanque.FormattingEnabled = true;
            cBoxQtdTanque.Items.AddRange(new object[] { "0/1", "1/4", "1/2", "3/4", "1/1" });
            cBoxQtdTanque.Location = new System.Drawing.Point(459, 123);
            cBoxQtdTanque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cBoxQtdTanque.Name = "cBoxQtdTanque";
            cBoxQtdTanque.Size = new System.Drawing.Size(99, 28);
            cBoxQtdTanque.TabIndex = 20;
            cBoxQtdTanque.SelectedIndexChanged += CBoxQtdTanque_SelectedIndexChanged;
            // 
            // lblValorCombustivel
            // 
            lblValorCombustivel.AutoSize = true;
            lblValorCombustivel.Location = new System.Drawing.Point(11, 126);
            lblValorCombustivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblValorCombustivel.Name = "lblValorCombustivel";
            lblValorCombustivel.Size = new System.Drawing.Size(88, 20);
            lblValorCombustivel.TabIndex = 19;
            lblValorCombustivel.Text = "Gas value  $";
            // 
            // txtValorCombustivel
            // 
            txtValorCombustivel.Location = new System.Drawing.Point(107, 123);
            txtValorCombustivel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtValorCombustivel.Name = "txtValorCombustivel";
            txtValorCombustivel.Size = new System.Drawing.Size(99, 27);
            txtValorCombustivel.TabIndex = 18;
            txtValorCombustivel.Text = "0";
            txtValorCombustivel.KeyPress += TxtValorCombustivel_KeyPress;
            // 
            // TelaDevolucaoForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1196, 682);
            Controls.Add(gBoxDevolucao);
            Controls.Add(brnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(gBoxLocacao);
            Controls.Add(lblTitulo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaDevolucaoForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Car Rental App";
            gBoxLocacao.ResumeLayout(false);
            gBoxLocacao.PerformLayout();
            gBoxDevolucao.ResumeLayout(false);
            gBoxDevolucao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.TextBox txtValorTotal;
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