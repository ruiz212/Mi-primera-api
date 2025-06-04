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
            ((System.ComponentModel.ISupportInitialize)dgvEstudiante).BeginInit();
            SuspendLayout();
            // 
            // dgvEstudiante
            // 
            dgvEstudiante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiante.Location = new Point(12, 88);
            dgvEstudiante.Name = "dgvEstudiante";
            dgvEstudiante.RowHeadersWidth = 51;
            dgvEstudiante.Size = new Size(776, 276);
            dgvEstudiante.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvEstudiante);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEstudiante).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEstudiante;
    }
}
