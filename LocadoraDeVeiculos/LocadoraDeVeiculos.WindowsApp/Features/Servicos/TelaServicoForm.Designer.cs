
namespace LocadoraDeVeiculos.WindowsApp.Features.Servicos
{
    partial class TelaServicoForm
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
            labelNome = new System.Windows.Forms.Label();
            labelValor = new System.Windows.Forms.Label();
            txtNome = new System.Windows.Forms.TextBox();
            txtValor = new System.Windows.Forms.TextBox();
            labelCalculoFixo = new System.Windows.Forms.Label();
            labelCalculoDiario = new System.Windows.Forms.Label();
            rdbTaxaFixa = new System.Windows.Forms.RadioButton();
            rdbCalcDiaria = new System.Windows.Forms.RadioButton();
            btnCancelar = new System.Windows.Forms.Button();
            btnConfirma = new System.Windows.Forms.Button();
            txtId = new System.Windows.Forms.TextBox();
            labelId = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            lblTipoCalculo = new System.Windows.Forms.Label();
            lblCadastroServico = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            labelNome.ForeColor = System.Drawing.Color.Black;
            labelNome.Location = new System.Drawing.Point(40, 74);
            labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelNome.Name = "labelNome";
            labelNome.Size = new System.Drawing.Size(45, 17);
            labelNome.TabIndex = 0;
            labelNome.Text = "Name";
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            labelValor.ForeColor = System.Drawing.Color.Black;
            labelValor.Location = new System.Drawing.Point(45, 114);
            labelValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelValor.Name = "labelValor";
            labelValor.Size = new System.Drawing.Size(44, 17);
            labelValor.TabIndex = 1;
            labelValor.Text = "Value";
            // 
            // txtNome
            // 
            txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            txtNome.Location = new System.Drawing.Point(95, 69);
            txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtNome.MaxLength = 200;
            txtNome.Name = "txtNome";
            txtNome.Size = new System.Drawing.Size(153, 23);
            txtNome.TabIndex = 2;
            // 
            // txtValor
            // 
            txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            txtValor.Location = new System.Drawing.Point(95, 109);
            txtValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtValor.MaxLength = 200;
            txtValor.Name = "txtValor";
            txtValor.Size = new System.Drawing.Size(153, 23);
            txtValor.TabIndex = 3;
            txtValor.KeyPress += TxtValor_KeyPress;
            // 
            // labelCalculoFixo
            // 
            labelCalculoFixo.AutoSize = true;
            labelCalculoFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            labelCalculoFixo.ForeColor = System.Drawing.Color.Black;
            labelCalculoFixo.Location = new System.Drawing.Point(121, 223);
            labelCalculoFixo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelCalculoFixo.Name = "labelCalculoFixo";
            labelCalculoFixo.Size = new System.Drawing.Size(68, 17);
            labelCalculoFixo.TabIndex = 5;
            labelCalculoFixo.Text = "Fixed Tax";
            // 
            // labelCalculoDiario
            // 
            labelCalculoDiario.AutoSize = true;
            labelCalculoDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            labelCalculoDiario.ForeColor = System.Drawing.Color.Black;
            labelCalculoDiario.Location = new System.Drawing.Point(121, 194);
            labelCalculoDiario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelCalculoDiario.Name = "labelCalculoDiario";
            labelCalculoDiario.Size = new System.Drawing.Size(66, 17);
            labelCalculoDiario.TabIndex = 4;
            labelCalculoDiario.Text = "Daily Tax";
            // 
            // rdbTaxaFixa
            // 
            rdbTaxaFixa.AutoSize = true;
            rdbTaxaFixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            rdbTaxaFixa.Location = new System.Drawing.Point(95, 223);
            rdbTaxaFixa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rdbTaxaFixa.Name = "rdbTaxaFixa";
            rdbTaxaFixa.Size = new System.Drawing.Size(17, 16);
            rdbTaxaFixa.TabIndex = 4;
            rdbTaxaFixa.TabStop = true;
            rdbTaxaFixa.UseVisualStyleBackColor = true;
            // 
            // rdbCalcDiaria
            // 
            rdbCalcDiaria.AutoSize = true;
            rdbCalcDiaria.Checked = true;
            rdbCalcDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            rdbCalcDiaria.Location = new System.Drawing.Point(95, 194);
            rdbCalcDiaria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rdbCalcDiaria.Name = "rdbCalcDiaria";
            rdbCalcDiaria.Size = new System.Drawing.Size(17, 16);
            rdbCalcDiaria.TabIndex = 5;
            rdbCalcDiaria.TabStop = true;
            rdbCalcDiaria.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnCancelar.Location = new System.Drawing.Point(203, 346);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(100, 35);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancel";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirma
            // 
            btnConfirma.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnConfirma.Location = new System.Drawing.Point(95, 346);
            btnConfirma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnConfirma.Name = "btnConfirma";
            btnConfirma.Size = new System.Drawing.Size(100, 35);
            btnConfirma.TabIndex = 6;
            btnConfirma.Text = "Submit";
            btnConfirma.UseVisualStyleBackColor = true;
            btnConfirma.Click += BtnConfirma_Click;
            // 
            // txtId
            // 
            txtId.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            txtId.Enabled = false;
            txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            txtId.Location = new System.Drawing.Point(95, 29);
            txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtId.MaxLength = 200;
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(153, 23);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            labelId.ForeColor = System.Drawing.Color.Black;
            labelId.Location = new System.Drawing.Point(65, 34);
            labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelId.Name = "labelId";
            labelId.Size = new System.Drawing.Size(19, 17);
            labelId.TabIndex = 7;
            labelId.Text = "Id";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTipoCalculo);
            groupBox1.Controls.Add(labelId);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(rdbTaxaFixa);
            groupBox1.Controls.Add(labelCalculoFixo);
            groupBox1.Controls.Add(rdbCalcDiaria);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(labelCalculoDiario);
            groupBox1.Controls.Add(txtValor);
            groupBox1.Controls.Add(labelNome);
            groupBox1.Controls.Add(labelValor);
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            groupBox1.Location = new System.Drawing.Point(16, 71);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Size = new System.Drawing.Size(289, 266);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            // 
            // lblTipoCalculo
            // 
            lblTipoCalculo.AutoSize = true;
            lblTipoCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTipoCalculo.ForeColor = System.Drawing.Color.Black;
            lblTipoCalculo.Location = new System.Drawing.Point(24, 165);
            lblTipoCalculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTipoCalculo.Name = "lblTipoCalculo";
            lblTipoCalculo.Size = new System.Drawing.Size(80, 17);
            lblTipoCalculo.TabIndex = 53;
            lblTipoCalculo.Text = "Tax Type:";
            // 
            // lblCadastroServico
            // 
            lblCadastroServico.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCadastroServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCadastroServico.ForeColor = System.Drawing.Color.Black;
            lblCadastroServico.Location = new System.Drawing.Point(1, 30);
            lblCadastroServico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCadastroServico.Name = "lblCadastroServico";
            lblCadastroServico.Size = new System.Drawing.Size(319, 25);
            lblCadastroServico.TabIndex = 53;
            lblCadastroServico.Text = "Register Services";
            lblCadastroServico.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TelaServicoForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(319, 402);
            Controls.Add(lblCadastroServico);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirma);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaServicoForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Car Rental App";
            FormClosing += ServicoForm_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label labelCalculoFixo;
        private System.Windows.Forms.Label labelCalculoDiario;
        private System.Windows.Forms.RadioButton rdbTaxaFixa;
        private System.Windows.Forms.RadioButton rdbCalcDiaria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTipoCalculo;
        private System.Windows.Forms.Label lblCadastroServico;
    }
}