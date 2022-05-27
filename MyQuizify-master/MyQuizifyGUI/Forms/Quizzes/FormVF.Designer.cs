
namespace MyQuizifyGUI.Forms
{
    partial class FormVF
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
            this.textBoxEnunciado = new System.Windows.Forms.TextBox();
            this.inputImagen = new System.Windows.Forms.PictureBox();
            this.botonAñadirImagen = new System.Windows.Forms.Button();
            this.botonVerdadero = new System.Windows.Forms.RadioButton();
            this.panelVerdadero = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.botonFalso = new System.Windows.Forms.RadioButton();
            this.panelFalso = new System.Windows.Forms.Panel();
            this.textboxExplicacion = new System.Windows.Forms.TextBox();
            this.textBoxPuntuacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.inputImagen)).BeginInit();
            this.panelVerdadero.SuspendLayout();
            this.panelFalso.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEnunciado
            // 
            this.textBoxEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnunciado.ForeColor = System.Drawing.Color.Black;
            this.textBoxEnunciado.Location = new System.Drawing.Point(56, 39);
            this.textBoxEnunciado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEnunciado.Multiline = true;
            this.textBoxEnunciado.Name = "textBoxEnunciado";
            this.textBoxEnunciado.Size = new System.Drawing.Size(737, 100);
            this.textBoxEnunciado.TabIndex = 1;
            this.textBoxEnunciado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputImagen
            // 
            this.inputImagen.Location = new System.Drawing.Point(487, 193);
            this.inputImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputImagen.Name = "inputImagen";
            this.inputImagen.Size = new System.Drawing.Size(308, 357);
            this.inputImagen.TabIndex = 5;
            this.inputImagen.TabStop = false;
            // 
            // botonAñadirImagen
            // 
            this.botonAñadirImagen.Location = new System.Drawing.Point(556, 558);
            this.botonAñadirImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonAñadirImagen.Name = "botonAñadirImagen";
            this.botonAñadirImagen.Size = new System.Drawing.Size(192, 58);
            this.botonAñadirImagen.TabIndex = 8;
            this.botonAñadirImagen.Text = "Añadir imagen";
            this.botonAñadirImagen.UseVisualStyleBackColor = true;
            this.botonAñadirImagen.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonVerdadero
            // 
            this.botonVerdadero.AutoSize = true;
            this.botonVerdadero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.botonVerdadero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVerdadero.Location = new System.Drawing.Point(68, 55);
            this.botonVerdadero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonVerdadero.Name = "botonVerdadero";
            this.botonVerdadero.Size = new System.Drawing.Size(192, 33);
            this.botonVerdadero.TabIndex = 2;
            this.botonVerdadero.Text = "VERDADERO";
            this.botonVerdadero.UseVisualStyleBackColor = false;
            this.botonVerdadero.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panelVerdadero
            // 
            this.panelVerdadero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelVerdadero.Controls.Add(this.botonVerdadero);
            this.panelVerdadero.Location = new System.Drawing.Point(59, 407);
            this.panelVerdadero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelVerdadero.Name = "panelVerdadero";
            this.panelVerdadero.Size = new System.Drawing.Size(351, 143);
            this.panelVerdadero.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Escriba el enunciado :";
            // 
            // botonFalso
            // 
            this.botonFalso.AutoSize = true;
            this.botonFalso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.botonFalso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonFalso.Location = new System.Drawing.Point(107, 55);
            this.botonFalso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonFalso.Name = "botonFalso";
            this.botonFalso.Size = new System.Drawing.Size(117, 33);
            this.botonFalso.TabIndex = 2;
            this.botonFalso.Text = "FALSO";
            this.botonFalso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.botonFalso.UseVisualStyleBackColor = false;
            this.botonFalso.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panelFalso
            // 
            this.panelFalso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelFalso.Controls.Add(this.botonFalso);
            this.panelFalso.Location = new System.Drawing.Point(59, 193);
            this.panelFalso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFalso.Name = "panelFalso";
            this.panelFalso.Size = new System.Drawing.Size(348, 148);
            this.panelFalso.TabIndex = 7;
            // 
            // textboxExplicacion
            // 
            this.textboxExplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxExplicacion.ForeColor = System.Drawing.Color.Black;
            this.textboxExplicacion.Location = new System.Drawing.Point(8, 174);
            this.textboxExplicacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textboxExplicacion.Multiline = true;
            this.textboxExplicacion.Name = "textboxExplicacion";
            this.textboxExplicacion.Size = new System.Drawing.Size(173, 351);
            this.textboxExplicacion.TabIndex = 12;
            this.textboxExplicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPuntuacion
            // 
            this.textBoxPuntuacion.Location = new System.Drawing.Point(8, 92);
            this.textBoxPuntuacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPuntuacion.Name = "textBoxPuntuacion";
            this.textBoxPuntuacion.Size = new System.Drawing.Size(173, 22);
            this.textBoxPuntuacion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Explicación (opcional):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(4, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Puntuacion :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textboxExplicacion);
            this.panel1.Controls.Add(this.textBoxPuntuacion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1021, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 652);
            this.panel1.TabIndex = 14;
            // 
            // FormVF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFalso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelVerdadero);
            this.Controls.Add(this.botonAñadirImagen);
            this.Controls.Add(this.inputImagen);
            this.Controls.Add(this.textBoxEnunciado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormVF";
            this.Text = "FormVF";
            ((System.ComponentModel.ISupportInitialize)(this.inputImagen)).EndInit();
            this.panelVerdadero.ResumeLayout(false);
            this.panelVerdadero.PerformLayout();
            this.panelFalso.ResumeLayout(false);
            this.panelFalso.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEnunciado;
        private System.Windows.Forms.PictureBox inputImagen;
        private System.Windows.Forms.Button botonAñadirImagen;
        private System.Windows.Forms.RadioButton botonVerdadero;
        private System.Windows.Forms.Panel panelVerdadero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelFalso;
        private System.Windows.Forms.RadioButton botonFalso;
        private System.Windows.Forms.TextBox textboxExplicacion;
        private System.Windows.Forms.TextBox textBoxPuntuacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}