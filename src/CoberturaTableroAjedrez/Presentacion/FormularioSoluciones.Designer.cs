
namespace CoberturaTableroAjedrez.Presentacion
{
    partial class FormularioSoluciones
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_next = new System.Windows.Forms.Button();
            this.Barra = new System.Windows.Forms.ProgressBar();
            this.btn_fatales = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_back_fatal = new System.Windows.Forms.Button();
            this.btn_next_fatal = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_time = new System.Windows.Forms.Button();
            Dtg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(Dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtg
            // 
            Dtg.AllowUserToAddRows = false;
            Dtg.AllowUserToDeleteRows = false;
            Dtg.AllowUserToResizeColumns = false;
            Dtg.AllowUserToResizeRows = false;
            Dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            Dtg.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            Dtg.CausesValidation = false;
            Dtg.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            Dtg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            Dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dtg.ColumnHeadersVisible = false;
            Dtg.Cursor = System.Windows.Forms.Cursors.Arrow;
            Dtg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            Dtg.EnableHeadersVisualStyles = false;
            Dtg.GridColor = System.Drawing.SystemColors.ControlLight;
            Dtg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            Dtg.Location = new System.Drawing.Point(187, 75);
            Dtg.MultiSelect = false;
            Dtg.Name = "Dtg";
            Dtg.ReadOnly = true;
            Dtg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            Dtg.RowHeadersVisible = false;
            Dtg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Dtg.RowTemplate.Height = 50;
            Dtg.RowTemplate.ReadOnly = true;
            Dtg.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Dtg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            Dtg.ShowCellErrors = false;
            Dtg.ShowCellToolTips = false;
            Dtg.ShowEditingIcon = false;
            Dtg.ShowRowErrors = false;
            Dtg.Size = new System.Drawing.Size(400, 400);
            Dtg.TabIndex = 0;
            Dtg.TabStop = false;
            // 
            // btn_next
            // 
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Location = new System.Drawing.Point(663, 452);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // 
            // Barra
            // 
            this.Barra.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Barra.Location = new System.Drawing.Point(187, 30);
            this.Barra.Maximum = 10;
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(400, 23);
            this.Barra.Step = 1;
            this.Barra.TabIndex = 1;
            // 
            // btn_fatales
            // 
            this.btn_fatales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fatales.Location = new System.Drawing.Point(663, 413);
            this.btn_fatales.Name = "btn_fatales";
            this.btn_fatales.Size = new System.Drawing.Size(75, 23);
            this.btn_fatales.TabIndex = 2;
            this.btn_fatales.Text = "Filtrar";
            this.btn_fatales.UseVisualStyleBackColor = true;
            this.btn_fatales.Visible = false;
            this.btn_fatales.Click += new System.EventHandler(this.btn_fatales_Click);
            // 
            // btn_back
            // 
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(53, 452);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_back_fatal
            // 
            this.btn_back_fatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back_fatal.Location = new System.Drawing.Point(53, 452);
            this.btn_back_fatal.Name = "btn_back_fatal";
            this.btn_back_fatal.Size = new System.Drawing.Size(75, 23);
            this.btn_back_fatal.TabIndex = 4;
            this.btn_back_fatal.Text = "Back";
            this.btn_back_fatal.UseVisualStyleBackColor = true;
            this.btn_back_fatal.Click += new System.EventHandler(this.btn_back_fatal_Click);
            // 
            // btn_next_fatal
            // 
            this.btn_next_fatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next_fatal.Location = new System.Drawing.Point(663, 452);
            this.btn_next_fatal.Name = "btn_next_fatal";
            this.btn_next_fatal.Size = new System.Drawing.Size(75, 23);
            this.btn_next_fatal.TabIndex = 5;
            this.btn_next_fatal.Text = "Next";
            this.btn_next_fatal.UseVisualStyleBackColor = true;
            this.btn_next_fatal.Click += new System.EventHandler(this.btn_next_fatal_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(663, 375);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Visible = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_time
            // 
            this.btn_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_time.Location = new System.Drawing.Point(663, 336);
            this.btn_time.Name = "btn_time";
            this.btn_time.Size = new System.Drawing.Size(75, 23);
            this.btn_time.TabIndex = 7;
            this.btn_time.Text = "Time";
            this.btn_time.UseVisualStyleBackColor = true;
            this.btn_time.Visible = false;
            this.btn_time.Click += new System.EventHandler(this.btn_time_Click);
            // 
            // 
            // FormularioSoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; 
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.btn_time);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_next_fatal);
            this.Controls.Add(this.btn_back_fatal);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_fatales);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(Dtg);
            this.Name = "FormularioSoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soluciones";
            ((System.ComponentModel.ISupportInitialize)(Dtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.ProgressBar Barra;
        private System.Windows.Forms.Button btn_fatales;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_back_fatal;
        private System.Windows.Forms.Button btn_next_fatal;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_time;
        private System.Windows.Forms.DataGridView Dtg;
    }
}

