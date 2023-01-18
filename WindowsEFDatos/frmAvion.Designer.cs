namespace WindowsEFDatos
{
    partial class frmAvion
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
            this.AVIONES = new System.Windows.Forms.Label();
            this.dgvAviones = new System.Windows.Forms.DataGridView();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblMsjInsertar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.lblMsjEliminar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblMsjEditar = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblMsjPorId = new System.Windows.Forms.Label();
            this.btnPorId = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLineasAereas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAviones)).BeginInit();
            this.SuspendLayout();
            // 
            // AVIONES
            // 
            this.AVIONES.AutoSize = true;
            this.AVIONES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AVIONES.Location = new System.Drawing.Point(12, 21);
            this.AVIONES.Name = "AVIONES";
            this.AVIONES.Size = new System.Drawing.Size(88, 20);
            this.AVIONES.TabIndex = 0;
            this.AVIONES.Text = "AVIONES";
            // 
            // dgvAviones
            // 
            this.dgvAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAviones.Location = new System.Drawing.Point(12, 196);
            this.dgvAviones.Name = "dgvAviones";
            this.dgvAviones.Size = new System.Drawing.Size(550, 150);
            this.dgvAviones.TabIndex = 1;
            this.dgvAviones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAviones_CellDoubleClick);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(377, 21);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblMsjInsertar
            // 
            this.lblMsjInsertar.AutoSize = true;
            this.lblMsjInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjInsertar.Location = new System.Drawing.Point(467, 28);
            this.lblMsjInsertar.Name = "lblMsjInsertar";
            this.lblMsjInsertar.Size = new System.Drawing.Size(0, 16);
            this.lblMsjInsertar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Capacidad: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Denominación: ";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(115, 97);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(203, 20);
            this.txtCapacidad.TabIndex = 6;
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Location = new System.Drawing.Point(115, 131);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(203, 20);
            this.txtDenominacion.TabIndex = 7;
            // 
            // lblMsjEliminar
            // 
            this.lblMsjEliminar.AutoSize = true;
            this.lblMsjEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjEliminar.Location = new System.Drawing.Point(467, 67);
            this.lblMsjEliminar.Name = "lblMsjEliminar";
            this.lblMsjEliminar.Size = new System.Drawing.Size(0, 16);
            this.lblMsjEliminar.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(377, 60);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblMsjEditar
            // 
            this.lblMsjEditar.AutoSize = true;
            this.lblMsjEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjEditar.Location = new System.Drawing.Point(467, 105);
            this.lblMsjEditar.Name = "lblMsjEditar";
            this.lblMsjEditar.Size = new System.Drawing.Size(0, 16);
            this.lblMsjEditar.TabIndex = 11;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(377, 98);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblMsjPorId
            // 
            this.lblMsjPorId.AutoSize = true;
            this.lblMsjPorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjPorId.Location = new System.Drawing.Point(467, 137);
            this.lblMsjPorId.Name = "lblMsjPorId";
            this.lblMsjPorId.Size = new System.Drawing.Size(0, 16);
            this.lblMsjPorId.TabIndex = 13;
            // 
            // btnPorId
            // 
            this.btnPorId.Location = new System.Drawing.Point(377, 130);
            this.btnPorId.Name = "btnPorId";
            this.btnPorId.Size = new System.Drawing.Size(75, 57);
            this.btnPorId.TabIndex = 12;
            this.btnPorId.Text = "BUSCAR \r\nPOR\r\nID";
            this.btnPorId.UseVisualStyleBackColor = true;
            this.btnPorId.Click += new System.EventHandler(this.btnPorId_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(115, 61);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(52, 20);
            this.txtId.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Linea Aerea:";
            // 
            // cboLineasAereas
            // 
            this.cboLineasAereas.FormattingEnabled = true;
            this.cboLineasAereas.Location = new System.Drawing.Point(115, 165);
            this.cboLineasAereas.Name = "cboLineasAereas";
            this.cboLineasAereas.Size = new System.Drawing.Size(203, 21);
            this.cboLineasAereas.TabIndex = 18;
            this.cboLineasAereas.SelectionChangeCommitted += new System.EventHandler(this.cboLineasAereas_SelectionChangeCommitted);
            // 
            // frmAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 416);
            this.Controls.Add(this.cboLineasAereas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMsjPorId);
            this.Controls.Add(this.btnPorId);
            this.Controls.Add(this.lblMsjEditar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblMsjEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtDenominacion);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsjInsertar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dgvAviones);
            this.Controls.Add(this.AVIONES);
            this.Name = "frmAvion";
            this.Text = "Perez Candela";
            this.Load += new System.EventHandler(this.frmAvion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAviones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AVIONES;
        private System.Windows.Forms.DataGridView dgvAviones;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblMsjInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtDenominacion;
        private System.Windows.Forms.Label lblMsjEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblMsjEditar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblMsjPorId;
        private System.Windows.Forms.Button btnPorId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLineasAereas;
    }
}

