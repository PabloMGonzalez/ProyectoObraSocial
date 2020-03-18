namespace ObraSocial
{
    partial class fPrincipal
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
            this.bAgregar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.bPlanes = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bListar = new System.Windows.Forms.Button();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.gbAfiliado = new System.Windows.Forms.GroupBox();
            this.gbBuscarPor = new System.Windows.Forms.GroupBox();
            this.rbApellido = new System.Windows.Forms.RadioButton();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.mtDNI = new System.Windows.Forms.MaskedTextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.tApellido = new System.Windows.Forms.TextBox();
            this.gbListarPor = new System.Windows.Forms.GroupBox();
            this.chkbEmbarazo = new System.Windows.Forms.CheckBox();
            this.rbSexo = new System.Windows.Forms.RadioButton();
            this.rbEmpresa = new System.Windows.Forms.RadioButton();
            this.rbPlan = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbEnfermedadLegislada = new System.Windows.Forms.RadioButton();
            this.rbDiscapacidad = new System.Windows.Forms.RadioButton();
            this.rbRecienNacido = new System.Windows.Forms.RadioButton();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.rbListarPor = new System.Windows.Forms.RadioButton();
            this.rbBuscarPor = new System.Windows.Forms.RadioButton();
            this.mcEditar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mciModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.mciEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.miArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.miAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.miLimpiar = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.miSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsListado = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLimpiar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.gbAfiliado.SuspendLayout();
            this.gbBuscarPor.SuspendLayout();
            this.gbListarPor.SuspendLayout();
            this.mcEditar.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.cmsListado.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(12, 402);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 42);
            this.bAgregar.TabIndex = 0;
            this.bAgregar.Text = "Agregar Afiliado";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(355, 348);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(75, 42);
            this.bModificar.TabIndex = 1;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(680, 348);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(75, 42);
            this.bSalir.TabIndex = 2;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bPlanes
            // 
            this.bPlanes.Location = new System.Drawing.Point(93, 402);
            this.bPlanes.Name = "bPlanes";
            this.bPlanes.Size = new System.Drawing.Size(75, 42);
            this.bPlanes.TabIndex = 3;
            this.bPlanes.Text = "Planes";
            this.bPlanes.UseVisualStyleBackColor = true;
            this.bPlanes.Click += new System.EventHandler(this.bPlanes_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(517, 348);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 42);
            this.bEliminar.TabIndex = 5;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bListar
            // 
            this.bListar.Location = new System.Drawing.Point(255, 312);
            this.bListar.Name = "bListar";
            this.bListar.Size = new System.Drawing.Size(75, 42);
            this.bListar.TabIndex = 6;
            this.bListar.Text = "Listar";
            this.bListar.UseVisualStyleBackColor = true;
            this.bListar.Click += new System.EventHandler(this.bListar_Click);
            // 
            // dgvListar
            // 
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.ContextMenuStrip = this.cmsListado;
            this.dgvListar.Location = new System.Drawing.Point(355, 36);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.Size = new System.Drawing.Size(400, 301);
            this.dgvListar.TabIndex = 7;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(436, 348);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 42);
            this.bLimpiar.TabIndex = 8;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // gbAfiliado
            // 
            this.gbAfiliado.Controls.Add(this.gbBuscarPor);
            this.gbAfiliado.Controls.Add(this.gbListarPor);
            this.gbAfiliado.Controls.Add(this.rbListarPor);
            this.gbAfiliado.Controls.Add(this.bListar);
            this.gbAfiliado.Controls.Add(this.rbBuscarPor);
            this.gbAfiliado.Location = new System.Drawing.Point(12, 36);
            this.gbAfiliado.Name = "gbAfiliado";
            this.gbAfiliado.Size = new System.Drawing.Size(337, 360);
            this.gbAfiliado.TabIndex = 9;
            this.gbAfiliado.TabStop = false;
            this.gbAfiliado.Text = "Afiliado";
            // 
            // gbBuscarPor
            // 
            this.gbBuscarPor.Controls.Add(this.rbApellido);
            this.gbBuscarPor.Controls.Add(this.rbDNI);
            this.gbBuscarPor.Controls.Add(this.mtDNI);
            this.gbBuscarPor.Controls.Add(this.bBuscar);
            this.gbBuscarPor.Controls.Add(this.tApellido);
            this.gbBuscarPor.Location = new System.Drawing.Point(3, 42);
            this.gbBuscarPor.Name = "gbBuscarPor";
            this.gbBuscarPor.Size = new System.Drawing.Size(178, 108);
            this.gbBuscarPor.TabIndex = 78;
            this.gbBuscarPor.TabStop = false;
            // 
            // rbApellido
            // 
            this.rbApellido.AutoSize = true;
            this.rbApellido.Location = new System.Drawing.Point(6, 34);
            this.rbApellido.Name = "rbApellido";
            this.rbApellido.Size = new System.Drawing.Size(65, 17);
            this.rbApellido.TabIndex = 1;
            this.rbApellido.TabStop = true;
            this.rbApellido.Text = "Apellido:";
            this.rbApellido.UseVisualStyleBackColor = true;
            this.rbApellido.CheckedChanged += new System.EventHandler(this.rbApellido_CheckedChanged);
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Location = new System.Drawing.Point(6, 11);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(47, 17);
            this.rbDNI.TabIndex = 0;
            this.rbDNI.TabStop = true;
            this.rbDNI.Text = "DNI:";
            this.rbDNI.UseVisualStyleBackColor = true;
            this.rbDNI.CheckedChanged += new System.EventHandler(this.rbDNI_CheckedChanged);
            // 
            // mtDNI
            // 
            this.mtDNI.Location = new System.Drawing.Point(73, 8);
            this.mtDNI.Mask = "00.000.000";
            this.mtDNI.Name = "mtDNI";
            this.mtDNI.Size = new System.Drawing.Size(100, 20);
            this.mtDNI.TabIndex = 69;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(98, 58);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 42);
            this.bBuscar.TabIndex = 10;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // tApellido
            // 
            this.tApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tApellido.Location = new System.Drawing.Point(73, 35);
            this.tApellido.Name = "tApellido";
            this.tApellido.Size = new System.Drawing.Size(100, 20);
            this.tApellido.TabIndex = 5;
            // 
            // gbListarPor
            // 
            this.gbListarPor.Controls.Add(this.chkbEmbarazo);
            this.gbListarPor.Controls.Add(this.rbSexo);
            this.gbListarPor.Controls.Add(this.rbEmpresa);
            this.gbListarPor.Controls.Add(this.rbPlan);
            this.gbListarPor.Controls.Add(this.rbTodos);
            this.gbListarPor.Controls.Add(this.rbEnfermedadLegislada);
            this.gbListarPor.Controls.Add(this.rbDiscapacidad);
            this.gbListarPor.Controls.Add(this.rbRecienNacido);
            this.gbListarPor.Controls.Add(this.cbSexo);
            this.gbListarPor.Controls.Add(this.cbEmpresa);
            this.gbListarPor.Controls.Add(this.cbPlan);
            this.gbListarPor.Location = new System.Drawing.Point(187, 39);
            this.gbListarPor.Name = "gbListarPor";
            this.gbListarPor.Size = new System.Drawing.Size(143, 270);
            this.gbListarPor.TabIndex = 69;
            this.gbListarPor.TabStop = false;
            // 
            // chkbEmbarazo
            // 
            this.chkbEmbarazo.AutoSize = true;
            this.chkbEmbarazo.Location = new System.Drawing.Point(6, 155);
            this.chkbEmbarazo.Name = "chkbEmbarazo";
            this.chkbEmbarazo.Size = new System.Drawing.Size(73, 17);
            this.chkbEmbarazo.TabIndex = 70;
            this.chkbEmbarazo.Text = "Embarazo";
            this.chkbEmbarazo.UseVisualStyleBackColor = true;
            // 
            // rbSexo
            // 
            this.rbSexo.AutoSize = true;
            this.rbSexo.Location = new System.Drawing.Point(6, 107);
            this.rbSexo.Name = "rbSexo";
            this.rbSexo.Size = new System.Drawing.Size(49, 17);
            this.rbSexo.TabIndex = 76;
            this.rbSexo.TabStop = true;
            this.rbSexo.Text = "Sexo";
            this.rbSexo.UseVisualStyleBackColor = true;
            this.rbSexo.CheckedChanged += new System.EventHandler(this.rbSexo_CheckedChanged);
            // 
            // rbEmpresa
            // 
            this.rbEmpresa.AutoSize = true;
            this.rbEmpresa.Location = new System.Drawing.Point(6, 11);
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.Size = new System.Drawing.Size(66, 17);
            this.rbEmpresa.TabIndex = 77;
            this.rbEmpresa.TabStop = true;
            this.rbEmpresa.Text = "Empresa";
            this.rbEmpresa.UseVisualStyleBackColor = true;
            this.rbEmpresa.CheckedChanged += new System.EventHandler(this.rbEmpresa_CheckedChanged);
            // 
            // rbPlan
            // 
            this.rbPlan.AutoSize = true;
            this.rbPlan.Location = new System.Drawing.Point(6, 59);
            this.rbPlan.Name = "rbPlan";
            this.rbPlan.Size = new System.Drawing.Size(46, 17);
            this.rbPlan.TabIndex = 75;
            this.rbPlan.TabStop = true;
            this.rbPlan.Text = "Plan";
            this.rbPlan.UseVisualStyleBackColor = true;
            this.rbPlan.CheckedChanged += new System.EventHandler(this.rbPlan_CheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(6, 243);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 74;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbEnfermedadLegislada
            // 
            this.rbEnfermedadLegislada.AutoSize = true;
            this.rbEnfermedadLegislada.Location = new System.Drawing.Point(6, 221);
            this.rbEnfermedadLegislada.Name = "rbEnfermedadLegislada";
            this.rbEnfermedadLegislada.Size = new System.Drawing.Size(130, 17);
            this.rbEnfermedadLegislada.TabIndex = 73;
            this.rbEnfermedadLegislada.TabStop = true;
            this.rbEnfermedadLegislada.Text = "Enfermedad Legislada";
            this.rbEnfermedadLegislada.UseVisualStyleBackColor = true;
            // 
            // rbDiscapacidad
            // 
            this.rbDiscapacidad.AutoSize = true;
            this.rbDiscapacidad.Location = new System.Drawing.Point(6, 199);
            this.rbDiscapacidad.Name = "rbDiscapacidad";
            this.rbDiscapacidad.Size = new System.Drawing.Size(90, 17);
            this.rbDiscapacidad.TabIndex = 72;
            this.rbDiscapacidad.TabStop = true;
            this.rbDiscapacidad.Text = "Discapacidad";
            this.rbDiscapacidad.UseVisualStyleBackColor = true;
            // 
            // rbRecienNacido
            // 
            this.rbRecienNacido.AutoSize = true;
            this.rbRecienNacido.Location = new System.Drawing.Point(6, 177);
            this.rbRecienNacido.Name = "rbRecienNacido";
            this.rbRecienNacido.Size = new System.Drawing.Size(96, 17);
            this.rbRecienNacido.TabIndex = 71;
            this.rbRecienNacido.TabStop = true;
            this.rbRecienNacido.Text = "Recién Nacido";
            this.rbRecienNacido.UseVisualStyleBackColor = true;
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbSexo.Location = new System.Drawing.Point(10, 129);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(100, 21);
            this.cbSexo.TabIndex = 62;
            this.cbSexo.Text = "Sexo";
            this.cbSexo.SelectedIndexChanged += new System.EventHandler(this.cbSexo_SelectedIndexChanged);
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Items.AddRange(new object[] {
            "GLOBANT",
            "HEXACTA",
            "LA BAHIENSE"});
            this.cbEmpresa.Location = new System.Drawing.Point(10, 33);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(121, 21);
            this.cbEmpresa.TabIndex = 63;
            this.cbEmpresa.Text = "Empresa";
            // 
            // cbPlan
            // 
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Items.AddRange(new object[] {
            "Plan A",
            "Plan B",
            "Plan C"});
            this.cbPlan.Location = new System.Drawing.Point(10, 81);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(100, 21);
            this.cbPlan.TabIndex = 61;
            this.cbPlan.Text = "Plan";
            // 
            // rbListarPor
            // 
            this.rbListarPor.AutoSize = true;
            this.rbListarPor.Location = new System.Drawing.Point(187, 19);
            this.rbListarPor.Name = "rbListarPor";
            this.rbListarPor.Size = new System.Drawing.Size(71, 17);
            this.rbListarPor.TabIndex = 1;
            this.rbListarPor.Text = "Listar por:";
            this.rbListarPor.UseVisualStyleBackColor = true;
            // 
            // rbBuscarPor
            // 
            this.rbBuscarPor.AutoSize = true;
            this.rbBuscarPor.Checked = true;
            this.rbBuscarPor.Location = new System.Drawing.Point(4, 19);
            this.rbBuscarPor.Name = "rbBuscarPor";
            this.rbBuscarPor.Size = new System.Drawing.Size(79, 17);
            this.rbBuscarPor.TabIndex = 0;
            this.rbBuscarPor.TabStop = true;
            this.rbBuscarPor.Text = "Buscar por:";
            this.rbBuscarPor.UseVisualStyleBackColor = true;
            this.rbBuscarPor.CheckedChanged += new System.EventHandler(this.rbBuscarPor_CheckedChanged);
            // 
            // mcEditar
            // 
            this.mcEditar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mciModificar,
            this.mciEliminar});
            this.mcEditar.Name = "mcEditar";
            this.mcEditar.Size = new System.Drawing.Size(126, 48);
            // 
            // mciModificar
            // 
            this.mciModificar.Name = "mciModificar";
            this.mciModificar.Size = new System.Drawing.Size(125, 22);
            this.mciModificar.Text = "Modificar";
            // 
            // mciEliminar
            // 
            this.mciEliminar.Name = "mciEliminar";
            this.mciEliminar.Size = new System.Drawing.Size(125, 22);
            this.mciEliminar.Text = "Eliminar";
            // 
            // miArchivo
            // 
            this.miArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAgregar,
            this.miLimpiar});
            this.miArchivo.Name = "miArchivo";
            this.miArchivo.Size = new System.Drawing.Size(60, 20);
            this.miArchivo.Text = "&Archivo";
            // 
            // miAgregar
            // 
            this.miAgregar.Name = "miAgregar";
            this.miAgregar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.miAgregar.Size = new System.Drawing.Size(180, 22);
            this.miAgregar.Text = "Agregar";
            this.miAgregar.ToolTipText = "Agrega un Afiliado nuevo";
            this.miAgregar.Click += new System.EventHandler(this.miAgregar_Click);
            // 
            // miLimpiar
            // 
            this.miLimpiar.Name = "miLimpiar";
            this.miLimpiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.miLimpiar.Size = new System.Drawing.Size(180, 22);
            this.miLimpiar.Text = "Limpiar";
            this.miLimpiar.ToolTipText = "Limpia el listado";
            this.miLimpiar.Click += new System.EventHandler(this.miLimpiar_Click);
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miArchivo,
            this.miSalir});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(767, 24);
            this.msMenu.TabIndex = 4;
            this.msMenu.Text = "Menú";
            // 
            // miSalir
            // 
            this.miSalir.Name = "miSalir";
            this.miSalir.Size = new System.Drawing.Size(41, 20);
            this.miSalir.Text = "Salir";
            this.miSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // cmsListado
            // 
            this.cmsListado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModificar,
            this.tsmiLimpiar,
            this.tsmiEliminar});
            this.cmsListado.Name = "cmsListado";
            this.cmsListado.Size = new System.Drawing.Size(126, 70);
            // 
            // tsmiModificar
            // 
            this.tsmiModificar.Name = "tsmiModificar";
            this.tsmiModificar.Size = new System.Drawing.Size(180, 22);
            this.tsmiModificar.Text = "Modificar";
            this.tsmiModificar.Click += new System.EventHandler(this.tsmiModificar_Click);
            // 
            // tsmiLimpiar
            // 
            this.tsmiLimpiar.Name = "tsmiLimpiar";
            this.tsmiLimpiar.Size = new System.Drawing.Size(180, 22);
            this.tsmiLimpiar.Text = "Limpiar";
            this.tsmiLimpiar.Click += new System.EventHandler(this.tsmiLimpiar_Click);
            // 
            // tsmiEliminar
            // 
            this.tsmiEliminar.Name = "tsmiEliminar";
            this.tsmiEliminar.Size = new System.Drawing.Size(180, 22);
            this.tsmiEliminar.Text = "Eliminar";
            this.tsmiEliminar.Click += new System.EventHandler(this.tsmiEliminar_Click);
            // 
            // fPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 451);
            this.Controls.Add(this.gbAfiliado);
            this.Controls.Add(this.dgvListar);
            this.Controls.Add(this.bPlanes);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "fPrincipal";
            this.Text = "Sistema Afiliados";
            this.Load += new System.EventHandler(this.fPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.gbAfiliado.ResumeLayout(false);
            this.gbAfiliado.PerformLayout();
            this.gbBuscarPor.ResumeLayout(false);
            this.gbBuscarPor.PerformLayout();
            this.gbListarPor.ResumeLayout(false);
            this.gbListarPor.PerformLayout();
            this.mcEditar.ResumeLayout(false);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.cmsListado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button bPlanes;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bListar;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.GroupBox gbAfiliado;
        private System.Windows.Forms.RadioButton rbBuscarPor;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.RadioButton rbListarPor;
        private System.Windows.Forms.TextBox tApellido;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.ComboBox cbPlan;
        private System.Windows.Forms.MaskedTextBox mtDNI;
        private System.Windows.Forms.ContextMenuStrip mcEditar;
        private System.Windows.Forms.ToolStripMenuItem mciModificar;
        private System.Windows.Forms.ToolStripMenuItem mciEliminar;
        private System.Windows.Forms.ToolStripMenuItem miArchivo;
        private System.Windows.Forms.ToolStripMenuItem miAgregar;
        private System.Windows.Forms.ToolStripMenuItem miLimpiar;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem miSalir;
        private System.Windows.Forms.GroupBox gbListarPor;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbEnfermedadLegislada;
        private System.Windows.Forms.RadioButton rbDiscapacidad;
        private System.Windows.Forms.RadioButton rbRecienNacido;
        private System.Windows.Forms.RadioButton rbEmpresa;
        private System.Windows.Forms.RadioButton rbSexo;
        private System.Windows.Forms.RadioButton rbPlan;
        private System.Windows.Forms.CheckBox chkbEmbarazo;
        private System.Windows.Forms.GroupBox gbBuscarPor;
        private System.Windows.Forms.RadioButton rbApellido;
        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.ContextMenuStrip cmsListado;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificar;
        private System.Windows.Forms.ToolStripMenuItem tsmiLimpiar;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminar;
    }
}

