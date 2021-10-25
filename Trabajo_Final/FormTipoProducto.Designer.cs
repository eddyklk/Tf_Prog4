
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
            this.BtnProConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtmodIdtipPro = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoProd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProGuardar
            // 
            this.btnProGuardar.Location = new System.Drawing.Point(320, 25);
            this.btnProGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnProGuardar.Name = "btnProGuardar";
            this.btnProGuardar.Size = new System.Drawing.Size(56, 19);
            this.btnProGuardar.TabIndex = 0;
            this.btnProGuardar.Text = "Guardar";
            this.btnProGuardar.UseVisualStyleBackColor = true;
            this.btnProGuardar.Click += new System.EventHandler(this.btnProGuardar_Click);
            // 
            // TxtmodtipPro
            // 
            this.TxtmodtipPro.Location = new System.Drawing.Point(128, 86);
            this.TxtmodtipPro.Margin = new System.Windows.Forms.Padding(2);
            this.TxtmodtipPro.Name = "TxtmodtipPro";
            this.TxtmodtipPro.Size = new System.Drawing.Size(179, 20);
            this.TxtmodtipPro.TabIndex = 1;
            // 
            // dgvTipoProd
            // 
            this.dgvTipoProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoProd.Location = new System.Drawing.Point(12, 110);
            this.dgvTipoProd.Name = "dgvTipoProd";
            this.dgvTipoProd.RowHeadersWidth = 51;
            this.dgvTipoProd.RowTemplate.Height = 24;
            this.dgvTipoProd.Size = new System.Drawing.Size(862, 175);
            this.dgvTipoProd.TabIndex = 2;
            // 
            // BtnProEditar
            // 
            this.BtnProEditar.Location = new System.Drawing.Point(320, 65);
            this.BtnProEditar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnProEditar.Name = "BtnProEditar";
            this.BtnProEditar.Size = new System.Drawing.Size(56, 19);
            this.BtnProEditar.TabIndex = 3;
            this.BtnProEditar.Text = "Editar";
            this.BtnProEditar.UseVisualStyleBackColor = true;
            this.BtnProEditar.Click += new System.EventHandler(this.BtnProEditar_Click);
            // 
            // BtnProSalir
            // 
            this.BtnProSalir.Location = new System.Drawing.Point(320, 85);
            this.BtnProSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnProSalir.Name = "BtnProSalir";
            this.BtnProSalir.Size = new System.Drawing.Size(56, 19);
            this.BtnProSalir.TabIndex = 4;
            this.BtnProSalir.Text = "Salir";
            this.BtnProSalir.UseVisualStyleBackColor = true;
            this.BtnProSalir.Click += new System.EventHandler(this.BtnProSalir_Click);
            // 
            // BtnProConsultar
            // 
            this.BtnProConsultar.Location = new System.Drawing.Point(320, 2);
            this.BtnProConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnProConsultar.Name = "BtnProConsultar";
            this.BtnProConsultar.Size = new System.Drawing.Size(63, 19);
            this.BtnProConsultar.TabIndex = 5;
            this.BtnProConsultar.Text = "Actualizar";
            this.BtnProConsultar.UseVisualStyleBackColor = true;
            this.BtnProConsultar.Click += new System.EventHandler(this.BtnProConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre Tipo Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Id";
            // 
            // TxtmodIdtipPro
            // 
            this.TxtmodIdtipPro.Enabled = false;
            this.TxtmodIdtipPro.Location = new System.Drawing.Point(128, 62);
            this.TxtmodIdtipPro.Margin = new System.Windows.Forms.Padding(2);
            this.TxtmodIdtipPro.Name = "TxtmodIdtipPro";
            this.TxtmodIdtipPro.Size = new System.Drawing.Size(73, 20);
            this.TxtmodIdtipPro.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 46);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 19;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 296);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtmodIdtipPro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnProConsultar);
            this.Controls.Add(this.BtnProSalir);
            this.Controls.Add(this.BtnProEditar);
            this.Controls.Add(this.dgvTipoProd);
            this.Controls.Add(this.TxtmodtipPro);
            this.Controls.Add(this.btnProGuardar);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button BtnProConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtmodIdtipPro;
        private System.Windows.Forms.Button button2;
    }
}