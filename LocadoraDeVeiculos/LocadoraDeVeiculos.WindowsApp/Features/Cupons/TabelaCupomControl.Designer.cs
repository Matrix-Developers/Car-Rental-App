
namespace LocadoraDeVeiculos.WindowsApp.Features.Cupons
{
    partial class TabelaCupomControl
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
            this.gridCupons = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCupons)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCupons
            // 
            this.gridCupons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCupons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCupons.Location = new System.Drawing.Point(0, 0);
            this.gridCupons.Name = "gridCupons";
            this.gridCupons.Size = new System.Drawing.Size(150, 150);
            this.gridCupons.TabIndex = 0;
            // 
            // TabelaCupomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridCupons);
            this.Name = "TabelaCupomControl";
            ((System.ComponentModel.ISupportInitialize)(this.gridCupons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCupons;
    }
}
