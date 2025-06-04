namespace EstuidiantConApi
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
            dgvEstudiante = new DataGridView();
            lblnombre = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtEdad = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            btnAgregar = new Button();
            Actualizar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiante).BeginInit();
            SuspendLayout();
            // 
            // dgvEstudiante
            // 
            dgvEstudiante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiante.Location = new Point(416, 6);
            dgvEstudiante.Name = "dgvEstudiante";
            dgvEstudiante.RowHeadersWidth = 51;
            dgvEstudiante.Size = new Size(372, 432);
            dgvEstudiante.TabIndex = 0;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(48, 39);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(64, 20);
            lblnombre.TabIndex = 1;
            lblnombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(120, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 119);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(120, 123);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 184);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 1;
            label3.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(120, 181);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(125, 27);
            txtEdad.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 246);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 1;
            label4.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 239);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(18, 315);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Actualizar
            // 
            Actualizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Actualizar.Location = new Point(140, 315);
            Actualizar.Name = "Actualizar";
            Actualizar.Size = new Size(94, 29);
            Actualizar.TabIndex = 3;
            Actualizar.Text = "Actulizar";
            Actualizar.UseVisualStyleBackColor = true;
            Actualizar.Click += Actualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(265, 315);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(Actualizar);
            Controls.Add(btnAgregar);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(lblnombre);
            Controls.Add(dgvEstudiante);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEstudiante).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEstudiante;
        private Label lblnombre;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtEdad;
        private Label label4;
        private TextBox txtEmail;
        private Button btnAgregar;
        private Button Actualizar;
        private Button btnEliminar;
    }
}
