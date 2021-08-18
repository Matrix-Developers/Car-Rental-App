
namespace LocadoraDeVeiculos.WindowsApp.GrupoDeVeiculo
{
    partial class TarefaGrupoDeVeiculosForm
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
            this.textNomeGrupo = new System.Windows.Forms.TextBox();
            this.txtTaxaPlanoDiario = new System.Windows.Forms.TextBox();
            this.txtTaxaKMControlado = new System.Windows.Forms.TextBox();
            this.txtTaxaKMLivre = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.lblCadastroGrupoDeVeiculos = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbNomeGrupo = new System.Windows.Forms.Label();
            this.lbDiario = new System.Windows.Forms.Label();
            this.lbKMControlado = new System.Windows.Forms.Label();
            this.lbKMLivre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNomeGrupo
            // 
            this.textNomeGrupo.Location = new System.Drawing.Point(365, 65);
            this.textNomeGrupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNomeGrupo.Name = "textNomeGrupo";
            this.textNomeGrupo.Size = new System.Drawing.Size(132, 22);
            this.textNomeGrupo.TabIndex = 2;
            // 
            // txtTaxaPlanoDiario
            // 
            this.txtTaxaPlanoDiario.Location = new System.Drawing.Point(365, 107);
            this.txtTaxaPlanoDiario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaxaPlanoDiario.Name = "txtTaxaPlanoDiario";
            this.txtTaxaPlanoDiario.Size = new System.Drawing.Size(132, 22);
            this.txtTaxaPlanoDiario.TabIndex = 3;
            this.txtTaxaPlanoDiario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxaPlanoDiario_KeyPress);
            // 
            // txtTaxaKMControlado
            // 
            this.txtTaxaKMControlado.Location = new System.Drawing.Point(365, 150);
            this.txtTaxaKMControlado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaxaKMControlado.Name = "txtTaxaKMControlado";
            this.txtTaxaKMControlado.Size = new System.Drawing.Size(132, 22);
            this.txtTaxaKMControlado.TabIndex = 4;
            this.txtTaxaKMControlado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxaKMControlado_KeyPress);
            // 
            // txtTaxaKMLivre
            // 
            this.txtTaxaKMLivre.Location = new System.Drawing.Point(365, 190);
            this.txtTaxaKMLivre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaxaKMLivre.Name = "txtTaxaKMLivre";
            this.txtTaxaKMLivre.Size = new System.Drawing.Size(132, 22);
            this.txtTaxaKMLivre.TabIndex = 5;
            this.txtTaxaKMLivre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxaKMLivre_KeyPress);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(365, 23);
            this.textId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(132, 22);
            this.textId.TabIndex = 1;
            // 
            // lblCadastroGrupoDeVeiculos
            // 
            this.lblCadastroGrupoDeVeiculos.AutoSize = true;
            this.lblCadastroGrupoDeVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroGrupoDeVeiculos.ForeColor = System.Drawing.Color.Red;
            this.lblCadastroGrupoDeVeiculos.Location = new System.Drawing.Point(85, 30);
            this.lblCadastroGrupoDeVeiculos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastroGrupoDeVeiculos.Name = "lblCadastroGrupoDeVeiculos";
            this.lblCadastroGrupoDeVeiculos.Size = new System.Drawing.Size(349, 29);
            this.lblCadastroGrupoDeVeiculos.TabIndex = 47;
            this.lblCadastroGrupoDeVeiculos.Text = "Cadastro de Grupo de Veículos";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.Red;
            this.lbId.Location = new System.Drawing.Point(8, 20);
            this.lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(33, 29);
            this.lbId.TabIndex = 41;
            this.lbId.Text = "Id";
            // 
            // lbNomeGrupo
            // 
            this.lbNomeGrupo.AutoSize = true;
            this.lbNomeGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeGrupo.ForeColor = System.Drawing.Color.Red;
            this.lbNomeGrupo.Location = new System.Drawing.Point(8, 62);
            this.lbNomeGrupo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomeGrupo.Name = "lbNomeGrupo";
            this.lbNomeGrupo.Size = new System.Drawing.Size(182, 29);
            this.lbNomeGrupo.TabIndex = 42;
            this.lbNomeGrupo.Text = "Nome do grupo";
            // 
            // lbDiario
            // 
            this.lbDiario.AutoSize = true;
            this.lbDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiario.ForeColor = System.Drawing.Color.Red;
            this.lbDiario.Location = new System.Drawing.Point(8, 107);
            this.lbDiario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiario.Name = "lbDiario";
            this.lbDiario.Size = new System.Drawing.Size(238, 29);
            this.lbDiario.TabIndex = 43;
            this.lbDiario.Text = "Taxa de Plano Diário";
            // 
            // lbKMControlado
            // 
            this.lbKMControlado.AutoSize = true;
            this.lbKMControlado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKMControlado.ForeColor = System.Drawing.Color.Red;
            this.lbKMControlado.Location = new System.Drawing.Point(8, 149);
            this.lbKMControlado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKMControlado.Name = "lbKMControlado";
            this.lbKMControlado.Size = new System.Drawing.Size(330, 29);
            this.lbKMControlado.TabIndex = 44;
            this.lbKMControlado.Text = "Taxa de Plano KM controlado";
            // 
            // lbKMLivre
            // 
            this.lbKMLivre.AutoSize = true;
            this.lbKMLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKMLivre.ForeColor = System.Drawing.Color.Red;
            this.lbKMLivre.Location = new System.Drawing.Point(8, 186);
            this.lbKMLivre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKMLivre.Name = "lbKMLivre";
            this.lbKMLivre.Size = new System.Drawing.Size(261, 29);
            this.lbKMLivre.TabIndex = 45;
            this.lbKMLivre.Text = "Taxa de Plano KM livre";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(428, 302);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 34);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(13, 302);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 34);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbId);
            this.groupBox1.Controls.Add(this.lbKMLivre);
            this.groupBox1.Controls.Add(this.lbKMControlado);
            this.groupBox1.Controls.Add(this.textNomeGrupo);
            this.groupBox1.Controls.Add(this.lbDiario);
            this.groupBox1.Controls.Add(this.txtTaxaPlanoDiario);
            this.groupBox1.Controls.Add(this.lbNomeGrupo);
            this.groupBox1.Controls.Add(this.txtTaxaKMControlado);
            this.groupBox1.Controls.Add(this.textId);
            this.groupBox1.Controls.Add(this.txtTaxaKMLivre);
            this.groupBox1.Location = new System.Drawing.Point(13, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(515, 231);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // GrupodeVeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(537, 344);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblCadastroGrupoDeVeiculos);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GrupodeVeiculoForm";
            this.Text = "GrupodeVeiculo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNomeGrupo;
        private System.Windows.Forms.TextBox txtTaxaPlanoDiario;
        private System.Windows.Forms.TextBox txtTaxaKMControlado;
        private System.Windows.Forms.TextBox txtTaxaKMLivre;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label lblCadastroGrupoDeVeiculos;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbNomeGrupo;
        private System.Windows.Forms.Label lbDiario;
        private System.Windows.Forms.Label lbKMControlado;
        private System.Windows.Forms.Label lbKMLivre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}