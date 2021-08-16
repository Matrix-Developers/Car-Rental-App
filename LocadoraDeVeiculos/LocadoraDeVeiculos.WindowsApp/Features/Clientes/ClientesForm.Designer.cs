
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
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.lbValidade = new System.Windows.Forms.Label();
            this.maskRegistro = new System.Windows.Forms.MaskedTextBox();
            this.mskCNH = new System.Windows.Forms.MaskedTextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.labelCNH = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tetxtEmail = new System.Windows.Forms.TextBox();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RBSim = new System.Windows.Forms.RadioButton();
            this.RBNao = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(52, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "Cadastro de Clientes";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(33, 58);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(38, 17);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "PF";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(145, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 17);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "PJ";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(56, 439);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 28);
            this.btnConfirmar.TabIndex = 30;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(127, 439);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBNao);
            this.groupBox1.Controls.Add(this.RBSim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maskTelefone);
            this.groupBox1.Controls.Add(this.dtpValidade);
            this.groupBox1.Controls.Add(this.lbValidade);
            this.groupBox1.Controls.Add(this.maskRegistro);
            this.groupBox1.Controls.Add(this.mskCNH);
            this.groupBox1.Controls.Add(this.textId);
            this.groupBox1.Controls.Add(this.labelCNH);
            this.groupBox1.Controls.Add(this.lbTelefone);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.tetxtEmail);
            this.groupBox1.Controls.Add(this.lbEndereco);
            this.groupBox1.Controls.Add(this.labelRegistro);
            this.groupBox1.Controls.Add(this.textEndereco);
            this.groupBox1.Controls.Add(this.lbNome);
            this.groupBox1.Controls.Add(this.lbId);
            this.groupBox1.Controls.Add(this.textNome);
            this.groupBox1.Location = new System.Drawing.Point(4, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 340);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // maskTelefone
            // 
            this.maskTelefone.Location = new System.Drawing.Point(154, 164);
            this.maskTelefone.Mask = "(99) 00000-0000";
            this.maskTelefone.Name = "maskTelefone";
            this.maskTelefone.Size = new System.Drawing.Size(81, 20);
            this.maskTelefone.TabIndex = 37;
            // 
            // dtpValidade
            // 
            this.dtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidade.Location = new System.Drawing.Point(154, 275);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(90, 20);
            this.dtpValidade.TabIndex = 36;
            // 
            // lbValidade
            // 
            this.lbValidade.AutoSize = true;
            this.lbValidade.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValidade.ForeColor = System.Drawing.Color.Red;
            this.lbValidade.Location = new System.Drawing.Point(6, 273);
            this.lbValidade.Name = "lbValidade";
            this.lbValidade.Size = new System.Drawing.Size(109, 23);
            this.lbValidade.TabIndex = 35;
            this.lbValidade.Text = "Validade CNH";
            // 
            // maskRegistro
            // 
            this.maskRegistro.Location = new System.Drawing.Point(154, 94);
            this.maskRegistro.Mask = "___.___.___-__";
            this.maskRegistro.Name = "maskRegistro";
            this.maskRegistro.Size = new System.Drawing.Size(81, 20);
            this.maskRegistro.TabIndex = 34;
            // 
            // mskCNH
            // 
            this.mskCNH.Location = new System.Drawing.Point(154, 240);
            this.mskCNH.Mask = "_________-__";
            this.mskCNH.Name = "mskCNH";
            this.mskCNH.Size = new System.Drawing.Size(81, 20);
            this.mskCNH.TabIndex = 33;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(154, 19);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(131, 20);
            this.textId.TabIndex = 23;
            // 
            // labelCNH
            // 
            this.labelCNH.AutoSize = true;
            this.labelCNH.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCNH.ForeColor = System.Drawing.Color.Red;
            this.labelCNH.Location = new System.Drawing.Point(6, 234);
            this.labelCNH.Name = "labelCNH";
            this.labelCNH.Size = new System.Drawing.Size(43, 23);
            this.labelCNH.TabIndex = 29;
            this.labelCNH.Text = "CNH";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.ForeColor = System.Drawing.Color.Red;
            this.lbTelefone.Location = new System.Drawing.Point(6, 159);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(70, 23);
            this.lbTelefone.TabIndex = 21;
            this.lbTelefone.Text = "Telefone";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Red;
            this.lbEmail.Location = new System.Drawing.Point(6, 195);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(53, 23);
            this.lbEmail.TabIndex = 22;
            this.lbEmail.Text = "E-mail";
            // 
            // tetxtEmail
            // 
            this.tetxtEmail.Location = new System.Drawing.Point(154, 203);
            this.tetxtEmail.Name = "tetxtEmail";
            this.tetxtEmail.Size = new System.Drawing.Size(131, 20);
            this.tetxtEmail.TabIndex = 28;
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndereco.ForeColor = System.Drawing.Color.Red;
            this.lbEndereco.Location = new System.Drawing.Point(6, 125);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(78, 23);
            this.lbEndereco.TabIndex = 20;
            this.lbEndereco.Text = "Endereço";
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistro.ForeColor = System.Drawing.Color.Red;
            this.labelRegistro.Location = new System.Drawing.Point(6, 86);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(41, 23);
            this.labelRegistro.TabIndex = 19;
            this.labelRegistro.Text = "CPF";
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(154, 133);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(131, 20);
            this.textEndereco.TabIndex = 26;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.Red;
            this.lbNome.Location = new System.Drawing.Point(6, 50);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(52, 23);
            this.lbNome.TabIndex = 17;
            this.lbNome.Text = "Nome";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.Red;
            this.lbId.Location = new System.Drawing.Point(6, 16);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(22, 23);
            this.lbId.TabIndex = 14;
            this.lbId.Text = "Id";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(154, 54);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(131, 20);
            this.textNome.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "É pessoa fisíca?";
            // 
            // RBSim
            // 
            this.RBSim.AutoSize = true;
            this.RBSim.Location = new System.Drawing.Point(154, 317);
            this.RBSim.Name = "RBSim";
            this.RBSim.Size = new System.Drawing.Size(42, 17);
            this.RBSim.TabIndex = 39;
            this.RBSim.TabStop = true;
            this.RBSim.Text = "Sim";
            this.RBSim.UseVisualStyleBackColor = true;
            // 
            // RBNao
            // 
            this.RBNao.AutoSize = true;
            this.RBNao.Location = new System.Drawing.Point(202, 317);
            this.RBNao.Name = "RBNao";
            this.RBNao.Size = new System.Drawing.Size(45, 17);
            this.RBNao.TabIndex = 40;
            this.RBNao.TabStop = true;
            this.RBNao.Text = "Não";
            this.RBNao.UseVisualStyleBackColor = true;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(328, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label8);
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MaskedTextBox maskRegistro;
        private System.Windows.Forms.MaskedTextBox mskCNH;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBNao;
        private System.Windows.Forms.RadioButton RBSim;
    }
}