
namespace MyQuizifyGUI.Forms
{
    partial class FormAbierto
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
            this.textboxEnunciado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputImagen = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxResp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPuntuacion = new System.Windows.Forms.TextBox();
            this.textboxExplicacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxEnunciado
            // 
            this.textboxEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxEnunciado.ForeColor = System.Drawing.Color.Black;
            this.textboxEnunciado.Location = new System.Drawing.Point(22, 48);
            this.textboxEnunciado.Multiline = true;
            this.textboxEnunciado.Name = "textboxEnunciado";
            this.textboxEnunciado.Size = new System.Drawing.Size(696, 56);
            this.textboxEnunciado.TabIndex = 2;
            this.textboxEnunciado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Escriba el enunciado :";
            // 
            // inputImagen
            // 
            this.inputImagen.Location = new System.Drawing.Point(401, 141);
            this.inputImagen.Name = "inputImagen";
            this.inputImagen.Size = new System.Drawing.Size(284, 336);
            this.inputImagen.TabIndex = 13;
            this.inputImagen.TabStop = false;
            this.inputImagen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "Añadir imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxResp
            // 
            this.textBoxResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResp.ForeColor = System.Drawing.Color.Black;
            this.textBoxResp.Location = new System.Drawing.Point(21, 141);
            this.textBoxResp.Multiline = true;
            this.textBoxResp.Name = "textBoxResp";
            this.textBoxResp.Size = new System.Drawing.Size(334, 336);
            this.textBoxResp.TabIndex = 17;
            this.textBoxResp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxResp.TextChanged += new System.EventHandler(this.textBoxResp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Escriba la respuesta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(771, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Puntuacion :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(771, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Explicación (opcional):";
            // 
            // textBoxPuntuacion
            // 
            this.textBoxPuntuacion.Location = new System.Drawing.Point(774, 141);
            this.textBoxPuntuacion.Name = "textBoxPuntuacion";
            this.textBoxPuntuacion.Size = new System.Drawing.Size(131, 20);
            this.textBoxPuntuacion.TabIndex = 2;
            // 
            // textboxExplicacion
            // 
            this.textboxExplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxExplicacion.ForeColor = System.Drawing.Color.Black;
            this.textboxExplicacion.Location = new System.Drawing.Point(774, 191);
            this.textboxExplicacion.Multiline = true;
            this.textboxExplicacion.Name = "textboxExplicacion";
            this.textboxExplicacion.Size = new System.Drawing.Size(131, 286);
            this.textboxExplicacion.TabIndex = 12;
            this.textboxExplicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormAbierto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 553);
            this.Controls.Add(this.textboxExplicacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPuntuacion);
            this.Controls.Add(this.textBoxResp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputImagen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxEnunciado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAbierto";
            this.Text = "FormAbierto";
            this.Load += new System.EventHandler(this.FormAbierto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxEnunciado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox inputImagen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxResp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPuntuacion;
        private System.Windows.Forms.TextBox textboxExplicacion;
    }
}