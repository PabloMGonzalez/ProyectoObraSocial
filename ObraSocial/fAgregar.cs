using System;
using System.Windows.Forms;

namespace ObraSocial
{
    public partial class fAgregar : Form
    {

        #region atributos

        public int _nroControl;
        public Afiliado afiliado;
        #endregion

        #region hacer visibiles las distintas secciones (cliente particular) 1/2

        private void chkbParticular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbParticular.Checked && chkbEmpresa.Checked)
            {
                lNombre.Visible = true;
                tNombre.Visible = true;
                lRubro.Visible = false;
                tRubro.Visible = false;
                cbPlan.Visible = true;
                lApellido.Visible = true;
                tApellido.Visible = true;
                lDomicilio.Visible = true;
                tDomicilio.Visible = true;
                lDNI.Visible = true;
                mtDNI.Visible = true;
                lTelefono.Visible = true;
                mtTelefono.Visible = true;
                cbSexo.Visible = true;
                cbEmpresa.Visible = true;
                chkbEmbarazo.Visible = false;
                cbPlan.Visible = false;
                chkbDiscapacidad.Visible = true;
                chkbEnfermedadLegislada.Visible = true;
                chkbRecienNacido.Visible = true;
                lCUIT.Visible = false;
                gbObservaciones.Visible = true;
                tNombre.Focus();

            }
            else if (!chkbParticular.Checked && chkbEmpresa.Checked)
            {
                lNombre.Visible = true;
                tNombre.Visible = true;
                lRubro.Visible = true;
                tRubro.Visible = true;
                cbPlan.Visible = true;
                lApellido.Visible = false;
                tApellido.Visible = false;
                lDomicilio.Visible = true;
                tDomicilio.Visible = true;
                lCUIT.Visible = true;
                lDNI.Visible = false;
                mtDNI.Visible = true;
                cbSexo.Visible = false;
                cbEmpresa.Visible = false;
                lTelefono.Visible = true;
                mtTelefono.Visible = true;
                chkbEmbarazo.Visible = false;
                cbPlan.Visible = true;
                chkbDiscapacidad.Visible = false;
                chkbEnfermedadLegislada.Visible = false;
                chkbRecienNacido.Visible = false;
                gbObservaciones.Visible = false;
                tNombre.Focus();
            }
            else if (chkbParticular.Checked)
            {
                lNombre.Visible = true;
                tNombre.Visible = true;
                lApellido.Visible = true;
                tApellido.Visible = true;
                lDomicilio.Visible = true;
                tDomicilio.Visible = true;
                lDNI.Visible = true;
                mtDNI.Visible = true;
                lTelefono.Visible = true;
                mtTelefono.Visible = true;
                cbSexo.Visible = true;
                cbPlan.Visible = true;
                lRubro.Visible = false;
                cbEmpresa.Visible = false;
                tRubro.Visible = false;
                chkbEmbarazo.Visible = false;
                cbPlan.Visible = true;
                chkbDiscapacidad.Visible = true;
                chkbEnfermedadLegislada.Visible = true;
                chkbRecienNacido.Visible = true;
                lCUIT.Visible = false;
                gbObservaciones.Visible = true;
                tNombre.Focus();
            }
            else if (!chkbParticular.Checked)
            {
                lNombre.Visible = false;
                tNombre.Visible = false;
                lRubro.Visible = false;
                tRubro.Visible = false;
                cbPlan.Visible = false;
                lApellido.Visible = false;
                tApellido.Visible = false;
                lDomicilio.Visible = false;
                tDomicilio.Visible = false;
                lDNI.Visible = false;
                mtDNI.Visible = false;
                lTelefono.Visible = false;
                mtTelefono.Visible = false;
                cbSexo.Visible = false;
                chkbEmbarazo.Visible = false;
                cbPlan.Visible = false;
                chkbDiscapacidad.Visible = false;
                chkbEnfermedadLegislada.Visible = false;
                chkbRecienNacido.Visible = false;
                lCUIT.Visible = false;
                gbObservaciones.Visible = false;
            }

