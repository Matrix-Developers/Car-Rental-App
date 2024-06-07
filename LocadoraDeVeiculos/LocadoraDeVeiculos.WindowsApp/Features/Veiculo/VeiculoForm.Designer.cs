
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
            labelTitulo = new System.Windows.Forms.Label();
            textPlaca = new System.Windows.Forms.TextBox();
            textChassi = new System.Windows.Forms.TextBox();
            textMarca = new System.Windows.Forms.TextBox();
            textModelo = new System.Windows.Forms.TextBox();
            textId = new System.Windows.Forms.TextBox();
            lbGrupo = new System.Windows.Forms.Label();
            lbNome = new System.Windows.Forms.Label();
            lbChassi = new System.Windows.Forms.Label();
            lbMarca = new System.Windows.Forms.Label();
            lbAno = new System.Windows.Forms.Label();
            lbModelo = new System.Windows.Forms.Label();
            textCor = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            textKM = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            btnCancelar = new System.Windows.Forms.Button();
            btnConfirmar = new System.Windows.Forms.Button();
            gBoxDados = new System.Windows.Forms.GroupBox();
            cBoxCombustivel = new System.Windows.Forms.ComboBox();
            textAno = new System.Windows.Forms.TextBox();
            numUpDownCapTanque = new System.Windows.Forms.NumericUpDown();
            cBoxPortaMalas = new System.Windows.Forms.ComboBox();
            numUpDownQtdPessoas = new System.Windows.Forms.NumericUpDown();
            numUpDownQtdPortas = new System.Windows.Forms.NumericUpDown();
            cBoxGrupo = new System.Windows.Forms.ComboBox();
            lbPlaca = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            checkLBoxOpcionais = new System.Windows.Forms.CheckedListBox();
            gBoxDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownCapTanque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownQtdPessoas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownQtdPortas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = System.Drawing.Color.Black;
            labelTitulo.Location = new System.Drawing.Point(176, 47);
            labelTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new System.Drawing.Size(169, 25);
            labelTitulo.TabIndex = 64;
            labelTitulo.Text = "Register Vehicle";
            // 
            // textPlaca
            // 
            textPlaca.Location = new System.Drawing.Point(129, 68);
            textPlaca.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            textPlaca.MaxLength = 7;
            textPlaca.Name = "textPlaca";
            textPlaca.Size = new System.Drawing.Size(287, 27);
            textPlaca.TabIndex = 1;
            // 
            // textChassi
            // 
            textChassi.Location = new System.Drawing.Point(129, 108);
            textChassi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            textChassi.Name = "textChassi";
            textChassi.Size = new System.Drawing.Size(287, 27);
            textChassi.TabIndex = 2;
            // 
            // textMarca
            // 
            textMarca.Location = new System.Drawing.Point(129, 148);
            textMarca.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            textMarca.Name = "textMarca";
            textMarca.Size = new System.Drawing.Size(287, 27);
            textMarca.TabIndex = 3;
            // 
            // textModelo
            // 
            textModelo.Location = new System.Drawing.Point(129, 188);
            textModelo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            textModelo.Name = "textModelo";
            textModelo.Size = new System.Drawing.Size(287, 27);
            textModelo.TabIndex = 4;
            // 
            // textId
            // 
            textId.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            textId.Enabled = false;
            textId.Location = new System.Drawing.Point(129, 28);
            textId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            textId.Name = "textId";
            textId.ReadOnly = true;
            textId.Size = new System.Drawing.Size(287, 27);
            textId.TabIndex = 73;
            // 
            // lbGrupo
            // 
            lbGrupo.AutoSize = true;
            lbGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbGrupo.ForeColor = System.Drawing.Color.Black;
            lbGrupo.Location = new System.Drawing.Point(73, 272);
            lbGrupo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbGrupo.Name = "lbGrupo";
            lbGrupo.Size = new System.Drawing.Size(48, 17);
            lbGrupo.TabIndex = 72;
            lbGrupo.Text = "Group";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbNome.ForeColor = System.Drawing.Color.Black;
            lbNome.Location = new System.Drawing.Point(101, 32);
            lbNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbNome.Name = "lbNome";
            lbNome.Size = new System.Drawing.Size(19, 17);
            lbNome.TabIndex = 65;
            lbNome.Text = "Id";
            // 
            // lbChassi
            // 
            lbChassi.AutoSize = true;
            lbChassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbChassi.ForeColor = System.Drawing.Color.Black;
            lbChassi.Location = new System.Drawing.Point(70, 113);
            lbChassi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbChassi.Name = "lbChassi";
            lbChassi.Size = new System.Drawing.Size(50, 17);
            lbChassi.TabIndex = 67;
            lbChassi.Text = "Chassi";
            // 
            // lbMarca
            // 
            lbMarca.AutoSize = true;
            lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbMarca.ForeColor = System.Drawing.Color.Black;
            lbMarca.Location = new System.Drawing.Point(74, 158);
            lbMarca.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new System.Drawing.Size(46, 17);
            lbMarca.TabIndex = 68;
            lbMarca.Text = "Brand";
            // 
            // lbAno
            // 
            lbAno.AutoSize = true;
            lbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbAno.ForeColor = System.Drawing.Color.Black;
            lbAno.Location = new System.Drawing.Point(82, 238);
            lbAno.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbAno.Name = "lbAno";
            lbAno.Size = new System.Drawing.Size(38, 17);
            lbAno.TabIndex = 70;
            lbAno.Text = "Year";
            // 
            // lbModelo
            // 
            lbModelo.AutoSize = true;
            lbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbModelo.ForeColor = System.Drawing.Color.Black;
            lbModelo.Location = new System.Drawing.Point(74, 193);
            lbModelo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbModelo.Name = "lbModelo";
            lbModelo.Size = new System.Drawing.Size(46, 17);
            lbModelo.TabIndex = 69;
            lbModelo.Text = "Model";
            // 
            // textCor
            // 
            textCor.Location = new System.Drawing.Point(259, 228);
            textCor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            textCor.Name = "textCor";
            textCor.Size = new System.Drawing.Size(157, 27);
            textCor.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label10.ForeColor = System.Drawing.Color.Black;
            label10.Location = new System.Drawing.Point(206, 233);
            label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(49, 17);
            label10.TabIndex = 81;
            label10.Text = "Colour";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label16.ForeColor = System.Drawing.Color.Black;
            label16.Location = new System.Drawing.Point(266, 312);
            label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(76, 17);
            label16.TabIndex = 91;
            label16.Text = "Trunk Size";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label11.ForeColor = System.Drawing.Color.Black;
            label11.Location = new System.Drawing.Point(50, 358);
            label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(71, 17);
            label11.TabIndex = 81;
            label11.Text = "Fuel Type";
            // 
            // textKM
            // 
            textKM.Location = new System.Drawing.Point(259, 388);
            textKM.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            textKM.Name = "textKM";
            textKM.Size = new System.Drawing.Size(157, 27);
            textKM.TabIndex = 13;
            textKM.Text = "0";
            textKM.KeyPress += TextKM_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label12.ForeColor = System.Drawing.Color.Black;
            label12.Location = new System.Drawing.Point(7, 393);
            label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(114, 17);
            label12.TabIndex = 85;
            label12.Text = "Number of Seats";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label13.ForeColor = System.Drawing.Color.Black;
            label13.Location = new System.Drawing.Point(296, 347);
            label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(46, 17);
            label13.TabIndex = 84;
            label13.Text = "Doors";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label14.ForeColor = System.Drawing.Color.Black;
            label14.Location = new System.Drawing.Point(27, 311);
            label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(93, 17);
            label14.TabIndex = 83;
            label14.Text = "Fuel Capacity";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label15.ForeColor = System.Drawing.Color.Black;
            label15.Location = new System.Drawing.Point(222, 393);
            label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(28, 17);
            label15.TabIndex = 82;
            label15.Text = "Km";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnCancelar.Location = new System.Drawing.Point(407, 801);
            btnCancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(101, 36);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancel";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnConfirmar.Location = new System.Drawing.Point(298, 801);
            btnConfirmar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(101, 36);
            btnConfirmar.TabIndex = 16;
            btnConfirmar.Text = "Submit";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += BtnConfirmar_Click;
            // 
            // gBoxDados
            // 
            gBoxDados.Controls.Add(cBoxCombustivel);
            gBoxDados.Controls.Add(textAno);
            gBoxDados.Controls.Add(numUpDownCapTanque);
            gBoxDados.Controls.Add(cBoxPortaMalas);
            gBoxDados.Controls.Add(label14);
            gBoxDados.Controls.Add(numUpDownQtdPessoas);
            gBoxDados.Controls.Add(numUpDownQtdPortas);
            gBoxDados.Controls.Add(label11);
            gBoxDados.Controls.Add(label16);
            gBoxDados.Controls.Add(cBoxGrupo);
            gBoxDados.Controls.Add(lbChassi);
            gBoxDados.Controls.Add(label12);
            gBoxDados.Controls.Add(label13);
            gBoxDados.Controls.Add(label15);
            gBoxDados.Controls.Add(textCor);
            gBoxDados.Controls.Add(lbPlaca);
            gBoxDados.Controls.Add(textKM);
            gBoxDados.Controls.Add(label10);
            gBoxDados.Controls.Add(lbNome);
            gBoxDados.Controls.Add(textModelo);
            gBoxDados.Controls.Add(textPlaca);
            gBoxDados.Controls.Add(lbMarca);
            gBoxDados.Controls.Add(lbModelo);
            gBoxDados.Controls.Add(lbGrupo);
            gBoxDados.Controls.Add(textChassi);
            gBoxDados.Controls.Add(textMarca);
            gBoxDados.Controls.Add(textId);
            gBoxDados.Controls.Add(lbAno);
            gBoxDados.ForeColor = System.Drawing.Color.Black;
            gBoxDados.Location = new System.Drawing.Point(16, 111);
            gBoxDados.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            gBoxDados.Name = "gBoxDados";
            gBoxDados.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            gBoxDados.Size = new System.Drawing.Size(489, 431);
            gBoxDados.TabIndex = 94;
            gBoxDados.TabStop = false;
            gBoxDados.Text = "Vehicle Data";
            // 
            // cBoxCombustivel
            // 
            cBoxCombustivel.FormattingEnabled = true;
            cBoxCombustivel.ItemHeight = 20;
            cBoxCombustivel.Items.AddRange(new object[] { "Gasolina", "Etanol", "Flex (Gasolina e Etanol)", "Diesel" });
            cBoxCombustivel.Location = new System.Drawing.Point(129, 347);
            cBoxCombustivel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            cBoxCombustivel.Name = "cBoxCombustivel";
            cBoxCombustivel.Size = new System.Drawing.Size(122, 28);
            cBoxCombustivel.TabIndex = 10;
            // 
            // textAno
            // 
            textAno.Location = new System.Drawing.Point(129, 228);
            textAno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            textAno.MaxLength = 4;
            textAno.Name = "textAno";
            textAno.Size = new System.Drawing.Size(67, 27);
            textAno.TabIndex = 5;
            textAno.KeyPress += TextAno_KeyPress;
            // 
            // numUpDownCapTanque
            // 
            numUpDownCapTanque.Location = new System.Drawing.Point(129, 307);
            numUpDownCapTanque.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            numUpDownCapTanque.Name = "numUpDownCapTanque";
            numUpDownCapTanque.Size = new System.Drawing.Size(67, 27);
            numUpDownCapTanque.TabIndex = 9;
            // 
            // cBoxPortaMalas
            // 
            cBoxPortaMalas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cBoxPortaMalas.FormattingEnabled = true;
            cBoxPortaMalas.Items.AddRange(new object[] { "G", "M", "P" });
            cBoxPortaMalas.Location = new System.Drawing.Point(352, 307);
            cBoxPortaMalas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            cBoxPortaMalas.Name = "cBoxPortaMalas";
            cBoxPortaMalas.Size = new System.Drawing.Size(63, 28);
            cBoxPortaMalas.TabIndex = 14;
            // 
            // numUpDownQtdPessoas
            // 
            numUpDownQtdPessoas.Location = new System.Drawing.Point(129, 388);
            numUpDownQtdPessoas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            numUpDownQtdPessoas.Name = "numUpDownQtdPessoas";
            numUpDownQtdPessoas.Size = new System.Drawing.Size(64, 27);
            numUpDownQtdPessoas.TabIndex = 12;
            // 
            // numUpDownQtdPortas
            // 
            numUpDownQtdPortas.Location = new System.Drawing.Point(353, 348);
            numUpDownQtdPortas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            numUpDownQtdPortas.Name = "numUpDownQtdPortas";
            numUpDownQtdPortas.Size = new System.Drawing.Size(64, 27);
            numUpDownQtdPortas.TabIndex = 11;
            // 
            // cBoxGrupo
            // 
            cBoxGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cBoxGrupo.FormattingEnabled = true;
            cBoxGrupo.Location = new System.Drawing.Point(129, 268);
            cBoxGrupo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            cBoxGrupo.Name = "cBoxGrupo";
            cBoxGrupo.Size = new System.Drawing.Size(287, 28);
            cBoxGrupo.TabIndex = 7;
            // 
            // lbPlaca
            // 
            lbPlaca.AutoSize = true;
            lbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbPlaca.ForeColor = System.Drawing.Color.Black;
            lbPlaca.Location = new System.Drawing.Point(84, 73);
            lbPlaca.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbPlaca.Name = "lbPlaca";
            lbPlaca.Size = new System.Drawing.Size(36, 17);
            lbPlaca.TabIndex = 66;
            lbPlaca.Text = "Sign";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkLBoxOpcionais);
            groupBox1.ForeColor = System.Drawing.Color.Black;
            groupBox1.Location = new System.Drawing.Point(15, 549);
            groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            groupBox1.Size = new System.Drawing.Size(489, 244);
            groupBox1.TabIndex = 95;
            groupBox1.TabStop = false;
            groupBox1.Text = "Optional";
            // 
            // checkLBoxOpcionais
            // 
            checkLBoxOpcionais.FormattingEnabled = true;
            checkLBoxOpcionais.Items.AddRange(new object[] { "Air conditioning", "Hydraulic Steering", "ABS Breaks" });
            checkLBoxOpcionais.Location = new System.Drawing.Point(8, 29);
            checkLBoxOpcionais.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            checkLBoxOpcionais.Name = "checkLBoxOpcionais";
            checkLBoxOpcionais.Size = new System.Drawing.Size(473, 158);
            checkLBoxOpcionais.TabIndex = 15;
            // 
            // VeiculoForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(522, 843);
            Controls.Add(groupBox1);
            Controls.Add(gBoxDados);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(labelTitulo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VeiculoForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Car Rental App";
            gBoxDados.ResumeLayout(false);
            gBoxDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownCapTanque).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownQtdPessoas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownQtdPortas).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textPlaca;
        private System.Windows.Forms.TextBox textChassi;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label lbGrupo;
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
    }
}