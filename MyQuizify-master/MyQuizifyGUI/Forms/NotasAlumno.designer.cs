namespace MyQuizifyGUI.Forms
{
    partial class NotasAlumno
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridNotasAlumno = new System.Windows.Forms.DataGridView();
            this.btbVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotasAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridNotasAlumno
            // 
            this.dataGridNotasAlumno.AccessibleName = "DataGridNotasAlumno";
            this.dataGridNotasAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNotasAlumno.Location = new System.Drawing.Point(15, 96);
            this.dataGridNotasAlumno.Name = "dataGridNotasAlumno";
            this.dataGridNotasAlumno.RowHeadersWidth = 51;
            this.dataGridNotasAlumno.Size = new System.Drawing.Size(688, 316);
            this.dataGridNotasAlumno.TabIndex = 15;
            // 
            // btbVolver
            // 
            this.btbVolver.AccessibleName = "botonVolver";
            this.btbVolver.Location = new System.Drawing.Point(15, 461);
            this.btbVolver.Name = "btbVolver";
            this.btbVolver.Size = new System.Drawing.Size(94, 48);
            this.btbVolver.TabIndex = 16;
            this.btbVolver.Text = "Volver";
            this.btbVolver.UseVisualStyleBackColor = true;
            this.btbVolver.Click += new System.EventHandler(this.btbVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tus notas";
            // 
            // NotasAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btbVolver);
            this.Controls.Add(this.dataGridNotasAlumno);
            this.Name = "NotasAlumno";
            this.Size = new System.Drawing.Size(817, 539);
            this.Load += new System.EventHandler(this.NotasAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotasAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridNotasAlumno;
        private System.Windows.Forms.Button btbVolver;
        private System.Windows.Forms.Label label1;
    }
}
