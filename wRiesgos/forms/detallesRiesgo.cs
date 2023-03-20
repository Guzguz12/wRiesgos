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
    public partial class detallesRiesgo : Form
    {
        public detallesRiesgo()
        {
            InitializeComponent();
        }

      
        private void detallesRiesgo_Load(object sender, EventArgs e)
        {
            dgvAnalisis.DataSource = DatosUsuario.Priorizacion();
        
        }
    }
}
