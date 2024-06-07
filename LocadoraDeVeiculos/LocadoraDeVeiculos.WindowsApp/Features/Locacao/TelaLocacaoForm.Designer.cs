
namespace LocadoraDeVeiculos.WindowsApp.Features.Locacoes
{
    partial class TelaLocacaoForm
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
            gBoxRegistro = new System.Windows.Forms.GroupBox();
            btnVerificar = new System.Windows.Forms.Button();
            txtCupom = new System.Windows.Forms.TextBox();
            lblCupom = new System.Windows.Forms.Label();
            txtTotal = new System.Windows.Forms.TextBox();
            lblValorInicial = new System.Windows.Forms.Label();
            btnServicos = new System.Windows.Forms.Button();
            lblServicos = new System.Windows.Forms.Label();
            cBoxPlano = new System.Windows.Forms.ComboBox();
            lblPlano = new System.Windows.Forms.Label();
            lblVeiculo = new System.Windows.Forms.Label();
            lblDataDevolucao = new System.Windows.Forms.Label();
            lblDataLocacao = new System.Windows.Forms.Label();
            lblCondutor = new System.Windows.Forms.Label();
            lblCliente = new System.Windows.Forms.Label();
            lblFuncionario = new System.Windows.Forms.Label();
            lblId = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            dateTPDataDevolucao = new System.Windows.Forms.DateTimePicker();
            dateTPDataSaida = new System.Windows.Forms.DateTimePicker();
            cBoxCondutor = new System.Windows.Forms.ComboBox();
            cBoxCliente = new System.Windows.Forms.ComboBox();
            cBoxFuncionario = new System.Windows.Forms.ComboBox();
            cBoxVeiculo = new System.Windows.Forms.ComboBox();
            lblTitulo = new System.Windows.Forms.Label();
            brnConfirmar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            gBoxRegistro.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxRegistro
            // 
            gBoxRegistro.Controls.Add(btnVerificar);
            gBoxRegistro.Controls.Add(txtCupom);
            gBoxRegistro.Controls.Add(lblCupom);
            gBoxRegistro.Controls.Add(txtTotal);
            gBoxRegistro.Controls.Add(lblValorInicial);
            gBoxRegistro.Controls.Add(btnServicos);
            gBoxRegistro.Controls.Add(lblServicos);
            gBoxRegistro.Controls.Add(cBoxPlano);
            gBoxRegistro.Controls.Add(lblPlano);
            gBoxRegistro.Controls.Add(lblVeiculo);
            gBoxRegistro.Controls.Add(lblDataDevolucao);
            gBoxRegistro.Controls.Add(lblDataLocacao);
            gBoxRegistro.Controls.Add(lblCondutor);
            gBoxRegistro.Controls.Add(lblCliente);
            gBoxRegistro.Controls.Add(lblFuncionario);
            gBoxRegistro.Controls.Add(lblId);
            gBoxRegistro.Controls.Add(txtId);
            gBoxRegistro.Controls.Add(dateTPDataDevolucao);
            gBoxRegistro.Controls.Add(dateTPDataSaida);
            gBoxRegistro.Controls.Add(cBoxCondutor);
            gBoxRegistro.Controls.Add(cBoxCliente);
            gBoxRegistro.Controls.Add(cBoxFuncionario);
            gBoxRegistro.Controls.Add(cBoxVeiculo);
            gBoxRegistro.Location = new System.Drawing.Point(16, 134);
            gBoxRegistro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            gBoxRegistro.Name = "gBoxRegistro";
            gBoxRegistro.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            gBoxRegistro.Size = new System.Drawing.Size(577, 434);
            gBoxRegistro.TabIndex = 0;
            gBoxRegistro.TabStop = false;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new System.Drawing.Point(445, 314);
            btnVerificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new System.Drawing.Size(100, 35);
            btnVerificar.TabIndex = 20;
            btnVerificar.Text = "Verify";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += BtnVerificar_Click;
            // 
            // txtCupom
            // 
            txtCupom.BackColor = System.Drawing.SystemColors.Window;
            txtCupom.Location = new System.Drawing.Point(119, 317);
            txtCupom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtCupom.Name = "txtCupom";
            txtCupom.Size = new System.Drawing.Size(317, 27);
            txtCupom.TabIndex = 19;
            // 
            // lblCupom
            // 
            lblCupom.AutoSize = true;
            lblCupom.Location = new System.Drawing.Point(50, 321);
            lblCupom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCupom.Name = "lblCupom";
            lblCupom.Size = new System.Drawing.Size(61, 20);
            lblCupom.TabIndex = 18;
            lblCupom.Text = "Coupon";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            txtTotal.Enabled = false;
            txtTotal.Location = new System.Drawing.Point(412, 385);
            txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(132, 27);
            txtTotal.TabIndex = 17;
            txtTotal.Text = "0";
            // 
            // lblValorInicial
            // 
            lblValorInicial.AutoSize = true;
            lblValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblValorInicial.Location = new System.Drawing.Point(274, 388);
            lblValorInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblValorInicial.Name = "lblValorInicial";
            lblValorInicial.Size = new System.Drawing.Size(130, 20);
            lblValorInicial.TabIndex = 2;
            lblValorInicial.Text = "Initial Value: $";
            // 
            // btnServicos
            // 
            btnServicos.Location = new System.Drawing.Point(445, 152);
            btnServicos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnServicos.Name = "btnServicos";
            btnServicos.Size = new System.Drawing.Size(100, 35);
            btnServicos.TabIndex = 16;
            btnServicos.Text = "Selecionar";
            btnServicos.UseVisualStyleBackColor = true;
            btnServicos.Click += BtnServicos_Click;
            // 
            // lblServicos
            // 
            lblServicos.AutoSize = true;
            lblServicos.Location = new System.Drawing.Point(373, 160);
            lblServicos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblServicos.Name = "lblServicos";
            lblServicos.Size = new System.Drawing.Size(62, 20);
            lblServicos.TabIndex = 15;
            lblServicos.Text = "Services";
            // 
            // cBoxPlano
            // 
            cBoxPlano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cBoxPlano.FormattingEnabled = true;
            cBoxPlano.Items.AddRange(new object[] { "Plano Diario", "Km Controlado", "Km Livre" });
            cBoxPlano.Location = new System.Drawing.Point(119, 152);
            cBoxPlano.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cBoxPlano.Name = "cBoxPlano";
            cBoxPlano.Size = new System.Drawing.Size(225, 28);
            cBoxPlano.TabIndex = 14;
            // 
            // lblPlano
            // 
            lblPlano.AutoSize = true;
            lblPlano.Location = new System.Drawing.Point(39, 159);
            lblPlano.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPlano.Name = "lblPlano";
            lblPlano.Size = new System.Drawing.Size(72, 20);
            lblPlano.TabIndex = 13;
            lblPlano.Text = "Plan Type";
            // 
            // lblVeiculo
            // 
            lblVeiculo.AutoSize = true;
            lblVeiculo.Location = new System.Drawing.Point(58, 114);
            lblVeiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVeiculo.Name = "lblVeiculo";
            lblVeiculo.Size = new System.Drawing.Size(56, 20);
            lblVeiculo.TabIndex = 12;
            lblVeiculo.Text = "Vehicle";
            // 
            // lblDataDevolucao
            // 
            lblDataDevolucao.AutoSize = true;
            lblDataDevolucao.Location = new System.Drawing.Point(318, 284);
            lblDataDevolucao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDataDevolucao.Name = "lblDataDevolucao";
            lblDataDevolucao.Size = new System.Drawing.Size(52, 20);
            lblDataDevolucao.TabIndex = 11;
            lblDataDevolucao.Text = "Return";
            // 
            // lblDataLocacao
            // 
            lblDataLocacao.AutoSize = true;
            lblDataLocacao.Location = new System.Drawing.Point(60, 284);
            lblDataLocacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDataLocacao.Name = "lblDataLocacao";
            lblDataLocacao.Size = new System.Drawing.Size(51, 20);
            lblDataLocacao.TabIndex = 10;
            lblDataLocacao.Text = "Rental";
            // 
            // lblCondutor
            // 
            lblCondutor.AutoSize = true;
            lblCondutor.Location = new System.Drawing.Point(33, 238);
            lblCondutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCondutor.Name = "lblCondutor";
            lblCondutor.Size = new System.Drawing.Size(78, 20);
            lblCondutor.TabIndex = 9;
            lblCondutor.Text = "Conductor";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new System.Drawing.Point(64, 197);
            lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new System.Drawing.Size(47, 20);
            lblCliente.TabIndex = 8;
            lblCliente.Text = "Client";
            // 
            // lblFuncionario
            // 
            lblFuncionario.AutoSize = true;
            lblFuncionario.Location = new System.Drawing.Point(36, 77);
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
            txtId.Size = new System.Drawing.Size(89, 27);
            txtId.TabIndex = 2;
            txtId.Text = "0";
            // 
            // dateTPDataDevolucao
            // 
            dateTPDataDevolucao.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTPDataDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTPDataDevolucao.Location = new System.Drawing.Point(379, 277);
            dateTPDataDevolucao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dateTPDataDevolucao.Name = "dateTPDataDevolucao";
            dateTPDataDevolucao.Size = new System.Drawing.Size(165, 27);
            dateTPDataDevolucao.TabIndex = 5;
            // 
            // dateTPDataSaida
            // 
            dateTPDataSaida.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTPDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTPDataSaida.Location = new System.Drawing.Point(119, 277);
            dateTPDataSaida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dateTPDataSaida.Name = "dateTPDataSaida";
            dateTPDataSaida.Size = new System.Drawing.Size(160, 27);
            dateTPDataSaida.TabIndex = 4;
            // 
            // cBoxCondutor
            // 
            cBoxCondutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cBoxCondutor.FormattingEnabled = true;
            cBoxCondutor.Location = new System.Drawing.Point(119, 235);
            cBoxCondutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cBoxCondutor.Name = "cBoxCondutor";
            cBoxCondutor.Size = new System.Drawing.Size(425, 28);
            cBoxCondutor.TabIndex = 3;
            // 
            // cBoxCliente
            // 
            cBoxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cBoxCliente.FormattingEnabled = true;
            cBoxCliente.Location = new System.Drawing.Point(119, 194);
            cBoxCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cBoxCliente.Name = "cBoxCliente";
            cBoxCliente.Size = new System.Drawing.Size(425, 28);
            cBoxCliente.TabIndex = 2;
            // 
            // cBoxFuncionario
            // 
            cBoxFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cBoxFuncionario.FormattingEnabled = true;
            cBoxFuncionario.Location = new System.Drawing.Point(119, 69);
            cBoxFuncionario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cBoxFuncionario.Name = "cBoxFuncionario";
            cBoxFuncionario.Size = new System.Drawing.Size(425, 28);
            cBoxFuncionario.TabIndex = 1;
            // 
            // cBoxVeiculo
            // 
            cBoxVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cBoxVeiculo.FormattingEnabled = true;
            cBoxVeiculo.Location = new System.Drawing.Point(119, 111);
            cBoxVeiculo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cBoxVeiculo.Name = "cBoxVeiculo";
            cBoxVeiculo.Size = new System.Drawing.Size(425, 28);
            cBoxVeiculo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitulo.Location = new System.Drawing.Point(234, 60);
            lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(158, 25);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Register Rental";
            // 
            // brnConfirmar
            // 
            brnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            brnConfirmar.Location = new System.Drawing.Point(385, 580);
            brnConfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            brnConfirmar.Name = "brnConfirmar";
            brnConfirmar.Size = new System.Drawing.Size(100, 35);
            brnConfirmar.TabIndex = 18;
            brnConfirmar.Text = "Submit";
            brnConfirmar.UseVisualStyleBackColor = true;
            brnConfirmar.Click += BrnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancelar.Location = new System.Drawing.Point(493, 580);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(100, 35);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancel";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaLocacaoForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(612, 634);
            Controls.Add(brnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(lblTitulo);
            Controls.Add(gBoxRegistro);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaLocacaoForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Car Rental App";
            gBoxRegistro.ResumeLayout(false);
            gBoxRegistro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxRegistro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DateTimePicker dateTPDataDevolucao;
        private System.Windows.Forms.DateTimePicker dateTPDataSaida;
        private System.Windows.Forms.ComboBox cBoxCondutor;
        private System.Windows.Forms.ComboBox cBoxCliente;
        private System.Windows.Forms.ComboBox cBoxFuncionario;
        private System.Windows.Forms.ComboBox cBoxVeiculo;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label lblDataDevolucao;
        private System.Windows.Forms.Label lblDataLocacao;
        private System.Windows.Forms.Label lblCondutor;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Label lblServicos;
        private System.Windows.Forms.ComboBox cBoxPlano;
        private System.Windows.Forms.Label lblPlano;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button brnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblValorInicial;
        private System.Windows.Forms.TextBox txtCupom;
        private System.Windows.Forms.Label lblCupom;
        private System.Windows.Forms.Button btnVerificar;
    }
}