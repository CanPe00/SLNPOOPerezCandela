using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.DAC;
using WindowsEFDatos.Models;
using WindowsEFDatos.Negocio;

namespace WindowsEFDatos
{
    public partial class frmAvion : Form
    {
        public frmAvion()
        {
            InitializeComponent();
        }

        private void frmAvion_Load(object sender, EventArgs e)
        {
            //LineaAerea lineaAerea = new LineaAerea()
            //{
            //    Nombre = "Aerolineas Argentinas",
            //    FechaInicioActividades = DateTime.Now,
            //};
            //AbmLineaAerea.Insertar(lineaAerea);
            
            MostrarTodosAviones();
        }

        private void MostrarTodosAviones()
        {
            dgvAviones.DataSource = AbmAvion.Listar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
           
            Avion avion = new Avion() {
                Capacidad = Convert.ToInt32(txtCapacidad.Text),
                Denominación= txtDenominacion.Text,
                LineaAereaId=1 //Para facilidad queda siempre la aerolinea cargada en bd
            };
            

            int filasAfectadas = AbmAvion.Insertar(avion);

            if (filasAfectadas > 0)
            {
                lblMsjInsertar.ForeColor = Color.Green;
                lblMsjInsertar.Text = "Insert ok";
                limpiar();
                MostrarTodosAviones();

            }
            else
            {
                lblMsjInsertar.ForeColor = Color.Red;
                lblMsjInsertar.Text = "Error al insertar";
            }
        }

        private void limpiar()
        {
            txtCapacidad.Text = "";
            txtDenominacion.Text = "";
        }
    }
}
