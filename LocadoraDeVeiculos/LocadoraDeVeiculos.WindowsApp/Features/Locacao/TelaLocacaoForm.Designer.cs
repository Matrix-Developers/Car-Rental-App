
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cBoxVeiculo = new System.Windows.Forms.ComboBox();
            this.cBoxFuncionario = new System.Windows.Forms.ComboBox();
            this.cBoxCliente = new System.Windows.Forms.ComboBox();
            this.cBoxCondutor = new System.Windows.Forms.ComboBox();
            this.dateTPDataSaida = new System.Windows.Forms.DateTimePicker();
            this.dateTPDataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCondutor = new System.Windows.Forms.Label();
            this.lblDataLocacao = new System.Windows.Forms.Label();
            this.lblDataDevolucao = new System.Windows.Forms.Label();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.lblPlano = new System.Windows.Forms.Label();
            this.cBoxPlano = new System.Windows.Forms.ComboBox();
            this.lblServicos = new System.Windows.Forms.Label();
            this.btnServicos = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.brnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gBoxRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxRegistro
            // 
            this.gBoxRegistro.Controls.Add(this.txtTotal);
            this.gBoxRegistro.Controls.Add(this.lblTotal);
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
            this.gBoxRegistro.Location = new System.Drawing.Point(12, 87);
            this.gBoxRegistro.Name = "gBoxRegistro";
            this.gBoxRegistro.Size = new System.Drawing.Size(433, 260);
            this.gBoxRegistro.TabIndex = 0;
            this.gBoxRegistro.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(150, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(156, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Registrar Locação";
            // 
            // cBoxVeiculo
            // 
            this.cBoxVeiculo.FormattingEnabled = true;
            this.cBoxVeiculo.Location = new System.Drawing.Point(89, 72);
            this.cBoxVeiculo.Name = "cBoxVeiculo";
            this.cBoxVeiculo.Size = new System.Drawing.Size(320, 21);
            this.cBoxVeiculo.TabIndex = 0;
            // 
            // cBoxFuncionario
            // 
            this.cBoxFuncionario.FormattingEnabled = true;
            this.cBoxFuncionario.Location = new System.Drawing.Point(89, 45);
            this.cBoxFuncionario.Name = "cBoxFuncionario";
            this.cBoxFuncionario.Size = new System.Drawing.Size(320, 21);
            this.cBoxFuncionario.TabIndex = 1;
            // 
            // cBoxCliente
            // 
            this.cBoxCliente.FormattingEnabled = true;
            this.cBoxCliente.Location = new System.Drawing.Point(89, 126);
            this.cBoxCliente.Name = "cBoxCliente";
            this.cBoxCliente.Size = new System.Drawing.Size(320, 21);
            this.cBoxCliente.TabIndex = 2;
            // 
            // cBoxCondutor
            // 
            this.cBoxCondutor.FormattingEnabled = true;
            this.cBoxCondutor.Location = new System.Drawing.Point(89, 153);
            this.cBoxCondutor.Name = "cBoxCondutor";
            this.cBoxCondutor.Size = new System.Drawing.Size(320, 21);
            this.cBoxCondutor.TabIndex = 3;
            // 
            // dateTPDataSaida
            // 
            this.dateTPDataSaida.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTPDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTPDataSaida.Location = new System.Drawing.Point(89, 180);
            this.dateTPDataSaida.Name = "dateTPDataSaida";
            this.dateTPDataSaida.Size = new System.Drawing.Size(121, 20);
            this.dateTPDataSaida.TabIndex = 4;
            // 
            // dateTPDataDevolucao
            // 
            this.dateTPDataDevolucao.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTPDataDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTPDataDevolucao.Location = new System.Drawing.Point(284, 180);
            this.dateTPDataDevolucao.Name = "dateTPDataDevolucao";
            this.dateTPDataDevolucao.Size = new System.Drawing.Size(125, 20);
            this.dateTPDataDevolucao.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(89, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(68, 20);
            this.txtId.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(65, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "ID";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(21, 48);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(62, 13);
            this.lblFuncionario.TabIndex = 7;
            this.lblFuncionario.Text = "Funcionário";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(44, 129);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Cliente";
            // 
            // lblCondutor
            // 
            this.lblCondutor.AutoSize = true;
            this.lblCondutor.Location = new System.Drawing.Point(33, 156);
            this.lblCondutor.Name = "lblCondutor";
            this.lblCondutor.Size = new System.Drawing.Size(50, 13);
            this.lblCondutor.TabIndex = 9;
            this.lblCondutor.Text = "Condutor";
            // 
            // lblDataLocacao
            // 
            this.lblDataLocacao.AutoSize = true;
            this.lblDataLocacao.Location = new System.Drawing.Point(34, 183);
            this.lblDataLocacao.Name = "lblDataLocacao";
            this.lblDataLocacao.Size = new System.Drawing.Size(49, 13);
            this.lblDataLocacao.TabIndex = 10;
            this.lblDataLocacao.Text = "Locação";
            // 
            // lblDataDevolucao
            // 
            this.lblDataDevolucao.AutoSize = true;
            this.lblDataDevolucao.Location = new System.Drawing.Point(216, 183);
            this.lblDataDevolucao.Name = "lblDataDevolucao";
            this.lblDataDevolucao.Size = new System.Drawing.Size(62, 13);
            this.lblDataDevolucao.TabIndex = 11;
            this.lblDataDevolucao.Text = "Devolução ";
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Location = new System.Drawing.Point(39, 75);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(44, 13);
            this.lblVeiculo.TabIndex = 12;
            this.lblVeiculo.Text = "Veículo";
            // 
            // lblPlano
            // 
            this.lblPlano.AutoSize = true;
            this.lblPlano.Location = new System.Drawing.Point(49, 104);
            this.lblPlano.Name = "lblPlano";
            this.lblPlano.Size = new System.Drawing.Size(34, 13);
            this.lblPlano.TabIndex = 13;
            this.lblPlano.Text = "Plano";
            // 
            // cBoxPlano
            // 
            this.cBoxPlano.FormattingEnabled = true;
            this.cBoxPlano.Location = new System.Drawing.Point(89, 99);
            this.cBoxPlano.Name = "cBoxPlano";
            this.cBoxPlano.Size = new System.Drawing.Size(170, 21);
            this.cBoxPlano.TabIndex = 14;
            // 
            // lblServicos
            // 
            this.lblServicos.AutoSize = true;
            this.lblServicos.Location = new System.Drawing.Point(280, 104);
            this.lblServicos.Name = "lblServicos";
            this.lblServicos.Size = new System.Drawing.Size(48, 13);
            this.lblServicos.TabIndex = 15;
            this.lblServicos.Text = "Serviços";
            // 
            // btnServicos
            // 
            this.btnServicos.Location = new System.Drawing.Point(334, 99);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(75, 23);
            this.btnServicos.TabIndex = 16;
            this.btnServicos.Text = "Selecionar";
            this.btnServicos.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(222, 224);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 16);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total: R$";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(297, 223);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 17;
            // 
            // brnConfirmar
            // 
            this.brnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.brnConfirmar.Location = new System.Drawing.Point(291, 353);
            this.brnConfirmar.Name = "brnConfirmar";
            this.brnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.brnConfirmar.TabIndex = 18;
            this.brnConfirmar.Text = "Confirmar";
            this.brnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(372, 353);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaLocacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 390);
            this.Controls.Add(this.brnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gBoxRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaLocacaoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
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
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button brnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}