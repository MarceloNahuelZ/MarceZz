namespace ZabalettaMarcelotp6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            botonagregar = new Button();
            botoncancelar = new Button();
            listagenero = new ComboBox();
            checkBoxInternacional = new CheckBox();
            preciolibro = new TextBox();
            cantidadpaginas = new TextBox();
            nombreautor = new TextBox();
            nombrelibro = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            listadelibros = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(584, 431);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(576, 403);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ingreso";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(botonagregar);
            groupBox1.Controls.Add(botoncancelar);
            groupBox1.Controls.Add(listagenero);
            groupBox1.Controls.Add(checkBoxInternacional);
            groupBox1.Controls.Add(preciolibro);
            groupBox1.Controls.Add(cantidadpaginas);
            groupBox1.Controls.Add(nombreautor);
            groupBox1.Controls.Add(nombrelibro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(564, 391);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresar libro";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // botonagregar
            // 
            botonagregar.Location = new Point(225, 316);
            botonagregar.Name = "botonagregar";
            botonagregar.Size = new Size(75, 23);
            botonagregar.TabIndex = 13;
            botonagregar.Text = "Ingresar";
            botonagregar.UseVisualStyleBackColor = true;
            botonagregar.Click += botonagregar_Click;
            // 
            // botoncancelar
            // 
            botoncancelar.Location = new Point(102, 316);
            botoncancelar.Name = "botoncancelar";
            botoncancelar.Size = new Size(75, 23);
            botoncancelar.TabIndex = 12;
            botoncancelar.Text = "Cancelar";
            botoncancelar.UseVisualStyleBackColor = true;
            botoncancelar.Click += botoncancelar_Click;
            // 
            // listagenero
            // 
            listagenero.FormattingEnabled = true;
            listagenero.Items.AddRange(new object[] { "Novela", "Ciencia Ficcion", "Fantasia", "Misterio", "Policial" });
            listagenero.Location = new Point(168, 134);
            listagenero.Name = "listagenero";
            listagenero.Size = new Size(98, 23);
            listagenero.TabIndex = 11;
            // 
            // checkBoxInternacional
            // 
            checkBoxInternacional.AutoSize = true;
            checkBoxInternacional.Location = new Point(175, 221);
            checkBoxInternacional.Name = "checkBoxInternacional";
            checkBoxInternacional.Size = new Size(35, 19);
            checkBoxInternacional.TabIndex = 10;
            checkBoxInternacional.Text = "Si";
            checkBoxInternacional.UseVisualStyleBackColor = true;
            // 
            // preciolibro
            // 
            preciolibro.Location = new Point(166, 256);
            preciolibro.Name = "preciolibro";
            preciolibro.Size = new Size(100, 23);
            preciolibro.TabIndex = 9;
            // 
            // cantidadpaginas
            // 
            cantidadpaginas.Location = new Point(166, 182);
            cantidadpaginas.Name = "cantidadpaginas";
            cantidadpaginas.Size = new Size(100, 23);
            cantidadpaginas.TabIndex = 8;
            // 
            // nombreautor
            // 
            nombreautor.Location = new Point(166, 99);
            nombreautor.Name = "nombreautor";
            nombreautor.Size = new Size(100, 23);
            nombreautor.TabIndex = 7;
            // 
            // nombrelibro
            // 
            nombrelibro.Location = new Point(166, 69);
            nombrelibro.Name = "nombrelibro";
            nombrelibro.Size = new Size(100, 23);
            nombrelibro.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 185);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 5;
            label4.Text = "Páginas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 259);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 4;
            label5.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 220);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 3;
            label6.Text = "Importado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 135);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Género";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 104);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Autor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 72);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(listadelibros);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(576, 403);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lista";
            // 
            // listadelibros
            // 
            listadelibros.FormattingEnabled = true;
            listadelibros.ItemHeight = 15;
            listadelibros.Location = new Point(73, 53);
            listadelibros.Name = "listadelibros";
            listadelibros.Size = new Size(427, 289);
            listadelibros.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 455);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Gestion de libros";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private CheckBox checkBoxInternacional;
        private TextBox preciolibro;
        private TextBox cantidadpaginas;
        private TextBox nombreautor;
        private TextBox nombrelibro;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox listagenero;
        private Button botonagregar;
        private Button botoncancelar;
        private ListBox listadelibros;
    }
}