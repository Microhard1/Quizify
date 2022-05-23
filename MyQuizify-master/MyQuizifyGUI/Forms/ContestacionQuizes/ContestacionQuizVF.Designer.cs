
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
            this.groupBox1.Location = new System.Drawing.Point(122, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 141);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // botonVerdadero
            // 
            this.botonVerdadero.AutoSize = true;
            this.botonVerdadero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.botonVerdadero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVerdadero.Location = new System.Drawing.Point(36, 66);
            this.botonVerdadero.Name = "botonVerdadero";
            this.botonVerdadero.Size = new System.Drawing.Size(156, 28);
            this.botonVerdadero.TabIndex = 2;
            this.botonVerdadero.Text = "VERDADERO";
            this.botonVerdadero.UseVisualStyleBackColor = false;
            // 
            // botonFalso
            // 
            this.botonFalso.AutoSize = true;
            this.botonFalso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.botonFalso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonFalso.Location = new System.Drawing.Point(310, 66);
            this.botonFalso.Name = "botonFalso";
            this.botonFalso.Size = new System.Drawing.Size(95, 28);
            this.botonFalso.TabIndex = 2;
            this.botonFalso.Text = "FALSO";
            this.botonFalso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.botonFalso.UseVisualStyleBackColor = false;
            // 
            // panelVerdadero
            // 
            this.panelVerdadero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelVerdadero.Location = new System.Drawing.Point(18, 32);
            this.panelVerdadero.Name = "panelVerdadero";
            this.panelVerdadero.Size = new System.Drawing.Size(263, 90);
            this.panelVerdadero.TabIndex = 6;
            // 
            // panelFalso
            // 
            this.panelFalso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelFalso.Location = new System.Drawing.Point(287, 32);
            this.panelFalso.Name = "panelFalso";
            this.panelFalso.Size = new System.Drawing.Size(261, 90);
            this.panelFalso.TabIndex = 7;
            // 
            // inputImagen
            // 
            this.inputImagen.Location = new System.Drawing.Point(250, 146);
            this.inputImagen.Name = "inputImagen";
            this.inputImagen.Size = new System.Drawing.Size(320, 218);
            this.inputImagen.TabIndex = 13;
            this.inputImagen.TabStop = false;
            // 
            // Enunciado
            // 
            this.Enunciado.AutoSize = true;
            this.Enunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enunciado.Location = new System.Drawing.Point(44, 93);
            this.Enunciado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Enunciado.Name = "Enunciado";
            this.Enunciado.Size = new System.Drawing.Size(102, 24);
            this.Enunciado.TabIndex = 16;
            this.Enunciado.Text = "Enunciado";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.labelTiempo);
            this.panel1.Controls.Add(this.botonPausa);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 89);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempo.Location = new System.Drawing.Point(762, 27);
            this.labelTiempo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(88, 18);
            this.labelTiempo.TabIndex = 20;
            this.labelTiempo.Text = "labelTiempo";
            // 
            // botonPausa
            // 
            this.botonPausa.Location = new System.Drawing.Point(774, 57);
            this.botonPausa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonPausa.Name = "botonPausa";
            this.botonPausa.Size = new System.Drawing.Size(65, 30);
            this.botonPausa.TabIndex = 19;
            this.botonPausa.Text = "Pausar";
            this.botonPausa.UseVisualStyleBackColor = true;
            this.botonPausa.Click += new System.EventHandler(this.botonPausa_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(122, 28);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(620, 19);
            this.progressBar1.TabIndex = 0;
            // 
            // botonSiguiente
            // 
            this.botonSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSiguiente.Location = new System.Drawing.Point(297, 537);
            this.botonSiguiente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(230, 54);
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
            this.Peso.Location = new System.Drawing.Point(771, 97);
            this.Peso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(46, 18);
            this.Peso.TabIndex = 21;
            this.Peso.Text = "label1";
            // 
            // botonAyuda
            // 
            this.botonAyuda.Location = new System.Drawing.Point(765, 552);
            this.botonAyuda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonAyuda.Name = "botonAyuda";
            this.botonAyuda.Size = new System.Drawing.Size(65, 30);
            this.botonAyuda.TabIndex = 22;
            this.botonAyuda.Text = "Ayuda";
            this.botonAyuda.UseVisualStyleBackColor = true;
            this.botonAyuda.Click += new System.EventHandler(this.botonAyuda_Click);
            // 
            // ContestacionQuizVF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 609);
            this.Controls.Add(this.botonAyuda);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.botonSiguiente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Enunciado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inputImagen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ContestacionQuizVF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContestacionQuizVF";
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