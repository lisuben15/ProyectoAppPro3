namespace ProyectoApp
{
    partial class Form1ProyectoApp
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
            this.components = new System.ComponentModel.Container();
            this.lblGestionComercial = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.msArchivo = new System.Windows.Forms.MenuStrip();
            this.mstripArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msArchivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGestionComercial
            // 
            this.lblGestionComercial.AutoSize = true;
            this.lblGestionComercial.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionComercial.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblGestionComercial.Location = new System.Drawing.Point(297, 60);
            this.lblGestionComercial.Name = "lblGestionComercial";
            this.lblGestionComercial.Size = new System.Drawing.Size(811, 109);
            this.lblGestionComercial.TabIndex = 0;
            this.lblGestionComercial.Text = "Gestion Comercial";
            this.lblGestionComercial.Click += new System.EventHandler(this.lblGestionComercial_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerProductos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerProductos.Location = new System.Drawing.Point(141, 327);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(210, 90);
            this.btnVerProductos.TabIndex = 1;
            this.btnVerProductos.Text = "Ver Productos";
            this.btnVerProductos.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(433, 327);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(210, 90);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(722, 327);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(210, 90);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1010, 327);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(210, 90);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // msArchivo
            // 
            this.msArchivo.BackColor = System.Drawing.Color.DarkGray;
            this.msArchivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstripArchivo,
            this.opcionToolStripMenuItem});
            this.msArchivo.Location = new System.Drawing.Point(0, 0);
            this.msArchivo.Name = "msArchivo";
            this.msArchivo.Size = new System.Drawing.Size(1191, 24);
            this.msArchivo.TabIndex = 5;
            this.msArchivo.Text = "Archivo";
            this.msArchivo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msArchivo_ItemClicked);
            // 
            // mstripArchivo
            // 
            this.mstripArchivo.Name = "mstripArchivo";
            this.mstripArchivo.Size = new System.Drawing.Size(60, 20);
            this.mstripArchivo.Text = "Archivo";
            // 
            // opcionToolStripMenuItem
            // 
            this.opcionToolStripMenuItem.Name = "opcionToolStripMenuItem";
            this.opcionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.opcionToolStripMenuItem.Text = "opcion";
            // 
            // Form1ProyectoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1191, 496);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVerProductos);
            this.Controls.Add(this.lblGestionComercial);
            this.Controls.Add(this.msArchivo);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Name = "Form1ProyectoApp";
            this.Text = "ProyectoApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1ProyectoApp_Load);
            this.msArchivo.ResumeLayout(false);
            this.msArchivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionComercial;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnVerProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.MenuStrip msArchivo;
        private System.Windows.Forms.ToolStripMenuItem mstripArchivo;
        private System.Windows.Forms.ToolStripMenuItem opcionToolStripMenuItem;
    }
}

