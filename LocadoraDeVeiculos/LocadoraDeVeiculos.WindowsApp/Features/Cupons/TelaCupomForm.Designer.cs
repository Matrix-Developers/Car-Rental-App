
namespace LocadoraDeVeiculos.WindowsApp.Features.Cupons
{
    partial class TelaCupomForm
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.lbValidade = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbValorMinimo = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rBtnPorcentagem = new System.Windows.Forms.RadioButton();
            this.rBtnValorFixo = new System.Windows.Forms.RadioButton();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.numUpDownValor = new System.Windows.Forms.NumericUpDown();
            this.numUpDownValorMinimo = new System.Windows.Forms.NumericUpDown();
            this.lblParceiro = new System.Windows.Forms.Label();
            this.cBoxParceiro = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownValorMinimo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(94, 38);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(173, 20);
            this.labelTitulo.TabIndex = 66;
            this.labelTitulo.Text = "Cadastro de Cupons";
            // 
            // dtpValidade
            // 
            this.dtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidade.Location = new System.Drawing.Point(125, 306);
            this.dtpValidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(180, 23);
            this.dtpValidade.TabIndex = 73;
            // 
            // lbValidade
            // 
            this.lbValidade.AutoSize = true;
            this.lbValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbValidade.ForeColor = System.Drawing.Color.Black;
            this.lbValidade.Location = new System.Drawing.Point(66, 313);
            this.lbValidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValidade.Name = "lbValidade";
            this.lbValidade.Size = new System.Drawing.Size(48, 13);
            this.lbValidade.TabIndex = 82;
            this.lbValidade.Text = "Validade";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(125, 115);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(62, 23);
            this.txtId.TabIndex = 80;
            this.txtId.Text = "0";
            // 
            // lbValorMinimo
            // 
            this.lbValorMinimo.AutoSize = true;
            this.lbValorMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbValorMinimo.ForeColor = System.Drawing.Color.Black;
            this.lbValorMinimo.Location = new System.Drawing.Point(45, 279);
            this.lbValorMinimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValorMinimo.Name = "lbValorMinimo";
            this.lbValorMinimo.Size = new System.Drawing.Size(69, 13);
            this.lbValorMinimo.TabIndex = 78;
            this.lbValorMinimo.Text = "Valor Mínimo";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbValor.ForeColor = System.Drawing.Color.Black;
            this.lbValor.Location = new System.Drawing.Point(83, 249);
            this.lbValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(31, 13);
            this.lbValor.TabIndex = 77;
            this.lbValor.Text = "Valor";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCodigo.ForeColor = System.Drawing.Color.Black;
            this.labelCodigo.Location = new System.Drawing.Point(77, 179);
            this.labelCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 76;
            this.labelCodigo.Text = "Código";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNome.ForeColor = System.Drawing.Color.Black;
            this.lbNome.Location = new System.Drawing.Point(83, 149);
            this.lbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 75;
            this.lbNome.Text = "Nome";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbId.ForeColor = System.Drawing.Color.Black;
            this.lbId.Location = new System.Drawing.Point(105, 119);
            this.lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(16, 13);
            this.lbId.TabIndex = 74;
            this.lbId.Text = "Id";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(125, 145);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(180, 23);
            this.txtNome.TabIndex = 1;
            // 
            // rBtnPorcentagem
            // 
            this.rBtnPorcentagem.AutoSize = true;
            this.rBtnPorcentagem.Location = new System.Drawing.Point(192, 215);
            this.rBtnPorcentagem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rBtnPorcentagem.Name = "rBtnPorcentagem";
            this.rBtnPorcentagem.Size = new System.Drawing.Size(96, 19);
            this.rBtnPorcentagem.TabIndex = 4;
            this.rBtnPorcentagem.TabStop = true;
            this.rBtnPorcentagem.Text = "Porcentagem";
            this.rBtnPorcentagem.UseVisualStyleBackColor = true;
            this.rBtnPorcentagem.CheckedChanged += new System.EventHandler(this.RBtnPorcentagem_CheckedChanged);
            // 
            // rBtnValorFixo
            // 
            this.rBtnValorFixo.AutoSize = true;
            this.rBtnValorFixo.Location = new System.Drawing.Point(92, 215);
            this.rBtnValorFixo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rBtnValorFixo.Name = "rBtnValorFixo";
            this.rBtnValorFixo.Size = new System.Drawing.Size(76, 19);
            this.rBtnValorFixo.TabIndex = 3;
            this.rBtnValorFixo.TabStop = true;
            this.rBtnValorFixo.Text = "Valor Fixo";
            this.rBtnValorFixo.UseVisualStyleBackColor = true;
            this.rBtnValorFixo.CheckedChanged += new System.EventHandler(this.RBtnValorFixo_CheckedChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(125, 175);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(180, 23);
            this.txtCodigo.TabIndex = 2;
            // 
            // numUpDownValor
            // 
            this.numUpDownValor.Location = new System.Drawing.Point(125, 246);
            this.numUpDownValor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numUpDownValor.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.numUpDownValor.Name = "numUpDownValor";
            this.numUpDownValor.Size = new System.Drawing.Size(181, 23);
            this.numUpDownValor.TabIndex = 5;
            // 
            // numUpDownValorMinimo
            // 
            this.numUpDownValorMinimo.Location = new System.Drawing.Point(125, 276);
            this.numUpDownValorMinimo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numUpDownValorMinimo.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.numUpDownValorMinimo.Name = "numUpDownValorMinimo";
            this.numUpDownValorMinimo.Size = new System.Drawing.Size(181, 23);
            this.numUpDownValorMinimo.TabIndex = 6;
            // 
            // lblParceiro
            // 
            this.lblParceiro.AutoSize = true;
            this.lblParceiro.Location = new System.Drawing.Point(64, 345);
            this.lblParceiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParceiro.Name = "lblParceiro";
            this.lblParceiro.Size = new System.Drawing.Size(50, 15);
            this.lblParceiro.TabIndex = 83;
            this.lblParceiro.Text = "Parceiro";
            // 
            // cBoxParceiro
            // 
            this.cBoxParceiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxParceiro.FormattingEnabled = true;
            this.cBoxParceiro.Location = new System.Drawing.Point(125, 342);
            this.cBoxParceiro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cBoxParceiro.Name = "cBoxParceiro";
            this.cBoxParceiro.Size = new System.Drawing.Size(180, 23);
            this.cBoxParceiro.TabIndex = 84;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(289, 403);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 27);
            this.btnCancelar.TabIndex = 86;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.Location = new System.Drawing.Point(195, 403);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(88, 27);
            this.btnConfirmar.TabIndex = 85;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // TelaCupomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 443);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cBoxParceiro);
            this.Controls.Add(this.lblParceiro);
            this.Controls.Add(this.numUpDownValorMinimo);
            this.Controls.Add(this.numUpDownValor);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.rBtnValorFixo);
            this.Controls.Add(this.rBtnPorcentagem);
            this.Controls.Add(this.dtpValidade);
            this.Controls.Add(this.lbValidade);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbValorMinimo);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCupomForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locadora de Veiculo";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownValorMinimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DateTimePicker dtpValidade;
        private System.Windows.Forms.Label lbValidade;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbValorMinimo;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rBtnPorcentagem;
        private System.Windows.Forms.RadioButton rBtnValorFixo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.NumericUpDown numUpDownValor;
        private System.Windows.Forms.NumericUpDown numUpDownValorMinimo;
        private System.Windows.Forms.Label lblParceiro;
        private System.Windows.Forms.ComboBox cBoxParceiro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}