namespace ProyectoApp
{
    partial class FormProductoAgregar
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblIdMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtElemCodigo = new System.Windows.Forms.TextBox();
            this.txtElemNombre = new System.Windows.Forms.TextBox();
            this.txtElemDescripcion = new System.Windows.Forms.TextBox();
            this.txtElemPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboIdMarca = new System.Windows.Forms.ComboBox();
            this.cboIdCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(126, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(433, 75);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "    Producto   ";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(194, 128);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(69, 18);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(187, 167);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 18);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(154, 200);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(109, 18);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMarca.Location = new System.Drawing.Point(194, 234);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.Size = new System.Drawing.Size(67, 18);
            this.lblIdMarca.TabIndex = 5;
            this.lblIdMarca.Text = " Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(169, 267);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(92, 18);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(194, 301);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(65, 18);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtElemCodigo
            // 
            this.txtElemCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtElemCodigo.Location = new System.Drawing.Point(284, 128);
            this.txtElemCodigo.Name = "txtElemCodigo";
            this.txtElemCodigo.Size = new System.Drawing.Size(170, 20);
            this.txtElemCodigo.TabIndex = 8;
            // 
            // txtElemNombre
            // 
            this.txtElemNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtElemNombre.Location = new System.Drawing.Point(284, 165);
            this.txtElemNombre.Name = "txtElemNombre";
            this.txtElemNombre.Size = new System.Drawing.Size(170, 20);
            this.txtElemNombre.TabIndex = 9;
            // 
            // txtElemDescripcion
            // 
            this.txtElemDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtElemDescripcion.Location = new System.Drawing.Point(284, 200);
            this.txtElemDescripcion.Name = "txtElemDescripcion";
            this.txtElemDescripcion.Size = new System.Drawing.Size(304, 20);
            this.txtElemDescripcion.TabIndex = 10;
            // 
            // txtElemPrecio
            // 
            this.txtElemPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtElemPrecio.Location = new System.Drawing.Point(284, 302);
            this.txtElemPrecio.Name = "txtElemPrecio";
            this.txtElemPrecio.Size = new System.Drawing.Size(109, 20);
            this.txtElemPrecio.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(284, 336);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 42);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboIdMarca
            // 
            this.cboIdMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdMarca.FormattingEnabled = true;
            this.cboIdMarca.Location = new System.Drawing.Point(284, 235);
            this.cboIdMarca.Name = "cboIdMarca";
            this.cboIdMarca.Size = new System.Drawing.Size(121, 21);
            this.cboIdMarca.TabIndex = 15;
            // 
            // cboIdCategoria
            // 
            this.cboIdCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdCategoria.FormattingEnabled = true;
            this.cboIdCategoria.Location = new System.Drawing.Point(284, 268);
            this.cboIdCategoria.Name = "cboIdCategoria";
            this.cboIdCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboIdCategoria.TabIndex = 16;
            // 
            // FormProductoAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(643, 390);
            this.Controls.Add(this.cboIdCategoria);
            this.Controls.Add(this.cboIdMarca);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtElemPrecio);
            this.Controls.Add(this.txtElemDescripcion);
            this.Controls.Add(this.txtElemNombre);
            this.Controls.Add(this.txtElemCodigo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblIdMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormProductoAgregar";
            this.Text = "FormProductoAgregar";
            this.Load += new System.EventHandler(this.FormProductoAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblIdMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtElemCodigo;
        private System.Windows.Forms.TextBox txtElemNombre;
        private System.Windows.Forms.TextBox txtElemDescripcion;
        private System.Windows.Forms.TextBox txtElemPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboIdMarca;
        private System.Windows.Forms.ComboBox cboIdCategoria;
    }
}