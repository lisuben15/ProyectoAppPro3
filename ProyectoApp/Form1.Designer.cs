﻿namespace ProyectoApp
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
            this.components = new System.ComponentModel.Container();
            this.lblGestionComercial = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGestionComercial
            // 
            this.lblGestionComercial.AutoSize = true;
            this.lblGestionComercial.BackColor = System.Drawing.Color.Black;
            this.lblGestionComercial.Font = new System.Drawing.Font("Times New Roman", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionComercial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblGestionComercial.Location = new System.Drawing.Point(297, 60);
            this.lblGestionComercial.Name = "lblGestionComercial";
            this.lblGestionComercial.Size = new System.Drawing.Size(811, 109);
            this.lblGestionComercial.TabIndex = 0;
            this.lblGestionComercial.Text = "Gestión Comercial";
            this.lblGestionComercial.Click += new System.EventHandler(this.lblGestionComercial_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProductos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.Silver;
            this.btnProductos.Location = new System.Drawing.Point(316, 327);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(210, 90);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMarcas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.ForeColor = System.Drawing.Color.Silver;
            this.btnMarcas.Location = new System.Drawing.Point(600, 327);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(210, 90);
            this.btnMarcas.TabIndex = 2;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = false;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCategorias.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.Silver;
            this.btnCategorias.Location = new System.Drawing.Point(882, 327);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(210, 90);
            this.btnCategorias.TabIndex = 3;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1191, 496);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.lblGestionComercial);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1ProyectoApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionComercial;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnCategorias;
    }
}

