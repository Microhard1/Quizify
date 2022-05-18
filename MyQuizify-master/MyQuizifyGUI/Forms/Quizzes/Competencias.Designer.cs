
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
            this.textoCompetencia = new System.Windows.Forms.TextBox();
            this.botonCrearCompetencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(375, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Asignar competencias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaCompetencias
            // 
            this.listaCompetencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaCompetencias.FormattingEnabled = true;
            this.listaCompetencias.Items.AddRange(new object[] {
            "Trabajo en equipo"});
            this.listaCompetencias.Location = new System.Drawing.Point(199, 120);
            this.listaCompetencias.Name = "listaCompetencias";
            this.listaCompetencias.Size = new System.Drawing.Size(580, 410);
            this.listaCompetencias.TabIndex = 1;
            this.listaCompetencias.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // textoCompetencia
            // 
            this.textoCompetencia.Location = new System.Drawing.Point(199, 65);
            this.textoCompetencia.Name = "textoCompetencia";
            this.textoCompetencia.Size = new System.Drawing.Size(495, 22);
            this.textoCompetencia.TabIndex = 2;
            // 
            // botonCrearCompetencia
            // 
            this.botonCrearCompetencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCrearCompetencia.Location = new System.Drawing.Point(700, 51);
            this.botonCrearCompetencia.Name = "botonCrearCompetencia";
            this.botonCrearCompetencia.Size = new System.Drawing.Size(79, 49);
            this.botonCrearCompetencia.TabIndex = 3;
            this.botonCrearCompetencia.Text = "Crear";
            this.botonCrearCompetencia.UseVisualStyleBackColor = true;
            this.botonCrearCompetencia.Click += new System.EventHandler(this.botonCrearCompetencia_Click);
            // 
            // Competencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 647);
            this.Controls.Add(this.botonCrearCompetencia);
            this.Controls.Add(this.textoCompetencia);
            this.Controls.Add(this.listaCompetencias);
            this.Controls.Add(this.button1);
            this.Name = "Competencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Competencias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox listaCompetencias;
        private System.Windows.Forms.TextBox textoCompetencia;
        private System.Windows.Forms.Button botonCrearCompetencia;
    }
}