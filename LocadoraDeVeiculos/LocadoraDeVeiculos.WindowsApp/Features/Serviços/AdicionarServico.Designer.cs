
namespace LocadoraDeVeiculos.WindowsApp.Features.Serviços
{
    partial class AdicionarServico
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
            this.labelTaxaFixa = new System.Windows.Forms.Label();
            this.labelCalcDiaria = new System.Windows.Forms.Label();
            this.rdbTaxaFixa = new System.Windows.Forms.RadioButton();
            this.rdbCalcDiaria = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.Red;
            this.labelNome.Location = new System.Drawing.Point(23, 63);
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
            this.labelValor.Location = new System.Drawing.Point(23, 104);
            this.labelValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(69, 29);
            this.labelValor.TabIndex = 1;
            this.labelValor.Text = "Valor";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(113, 70);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 200;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(132, 22);
            this.txtNome.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(113, 111);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.MaxLength = 200;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(132, 22);
            this.txtValor.TabIndex = 3;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // labelTaxaFixa
            // 
            this.labelTaxaFixa.AutoSize = true;
            this.labelTaxaFixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaxaFixa.ForeColor = System.Drawing.Color.Red;
            this.labelTaxaFixa.Location = new System.Drawing.Point(52, 147);
            this.labelTaxaFixa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaxaFixa.Name = "labelTaxaFixa";
            this.labelTaxaFixa.Size = new System.Drawing.Size(117, 29);
            this.labelTaxaFixa.TabIndex = 4;
            this.labelTaxaFixa.Text = "Taxa Fixa";
            // 
            // labelCalcDiaria
            // 
            this.labelCalcDiaria.AutoSize = true;
            this.labelCalcDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalcDiaria.ForeColor = System.Drawing.Color.Red;
            this.labelCalcDiaria.Location = new System.Drawing.Point(57, 176);
            this.labelCalcDiaria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCalcDiaria.Name = "labelCalcDiaria";
            this.labelCalcDiaria.Size = new System.Drawing.Size(136, 29);
            this.labelCalcDiaria.TabIndex = 5;
            this.labelCalcDiaria.Text = "Calc. Diária";
            // 
            // rdbTaxaFixa
            // 
            this.rdbTaxaFixa.AutoSize = true;
            this.rdbTaxaFixa.Location = new System.Drawing.Point(32, 151);
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
            this.rdbCalcDiaria.Location = new System.Drawing.Point(32, 186);
            this.rdbCalcDiaria.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCalcDiaria.Name = "rdbCalcDiaria";
            this.rdbCalcDiaria.Size = new System.Drawing.Size(17, 16);
            this.rdbCalcDiaria.TabIndex = 5;
            this.rdbCalcDiaria.TabStop = true;
            this.rdbCalcDiaria.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(172, 224);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 34);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.Location = new System.Drawing.Point(28, 224);
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
            this.txtId.Location = new System.Drawing.Point(113, 28);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.MaxLength = 200;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(132, 22);
            this.txtId.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.Color.Red;
            this.labelId.Location = new System.Drawing.Point(23, 21);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(33, 29);
            this.labelId.TabIndex = 7;
            this.labelId.Text = "Id";
            // 
            // AdicionarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(297, 273);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.rdbCalcDiaria);
            this.Controls.Add(this.rdbTaxaFixa);
            this.Controls.Add(this.labelCalcDiaria);
            this.Controls.Add(this.labelTaxaFixa);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelNome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdicionarServico";
            this.Text = "AdicionarServiço";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdicionarServico_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label labelTaxaFixa;
        private System.Windows.Forms.Label labelCalcDiaria;
        private System.Windows.Forms.RadioButton rdbTaxaFixa;
        private System.Windows.Forms.RadioButton rdbCalcDiaria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelId;
    }
}