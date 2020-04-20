using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioUsuariosWinForms
{
    public partial class FormUsuarios : Form
    {
        public static FormUsuarios instancia = null;

        protected FormUsuarios()
        {
            InitializeComponent();
        }

        public static FormUsuarios CrearInstanciaUsuarios()
        {
            if (instancia == null)
                instancia = new FormUsuarios();

            return instancia;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {            
            Form formnuevousuario = new FormNuevoUsuario();              
            formnuevousuario.Show();
            
        }
    }
}
