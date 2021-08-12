
namespace LocadoraDeVeiculos.WindowsApp.GrupoDeVeiculos
{
    partial class GrupodeVeiculoForm
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
            this.textDiario = new System.Windows.Forms.TextBox();
            this.textKMControlado = new System.Windows.Forms.TextBox();
            this.textKMLivre = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.textNomeGrupo.Location = new System.Drawing.Point(274, 53);
            this.textNomeGrupo.Name = "textNomeGrupo";
            this.textNomeGrupo.Size = new System.Drawing.Size(100, 20);
            this.textNomeGrupo.TabIndex = 57;
            // 
            // textDiario
            // 
            this.textDiario.Location = new System.Drawing.Point(274, 87);
            this.textDiario.Name = "textDiario";
            this.textDiario.Size = new System.Drawing.Size(100, 20);
            this.textDiario.TabIndex = 56;
            // 
            // textKMControlado
            // 
            this.textKMControlado.Location = new System.Drawing.Point(274, 122);
            this.textKMControlado.Name = "textKMControlado";
            this.textKMControlado.Size = new System.Drawing.Size(100, 20);
            this.textKMControlado.TabIndex = 55;
            // 
            // textKMLivre
            // 
            this.textKMLivre.Location = new System.Drawing.Point(274, 154);
            this.textKMLivre.Name = "textKMLivre";
            this.textKMLivre.Size = new System.Drawing.Size(100, 20);
            this.textKMLivre.TabIndex = 54;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(274, 19);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(102, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 23);
            this.label8.TabIndex = 47;
            this.label8.Text = "Cadastro de Grupo de Veículos";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.Red;
            this.lbId.Location = new System.Drawing.Point(6, 16);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(22, 23);
            this.lbId.TabIndex = 41;
            this.lbId.Text = "Id";
            // 
            // lbNomeGrupo
            // 
            this.lbNomeGrupo.AutoSize = true;
            this.lbNomeGrupo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeGrupo.ForeColor = System.Drawing.Color.Red;
            this.lbNomeGrupo.Location = new System.Drawing.Point(6, 50);
            this.lbNomeGrupo.Name = "lbNomeGrupo";
            this.lbNomeGrupo.Size = new System.Drawing.Size(119, 23);
            this.lbNomeGrupo.TabIndex = 42;
            this.lbNomeGrupo.Text = "Nome do grupo";
            // 
            // lbDiario
            // 
            this.lbDiario.AutoSize = true;
            this.lbDiario.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiario.ForeColor = System.Drawing.Color.Red;
            this.lbDiario.Location = new System.Drawing.Point(6, 87);
            this.lbDiario.Name = "lbDiario";
            this.lbDiario.Size = new System.Drawing.Size(155, 23);
            this.lbDiario.TabIndex = 43;
            this.lbDiario.Text = "Taxa de Plano Diário";
            // 
            // lbKMControlado
            // 
            this.lbKMControlado.AutoSize = true;
            this.lbKMControlado.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKMControlado.ForeColor = System.Drawing.Color.Red;
            this.lbKMControlado.Location = new System.Drawing.Point(6, 121);
            this.lbKMControlado.Name = "lbKMControlado";
            this.lbKMControlado.Size = new System.Drawing.Size(215, 23);
            this.lbKMControlado.TabIndex = 44;
            this.lbKMControlado.Text = "Taxa de Plano KM controlado";
            // 
            // lbKMLivre
            // 
            this.lbKMLivre.AutoSize = true;
            this.lbKMLivre.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKMLivre.ForeColor = System.Drawing.Color.Red;
            this.lbKMLivre.Location = new System.Drawing.Point(6, 151);
            this.lbKMLivre.Name = "lbKMLivre";
            this.lbKMLivre.Size = new System.Drawing.Size(169, 23);
            this.lbKMLivre.TabIndex = 45;
            this.lbKMLivre.Text = "Taxa de Plano KM livre";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(206, 323);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(135, 323);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 28);
            this.btnConfirmar.TabIndex = 58;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbId);
            this.groupBox1.Controls.Add(this.lbKMLivre);
            this.groupBox1.Controls.Add(this.lbKMControlado);
            this.groupBox1.Controls.Add(this.textNomeGrupo);
            this.groupBox1.Controls.Add(this.lbDiario);
            this.groupBox1.Controls.Add(this.textDiario);
            this.groupBox1.Controls.Add(this.lbNomeGrupo);
            this.groupBox1.Controls.Add(this.textKMControlado);
            this.groupBox1.Controls.Add(this.textId);
            this.groupBox1.Controls.Add(this.textKMLivre);
            this.groupBox1.Location = new System.Drawing.Point(28, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 188);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // GrupodeVeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(464, 363);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label8);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "GrupodeVeiculoForm";
            this.Text = "GrupodeVeiculo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNomeGrupo;
        private System.Windows.Forms.TextBox textDiario;
        private System.Windows.Forms.TextBox textKMControlado;
        private System.Windows.Forms.TextBox textKMLivre;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label8;
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