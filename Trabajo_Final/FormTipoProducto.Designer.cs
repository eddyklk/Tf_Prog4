
namespace Trabajo_Final
{
    partial class FormTipoProducto
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
            this.btnProGuardar = new System.Windows.Forms.Button();
            this.TxtmodtipPro = new System.Windows.Forms.TextBox();
            this.dgvTipoProd = new System.Windows.Forms.DataGridView();
            this.BtnProEditar = new System.Windows.Forms.Button();
            this.BtnProSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoProd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProGuardar
            // 
            this.btnProGuardar.Location = new System.Drawing.Point(12, 52);
            this.btnProGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProGuardar.Name = "btnProGuardar";
            this.btnProGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnProGuardar.TabIndex = 0;
            this.btnProGuardar.Text = "Guardar";
            this.btnProGuardar.UseVisualStyleBackColor = true;
            this.btnProGuardar.Click += new System.EventHandler(this.btnProGuardar_Click);
            // 
            // TxtmodtipPro
            // 
            this.TxtmodtipPro.Location = new System.Drawing.Point(12, 14);
            this.TxtmodtipPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtmodtipPro.Name = "TxtmodtipPro";
            this.TxtmodtipPro.Size = new System.Drawing.Size(237, 22);
            this.TxtmodtipPro.TabIndex = 1;
            // 
            // dgvTipoProd
            // 
            this.dgvTipoProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoProd.Location = new System.Drawing.Point(16, 104);
            this.dgvTipoProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTipoProd.Name = "dgvTipoProd";
            this.dgvTipoProd.RowHeadersWidth = 51;
            this.dgvTipoProd.RowTemplate.Height = 24;
            this.dgvTipoProd.Size = new System.Drawing.Size(233, 407);
            this.dgvTipoProd.TabIndex = 2;
            // 
            // BtnProEditar
            // 
            this.BtnProEditar.Location = new System.Drawing.Point(93, 52);
            this.BtnProEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProEditar.Name = "BtnProEditar";
            this.BtnProEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnProEditar.TabIndex = 3;
            this.BtnProEditar.Text = "Editar";
            this.BtnProEditar.UseVisualStyleBackColor = true;
            // 
            // BtnProSalir
            // 
            this.BtnProSalir.Location = new System.Drawing.Point(173, 52);
            this.BtnProSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProSalir.Name = "BtnProSalir";
            this.BtnProSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnProSalir.TabIndex = 4;
            this.BtnProSalir.Text = "Salir";
            this.BtnProSalir.UseVisualStyleBackColor = true;
            this.BtnProSalir.Click += new System.EventHandler(this.BtnProSalir_Click);
            // 
            // FormTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 545);
            this.Controls.Add(this.BtnProSalir);
            this.Controls.Add(this.BtnProEditar);
            this.Controls.Add(this.dgvTipoProd);
            this.Controls.Add(this.TxtmodtipPro);
            this.Controls.Add(this.btnProGuardar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTipoProducto";
            this.Text = "FormTipoProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProGuardar;
        private System.Windows.Forms.TextBox TxtmodtipPro;
        private System.Windows.Forms.DataGridView dgvTipoProd;
        private System.Windows.Forms.Button BtnProEditar;
        private System.Windows.Forms.Button BtnProSalir;
    }
}