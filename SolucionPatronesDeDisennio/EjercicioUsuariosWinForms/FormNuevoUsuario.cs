using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace EjercicioUsuariosWinForms
{
    public partial class FormNuevoUsuario : Form
    {
        
        public FormNuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string nroMovil = txtNroMovil.Text;
            string nroFijo = txtNroFijo.Text;
            string email = txtEmail.Text;
            string direccion = txtDireccion.Text;
            string combo = "1";

            try
            {
                string instruccion = "INSERT INTO [dbo].[user] VALUES ('" + nombre + "','" + apellido + "','" + nroMovil + "','" + nroFijo + "','" + email + "','" + direccion + "','" + combo + "')";
                DataAccess.Conexion.EjecutarInstruccionesSinRetorno(instruccion);
                DataAccess.Archivos.GuardarLog(instruccion);
                MessageBox.Show("Registro guardado exitosamente");                
            }
            catch (Exception exx)
            {
                MessageBox.Show("Se ha producido una excepcion  " + exx.Message);
            }
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form formusuarios = FormUsuarios.CrearInstanciaUsuarios();
            formusuarios.Show();
        }
       
    }
}
