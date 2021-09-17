
namespace LocadoraDeVeiculos.WindowsApp.Veiculos
{
    partial class VeiculoForm
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textPlaca = new System.Windows.Forms.TextBox();
            this.textChassi = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.lbGrupo = new System.Windows.Forms.Label();
            this.lbImagem = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbChassi = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.textCor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textKM = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gBoxDados = new System.Windows.Forms.GroupBox();
            this.btnImagem = new System.Windows.Forms.Button();
            this.cBoxCombustivel = new System.Windows.Forms.ComboBox();
            this.textAno = new System.Windows.Forms.TextBox();
            this.numUpDownCapTanque = new System.Windows.Forms.NumericUpDown();
            this.cBoxPortaMalas = new System.Windows.Forms.ComboBox();
            this.numUpDownQtdPessoas = new System.Windows.Forms.NumericUpDown();
            this.numUpDownQtdPortas = new System.Windows.Forms.NumericUpDown();
            this.cBoxGrupo = new System.Windows.Forms.ComboBox();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkLBoxOpcionais = new System.Windows.Forms.CheckedListBox();
            this.gBoxDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCapTanque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQtdPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQtdPortas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(105, 26);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(180, 20);
            this.labelTitulo.TabIndex = 64;
            this.labelTitulo.Text = "Cadastro de Veículos";
            // 
            // textPlaca
            // 
            this.textPlaca.Location = new System.Drawing.Point(97, 44);
            this.textPlaca.MaxLength = 7;
            this.textPlaca.Name = "textPlaca";
            this.textPlaca.Size = new System.Drawing.Size(217, 20);
            this.textPlaca.TabIndex = 1;
            // 
            // textChassi
            // 
            this.textChassi.Location = new System.Drawing.Point(97, 70);
            this.textChassi.Name = "textChassi";
            this.textChassi.Size = new System.Drawing.Size(217, 20);
            this.textChassi.TabIndex = 2;
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(97, 96);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(217, 20);
            this.textMarca.TabIndex = 3;
            // 
            // textModelo
            // 
            this.textModelo.Location = new System.Drawing.Point(97, 122);
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(217, 20);
            this.textModelo.TabIndex = 4;
            // 
            // textId
            // 
            this.textId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textId.Enabled = false;
            this.textId.Location = new System.Drawing.Point(97, 18);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(217, 20);
            this.textId.TabIndex = 73;
            // 
            // lbGrupo
            // 
            this.lbGrupo.AutoSize = true;
            this.lbGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbGrupo.ForeColor = System.Drawing.Color.Black;
            this.lbGrupo.Location = new System.Drawing.Point(55, 177);
            this.lbGrupo.Name = "lbGrupo";
            this.lbGrupo.Size = new System.Drawing.Size(36, 13);
            this.lbGrupo.TabIndex = 72;
            this.lbGrupo.Text = "Grupo";
            // 
            // lbImagem
            // 
            this.lbImagem.AutoSize = true;
            this.lbImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbImagem.ForeColor = System.Drawing.Color.Black;
            this.lbImagem.Location = new System.Drawing.Point(47, 204);
            this.lbImagem.Name = "lbImagem";
            this.lbImagem.Size = new System.Drawing.Size(44, 13);
            this.lbImagem.TabIndex = 71;
            this.lbImagem.Text = "Imagem";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbNome.ForeColor = System.Drawing.Color.Black;
            this.lbNome.Location = new System.Drawing.Point(75, 21);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(16, 13);
            this.lbNome.TabIndex = 65;
            this.lbNome.Text = "Id";
            // 
            // lbChassi
            // 
            this.lbChassi.AutoSize = true;
            this.lbChassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbChassi.ForeColor = System.Drawing.Color.Black;
            this.lbChassi.Location = new System.Drawing.Point(53, 73);
            this.lbChassi.Name = "lbChassi";
            this.lbChassi.Size = new System.Drawing.Size(38, 13);
            this.lbChassi.TabIndex = 67;
            this.lbChassi.Text = "Chassi";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbMarca.ForeColor = System.Drawing.Color.Black;
            this.lbMarca.Location = new System.Drawing.Point(54, 99);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(37, 13);
            this.lbMarca.TabIndex = 68;
            this.lbMarca.Text = "Marca";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbAno.ForeColor = System.Drawing.Color.Black;
            this.lbAno.Location = new System.Drawing.Point(65, 148);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(26, 13);
            this.lbAno.TabIndex = 70;
            this.lbAno.Text = "Ano";
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbModelo.ForeColor = System.Drawing.Color.Black;
            this.lbModelo.Location = new System.Drawing.Point(49, 125);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(42, 13);
            this.lbModelo.TabIndex = 69;
            this.lbModelo.Text = "Modelo";
            // 
            // textCor
            // 
            this.textCor.Location = new System.Drawing.Point(195, 148);
            this.textCor.Name = "textCor";
            this.textCor.Size = new System.Drawing.Size(119, 20);
            this.textCor.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(166, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "Cor";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(168, 230);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 91;
            this.label16.Text = "Tam. Porta Malas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(25, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 81;
            this.label11.Text = "Combustível";
            // 
            // textKM
            // 
            this.textKM.Location = new System.Drawing.Point(195, 280);
            this.textKM.Name = "textKM";
            this.textKM.Size = new System.Drawing.Size(119, 20);
            this.textKM.TabIndex = 13;
            this.textKM.Text = "0";
            this.textKM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextKM_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(29, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 85;
            this.label12.Text = "N° Pessoas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(207, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 84;
            this.label13.Text = "N° Portas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(22, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 83;
            this.label14.Text = "Cap. Tanque";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(166, 283);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 82;
            this.label15.Text = "Km";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancelar.Location = new System.Drawing.Point(305, 574);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnConfirmar.Location = new System.Drawing.Point(224, 574);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 16;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // gBoxDados
            // 
            this.gBoxDados.Controls.Add(this.btnImagem);
            this.gBoxDados.Controls.Add(this.cBoxCombustivel);
            this.gBoxDados.Controls.Add(this.textAno);
            this.gBoxDados.Controls.Add(this.numUpDownCapTanque);
            this.gBoxDados.Controls.Add(this.cBoxPortaMalas);
            this.gBoxDados.Controls.Add(this.label14);
            this.gBoxDados.Controls.Add(this.numUpDownQtdPessoas);
            this.gBoxDados.Controls.Add(this.numUpDownQtdPortas);
            this.gBoxDados.Controls.Add(this.label11);
            this.gBoxDados.Controls.Add(this.label16);
            this.gBoxDados.Controls.Add(this.cBoxGrupo);
            this.gBoxDados.Controls.Add(this.lbChassi);
            this.gBoxDados.Controls.Add(this.label12);
            this.gBoxDados.Controls.Add(this.label13);
            this.gBoxDados.Controls.Add(this.label15);
            this.gBoxDados.Controls.Add(this.textCor);
            this.gBoxDados.Controls.Add(this.lbPlaca);
            this.gBoxDados.Controls.Add(this.textKM);
            this.gBoxDados.Controls.Add(this.label10);
            this.gBoxDados.Controls.Add(this.lbImagem);
            this.gBoxDados.Controls.Add(this.lbNome);
            this.gBoxDados.Controls.Add(this.textModelo);
            this.gBoxDados.Controls.Add(this.textPlaca);
            this.gBoxDados.Controls.Add(this.lbMarca);
            this.gBoxDados.Controls.Add(this.lbModelo);
            this.gBoxDados.Controls.Add(this.lbGrupo);
            this.gBoxDados.Controls.Add(this.textChassi);
            this.gBoxDados.Controls.Add(this.textMarca);
            this.gBoxDados.Controls.Add(this.textId);
            this.gBoxDados.Controls.Add(this.lbAno);
            this.gBoxDados.ForeColor = System.Drawing.Color.Black;
            this.gBoxDados.Location = new System.Drawing.Point(12, 72);
            this.gBoxDados.Name = "gBoxDados";
            this.gBoxDados.Size = new System.Drawing.Size(367, 318);
            this.gBoxDados.TabIndex = 94;
            this.gBoxDados.TabStop = false;
            this.gBoxDados.Text = "Dados Obrigatórios";
            // 
            // btnImagem
            // 
            this.btnImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnImagem.Location = new System.Drawing.Point(97, 199);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(216, 23);
            this.btnImagem.TabIndex = 8;
            this.btnImagem.Text = "Inserir imagens";
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cBoxCombustivel
            // 
            this.cBoxCombustivel.FormattingEnabled = true;
            this.cBoxCombustivel.ItemHeight = 13;
            this.cBoxCombustivel.Items.AddRange(new object[] {
            "Gasolina",
            "Etanol",
            "Flex (Gasolina e Etanol)",
            "Diesel"});
            this.cBoxCombustivel.Location = new System.Drawing.Point(97, 253);
            this.cBoxCombustivel.Name = "cBoxCombustivel";
            this.cBoxCombustivel.Size = new System.Drawing.Size(92, 21);
            this.cBoxCombustivel.TabIndex = 10;
            this.cBoxCombustivel.Text = "Selecionar";
            // 
            // textAno
            // 
            this.textAno.Location = new System.Drawing.Point(97, 148);
            this.textAno.MaxLength = 4;
            this.textAno.Name = "textAno";
            this.textAno.Size = new System.Drawing.Size(51, 20);
            this.textAno.TabIndex = 5;
            this.textAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextAno_KeyPress);
            // 
            // numUpDownCapTanque
            // 
            this.numUpDownCapTanque.Location = new System.Drawing.Point(97, 227);
            this.numUpDownCapTanque.Name = "numUpDownCapTanque";
            this.numUpDownCapTanque.Size = new System.Drawing.Size(51, 20);
            this.numUpDownCapTanque.TabIndex = 9;
            // 
            // cBoxPortaMalas
            // 
            this.cBoxPortaMalas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPortaMalas.FormattingEnabled = true;
            this.cBoxPortaMalas.Items.AddRange(new object[] {
            "G",
            "M",
            "P"});
            this.cBoxPortaMalas.Location = new System.Drawing.Point(264, 227);
            this.cBoxPortaMalas.Name = "cBoxPortaMalas";
            this.cBoxPortaMalas.Size = new System.Drawing.Size(49, 21);
            this.cBoxPortaMalas.TabIndex = 14;
            // 
            // numUpDownQtdPessoas
            // 
            this.numUpDownQtdPessoas.Location = new System.Drawing.Point(97, 280);
            this.numUpDownQtdPessoas.Name = "numUpDownQtdPessoas";
            this.numUpDownQtdPessoas.Size = new System.Drawing.Size(48, 20);
            this.numUpDownQtdPessoas.TabIndex = 12;
            // 
            // numUpDownQtdPortas
            // 
            this.numUpDownQtdPortas.Location = new System.Drawing.Point(265, 254);
            this.numUpDownQtdPortas.Name = "numUpDownQtdPortas";
            this.numUpDownQtdPortas.Size = new System.Drawing.Size(48, 20);
            this.numUpDownQtdPortas.TabIndex = 11;
            // 
            // cBoxGrupo
            // 
            this.cBoxGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxGrupo.FormattingEnabled = true;
            this.cBoxGrupo.Location = new System.Drawing.Point(97, 174);
            this.cBoxGrupo.Name = "cBoxGrupo";
            this.cBoxGrupo.Size = new System.Drawing.Size(217, 21);
            this.cBoxGrupo.TabIndex = 7;
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbPlaca.ForeColor = System.Drawing.Color.Black;
            this.lbPlaca.Location = new System.Drawing.Point(57, 47);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(34, 13);
            this.lbPlaca.TabIndex = 66;
            this.lbPlaca.Text = "Placa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkLBoxOpcionais);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 159);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcionais";
            // 
            // checkLBoxOpcionais
            // 
            this.checkLBoxOpcionais.FormattingEnabled = true;
            this.checkLBoxOpcionais.Items.AddRange(new object[] {
            "Ar condicionado",
            "Direção Hidraulica",
            "Freio ABS"});
            this.checkLBoxOpcionais.Location = new System.Drawing.Point(6, 19);
            this.checkLBoxOpcionais.Name = "checkLBoxOpcionais";
            this.checkLBoxOpcionais.Size = new System.Drawing.Size(355, 124);
            this.checkLBoxOpcionais.TabIndex = 15;
            // 
            // VeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(392, 609);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBoxDados);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VeiculoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locadora de Veiculo";
            this.gBoxDados.ResumeLayout(false);
            this.gBoxDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCapTanque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQtdPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQtdPortas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textPlaca;
        private System.Windows.Forms.TextBox textChassi;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label lbGrupo;
        private System.Windows.Forms.Label lbImagem;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbChassi;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.TextBox textCor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textKM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox gBoxDados;
        private System.Windows.Forms.ComboBox cBoxGrupo;
        private System.Windows.Forms.NumericUpDown numUpDownCapTanque;
        private System.Windows.Forms.ComboBox cBoxPortaMalas;
        private System.Windows.Forms.NumericUpDown numUpDownQtdPessoas;
        private System.Windows.Forms.NumericUpDown numUpDownQtdPortas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkLBoxOpcionais;
        private System.Windows.Forms.TextBox textAno;
        private System.Windows.Forms.ComboBox cBoxCombustivel;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Button btnImagem;
    }
}