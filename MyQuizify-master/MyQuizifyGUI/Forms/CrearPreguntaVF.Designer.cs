
namespace MyQuizifyGUI.Forms
{
    partial class CrearPreguntaVF
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonVerdadero = new System.Windows.Forms.RadioButton();
            this.radioButtonFalso = new System.Windows.Forms.RadioButton();
            this.textBoxExplicacion = new System.Windows.Forms.TextBox();
            this.textBoxNombrePregunta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEnunciado
            // 
            this.textBoxEnunciado.Location = new System.Drawing.Point(45, 49);
            this.textBoxEnunciado.Multiline = true;
            this.textBoxEnunciado.Name = "textBoxEnunciado";
            this.textBoxEnunciado.Size = new System.Drawing.Size(277, 128);
            this.textBoxEnunciado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escriba el enunciado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFalso);
            this.groupBox1.Controls.Add(this.radioButtonVerdadero);
            this.groupBox1.Location = new System.Drawing.Point(45, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButtonVerdadero
            // 
            this.radioButtonVerdadero.AutoSize = true;
            this.radioButtonVerdadero.Location = new System.Drawing.Point(31, 47);
            this.radioButtonVerdadero.Name = "radioButtonVerdadero";
            this.radioButtonVerdadero.Size = new System.Drawing.Size(74, 17);
            this.radioButtonVerdadero.TabIndex = 0;
            this.radioButtonVerdadero.TabStop = true;
            this.radioButtonVerdadero.Text = "Verdadero";
            this.radioButtonVerdadero.UseVisualStyleBackColor = true;
            // 
            // radioButtonFalso
            // 
            this.radioButtonFalso.AutoSize = true;
            this.radioButtonFalso.Location = new System.Drawing.Point(155, 47);
            this.radioButtonFalso.Name = "radioButtonFalso";
            this.radioButtonFalso.Size = new System.Drawing.Size(50, 17);
            this.radioButtonFalso.TabIndex = 1;
            this.radioButtonFalso.TabStop = true;
            this.radioButtonFalso.Text = "Falso";
            this.radioButtonFalso.UseVisualStyleBackColor = true;
            // 
            // textBoxExplicacion
            // 
            this.textBoxExplicacion.Location = new System.Drawing.Point(371, 118);
            this.textBoxExplicacion.Multiline = true;
            this.textBoxExplicacion.Name = "textBoxExplicacion";
            this.textBoxExplicacion.Size = new System.Drawing.Size(128, 91);
            this.textBoxExplicacion.TabIndex = 19;
            // 
            // textBoxNombrePregunta
            // 
            this.textBoxNombrePregunta.Location = new System.Drawing.Point(371, 68);
            this.textBoxNombrePregunta.Name = "textBoxNombrePregunta";
            this.textBoxNombrePregunta.Size = new System.Drawing.Size(128, 20);
            this.textBoxNombrePregunta.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Explicacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre de la pregunta:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Crear pregunta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CrearPreguntaVF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 343);
            this.Controls.Add(this.textBoxExplicacion);
            this.Controls.Add(this.textBoxNombrePregunta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEnunciado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearPreguntaVF";
            this.Text = "CrearPreguntaVF";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEnunciado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFalso;
        private System.Windows.Forms.RadioButton radioButtonVerdadero;
        private System.Windows.Forms.TextBox textBoxExplicacion;
        private System.Windows.Forms.TextBox textBoxNombrePregunta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}