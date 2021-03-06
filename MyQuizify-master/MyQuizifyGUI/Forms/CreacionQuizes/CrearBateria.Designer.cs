
namespace MyQuizifyGUI.Forms
{
    partial class CrearBateria
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
            this.dataGridPreguntas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombreBateria = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enunciado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntuacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Explicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPreguntas
            // 
            this.dataGridPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPreguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.nombre,
            this.Enunciado,
            this.Puntuacion,
            this.Explicacion});
            this.dataGridPreguntas.Location = new System.Drawing.Point(45, 84);
            this.dataGridPreguntas.Name = "dataGridPreguntas";
            this.dataGridPreguntas.Size = new System.Drawing.Size(561, 320);
            this.dataGridPreguntas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona las preguntas de la bateria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de la bateria:";
            // 
            // textBoxNombreBateria
            // 
            this.textBoxNombreBateria.Location = new System.Drawing.Point(642, 158);
            this.textBoxNombreBateria.Name = "textBoxNombreBateria";
            this.textBoxNombreBateria.Size = new System.Drawing.Size(126, 20);
            this.textBoxNombreBateria.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Crear Bateria";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MultiOpcion",
            "Abierta",
            "Verdadero/Falso"});
            this.comboBox1.Location = new System.Drawing.Point(642, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de Bateria: ";
            // 
            // check
            // 
            this.check.HeaderText = "Selecciona";
            this.check.Name = "check";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "ID";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // Enunciado
            // 
            this.Enunciado.HeaderText = "Enunciado";
            this.Enunciado.Name = "Enunciado";
            this.Enunciado.ReadOnly = true;
            // 
            // Puntuacion
            // 
            this.Puntuacion.HeaderText = "Puntuacion";
            this.Puntuacion.Name = "Puntuacion";
            this.Puntuacion.ReadOnly = true;
            // 
            // Explicacion
            // 
            this.Explicacion.HeaderText = "Explicacion";
            this.Explicacion.Name = "Explicacion";
            this.Explicacion.ReadOnly = true;
            // 
            // CrearBateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNombreBateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridPreguntas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearBateria";
            this.Text = "CrearPregunta";
            this.Load += new System.EventHandler(this.CrearPregunta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPreguntas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPreguntas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombreBateria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enunciado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntuacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Explicacion;
    }
}