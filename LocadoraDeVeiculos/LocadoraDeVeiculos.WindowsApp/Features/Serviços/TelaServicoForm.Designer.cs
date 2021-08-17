
namespace LocadoraDeVeiculos.WindowsApp.Features.Serviços
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.labelCalculoFixo = new System.Windows.Forms.Label();
            this.labelCalculoDiario = new System.Windows.Forms.Label();
            this.rdbTaxaFixa = new System.Windows.Forms.RadioButton();
            this.rdbCalcDiaria = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTipoCalculo = new System.Windows.Forms.Label();
            this.lblCadastroServico = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.Red;
            this.labelNome.Location = new System.Drawing.Point(10, 49);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(79, 29);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.ForeColor = System.Drawing.Color.Red;
            this.labelValor.Location = new System.Drawing.Point(10, 78);
            this.labelValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(69, 29);
            this.labelValor.TabIndex = 1;
            this.labelValor.Text = "Valor";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(128, 49);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 200;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(153, 22);
            this.txtNome.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(128, 83);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.MaxLength = 200;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(153, 22);
            this.txtValor.TabIndex = 3;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // labelCalculoFixo
            // 
            this.labelCalculoFixo.AutoSize = true;
            this.labelCalculoFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalculoFixo.ForeColor = System.Drawing.Color.Red;
            this.labelCalculoFixo.Location = new System.Drawing.Point(89, 172);
            this.labelCalculoFixo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCalculoFixo.Name = "labelCalculoFixo";
            this.labelCalculoFixo.Size = new System.Drawing.Size(146, 29);
            this.labelCalculoFixo.TabIndex = 5;
            this.labelCalculoFixo.Text = "Cálculo Fixo";
            // 
            // labelCalculoDiario
            // 
            this.labelCalculoDiario.AutoSize = true;
            this.labelCalculoDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalculoDiario.ForeColor = System.Drawing.Color.Red;
            this.labelCalculoDiario.Location = new System.Drawing.Point(89, 138);
            this.labelCalculoDiario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCalculoDiario.Name = "labelCalculoDiario";
            this.labelCalculoDiario.Size = new System.Drawing.Size(164, 29);
            this.labelCalculoDiario.TabIndex = 4;
            this.labelCalculoDiario.Text = "Cálculo Diário";
            // 
            // rdbTaxaFixa
            // 
            this.rdbTaxaFixa.AutoSize = true;
            this.rdbTaxaFixa.Location = new System.Drawing.Point(64, 182);
            this.rdbTaxaFixa.Margin = new System.Windows.Forms.Padding(4);
            this.rdbTaxaFixa.Name = "rdbTaxaFixa";
            this.rdbTaxaFixa.Size = new System.Drawing.Size(17, 16);
            this.rdbTaxaFixa.TabIndex = 4;
            this.rdbTaxaFixa.TabStop = true;
            this.rdbTaxaFixa.UseVisualStyleBackColor = true;
            // 
            // rdbCalcDiaria
            // 
            this.rdbCalcDiaria.AutoSize = true;
            this.rdbCalcDiaria.Checked = true;
            this.rdbCalcDiaria.Location = new System.Drawing.Point(64, 148);
            this.rdbCalcDiaria.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCalcDiaria.Name = "rdbCalcDiaria";
            this.rdbCalcDiaria.Size = new System.Drawing.Size(17, 16);
            this.rdbCalcDiaria.TabIndex = 5;
            this.rdbCalcDiaria.TabStop = true;
            this.rdbCalcDiaria.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(205, 287);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 34);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirma
            // 
            this.btnConfirma.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.Location = new System.Drawing.Point(16, 287);
            this.btnConfirma.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(100, 34);
            this.btnConfirma.TabIndex = 6;
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(128, 19);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.MaxLength = 200;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(153, 22);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "0";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.Color.Red;
            this.labelId.Location = new System.Drawing.Point(10, 19);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(33, 29);
            this.labelId.TabIndex = 7;
            this.labelId.Text = "Id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTipoCalculo);
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.rdbTaxaFixa);
            this.groupBox1.Controls.Add(this.labelCalculoFixo);
            this.groupBox1.Controls.Add(this.rdbCalcDiaria);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.labelCalculoDiario);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.labelNome);
            this.groupBox1.Controls.Add(this.labelValor);
            this.groupBox1.Location = new System.Drawing.Point(16, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(289, 213);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // lblTipoCalculo
            // 
            this.lblTipoCalculo.AutoSize = true;
            this.lblTipoCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCalculo.ForeColor = System.Drawing.Color.Red;
            this.lblTipoCalculo.Location = new System.Drawing.Point(10, 109);
            this.lblTipoCalculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoCalculo.Name = "lblTipoCalculo";
            this.lblTipoCalculo.Size = new System.Drawing.Size(162, 29);
            this.lblTipoCalculo.TabIndex = 53;
            this.lblTipoCalculo.Text = "Tipo de Taxa:";
            // 
            // lblCadastroServico
            // 
            this.lblCadastroServico.AutoSize = true;
            this.lblCadastroServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroServico.ForeColor = System.Drawing.Color.Red;
            this.lblCadastroServico.Location = new System.Drawing.Point(41, 23);
            this.lblCadastroServico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastroServico.Name = "lblCadastroServico";
            this.lblCadastroServico.Size = new System.Drawing.Size(243, 29);
            this.lblCadastroServico.TabIndex = 53;
            this.lblCadastroServico.Text = "Cadastro de Serviços";
            // 
            // TelaServicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(319, 333);
            this.Controls.Add(this.lblCadastroServico);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirma);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaServicoForm";
            this.Text = "Serviço";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServicoForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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