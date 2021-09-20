
namespace LocadoraDeVeiculos.WindowsApp.GrupoDeVeiculos
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
            this.txtTaxaPorKmDiario = new System.Windows.Forms.TextBox();
            this.txtTaxaPlanoControlado = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.lblCadastroGrupoDeVeiculos = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbNomeGrupo = new System.Windows.Forms.Label();
            this.lbTaxaPlanoDiário = new System.Windows.Forms.Label();
            this.lbTaxaPorKMPlanoDiário = new System.Windows.Forms.Label();
            this.lbKMLivre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTaxaPlanoLivre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTaxaKmExcedidoControlado = new System.Windows.Forms.TextBox();
            this.txtTaxaPlanoLivre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLimiteKmControlado = new System.Windows.Forms.TextBox();
            this.lbLimiteKmControlado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNomeGrupo
            // 
            this.textNomeGrupo.Location = new System.Drawing.Point(235, 37);
            this.textNomeGrupo.Name = "textNomeGrupo";
            this.textNomeGrupo.Size = new System.Drawing.Size(100, 20);
            this.textNomeGrupo.TabIndex = 2;
            // 
            // txtTaxaPlanoDiario
            // 
            this.txtTaxaPlanoDiario.Location = new System.Drawing.Point(235, 63);
            this.txtTaxaPlanoDiario.Name = "txtTaxaPlanoDiario";
            this.txtTaxaPlanoDiario.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaPlanoDiario.TabIndex = 3;
            this.txtTaxaPlanoDiario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTaxaPlanoDiario_KeyPress);
            // 
            // txtTaxaPorKmDiario
            // 
            this.txtTaxaPorKmDiario.Location = new System.Drawing.Point(235, 89);
            this.txtTaxaPorKmDiario.Name = "txtTaxaPorKmDiario";
            this.txtTaxaPorKmDiario.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaPorKmDiario.TabIndex = 4;
            this.txtTaxaPorKmDiario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTaxaKmDiario_KeyPress);
            // 
            // txtTaxaPlanoControlado
            // 
            this.txtTaxaPlanoControlado.Location = new System.Drawing.Point(235, 115);
            this.txtTaxaPlanoControlado.Name = "txtTaxaPlanoControlado";
            this.txtTaxaPlanoControlado.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaPlanoControlado.TabIndex = 5;
            this.txtTaxaPlanoControlado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTaxaPlanoControlado_KeyPress);
            // 
            // textId
            // 
            this.textId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textId.Enabled = false;
            this.textId.Location = new System.Drawing.Point(235, 11);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 1;
            this.textId.Text = "0";
            // 
            // lblCadastroGrupoDeVeiculos
            // 
            this.lblCadastroGrupoDeVeiculos.AutoSize = true;
            this.lblCadastroGrupoDeVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCadastroGrupoDeVeiculos.ForeColor = System.Drawing.Color.Black;
            this.lblCadastroGrupoDeVeiculos.Location = new System.Drawing.Point(43, 18);
            this.lblCadastroGrupoDeVeiculos.Name = "lblCadastroGrupoDeVeiculos";
            this.lblCadastroGrupoDeVeiculos.Size = new System.Drawing.Size(260, 20);
            this.lblCadastroGrupoDeVeiculos.TabIndex = 47;
            this.lblCadastroGrupoDeVeiculos.Text = "Cadastro de Grupo de Veículos";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbId.ForeColor = System.Drawing.Color.Black;
            this.lbId.Location = new System.Drawing.Point(6, 14);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(16, 13);
            this.lbId.TabIndex = 41;
            this.lbId.Text = "Id";
            // 
            // lbNomeGrupo
            // 
            this.lbNomeGrupo.AutoSize = true;
            this.lbNomeGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbNomeGrupo.ForeColor = System.Drawing.Color.Black;
            this.lbNomeGrupo.Location = new System.Drawing.Point(6, 40);
            this.lbNomeGrupo.Name = "lbNomeGrupo";
            this.lbNomeGrupo.Size = new System.Drawing.Size(80, 13);
            this.lbNomeGrupo.TabIndex = 42;
            this.lbNomeGrupo.Text = "Nome do grupo";
            // 
            // lbTaxaPlanoDiário
            // 
            this.lbTaxaPlanoDiário.AutoSize = true;
            this.lbTaxaPlanoDiário.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbTaxaPlanoDiário.ForeColor = System.Drawing.Color.Black;
            this.lbTaxaPlanoDiário.Location = new System.Drawing.Point(6, 66);
            this.lbTaxaPlanoDiário.Name = "lbTaxaPlanoDiário";
            this.lbTaxaPlanoDiário.Size = new System.Drawing.Size(106, 13);
            this.lbTaxaPlanoDiário.TabIndex = 43;
            this.lbTaxaPlanoDiário.Text = "Taxa do Plano Diário";
            // 
            // lbTaxaPorKMPlanoDiário
            // 
            this.lbTaxaPorKMPlanoDiário.AutoSize = true;
            this.lbTaxaPorKMPlanoDiário.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbTaxaPorKMPlanoDiário.ForeColor = System.Drawing.Color.Black;
            this.lbTaxaPorKMPlanoDiário.Location = new System.Drawing.Point(6, 92);
            this.lbTaxaPorKMPlanoDiário.Name = "lbTaxaPorKMPlanoDiário";
            this.lbTaxaPorKMPlanoDiário.Size = new System.Drawing.Size(144, 13);
            this.lbTaxaPorKMPlanoDiário.TabIndex = 44;
            this.lbTaxaPorKMPlanoDiário.Text = "Taxa Por KM do Plano Diário";
            // 
            // lbKMLivre
            // 
            this.lbKMLivre.AutoSize = true;
            this.lbKMLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbKMLivre.ForeColor = System.Drawing.Color.Black;
            this.lbKMLivre.Location = new System.Drawing.Point(6, 118);
            this.lbKMLivre.Name = "lbKMLivre";
            this.lbKMLivre.Size = new System.Drawing.Size(130, 13);
            this.lbKMLivre.TabIndex = 45;
            this.lbKMLivre.Text = "Taxa do Plano Controlado";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancelar.Location = new System.Drawing.Point(280, 286);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnConfirmar.Location = new System.Drawing.Point(199, 286);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbTaxaPlanoLivre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTaxaKmExcedidoControlado);
            this.groupBox1.Controls.Add(this.txtTaxaPlanoLivre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLimiteKmControlado);
            this.groupBox1.Controls.Add(this.lbLimiteKmControlado);
            this.groupBox1.Controls.Add(this.lbId);
            this.groupBox1.Controls.Add(this.lbKMLivre);
            this.groupBox1.Controls.Add(this.lbTaxaPorKMPlanoDiário);
            this.groupBox1.Controls.Add(this.textNomeGrupo);
            this.groupBox1.Controls.Add(this.lbTaxaPlanoDiário);
            this.groupBox1.Controls.Add(this.txtTaxaPlanoDiario);
            this.groupBox1.Controls.Add(this.lbNomeGrupo);
            this.groupBox1.Controls.Add(this.txtTaxaPorKmDiario);
            this.groupBox1.Controls.Add(this.textId);
            this.groupBox1.Controls.Add(this.txtTaxaPlanoControlado);
            this.groupBox1.Location = new System.Drawing.Point(10, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 228);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(208, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "R$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(208, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "R$";
            // 
            // lbTaxaPlanoLivre
            // 
            this.lbTaxaPlanoLivre.AutoSize = true;
            this.lbTaxaPlanoLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbTaxaPlanoLivre.ForeColor = System.Drawing.Color.Black;
            this.lbTaxaPlanoLivre.Location = new System.Drawing.Point(6, 196);
            this.lbTaxaPlanoLivre.Name = "lbTaxaPlanoLivre";
            this.lbTaxaPlanoLivre.Size = new System.Drawing.Size(102, 13);
            this.lbTaxaPlanoLivre.TabIndex = 54;
            this.lbTaxaPlanoLivre.Text = "Taxa do Plano Livre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Taxa KM Excedido Plano Controlado";
            // 
            // txtTaxaKmExcedidoControlado
            // 
            this.txtTaxaKmExcedidoControlado.Location = new System.Drawing.Point(235, 167);
            this.txtTaxaKmExcedidoControlado.Name = "txtTaxaKmExcedidoControlado";
            this.txtTaxaKmExcedidoControlado.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaKmExcedidoControlado.TabIndex = 7;
            this.txtTaxaKmExcedidoControlado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTaxaKmExcedidoControlado_KeyPress);
            // 
            // txtTaxaPlanoLivre
            // 
            this.txtTaxaPlanoLivre.Location = new System.Drawing.Point(235, 193);
            this.txtTaxaPlanoLivre.Name = "txtTaxaPlanoLivre";
            this.txtTaxaPlanoLivre.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaPlanoLivre.TabIndex = 8;
            this.txtTaxaPlanoLivre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTaxaPlanoLivre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(208, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(208, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(208, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "R$";
            // 
            // txtLimiteKmControlado
            // 
            this.txtLimiteKmControlado.Location = new System.Drawing.Point(235, 141);
            this.txtLimiteKmControlado.Name = "txtLimiteKmControlado";
            this.txtLimiteKmControlado.Size = new System.Drawing.Size(100, 20);
            this.txtLimiteKmControlado.TabIndex = 6;
            this.txtLimiteKmControlado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLimiteKmControlado_KeyPress);
            // 
            // lbLimiteKmControlado
            // 
            this.lbLimiteKmControlado.AutoSize = true;
            this.lbLimiteKmControlado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbLimiteKmControlado.ForeColor = System.Drawing.Color.Black;
            this.lbLimiteKmControlado.Location = new System.Drawing.Point(6, 144);
            this.lbLimiteKmControlado.Name = "lbLimiteKmControlado";
            this.lbLimiteKmControlado.Size = new System.Drawing.Size(167, 13);
            this.lbLimiteKmControlado.TabIndex = 46;
            this.lbLimiteKmControlado.Text = "Limite de KM do Plano Controlado";
            // 
            // TarefaGrupoDeVeiculosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblCadastroGrupoDeVeiculos);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TarefaGrupoDeVeiculosForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locadora de Veículos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNomeGrupo;
        private System.Windows.Forms.TextBox txtTaxaPlanoDiario;
        private System.Windows.Forms.TextBox txtTaxaPorKmDiario;
        private System.Windows.Forms.TextBox txtTaxaPlanoControlado;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label lblCadastroGrupoDeVeiculos;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbNomeGrupo;
        private System.Windows.Forms.Label lbTaxaPlanoDiário;
        private System.Windows.Forms.Label lbTaxaPorKMPlanoDiário;
        private System.Windows.Forms.Label lbKMLivre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLimiteKmControlado;
        private System.Windows.Forms.Label lbLimiteKmControlado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTaxaPlanoLivre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTaxaKmExcedidoControlado;
        private System.Windows.Forms.TextBox txtTaxaPlanoLivre;
    }
}