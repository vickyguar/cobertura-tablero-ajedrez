
namespace CoberturaTableroAjedrez.Presentacion
{
    partial class FormularioInicio
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
            this.btnGenerarSoluciones = new System.Windows.Forms.Button();
            this.imagenPortada = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarSoluciones
            // 
            this.btnGenerarSoluciones.BackColor = System.Drawing.Color.Black;
            this.btnGenerarSoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarSoluciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerarSoluciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerarSoluciones.Location = new System.Drawing.Point(304, 467);
            this.btnGenerarSoluciones.Name = "btnGenerarSoluciones";
            this.btnGenerarSoluciones.Size = new System.Drawing.Size(151, 38);
            this.btnGenerarSoluciones.TabIndex = 6;
            this.btnGenerarSoluciones.Text = "Generar soluciones";
            this.btnGenerarSoluciones.UseVisualStyleBackColor = false;
            this.btnGenerarSoluciones.Click += new System.EventHandler(this.btnGenerarSoluciones_Click);
            // 
            // imagenPortada
            // 
            this.imagenPortada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagenPortada.Image = global::CoberturaTableroAjedrez.Properties.Resources.Caratula;
            this.imagenPortada.Location = new System.Drawing.Point(0, 0);
            this.imagenPortada.Name = "imagenPortada";
            this.imagenPortada.Size = new System.Drawing.Size(744, 542);
            this.imagenPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenPortada.TabIndex = 9;
            this.imagenPortada.TabStop = false;
            // 
            // FormularioInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(744, 542);
            this.Controls.Add(this.btnGenerarSoluciones);
            this.Controls.Add(this.imagenPortada);
            this.Name = "FormularioInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobertura de tablero de ajedrez";
            ((System.ComponentModel.ISupportInitialize)(this.imagenPortada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGenerarSoluciones;
        private System.Windows.Forms.PictureBox imagenPortada;
    }
}