
namespace LocadoraDeVeiculos.WindowsApp.Features.ImagemVeiculo
{
    partial class ImagemVeiculoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImagemVeiculoForm));
            this.pctBoxImagem = new System.Windows.Forms.PictureBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxImagem)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctBoxImagem
            // 
            this.pctBoxImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctBoxImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctBoxImagem.Location = new System.Drawing.Point(13, 14);
            this.pctBoxImagem.Name = "pctBoxImagem";
            this.pctBoxImagem.Size = new System.Drawing.Size(283, 185);
            this.pctBoxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxImagem.TabIndex = 0;
            this.pctBoxImagem.TabStop = false;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.btnAvancar);
            this.panelPrincipal.Controls.Add(this.pctBoxImagem);
            this.panelPrincipal.Controls.Add(this.btnVoltar);
            this.panelPrincipal.Controls.Add(this.btnAdicionar);
            this.panelPrincipal.Controls.Add(this.btnExcluir);
            this.panelPrincipal.Location = new System.Drawing.Point(12, 12);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(310, 265);
            this.panelPrincipal.TabIndex = 1;
            // 
            // btnAvancar
            // 
            this.btnAvancar.Image = ((System.Drawing.Image)(resources.GetObject("btnAvancar.Image")));
            this.btnAvancar.Location = new System.Drawing.Point(232, 205);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(66, 42);
            this.btnAvancar.TabIndex = 5;
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(13, 205);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(67, 42);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(86, 205);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(67, 42);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(159, 205);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(67, 42);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnConfirmar.Location = new System.Drawing.Point(166, 283);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancelar.Location = new System.Drawing.Point(247, 283);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Todos os tipos|*.jpeg;*.jpg;*.png|JPEG|*.jpeg|PNG|*.png|JPG|*.jpg";
            // 
            // ImagemVeiculoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(338, 321);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.panelPrincipal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImagemVeiculoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locadora de Veículos";
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxImagem)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBoxImagem;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}