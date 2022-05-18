
namespace MyQuizifyGUI
{
    partial class QuizesActivos
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
            this.dataGridQuizes = new System.Windows.Forms.DataGridView();
            this.Selecciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxEstados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuizes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridQuizes
            // 
            this.dataGridQuizes.AccessibleName = "DataGridQuizesActivos";
            this.dataGridQuizes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuizes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecciona});
            this.dataGridQuizes.Location = new System.Drawing.Point(36, 138);
            this.dataGridQuizes.Name = "dataGridQuizes";
            this.dataGridQuizes.RowHeadersWidth = 51;
            this.dataGridQuizes.Size = new System.Drawing.Size(841, 316);
            this.dataGridQuizes.TabIndex = 0;
            this.dataGridQuizes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridQuizes_CellContentClick);
            // 
            // Selecciona
            // 
            this.Selecciona.HeaderText = "Selecciona";
            this.Selecciona.MinimumWidth = 6;
            this.Selecciona.Name = "Selecciona";
            this.Selecciona.Width = 125;
            // 
            // label1
            // 
            this.label1.AccessibleName = "labelQuizesActivos";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quizes activos";
            // 
            // button1
            // 
            this.button1.AccessibleName = "botonCrearQuiz";
            this.button1.Location = new System.Drawing.Point(36, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Crear Quiz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxEstados
            // 
            this.comboBoxEstados.FormattingEnabled = true;
            this.comboBoxEstados.Items.AddRange(new object[] {
            "Borrador",
            "Publicado",
            "Cancelado",
            "Corregido",
            "Terminado"});
            this.comboBoxEstados.Location = new System.Drawing.Point(756, 82);
            this.comboBoxEstados.Name = "comboBoxEstados";
            this.comboBoxEstados.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstados.TabIndex = 9;
            this.comboBoxEstados.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstados_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filtrar por:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(917, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 48);
            this.button2.TabIndex = 12;
            this.button2.Text = "Generar informe de calificaciones";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AccessibleName = "botonCrearQuiz";
            this.button3.Location = new System.Drawing.Point(136, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 48);
            this.button3.TabIndex = 13;
            this.button3.Text = "Clonar Quizes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AccessibleName = "botonCrearQuiz";
            this.button4.Location = new System.Drawing.Point(236, 479);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 48);
            this.button4.TabIndex = 14;
            this.button4.Text = "Estadisticas";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(917, 351);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 48);
            this.button5.TabIndex = 15;
            this.button5.Text = "Borrar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(917, 138);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Publicar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(917, 177);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "Cancelar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(917, 217);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "Publicar resultados";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(336, 479);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(140, 48);
            this.button9.TabIndex = 19;
            this.button9.Text = "Editar preguntas";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(482, 479);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(107, 48);
            this.button10.TabIndex = 20;
            this.button10.Text = "Asignar Competencias";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // QuizesActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 539);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEstados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridQuizes);
            this.Name = "QuizesActivos";
            this.Text = "InicioInstructor";
            this.Load += new System.EventHandler(this.InicioInstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuizes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridQuizes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecciona;
        private System.Windows.Forms.ComboBox comboBoxEstados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}