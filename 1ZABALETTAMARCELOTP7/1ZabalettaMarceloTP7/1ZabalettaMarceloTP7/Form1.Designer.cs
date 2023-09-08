namespace _1ZabalettaMarceloTP7
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataEmpleados = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new _1ZabalettaMarceloTP7.DataSet1();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new _1ZabalettaMarceloTP7.DataSet1TableAdapters.EmpleadosTableAdapter();
            this.eMPLEADOS_DBDataSet = new _1ZabalettaMarceloTP7.EMPLEADOS_DBDataSet();
            this.eMPLEADOSDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOS_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(657, 401);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 33);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataEmpleados
            // 
            this.dataEmpleados.AutoGenerateColumns = false;
            this.dataEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn,
            this.dNIDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.casadoDataGridViewCheckBoxColumn,
            this.salarioDataGridViewTextBoxColumn});
            this.dataEmpleados.DataSource = this.empleadosBindingSource1;
            this.dataEmpleados.Location = new System.Drawing.Point(107, 132);
            this.dataEmpleados.Name = "dataEmpleados";
            this.dataEmpleados.Size = new System.Drawing.Size(645, 236);
            this.dataEmpleados.TabIndex = 3;
            this.dataEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEmpleados_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            this.dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // casadoDataGridViewCheckBoxColumn
            // 
            this.casadoDataGridViewCheckBoxColumn.DataPropertyName = "Casado";
            this.casadoDataGridViewCheckBoxColumn.HeaderText = "Casado";
            this.casadoDataGridViewCheckBoxColumn.Name = "casadoDataGridViewCheckBoxColumn";
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            this.salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            // 
            // empleadosBindingSource1
            // 
            this.empleadosBindingSource1.DataMember = "Empleados";
            this.empleadosBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.dataSet1;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // eMPLEADOS_DBDataSet
            // 
            this.eMPLEADOS_DBDataSet.DataSetName = "EMPLEADOS_DBDataSet";
            this.eMPLEADOS_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLEADOSDBDataSetBindingSource
            // 
            this.eMPLEADOSDBDataSetBindingSource.DataSource = this.eMPLEADOS_DBDataSet;
            this.eMPLEADOSDBDataSetBindingSource.Position = 0;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1BindingSource1
            // 
            this.dataSet1BindingSource1.DataSource = this.dataSet1;
            this.dataSet1BindingSource1.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "DATOS EMPLEADOS";
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataEmpleados);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOS_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataEmpleados;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private DataSet1TableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private EMPLEADOS_DBDataSet eMPLEADOS_DBDataSet;
        private System.Windows.Forms.BindingSource eMPLEADOSDBDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn casadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource empleadosBindingSource1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource1;
        private System.Windows.Forms.Label label1;
    }
}

