
namespace LocadoraDeVeiculos.WindowsApp.Features.Devolucoes
{
    partial class FiltroDevolucaoForm
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
            this.rdbDevolucoesConcluidas = new System.Windows.Forms.RadioButton();
            this.rdbDevolucoesPendentes = new System.Windows.Forms.RadioButton();
            this.rdbTodasDevolucoes = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbDevolucoesConcluidas
            // 
            this.rdbDevolucoesConcluidas.AutoSize = true;
            this.rdbDevolucoesConcluidas.Location = new System.Drawing.Point(49, 106);
            this.rdbDevolucoesConcluidas.Name = "rdbDevolucoesConcluidas";
            this.rdbDevolucoesConcluidas.Size = new System.Drawing.Size(203, 17);
            this.rdbDevolucoesConcluidas.TabIndex = 9;
            this.rdbDevolucoesConcluidas.TabStop = true;
            this.rdbDevolucoesConcluidas.Text = "Visualizar somente tarefas concluídas";
            this.rdbDevolucoesConcluidas.UseVisualStyleBackColor = true;
            // 
            // rdbDevolucoesPendentes
            // 
            this.rdbDevolucoesPendentes.AutoSize = true;
            this.rdbDevolucoesPendentes.Location = new System.Drawing.Point(49, 72);
            this.rdbDevolucoesPendentes.Name = "rdbDevolucoesPendentes";
            this.rdbDevolucoesPendentes.Size = new System.Drawing.Size(200, 17);
            this.rdbDevolucoesPendentes.TabIndex = 8;
            this.rdbDevolucoesPendentes.TabStop = true;
            this.rdbDevolucoesPendentes.Text = "Visualizar somente tarefas pendentes";
            this.rdbDevolucoesPendentes.UseVisualStyleBackColor = true;
            // 
            // rdbTodasDevolucoes
            // 
            this.rdbTodasDevolucoes.AutoSize = true;
            this.rdbTodasDevolucoes.Location = new System.Drawing.Point(49, 38);
            this.rdbTodasDevolucoes.Name = "rdbTodasDevolucoes";
            this.rdbTodasDevolucoes.Size = new System.Drawing.Size(151, 17);
            this.rdbTodasDevolucoes.TabIndex = 7;
            this.rdbTodasDevolucoes.TabStop = true;
            this.rdbTodasDevolucoes.Text = "Visualizar todas as Tarefas";
            this.rdbTodasDevolucoes.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(338, 156);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(257, 156);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Filtrar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // FiltroDevolucaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 191);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.rdbDevolucoesConcluidas);
            this.Controls.Add(this.rdbDevolucoesPendentes);
            this.Controls.Add(this.rdbTodasDevolucoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FiltroDevolucaoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FiltroDevolucaoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbDevolucoesConcluidas;
        private System.Windows.Forms.RadioButton rdbDevolucoesPendentes;
        private System.Windows.Forms.RadioButton rdbTodasDevolucoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
    }
}