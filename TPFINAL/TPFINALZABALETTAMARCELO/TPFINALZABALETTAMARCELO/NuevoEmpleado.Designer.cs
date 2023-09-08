namespace TPFINALZABALETTAMARCELO
{
    partial class NuevoEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoEmpleado));
            this.NyA = new System.Windows.Forms.Label();
            this.DNI = new System.Windows.Forms.Label();
            this.Edad = new System.Windows.Forms.Label();
            this.Casado = new System.Windows.Forms.Label();
            this.Salario = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.comboCasado = new System.Windows.Forms.ComboBox();
            this.eMPLEADOS_DBDataSet = new TPFINALZABALETTAMARCELO.EMPLEADOS_DBDataSet();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new TPFINALZABALETTAMARCELO.EMPLEADOS_DBDataSetTableAdapters.EmpleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOS_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NyA
            // 
            this.NyA.AutoSize = true;
            this.NyA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NyA.Location = new System.Drawing.Point(43, 63);
            this.NyA.Name = "NyA";
            this.NyA.Size = new System.Drawing.Size(120, 16);
            this.NyA.TabIndex = 0;
            this.NyA.Text = "Nombre Completo:";
            this.NyA.Click += new System.EventHandler(this.NyA_Click);
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNI.Location = new System.Drawing.Point(130, 102);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(33, 16);
            this.DNI.TabIndex = 1;
            this.DNI.Text = "DNI:";
            this.DNI.Click += new System.EventHandler(this.DNI_Click);
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edad.Location = new System.Drawing.Point(120, 140);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(43, 16);
            this.Edad.TabIndex = 2;
            this.Edad.Text = "Edad:";
            this.Edad.Click += new System.EventHandler(this.Edad_Click);
            // 
            // Casado
            // 
            this.Casado.AutoSize = true;
            this.Casado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Casado.Location = new System.Drawing.Point(105, 180);
            this.Casado.Name = "Casado";
            this.Casado.Size = new System.Drawing.Size(58, 16);
            this.Casado.TabIndex = 3;
            this.Casado.Text = "Casado:";
            this.Casado.Click += new System.EventHandler(this.Casado_Click);
            // 
            // Salario
            // 
            this.Salario.AutoSize = true;
            this.Salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salario.Location = new System.Drawing.Point(111, 216);
            this.Salario.Name = "Salario";
            this.Salario.Size = new System.Drawing.Size(53, 16);
            this.Salario.TabIndex = 4;
            this.Salario.Text = "Salario:";
            this.Salario.Click += new System.EventHandler(this.Salario_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(310, 270);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 58);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(169, 270);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 58);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(170, 63);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(215, 20);
            this.txtNombreCompleto.TabIndex = 1;
            this.txtNombreCompleto.TextChanged += new System.EventHandler(this.txtNombreCompleto_TextChanged);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(169, 102);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(215, 20);
            this.txtDNI.TabIndex = 2;
            this.txtDNI.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(169, 139);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(215, 20);
            this.txtEdad.TabIndex = 3;
            this.txtEdad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(170, 212);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(215, 20);
            this.txtSalario.TabIndex = 5;
            this.txtSalario.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboCasado
            // 
            this.comboCasado.FormattingEnabled = true;
            this.comboCasado.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.comboCasado.Location = new System.Drawing.Point(170, 174);
            this.comboCasado.Name = "comboCasado";
            this.comboCasado.Size = new System.Drawing.Size(215, 21);
            this.comboCasado.TabIndex = 4;
            this.comboCasado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // eMPLEADOS_DBDataSet
            // 
            this.eMPLEADOS_DBDataSet.DataSetName = "EMPLEADOS_DBDataSet";
            this.eMPLEADOS_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.eMPLEADOS_DBDataSet;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // NuevoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 378);
            this.Controls.Add(this.comboCasado);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.Salario);
            this.Controls.Add(this.Casado);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.NyA);
            this.Name = "NuevoEmpleado";
            this.Text = "NuevoEmpleado";
            this.Load += new System.EventHandler(this.NuevoEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOS_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NyA;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Label Edad;
        private System.Windows.Forms.Label Casado;
        private System.Windows.Forms.Label Salario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.ComboBox comboCasado;
        private EMPLEADOS_DBDataSet eMPLEADOS_DBDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private EMPLEADOS_DBDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
    }
}