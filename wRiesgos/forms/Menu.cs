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
using System.IO;
using System.Reflection;

namespace wRiesgos.forms
{
    public partial class Menu : Form
    {
        private int IdUser;
        public Menu(int _idUsuario = 0)
        {
            InitializeComponent();
            IdUser = _idUsuario;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            List<wManejoLogica.Menu> permisos_esperados = DatosUsuario.obtenerPermisos(IdUser);

            MenuStrip MiMenu = new MenuStrip();
            //ITERAMOS CADA MENU DE NUESTRA LISTA
            foreach (wManejoLogica.Menu objMenu in permisos_esperados) 
            {
                ToolStripMenuItem menuPadre = new ToolStripMenuItem(objMenu.Nombre,null, click_en_menu, objMenu.Formulario);
                menuPadre.TextImageRelation = TextImageRelation.ImageAboveText;
                string rutaImagen = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../") + @objMenu.Icono);

                menuPadre.Image = new Bitmap(rutaImagen);
                menuPadre.ImageScaling = ToolStripItemImageScaling.None;

              

                MiMenu.Items.Add(menuPadre);
            }
            //AGREGAMOS EL CONTROL AL FORMULARIO
            this.MainMenuStrip = MiMenu;
            Controls.Add(MiMenu);
        }

        private void click_en_menu(object sender, System.EventArgs e)
        {

            ToolStripMenuItem menuSeleccionado = (ToolStripMenuItem)sender;

            //NOS AYUDA A VALIDAR SI EXISTE ELEMENTOS EN NUESTRO PROYECTO - OBTENEMOS PROYECTO
            //ASSEMBLY Obtiene el proceso de nuestro ejecutable
            Assembly asm = Assembly.GetEntryAssembly();

            //Type elemento = asm.GetType(asm.GetName().Name + "." + menuSeleccionado.Name);
            Type elemento = asm.GetType(asm.GetName().Name + ".forms." + menuSeleccionado.Name);


            if (elemento == null)
            {
                MessageBox.Show("Formulario no encontrado");
            }
            else
            {

                //IMPORTANTE CAMBIAR EL TEXTO DEL FORMULARIO CUANDO SE CREA , TIENE QUE SER DIFERENTE AL NAME
                Form FormularioCreado = (Form)Activator.CreateInstance(elemento);


                int encontrado = this.MdiChildren.Where(x => x.Name == FormularioCreado.Name).ToList().Count();

                if (encontrado != 0)
                {

                    ((Form)this.MdiChildren.Where(x => x.Name == FormularioCreado.Name).FirstOrDefault()).WindowState = FormWindowState.Normal;
                    ((Form)this.MdiChildren.Where(x => x.Name == FormularioCreado.Name).FirstOrDefault()).Activate();

                }
                else
                {

                    FormularioCreado.MdiParent = this;
                    FormularioCreado.Show();
                }

            }


        }

    }
}
