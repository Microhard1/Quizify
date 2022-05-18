
namespace MyQuizifyGUI.Forms
{
    partial class ContestacionQuizesVF
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botonVerdadero = new System.Windows.Forms.RadioButton();
            this.botonFalso = new System.Windows.Forms.RadioButton();
            this.panelVerdadero = new System.Windows.Forms.Panel();
            this.panelFalso = new System.Windows.Forms.Panel();
            this.imagenPregunta = new System.Windows.Forms.PictureBox();
            this.botonAnterior = new System.Windows.Forms.Button();
            this.botonSiguiente = new System.Windows.Forms.Button();
            this.labelEnunciado = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPregunta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botonVerdadero);
            this.groupBox2.Controls.Add(this.botonFalso);
            this.groupBox2.Controls.Add(this.panelVerdadero);
            this.groupBox2.Controls.Add(this.panelFalso);
            this.groupBox2.Location = new System.Drawing.Point(243, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 141);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
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
            // imagenPregunta
            // 
            this.imagenPregunta.Location = new System.Drawing.Point(297, 94);
            this.imagenPregunta.Name = "imagenPregunta";
            this.imagenPregunta.Size = new System.Drawing.Size(452, 271);
            this.imagenPregunta.TabIndex = 19;
            this.imagenPregunta.TabStop = false;
            // 
            // botonAnterior
            // 
            this.botonAnterior.Location = new System.Drawing.Point(243, 593);
            this.botonAnterior.Name = "botonAnterior";
            this.botonAnterior.Size = new System.Drawing.Size(75, 23);
            this.botonAnterior.TabIndex = 18;
            this.botonAnterior.Text = "Anterior";
            this.botonAnterior.UseVisualStyleBackColor = true;
            // 
            // botonSiguiente
            // 
            this.botonSiguiente.Location = new System.Drawing.Point(722, 593);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(75, 23);
            this.botonSiguiente.TabIndex = 17;
            this.botonSiguiente.Text = "Siguiente";
            this.botonSiguiente.UseVisualStyleBackColor = true;
            this.botonSiguiente.Click += new System.EventHandler(this.botonSiguiente_Click);
            // 
            // labelEnunciado
            // 
            this.labelEnunciado.AutoSize = true;
            this.labelEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnunciado.Location = new System.Drawing.Point(419, 30);
            this.labelEnunciado.Name = "labelEnunciado";
            this.labelEnunciado.Size = new System.Drawing.Size(189, 33);
            this.labelEnunciado.TabIndex = 16;
            this.labelEnunciado.Text = "ENUNCIADO";
            // 
            // ContestacionQuizesVF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 786);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.imagenPregunta);
            this.Controls.Add(this.botonAnterior);
            this.Controls.Add(this.botonSiguiente);
            this.Controls.Add(this.labelEnunciado);
            this.Name = "ContestacionQuizesVF";
            this.Text = "ContestacionQuizesVF";
            this.Load += new System.EventHandler(this.ContestacionQuizesVF_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPregunta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton botonVerdadero;
        private System.Windows.Forms.RadioButton botonFalso;
        private System.Windows.Forms.Panel panelVerdadero;
        private System.Windows.Forms.Panel panelFalso;
        private System.Windows.Forms.PictureBox imagenPregunta;
        private System.Windows.Forms.Button botonAnterior;
        private System.Windows.Forms.Button botonSiguiente;
        private System.Windows.Forms.Label labelEnunciado;
    }
}