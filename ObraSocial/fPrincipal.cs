using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// se me rompio todo el programa asi como la cabeza al intentar aumentar de a 1 el nro de afiliado

namespace ObraSocial
{
    public partial class fPrincipal : Form
    {
        public List<Afiliado> ListaCoincidencia;
        public fPrincipal()
        {
            InitializeComponent();
            coleccion.Listafiliados = new List<Afiliado>();
            ListaCoincidencia = new List<Afiliado>();
        }

        #region botones

        private void bAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
            rbDNI.Enabled = true;
            rbApellido.Enabled = true;
            bBuscar.Enabled = true;
        }

        private void bPlanes_Click(object sender, EventArgs e)
        {
            fPlan fPlan = new fPlan();
            if (fPlan.ShowDialog() == DialogResult.OK) { }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            dgvListar.DataSource = null;
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            if (rbTodos.Checked)
            {
                ListarTodos();
            }
            else if (rbDNI.Checked || rbApellido.Checked || rbEmpresa.Checked || rbPlan.Checked || rbSexo.Checked || rbRecienNacido.Checked || rbDiscapacidad.Checked || rbEnfermedadLegislada.Checked)
            {
                ListarCoincidencia();
            }
        }
        #endregion

        #region botones listar y buscar

        private void bListar_Click(object sender, EventArgs e)
        {
            ListaCoincidencia.Clear();

            if (rbTodos.Checked)
            {
                ListarTodos();
            }
            else if (rbEmpresa.Checked)
            {
                Coincidencia();
                ListarCoincidencia();
            }
            else if (rbPlan.Checked)
            {
                Coincidencia();
                ListarCoincidencia();
            }
            else if (rbSexo.Checked)
            {
                Coincidencia();
                ListarCoincidencia();
            }
            else if (rbRecienNacido.Checked)
            {
                Coincidencia();
                ListarCoincidencia();
            }
            else if (rbDiscapacidad.Checked)
            {
                Coincidencia();
                ListarCoincidencia();
            }
            else if (rbEnfermedadLegislada.Checked)
            {
                Coincidencia();
                ListarCoincidencia();
            }
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            ListaCoincidencia.Clear();

            if (rbDNI.Checked)
            {
                Coincidencia();
                ListarCoincidencia();
            }
            else if (rbApellido.Checked)
            {
                Coincidencia();
                ListarCoincidencia();
            }
        }
        #endregion

        #region load

        private void fPrincipal_Load(object sender, EventArgs e)
        {
            rbDNI.Enabled = false;
            mtDNI.Enabled = false;
            rbApellido.Enabled = false;
            tApellido.Enabled = false;
            bBuscar.Enabled = false;
            cbEmpresa.Enabled = false;
            cbPlan.Enabled = false;
            cbSexo.Enabled = false;
            chkbEmbarazo.Enabled = false;
            rbRecienNacido.Enabled = false;
            rbDiscapacidad.Enabled = false;
            rbEnfermedadLegislada.Enabled = false;
            rbTodos.Enabled = false;
            bListar.Enabled = false;
            rbEmpresa.Enabled = false;
            rbPlan.Enabled = false;
            rbSexo.Enabled = false;
        }
        #endregion

