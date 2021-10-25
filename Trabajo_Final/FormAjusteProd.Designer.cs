
namespace Trabajo_Final
{
    partial class FormAjusteProd
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
            this.components = new System.ComponentModel.Container();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtExistencia = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmbEntrada = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 12);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(1037, 271);
            this.dgv1.TabIndex = 0;
            this.dgv1.DoubleClick += new System.EventHandler(this.dgv1_DoubleClick);
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv2.Location = new System.Drawing.Point(12, 364);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 24;
            this.dgv2.Size = new System.Drawing.Size(1037, 150);
            this.dgv2.TabIndex = 1;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(1105, 23);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(98, 32);
            this.BtnActualizar.TabIndex = 2;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(13, 326);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(160, 22);
            this.txtDescripcion.TabIndex = 3;
            // 
            // TxtExistencia
            // 
            this.TxtExistencia.Location = new System.Drawing.Point(191, 326);
            this.TxtExistencia.Name = "TxtExistencia";
            this.TxtExistencia.ReadOnly = true;
            this.TxtExistencia.Size = new System.Drawing.Size(100, 22);
            this.TxtExistencia.TabIndex = 4;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(477, 328);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 22);
            this.TxtCantidad.TabIndex = 6;
            this.TxtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cantidad_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Existencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CmbEntrada
            // 
            this.CmbEntrada.FormattingEnabled = true;
            this.CmbEntrada.Items.AddRange(new object[] {
            "Entrada",
            "Salida"});
            this.CmbEntrada.Location = new System.Drawing.Point(319, 326);
            this.CmbEntrada.Name = "CmbEntrada";
            this.CmbEntrada.Size = new System.Drawing.Size(121, 24);
            this.CmbEntrada.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tipo";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Descripción";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Existencia";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tipo";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ajustada";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // FormAjusteProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 526);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbEntrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtExistencia);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgv1);
            this.Name = "FormAjusteProd";
            this.Text = "FormAjusteProd";
            this.Load += new System.EventHandler(this.FormAjusteProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox TxtExistencia;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox CmbEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label3;
    }
}