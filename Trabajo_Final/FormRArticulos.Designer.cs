
namespace Trabajo_Final
{
    partial class FormRArticulos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbTipoProd = new System.Windows.Forms.ComboBox();
            this.TxtNomProd = new System.Windows.Forms.TextBox();
            this.TxtUbicaProd = new System.Windows.Forms.TextBox();
            this.TxtCostoProd = new System.Windows.Forms.TextBox();
            this.TxtPrecioProd = new System.Windows.Forms.TextBox();
            this.TxtCantMin = new System.Windows.Forms.TextBox();
            this.TxtCantMax = new System.Windows.Forms.TextBox();
            this.TxtExistencia = new System.Windows.Forms.TextBox();
            this.dgvRegArt = new System.Windows.Forms.DataGridView();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnRASalir = new System.Windows.Forms.Button();
            this.TxtIdProd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegArt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ubicación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad Minima";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad Maxima";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Existencia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 109);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tipo de Producto";
            // 
            // CmbTipoProd
            // 
            this.CmbTipoProd.FormattingEnabled = true;
            this.CmbTipoProd.Location = new System.Drawing.Point(386, 106);
            this.CmbTipoProd.Margin = new System.Windows.Forms.Padding(2);
            this.CmbTipoProd.Name = "CmbTipoProd";
            this.CmbTipoProd.Size = new System.Drawing.Size(125, 21);
            this.CmbTipoProd.TabIndex = 8;
            this.CmbTipoProd.SelectedIndexChanged += new System.EventHandler(this.CmbTipoProd_SelectedIndexChanged);
            // 
            // TxtNomProd
            // 
            this.TxtNomProd.Location = new System.Drawing.Point(83, 36);
            this.TxtNomProd.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNomProd.Name = "TxtNomProd";
            this.TxtNomProd.Size = new System.Drawing.Size(169, 20);
            this.TxtNomProd.TabIndex = 9;
            // 
            // TxtUbicaProd
            // 
            this.TxtUbicaProd.Location = new System.Drawing.Point(83, 59);
            this.TxtUbicaProd.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUbicaProd.Name = "TxtUbicaProd";
            this.TxtUbicaProd.Size = new System.Drawing.Size(169, 20);
            this.TxtUbicaProd.TabIndex = 10;
            // 
            // TxtCostoProd
            // 
            this.TxtCostoProd.Location = new System.Drawing.Point(83, 83);
            this.TxtCostoProd.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCostoProd.Name = "TxtCostoProd";
            this.TxtCostoProd.Size = new System.Drawing.Size(90, 20);
            this.TxtCostoProd.TabIndex = 11;
            // 
            // TxtPrecioProd
            // 
            this.TxtPrecioProd.Location = new System.Drawing.Point(83, 106);
            this.TxtPrecioProd.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPrecioProd.Name = "TxtPrecioProd";
            this.TxtPrecioProd.Size = new System.Drawing.Size(90, 20);
            this.TxtPrecioProd.TabIndex = 12;
            // 
            // TxtCantMin
            // 
            this.TxtCantMin.Location = new System.Drawing.Point(386, 36);
            this.TxtCantMin.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCantMin.Name = "TxtCantMin";
            this.TxtCantMin.Size = new System.Drawing.Size(76, 20);
            this.TxtCantMin.TabIndex = 13;
            // 
            // TxtCantMax
            // 
            this.TxtCantMax.Location = new System.Drawing.Point(386, 59);
            this.TxtCantMax.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCantMax.Name = "TxtCantMax";
            this.TxtCantMax.Size = new System.Drawing.Size(76, 20);
            this.TxtCantMax.TabIndex = 14;
            // 
            // TxtExistencia
            // 
            this.TxtExistencia.Location = new System.Drawing.Point(386, 83);
            this.TxtExistencia.Margin = new System.Windows.Forms.Padding(2);
            this.TxtExistencia.Name = "TxtExistencia";
            this.TxtExistencia.Size = new System.Drawing.Size(76, 20);
            this.TxtExistencia.TabIndex = 15;
            // 
            // dgvRegArt
            // 
            this.dgvRegArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegArt.Location = new System.Drawing.Point(12, 142);
            this.dgvRegArt.Name = "dgvRegArt";
            this.dgvRegArt.Size = new System.Drawing.Size(908, 217);
            this.dgvRegArt.TabIndex = 24;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(515, 39);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(56, 19);
            this.BtnGuardar.TabIndex = 17;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 62);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 18;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(515, 85);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(56, 19);
            this.BtnEditar.TabIndex = 19;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnRASalir
            // 
            this.BtnRASalir.Location = new System.Drawing.Point(515, 109);
            this.BtnRASalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRASalir.Name = "BtnRASalir";
            this.BtnRASalir.Size = new System.Drawing.Size(56, 19);
            this.BtnRASalir.TabIndex = 20;
            this.BtnRASalir.Text = "Salir";
            this.BtnRASalir.UseVisualStyleBackColor = true;
            this.BtnRASalir.Click += new System.EventHandler(this.BtnRASalir_Click);
            // 
            // TxtIdProd
            // 
            this.TxtIdProd.Enabled = false;
            this.TxtIdProd.Location = new System.Drawing.Point(83, 12);
            this.TxtIdProd.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIdProd.Name = "TxtIdProd";
            this.TxtIdProd.Size = new System.Drawing.Size(90, 20);
            this.TxtIdProd.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Id";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(515, 15);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(66, 19);
            this.btnActualizar.TabIndex = 23;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.BtnRAConsultar_Click);
            // 
            // FormRArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 371);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.TxtIdProd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnRASalir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.dgvRegArt);
            this.Controls.Add(this.TxtExistencia);
            this.Controls.Add(this.TxtCantMax);
            this.Controls.Add(this.TxtCantMin);
            this.Controls.Add(this.TxtPrecioProd);
            this.Controls.Add(this.TxtCostoProd);
            this.Controls.Add(this.TxtUbicaProd);
            this.Controls.Add(this.TxtNomProd);
            this.Controls.Add(this.CmbTipoProd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRArticulos";
            this.Text = "Registrar Articulo";
            this.Load += new System.EventHandler(this.FormRArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbTipoProd;
        private System.Windows.Forms.TextBox TxtNomProd;
        private System.Windows.Forms.TextBox TxtUbicaProd;
        private System.Windows.Forms.TextBox TxtCostoProd;
        private System.Windows.Forms.TextBox TxtPrecioProd;
        private System.Windows.Forms.TextBox TxtCantMin;
        private System.Windows.Forms.TextBox TxtCantMax;
        private System.Windows.Forms.TextBox TxtExistencia;
        private System.Windows.Forms.DataGridView dgvRegArt;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnRASalir;
        private System.Windows.Forms.TextBox TxtIdProd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnActualizar;
    }
}