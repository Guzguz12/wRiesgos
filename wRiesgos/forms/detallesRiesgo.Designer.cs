
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.planRespuesta = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRiesgo,
            this.nivelRiesgo,
            this.estadoRiesgo,
            this.planRespuesta});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(187, 148);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // idRiesgo
            // 
            this.idRiesgo.HeaderText = "Identificador del Riesgo";
            this.idRiesgo.Name = "idRiesgo";
            // 
            // nivelRiesgo
            // 
            this.nivelRiesgo.HeaderText = "Nivel de Riesgo";
            this.nivelRiesgo.Name = "nivelRiesgo";
            // 
            // estadoRiesgo
            // 
            this.estadoRiesgo.HeaderText = "Estado del Riesgo";
            this.estadoRiesgo.Name = "estadoRiesgo";
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
            // planRespuesta
            // 
            this.planRespuesta.HeaderText = "Plan de Respuesta";
            this.planRespuesta.Name = "planRespuesta";
            // 
            // detallesRiesgo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "detallesRiesgo";
            this.Text = "detallesRiesgo";
            this.Load += new System.EventHandler(this.detallesRiesgo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoRiesgo;
        private System.Windows.Forms.DataGridViewButtonColumn planRespuesta;
        private System.Windows.Forms.Label lblTitulo;
    }
}