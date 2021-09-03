
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
            this.gBoxRegistro = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblValorInicial = new System.Windows.Forms.Label();
            this.btnServicos = new System.Windows.Forms.Button();
            this.lblServicos = new System.Windows.Forms.Label();
            this.cBoxPlano = new System.Windows.Forms.ComboBox();
            this.lblPlano = new System.Windows.Forms.Label();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.lblDataDevolucao = new System.Windows.Forms.Label();
            this.lblDataLocacao = new System.Windows.Forms.Label();
            this.lblCondutor = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dateTPDataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.dateTPDataSaida = new System.Windows.Forms.DateTimePicker();
            this.cBoxCondutor = new System.Windows.Forms.ComboBox();
            this.cBoxCliente = new System.Windows.Forms.ComboBox();
            this.cBoxFuncionario = new System.Windows.Forms.ComboBox();
            this.cBoxVeiculo = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.brnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gBoxRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxRegistro
            // 
            this.gBoxRegistro.Controls.Add(this.txtTotal);
            this.gBoxRegistro.Controls.Add(this.lblValorInicial);
            this.gBoxRegistro.Controls.Add(this.btnServicos);
            this.gBoxRegistro.Controls.Add(this.lblServicos);
            this.gBoxRegistro.Controls.Add(this.cBoxPlano);
            this.gBoxRegistro.Controls.Add(this.lblPlano);
            this.gBoxRegistro.Controls.Add(this.lblVeiculo);
            this.gBoxRegistro.Controls.Add(this.lblDataDevolucao);
            this.gBoxRegistro.Controls.Add(this.lblDataLocacao);
            this.gBoxRegistro.Controls.Add(this.lblCondutor);
            this.gBoxRegistro.Controls.Add(this.lblCliente);
            this.gBoxRegistro.Controls.Add(this.lblFuncionario);
            this.gBoxRegistro.Controls.Add(this.lblId);
            this.gBoxRegistro.Controls.Add(this.txtId);
            this.gBoxRegistro.Controls.Add(this.dateTPDataDevolucao);
            this.gBoxRegistro.Controls.Add(this.dateTPDataSaida);
            this.gBoxRegistro.Controls.Add(this.cBoxCondutor);
            this.gBoxRegistro.Controls.Add(this.cBoxCliente);
            this.gBoxRegistro.Controls.Add(this.cBoxFuncionario);
            this.gBoxRegistro.Controls.Add(this.cBoxVeiculo);
            this.gBoxRegistro.Location = new System.Drawing.Point(16, 107);
            this.gBoxRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxRegistro.Name = "gBoxRegistro";
            this.gBoxRegistro.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxRegistro.Size = new System.Drawing.Size(577, 320);
            this.gBoxRegistro.TabIndex = 0;
            this.gBoxRegistro.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(412, 276);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(132, 22);
            this.txtTotal.TabIndex = 17;
            this.txtTotal.Text = "0";
            // 
            // lblValorInicial
            // 
            this.lblValorInicial.AutoSize = true;
            this.lblValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorInicial.Location = new System.Drawing.Point(260, 276);
            this.lblValorInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorInicial.Name = "lblValorInicial";
            this.lblValorInicial.Size = new System.Drawing.Size(144, 20);
            this.lblValorInicial.TabIndex = 2;
            this.lblValorInicial.Text = "Valor Inicial: R$";
            // 
            // btnServicos
            // 
            this.btnServicos.Location = new System.Drawing.Point(445, 122);
            this.btnServicos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(100, 28);
            this.btnServicos.TabIndex = 16;
            this.btnServicos.Text = "Selecionar";
            this.btnServicos.UseVisualStyleBackColor = true;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // lblServicos
            // 
            this.lblServicos.AutoSize = true;
            this.lblServicos.Location = new System.Drawing.Point(373, 128);
            this.lblServicos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServicos.Name = "lblServicos";
            this.lblServicos.Size = new System.Drawing.Size(62, 17);
            this.lblServicos.TabIndex = 15;
            this.lblServicos.Text = "Serviços";
            // 
            // cBoxPlano
            // 
            this.cBoxPlano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPlano.FormattingEnabled = true;
            this.cBoxPlano.Items.AddRange(new object[] {
            "Plano Diario",
            "Km Controlado",
            "Km Livre"});
            this.cBoxPlano.Location = new System.Drawing.Point(119, 122);
            this.cBoxPlano.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxPlano.Name = "cBoxPlano";
            this.cBoxPlano.Size = new System.Drawing.Size(225, 24);
            this.cBoxPlano.TabIndex = 14;
            // 
            // lblPlano
            // 
            this.lblPlano.AutoSize = true;
            this.lblPlano.Location = new System.Drawing.Point(65, 128);
            this.lblPlano.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlano.Name = "lblPlano";
            this.lblPlano.Size = new System.Drawing.Size(44, 17);
            this.lblPlano.TabIndex = 13;
            this.lblPlano.Text = "Plano";
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Location = new System.Drawing.Point(52, 92);
            this.lblVeiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(54, 17);
            this.lblVeiculo.TabIndex = 12;
            this.lblVeiculo.Text = "Veículo";
            // 
            // lblDataDevolucao
            // 
            this.lblDataDevolucao.AutoSize = true;
            this.lblDataDevolucao.Location = new System.Drawing.Point(288, 225);
            this.lblDataDevolucao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataDevolucao.Name = "lblDataDevolucao";
            this.lblDataDevolucao.Size = new System.Drawing.Size(79, 17);
            this.lblDataDevolucao.TabIndex = 11;
            this.lblDataDevolucao.Text = "Devolução ";
            // 
            // lblDataLocacao
            // 
            this.lblDataLocacao.AutoSize = true;
            this.lblDataLocacao.Location = new System.Drawing.Point(45, 225);
            this.lblDataLocacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataLocacao.Name = "lblDataLocacao";
            this.lblDataLocacao.Size = new System.Drawing.Size(62, 17);
            this.lblDataLocacao.TabIndex = 10;
            this.lblDataLocacao.Text = "Locação";
            // 
            // lblCondutor
            // 
            this.lblCondutor.AutoSize = true;
            this.lblCondutor.Location = new System.Drawing.Point(44, 192);
            this.lblCondutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCondutor.Name = "lblCondutor";
            this.lblCondutor.Size = new System.Drawing.Size(66, 17);
            this.lblCondutor.TabIndex = 9;
            this.lblCondutor.Text = "Condutor";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(59, 159);
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
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(89, 22);
            this.txtId.TabIndex = 2;
            this.txtId.Text = "0";
            // 
            // dateTPDataDevolucao
            // 
            this.dateTPDataDevolucao.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTPDataDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTPDataDevolucao.Location = new System.Drawing.Point(379, 222);
            this.dateTPDataDevolucao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTPDataDevolucao.Name = "dateTPDataDevolucao";
            this.dateTPDataDevolucao.Size = new System.Drawing.Size(165, 22);
            this.dateTPDataDevolucao.TabIndex = 5;
            // 
            // dateTPDataSaida
            // 
            this.dateTPDataSaida.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTPDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTPDataSaida.Location = new System.Drawing.Point(119, 222);
            this.dateTPDataSaida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTPDataSaida.Name = "dateTPDataSaida";
            this.dateTPDataSaida.Size = new System.Drawing.Size(160, 22);
            this.dateTPDataSaida.TabIndex = 4;
            // 
            // cBoxCondutor
            // 
            this.cBoxCondutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCondutor.FormattingEnabled = true;
            this.cBoxCondutor.Location = new System.Drawing.Point(119, 188);
            this.cBoxCondutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxCondutor.Name = "cBoxCondutor";
            this.cBoxCondutor.Size = new System.Drawing.Size(425, 24);
            this.cBoxCondutor.TabIndex = 3;
            // 
            // cBoxCliente
            // 
            this.cBoxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCliente.FormattingEnabled = true;
            this.cBoxCliente.Location = new System.Drawing.Point(119, 155);
            this.cBoxCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxCliente.Name = "cBoxCliente";
            this.cBoxCliente.Size = new System.Drawing.Size(425, 24);
            this.cBoxCliente.TabIndex = 2;
            // 
            // cBoxFuncionario
            // 
            this.cBoxFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFuncionario.FormattingEnabled = true;
            this.cBoxFuncionario.Location = new System.Drawing.Point(119, 55);
            this.cBoxFuncionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxFuncionario.Name = "cBoxFuncionario";
            this.cBoxFuncionario.Size = new System.Drawing.Size(425, 24);
            this.cBoxFuncionario.TabIndex = 1;
            // 
            // cBoxVeiculo
            // 
            this.cBoxVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxVeiculo.FormattingEnabled = true;
            this.cBoxVeiculo.Location = new System.Drawing.Point(119, 89);
            this.cBoxVeiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxVeiculo.Name = "cBoxVeiculo";
            this.cBoxVeiculo.Size = new System.Drawing.Size(425, 24);
            this.cBoxVeiculo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(200, 48);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(186, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Registrar Locação";
            // 
            // brnConfirmar
            // 
            this.brnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.brnConfirmar.Location = new System.Drawing.Point(388, 434);
            this.brnConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brnConfirmar.Name = "brnConfirmar";
            this.brnConfirmar.Size = new System.Drawing.Size(100, 28);
            this.brnConfirmar.TabIndex = 18;
            this.brnConfirmar.Text = "Confirmar";
            this.brnConfirmar.UseVisualStyleBackColor = true;
            this.brnConfirmar.Click += new System.EventHandler(this.brnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(496, 434);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaLocacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 480);
            this.Controls.Add(this.brnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gBoxRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaLocacaoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locadora de Veiculo";
            this.gBoxRegistro.ResumeLayout(false);
            this.gBoxRegistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}