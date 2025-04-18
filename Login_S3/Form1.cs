using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_S3
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            //este evento se ejecuta cuando llega el foco
            if (txtUsuario.Text=="Usuario")
            {
                txtUsuario.Text = "";

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            //este evento se ejecuta cuando se va el foco sin haber ingresado contenido, (vuelve a dar la guia)
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            //este evento borra la palabra guia y camufla el password
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
            
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            //este evento se ejecuta cuando se va el foco sin haber ingresado contenido, (vuelve a dar la guia)
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.UseSystemPasswordChar = false;  //saca el camuflado si se va el foco sin ingreso
            }
        }
    }
}

