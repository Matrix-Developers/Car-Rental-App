
namespace LocadoraDeVeiculos.WindowsApp.Features.Devolucoes
{
    partial class TabelaDevolucaoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridDevolucoes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridDevolucoes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDevolucoes
            // 
            this.gridDevolucoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDevolucoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDevolucoes.Location = new System.Drawing.Point(0, 0);
            this.gridDevolucoes.Name = "gridDevolucoes";
            this.gridDevolucoes.Size = new System.Drawing.Size(150, 150);
            this.gridDevolucoes.TabIndex = 0;
            // 
            // TabelaDevolucaoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridDevolucoes);
            this.Name = "TabelaDevolucaoControl";
            ((System.ComponentModel.ISupportInitialize)(this.gridDevolucoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDevolucoes;
    }
}
