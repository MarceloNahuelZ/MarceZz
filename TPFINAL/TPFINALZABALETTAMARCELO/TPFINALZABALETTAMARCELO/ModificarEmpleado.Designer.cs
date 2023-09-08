namespace TPFINALZABALETTAMARCELO
{
    partial class ModificarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarEmpleado));
            this.comboCasado = new System.Windows.Forms.ComboBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.Salario = new System.Windows.Forms.Label();
            this.Casado = new System.Windows.Forms.Label();
            this.Edad = new System.Windows.Forms.Label();
            this.DNI = new System.Windows.Forms.Label();
            this.NyA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboCasado
            // 
            this.comboCasado.FormattingEnabled = true;
            this.comboCasado.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.comboCasado.Location = new System.Drawing.Point(155, 167);
            this.comboCasado.Name = "comboCasado";
            this.comboCasado.Size = new System.Drawing.Size(215, 21);
            this.comboCasado.TabIndex = 4;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(155, 205);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(215, 20);
            this.txtSalario.TabIndex = 5;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(154, 132);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(215, 20);
            this.txtEdad.TabIndex = 3;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(154, 95);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(215, 20);
            this.txtDNI.TabIndex = 2;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(155, 56);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(215, 20);
            this.txtNombreCompleto.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(154, 263);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 58);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(295, 263);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 58);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // Salario
            // 
            this.Salario.AutoSize = true;
            this.Salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salario.Location = new System.Drawing.Point(96, 209);
            this.Salario.Name = "Salario";
            this.Salario.Size = new System.Drawing.Size(53, 16);
            this.Salario.TabIndex = 14;
            this.Salario.Text = "Salario:";
            // 
            // Casado
            // 
            this.Casado.AutoSize = true;
            this.Casado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Casado.Location = new System.Drawing.Point(90, 173);
            this.Casado.Name = "Casado";
            this.Casado.Size = new System.Drawing.Size(58, 16);
            this.Casado.TabIndex = 13;
            this.Casado.Text = "Casado:";
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edad.Location = new System.Drawing.Point(105, 133);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(43, 16);
            this.Edad.TabIndex = 12;
            this.Edad.Text = "Edad:";
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNI.Location = new System.Drawing.Point(115, 95);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(33, 16);
            this.DNI.TabIndex = 11;
            this.DNI.Text = "DNI:";
            // 
            // NyA
            // 
            this.NyA.AutoSize = true;
            this.NyA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NyA.Location = new System.Drawing.Point(28, 56);
            this.NyA.Name = "NyA";
            this.NyA.Size = new System.Drawing.Size(120, 16);
            this.NyA.TabIndex = 10;
            this.NyA.Text = "Nombre Completo:";
            // 
            // ModificarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 369);
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
            this.Name = "ModificarEmpleado";
            this.Text = "ModificarEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCasado;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label Salario;
        private System.Windows.Forms.Label Casado;
        private System.Windows.Forms.Label Edad;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Label NyA;
    }
}