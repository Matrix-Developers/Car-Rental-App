
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
            textNomeGrupo = new System.Windows.Forms.TextBox();
            txtTaxaPlanoDiario = new System.Windows.Forms.TextBox();
            txtTaxaPorKmDiario = new System.Windows.Forms.TextBox();
            txtTaxaPlanoControlado = new System.Windows.Forms.TextBox();
            textId = new System.Windows.Forms.TextBox();
            lblCadastroGrupoDeVeiculos = new System.Windows.Forms.Label();
            lbId = new System.Windows.Forms.Label();
            lbNomeGrupo = new System.Windows.Forms.Label();
            lbTaxaPlanoDiário = new System.Windows.Forms.Label();
            lbTaxaPorKMPlanoDiário = new System.Windows.Forms.Label();
            lbKMLivre = new System.Windows.Forms.Label();
            btnCancelar = new System.Windows.Forms.Button();
            btnConfirmar = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lbTaxaPlanoLivre = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtTaxaKmExcedidoControlado = new System.Windows.Forms.TextBox();
            txtTaxaPlanoLivre = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtLimiteKmControlado = new System.Windows.Forms.TextBox();
            lbLimiteKmControlado = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textNomeGrupo
            // 
            textNomeGrupo.Location = new System.Drawing.Point(313, 57);
            textNomeGrupo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            textNomeGrupo.Name = "textNomeGrupo";
            textNomeGrupo.Size = new System.Drawing.Size(132, 27);
            textNomeGrupo.TabIndex = 2;
            // 
            // txtTaxaPlanoDiario
            // 
            txtTaxaPlanoDiario.Location = new System.Drawing.Point(313, 97);
            txtTaxaPlanoDiario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtTaxaPlanoDiario.Name = "txtTaxaPlanoDiario";
            txtTaxaPlanoDiario.Size = new System.Drawing.Size(132, 27);
            txtTaxaPlanoDiario.TabIndex = 3;
            txtTaxaPlanoDiario.KeyPress += TxtTaxaPlanoDiario_KeyPress;
            // 
            // txtTaxaPorKmDiario
            // 
            txtTaxaPorKmDiario.Location = new System.Drawing.Point(313, 137);
            txtTaxaPorKmDiario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtTaxaPorKmDiario.Name = "txtTaxaPorKmDiario";
            txtTaxaPorKmDiario.Size = new System.Drawing.Size(132, 27);
            txtTaxaPorKmDiario.TabIndex = 4;
            txtTaxaPorKmDiario.KeyPress += TxtTaxaKmDiario_KeyPress;
            // 
            // txtTaxaPlanoControlado
            // 
            txtTaxaPlanoControlado.Location = new System.Drawing.Point(313, 177);
            txtTaxaPlanoControlado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtTaxaPlanoControlado.Name = "txtTaxaPlanoControlado";
            txtTaxaPlanoControlado.Size = new System.Drawing.Size(132, 27);
            txtTaxaPlanoControlado.TabIndex = 5;
            txtTaxaPlanoControlado.KeyPress += TxtTaxaPlanoControlado_KeyPress;
            // 
            // textId
            // 
            textId.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            textId.Enabled = false;
            textId.Location = new System.Drawing.Point(313, 17);
            textId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            textId.Name = "textId";
            textId.Size = new System.Drawing.Size(132, 27);
            textId.TabIndex = 1;
            textId.Text = "0";
            // 
            // lblCadastroGrupoDeVeiculos
            // 
            lblCadastroGrupoDeVeiculos.AutoSize = true;
            lblCadastroGrupoDeVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            lblCadastroGrupoDeVeiculos.ForeColor = System.Drawing.Color.Black;
            lblCadastroGrupoDeVeiculos.Location = new System.Drawing.Point(119, 28);
            lblCadastroGrupoDeVeiculos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCadastroGrupoDeVeiculos.Name = "lblCadastroGrupoDeVeiculos";
            lblCadastroGrupoDeVeiculos.Size = new System.Drawing.Size(234, 25);
            lblCadastroGrupoDeVeiculos.TabIndex = 47;
            lblCadastroGrupoDeVeiculos.Text = "Register Vehicle Group";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbId.ForeColor = System.Drawing.Color.Black;
            lbId.Location = new System.Drawing.Point(8, 22);
            lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbId.Name = "lbId";
            lbId.Size = new System.Drawing.Size(19, 17);
            lbId.TabIndex = 41;
            lbId.Text = "Id";
            // 
            // lbNomeGrupo
            // 
            lbNomeGrupo.AutoSize = true;
            lbNomeGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbNomeGrupo.ForeColor = System.Drawing.Color.Black;
            lbNomeGrupo.Location = new System.Drawing.Point(8, 62);
            lbNomeGrupo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbNomeGrupo.Name = "lbNomeGrupo";
            lbNomeGrupo.Size = new System.Drawing.Size(87, 17);
            lbNomeGrupo.TabIndex = 42;
            lbNomeGrupo.Text = "Group name";
            // 
            // lbTaxaPlanoDiário
            // 
            lbTaxaPlanoDiário.AutoSize = true;
            lbTaxaPlanoDiário.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbTaxaPlanoDiário.ForeColor = System.Drawing.Color.Black;
            lbTaxaPlanoDiário.Location = new System.Drawing.Point(8, 102);
            lbTaxaPlanoDiário.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbTaxaPlanoDiário.Name = "lbTaxaPlanoDiário";
            lbTaxaPlanoDiário.Size = new System.Drawing.Size(98, 17);
            lbTaxaPlanoDiário.TabIndex = 43;
            lbTaxaPlanoDiário.Text = "Daily Plan Tax";
            // 
            // lbTaxaPorKMPlanoDiário
            // 
            lbTaxaPorKMPlanoDiário.AutoSize = true;
            lbTaxaPorKMPlanoDiário.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbTaxaPorKMPlanoDiário.ForeColor = System.Drawing.Color.Black;
            lbTaxaPorKMPlanoDiário.Location = new System.Drawing.Point(8, 142);
            lbTaxaPorKMPlanoDiário.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbTaxaPorKMPlanoDiário.Name = "lbTaxaPorKMPlanoDiário";
            lbTaxaPorKMPlanoDiário.Size = new System.Drawing.Size(163, 17);
            lbTaxaPorKMPlanoDiário.TabIndex = 44;
            lbTaxaPorKMPlanoDiário.Text = "Tax per KM of Daily Plan";
            // 
            // lbKMLivre
            // 
            lbKMLivre.AutoSize = true;
            lbKMLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbKMLivre.ForeColor = System.Drawing.Color.Black;
            lbKMLivre.Location = new System.Drawing.Point(8, 182);
            lbKMLivre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbKMLivre.Name = "lbKMLivre";
            lbKMLivre.Size = new System.Drawing.Size(166, 17);
            lbKMLivre.TabIndex = 45;
            lbKMLivre.Text = "Daily Controlled Plan Tax";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnCancelar.Location = new System.Drawing.Point(373, 440);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(100, 35);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancel";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnConfirmar.Location = new System.Drawing.Point(265, 440);
            btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(100, 35);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "Submit";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += BtnConfirmar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lbTaxaPlanoLivre);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTaxaKmExcedidoControlado);
            groupBox1.Controls.Add(txtTaxaPlanoLivre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtLimiteKmControlado);
            groupBox1.Controls.Add(lbLimiteKmControlado);
            groupBox1.Controls.Add(lbId);
            groupBox1.Controls.Add(lbKMLivre);
            groupBox1.Controls.Add(lbTaxaPorKMPlanoDiário);
            groupBox1.Controls.Add(textNomeGrupo);
            groupBox1.Controls.Add(lbTaxaPlanoDiário);
            groupBox1.Controls.Add(txtTaxaPlanoDiario);
            groupBox1.Controls.Add(lbNomeGrupo);
            groupBox1.Controls.Add(txtTaxaPorKmDiario);
            groupBox1.Controls.Add(textId);
            groupBox1.Controls.Add(txtTaxaPlanoControlado);
            groupBox1.Location = new System.Drawing.Point(13, 78);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Size = new System.Drawing.Size(460, 351);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(287, 302);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(16, 17);
            label4.TabIndex = 56;
            label4.Text = "$";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(287, 262);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(16, 17);
            label5.TabIndex = 55;
            label5.Text = "$";
            // 
            // lbTaxaPlanoLivre
            // 
            lbTaxaPlanoLivre.AutoSize = true;
            lbTaxaPlanoLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbTaxaPlanoLivre.ForeColor = System.Drawing.Color.Black;
            lbTaxaPlanoLivre.Location = new System.Drawing.Point(8, 302);
            lbTaxaPlanoLivre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbTaxaPlanoLivre.Name = "lbTaxaPlanoLivre";
            lbTaxaPlanoLivre.Size = new System.Drawing.Size(96, 17);
            lbTaxaPlanoLivre.TabIndex = 54;
            lbTaxaPlanoLivre.Text = "Tax Free Plan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(8, 262);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(209, 17);
            label7.TabIndex = 53;
            label7.Text = "Tax per Exceeded KM controled";
            // 
            // txtTaxaKmExcedidoControlado
            // 
            txtTaxaKmExcedidoControlado.Location = new System.Drawing.Point(313, 257);
            txtTaxaKmExcedidoControlado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtTaxaKmExcedidoControlado.Name = "txtTaxaKmExcedidoControlado";
            txtTaxaKmExcedidoControlado.Size = new System.Drawing.Size(132, 27);
            txtTaxaKmExcedidoControlado.TabIndex = 7;
            txtTaxaKmExcedidoControlado.KeyPress += TxtTaxaKmExcedidoControlado_KeyPress;
            // 
            // txtTaxaPlanoLivre
            // 
            txtTaxaPlanoLivre.Location = new System.Drawing.Point(313, 297);
            txtTaxaPlanoLivre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtTaxaPlanoLivre.Name = "txtTaxaPlanoLivre";
            txtTaxaPlanoLivre.Size = new System.Drawing.Size(132, 27);
            txtTaxaPlanoLivre.TabIndex = 8;
            txtTaxaPlanoLivre.KeyPress += TxtTaxaPlanoLivre_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(287, 182);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(16, 17);
            label3.TabIndex = 50;
            label3.Text = "$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(287, 142);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(16, 17);
            label2.TabIndex = 49;
            label2.Text = "$";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(287, 102);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(16, 17);
            label1.TabIndex = 48;
            label1.Text = "$";
            // 
            // txtLimiteKmControlado
            // 
            txtLimiteKmControlado.Location = new System.Drawing.Point(313, 217);
            txtLimiteKmControlado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtLimiteKmControlado.Name = "txtLimiteKmControlado";
            txtLimiteKmControlado.Size = new System.Drawing.Size(132, 27);
            txtLimiteKmControlado.TabIndex = 6;
            txtLimiteKmControlado.KeyPress += TxtLimiteKmControlado_KeyPress;
            // 
            // lbLimiteKmControlado
            // 
            lbLimiteKmControlado.AutoSize = true;
            lbLimiteKmControlado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbLimiteKmControlado.ForeColor = System.Drawing.Color.Black;
            lbLimiteKmControlado.Location = new System.Drawing.Point(8, 222);
            lbLimiteKmControlado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbLimiteKmControlado.Name = "lbLimiteKmControlado";
            lbLimiteKmControlado.Size = new System.Drawing.Size(129, 17);
            lbLimiteKmControlado.TabIndex = 46;
            lbLimiteKmControlado.Text = "Controlled KM Limit";
            // 
            // TarefaGrupoDeVeiculosForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(487, 488);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(lblCadastroGrupoDeVeiculos);
            ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TarefaGrupoDeVeiculosForm";
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