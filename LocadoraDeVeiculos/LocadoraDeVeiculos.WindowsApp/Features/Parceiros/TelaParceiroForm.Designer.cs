
namespace LocadoraDeVeiculos.WindowsApp.Features.Parceiros
{
    partial class TelaParceiroForm
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
            lbPlaca = new System.Windows.Forms.Label();
            lbNome = new System.Windows.Forms.Label();
            txtNome = new System.Windows.Forms.TextBox();
            txtId = new System.Windows.Forms.TextBox();
            btnCancelar = new System.Windows.Forms.Button();
            btnConfirmar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            labelTitulo.ForeColor = System.Drawing.Color.Black;
            labelTitulo.Location = new System.Drawing.Point(162, 51);
            labelTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new System.Drawing.Size(167, 25);
            labelTitulo.TabIndex = 65;
            labelTitulo.Text = "Register Partner";
            labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPlaca
            // 
            lbPlaca.AutoSize = true;
            lbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbPlaca.ForeColor = System.Drawing.Color.Black;
            lbPlaca.Location = new System.Drawing.Point(82, 179);
            lbPlaca.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbPlaca.Name = "lbPlaca";
            lbPlaca.Size = new System.Drawing.Size(45, 17);
            lbPlaca.TabIndex = 76;
            lbPlaca.Text = "Name";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbNome.ForeColor = System.Drawing.Color.Black;
            lbNome.Location = new System.Drawing.Point(107, 139);
            lbNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbNome.Name = "lbNome";
            lbNome.Size = new System.Drawing.Size(19, 17);
            lbNome.TabIndex = 75;
            lbNome.Text = "Id";
            // 
            // txtNome
            // 
            txtNome.Location = new System.Drawing.Point(136, 173);
            txtNome.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            txtNome.MaxLength = 7;
            txtNome.Name = "txtNome";
            txtNome.Size = new System.Drawing.Size(287, 27);
            txtNome.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            txtId.Enabled = false;
            txtId.Location = new System.Drawing.Point(137, 133);
            txtId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new System.Drawing.Size(126, 27);
            txtId.TabIndex = 77;
            txtId.Text = "0";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnCancelar.Location = new System.Drawing.Point(376, 244);
            btnCancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(101, 36);
            btnCancelar.TabIndex = 79;
            btnCancelar.Text = "Cancel";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnConfirmar.Location = new System.Drawing.Point(267, 244);
            btnConfirmar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(101, 36);
            btnConfirmar.TabIndex = 78;
            btnConfirmar.Text = "Submit";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += BtnConfirmar_Click;
            // 
            // TelaParceiroForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(491, 299);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(lbPlaca);
            Controls.Add(lbNome);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(labelTitulo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaParceiroForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Car Rental App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}