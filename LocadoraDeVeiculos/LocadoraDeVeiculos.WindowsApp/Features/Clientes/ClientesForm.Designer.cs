
namespace LocadoraDeVeiculos.WindowsApp.ClientesModule
{
    partial class ClientesForm
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
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            btnConfirmar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            maskRegistro = new System.Windows.Forms.MaskedTextBox();
            maskedCNH = new System.Windows.Forms.MaskedTextBox();
            maskTelefone = new System.Windows.Forms.MaskedTextBox();
            dtpValidade = new System.Windows.Forms.DateTimePicker();
            lbValidade = new System.Windows.Forms.Label();
            textId = new System.Windows.Forms.TextBox();
            labelCNH = new System.Windows.Forms.Label();
            lbTelefone = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            tetxtEmail = new System.Windows.Forms.TextBox();
            lbEndereco = new System.Windows.Forms.Label();
            labelRegistro = new System.Windows.Forms.Label();
            textEndereco = new System.Windows.Forms.TextBox();
            lbNome = new System.Windows.Forms.Label();
            lbId = new System.Windows.Forms.Label();
            textNome = new System.Windows.Forms.TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.Black;
            label8.Location = new System.Drawing.Point(130, 25);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(153, 25);
            label8.TabIndex = 26;
            label8.Text = "Register Client";
            label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(74, 75);
            radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(126, 24);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Natural Person";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += RadioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(222, 75);
            radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(131, 24);
            radioButton2.TabIndex = 28;
            radioButton2.TabStop = true;
            radioButton2.Text = "Juridical Person";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += RadioButton2_CheckedChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnConfirmar.Location = new System.Drawing.Point(201, 495);
            btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(100, 35);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "Submit";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += BtnConfirmar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnCancelar.Location = new System.Drawing.Point(309, 494);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(100, 35);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancel";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskRegistro);
            groupBox1.Controls.Add(maskedCNH);
            groupBox1.Controls.Add(maskTelefone);
            groupBox1.Controls.Add(dtpValidade);
            groupBox1.Controls.Add(lbValidade);
            groupBox1.Controls.Add(textId);
            groupBox1.Controls.Add(labelCNH);
            groupBox1.Controls.Add(lbTelefone);
            groupBox1.Controls.Add(lbEmail);
            groupBox1.Controls.Add(tetxtEmail);
            groupBox1.Controls.Add(lbEndereco);
            groupBox1.Controls.Add(labelRegistro);
            groupBox1.Controls.Add(textEndereco);
            groupBox1.Controls.Add(lbNome);
            groupBox1.Controls.Add(lbId);
            groupBox1.Controls.Add(textNome);
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            groupBox1.ForeColor = System.Drawing.Color.Black;
            groupBox1.Location = new System.Drawing.Point(16, 125);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Size = new System.Drawing.Size(393, 360);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Client Form";
            // 
            // maskRegistro
            // 
            maskRegistro.Location = new System.Drawing.Point(148, 106);
            maskRegistro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            maskRegistro.Mask = "999.999.999-99";
            maskRegistro.Name = "maskRegistro";
            maskRegistro.Size = new System.Drawing.Size(119, 23);
            maskRegistro.TabIndex = 3;
            // 
            // maskedCNH
            // 
            maskedCNH.Location = new System.Drawing.Point(148, 266);
            maskedCNH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            maskedCNH.Mask = "000000000-90";
            maskedCNH.Name = "maskedCNH";
            maskedCNH.Size = new System.Drawing.Size(107, 23);
            maskedCNH.TabIndex = 7;
            // 
            // maskTelefone
            // 
            maskTelefone.Location = new System.Drawing.Point(148, 186);
            maskTelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            maskTelefone.Mask = "(99) 99999-9999";
            maskTelefone.Name = "maskTelefone";
            maskTelefone.Size = new System.Drawing.Size(119, 23);
            maskTelefone.TabIndex = 5;
            // 
            // dtpValidade
            // 
            dtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpValidade.Location = new System.Drawing.Point(148, 306);
            dtpValidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dtpValidade.Name = "dtpValidade";
            dtpValidade.Size = new System.Drawing.Size(119, 23);
            dtpValidade.TabIndex = 8;
            // 
            // lbValidade
            // 
            lbValidade.AutoSize = true;
            lbValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbValidade.ForeColor = System.Drawing.Color.Black;
            lbValidade.Location = new System.Drawing.Point(49, 312);
            lbValidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbValidade.Name = "lbValidade";
            lbValidade.Size = new System.Drawing.Size(86, 17);
            lbValidade.TabIndex = 35;
            lbValidade.Text = "CNH Validity";
            // 
            // textId
            // 
            textId.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            textId.Enabled = false;
            textId.Location = new System.Drawing.Point(148, 26);
            textId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            textId.Name = "textId";
            textId.Size = new System.Drawing.Size(173, 23);
            textId.TabIndex = 23;
            textId.Text = "0";
            // 
            // labelCNH
            // 
            labelCNH.AutoSize = true;
            labelCNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            labelCNH.ForeColor = System.Drawing.Color.Black;
            labelCNH.Location = new System.Drawing.Point(100, 271);
            labelCNH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelCNH.Name = "labelCNH";
            labelCNH.Size = new System.Drawing.Size(37, 17);
            labelCNH.TabIndex = 29;
            labelCNH.Text = "CNH";
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbTelefone.ForeColor = System.Drawing.Color.Black;
            lbTelefone.Location = new System.Drawing.Point(86, 192);
            lbTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new System.Drawing.Size(49, 17);
            lbTelefone.TabIndex = 21;
            lbTelefone.Text = "Phone";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbEmail.ForeColor = System.Drawing.Color.Black;
            lbEmail.Location = new System.Drawing.Point(93, 232);
            lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(42, 17);
            lbEmail.TabIndex = 22;
            lbEmail.Text = "Email";
            // 
            // tetxtEmail
            // 
            tetxtEmail.Location = new System.Drawing.Point(148, 226);
            tetxtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tetxtEmail.Name = "tetxtEmail";
            tetxtEmail.Size = new System.Drawing.Size(173, 23);
            tetxtEmail.TabIndex = 6;
            // 
            // lbEndereco
            // 
            lbEndereco.AutoSize = true;
            lbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbEndereco.ForeColor = System.Drawing.Color.Black;
            lbEndereco.Location = new System.Drawing.Point(75, 152);
            lbEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbEndereco.Name = "lbEndereco";
            lbEndereco.Size = new System.Drawing.Size(60, 17);
            lbEndereco.TabIndex = 20;
            lbEndereco.Text = "Address";
            // 
            // labelRegistro
            // 
            labelRegistro.AutoSize = true;
            labelRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            labelRegistro.ForeColor = System.Drawing.Color.Black;
            labelRegistro.Location = new System.Drawing.Point(101, 109);
            labelRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelRegistro.Name = "labelRegistro";
            labelRegistro.Size = new System.Drawing.Size(34, 17);
            labelRegistro.TabIndex = 19;
            labelRegistro.Text = "CPF";
            // 
            // textEndereco
            // 
            textEndereco.Location = new System.Drawing.Point(148, 146);
            textEndereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            textEndereco.Name = "textEndereco";
            textEndereco.Size = new System.Drawing.Size(173, 23);
            textEndereco.TabIndex = 4;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbNome.ForeColor = System.Drawing.Color.Black;
            lbNome.Location = new System.Drawing.Point(90, 72);
            lbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbNome.Name = "lbNome";
            lbNome.Size = new System.Drawing.Size(45, 17);
            lbNome.TabIndex = 17;
            lbNome.Text = "Name";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbId.ForeColor = System.Drawing.Color.Black;
            lbId.Location = new System.Drawing.Point(119, 31);
            lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbId.Name = "lbId";
            lbId.Size = new System.Drawing.Size(19, 17);
            lbId.TabIndex = 14;
            lbId.Text = "Id";
            // 
            // textNome
            // 
            textNome.Location = new System.Drawing.Point(148, 66);
            textNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            textNome.Name = "textNome";
            textNome.Size = new System.Drawing.Size(173, 23);
            textNome.TabIndex = 2;
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.SystemColors.Control;
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(425, 549);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label8);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClientesForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Register Client";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskTelefone;
        private System.Windows.Forms.DateTimePicker dtpValidade;
        private System.Windows.Forms.Label lbValidade;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label labelCNH;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tetxtEmail;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.MaskedTextBox maskedCNH;
        private System.Windows.Forms.MaskedTextBox maskRegistro;
    }
}