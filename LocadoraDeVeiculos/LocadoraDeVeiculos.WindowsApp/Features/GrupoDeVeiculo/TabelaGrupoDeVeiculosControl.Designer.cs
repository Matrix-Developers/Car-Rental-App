
namespace LocadoraDeVeiculos.WindowsApp.Features.GrupoDeVeiculos
{
    partial class TabelaGrupoDeVeiculosControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridGrupoDeVeiculos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridGrupoDeVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGrupoDeVeiculos
            // 
            this.gridGrupoDeVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGrupoDeVeiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGrupoDeVeiculos.Location = new System.Drawing.Point(0, 0);
            this.gridGrupoDeVeiculos.Name = "gridGrupoDeVeiculos";
            this.gridGrupoDeVeiculos.Size = new System.Drawing.Size(237, 219);
            this.gridGrupoDeVeiculos.TabIndex = 0;
            // 
            // TabelaGrupoDeVeiculosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridGrupoDeVeiculos);
            this.Name = "TabelaGrupoDeVeiculosControl";
            this.Size = new System.Drawing.Size(237, 219);
            ((System.ComponentModel.ISupportInitialize)(this.gridGrupoDeVeiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridGrupoDeVeiculos;
    }
}
