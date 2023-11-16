﻿namespace PRYvarelaIE
{
    partial class frmRegistroProveedor
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
            this.dgvDatosRegistro = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbJuzgado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpApertura = new System.Windows.Forms.DateTimePicker();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.cmbJurisdiccion = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNumExpediente = new System.Windows.Forms.TextBox();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.txtNumeroRegistro = new System.Windows.Forms.TextBox();
            this.lblLiquidador = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblJuzgado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblApertura = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.lblNumeroRegistro = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.mrcRegistro = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRegistro)).BeginInit();
            this.mrcRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatosRegistro
            // 
            this.dgvDatosRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvDatosRegistro.Location = new System.Drawing.Point(-129, 225);
            this.dgvDatosRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatosRegistro.Name = "dgvDatosRegistro";
            this.dgvDatosRegistro.ReadOnly = true;
            this.dgvDatosRegistro.RowHeadersWidth = 51;
            this.dgvDatosRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosRegistro.Size = new System.Drawing.Size(1059, 272);
            this.dgvDatosRegistro.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nº";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Entidad";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apertura";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nº Expediente";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Juzgado";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Jurisdiccion";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Direccion";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Liquidador Responsable";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // cmbJuzgado
            // 
            this.cmbJuzgado.FormattingEnabled = true;
            this.cmbJuzgado.Location = new System.Drawing.Point(612, 41);
            this.cmbJuzgado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbJuzgado.Name = "cmbJuzgado";
            this.cmbJuzgado.Size = new System.Drawing.Size(220, 24);
            this.cmbJuzgado.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Jurisdiccion";
            // 
            // dtpApertura
            // 
            this.dtpApertura.Location = new System.Drawing.Point(103, 140);
            this.dtpApertura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpApertura.Name = "dtpApertura";
            this.dtpApertura.Size = new System.Drawing.Size(268, 22);
            this.dtpApertura.TabIndex = 15;
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Location = new System.Drawing.Point(612, 187);
            this.cmbResponsable.Margin = new System.Windows.Forms.Padding(4);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(220, 24);
            this.cmbResponsable.TabIndex = 14;
            // 
            // cmbJurisdiccion
            // 
            this.cmbJurisdiccion.FormattingEnabled = true;
            this.cmbJurisdiccion.Location = new System.Drawing.Point(612, 91);
            this.cmbJurisdiccion.Margin = new System.Windows.Forms.Padding(4);
            this.cmbJurisdiccion.Name = "cmbJurisdiccion";
            this.cmbJurisdiccion.Size = new System.Drawing.Size(220, 24);
            this.cmbJurisdiccion.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(612, 140);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(184, 22);
            this.txtDireccion.TabIndex = 13;
            // 
            // txtNumExpediente
            // 
            this.txtNumExpediente.Location = new System.Drawing.Point(103, 186);
            this.txtNumExpediente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumExpediente.Name = "txtNumExpediente";
            this.txtNumExpediente.Size = new System.Drawing.Size(184, 22);
            this.txtNumExpediente.TabIndex = 10;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(103, 95);
            this.txtEntidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(184, 22);
            this.txtEntidad.TabIndex = 8;
            // 
            // txtNumeroRegistro
            // 
            this.txtNumeroRegistro.Location = new System.Drawing.Point(103, 47);
            this.txtNumeroRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroRegistro.Name = "txtNumeroRegistro";
            this.txtNumeroRegistro.Size = new System.Drawing.Size(91, 22);
            this.txtNumeroRegistro.TabIndex = 7;
            // 
            // lblLiquidador
            // 
            this.lblLiquidador.AutoSize = true;
            this.lblLiquidador.Location = new System.Drawing.Point(488, 191);
            this.lblLiquidador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLiquidador.Name = "lblLiquidador";
            this.lblLiquidador.Size = new System.Drawing.Size(110, 16);
            this.lblLiquidador.TabIndex = 6;
            this.lblLiquidador.Text = "Liquidador Resp.";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(488, 144);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblJuzgado
            // 
            this.lblJuzgado.AutoSize = true;
            this.lblJuzgado.Location = new System.Drawing.Point(488, 41);
            this.lblJuzgado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJuzgado.Name = "lblJuzgado";
            this.lblJuzgado.Size = new System.Drawing.Size(59, 16);
            this.lblJuzgado.TabIndex = 4;
            this.lblJuzgado.Text = "Juzgado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nº Expe.";
            // 
            // lblApertura
            // 
            this.lblApertura.AutoSize = true;
            this.lblApertura.Location = new System.Drawing.Point(20, 143);
            this.lblApertura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(58, 16);
            this.lblApertura.TabIndex = 2;
            this.lblApertura.Text = "Apertura";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(830, -36);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(830, 25);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(830, 162);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 28);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.Location = new System.Drawing.Point(20, 98);
            this.lblEntidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(53, 16);
            this.lblEntidad.TabIndex = 1;
            this.lblEntidad.Text = "Entidad";
            // 
            // lblNumeroRegistro
            // 
            this.lblNumeroRegistro.AutoSize = true;
            this.lblNumeroRegistro.Location = new System.Drawing.Point(20, 47);
            this.lblNumeroRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroRegistro.Name = "lblNumeroRegistro";
            this.lblNumeroRegistro.Size = new System.Drawing.Size(22, 16);
            this.lblNumeroRegistro.TabIndex = 0;
            this.lblNumeroRegistro.Text = "Nº";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(830, 95);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // mrcRegistro
            // 
            this.mrcRegistro.Controls.Add(this.cmbJuzgado);
            this.mrcRegistro.Controls.Add(this.label1);
            this.mrcRegistro.Controls.Add(this.dtpApertura);
            this.mrcRegistro.Controls.Add(this.cmbResponsable);
            this.mrcRegistro.Controls.Add(this.cmbJurisdiccion);
            this.mrcRegistro.Controls.Add(this.txtDireccion);
            this.mrcRegistro.Controls.Add(this.txtNumExpediente);
            this.mrcRegistro.Controls.Add(this.txtEntidad);
            this.mrcRegistro.Controls.Add(this.txtNumeroRegistro);
            this.mrcRegistro.Controls.Add(this.lblLiquidador);
            this.mrcRegistro.Controls.Add(this.lblDireccion);
            this.mrcRegistro.Controls.Add(this.lblJuzgado);
            this.mrcRegistro.Controls.Add(this.label4);
            this.mrcRegistro.Controls.Add(this.lblApertura);
            this.mrcRegistro.Controls.Add(this.lblEntidad);
            this.mrcRegistro.Controls.Add(this.lblNumeroRegistro);
            this.mrcRegistro.Location = new System.Drawing.Point(-129, -47);
            this.mrcRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Padding = new System.Windows.Forms.Padding(4);
            this.mrcRegistro.Size = new System.Drawing.Size(937, 250);
            this.mrcRegistro.TabIndex = 7;
            this.mrcRegistro.TabStop = false;
            this.mrcRegistro.Text = "Registro";
            // 
            // frmRegistroProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 536);
            this.Controls.Add(this.dgvDatosRegistro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.mrcRegistro);
            this.Name = "frmRegistroProveedor";
            this.Text = "frmRegistroProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRegistro)).EndInit();
            this.mrcRegistro.ResumeLayout(false);
            this.mrcRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ComboBox cmbJuzgado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpApertura;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private System.Windows.Forms.ComboBox cmbJurisdiccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNumExpediente;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.TextBox txtNumeroRegistro;
        private System.Windows.Forms.Label lblLiquidador;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblJuzgado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.Label lblNumeroRegistro;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox mrcRegistro;
    }
}