            if (chkbParticular.Checked) //validacion de Particular
            {
                epCampo.Clear();
            }
        }

        #endregion

        #region hacer visibiles las distintas secciones (cliente empresa) 2/2

        private void chkbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbParticular.Checked && chkbEmpresa.Checked)
            {
                lNombre.Visible = true;
                tNombre.Visible = true;
                lRubro.Visible = false;
                tRubro.Visible = false;
                cbPlan.Visible = true;
                lApellido.Visible = true;
                tApellido.Visible = true;
                lDomicilio.Visible = true;
                tDomicilio.Visible = true;
                lDNI.Visible = true;
                mtDNI.Visible = true;
                lTelefono.Visible = true;
                mtTelefono.Visible = true;
                cbSexo.Visible = true;
                cbEmpresa.Visible = true;
                chkbEmbarazo.Visible = false;
                cbPlan.Visible = false;
                lCUIT.Visible = false;
                gbObservaciones.Visible = true;
                tNombre.Focus();
            }
            else if (chkbParticular.Checked && !chkbEmpresa.Checked)
            {
                lNombre.Visible = true;
                tNombre.Visible = true;
                lRubro.Visible = false;
                tRubro.Visible = false;
                cbPlan.Visible = true;
                lApellido.Visible = true;
                tApellido.Visible = true;
                lDomicilio.Visible = true;
                tDomicilio.Visible = true;
                lDNI.Visible = true;
                mtDNI.Visible = true;
                cbSexo.Visible = true;
                cbEmpresa.Visible = false;
                lTelefono.Visible = true;
                mtTelefono.Visible = true;
                chkbEmbarazo.Visible = false;
                cbPlan.Visible = true;
                lCUIT.Visible = false;
                gbObservaciones.Visible = true;
                tNombre.Focus();
            }
            else if (chkbEmpresa.Checked)
            {
                lNombre.Visible = true;
                tNombre.Visible = true;
                lRubro.Visible = true;
                tRubro.Visible = true;
                cbPlan.Visible = true;
                lApellido.Visible = false;
                tApellido.Visible = false;
                lDNI.Visible = false;
                mtDNI.Visible = true;
                cbSexo.Visible = false;
                cbEmpresa.Visible = false;
                lDomicilio.Visible = true;
                tDomicilio.Visible = true;
                lTelefono.Visible = true;
                mtTelefono.Visible = true;
                chkbEmbarazo.Visible = false;
                lCUIT.Visible = true;
                gbObservaciones.Visible = false;
                tNombre.Focus();
            }
            else if (!chkbEmpresa.Checked)
            {
                lNombre.Visible = false;
                tNombre.Visible = false;
                lRubro.Visible = false;
                tRubro.Visible = false;
                cbPlan.Visible = false;
                lApellido.Visible = false;
                tApellido.Visible = false;
                lDomicilio.Visible = false;
                tDomicilio.Visible = false;
                lDNI.Visible = false;
                mtDNI.Visible = false;
                lTelefono.Visible = false;
                mtTelefono.Visible = false;
                cbSexo.Visible = false;
                chkbEmbarazo.Visible = false;
                cbPlan.Visible = false;
                lCUIT.Visible = false;
                gbObservaciones.Visible = false;
            }

            if (chkbEmpresa.Checked) //validacion Empresa
            {
                epCampo.Clear();
            }
        }
        #endregion

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSexo.SelectedIndex == 1)
            {
                chkbEmbarazo.Visible = true;
            }
            else chkbEmbarazo.Visible = false;
        }

        #region botones
        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            if (VerificarCampo())
            {
                AgregarNuevo();
            }
        }
        #endregion

        #region validaciones

        private void tNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tNombre.Text == "")
            {
                epCampo.SetError(tNombre, "Falta completar el Campo");
            }
            else
            {
                epCampo.Clear();
            }
        }

        private void tApellido_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tApellido.Text == "")
            {
                epCampo.SetError(tApellido, "Falta completar el Campo");
            }
            else
            {
                epCampo.Clear();
            }
        }

        private void mtDNI_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (mtDNI.MaskCompleted == false)
            {
                epCampo.SetError(mtDNI, "Ingrese su DNI");
            }
            else
            {
                epCampo.Clear();
            }
        }

        private void cbSexo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cbSexo.SelectedIndex == -1)
            {
                epCampo.SetError(cbSexo, "Elija el Sexo");
            }
            else
            {
                epCampo.Clear();
            }
        }

        private void cbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPlan.SelectedIndex == -1)
            {
                epCampo.SetError(cbPlan, "Elija un Plan");
            }
            else
            {
                epCampo.Clear();
            }
        }

        private void cbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmpresa.SelectedIndex == -1)
            {
                epCampo.SetError(cbEmpresa, "Elija una Empresa de las Existentes");
            }
            else
            {
                epCampo.Clear();
            }
        }

        private void tRubro_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tRubro.Text == "")
            {
                epCampo.SetError(tRubro, "Falta completar el Campo");
            }
            else
            {
                epCampo.Clear();
            }
        }
        #endregion

        #region metodo verificar campo

        public bool VerificarCampo() //Verifica los campos
        {
            bool campo = false;

            if (!chkbParticular.Checked && !chkbEmpresa.Checked) //group box particular o empresa
            {
                MessageBox.Show("Seleccione una opción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                epCampo.SetError(gbCliente, "Seleccione una opción, Particular o Empresa");
                gbCliente.Focus();
            }
            else if (tNombre.Text == "") //nombre
            {
                MessageBox.Show("Complete los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                epCampo.SetError(tNombre, "Falta completar el Campo");
                tNombre.Focus();
            }
            else if (chkbParticular.Checked && tApellido.Text == "") //apellido
            {
                MessageBox.Show("Complete los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                epCampo.SetError(tApellido, "Falta completar el Campo");
                tApellido.Focus();
            }
            else if (chkbParticular.Checked && !mtDNI.MaskCompleted) // DNI
            {
                MessageBox.Show("Complete los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                epCampo.SetError(mtDNI, "Ingrese un DNI valido");
                mtDNI.Focus();
            }
            else if (chkbParticular.Checked && cbSexo.SelectedIndex == -1) //sexo
            {
                MessageBox.Show("Complete los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                epCampo.SetError(cbSexo, "Elija el Sexo");
                cbSexo.Focus();
            }
            else if ((cbPlan.SelectedIndex == -1 && chkbEmpresa.Checked && !chkbParticular.Checked) || (cbPlan.SelectedIndex == -1 && !chkbEmpresa.Checked && chkbParticular.Checked)) //plan
            {
                MessageBox.Show("Complete los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                epCampo.SetError(cbPlan, "Elija un Plan");
                cbPlan.Focus();
            }
            else if (chkbEmpresa.Checked && cbEmpresa.SelectedIndex == -1 && chkbParticular.Checked) //empresa
            {
                if (cbEmpresa.Items.Count < 1)
                {
                    MessageBox.Show("No existen Empresas, primero debe cargar una Empresa Nueva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Complete los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    epCampo.SetError(cbEmpresa, "Elija una Empresa de las Existentes");
                    cbEmpresa.Focus();
                }
            }
            else if (!chkbParticular.Checked && chkbEmpresa.Checked && tRubro.Text == "") //rubro
            {
                MessageBox.Show("Complete los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                epCampo.SetError(tRubro, "Falta completar el Campo");
                tRubro.Focus();
            }
            else if (chkbEmbarazo.Checked && chkbRecienNacido.Checked)
            {
                MessageBox.Show("Observaciones 'Embarazo' y 'Recien Nacido', incompatibles, por favor seleccione el adecuado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                epCampo.SetError(gbObservaciones, "Seleccione la opcion adecuada");
                tRubro.Focus();
            }
            else campo = true;
            return campo;
        }
        #endregion

        #region metodo agregar nuevo

        public void AgregarNuevo() //mejorar observacion
        {
            if (chkbParticular.Checked && !chkbEmpresa.Checked) // solo particular
            {
                if (chkbDiscapacidad.Checked)
                {
                    lNroAfiliado1.Text = Convert.ToString(_nroControl++);
                    afiliado = new Afiliado(tNombre.Text, tApellido.Text, tDomicilio.Text, cbSexo.Text, chkbDiscapacidad.Text, Convert.ToInt32(mtDNI.Text.Replace(",", string.Empty)), Convert.ToDouble(mtTelefono.Text.Replace("-", string.Empty)), Convert.ToInt32(lNroAfiliado1.Text), dtFecha.Value, cbPlan.Text);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else if (chkbEnfermedadLegislada.Checked)
                {
                    afiliado = new Afiliado(tNombre.Text, tApellido.Text, tDomicilio.Text, cbSexo.Text, chkbEnfermedadLegislada.Text, Convert.ToInt32(mtDNI.Text.Replace(",", string.Empty)), Convert.ToDouble(mtTelefono.Text.Replace("-", string.Empty)), Convert.ToInt32(lNroAfiliado1.Text), dtFecha.Value, cbPlan.Text);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else if (chkbRecienNacido.Checked)
                {
                    afiliado = new Afiliado(tNombre.Text, tApellido.Text, tDomicilio.Text, cbSexo.Text, chkbRecienNacido.Text, Convert.ToInt32(mtDNI.Text.Replace(",", string.Empty)), Convert.ToDouble(mtTelefono.Text.Replace("-", string.Empty)), Convert.ToInt32(lNroAfiliado1.Text), dtFecha.Value, cbPlan.Text);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else if (cbSexo.Text == "Femenino" && chkbEmbarazo.Checked)
                {
                    afiliado = new Afiliado(tNombre.Text, tApellido.Text, tDomicilio.Text, cbSexo.Text, chkbEmbarazo.Text, Convert.ToInt32(mtDNI.Text.Replace(",", string.Empty)), Convert.ToDouble(mtTelefono.Text.Replace("-", string.Empty)), Convert.ToInt32(lNroAfiliado1.Text), dtFecha.Value, cbPlan.Text);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    afiliado = new Afiliado(tNombre.Text, tApellido.Text, tDomicilio.Text, cbSexo.Text, " - ", Convert.ToInt32(mtDNI.Text.Replace(",", string.Empty)), Convert.ToDouble(mtTelefono.Text.Replace("-", string.Empty)), Convert.ToInt32(lNroAfiliado1.Text), dtFecha.Value, cbPlan.Text);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else if (chkbEmpresa.Checked && !chkbParticular.Checked) // solo empresa
            {
                afiliado = new Empresa(Convert.ToInt32(mtDNI.Text.Replace(",", string.Empty)), Convert.ToInt32(lNroAfiliado1.Text), Convert.ToDouble(mtTelefono.Text.Replace("-", string.Empty)), tRubro.Text, tNombre.Text, cbPlan.Text, dtFecha.Value, tDomicilio.Text);

                DialogResult = DialogResult.OK;
                Close();
            }
            else if (chkbParticular.Checked && chkbEmpresa.Checked) // particular y empresa revisar aca!
            {
                if (chkbDiscapacidad.Checked)
                {
                    afiliado = new Afiliado(tNombre.Text, tApellido.Text, tDomicilio.Text, cbSexo.Text, chkbDiscapacidad.Text, Convert.ToInt32(mtDNI.Text.Replace(",", string.Empty)), Convert.ToDouble(mtTelefono.Text.Replace("-", string.Empty)), Convert.ToInt32(lNroAfiliado1.Text), dtFecha.Value, cbPlan.Text, cbEmpresa.Text);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else if (chkbEnfermedadLegislada.Checked)
                {
                    afiliado = new Afiliado(tNombre.Text, tApellido.Text, tDomicilio.Text, cbSexo.Text, chkbEnfermedadLegislada.Text, Convert.ToInt32(mtDNI.Text.Replace(",", string.Empty)), Convert.ToDouble(mtTelefono.Text.Replace("-", string.Empty)), Convert.ToInt32(lNroAfiliado1.Text), dtFecha.Value, cbPlan.Text, cbEmpresa.Text);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else if (chkbRecienNacido.Checked)
                {
                    afiliado = new Afiliado(tNombre.Text, tApellido.Text, tDomicilio.Text, cbSexo.Text, chkbRecienNacido.Text, Convert.ToInt32(mtDNI.Text.Replace(",", string.Empty)), Convert.ToDouble(mtTelefono.Text.Replace("-", string.Empty)), Convert.ToInt32(lNroAfiliado1.Text), dtFecha.Value, cbPlan.Text, cbEmpresa.Text);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else if (cbSexo.Text == "Femenino" && chkbEmbarazo.Checked)
                {
                    afiliado = new Afiliado(tNombre.Text, tApellido.Text, tDomicilio.Text, cbSexo.Text, chkbEmbarazo.Text, Convert.ToInt32(mtDNI.Text.Replace(",", string.Empty)), Convert.ToDouble(mtTelefono.Text.Replace("-", string.Empty)), Convert.ToInt32(lNroAfiliado1.Text), dtFecha.Value, cbPlan.Text, cbEmpresa.Text);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    afiliado = new Afiliado(tNombre.Text, tApellido.Text, tDomicilio.Text, cbSexo.Text, " - ", Convert.ToInt32(mtDNI.Text.Replace(",", string.Empty)), Convert.ToDouble(mtTelefono.Text.Replace("-", string.Empty)), Convert.ToInt32(lNroAfiliado1.Text), dtFecha.Value, cbPlan.Text, cbEmpresa.Text);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
        #endregion

        #region constructor
        public fAgregar()
        {
            InitializeComponent();
        }
        #endregion

        private void fAgregar_Load(object sender, EventArgs e)
        {
            lNroAfiliado1.Text = Convert.ToString(_nroControl++);
        }
    }
}





