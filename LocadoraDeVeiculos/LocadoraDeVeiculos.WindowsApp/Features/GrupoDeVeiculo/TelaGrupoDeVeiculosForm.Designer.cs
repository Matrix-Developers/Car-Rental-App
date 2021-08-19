
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
            this.textQuantKMControl = new System.Windows.Forms.TextBox();
            this.lbQuantKMControl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNomeGrupo
            // 
            this.textNomeGrupo.Location = new System.Drawing.Point(274, 53);
            this.textNomeGrupo.Name = "textNomeGrupo";
            this.textNomeGrupo.Size = new System.Drawing.Size(100, 20);
            this.textNomeGrupo.TabIndex = 2;
            // 
            // txtTaxaPlanoDiario
            // 
            this.txtTaxaPlanoDiario.Location = new System.Drawing.Point(274, 87);
            this.txtTaxaPlanoDiario.Name = "txtTaxaPlanoDiario";
            this.txtTaxaPlanoDiario.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaPlanoDiario.TabIndex = 3;
            this.txtTaxaPlanoDiario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxaPlanoDiario_KeyPress);
            // 
            // txtTaxaKMControlado
            // 
            this.txtTaxaKMControlado.Location = new System.Drawing.Point(274, 122);
            this.txtTaxaKMControlado.Name = "txtTaxaKMControlado";
            this.txtTaxaKMControlado.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaKMControlado.TabIndex = 4;
            this.txtTaxaKMControlado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxaKMControlado_KeyPress);
            // 
            // txtTaxaKMLivre
            // 
            this.txtTaxaKMLivre.Location = new System.Drawing.Point(274, 154);
            this.txtTaxaKMLivre.Name = "txtTaxaKMLivre";
            this.txtTaxaKMLivre.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaKMLivre.TabIndex = 5;
            this.txtTaxaKMLivre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxaKMLivre_KeyPress);
            // 
            // textId
            // 
            this.textId.Enabled = false;
            this.textId.Location = new System.Drawing.Point(274, 19);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 1;
            this.textId.Text = "0";
            // 
            // lblCadastroGrupoDeVeiculos
            // 
            this.lblCadastroGrupoDeVeiculos.AutoSize = true;
            this.lblCadastroGrupoDeVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroGrupoDeVeiculos.ForeColor = System.Drawing.Color.Red;
            this.lblCadastroGrupoDeVeiculos.Location = new System.Drawing.Point(64, 24);
            this.lblCadastroGrupoDeVeiculos.Name = "lblCadastroGrupoDeVeiculos";
            this.lblCadastroGrupoDeVeiculos.Size = new System.Drawing.Size(274, 24);
            this.lblCadastroGrupoDeVeiculos.TabIndex = 47;
            this.lblCadastroGrupoDeVeiculos.Text = "Cadastro de Grupo de Veículos";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.Red;
            this.lbId.Location = new System.Drawing.Point(6, 16);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(25, 24);
            this.lbId.TabIndex = 41;
            this.lbId.Text = "Id";
            // 
            // lbNomeGrupo
            // 
            this.lbNomeGrupo.AutoSize = true;
            this.lbNomeGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeGrupo.ForeColor = System.Drawing.Color.Red;
            this.lbNomeGrupo.Location = new System.Drawing.Point(6, 50);
            this.lbNomeGrupo.Name = "lbNomeGrupo";
            this.lbNomeGrupo.Size = new System.Drawing.Size(144, 24);
            this.lbNomeGrupo.TabIndex = 42;
            this.lbNomeGrupo.Text = "Nome do grupo";
            // 
            // lbDiario
            // 
            this.lbDiario.AutoSize = true;
            this.lbDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiario.ForeColor = System.Drawing.Color.Red;
            this.lbDiario.Location = new System.Drawing.Point(6, 87);
            this.lbDiario.Name = "lbDiario";
            this.lbDiario.Size = new System.Drawing.Size(185, 24);
            this.lbDiario.TabIndex = 43;
            this.lbDiario.Text = "Taxa de Plano Diário";
            // 
            // lbKMControlado
            // 
            this.lbKMControlado.AutoSize = true;
            this.lbKMControlado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKMControlado.ForeColor = System.Drawing.Color.Red;
            this.lbKMControlado.Location = new System.Drawing.Point(6, 121);
            this.lbKMControlado.Name = "lbKMControlado";
            this.lbKMControlado.Size = new System.Drawing.Size(259, 24);
            this.lbKMControlado.TabIndex = 44;
            this.lbKMControlado.Text = "Taxa de Plano KM controlado";
            // 
            // lbKMLivre
            // 
            this.lbKMLivre.AutoSize = true;
            this.lbKMLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKMLivre.ForeColor = System.Drawing.Color.Red;
            this.lbKMLivre.Location = new System.Drawing.Point(6, 151);
            this.lbKMLivre.Name = "lbKMLivre";
            this.lbKMLivre.Size = new System.Drawing.Size(204, 24);
            this.lbKMLivre.TabIndex = 45;
            this.lbKMLivre.Text = "Taxa de Plano KM livre";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(303, 270);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 28);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(10, 270);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(88, 28);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textQuantKMControl);
            this.groupBox1.Controls.Add(this.lbQuantKMControl);
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
            this.groupBox1.Location = new System.Drawing.Point(10, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 213);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // textQuantKMControl
            // 
            this.textQuantKMControl.Location = new System.Drawing.Point(274, 188);
            this.textQuantKMControl.Name = "textQuantKMControl";
            this.textQuantKMControl.Size = new System.Drawing.Size(100, 20);
            this.textQuantKMControl.TabIndex = 47;
            // 
            // lbQuantKMControl
            // 
            this.lbQuantKMControl.AutoSize = true;
            this.lbQuantKMControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantKMControl.ForeColor = System.Drawing.Color.Red;
            this.lbQuantKMControl.Location = new System.Drawing.Point(6, 184);
            this.lbQuantKMControl.Name = "lbQuantKMControl";
            this.lbQuantKMControl.Size = new System.Drawing.Size(265, 24);
            this.lbQuantKMControl.TabIndex = 46;
            this.lbQuantKMControl.Text = "Quantidade de KM Controlado";
            // 
            // TarefaGrupoDeVeiculosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(403, 304);
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
        private System.Windows.Forms.TextBox textQuantKMControl;
        private System.Windows.Forms.Label lbQuantKMControl;
    }
}