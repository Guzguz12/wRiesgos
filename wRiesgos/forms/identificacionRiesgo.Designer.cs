
namespace wRiesgos.forms
{
    partial class identificacionRiesgo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescripRiesgo = new System.Windows.Forms.Label();
            this.txtDescripRiesgo = new System.Windows.Forms.TextBox();
            this.txtCausaRiesgo = new System.Windows.Forms.TextBox();
            this.lblCausa = new System.Windows.Forms.Label();
            this.lblConsecuencia = new System.Windows.Forms.Label();
            this.txtConsecuencias = new System.Windows.Forms.TextBox();
            this.lblEstadoTitulo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblFrecuencia = new System.Windows.Forms.Label();
            this.cmbFrecuencia = new System.Windows.Forms.ComboBox();
            this.lblImpacto = new System.Windows.Forms.Label();
            this.cmbImpacto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación del Riesgo";
            // 
            // lblDescripRiesgo
            // 
            this.lblDescripRiesgo.AutoSize = true;
            this.lblDescripRiesgo.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripRiesgo.ForeColor = System.Drawing.Color.White;
            this.lblDescripRiesgo.Location = new System.Drawing.Point(26, 93);
            this.lblDescripRiesgo.Name = "lblDescripRiesgo";
            this.lblDescripRiesgo.Size = new System.Drawing.Size(193, 24);
            this.lblDescripRiesgo.TabIndex = 1;
            this.lblDescripRiesgo.Text = "Descripción del Riesgo";
            // 
            // txtDescripRiesgo
            // 
            this.txtDescripRiesgo.Location = new System.Drawing.Point(26, 129);
            this.txtDescripRiesgo.Name = "txtDescripRiesgo";
            this.txtDescripRiesgo.Size = new System.Drawing.Size(265, 20);
            this.txtDescripRiesgo.TabIndex = 2;
            // 
            // txtCausaRiesgo
            // 
            this.txtCausaRiesgo.Location = new System.Drawing.Point(26, 218);
            this.txtCausaRiesgo.Name = "txtCausaRiesgo";
            this.txtCausaRiesgo.Size = new System.Drawing.Size(258, 20);
            this.txtCausaRiesgo.TabIndex = 3;
            // 
            // lblCausa
            // 
            this.lblCausa.AutoSize = true;
            this.lblCausa.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCausa.ForeColor = System.Drawing.Color.White;
            this.lblCausa.Location = new System.Drawing.Point(26, 181);
            this.lblCausa.Name = "lblCausa";
            this.lblCausa.Size = new System.Drawing.Size(145, 24);
            this.lblCausa.TabIndex = 4;
            this.lblCausa.Text = "Causa del Riesgo";
            // 
            // lblConsecuencia
            // 
            this.lblConsecuencia.AutoSize = true;
            this.lblConsecuencia.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsecuencia.ForeColor = System.Drawing.Color.White;
            this.lblConsecuencia.Location = new System.Drawing.Point(26, 264);
            this.lblConsecuencia.Name = "lblConsecuencia";
            this.lblConsecuencia.Size = new System.Drawing.Size(214, 24);
            this.lblConsecuencia.TabIndex = 5;
            this.lblConsecuencia.Text = "Consecuencias del Riesgo";
            // 
            // txtConsecuencias
            // 
            this.txtConsecuencias.Location = new System.Drawing.Point(26, 300);
            this.txtConsecuencias.Name = "txtConsecuencias";
            this.txtConsecuencias.Size = new System.Drawing.Size(292, 20);
            this.txtConsecuencias.TabIndex = 6;
            // 
            // lblEstadoTitulo
            // 
            this.lblEstadoTitulo.AutoSize = true;
            this.lblEstadoTitulo.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoTitulo.ForeColor = System.Drawing.Color.White;
            this.lblEstadoTitulo.Location = new System.Drawing.Point(333, 354);
            this.lblEstadoTitulo.Name = "lblEstadoTitulo";
            this.lblEstadoTitulo.Size = new System.Drawing.Size(153, 24);
            this.lblEstadoTitulo.TabIndex = 7;
            this.lblEstadoTitulo.Text = "Estado del Riesgo";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEstado.Location = new System.Drawing.Point(343, 378);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(133, 28);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "___________";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGuardar.Location = new System.Drawing.Point(561, 287);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(178, 60);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar ";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblFrecuencia
            // 
            this.lblFrecuencia.AutoSize = true;
            this.lblFrecuencia.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrecuencia.ForeColor = System.Drawing.Color.White;
            this.lblFrecuencia.Location = new System.Drawing.Point(557, 93);
            this.lblFrecuencia.Name = "lblFrecuencia";
            this.lblFrecuencia.Size = new System.Drawing.Size(233, 24);
            this.lblFrecuencia.TabIndex = 10;
            this.lblFrecuencia.Text = "Frecuencia en la que ocurre";
            // 
            // cmbFrecuencia
            // 
            this.cmbFrecuencia.FormattingEnabled = true;
            this.cmbFrecuencia.Items.AddRange(new object[] {
            "1 o más veces en un dia",
            "Varias veces en un mes",
            "Una vez al mes",
            "Una vez cada año",
            "Una vez cada 5 años o más"});
            this.cmbFrecuencia.Location = new System.Drawing.Point(490, 127);
            this.cmbFrecuencia.Name = "cmbFrecuencia";
            this.cmbFrecuencia.Size = new System.Drawing.Size(300, 21);
            this.cmbFrecuencia.TabIndex = 11;
            this.cmbFrecuencia.SelectedIndexChanged += new System.EventHandler(this.cmbFrecuencia_SelectedIndexChanged);
            // 
            // lblImpacto
            // 
            this.lblImpacto.AutoSize = true;
            this.lblImpacto.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpacto.ForeColor = System.Drawing.Color.White;
            this.lblImpacto.Location = new System.Drawing.Point(594, 181);
            this.lblImpacto.Name = "lblImpacto";
            this.lblImpacto.Size = new System.Drawing.Size(196, 24);
            this.lblImpacto.TabIndex = 12;
            this.lblImpacto.Text = "Impacto cuando ocurre";
            // 
            // cmbImpacto
            // 
            this.cmbImpacto.FormattingEnabled = true;
            this.cmbImpacto.Items.AddRange(new object[] {
            "El riesgo impide el cumpliento del objetivo",
            "El riesgo afecta en alto nivel el cumplimiento del objetivo",
            "El riesgo afecta parcialmente el cumplimiento del objetivo",
            "El riesgo afecta levemente el cumplimiento del objetivo",
            "El riesgo no afecta el cumplimiento del objetivo"});
            this.cmbImpacto.Location = new System.Drawing.Point(490, 228);
            this.cmbImpacto.Name = "cmbImpacto";
            this.cmbImpacto.Size = new System.Drawing.Size(300, 21);
            this.cmbImpacto.TabIndex = 13;
            this.cmbImpacto.SelectedIndexChanged += new System.EventHandler(this.cmbImpacto_SelectedIndexChanged);
            // 
            // identificacionRiesgo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(819, 447);
            this.Controls.Add(this.cmbImpacto);
            this.Controls.Add(this.lblImpacto);
            this.Controls.Add(this.cmbFrecuencia);
            this.Controls.Add(this.lblFrecuencia);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblEstadoTitulo);
            this.Controls.Add(this.txtConsecuencias);
            this.Controls.Add(this.lblConsecuencia);
            this.Controls.Add(this.lblCausa);
            this.Controls.Add(this.txtCausaRiesgo);
            this.Controls.Add(this.txtDescripRiesgo);
            this.Controls.Add(this.lblDescripRiesgo);
            this.Controls.Add(this.label1);
            this.Name = "identificacionRiesgo";
            this.Text = "identificacionRiesgo";
            this.Load += new System.EventHandler(this.identificacionRiesgo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescripRiesgo;
        private System.Windows.Forms.TextBox txtDescripRiesgo;
        private System.Windows.Forms.TextBox txtCausaRiesgo;
        private System.Windows.Forms.Label lblCausa;
        private System.Windows.Forms.Label lblConsecuencia;
        private System.Windows.Forms.TextBox txtConsecuencias;
        private System.Windows.Forms.Label lblEstadoTitulo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblFrecuencia;
        private System.Windows.Forms.ComboBox cmbFrecuencia;
        private System.Windows.Forms.Label lblImpacto;
        private System.Windows.Forms.ComboBox cmbImpacto;
    }
}