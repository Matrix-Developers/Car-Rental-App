
namespace LocadoraDeVeiculos.WindowsApp.Funcionarios
{
    partial class FuncionarioForm
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
            this.lbId = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbTituloCadastroDeFuncionarios = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.lbCargo = new System.Windows.Forms.Label();
            this.lbSalario = new System.Windows.Forms.Label();
            this.lbUsuAcesso = new System.Windows.Forms.Label();
            this.lbMatInt = new System.Windows.Forms.Label();
            this.lbDataAdmissao = new System.Windows.Forms.Label();
            this.textUsuarioAcesso = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskTxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskTxtDataAdmissao = new System.Windows.Forms.DateTimePicker();
            this.textMatriculaInterna = new System.Windows.Forms.NumericUpDown();
            this.textSalario = new System.Windows.Forms.NumericUpDown();
            this.textCargo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMatriculaInterna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSalario)).BeginInit();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.Red;
            this.lbId.Location = new System.Drawing.Point(12, 13);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(25, 24);
            this.lbId.TabIndex = 23;
            this.lbId.Text = "Id";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.Red;
            this.lbNome.Location = new System.Drawing.Point(12, 40);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(62, 24);
            this.lbNome.TabIndex = 24;
            this.lbNome.Text = "Nome";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.ForeColor = System.Drawing.Color.Red;
            this.lbCPF.Location = new System.Drawing.Point(12, 67);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(38, 24);
            this.lbCPF.TabIndex = 25;
            this.lbCPF.Text = "Cpf";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndereco.ForeColor = System.Drawing.Color.Red;
            this.lbEndereco.Location = new System.Drawing.Point(12, 92);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(94, 24);
            this.lbEndereco.TabIndex = 26;
            this.lbEndereco.Text = "Endereço";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Red;
            this.lbEmail.Location = new System.Drawing.Point(12, 144);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(63, 24);
            this.lbEmail.TabIndex = 28;
            this.lbEmail.Text = "E-mail";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.ForeColor = System.Drawing.Color.Red;
            this.lbTelefone.Location = new System.Drawing.Point(12, 121);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(85, 24);
            this.lbTelefone.TabIndex = 27;
            this.lbTelefone.Text = "Telefone";
            // 
            // lbTituloCadastroDeFuncionarios
            // 
            this.lbTituloCadastroDeFuncionarios.AutoSize = true;
            this.lbTituloCadastroDeFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloCadastroDeFuncionarios.ForeColor = System.Drawing.Color.Red;
            this.lbTituloCadastroDeFuncionarios.Location = new System.Drawing.Point(168, 43);
            this.lbTituloCadastroDeFuncionarios.Name = "lbTituloCadastroDeFuncionarios";
            this.lbTituloCadastroDeFuncionarios.Size = new System.Drawing.Size(226, 24);
            this.lbTituloCadastroDeFuncionarios.TabIndex = 29;
            this.lbTituloCadastroDeFuncionarios.Text = "Cadastro de Funcionários";
            // 
            // textId
            // 
            this.textId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textId.Enabled = false;
            this.textId.Location = new System.Drawing.Point(111, 19);
            this.textId.MaxLength = 200;
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 32;
            this.textId.Text = "0";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(111, 149);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 20);
            this.textEmail.TabIndex = 5;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(111, 97);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(100, 20);
            this.textEndereco.TabIndex = 3;
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCargo.ForeColor = System.Drawing.Color.Red;
            this.lbCargo.Location = new System.Drawing.Point(6, 107);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(61, 24);
            this.lbCargo.TabIndex = 44;
            this.lbCargo.Text = "Cargo";
            // 
            // lbSalario
            // 
            this.lbSalario.AutoSize = true;
            this.lbSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalario.ForeColor = System.Drawing.Color.Red;
            this.lbSalario.Location = new System.Drawing.Point(6, 132);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(67, 24);
            this.lbSalario.TabIndex = 43;
            this.lbSalario.Text = "Salário";
            // 
            // lbUsuAcesso
            // 
            this.lbUsuAcesso.AutoSize = true;
            this.lbUsuAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuAcesso.ForeColor = System.Drawing.Color.Red;
            this.lbUsuAcesso.Location = new System.Drawing.Point(6, 55);
            this.lbUsuAcesso.Name = "lbUsuAcesso";
            this.lbUsuAcesso.Size = new System.Drawing.Size(169, 24);
            this.lbUsuAcesso.TabIndex = 42;
            this.lbUsuAcesso.Text = "Usuário de Acesso";
            // 
            // lbMatInt
            // 
            this.lbMatInt.AutoSize = true;
            this.lbMatInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatInt.ForeColor = System.Drawing.Color.Red;
            this.lbMatInt.Location = new System.Drawing.Point(6, 31);
            this.lbMatInt.Name = "lbMatInt";
            this.lbMatInt.Size = new System.Drawing.Size(85, 24);
            this.lbMatInt.TabIndex = 41;
            this.lbMatInt.Text = "Matricula";
            // 
            // lbDataAdmissao
            // 
            this.lbDataAdmissao.AutoSize = true;
            this.lbDataAdmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataAdmissao.ForeColor = System.Drawing.Color.Red;
            this.lbDataAdmissao.Location = new System.Drawing.Point(6, 84);
            this.lbDataAdmissao.Name = "lbDataAdmissao";
            this.lbDataAdmissao.Size = new System.Drawing.Size(162, 24);
            this.lbDataAdmissao.TabIndex = 45;
            this.lbDataAdmissao.Text = "Data de Admissão";
            // 
            // textUsuarioAcesso
            // 
            this.textUsuarioAcesso.Location = new System.Drawing.Point(181, 60);
            this.textUsuarioAcesso.Name = "textUsuarioAcesso";
            this.textUsuarioAcesso.Size = new System.Drawing.Size(100, 20);
            this.textUsuarioAcesso.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskTxtTelefone);
            this.groupBox1.Controls.Add(this.mskTxtCpf);
            this.groupBox1.Controls.Add(this.lbId);
            this.groupBox1.Controls.Add(this.lbTelefone);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.lbEndereco);
            this.groupBox1.Controls.Add(this.lbCPF);
            this.groupBox1.Controls.Add(this.lbNome);
            this.groupBox1.Controls.Add(this.textId);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.textEndereco);
            this.groupBox1.Controls.Add(this.textNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 180);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // mskTxtTelefone
            // 
            this.mskTxtTelefone.Location = new System.Drawing.Point(111, 123);
            this.mskTxtTelefone.Mask = "(00) 00000-0000";
            this.mskTxtTelefone.Name = "mskTxtTelefone";
            this.mskTxtTelefone.Size = new System.Drawing.Size(100, 20);
            this.mskTxtTelefone.TabIndex = 4;
            // 
            // mskTxtCpf
            // 
            this.mskTxtCpf.Location = new System.Drawing.Point(111, 71);
            this.mskTxtCpf.Mask = "000.000.000-00";
            this.mskTxtCpf.Name = "mskTxtCpf";
            this.mskTxtCpf.Size = new System.Drawing.Size(100, 20);
            this.mskTxtCpf.TabIndex = 2;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(111, 45);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskTxtDataAdmissao);
            this.groupBox2.Controls.Add(this.textMatriculaInterna);
            this.groupBox2.Controls.Add(this.textSalario);
            this.groupBox2.Controls.Add(this.lbDataAdmissao);
            this.groupBox2.Controls.Add(this.lbMatInt);
            this.groupBox2.Controls.Add(this.textUsuarioAcesso);
            this.groupBox2.Controls.Add(this.lbUsuAcesso);
            this.groupBox2.Controls.Add(this.lbSalario);
            this.groupBox2.Controls.Add(this.textCargo);
            this.groupBox2.Controls.Add(this.lbCargo);
            this.groupBox2.Location = new System.Drawing.Point(248, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 180);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            // 
            // mskTxtDataAdmissao
            // 
            this.mskTxtDataAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mskTxtDataAdmissao.Location = new System.Drawing.Point(181, 86);
            this.mskTxtDataAdmissao.Name = "mskTxtDataAdmissao";
            this.mskTxtDataAdmissao.Size = new System.Drawing.Size(99, 20);
            this.mskTxtDataAdmissao.TabIndex = 8;
            // 
            // textMatriculaInterna
            // 
            this.textMatriculaInterna.Location = new System.Drawing.Point(181, 34);
            this.textMatriculaInterna.Name = "textMatriculaInterna";
            this.textMatriculaInterna.Size = new System.Drawing.Size(99, 20);
            this.textMatriculaInterna.TabIndex = 6;
            // 
            // textSalario
            // 
            this.textSalario.Location = new System.Drawing.Point(181, 138);
            this.textSalario.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.textSalario.Name = "textSalario";
            this.textSalario.Size = new System.Drawing.Size(100, 20);
            this.textSalario.TabIndex = 10;
            // 
            // textCargo
            // 
            this.textCargo.Location = new System.Drawing.Point(181, 112);
            this.textCargo.Name = "textCargo";
            this.textCargo.Size = new System.Drawing.Size(100, 20);
            this.textCargo.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(454, 288);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 28);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(12, 288);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(90, 28);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FuncionarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(547, 326);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTituloCadastroDeFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FuncionarioForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMatriculaInterna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSalario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbTituloCadastroDeFuncionarios;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.Label lbSalario;
        private System.Windows.Forms.Label lbUsuAcesso;
        private System.Windows.Forms.Label lbMatInt;
        private System.Windows.Forms.Label lbDataAdmissao;
        private System.Windows.Forms.TextBox textUsuarioAcesso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.MaskedTextBox mskTxtTelefone;
        private System.Windows.Forms.MaskedTextBox mskTxtCpf;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.NumericUpDown textSalario;
        private System.Windows.Forms.NumericUpDown textMatriculaInterna;
        private System.Windows.Forms.DateTimePicker mskTxtDataAdmissao;
        private System.Windows.Forms.TextBox textCargo;
    }
}