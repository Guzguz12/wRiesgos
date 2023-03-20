
namespace wRiesgos.forms
{
    partial class detallesRiesgo
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
            this.dgvAnalisis = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnalisis
            // 
            this.dgvAnalisis.BackgroundColor = System.Drawing.Color.White;
            this.dgvAnalisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalisis.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvAnalisis.Location = new System.Drawing.Point(187, 148);
            this.dgvAnalisis.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.dgvAnalisis.Name = "dgvAnalisis";
            this.dgvAnalisis.Size = new System.Drawing.Size(444, 150);
            this.dgvAnalisis.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(246, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(326, 40);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Análisis de los Riesgos";
            // 
            // detallesRiesgo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvAnalisis);
            this.Name = "detallesRiesgo";
            this.Text = "detallesRiesgo";
            this.Load += new System.EventHandler(this.detallesRiesgo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnalisis;
        private System.Windows.Forms.Label lblTitulo;
    }
}