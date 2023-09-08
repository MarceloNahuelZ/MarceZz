namespace _1ZabalettaMarceloTP7
{
    partial class frmEmpleados
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
            this.btnguardar = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNyA = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabDatosGenerales = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.tabDatosGenerales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(644, 395);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(105, 32);
            this.btnguardar.TabIndex = 21;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.txtSalario);
            this.tabPage1.Controls.Add(this.txtEdad);
            this.tabPage1.Controls.Add(this.txtDni);
            this.tabPage1.Controls.Add(this.txtNyA);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(688, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Generales";
            
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(242, 219);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(280, 27);
            this.txtSalario.TabIndex = 20;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(243, 151);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(279, 27);
            this.txtEdad.TabIndex = 19;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(242, 114);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(280, 27);
            this.txtDni.TabIndex = 18;
            // 
            // txtNyA
            // 
            this.txtNyA.Location = new System.Drawing.Point(243, 78);
            this.txtNyA.Name = "txtNyA";
            this.txtNyA.Size = new System.Drawing.Size(279, 27);
            this.txtNyA.TabIndex = 17;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(296, 190);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 23);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "Soltero";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(205, 189);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 23);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Casado";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Salario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estado Civil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre Y Apellido";
            // 
            // tabDatosGenerales
            // 
            this.tabDatosGenerales.AllowDrop = true;
            this.tabDatosGenerales.Controls.Add(this.tabPage1);
            this.tabDatosGenerales.Location = new System.Drawing.Point(57, 26);
            this.tabDatosGenerales.Name = "tabDatosGenerales";
            this.tabDatosGenerales.RightToLeftLayout = true;
            this.tabDatosGenerales.SelectedIndex = 0;
            this.tabDatosGenerales.Size = new System.Drawing.Size(696, 346);
            this.tabDatosGenerales.TabIndex = 0;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.tabDatosGenerales);
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabDatosGenerales.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNyA;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabDatosGenerales;
    }
}