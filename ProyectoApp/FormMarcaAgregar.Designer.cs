﻿namespace ProyectoApp
{
    partial class FormMarcaAgregar
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtElementoMarca = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblAgregarMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(228, 277);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(165, 53);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtElementoMarca
            // 
            this.txtElementoMarca.Location = new System.Drawing.Point(271, 208);
            this.txtElementoMarca.Name = "txtElementoMarca";
            this.txtElementoMarca.Size = new System.Drawing.Size(229, 20);
            this.txtElementoMarca.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(120, 204);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(145, 24);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripción: ";
            // 
            // lblAgregarMarca
            // 
            this.lblAgregarMarca.AutoSize = true;
            this.lblAgregarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblAgregarMarca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAgregarMarca.Location = new System.Drawing.Point(151, 41);
            this.lblAgregarMarca.Name = "lblAgregarMarca";
            this.lblAgregarMarca.Size = new System.Drawing.Size(379, 55);
            this.lblAgregarMarca.TabIndex = 9;
            this.lblAgregarMarca.Text = "Agregár Marca";
            // 
            // FormMarcaAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(637, 379);
            this.Controls.Add(this.lblAgregarMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtElementoMarca);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FormMarcaAgregar";
            this.Text = "FormMarcaAgregar";
            this.Load += new System.EventHandler(this.FormMarcarAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtElementoMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblAgregarMarca;
    }
}