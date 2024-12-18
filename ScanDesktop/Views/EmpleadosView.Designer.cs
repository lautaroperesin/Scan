﻿namespace ScanDesktop.Views
{
    partial class EmpleadosView
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
            tabEmpleados = new TabControl();
            tabListaEmpleados = new TabPage();
            iconBuscarEmpleado = new FontAwesome.Sharp.IconButton();
            txtBuscarEmpleado = new TextBox();
            label1 = new Label();
            iconEliminarEmpleado = new FontAwesome.Sharp.IconButton();
            iconEditarEmpleado = new FontAwesome.Sharp.IconButton();
            iconAgregarEmpleado = new FontAwesome.Sharp.IconButton();
            dataGridEmpleados = new DataGridView();
            tabAgregarEditarEmpleados = new TabPage();
            txtTelefonos = new TextBox();
            iconCancelar = new FontAwesome.Sharp.IconButton();
            iconGuardar = new FontAwesome.Sharp.IconButton();
            dateTimeFecha = new DateTimePicker();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            comboPuesto = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabEmpleados.SuspendLayout();
            tabListaEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEmpleados).BeginInit();
            tabAgregarEditarEmpleados.SuspendLayout();
            SuspendLayout();
            // 
            // tabEmpleados
            // 
            tabEmpleados.Controls.Add(tabListaEmpleados);
            tabEmpleados.Controls.Add(tabAgregarEditarEmpleados);
            tabEmpleados.Location = new Point(12, 50);
            tabEmpleados.Name = "tabEmpleados";
            tabEmpleados.SelectedIndex = 0;
            tabEmpleados.Size = new Size(856, 403);
            tabEmpleados.TabIndex = 0;
            // 
            // tabListaEmpleados
            // 
            tabListaEmpleados.Controls.Add(iconBuscarEmpleado);
            tabListaEmpleados.Controls.Add(txtBuscarEmpleado);
            tabListaEmpleados.Controls.Add(label1);
            tabListaEmpleados.Controls.Add(iconEliminarEmpleado);
            tabListaEmpleados.Controls.Add(iconEditarEmpleado);
            tabListaEmpleados.Controls.Add(iconAgregarEmpleado);
            tabListaEmpleados.Controls.Add(dataGridEmpleados);
            tabListaEmpleados.Location = new Point(4, 29);
            tabListaEmpleados.Name = "tabListaEmpleados";
            tabListaEmpleados.Padding = new Padding(3);
            tabListaEmpleados.Size = new Size(848, 370);
            tabListaEmpleados.TabIndex = 0;
            tabListaEmpleados.Text = "Lista de empleados";
            tabListaEmpleados.UseVisualStyleBackColor = true;
            // 
            // iconBuscarEmpleado
            // 
            iconBuscarEmpleado.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBuscarEmpleado.IconColor = Color.Black;
            iconBuscarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBuscarEmpleado.Location = new Point(611, 14);
            iconBuscarEmpleado.Name = "iconBuscarEmpleado";
            iconBuscarEmpleado.Size = new Size(94, 29);
            iconBuscarEmpleado.TabIndex = 6;
            iconBuscarEmpleado.Text = "Buscar";
            iconBuscarEmpleado.UseVisualStyleBackColor = true;
            iconBuscarEmpleado.Click += iconBuscarEmpleado_Click;
            // 
            // txtBuscarEmpleado
            // 
            txtBuscarEmpleado.Location = new Point(67, 16);
            txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            txtBuscarEmpleado.Size = new Size(517, 27);
            txtBuscarEmpleado.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 4;
            label1.Text = "Buscar:";
            // 
            // iconEliminarEmpleado
            // 
            iconEliminarEmpleado.IconChar = FontAwesome.Sharp.IconChar.None;
            iconEliminarEmpleado.IconColor = Color.Black;
            iconEliminarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEliminarEmpleado.Location = new Point(727, 213);
            iconEliminarEmpleado.Name = "iconEliminarEmpleado";
            iconEliminarEmpleado.Size = new Size(94, 29);
            iconEliminarEmpleado.TabIndex = 3;
            iconEliminarEmpleado.Text = "Eliminar";
            iconEliminarEmpleado.UseVisualStyleBackColor = true;
            iconEliminarEmpleado.Click += iconEliminarEmpleado_Click;
            // 
            // iconEditarEmpleado
            // 
            iconEditarEmpleado.IconChar = FontAwesome.Sharp.IconChar.None;
            iconEditarEmpleado.IconColor = Color.Black;
            iconEditarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEditarEmpleado.Location = new Point(727, 149);
            iconEditarEmpleado.Name = "iconEditarEmpleado";
            iconEditarEmpleado.Size = new Size(94, 29);
            iconEditarEmpleado.TabIndex = 2;
            iconEditarEmpleado.Text = "Editar";
            iconEditarEmpleado.UseVisualStyleBackColor = true;
            iconEditarEmpleado.Click += iconEditarEmpleado_Click;
            // 
            // iconAgregarEmpleado
            // 
            iconAgregarEmpleado.IconChar = FontAwesome.Sharp.IconChar.None;
            iconAgregarEmpleado.IconColor = Color.Black;
            iconAgregarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAgregarEmpleado.Location = new Point(727, 79);
            iconAgregarEmpleado.Name = "iconAgregarEmpleado";
            iconAgregarEmpleado.Size = new Size(94, 29);
            iconAgregarEmpleado.TabIndex = 1;
            iconAgregarEmpleado.Text = "Agregar";
            iconAgregarEmpleado.UseVisualStyleBackColor = true;
            iconAgregarEmpleado.Click += iconAgregarEmpleado_Click;
            // 
            // dataGridEmpleados
            // 
            dataGridEmpleados.AllowUserToAddRows = false;
            dataGridEmpleados.AllowUserToDeleteRows = false;
            dataGridEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmpleados.Location = new Point(6, 58);
            dataGridEmpleados.Name = "dataGridEmpleados";
            dataGridEmpleados.ReadOnly = true;
            dataGridEmpleados.RowHeadersWidth = 51;
            dataGridEmpleados.Size = new Size(699, 286);
            dataGridEmpleados.TabIndex = 0;
            // 
            // tabAgregarEditarEmpleados
            // 
            tabAgregarEditarEmpleados.Controls.Add(txtTelefonos);
            tabAgregarEditarEmpleados.Controls.Add(iconCancelar);
            tabAgregarEditarEmpleados.Controls.Add(iconGuardar);
            tabAgregarEditarEmpleados.Controls.Add(dateTimeFecha);
            tabAgregarEditarEmpleados.Controls.Add(txtCorreo);
            tabAgregarEditarEmpleados.Controls.Add(txtNombre);
            tabAgregarEditarEmpleados.Controls.Add(label6);
            tabAgregarEditarEmpleados.Controls.Add(comboPuesto);
            tabAgregarEditarEmpleados.Controls.Add(label5);
            tabAgregarEditarEmpleados.Controls.Add(label4);
            tabAgregarEditarEmpleados.Controls.Add(label3);
            tabAgregarEditarEmpleados.Controls.Add(label2);
            tabAgregarEditarEmpleados.Location = new Point(4, 29);
            tabAgregarEditarEmpleados.Name = "tabAgregarEditarEmpleados";
            tabAgregarEditarEmpleados.Padding = new Padding(3);
            tabAgregarEditarEmpleados.Size = new Size(848, 370);
            tabAgregarEditarEmpleados.TabIndex = 1;
            tabAgregarEditarEmpleados.Text = "Agregar/Editar";
            tabAgregarEditarEmpleados.UseVisualStyleBackColor = true;
            // 
            // txtTelefonos
            // 
            txtTelefonos.Location = new Point(211, 83);
            txtTelefonos.Name = "txtTelefonos";
            txtTelefonos.Size = new Size(125, 27);
            txtTelefonos.TabIndex = 13;
            // 
            // iconCancelar
            // 
            iconCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconCancelar.IconColor = Color.Black;
            iconCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCancelar.Location = new Point(668, 324);
            iconCancelar.Name = "iconCancelar";
            iconCancelar.Size = new Size(94, 29);
            iconCancelar.TabIndex = 12;
            iconCancelar.Text = "Cancelar";
            iconCancelar.UseVisualStyleBackColor = true;
            iconCancelar.Click += iconCancelar_Click;
            // 
            // iconGuardar
            // 
            iconGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconGuardar.IconColor = Color.Black;
            iconGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconGuardar.Location = new Point(526, 324);
            iconGuardar.Name = "iconGuardar";
            iconGuardar.Size = new Size(94, 29);
            iconGuardar.TabIndex = 11;
            iconGuardar.Text = "Guardar";
            iconGuardar.UseVisualStyleBackColor = true;
            iconGuardar.Click += iconGuardar_Click;
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Format = DateTimePickerFormat.Short;
            dateTimeFecha.Location = new Point(277, 183);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(250, 27);
            dateTimeFecha.TabIndex = 9;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(211, 130);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(211, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(119, 262);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 6;
            label6.Text = "Puesto:";
            // 
            // comboPuesto
            // 
            comboPuesto.FormattingEnabled = true;
            comboPuesto.Location = new Point(211, 259);
            comboPuesto.Name = "comboPuesto";
            comboPuesto.Size = new Size(151, 28);
            comboPuesto.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 188);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 4;
            label5.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 133);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 86);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 39);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // EmpleadosView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 465);
            Controls.Add(tabEmpleados);
            Name = "EmpleadosView";
            Text = "EmpleadosView";
            tabEmpleados.ResumeLayout(false);
            tabListaEmpleados.ResumeLayout(false);
            tabListaEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEmpleados).EndInit();
            tabAgregarEditarEmpleados.ResumeLayout(false);
            tabAgregarEditarEmpleados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabEmpleados;
        private TabPage tabListaEmpleados;
        private TabPage tabAgregarEditarEmpleados;
        private DataGridView dataGridEmpleados;
        private FontAwesome.Sharp.IconButton iconEliminarEmpleado;
        private FontAwesome.Sharp.IconButton iconEditarEmpleado;
        private FontAwesome.Sharp.IconButton iconAgregarEmpleado;
        private TextBox txtBuscarEmpleado;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconBuscarEmpleado;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private Label label6;
        private ComboBox comboPuesto;
        private DateTimePicker dateTimeFecha;
        private FontAwesome.Sharp.IconButton iconCancelar;
        private FontAwesome.Sharp.IconButton iconGuardar;
        private TextBox txtTelefonos;
    }
}