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
            //    Nombre = "LAN",
            //    FechaInicioActividades = DateTime.Now,
            //};
            //AbmLineaAerea.Insertar(lineaAerea);

            CargarCombo();
            MostrarTodosAviones();
        }

        private void CargarCombo()
        {
            cboLineasAereas.DataSource = AbmLineaAerea.Listar();
            cboLineasAereas.DisplayMember = "Nombre";
            cboLineasAereas.ValueMember = "IdLinea";
        }

        private void MostrarTodosAviones()
        {
            dgvAviones.DataSource = AbmAvion.Listar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (validarInsert())
            {
                Avion avion = new Avion()
                {
                    Capacidad = Convert.ToInt32(txtCapacidad.Text),
                    Denominación = txtDenominacion.Text,
                    LineaAereaId = Convert.ToInt32(cboLineasAereas.SelectedValue)
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
            else
            {
                MessageBox.Show("Debe completar todos los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarInsert()
        {
            if (txtCapacidad.Text == "")
            { return false; }
            else if (txtDenominacion.Text == "")
            { return false; }
            else if (cboLineasAereas.SelectedIndex <= 0)
            { return false; }
            return true;
        }

        private void limpiar()
        {
            txtCapacidad.Text = "";
            txtDenominacion.Text = "";
            txtId.Text = "";
            cboLineasAereas.SelectedValue = 0;
        }

        private void dgvAviones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvAviones.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCapacidad.Text = dgvAviones.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDenominacion.Text = dgvAviones.Rows[e.RowIndex].Cells[2].Value.ToString();
            cboLineasAereas.SelectedIndex = (int)dgvAviones.Rows[e.RowIndex].Cells[4].Value;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                int filasAfectadas = AbmAvion.Eliminar(Convert.ToInt32(txtId.Text));

                if (filasAfectadas > 0)
                {
                    lblMsjEliminar.ForeColor = Color.Green;
                    lblMsjEliminar.Text = "Delete ok";
                    limpiar();
                    MostrarTodosAviones();

                }
                else
                {
                    lblMsjEliminar.ForeColor = Color.Red;
                    lblMsjEliminar.Text = "Error al eliminar";
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool validar()
        {
            if (txtCapacidad.Text == "")
            { return false; }
            else if (txtId.Text == "")
            { return false; }
            else if (txtDenominacion.Text == "")
            { return false; }
            else if (cboLineasAereas.SelectedIndex <=0)
            { return false; }
            return true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Avion avion = new Avion()
                {
                    Capacidad = Convert.ToInt32(txtCapacidad.Text),
                    Denominación = txtDenominacion.Text,
                    LineaAereaId = Convert.ToInt32(cboLineasAereas.SelectedValue),
                    IdAvion = Convert.ToInt32(txtId.Text)
                };

                int filasAfectadas = AbmAvion.Editar(avion);

                if (filasAfectadas > 0)
                {
                    lblMsjEditar.ForeColor = Color.Green;
                    lblMsjEditar.Text = "Update ok";
                    limpiar();
                    MostrarTodosAviones();

                }
                else
                {
                    lblMsjEditar.ForeColor = Color.Red;
                    lblMsjEditar.Text = "Error al actualizar";
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void btnPorId_Click(object sender, EventArgs e)
        {
            if (txtId.Text!= "")
            {
                Avion avion = AbmAvion.TraerUno(Convert.ToInt32(txtId.Text));

                limpiar();
                lblMsjPorId.Text = $"ID: {avion.IdAvion}" +
                    $"\nCapacidad: {avion.Capacidad}" +
                    $"\nDenominacion: {avion.Denominación}";


            }
            else
            {
                MessageBox.Show("Debe completar todos los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cboLineasAereas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            

        }
    }
}
