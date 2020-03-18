using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObraSocial
{
    public partial class fPlan : Form
    {
        
        public fPlan()
        {
            InitializeComponent();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPlan.SelectedIndex == 0)
            {
                mtPrecio.Text = Convert.ToString( 1500);
                mtMedicamentos.Text = Convert.ToString(70);
                mtConsultas.Text = Convert.ToString(90);
                mtPracticas.Text = Convert.ToString(90);
                mtCirugias.Text = Convert.ToString(40);
            }
            else if (cbPlan.SelectedIndex==1)
            {
                mtPrecio.Text = Convert.ToString(1000);
                mtMedicamentos.Text = Convert.ToString(60);
                mtConsultas.Text = Convert.ToString(70);
                mtPracticas.Text = Convert.ToString(70);
                mtCirugias.Text = Convert.ToString(20);
            }
            else if (cbPlan.SelectedIndex == 2)
            {
                mtPrecio.Text = Convert.ToString(0500);
                mtMedicamentos.Text = Convert.ToString(50);
                mtConsultas.Text = Convert.ToString(70);
                mtPracticas.Text = Convert.ToString(60);
                mtCirugias.Text = Convert.ToString(00);
            }
        }

        private void bAgregarPlan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sección en construcción", "Lo sentimos...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
