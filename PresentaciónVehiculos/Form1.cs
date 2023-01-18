using LibTransportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentaciónVehiculos
{
    public partial class Form1 : Form
    {
        Camion camion = new Camion("ABD123", 80, 1500, new Remolque(4, 50));
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCamion.Text = camion.ToString();
        }

        private void btnQuitarRemolque_Click(object sender, EventArgs e)
        {
            camion.QuitarRemolque();
            Form1_Load(sender, e);
            
        }
    }
}
