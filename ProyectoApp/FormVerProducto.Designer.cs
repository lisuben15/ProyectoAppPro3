namespace ProyectoApp
{
    partial class FormVerProducto
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
            this.dgvVerProducto = new System.Windows.Forms.DataGridView();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtElemId = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVerProducto
            // 
            this.dgvVerProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerProducto.Location = new System.Drawing.Point(23, 116);
            this.dgvVerProducto.Name = "dgvVerProducto";
            this.dgvVerProducto.Size = new System.Drawing.Size(511, 54);
            this.dgvVerProducto.TabIndex = 0;

            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(20, 57);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(158, 18);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Ingrese Id articulo:";
            // 
            // txtElemId
            // 
            this.txtElemId.Location = new System.Drawing.Point(220, 57);
            this.txtElemId.Name = "txtElemId";
            this.txtElemId.Size = new System.Drawing.Size(166, 20);
            this.txtElemId.TabIndex = 2;
            this.txtElemId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.Teal;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.Location = new System.Drawing.Point(433, 49);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(100, 36);
            this.btnBuscarProducto.TabIndex = 3;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            
            // 
            // FormVerProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 357);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.txtElemId);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.dgvVerProducto);
            this.Name = "FormVerProducto";
            this.Text = "FormVerProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtElemId;
        private System.Windows.Forms.Button btnBuscarProducto;
    }
}