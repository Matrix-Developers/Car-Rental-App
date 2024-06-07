
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
            rdbDevolucoesConcluidas = new System.Windows.Forms.RadioButton();
            rdbDevolucoesPendentes = new System.Windows.Forms.RadioButton();
            rdbTodasDevolucoes = new System.Windows.Forms.RadioButton();
            btnCancelar = new System.Windows.Forms.Button();
            btnGravar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // rdbDevolucoesConcluidas
            // 
            rdbDevolucoesConcluidas.AutoSize = true;
            rdbDevolucoesConcluidas.Location = new System.Drawing.Point(65, 163);
            rdbDevolucoesConcluidas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rdbDevolucoesConcluidas.Name = "rdbDevolucoesConcluidas";
            rdbDevolucoesConcluidas.Size = new System.Drawing.Size(244, 24);
            rdbDevolucoesConcluidas.TabIndex = 9;
            rdbDevolucoesConcluidas.TabStop = true;
            rdbDevolucoesConcluidas.Text = "View only concluded Devolution";
            rdbDevolucoesConcluidas.UseVisualStyleBackColor = true;
            // 
            // rdbDevolucoesPendentes
            // 
            rdbDevolucoesPendentes.AutoSize = true;
            rdbDevolucoesPendentes.Location = new System.Drawing.Point(65, 111);
            rdbDevolucoesPendentes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rdbDevolucoesPendentes.Name = "rdbDevolucoesPendentes";
            rdbDevolucoesPendentes.Size = new System.Drawing.Size(236, 24);
            rdbDevolucoesPendentes.TabIndex = 8;
            rdbDevolucoesPendentes.TabStop = true;
            rdbDevolucoesPendentes.Text = "View only pending Devolutions";
            rdbDevolucoesPendentes.UseVisualStyleBackColor = true;
            // 
            // rdbTodasDevolucoes
            // 
            rdbTodasDevolucoes.AutoSize = true;
            rdbTodasDevolucoes.Location = new System.Drawing.Point(65, 58);
            rdbTodasDevolucoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rdbTodasDevolucoes.Name = "rdbTodasDevolucoes";
            rdbTodasDevolucoes.Size = new System.Drawing.Size(165, 24);
            rdbTodasDevolucoes.TabIndex = 7;
            rdbTodasDevolucoes.TabStop = true;
            rdbTodasDevolucoes.Text = "View all Devolutions";
            rdbTodasDevolucoes.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancelar.Location = new System.Drawing.Point(451, 240);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(100, 35);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancel";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnGravar.Location = new System.Drawing.Point(343, 240);
            btnGravar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new System.Drawing.Size(100, 35);
            btnGravar.TabIndex = 10;
            btnGravar.Text = "Filter";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // FiltroDevolucaoForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(567, 294);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(rdbDevolucoesConcluidas);
            Controls.Add(rdbDevolucoesPendentes);
            Controls.Add(rdbTodasDevolucoes);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FiltroDevolucaoForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Filter Vehicle Devolution";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RadioButton rdbDevolucoesConcluidas;
        private System.Windows.Forms.RadioButton rdbDevolucoesPendentes;
        private System.Windows.Forms.RadioButton rdbTodasDevolucoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
    }
}