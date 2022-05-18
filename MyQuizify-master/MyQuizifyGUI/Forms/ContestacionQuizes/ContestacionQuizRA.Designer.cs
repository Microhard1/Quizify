
namespace MyQuizifyGUI.Forms.ContestacionQuizes
{
    partial class ContestacionQuizRA
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
            this.textBoxResp = new System.Windows.Forms.TextBox();
            this.inputImagen = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.botonPausa = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Enunciado = new System.Windows.Forms.Label();
            this.botonSiguiente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TiempoQuiz = new System.Windows.Forms.Timer(this.components);
            this.Peso = new System.Windows.Forms.Label();
            this.botonAyuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputImagen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxResp
            // 
            this.textBoxResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResp.ForeColor = System.Drawing.Color.Black;
            this.textBoxResp.Location = new System.Drawing.Point(98, 233);
            this.textBoxResp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResp.Multiline = true;
            this.textBoxResp.Name = "textBoxResp";
            this.textBoxResp.Size = new System.Drawing.Size(444, 413);
            this.textBoxResp.TabIndex = 23;
            this.textBoxResp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputImagen
            // 
            this.inputImagen.Location = new System.Drawing.Point(621, 233);
            this.inputImagen.Margin = new System.Windows.Forms.Padding(4);
            this.inputImagen.Name = "inputImagen";
            this.inputImagen.Size = new System.Drawing.Size(378, 413);
            this.inputImagen.TabIndex = 21;
            this.inputImagen.TabStop = false;
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
            this.panel1.Size = new System.Drawing.Size(1138, 110);
            this.panel1.TabIndex = 25;
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
            // Enunciado
            // 
            this.Enunciado.AutoSize = true;
            this.Enunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enunciado.Location = new System.Drawing.Point(94, 126);
            this.Enunciado.Name = "Enunciado";
            this.Enunciado.Size = new System.Drawing.Size(127, 29);
            this.Enunciado.TabIndex = 26;
            this.Enunciado.Text = "Enunciado";
            this.Enunciado.Click += new System.EventHandler(this.Enunciado_Click);
            // 
            // botonSiguiente
            // 
            this.botonSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSiguiente.Location = new System.Drawing.Point(407, 660);
            this.botonSiguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(307, 66);
            this.botonSiguiente.TabIndex = 27;
            this.botonSiguiente.Text = "Siguiente";
            this.botonSiguiente.UseVisualStyleBackColor = true;
            this.botonSiguiente.Click += new System.EventHandler(this.botonSiguiente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Escriba la respuesta:";
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
            this.Peso.Location = new System.Drawing.Point(1028, 131);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(60, 24);
            this.Peso.TabIndex = 28;
            this.Peso.Text = "label1";
            // 
            // botonAyuda
            // 
            this.botonAyuda.Location = new System.Drawing.Point(1032, 679);
            this.botonAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonAyuda.Name = "botonAyuda";
            this.botonAyuda.Size = new System.Drawing.Size(87, 37);
            this.botonAyuda.TabIndex = 29;
            this.botonAyuda.Text = "Ayuda";
            this.botonAyuda.UseVisualStyleBackColor = true;
            this.botonAyuda.Click += new System.EventHandler(this.botonAyuda_Click);
            // 
            // ContestacionQuizRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 759);
            this.Controls.Add(this.botonAyuda);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.botonSiguiente);
            this.Controls.Add(this.Enunciado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResp);
            this.Controls.Add(this.inputImagen);
            this.Name = "ContestacionQuizRA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContestacionQuizRA";
            this.Load += new System.EventHandler(this.ContestacionQuizRA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputImagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxResp;
        private System.Windows.Forms.PictureBox inputImagen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Button botonPausa;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Enunciado;
        private System.Windows.Forms.Button botonSiguiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TiempoQuiz;
        private System.Windows.Forms.Label Peso;
        private System.Windows.Forms.Button botonAyuda;
    }
}