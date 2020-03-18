namespace ObraSocial
{
    partial class fAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.chkbEmpresa = new System.Windows.Forms.CheckBox();
            this.chkbParticular = new System.Windows.Forms.CheckBox();
            this.mtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.mtDNI = new System.Windows.Forms.MaskedTextBox();
            this.lTelefono = new System.Windows.Forms.Label();
            this.lDNI = new System.Windows.Forms.Label();
            this.lDomicilio = new System.Windows.Forms.Label();
            this.lApellido = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.tDomicilio = new System.Windows.Forms.TextBox();
            this.tApellido = new System.Windows.Forms.TextBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.lRubro = new System.Windows.Forms.Label();
            this.tRubro = new System.Windows.Forms.TextBox();
            this.chkbEmbarazo = new System.Windows.Forms.CheckBox();
            this.chkbDiscapacidad = new System.Windows.Forms.CheckBox();
            this.chkbRecienNacido = new System.Windows.Forms.CheckBox();
            this.chkbEnfermedadLegislada = new System.Windows.Forms.CheckBox();
            this.lNroAfiliado = new System.Windows.Forms.Label();
            this.epCampo = new System.Windows.Forms.ErrorProvider(this.components);
            this.lCUIT = new System.Windows.Forms.Label();
            this.lNroAfiliado1 = new System.Windows.Forms.Label();
            this.gbObservaciones = new System.Windows.Forms.GroupBox();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCampo)).BeginInit();
            this.gbObservaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(275, 270);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 52;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(185, 270);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 23);
            this.bAgregar.TabIndex = 51;
            this.bAgregar.Text = "Aceptar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // cbPlan
            // 
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Items.AddRange(new object[] {
            "Plan A",
            "Plan B",
            "Plan C"});
            this.cbPlan.Location = new System.Drawing.Point(185, 73);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(100, 21);
            this.cbPlan.TabIndex = 45;
            this.cbPlan.Text = "Plan";
            this.cbPlan.Visible = false;
            this.cbPlan.SelectedIndexChanged += new System.EventHandler(this.cbPlan_SelectedIndexChanged);
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(16, 90);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(163, 20);
            this.dtFecha.TabIndex = 53;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.chkbEmpresa);
            this.gbCliente.Controls.Add(this.chkbParticular);
            this.gbCliente.Location = new System.Drawing.Point(16, 16);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(163, 68);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // chkbEmpresa
            // 
            this.chkbEmpresa.AutoSize = true;
            this.chkbEmpresa.Location = new System.Drawing.Point(6, 42);
            this.chkbEmpresa.Name = "chkbEmpresa";
            this.chkbEmpresa.Size = new System.Drawing.Size(67, 17);
            this.chkbEmpresa.TabIndex = 2;
            this.chkbEmpresa.Text = "Empresa";
            this.chkbEmpresa.UseVisualStyleBackColor = true;
            this.chkbEmpresa.CheckedChanged += new System.EventHandler(this.chkbEmpresa_CheckedChanged);
            // 
            // chkbParticular
            // 
            this.chkbParticular.AutoSize = true;
            this.chkbParticular.Location = new System.Drawing.Point(6, 19);
            this.chkbParticular.Name = "chkbParticular";
            this.chkbParticular.Size = new System.Drawing.Size(70, 17);
            this.chkbParticular.TabIndex = 1;
            this.chkbParticular.Text = "Particular";
            this.chkbParticular.UseVisualStyleBackColor = true;
            this.chkbParticular.CheckedChanged += new System.EventHandler(this.chkbParticular_CheckedChanged);
            // 
            // mtTelefono
            // 
            this.mtTelefono.Location = new System.Drawing.Point(79, 224);
            this.mtTelefono.Mask = "000-0000000";
            this.mtTelefono.Name = "mtTelefono";
            this.mtTelefono.Size = new System.Drawing.Size(100, 20);
            this.mtTelefono.TabIndex = 43;
            this.mtTelefono.Visible = false;
            // 
            // mtDNI
            // 
            this.mtDNI.Location = new System.Drawing.Point(79, 198);
            this.mtDNI.Mask = "00.000.000";
            this.mtDNI.Name = "mtDNI";
            this.mtDNI.Size = new System.Drawing.Size(100, 20);
            this.mtDNI.TabIndex = 42;
            this.mtDNI.Visible = false;
            this.mtDNI.Validating += new System.ComponentModel.CancelEventHandler(this.mtDNI_Validating);
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Location = new System.Drawing.Point(13, 230);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(52, 13);
            this.lTelefono.TabIndex = 41;
            this.lTelefono.Text = "Teléfono:";
            this.lTelefono.Visible = false;
            // 
            // lDNI
            // 
            this.lDNI.AutoSize = true;
            this.lDNI.Location = new System.Drawing.Point(13, 201);
            this.lDNI.Name = "lDNI";
            this.lDNI.Size = new System.Drawing.Size(29, 13);
            this.lDNI.TabIndex = 40;
            this.lDNI.Text = "DNI:";
            this.lDNI.Visible = false;
            // 
            // lDomicilio
            // 
            this.lDomicilio.AutoSize = true;
            this.lDomicilio.Location = new System.Drawing.Point(13, 175);
            this.lDomicilio.Name = "lDomicilio";
            this.lDomicilio.Size = new System.Drawing.Size(52, 13);
            this.lDomicilio.TabIndex = 39;
            this.lDomicilio.Text = "Domicilio:";
            this.lDomicilio.Visible = false;
            // 
            // lApellido
            // 
            this.lApellido.AutoSize = true;
            this.lApellido.Location = new System.Drawing.Point(13, 149);
            this.lApellido.Name = "lApellido";
            this.lApellido.Size = new System.Drawing.Size(47, 13);
            this.lApellido.TabIndex = 38;
            this.lApellido.Text = "Apellido:";
            this.lApellido.Visible = false;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(13, 123);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(47, 13);
            this.lNombre.TabIndex = 37;
            this.lNombre.Text = "Nombre:";
            this.lNombre.Visible = false;
            // 
            // tDomicilio
            // 
            this.tDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tDomicilio.Location = new System.Drawing.Point(79, 172);
            this.tDomicilio.Name = "tDomicilio";
            this.tDomicilio.Size = new System.Drawing.Size(100, 20);
            this.tDomicilio.TabIndex = 36;
            this.tDomicilio.Visible = false;
            // 
            // tApellido
            // 
            this.tApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tApellido.Location = new System.Drawing.Point(79, 146);
            this.tApellido.Name = "tApellido";
            this.tApellido.Size = new System.Drawing.Size(100, 20);
            this.tApellido.TabIndex = 35;
            this.tApellido.Visible = false;
            this.tApellido.Validating += new System.ComponentModel.CancelEventHandler(this.tApellido_Validating);
            // 
            // tNombre
            // 
            this.tNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tNombre.Location = new System.Drawing.Point(79, 120);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(100, 20);
            this.tNombre.TabIndex = 33;
            this.tNombre.Visible = false;
            this.tNombre.Validating += new System.ComponentModel.CancelEventHandler(this.tNombre_Validating);
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbSexo.Location = new System.Drawing.Point(79, 250);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(100, 21);
            this.cbSexo.TabIndex = 44;
            this.cbSexo.Text = "Sexo";
            this.cbSexo.Visible = false;
            this.cbSexo.SelectedIndexChanged += new System.EventHandler(this.cbSexo_SelectedIndexChanged);
            this.cbSexo.Validating += new System.ComponentModel.CancelEventHandler(this.cbSexo_Validating);
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Items.AddRange(new object[] {
            "GLOBANT",
            "HEXACTA",
            "LA BAHIENSE"});
            this.cbEmpresa.Location = new System.Drawing.Point(185, 46);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(121, 21);
            this.cbEmpresa.TabIndex = 54;
            this.cbEmpresa.Text = "Empresa";
            this.cbEmpresa.Visible = false;
            this.cbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cbEmpresa_SelectedIndexChanged);
            // 
            // lRubro
            // 
            this.lRubro.AutoSize = true;
            this.lRubro.Location = new System.Drawing.Point(184, 123);
            this.lRubro.Name = "lRubro";
            this.lRubro.Size = new System.Drawing.Size(39, 13);
            this.lRubro.TabIndex = 55;
            this.lRubro.Text = "Rubro:";
            this.lRubro.Visible = false;
            // 
            // tRubro
            // 
            this.tRubro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tRubro.Location = new System.Drawing.Point(229, 120);
            this.tRubro.Name = "tRubro";
            this.tRubro.Size = new System.Drawing.Size(100, 20);
            this.tRubro.TabIndex = 46;
            this.tRubro.Visible = false;
            this.tRubro.Validating += new System.ComponentModel.CancelEventHandler(this.tRubro_Validating);
            // 
            // chkbEmbarazo
            // 
            this.chkbEmbarazo.AutoSize = true;
            this.chkbEmbarazo.Location = new System.Drawing.Point(6, 88);
            this.chkbEmbarazo.Name = "chkbEmbarazo";
            this.chkbEmbarazo.Size = new System.Drawing.Size(73, 17);
            this.chkbEmbarazo.TabIndex = 50;
            this.chkbEmbarazo.Text = "Embarazo";
            this.chkbEmbarazo.UseVisualStyleBackColor = true;
            this.chkbEmbarazo.Visible = false;
            // 
            // chkbDiscapacidad
            // 
            this.chkbDiscapacidad.AutoSize = true;
            this.chkbDiscapacidad.Location = new System.Drawing.Point(6, 42);
            this.chkbDiscapacidad.Name = "chkbDiscapacidad";
            this.chkbDiscapacidad.Size = new System.Drawing.Size(91, 17);
            this.chkbDiscapacidad.TabIndex = 47;
            this.chkbDiscapacidad.Text = "Discapacidad";
            this.chkbDiscapacidad.UseVisualStyleBackColor = true;
            this.chkbDiscapacidad.Visible = false;
            // 
            // chkbRecienNacido
            // 
            this.chkbRecienNacido.AutoSize = true;
            this.chkbRecienNacido.Location = new System.Drawing.Point(6, 19);
            this.chkbRecienNacido.Name = "chkbRecienNacido";
            this.chkbRecienNacido.Size = new System.Drawing.Size(97, 17);
            this.chkbRecienNacido.TabIndex = 47;
            this.chkbRecienNacido.Text = "Recién Nacido";
            this.chkbRecienNacido.UseVisualStyleBackColor = true;
            this.chkbRecienNacido.Visible = false;
            // 
            // chkbEnfermedadLegislada
            // 
            this.chkbEnfermedadLegislada.AutoSize = true;
            this.chkbEnfermedadLegislada.Location = new System.Drawing.Point(6, 65);
            this.chkbEnfermedadLegislada.Name = "chkbEnfermedadLegislada";
            this.chkbEnfermedadLegislada.Size = new System.Drawing.Size(131, 17);
            this.chkbEnfermedadLegislada.TabIndex = 49;
            this.chkbEnfermedadLegislada.Text = "Enfermedad Legislada";
            this.chkbEnfermedadLegislada.UseVisualStyleBackColor = true;
            this.chkbEnfermedadLegislada.Visible = false;
            // 
            // lNroAfiliado
            // 
            this.lNroAfiliado.AutoSize = true;
            this.lNroAfiliado.Location = new System.Drawing.Point(182, 23);
            this.lNroAfiliado.Name = "lNroAfiliado";
            this.lNroAfiliado.Size = new System.Drawing.Size(64, 13);
            this.lNroAfiliado.TabIndex = 61;
            this.lNroAfiliado.Text = "Nro Afiliado:";
            // 
            // epCampo
            // 
            this.epCampo.ContainerControl = this;
            // 
            // lCUIT
            // 
            this.lCUIT.AutoSize = true;
            this.lCUIT.Location = new System.Drawing.Point(13, 201);
            this.lCUIT.Name = "lCUIT";
            this.lCUIT.Size = new System.Drawing.Size(35, 13);
            this.lCUIT.TabIndex = 63;
            this.lCUIT.Text = "CUIT:";
            this.lCUIT.Visible = false;
            // 
            // lNroAfiliado1
            // 
            this.lNroAfiliado1.AutoSize = true;
            this.lNroAfiliado1.Location = new System.Drawing.Point(255, 23);
            this.lNroAfiliado1.Name = "lNroAfiliado1";
            this.lNroAfiliado1.Size = new System.Drawing.Size(0, 13);
            this.lNroAfiliado1.TabIndex = 64;
            // 
            // gbObservaciones
            // 
            this.gbObservaciones.Controls.Add(this.chkbEmbarazo);
            this.gbObservaciones.Controls.Add(this.chkbRecienNacido);
            this.gbObservaciones.Controls.Add(this.chkbDiscapacidad);
            this.gbObservaciones.Controls.Add(this.chkbEnfermedadLegislada);
            this.gbObservaciones.Location = new System.Drawing.Point(188, 149);
            this.gbObservaciones.Name = "gbObservaciones";
            this.gbObservaciones.Size = new System.Drawing.Size(144, 115);
            this.gbObservaciones.TabIndex = 65;
            this.gbObservaciones.TabStop = false;
            this.gbObservaciones.Text = "Observaciones";
            this.gbObservaciones.Visible = false;
            // 
            // fAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 309);
            this.Controls.Add(this.gbObservaciones);
            this.Controls.Add(this.lNroAfiliado1);
            this.Controls.Add(this.lCUIT);
            this.Controls.Add(this.lNroAfiliado);
            this.Controls.Add(this.tRubro);
            this.Controls.Add(this.lRubro);
            this.Controls.Add(this.cbEmpresa);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.cbPlan);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.mtTelefono);
            this.Controls.Add(this.mtDNI);
            this.Controls.Add(this.lTelefono);
            this.Controls.Add(this.lDNI);
            this.Controls.Add(this.lDomicilio);
            this.Controls.Add(this.lApellido);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.tDomicilio);
            this.Controls.Add(this.tApellido);
            this.Controls.Add(this.tNombre);
            this.Name = "fAgregar";
            this.Text = "Agregar Afiliado";
            this.Load += new System.EventHandler(this.fAgregar_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCampo)).EndInit();
            this.gbObservaciones.ResumeLayout(false);
            this.gbObservaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lNroAfiliado;
        private System.Windows.Forms.ErrorProvider epCampo;
        private System.Windows.Forms.Label lNroAfiliado1;
        public System.Windows.Forms.ComboBox cbEmpresa;
        public System.Windows.Forms.TextBox tNombre;
        public System.Windows.Forms.CheckBox chkbParticular;
        public System.Windows.Forms.ComboBox cbPlan;
        public System.Windows.Forms.DateTimePicker dtFecha;
        public System.Windows.Forms.MaskedTextBox mtTelefono;
        public System.Windows.Forms.MaskedTextBox mtDNI;
        public System.Windows.Forms.TextBox tDomicilio;
        public System.Windows.Forms.TextBox tApellido;
        public System.Windows.Forms.ComboBox cbSexo;
        public System.Windows.Forms.CheckBox chkbEmpresa;
        public System.Windows.Forms.TextBox tRubro;
        public System.Windows.Forms.CheckBox chkbEmbarazo;
        public System.Windows.Forms.CheckBox chkbDiscapacidad;
        public System.Windows.Forms.CheckBox chkbRecienNacido;
        public System.Windows.Forms.CheckBox chkbEnfermedadLegislada;
        public System.Windows.Forms.Label lTelefono;
        public System.Windows.Forms.Label lDomicilio;
        public System.Windows.Forms.Label lApellido;
        public System.Windows.Forms.Label lNombre;
        public System.Windows.Forms.Label lRubro;
        public System.Windows.Forms.Label lCUIT;
        public System.Windows.Forms.Label lDNI;
        public System.Windows.Forms.GroupBox gbObservaciones;
    }
}