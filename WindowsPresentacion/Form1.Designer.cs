namespace WindowsPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridPacientes = new System.Windows.Forms.DataGridView();
            this.gridMedicos = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lstHabitaciones = new System.Windows.Forms.ListView();
            this.lstMedicosClinicos = new System.Windows.Forms.ListView();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this.lblClinicos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPacientes
            // 
            this.gridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacientes.Location = new System.Drawing.Point(12, 317);
            this.gridPacientes.Name = "gridPacientes";
            this.gridPacientes.RowHeadersWidth = 62;
            this.gridPacientes.RowTemplate.Height = 28;
            this.gridPacientes.Size = new System.Drawing.Size(407, 208);
            this.gridPacientes.TabIndex = 0;
            // 
            // gridMedicos
            // 
            this.gridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedicos.Location = new System.Drawing.Point(12, 94);
            this.gridMedicos.Name = "gridMedicos";
            this.gridMedicos.RowHeadersWidth = 62;
            this.gridMedicos.Size = new System.Drawing.Size(407, 196);
            this.gridMedicos.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(279, 12);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(140, 68);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar Sistema";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(573, 12);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(140, 68);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar ";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lstHabitaciones
            // 
            this.lstHabitaciones.HideSelection = false;
            this.lstHabitaciones.Location = new System.Drawing.Point(680, 127);
            this.lstHabitaciones.Name = "lstHabitaciones";
            this.lstHabitaciones.Size = new System.Drawing.Size(244, 163);
            this.lstHabitaciones.TabIndex = 5;
            this.lstHabitaciones.UseCompatibleStateImageBehavior = false;
            // 
            // lstMedicosClinicos
            // 
            this.lstMedicosClinicos.HideSelection = false;
            this.lstMedicosClinicos.Location = new System.Drawing.Point(676, 330);
            this.lstMedicosClinicos.Name = "lstMedicosClinicos";
            this.lstMedicosClinicos.Size = new System.Drawing.Size(248, 195);
            this.lstMedicosClinicos.TabIndex = 6;
            this.lstMedicosClinicos.UseCompatibleStateImageBehavior = false;
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.Location = new System.Drawing.Point(12, 71);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(68, 20);
            this.lblMedicos.TabIndex = 7;
            this.lblMedicos.Text = "Medicos";
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Location = new System.Drawing.Point(16, 293);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(79, 20);
            this.lblPacientes.TabIndex = 8;
            this.lblPacientes.Text = "Pacientes";
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Location = new System.Drawing.Point(680, 104);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(102, 20);
            this.lblHabitaciones.TabIndex = 9;
            this.lblHabitaciones.Text = "Habitaciones";
            // 
            // lblClinicos
            // 
            this.lblClinicos.AutoSize = true;
            this.lblClinicos.Location = new System.Drawing.Point(676, 307);
            this.lblClinicos.Name = "lblClinicos";
            this.lblClinicos.Size = new System.Drawing.Size(63, 20);
            this.lblClinicos.TabIndex = 10;
            this.lblClinicos.Text = "Clinicos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 537);
            this.Controls.Add(this.lblClinicos);
            this.Controls.Add(this.lblHabitaciones);
            this.Controls.Add(this.lblPacientes);
            this.Controls.Add(this.lblMedicos);
            this.Controls.Add(this.lstMedicosClinicos);
            this.Controls.Add(this.lstHabitaciones);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.gridMedicos);
            this.Controls.Add(this.gridPacientes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPacientes;
        private System.Windows.Forms.DataGridView gridMedicos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListView lstHabitaciones;
        private System.Windows.Forms.ListView lstMedicosClinicos;
        private System.Windows.Forms.Label lblMedicos;
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.Label lblClinicos;
    }
}

