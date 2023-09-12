namespace ProyectoApp
{
    partial class FormCategoriaAgregar
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblIdMarca = new System.Windows.Forms.Label();
            this.txtElementoCategoria = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtRegArticulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(38, 219);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(145, 24);
            this.lblDescripcion.TabIndex = 13;
            this.lblDescripcion.Text = "Descripción: ";
            // 
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMarca.Location = new System.Drawing.Point(42, 142);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.Size = new System.Drawing.Size(152, 24);
            this.lblIdMarca.TabIndex = 12;
            this.lblIdMarca.Text = "Id Automático";
            // 
            // txtElementoCategoria
            // 
            this.txtElementoCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtElementoCategoria.Location = new System.Drawing.Point(189, 223);
            this.txtElementoCategoria.Name = "txtElementoCategoria";
            this.txtElementoCategoria.Size = new System.Drawing.Size(229, 20);
            this.txtElementoCategoria.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(35, 317);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 35);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtRegArticulo
            // 
            this.txtRegArticulo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtRegArticulo.Cursor = System.Windows.Forms.Cursors.No;
            this.txtRegArticulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegArticulo.ForeColor = System.Drawing.Color.White;
            this.txtRegArticulo.Location = new System.Drawing.Point(12, 12);
            this.txtRegArticulo.Name = "txtRegArticulo";
            this.txtRegArticulo.ReadOnly = true;
            this.txtRegArticulo.Size = new System.Drawing.Size(776, 63);
            this.txtRegArticulo.TabIndex = 9;
            this.txtRegArticulo.Text = "Agregar Categoria";
            this.txtRegArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegArticulo.TextChanged += new System.EventHandler(this.txtRegArticulo_TextChanged);
            // 
            // FormCategoriaAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblIdMarca);
            this.Controls.Add(this.txtElementoCategoria);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtRegArticulo);
            this.Name = "FormCategoriaAgregar";
            this.Text = "Agregar Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblIdMarca;
        private System.Windows.Forms.TextBox txtElementoCategoria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtRegArticulo;
    }
}