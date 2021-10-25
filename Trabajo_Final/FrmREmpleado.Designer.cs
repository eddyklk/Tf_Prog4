
namespace Trabajo_Final
{
    partial class FrmREmpleado
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.TxtIdEmp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvRegArt = new System.Windows.Forms.DataGridView();
            this.TxtCelEmp = new System.Windows.Forms.TextBox();
            this.TxtTelEmp = new System.Windows.Forms.TextBox();
            this.TxtDirecEmp = new System.Windows.Forms.TextBox();
            this.TxtApeEmp = new System.Windows.Forms.TextBox();
            this.TxtNomEmp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIdTipoEmpl = new System.Windows.Forms.ComboBox();
            this.cbEstadoEmp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegArt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(593, 7);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(66, 19);
            this.btnActualizar.TabIndex = 47;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // TxtIdEmp
            // 
            this.TxtIdEmp.Enabled = false;
            this.TxtIdEmp.Location = new System.Drawing.Point(85, 4);
            this.TxtIdEmp.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIdEmp.Name = "TxtIdEmp";
            this.TxtIdEmp.Size = new System.Drawing.Size(90, 20);
            this.TxtIdEmp.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Id";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(593, 101);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 19);
            this.btnSalir.TabIndex = 44;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(593, 77);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(56, 19);
            this.btnEditar.TabIndex = 43;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(593, 54);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(56, 19);
            this.btnLimpiar.TabIndex = 42;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(593, 30);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 19);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvRegArt
            // 
            this.dgvRegArt.AllowUserToAddRows = false;
            this.dgvRegArt.AllowUserToDeleteRows = false;
            this.dgvRegArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegArt.Location = new System.Drawing.Point(11, 132);
            this.dgvRegArt.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRegArt.Name = "dgvRegArt";
            this.dgvRegArt.ReadOnly = true;
            this.dgvRegArt.RowHeadersWidth = 51;
            this.dgvRegArt.RowTemplate.Height = 24;
            this.dgvRegArt.Size = new System.Drawing.Size(914, 229);
            this.dgvRegArt.TabIndex = 40;
            // 
            // TxtCelEmp
            // 
            this.TxtCelEmp.Location = new System.Drawing.Point(388, 28);
            this.TxtCelEmp.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCelEmp.Name = "TxtCelEmp";
            this.TxtCelEmp.Size = new System.Drawing.Size(163, 20);
            this.TxtCelEmp.TabIndex = 37;
            // 
            // TxtTelEmp
            // 
            this.TxtTelEmp.Location = new System.Drawing.Point(85, 98);
            this.TxtTelEmp.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTelEmp.Name = "TxtTelEmp";
            this.TxtTelEmp.Size = new System.Drawing.Size(169, 20);
            this.TxtTelEmp.TabIndex = 36;
            // 
            // TxtDirecEmp
            // 
            this.TxtDirecEmp.Location = new System.Drawing.Point(85, 75);
            this.TxtDirecEmp.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDirecEmp.Name = "TxtDirecEmp";
            this.TxtDirecEmp.Size = new System.Drawing.Size(169, 20);
            this.TxtDirecEmp.TabIndex = 35;
            // 
            // TxtApeEmp
            // 
            this.TxtApeEmp.Location = new System.Drawing.Point(85, 51);
            this.TxtApeEmp.Margin = new System.Windows.Forms.Padding(2);
            this.TxtApeEmp.Name = "TxtApeEmp";
            this.TxtApeEmp.Size = new System.Drawing.Size(169, 20);
            this.TxtApeEmp.TabIndex = 34;
            // 
            // TxtNomEmp
            // 
            this.TxtNomEmp.Location = new System.Drawing.Point(85, 28);
            this.TxtNomEmp.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNomEmp.Name = "TxtNomEmp";
            this.TxtNomEmp.Size = new System.Drawing.Size(169, 20);
            this.TxtNomEmp.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tipo Empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombres";
            // 
            // cbIdTipoEmpl
            // 
            this.cbIdTipoEmpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdTipoEmpl.FormattingEnabled = true;
            this.cbIdTipoEmpl.Location = new System.Drawing.Point(388, 54);
            this.cbIdTipoEmpl.Name = "cbIdTipoEmpl";
            this.cbIdTipoEmpl.Size = new System.Drawing.Size(163, 21);
            this.cbIdTipoEmpl.TabIndex = 48;
            // 
            // cbEstadoEmp
            // 
            this.cbEstadoEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoEmp.FormattingEnabled = true;
            this.cbEstadoEmp.Location = new System.Drawing.Point(388, 81);
            this.cbEstadoEmp.Name = "cbEstadoEmp";
            this.cbEstadoEmp.Size = new System.Drawing.Size(163, 21);
            this.cbEstadoEmp.TabIndex = 49;
            // 
            // FrmREmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 366);
            this.Controls.Add(this.cbEstadoEmp);
            this.Controls.Add(this.cbIdTipoEmpl);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.TxtIdEmp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvRegArt);
            this.Controls.Add(this.TxtCelEmp);
            this.Controls.Add(this.TxtTelEmp);
            this.Controls.Add(this.TxtDirecEmp);
            this.Controls.Add(this.TxtApeEmp);
            this.Controls.Add(this.TxtNomEmp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmREmpleado";
            this.Text = "FrmREmpleado";
            this.Load += new System.EventHandler(this.FrmREmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox TxtIdEmp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvRegArt;
        private System.Windows.Forms.TextBox TxtCelEmp;
        private System.Windows.Forms.TextBox TxtTelEmp;
        private System.Windows.Forms.TextBox TxtDirecEmp;
        private System.Windows.Forms.TextBox TxtApeEmp;
        private System.Windows.Forms.TextBox TxtNomEmp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIdTipoEmpl;
        private System.Windows.Forms.ComboBox cbEstadoEmp;
    }
}