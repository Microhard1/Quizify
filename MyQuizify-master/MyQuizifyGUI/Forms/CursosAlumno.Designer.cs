
namespace MyQuizifyGUI.Forms
{
    partial class CursosAlumno
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
            this.dataGridViewCursos = new System.Windows.Forms.DataGridView();
            this.ColumnaCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaCheck});
            this.dataGridViewCursos.Location = new System.Drawing.Point(81, 38);
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.RowHeadersWidth = 51;
            this.dataGridViewCursos.Size = new System.Drawing.Size(859, 418);
            this.dataGridViewCursos.TabIndex = 12;
            // 
            // ColumnaCheck
            // 
            this.ColumnaCheck.HeaderText = "Selecciona";
            this.ColumnaCheck.MinimumWidth = 6;
            this.ColumnaCheck.Name = "ColumnaCheck";
            this.ColumnaCheck.Width = 125;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(428, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 61);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cargar cursos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CursosAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewCursos);
            this.Name = "CursosAlumno";
            this.Text = "CursosAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewCursos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnaCheck;
        private System.Windows.Forms.Button button2;
    }
}