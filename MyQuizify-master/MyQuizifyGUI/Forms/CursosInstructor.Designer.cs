
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDefinicon = new System.Windows.Forms.TextBox();
            this.botonCrearCompetencia = new System.Windows.Forms.Button();
            this.textboxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaCheck});
            this.dataGridViewCursos.Location = new System.Drawing.Point(0, 135);
            this.dataGridViewCursos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.RowHeadersWidth = 51;
            this.dataGridViewCursos.Size = new System.Drawing.Size(1145, 419);
            this.dataGridViewCursos.TabIndex = 0;
            // 
            // ColumnaCheck
            // 
            this.ColumnaCheck.HeaderText = "Selecciona";
            this.ColumnaCheck.MinimumWidth = 6;
            this.ColumnaCheck.Name = "ColumnaCheck";
            this.ColumnaCheck.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 479);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 75);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(21, 135);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 75);
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
            this.panel1.Location = new System.Drawing.Point(1181, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 731);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Codigo";
            // 
            // textBoxDefinicon
            // 
            this.textBoxDefinicon.Location = new System.Drawing.Point(649, 83);
            this.textBoxDefinicon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDefinicon.Multiline = true;
            this.textBoxDefinicon.Name = "textBoxDefinicon";
            this.textBoxDefinicon.Size = new System.Drawing.Size(245, 30);
            this.textBoxDefinicon.TabIndex = 9;
            // 
            // botonCrearCompetencia
            // 
            this.botonCrearCompetencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCrearCompetencia.Location = new System.Drawing.Point(918, 74);
            this.botonCrearCompetencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonCrearCompetencia.Name = "botonCrearCompetencia";
            this.botonCrearCompetencia.Size = new System.Drawing.Size(79, 49);
            this.botonCrearCompetencia.TabIndex = 8;
            this.botonCrearCompetencia.Text = "Crear";
            this.botonCrearCompetencia.UseVisualStyleBackColor = true;
            this.botonCrearCompetencia.Click += new System.EventHandler(this.botonCrearCompetencia_Click);
            // 
            // textboxID
            // 
            this.textboxID.Location = new System.Drawing.Point(277, 87);
            this.textboxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(245, 22);
            this.textboxID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona las asignaturas que impartes :";
            // 
            // CursosInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 731);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.botonCrearCompetencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDefinicon);
            this.Controls.Add(this.dataGridViewCursos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDefinicon;
        private System.Windows.Forms.Button botonCrearCompetencia;
        private System.Windows.Forms.TextBox textboxID;
        private System.Windows.Forms.Label label1;
    }
}