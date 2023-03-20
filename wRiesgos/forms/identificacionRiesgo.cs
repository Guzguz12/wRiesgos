using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wManejoDatos;

namespace wRiesgos.forms
{
    public partial class identificacionRiesgo : Form
    {
        public int probabilidad;
        public int impacto;
        public identificacionRiesgo()
        {
            InitializeComponent();
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbFrecuencia.SelectedItem == null || cmbFrecuencia.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Selecciona una opción para la frecuencia del riesgo");
            }
            else
            {
                if (cmbImpacto.SelectedItem == null || cmbImpacto.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Selecciona una opción para el impacto del riesgo");
                }
                else
                {
                    
                    if (txtDescripRiesgo.Text == "" || txtDescripRiesgo.Text == null)
                    {
                        MessageBox.Show("La descripción del riesgo debe ser valida ");
                    }
                    else
                    {
                        if (txtConsecuencias.Text == "" || txtConsecuencias.Text == null)
                        {
                            MessageBox.Show("La consecuencia del riesgo debe ser valida ");
                        }
                        else
                        {
                            if (txtCausaRiesgo.Text == "" || txtCausaRiesgo.Text == null)
                            {
                                MessageBox.Show("La causa del riesgo debe ser valida ");
                            }
                            else
                            {
                                //paso las validaciones- guardar en el sp 
                                lblEstado.Text = "Identificado";
                                int resultadoSp = DatosUsuario.guardarRiesgo(txtDescripRiesgo.Text, txtCausaRiesgo.Text,txtConsecuencias.Text,"Identificado",probabilidad,impacto);
                                if (resultadoSp != 0)
                                {
                                    MessageBox.Show("Riesgo guardado");
                                    lblEstado.Text = "Identificado";
                                }
                                else
                                {
                                    MessageBox.Show("Hubo un error al guardar el riesgo consulta al administrador");
                                }


                            }
                        }
                    }
                }
            }
        }

        private void identificacionRiesgo_Load(object sender, EventArgs e)
        {
            lblEstado.Text = " ";
        }

        private void cmbFrecuencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = cmbFrecuencia.SelectedItem.ToString();
            
            switch (valor)
            {
                case "1 o más veces en un dia":
                    //maximo de caracteres que soporta el tipo de identidad
                    probabilidad = 5;
                    break;
                case "Varias veces en un mes":
                    probabilidad = 4;
                    break;

                case "Una vez al mes":
                    probabilidad = 3;
                    break;

                case "Una vez cada año":
                    probabilidad = 2;
                    break;

                case "Una vez cada 5 años o más":
                    probabilidad = 1;
                    break;
                

            }
        }

        private void cmbImpacto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = cmbImpacto.SelectedItem.ToString();

            switch (valor)
            {
                case "El riesgo impide el cumpliento del objetivo":
                    //maximo de caracteres que soporta el tipo de identidad
                    impacto = 5;
                    break;
                case "El riesgo afecta en alto nivel el cumplimiento del objetivo":
                    impacto = 4;
                    break;

                case "El riesgo afecta parcialmente el cumplimiento del objetivo":
                    impacto = 3;
                    break;

                case "El riesgo afecta levemente el cumplimiento del objetivo":
                    impacto = 2;
                    break;

                case "El riesgo no afecta el cumplimiento del objetivo":
                    impacto = 1;
                    break;

            }
        }
    }
}
