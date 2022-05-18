
namespace MyQuizifyGUI.Forms.ContestacionQuizes
{
    partial class ContestacionQuizVF
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonVerdadero = new System.Windows.Forms.RadioButton();
            this.botonFalso = new System.Windows.Forms.RadioButton();
            this.panelVerdadero = new System.Windows.Forms.Panel();
            this.panelFalso = new System.Windows.Forms.Panel();
            this.inputImagen = new System.Windows.Forms.PictureBox();
            this.Enunciado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.botonPausa = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.botonSiguiente = new System.Windows.Forms.Button();
            this.TiempoQuiz = new System.Windows.Forms.Timer(this.components);
            this.Peso = new System.Windows.Forms.Label();
            this.botonAyuda = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputImagen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botonVerdadero);
            this.groupBox1.Controls.Add(this.botonFalso);
            this.groupBox1.Controls.Add(this.panelVerdadero);
            this.groupBox1.Controls.Add(this.panelFalso);
            this.groupBox1.Location = new System.Drawing.Point(163, 455);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(739, 174);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // botonVerdadero
            // 
            this.botonVerdadero.AutoSize = true;
            this.botonVerdadero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.botonVerdadero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVerdadero.Location = new System.Drawing.Point(48, 81);
            this.botonVerdadero.Margin = new System.Windows.Forms.Padding(4);
            this.botonVerdadero.Name = "botonVerdadero";
            this.botonVerdadero.Size = new System.Drawing.Size(192, 33);
            this.botonVerdadero.TabIndex = 2;
            this.botonVerdadero.Text = "VERDADERO";
            this.botonVerdadero.UseVisualStyleBackColor = false;
            // 
            // botonFalso
            // 
            this.botonFalso.AutoSize = true;
            this.botonFalso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.botonFalso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonFalso.Location = new System.Drawing.Point(413, 81);
            this.botonFalso.Margin = new System.Windows.Forms.Padding(4);
            this.botonFalso.Name = "botonFalso";
            this.botonFalso.Size = new System.Drawing.Size(117, 33);
            this.botonFalso.TabIndex = 2;
            this.botonFalso.Text = "FALSO";
            this.botonFalso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.botonFalso.UseVisualStyleBackColor = false;
            // 
            // panelVerdadero
            // 
            this.panelVerdadero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelVerdadero.Location = new System.Drawing.Point(24, 39);
            this.panelVerdadero.Margin = new System.Windows.Forms.Padding(4);
            this.panelVerdadero.Name = "panelVerdadero";
            this.panelVerdadero.Size = new System.Drawing.Size(351, 111);
            this.panelVerdadero.TabIndex = 6;
            // 
            // panelFalso
            // 
            this.panelFalso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelFalso.Location = new System.Drawing.Point(383, 39);
            this.panelFalso.Margin = new System.Windows.Forms.Padding(4);
            this.panelFalso.Name = "panelFalso";
            this.panelFalso.Size = new System.Drawing.Size(348, 111);
            this.panelFalso.TabIndex = 7;
            // 
            // inputImagen
            // 
            this.inputImagen.Location = new System.Drawing.Point(333, 180);
            this.inputImagen.Margin = new System.Windows.Forms.Padding(4);
            this.inputImagen.Name = "inputImagen";
            this.inputImagen.Size = new System.Drawing.Size(427, 268);
            this.inputImagen.TabIndex = 13;
            this.inputImagen.TabStop = false;
            this.inputImagen.Click += new System.EventHandler(this.inputImagen_Click);
            // 
            // Enunciado
            // 
            this.Enunciado.AutoSize = true;
            this.Enunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enunciado.Location = new System.Drawing.Point(59, 114);
            this.Enunciado.Name = "Enunciado";
            this.Enunciado.Size = new System.Drawing.Size(127, 29);
            this.Enunciado.TabIndex = 16;
            this.Enunciado.Text = "Enunciado";
            this.Enunciado.Click += new System.EventHandler(this.Enunciado_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.labelTiempo);
            this.panel1.Controls.Add(this.botonPausa);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 110);
            this.panel1.TabIndex = 17;
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempo.Location = new System.Drawing.Point(1016, 33);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(115, 24);
            this.labelTiempo.TabIndex = 20;
            this.labelTiempo.Text = "labelTiempo";
            this.labelTiempo.Click += new System.EventHandler(this.label1_Click);
            // 
            // botonPausa
            // 
            this.botonPausa.Location = new System.Drawing.Point(1032, 70);
            this.botonPausa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonPausa.Name = "botonPausa";
            this.botonPausa.Size = new System.Drawing.Size(87, 37);
            this.botonPausa.TabIndex = 19;
            this.botonPausa.Text = "Pausar";
            this.botonPausa.UseVisualStyleBackColor = true;
            this.botonPausa.Click += new System.EventHandler(this.botonPausa_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(163, 34);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(827, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // botonSiguiente
            // 
            this.botonSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSiguiente.Location = new System.Drawing.Point(396, 661);
            this.botonSiguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(307, 66);
            this.botonSiguiente.TabIndex = 18;
            this.botonSiguiente.Text = "Siguiente";
            this.botonSiguiente.UseVisualStyleBackColor = true;
            this.botonSiguiente.Click += new System.EventHandler(this.button1_Click);
            // 
            // TiempoQuiz
            // 
            this.TiempoQuiz.Enabled = true;
            this.TiempoQuiz.Interval = 1000;
            this.TiempoQuiz.Tick += new System.EventHandler(this.TiempoQuiz_Tick);
            // 
            // Peso
            // 
            this.Peso.AutoSize = true;
            this.Peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Peso.Location = new System.Drawing.Point(1028, 119);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(60, 24);
            this.Peso.TabIndex = 21;
            this.Peso.Text = "label1";
            // 
            // botonAyuda
            // 
            this.botonAyuda.Location = new System.Drawing.Point(1020, 680);
            this.botonAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonAyuda.Name = "botonAyuda";
            this.botonAyuda.Size = new System.Drawing.Size(87, 37);
            this.botonAyuda.TabIndex = 22;
            this.botonAyuda.Text = "Ayuda";
            this.botonAyuda.UseVisualStyleBackColor = true;
            this.botonAyuda.Click += new System.EventHandler(this.botonAyuda_Click);
            // 
            // ContestacionQuizVF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 758);
            this.Controls.Add(this.botonAyuda);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.botonSiguiente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Enunciado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inputImagen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ContestacionQuizVF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContestacionQuizVF";
            this.Load += new System.EventHandler(this.ContestacionQuizVF_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputImagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton botonVerdadero;
        private System.Windows.Forms.RadioButton botonFalso;
        private System.Windows.Forms.Panel panelVerdadero;
        private System.Windows.Forms.Panel panelFalso;
        private System.Windows.Forms.PictureBox inputImagen;
        private System.Windows.Forms.Label Enunciado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button botonPausa;
        private System.Windows.Forms.Button botonSiguiente;
        private System.Windows.Forms.Timer TiempoQuiz;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Label Peso;
        private System.Windows.Forms.Button botonAyuda;
    }
}