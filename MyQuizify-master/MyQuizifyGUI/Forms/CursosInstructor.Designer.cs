
namespace MyQuizifyGUI.Forms
{
    partial class CursosInstructor
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaCheck});
            this.dataGridViewCursos.Location = new System.Drawing.Point(0, 36);
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.RowHeadersWidth = 51;
            this.dataGridViewCursos.Size = new System.Drawing.Size(800, 414);
            this.dataGridViewCursos.TabIndex = 0;
            // 
            // ColumnaCheck
            // 
            this.ColumnaCheck.HeaderText = "Selecciona";
            this.ColumnaCheck.MinimumWidth = 6;
            this.ColumnaCheck.Name = "ColumnaCheck";
            this.ColumnaCheck.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona las asignaturas que impartes :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 61);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cargar cursos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(886, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 594);
            this.panel1.TabIndex = 4;
            // 
            // CursosInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CursosInstructor";
            this.Text = "CursosInstructor";
            this.Load += new System.EventHandler(this.PantallaPrincipalInstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCursos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnaCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}