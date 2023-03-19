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
    public partial class login : Form
    {
        public static void Main()
        {
            //estilos
            Application.EnableVisualStyles();
            //correr el formulario
            Application.Run(new login());
        }
        public login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int idUser_esperado = DatosUsuario.logear(txtUsuario.Text, txtPassword.Text);
            if (idUser_esperado != 0)
            {
                MessageBox.Show("Bienvenido al sistema");
                this.Hide();
                Menu mdi = new Menu(idUser_esperado);
                mdi.Show();
            }
            else 
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }
    }
}
