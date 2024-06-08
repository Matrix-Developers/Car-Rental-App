
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
            labelTitulo = new System.Windows.Forms.Label();
            dtpValidade = new System.Windows.Forms.DateTimePicker();
            lbValidade = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            lbValorMinimo = new System.Windows.Forms.Label();
            lbValor = new System.Windows.Forms.Label();
            labelCodigo = new System.Windows.Forms.Label();
            lbNome = new System.Windows.Forms.Label();
            lbId = new System.Windows.Forms.Label();
            txtNome = new System.Windows.Forms.TextBox();
            rBtnPorcentagem = new System.Windows.Forms.RadioButton();
            rBtnValorFixo = new System.Windows.Forms.RadioButton();
            txtCodigo = new System.Windows.Forms.TextBox();
            numUpDownValor = new System.Windows.Forms.NumericUpDown();
            numUpDownValorMinimo = new System.Windows.Forms.NumericUpDown();
            lblParceiro = new System.Windows.Forms.Label();
            cBoxParceiro = new System.Windows.Forms.ComboBox();
            btnCancelar = new System.Windows.Forms.Button();
            btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numUpDownValor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownValorMinimo).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            labelTitulo.ForeColor = System.Drawing.Color.Black;
            labelTitulo.Location = new System.Drawing.Point(143, 58);
            labelTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new System.Drawing.Size(173, 25);
            labelTitulo.TabIndex = 66;
            labelTitulo.Text = "Register Coupon";
            // 
            // dtpValidade
            // 
            dtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpValidade.Location = new System.Drawing.Point(143, 408);
            dtpValidade.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            dtpValidade.Name = "dtpValidade";
            dtpValidade.Size = new System.Drawing.Size(205, 27);
            dtpValidade.TabIndex = 73;
            // 
            // lbValidade
            // 
            lbValidade.AutoSize = true;
            lbValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbValidade.ForeColor = System.Drawing.Color.Black;
            lbValidade.Location = new System.Drawing.Point(86, 415);
            lbValidade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbValidade.Name = "lbValidade";
            lbValidade.Size = new System.Drawing.Size(53, 17);
            lbValidade.TabIndex = 82;
            lbValidade.Text = "Validity";
            // 
            // txtId
            // 
            txtId.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            txtId.Enabled = false;
            txtId.Location = new System.Drawing.Point(143, 153);
            txtId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(70, 27);
            txtId.TabIndex = 80;
            txtId.Text = "0";
            // 
            // lbValorMinimo
            // 
            lbValorMinimo.AutoSize = true;
            lbValorMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbValorMinimo.ForeColor = System.Drawing.Color.Black;
            lbValorMinimo.Location = new System.Drawing.Point(39, 372);
            lbValorMinimo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbValorMinimo.Name = "lbValorMinimo";
            lbValorMinimo.Size = new System.Drawing.Size(100, 17);
            lbValorMinimo.TabIndex = 78;
            lbValorMinimo.Text = "Minimun Value";
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbValor.ForeColor = System.Drawing.Color.Black;
            lbValor.Location = new System.Drawing.Point(95, 332);
            lbValor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbValor.Name = "lbValor";
            lbValor.Size = new System.Drawing.Size(44, 17);
            lbValor.TabIndex = 77;
            lbValor.Text = "Value";
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            labelCodigo.ForeColor = System.Drawing.Color.Black;
            labelCodigo.Location = new System.Drawing.Point(98, 238);
            labelCodigo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new System.Drawing.Size(41, 17);
            labelCodigo.TabIndex = 76;
            labelCodigo.Text = "Code";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbNome.ForeColor = System.Drawing.Color.Black;
            lbNome.Location = new System.Drawing.Point(94, 198);
            lbNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbNome.Name = "lbNome";
            lbNome.Size = new System.Drawing.Size(45, 17);
            lbNome.TabIndex = 75;
            lbNome.Text = "Name";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbId.ForeColor = System.Drawing.Color.Black;
            lbId.Location = new System.Drawing.Point(120, 159);
            lbId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbId.Name = "lbId";
            lbId.Size = new System.Drawing.Size(19, 17);
            lbId.TabIndex = 74;
            lbId.Text = "Id";
            // 
            // txtNome
            // 
            txtNome.Location = new System.Drawing.Point(143, 193);
            txtNome.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new System.Drawing.Size(205, 27);
            txtNome.TabIndex = 1;
            // 
            // rBtnPorcentagem
            // 
            rBtnPorcentagem.AutoSize = true;
            rBtnPorcentagem.Location = new System.Drawing.Point(219, 287);
            rBtnPorcentagem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            rBtnPorcentagem.Name = "rBtnPorcentagem";
            rBtnPorcentagem.Size = new System.Drawing.Size(103, 24);
            rBtnPorcentagem.TabIndex = 4;
            rBtnPorcentagem.TabStop = true;
            rBtnPorcentagem.Text = "Percentage";
            rBtnPorcentagem.UseVisualStyleBackColor = true;
            rBtnPorcentagem.CheckedChanged += RBtnPorcentagem_CheckedChanged;
            // 
            // rBtnValorFixo
            // 
            rBtnValorFixo.AutoSize = true;
            rBtnValorFixo.Location = new System.Drawing.Point(105, 287);
            rBtnValorFixo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            rBtnValorFixo.Name = "rBtnValorFixo";
            rBtnValorFixo.Size = new System.Drawing.Size(105, 24);
            rBtnValorFixo.TabIndex = 3;
            rBtnValorFixo.TabStop = true;
            rBtnValorFixo.Text = "Fixed Value";
            rBtnValorFixo.UseVisualStyleBackColor = true;
            rBtnValorFixo.CheckedChanged += RBtnValorFixo_CheckedChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new System.Drawing.Point(143, 233);
            txtCodigo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new System.Drawing.Size(205, 27);
            txtCodigo.TabIndex = 2;
            // 
            // numUpDownValor
            // 
            numUpDownValor.Location = new System.Drawing.Point(143, 328);
            numUpDownValor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            numUpDownValor.Maximum = new decimal(new int[] { 15000, 0, 0, 0 });
            numUpDownValor.Name = "numUpDownValor";
            numUpDownValor.Size = new System.Drawing.Size(207, 27);
            numUpDownValor.TabIndex = 5;
            // 
            // numUpDownValorMinimo
            // 
            numUpDownValorMinimo.Location = new System.Drawing.Point(143, 368);
            numUpDownValorMinimo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            numUpDownValorMinimo.Maximum = new decimal(new int[] { 15000, 0, 0, 0 });
            numUpDownValorMinimo.Name = "numUpDownValorMinimo";
            numUpDownValorMinimo.Size = new System.Drawing.Size(207, 27);
            numUpDownValorMinimo.TabIndex = 6;
            // 
            // lblParceiro
            // 
            lblParceiro.AutoSize = true;
            lblParceiro.Location = new System.Drawing.Point(84, 459);
            lblParceiro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblParceiro.Name = "lblParceiro";
            lblParceiro.Size = new System.Drawing.Size(55, 20);
            lblParceiro.TabIndex = 83;
            lblParceiro.Text = "Partner";
            // 
            // cBoxParceiro
            // 
            cBoxParceiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cBoxParceiro.FormattingEnabled = true;
            cBoxParceiro.Location = new System.Drawing.Point(143, 456);
            cBoxParceiro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            cBoxParceiro.Name = "cBoxParceiro";
            cBoxParceiro.Size = new System.Drawing.Size(205, 28);
            cBoxParceiro.TabIndex = 84;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnCancelar.Location = new System.Drawing.Point(330, 537);
            btnCancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(101, 36);
            btnCancelar.TabIndex = 86;
            btnCancelar.Text = "Cancel";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnConfirmar.Location = new System.Drawing.Point(223, 537);
            btnConfirmar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(101, 36);
            btnConfirmar.TabIndex = 85;
            btnConfirmar.Text = "Submit";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += BtnConfirmar_Click;
            // 
            // TelaCupomForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(447, 591);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(cBoxParceiro);
            Controls.Add(lblParceiro);
            Controls.Add(numUpDownValorMinimo);
            Controls.Add(numUpDownValor);
            Controls.Add(txtCodigo);
            Controls.Add(rBtnValorFixo);
            Controls.Add(rBtnPorcentagem);
            Controls.Add(dtpValidade);
            Controls.Add(lbValidade);
            Controls.Add(txtId);
            Controls.Add(lbValorMinimo);
            Controls.Add(lbValor);
            Controls.Add(labelCodigo);
            Controls.Add(lbNome);
            Controls.Add(lbId);
            Controls.Add(txtNome);
            Controls.Add(labelTitulo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCupomForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Car Rental App";
            ((System.ComponentModel.ISupportInitialize)numUpDownValor).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownValorMinimo).EndInit();
            ResumeLayout(false);
            PerformLayout();
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