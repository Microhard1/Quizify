
namespace MyQuizifyGUI.Forms.Quizzes
{
    partial class Competencias
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
            this.button1 = new System.Windows.Forms.Button();
            this.listaCompetencias = new System.Windows.Forms.CheckedListBox();
            this.textboxID = new System.Windows.Forms.TextBox();
            this.botonCrearCompetencia = new System.Windows.Forms.Button();
            this.textBoxDefinicon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(500, 332);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Asignar competencias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaCompetencias
            // 
            this.listaCompetencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaCompetencias.FormattingEnabled = true;
            this.listaCompetencias.Location = new System.Drawing.Point(36, 63);
            this.listaCompetencias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listaCompetencias.Name = "listaCompetencias";
            this.listaCompetencias.Size = new System.Drawing.Size(436, 326);
            this.listaCompetencias.TabIndex = 1;
            this.listaCompetencias.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // textboxID
            // 
            this.textboxID.Location = new System.Drawing.Point(500, 72);
            this.textboxID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(143, 20);
            this.textboxID.TabIndex = 2;
            // 
            // botonCrearCompetencia
            // 
            this.botonCrearCompetencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCrearCompetencia.Location = new System.Drawing.Point(626, 278);
            this.botonCrearCompetencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonCrearCompetencia.Name = "botonCrearCompetencia";
            this.botonCrearCompetencia.Size = new System.Drawing.Size(59, 40);
            this.botonCrearCompetencia.TabIndex = 3;
            this.botonCrearCompetencia.Text = "Crear";
            this.botonCrearCompetencia.UseVisualStyleBackColor = true;
            this.botonCrearCompetencia.Click += new System.EventHandler(this.botonCrearCompetencia_Click);
            // 
            // textBoxDefinicon
            // 
            this.textBoxDefinicon.Location = new System.Drawing.Point(500, 114);
            this.textBoxDefinicon.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDefinicon.Multiline = true;
            this.textBoxDefinicon.Name = "textBoxDefinicon";
            this.textBoxDefinicon.Size = new System.Drawing.Size(185, 160);
            this.textBoxDefinicon.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Definicion";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cargar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Competencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 551);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDefinicon);
            this.Controls.Add(this.botonCrearCompetencia);
            this.Controls.Add(this.textboxID);
            this.Controls.Add(this.listaCompetencias);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Competencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Competencias";
            this.Load += new System.EventHandler(this.Competencias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox listaCompetencias;
        private System.Windows.Forms.TextBox textboxID;
        private System.Windows.Forms.Button botonCrearCompetencia;
        private System.Windows.Forms.TextBox textBoxDefinicon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}