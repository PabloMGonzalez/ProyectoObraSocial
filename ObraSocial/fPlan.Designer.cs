namespace ObraSocial
{
    partial class fPlan
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
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.lPlan = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            this.lMedicamentos = new System.Windows.Forms.Label();
            this.lPracticas = new System.Windows.Forms.Label();
            this.lConsultas = new System.Windows.Forms.Label();
            this.lCirugias = new System.Windows.Forms.Label();
            this.mtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.mtMedicamentos = new System.Windows.Forms.MaskedTextBox();
            this.mtPracticas = new System.Windows.Forms.MaskedTextBox();
            this.mtConsultas = new System.Windows.Forms.MaskedTextBox();
            this.mtCirugias = new System.Windows.Forms.MaskedTextBox();
            this.bSalir = new System.Windows.Forms.Button();
            this.bAgregarPlan = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPlan
            // 
            this.cbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Items.AddRange(new object[] {
            "Plan A",
            "Plan B",
            "Plan C"});
            this.cbPlan.Location = new System.Drawing.Point(101, 18);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(121, 21);
            this.cbPlan.TabIndex = 0;
            this.cbPlan.SelectedIndexChanged += new System.EventHandler(this.cbPlan_SelectedIndexChanged);
            // 
            // lPlan
            // 
            this.lPlan.AutoSize = true;
            this.lPlan.Location = new System.Drawing.Point(16, 21);
            this.lPlan.Name = "lPlan";
            this.lPlan.Size = new System.Drawing.Size(31, 13);
            this.lPlan.TabIndex = 1;
            this.lPlan.Text = "Plan:";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(16, 48);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(40, 13);
            this.lPrecio.TabIndex = 2;
            this.lPrecio.Text = "Precio:";
            // 
            // lMedicamentos
            // 
            this.lMedicamentos.AutoSize = true;
            this.lMedicamentos.Location = new System.Drawing.Point(16, 74);
            this.lMedicamentos.Name = "lMedicamentos";
            this.lMedicamentos.Size = new System.Drawing.Size(79, 13);
            this.lMedicamentos.TabIndex = 3;
            this.lMedicamentos.Text = "Medicamentos:";
            // 
            // lPracticas
            // 
            this.lPracticas.AutoSize = true;
            this.lPracticas.Location = new System.Drawing.Point(16, 100);
            this.lPracticas.Name = "lPracticas";
            this.lPracticas.Size = new System.Drawing.Size(54, 13);
            this.lPracticas.TabIndex = 4;
            this.lPracticas.Text = "Practicas:";
            // 
            // lConsultas
            // 
            this.lConsultas.AutoSize = true;
            this.lConsultas.Location = new System.Drawing.Point(16, 126);
            this.lConsultas.Name = "lConsultas";
            this.lConsultas.Size = new System.Drawing.Size(56, 13);
            this.lConsultas.TabIndex = 5;
            this.lConsultas.Text = "Consultas:";
            // 
            // lCirugias
            // 
            this.lCirugias.AutoSize = true;
            this.lCirugias.Location = new System.Drawing.Point(16, 152);
            this.lCirugias.Name = "lCirugias";
            this.lCirugias.Size = new System.Drawing.Size(47, 13);
            this.lCirugias.TabIndex = 6;
            this.lCirugias.Text = "Cirugias:";
            // 
            // mtPrecio
            // 
            this.mtPrecio.Enabled = false;
            this.mtPrecio.Location = new System.Drawing.Point(101, 45);
            this.mtPrecio.Mask = "9999";
            this.mtPrecio.Name = "mtPrecio";
            this.mtPrecio.Size = new System.Drawing.Size(35, 20);
            this.mtPrecio.TabIndex = 7;
            this.mtPrecio.ValidatingType = typeof(int);
            // 
            // mtMedicamentos
            // 
            this.mtMedicamentos.Enabled = false;
            this.mtMedicamentos.Location = new System.Drawing.Point(101, 71);
            this.mtMedicamentos.Mask = "99%";
            this.mtMedicamentos.Name = "mtMedicamentos";
            this.mtMedicamentos.Size = new System.Drawing.Size(35, 20);
            this.mtMedicamentos.TabIndex = 8;
            // 
            // mtPracticas
            // 
            this.mtPracticas.Enabled = false;
            this.mtPracticas.Location = new System.Drawing.Point(101, 97);
            this.mtPracticas.Mask = "99%";
            this.mtPracticas.Name = "mtPracticas";
            this.mtPracticas.Size = new System.Drawing.Size(35, 20);
            this.mtPracticas.TabIndex = 9;
            // 
            // mtConsultas
            // 
            this.mtConsultas.Enabled = false;
            this.mtConsultas.Location = new System.Drawing.Point(101, 123);
            this.mtConsultas.Mask = "99%";
            this.mtConsultas.Name = "mtConsultas";
            this.mtConsultas.Size = new System.Drawing.Size(35, 20);
            this.mtConsultas.TabIndex = 10;
            // 
            // mtCirugias
            // 
            this.mtCirugias.Enabled = false;
            this.mtCirugias.Location = new System.Drawing.Point(101, 149);
            this.mtCirugias.Mask = "99%";
            this.mtCirugias.Name = "mtCirugias";
            this.mtCirugias.Size = new System.Drawing.Size(35, 20);
            this.mtCirugias.TabIndex = 11;
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(164, 182);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(64, 35);
            this.bSalir.TabIndex = 12;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bAgregarPlan
            // 
            this.bAgregarPlan.Location = new System.Drawing.Point(89, 182);
            this.bAgregarPlan.Name = "bAgregarPlan";
            this.bAgregarPlan.Size = new System.Drawing.Size(64, 35);
            this.bAgregarPlan.TabIndex = 13;
            this.bAgregarPlan.Text = "Agregar Plan";
            this.bAgregarPlan.UseVisualStyleBackColor = true;
            this.bAgregarPlan.Click += new System.EventHandler(this.bAgregarPlan_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Enabled = false;
            this.bAceptar.Location = new System.Drawing.Point(12, 182);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(64, 35);
            this.bAceptar.TabIndex = 14;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // fPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 234);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bAgregarPlan);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.mtCirugias);
            this.Controls.Add(this.mtConsultas);
            this.Controls.Add(this.mtPracticas);
            this.Controls.Add(this.mtMedicamentos);
            this.Controls.Add(this.mtPrecio);
            this.Controls.Add(this.lCirugias);
            this.Controls.Add(this.lConsultas);
            this.Controls.Add(this.lPracticas);
            this.Controls.Add(this.lMedicamentos);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.lPlan);
            this.Controls.Add(this.cbPlan);
            this.Name = "fPlan";
            this.Text = "Plan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPlan;
        private System.Windows.Forms.Label lPlan;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.Label lMedicamentos;
        private System.Windows.Forms.Label lPracticas;
        private System.Windows.Forms.Label lConsultas;
        private System.Windows.Forms.Label lCirugias;
        private System.Windows.Forms.MaskedTextBox mtPrecio;
        private System.Windows.Forms.MaskedTextBox mtMedicamentos;
        private System.Windows.Forms.MaskedTextBox mtPracticas;
        private System.Windows.Forms.MaskedTextBox mtConsultas;
        private System.Windows.Forms.MaskedTextBox mtCirugias;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button bAgregarPlan;
        private System.Windows.Forms.Button bAceptar;
    }
}