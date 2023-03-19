
namespace wRiesgos.forms
{
    partial class planRespuesta
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
            this.lblTituloPlan = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accionRiesgo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fechaRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsableRiesgo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloPlan
            // 
            this.lblTituloPlan.AutoSize = true;
            this.lblTituloPlan.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPlan.ForeColor = System.Drawing.Color.White;
            this.lblTituloPlan.Location = new System.Drawing.Point(182, 34);
            this.lblTituloPlan.Name = "lblTituloPlan";
            this.lblTituloPlan.Size = new System.Drawing.Size(434, 40);
            this.lblTituloPlan.TabIndex = 0;
            this.lblTituloPlan.Text = "Plan de respuesta a los riesgos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accionRiesgo,
            this.fechaRiesgo,
            this.responsableRiesgo});
            this.dataGridView1.Location = new System.Drawing.Point(233, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(348, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // accionRiesgo
            // 
            this.accionRiesgo.HeaderText = "Acción";
            this.accionRiesgo.Name = "accionRiesgo";
            // 
            // fechaRiesgo
            // 
            this.fechaRiesgo.HeaderText = "Fecha de Atención";
            this.fechaRiesgo.Name = "fechaRiesgo";
            // 
            // responsableRiesgo
            // 
            this.responsableRiesgo.HeaderText = "Responsable";
            this.responsableRiesgo.Name = "responsableRiesgo";
            // 
            // planRespuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTituloPlan);
            this.Name = "planRespuesta";
            this.Text = "planRespuesta";
            this.Load += new System.EventHandler(this.planRespuesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloPlan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn accionRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRiesgo;
        private System.Windows.Forms.DataGridViewComboBoxColumn responsableRiesgo;
    }
}