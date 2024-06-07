
namespace LocadoraDeVeiculos.WindowsApp.Servicos
{
    partial class TelaSelecionarServicoForm
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
            label8 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            lblSeguro = new System.Windows.Forms.Label();
            cBoxSeguro = new System.Windows.Forms.ComboBox();
            cLBoxServicos = new System.Windows.Forms.CheckedListBox();
            button1 = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            btnConfirmar = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.Black;
            label8.Location = new System.Drawing.Point(76, 48);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(163, 25);
            label8.TabIndex = 63;
            label8.Text = "Select Services";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSeguro);
            groupBox1.Controls.Add(cBoxSeguro);
            groupBox1.Controls.Add(cLBoxServicos);
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            groupBox1.Location = new System.Drawing.Point(16, 108);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Size = new System.Drawing.Size(309, 366);
            groupBox1.TabIndex = 64;
            groupBox1.TabStop = false;
            // 
            // lblSeguro
            // 
            lblSeguro.AutoSize = true;
            lblSeguro.Location = new System.Drawing.Point(62, 325);
            lblSeguro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSeguro.Name = "lblSeguro";
            lblSeguro.Size = new System.Drawing.Size(70, 17);
            lblSeguro.TabIndex = 69;
            lblSeguro.Text = "Insurance";
            // 
            // cBoxSeguro
            // 
            cBoxSeguro.FormattingEnabled = true;
            cBoxSeguro.Items.AddRange(new object[] { "None", "Client Insurance", "Third Party Insurance" });
            cBoxSeguro.Location = new System.Drawing.Point(140, 322);
            cBoxSeguro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cBoxSeguro.Name = "cBoxSeguro";
            cBoxSeguro.Size = new System.Drawing.Size(160, 25);
            cBoxSeguro.TabIndex = 68;
            // 
            // cLBoxServicos
            // 
            cLBoxServicos.FormattingEnabled = true;
            cLBoxServicos.Location = new System.Drawing.Point(8, 29);
            cLBoxServicos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cLBoxServicos.Name = "cLBoxServicos";
            cLBoxServicos.Size = new System.Drawing.Size(292, 256);
            cLBoxServicos.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            button1.Location = new System.Drawing.Point(279, 45);
            button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(31, 35);
            button1.TabIndex = 65;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnCancelar.Location = new System.Drawing.Point(225, 483);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(100, 35);
            btnCancelar.TabIndex = 69;
            btnCancelar.Text = "Cancel";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnConfirmar.Location = new System.Drawing.Point(117, 483);
            btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(100, 35);
            btnConfirmar.TabIndex = 68;
            btnConfirmar.Text = "Submit";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += BtnConfirmar_Click;
            // 
            // TelaSelecionarServicoForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(341, 531);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaSelecionarServicoForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Car Rental App";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.CheckedListBox cLBoxServicos;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.ComboBox cBoxSeguro;
    }
}