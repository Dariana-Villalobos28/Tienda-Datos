using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PresentacionTienda
{
    public partial class FrmTienda : Form
    {
        private char _Bandera;

        public FrmTienda()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ControlarBotones(true, false, false, true, true);
                if(_Bandera == "guardar")
                {
                    GuardarProductos();
                    LlenarProductos("");
                    MessageBox.Show("Guardado Correctamente");
                }
                else
                {

                }
                LimpiarCampos();
                ControlarCampos(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LlenarProductos(string v)
        {
            throw new NotImplementedException();
        }

        private void GuardarProductos()
        {
            throw new NotImplementedException();
        }

        private void ControlarCampos(bool v)
        {
            throw new NotImplementedException();
        }

        private void LimpiarCampos()
        {
            throw new NotImplementedException();
        }

        private void ControlarBotones(bool v1, bool v2, bool v3, bool v4, bool v5)
        {
            throw new NotImplementedException();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ControlarBotones(true, false, false, true, true);
            LlenarCampos();
            ControlarCampos(false);
        }

        private void LlenarCampos()
        {
            throw new NotImplementedException();
        }

        private void ControlarCampos()
        {
            throw new NotImplementedException();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar registro?", "Eliminar", MessageBoxButtons.YesNo) Dialog.Yes);
            {
                try
                {
                    EliminarProducto();
                    LlenarProductos();
                    MessageBox.Show("Registro Correcto");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
        }

        private void LlenarProductos()
        {
            throw new NotImplementedException();
        }

        private void EliminarProducto()
        {
            throw new NotImplementedException();
        }
    }
}
