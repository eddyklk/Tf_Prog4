
namespace Trabajo_Final
{
    partial class FormRClientes
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
            this.BtnRASalir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.dgvRegArt = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtExistencia = new System.Windows.Forms.TextBox();
            this.TxtCantMax = new System.Windows.Forms.TextBox();
            this.TxtCantMin = new System.Windows.Forms.TextBox();
            this.TxtPrecioProd = new System.Windows.Forms.TextBox();
            this.TxtCostoProd = new System.Windows.Forms.TextBox();
            this.TxtUbicaProd = new System.Windows.Forms.TextBox();
            this.TxtNomProd = new System.Windows.Forms.TextBox();
            this.CmbTipoProd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegArt)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRASalir
            // 
            this.BtnRASalir.Location = new System.Drawing.Point(614, 102);
            this.BtnRASalir.Name = "BtnRASalir";
            this.BtnRASalir.Size = new System.Drawing.Size(75, 23);
            this.BtnRASalir.TabIndex = 41;
            this.BtnRASalir.Text = "Salir";
            this.BtnRASalir.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(614, 73);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 40;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(614, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(614, 15);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 38;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // dgvRegArt
            // 
            this.dgvRegArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegArt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvRegArt.Location = new System.Drawing.Point(13, 140);
            this.dgvRegArt.Name = "dgvRegArt";
            this.dgvRegArt.RowHeadersWidth = 51;
            this.dgvRegArt.RowTemplate.Height = 24;
            this.dgvRegArt.Size = new System.Drawing.Size(1219, 282);
            this.dgvRegArt.TabIndex = 37;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ubicación";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Costo";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cant. Minima";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cant. Maxina";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Existencia";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tipo De Producto";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // TxtExistencia
            // 
            this.TxtExistencia.Location = new System.Drawing.Point(442, 70);
            this.TxtExistencia.Name = "TxtExistencia";
            this.TxtExistencia.Size = new System.Drawing.Size(100, 22);
            this.TxtExistencia.TabIndex = 36;
            // 
            // TxtCantMax
            // 
            this.TxtCantMax.Location = new System.Drawing.Point(442, 41);
            this.TxtCantMax.Name = "TxtCantMax";
            this.TxtCantMax.Size = new System.Drawing.Size(100, 22);
            this.TxtCantMax.TabIndex = 35;
            // 
            // TxtCantMin
            // 
            this.TxtCantMin.Location = new System.Drawing.Point(442, 12);
            this.TxtCantMin.Name = "TxtCantMin";
            this.TxtCantMin.Size = new System.Drawing.Size(100, 22);
            this.TxtCantMin.TabIndex = 34;
            // 
            // TxtPrecioProd
            // 
            this.TxtPrecioProd.Location = new System.Drawing.Point(38, 99);
            this.TxtPrecioProd.Name = "TxtPrecioProd";
            this.TxtPrecioProd.Size = new System.Drawing.Size(118, 22);
            this.TxtPrecioProd.TabIndex = 33;
            // 
            // TxtCostoProd
            // 
            this.TxtCostoProd.Location = new System.Drawing.Point(38, 70);
            this.TxtCostoProd.Name = "TxtCostoProd";
            this.TxtCostoProd.Size = new System.Drawing.Size(118, 22);
            this.TxtCostoProd.TabIndex = 32;
            // 
            // TxtUbicaProd
            // 
            this.TxtUbicaProd.Location = new System.Drawing.Point(38, 41);
            this.TxtUbicaProd.Name = "TxtUbicaProd";
            this.TxtUbicaProd.Size = new System.Drawing.Size(224, 22);
            this.TxtUbicaProd.TabIndex = 31;
            // 
            // TxtNomProd
            // 
            this.TxtNomProd.Location = new System.Drawing.Point(38, 12);
            this.TxtNomProd.Name = "TxtNomProd";
            this.TxtNomProd.Size = new System.Drawing.Size(224, 22);
            this.TxtNomProd.TabIndex = 30;
            // 
            // CmbTipoProd
            // 
            this.CmbTipoProd.FormattingEnabled = true;
            this.CmbTipoProd.Location = new System.Drawing.Point(442, 99);
            this.CmbTipoProd.Name = "CmbTipoProd";
            this.CmbTipoProd.Size = new System.Drawing.Size(121, 24);
            this.CmbTipoProd.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Tipo de Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Existencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Cantidad Maxima";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cantidad Minima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-189, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-189, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Costo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-189, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ubicación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-189, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre";
            // 
            // FormRClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
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
            this.Name = "FormRClientes";
            this.Text = "FormRClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRASalir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView dgvRegArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox TxtExistencia;
        private System.Windows.Forms.TextBox TxtCantMax;
        private System.Windows.Forms.TextBox TxtCantMin;
        private System.Windows.Forms.TextBox TxtPrecioProd;
        private System.Windows.Forms.TextBox TxtCostoProd;
        private System.Windows.Forms.TextBox TxtUbicaProd;
        private System.Windows.Forms.TextBox TxtNomProd;
        private System.Windows.Forms.ComboBox CmbTipoProd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}