        #region controles enabled o disabled
        private void rbBuscarPor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBuscarPor.Checked)
            {
                rbDNI.Enabled = true;
                mtDNI.Enabled = true;
                rbApellido.Enabled = true;
                tApellido.Enabled = true;
                bBuscar.Enabled = true;
                cbEmpresa.Enabled = false;
                cbPlan.Enabled = false;
                cbSexo.Enabled = false;
                chkbEmbarazo.Enabled = false;
                rbRecienNacido.Enabled = false;
                rbDiscapacidad.Enabled = false;
                rbEnfermedadLegislada.Enabled = false;
                rbTodos.Enabled = false;
                bListar.Enabled = false;
                rbSexo.Enabled = false;
                rbPlan.Enabled = false;
                rbEmpresa.Enabled = false;
                mtDNI.Enabled = false;
                tApellido.Enabled = false;
            }
            else if ((!rbBuscarPor.Checked) && (rbListarPor.Checked))
            {
                rbDNI.Checked = false;
                rbDNI.Enabled = false;
                mtDNI.Enabled = false;                
                rbApellido.Enabled = false;
                tApellido.Enabled = false;
                bBuscar.Enabled = false;
                cbEmpresa.Enabled = false;
                cbPlan.Enabled = false;
                cbSexo.Enabled = false;
                chkbEmbarazo.Enabled = false;
                rbRecienNacido.Enabled = true;
                rbDiscapacidad.Enabled = true;
                rbEnfermedadLegislada.Enabled = true;
                rbTodos.Enabled = true;
                bListar.Enabled = true;
                rbSexo.Enabled = true;
                rbPlan.Enabled = true;
                rbEmpresa.Enabled = true;
            }
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSexo.SelectedIndex == 1)
            {
                chkbEmbarazo.Enabled = true;
            }
            else chkbEmbarazo.Enabled = false;
            chkbEmbarazo.Checked = false;
        }

        private void rbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmpresa.Checked)
            {
                cbEmpresa.Enabled = true;
                cbPlan.Enabled = false;
                cbSexo.Enabled = false;
            }
            else
            {
                cbEmpresa.Enabled = false;
            }
        }

        private void rbPlan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPlan.Checked)
            {
                cbPlan.Enabled = true;
                cbEmpresa.Enabled = false;
                cbSexo.Enabled = false;
            }
            else
            {
                cbPlan.Enabled = false;
            }
        }

        private void rbSexo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSexo.Checked)
            {
                cbSexo.Enabled = true;
                cbPlan.Enabled = false;
                cbEmpresa.Enabled = false;
            }
            else
            {
                cbSexo.Enabled = false;
            }
        }

        private void rbDNI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDNI.Checked)
            {
                mtDNI.Enabled = true;
            }
            else
            {
                mtDNI.Enabled = false;
            }
        }

        private void rbApellido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbApellido.Checked)
            {
                tApellido.Enabled = true;
            }
            else
            {
                tApellido.Enabled = false;
            }
        }

        #endregion

        #region metodo agregar
        Coleccion coleccion = new Coleccion();
        private void Agregar()
        {
            fAgregar fAgregar = new fAgregar();
            if (fAgregar.ShowDialog() == DialogResult.OK)
            //   fAgregar.cbEmpresa.Items.Add(fAgregar.tNombre.Text);
            {
                if (!coleccion.Listafiliados.Contains(fAgregar.afiliado)) //si no esta en la lista lo agrega
                {
                    coleccion.Listafiliados.Add(fAgregar.afiliado);
                    MessageBox.Show("El afiliado se ha cargado con éxito en el sistema", "Cargado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("El afiliado ya esta cargado en el sistema", "Cargado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region metodos listar

        private void ListarTodos()
        {
            dgvListar.DataSource = null;
            dgvListar.DataSource = coleccion.Listafiliados;
        }

        private void ListarCoincidencia()
        {
            dgvListar.DataSource = null;
            dgvListar.DataSource = ListaCoincidencia;
        }

        #endregion

        #region metodo buscar afiliado

        private Afiliado BuscarAfiliado()
        {
            Afiliado afiliado = null;
            int DNI;
            int index;
            if (dgvListar.Rows.Count > 0)
            {
                index = dgvListar.CurrentCell.RowIndex;
                DNI = Convert.ToInt32(dgvListar.Rows[index].Cells[9].Value.ToString().Replace(",", string.Empty));
                foreach (Afiliado a in coleccion.Listafiliados)
                {
                    if (a.DNI == DNI)
                    {
                        afiliado = a;
                    }
                }
            }
            return afiliado;
        }
        #endregion

        #region metodo modificar

        private void Modificar()
        {
            Afiliado afiliado = BuscarAfiliado();

            if (afiliado == null)
            {
                MessageBox.Show("No hay afiliado seleccionado.", "Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                fAgregar fAgregar = new fAgregar();

                fAgregar.lNombre.Visible = true;
                fAgregar.tNombre.Visible = true;
                fAgregar.lApellido.Visible = true;
                fAgregar.tApellido.Visible = true;
                fAgregar.lDomicilio.Visible = true;
                fAgregar.tDomicilio.Visible = true;
                fAgregar.lDNI.Visible = true;
                fAgregar.mtDNI.Visible = true;
                fAgregar.lTelefono.Visible = true;
                fAgregar.mtTelefono.Visible = true;
                fAgregar.cbEmpresa.Visible = true;
                fAgregar.cbPlan.Visible = true;
                fAgregar.cbSexo.Visible = true;
                fAgregar.lRubro.Visible = true;
                fAgregar.tRubro.Visible = true;
                fAgregar.chkbDiscapacidad.Visible = true;
                fAgregar.chkbEmbarazo.Visible = true;
                fAgregar.chkbEnfermedadLegislada.Visible = true;
                fAgregar.chkbRecienNacido.Visible = true;
                fAgregar.gbObservaciones.Visible = true;

                fAgregar.tNombre.Text = afiliado.Nombre;
                fAgregar.tApellido.Text = afiliado.Apellido;
                fAgregar.mtDNI.Text = Convert.ToString(afiliado.DNI);
                fAgregar.tDomicilio.Text = afiliado.Domicilio;
                fAgregar.mtTelefono.Text = Convert.ToString(afiliado.Telefono);
                fAgregar.dtFecha.Value = afiliado.FechaAlta;
                fAgregar.cbSexo.Text = afiliado.Sexo;
                fAgregar.cbEmpresa.Text = afiliado.NombreEmpresa;
                fAgregar.cbPlan.Text = afiliado.Plan;

                if (afiliado.GetType() == typeof(Afiliado))
                {
                    fAgregar.chkbParticular.Checked = true;
                }
                else if (afiliado.GetType() == typeof(Empresa))
                {
                    fAgregar.chkbEmpresa.Checked = true;
                }

                if (afiliado.Observacion == fAgregar.chkbEmbarazo.Text)
                {
                    fAgregar.chkbEmbarazo.Checked = true;
                }
                else if (afiliado.Observacion == fAgregar.chkbDiscapacidad.Text)
                {
                    fAgregar.chkbDiscapacidad.Checked = true;
                }
                else if (afiliado.Observacion == fAgregar.chkbEnfermedadLegislada.Text)
                {
                    fAgregar.chkbEnfermedadLegislada.Checked = true;
                }
                else if (afiliado.Observacion == fAgregar.chkbRecienNacido.Text)
                {
                    fAgregar.chkbRecienNacido.Checked = true;
                }

                if (fAgregar.ShowDialog() == DialogResult.OK)
                {
                    afiliado = fAgregar.afiliado;
                    int i = 0;
                    int tope = coleccion.Listafiliados.Count;
                    do
                    {
                        if (coleccion.Listafiliados[i].Equals(afiliado))
                        {
                            coleccion.Listafiliados[i] = afiliado;
                            ListaCoincidencia.Clear();
                            ListaCoincidencia.Add(afiliado);
                            ListarCoincidencia();
                            i++;
                        }
                        else
                            i++;
                    }
                    while ((i < tope));
                    MessageBox.Show("Se actualizaron los datos del Afiliado.", "Afiliado actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region metodo buscar coincidencias

        private void Coincidencia()
        {
            dgvListar.DataSource = coleccion.Listafiliados;
            if (rbDNI.Checked)
            {
                int DNI = Convert.ToInt32(mtDNI.Text.Replace(",", string.Empty)); ;

                if (dgvListar.Rows.Count > 0)
                {
                    foreach (Afiliado a in coleccion.Listafiliados)
                    {
                        if (a.DNI == DNI)
                        {
                            ListaCoincidencia.Add(a);
                        }
                    }
                }
            }
            else if (rbApellido.Checked)
            {
                string Apellido = tApellido.Text;

                if (dgvListar.Rows.Count > 0)
                {
                    foreach (Afiliado a in coleccion.Listafiliados)
                    {
                        if (a.Apellido == Apellido)
                        {
                            ListaCoincidencia.Add(a);
                        }
                    }
                }
            }
            else if (rbEmpresa.Checked)
            {
                string NombreEmpresa = cbEmpresa.Text;

                if (dgvListar.Rows.Count > 0)
                {
                    foreach (Afiliado a in coleccion.Listafiliados)
                    {
                        if (a.NombreEmpresa == NombreEmpresa)
                        {
                            ListaCoincidencia.Add(a);
                        }
                    }
                }
            }
            else if (rbPlan.Checked)
            {
                string Plan = cbPlan.Text;

                if (dgvListar.Rows.Count > 0)
                {
                    foreach (Afiliado a in coleccion.Listafiliados)
                    {
                        if (a.Plan == Plan)
                        {
                            ListaCoincidencia.Add(a);
                        }
                    }
                }
            }
            else if (rbSexo.Checked)
            {
                string Sexo = cbSexo.Text;

                if (dgvListar.Rows.Count > 0)
                {
                    foreach (Afiliado a in coleccion.Listafiliados)
                    {
                        if (a.Sexo == Sexo)
                        {
                            ListaCoincidencia.Add(a);
                        }
                    }
                }
            }
            else if (rbRecienNacido.Checked)
            {
                string Observacion = Convert.ToString(rbRecienNacido.Text);

                if (dgvListar.Rows.Count > 0)
                {
                    foreach (Afiliado a in coleccion.Listafiliados)
                    {
                        if (a.Observacion == Observacion)
                        {
                            ListaCoincidencia.Add(a);
                        }
                    }
                }
            }
            else if (rbDiscapacidad.Checked)
            {
                string Observacion = Convert.ToString(rbDiscapacidad.Text);

                if (dgvListar.Rows.Count > 0)
                {
                    foreach (Afiliado a in coleccion.Listafiliados)
                    {
                        if (a.Observacion == Observacion)
                        {
                            ListaCoincidencia.Add(a);
                        }
                    }
                }
            }
            else if (rbEnfermedadLegislada.Checked)
            {
                string Observacion = Convert.ToString(rbEnfermedadLegislada.Text);

                if (dgvListar.Rows.Count > 0)
                {
                    foreach (Afiliado a in coleccion.Listafiliados)
                    {
                        if (a.Observacion == Observacion)
                        {
                            ListaCoincidencia.Add(a);
                        }
                    }
                }
            }
            else if (chkbEmbarazo.Checked)
            {
                string Observacion = Convert.ToString(chkbEmbarazo.Text);

                if (dgvListar.Rows.Count > 0)
                {
                    foreach (Afiliado a in coleccion.Listafiliados)
                    {
                        if (a.Observacion == Observacion)
                        {
                            ListaCoincidencia.Add(a);
                        }
                    }
                }
            }
        }
        #endregion

        #region metodo eliminar

        private void Eliminar()
        {
            Afiliado afiliado = BuscarAfiliado();
            if (afiliado == null)
                MessageBox.Show("No hay afiliado.", "Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
            {
                DialogResult dialogResult = MessageBox.Show("Esta por borrar los datos ¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (dialogResult == DialogResult.Yes && coleccion.Listafiliados.Count > 0)
                {
                    coleccion.Listafiliados.Remove(afiliado);
                    if ((rbDNI.Checked || rbApellido.Checked || rbEmpresa.Checked || rbPlan.Checked || rbSexo.Checked || rbRecienNacido.Checked || rbDiscapacidad.Checked || rbEnfermedadLegislada.Checked || chkbEmbarazo.Checked) && (ListaCoincidencia.Count > 0))
                    {
                        ListaCoincidencia.Remove(afiliado);
                        dgvListar.DataSource = ListaCoincidencia;
                    }
                }
                else if (dialogResult == DialogResult.No) { }
            }
        }
        #endregion

        #region menus contextuales

        private void miLimpiar_Click(object sender, EventArgs e)
        {
            dgvListar.DataSource = null;
        }

        private void tsmiModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void tsmiLimpiar_Click(object sender, EventArgs e)
        {
            dgvListar.DataSource = null;
        }

        private void tsmiEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            if (rbTodos.Checked)
            {
                ListarTodos();
            }
            else if (rbDNI.Checked || rbApellido.Checked || rbEmpresa.Checked || rbPlan.Checked || rbSexo.Checked || rbRecienNacido.Checked || rbDiscapacidad.Checked || rbEnfermedadLegislada.Checked)
            {
                ListarCoincidencia();
            }
        }

        private void miAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
            rbDNI.Enabled = true;
            rbApellido.Enabled = true;
            bBuscar.Enabled = true;
        }
    }
}
#endregion
