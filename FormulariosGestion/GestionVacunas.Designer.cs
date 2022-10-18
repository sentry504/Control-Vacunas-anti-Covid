
namespace Control_Vacunas_anti_Covid
{
    partial class GestionVacunas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionVacunas));
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonValidar = new System.Windows.Forms.Button();
            this.textBoxRegistro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonCompras = new System.Windows.Forms.RadioButton();
            this.radioButtonDonaciones = new System.Windows.Forms.RadioButton();
            this.textBoxOrigen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.covid_Vacunas_DBDataSet = new Control_Vacunas_anti_Covid.Covid_Vacunas_DBDataSet();
            this.centrosAsistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.centros_AsistenciaTableAdapter = new Control_Vacunas_anti_Covid.Covid_Vacunas_DBDataSetTableAdapters.Centros_AsistenciaTableAdapter();
            this.comboBoxVacuna = new System.Windows.Forms.ComboBox();
            this.vacunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacunaTableAdapter = new Control_Vacunas_anti_Covid.Covid_Vacunas_DBDataSetTableAdapters.VacunaTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.covid_Vacunas_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centrosAsistenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fecha de Registro";
            // 
            // ButtonValidar
            // 
            this.ButtonValidar.Location = new System.Drawing.Point(213, 23);
            this.ButtonValidar.Name = "ButtonValidar";
            this.ButtonValidar.Size = new System.Drawing.Size(75, 23);
            this.ButtonValidar.TabIndex = 24;
            this.ButtonValidar.Text = "Validar";
            this.ButtonValidar.UseVisualStyleBackColor = true;
            this.ButtonValidar.Click += new System.EventHandler(this.buttonValidar_Click);
            // 
            // textBoxRegistro
            // 
            this.textBoxRegistro.Location = new System.Drawing.Point(98, 26);
            this.textBoxRegistro.Name = "textBoxRegistro";
            this.textBoxRegistro.Size = new System.Drawing.Size(109, 20);
            this.textBoxRegistro.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Registro";
            // 
            // dateTimePickerFechaRegistro
            // 
            this.dateTimePickerFechaRegistro.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerFechaRegistro.Enabled = false;
            this.dateTimePickerFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaRegistro.Location = new System.Drawing.Point(162, 59);
            this.dateTimePickerFechaRegistro.Name = "dateTimePickerFechaRegistro";
            this.dateTimePickerFechaRegistro.Size = new System.Drawing.Size(126, 20);
            this.dateTimePickerFechaRegistro.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Vacuna";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Enabled = false;
            this.textBoxCantidad.Location = new System.Drawing.Point(98, 119);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(73, 20);
            this.textBoxCantidad.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cantidad";
            // 
            // radioButtonCompras
            // 
            this.radioButtonCompras.AutoSize = true;
            this.radioButtonCompras.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonCompras.Enabled = false;
            this.radioButtonCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCompras.Location = new System.Drawing.Point(12, 28);
            this.radioButtonCompras.Name = "radioButtonCompras";
            this.radioButtonCompras.Size = new System.Drawing.Size(82, 21);
            this.radioButtonCompras.TabIndex = 32;
            this.radioButtonCompras.TabStop = true;
            this.radioButtonCompras.Text = "Compras";
            this.radioButtonCompras.UseVisualStyleBackColor = false;
            // 
            // radioButtonDonaciones
            // 
            this.radioButtonDonaciones.AutoSize = true;
            this.radioButtonDonaciones.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonDonaciones.Enabled = false;
            this.radioButtonDonaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDonaciones.Location = new System.Drawing.Point(114, 28);
            this.radioButtonDonaciones.Name = "radioButtonDonaciones";
            this.radioButtonDonaciones.Size = new System.Drawing.Size(101, 21);
            this.radioButtonDonaciones.TabIndex = 33;
            this.radioButtonDonaciones.TabStop = true;
            this.radioButtonDonaciones.Text = "Donaciones";
            this.radioButtonDonaciones.UseVisualStyleBackColor = false;
            // 
            // textBoxOrigen
            // 
            this.textBoxOrigen.Enabled = false;
            this.textBoxOrigen.Location = new System.Drawing.Point(98, 232);
            this.textBoxOrigen.Name = "textBoxOrigen";
            this.textBoxOrigen.Size = new System.Drawing.Size(286, 20);
            this.textBoxOrigen.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Origen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Destino";
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.DataSource = this.centrosAsistenciaBindingSource;
            this.comboBoxDestino.DisplayMember = "Nombre";
            this.comboBoxDestino.Enabled = false;
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(98, 266);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(286, 21);
            this.comboBoxDestino.TabIndex = 37;
            // 
            // covid_Vacunas_DBDataSet
            // 
            this.covid_Vacunas_DBDataSet.DataSetName = "Covid_Vacunas_DBDataSet";
            this.covid_Vacunas_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // centrosAsistenciaBindingSource
            // 
            this.centrosAsistenciaBindingSource.DataMember = "Centros_Asistencia";
            this.centrosAsistenciaBindingSource.DataSource = this.covid_Vacunas_DBDataSet;
            // 
            // centros_AsistenciaTableAdapter
            // 
            this.centros_AsistenciaTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxVacuna
            // 
            this.comboBoxVacuna.DataSource = this.vacunaBindingSource;
            this.comboBoxVacuna.DisplayMember = "ID_Vacuna";
            this.comboBoxVacuna.Enabled = false;
            this.comboBoxVacuna.FormattingEnabled = true;
            this.comboBoxVacuna.Location = new System.Drawing.Point(98, 88);
            this.comboBoxVacuna.Name = "comboBoxVacuna";
            this.comboBoxVacuna.Size = new System.Drawing.Size(73, 21);
            this.comboBoxVacuna.TabIndex = 38;
            // 
            // vacunaBindingSource
            // 
            this.vacunaBindingSource.DataMember = "Vacuna";
            this.vacunaBindingSource.DataSource = this.covid_Vacunas_DBDataSet;
            // 
            // vacunaTableAdapter
            // 
            this.vacunaTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButtonCompras);
            this.groupBox1.Controls.Add(this.radioButtonDonaciones);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 65);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de registro";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(327, 303);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(57, 23);
            this.buttonCancelar.TabIndex = 43;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Enabled = false;
            this.buttonEliminar.Location = new System.Drawing.Point(238, 303);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(64, 23);
            this.buttonEliminar.TabIndex = 42;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Enabled = false;
            this.buttonModificar.Location = new System.Drawing.Point(168, 303);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(64, 23);
            this.buttonModificar.TabIndex = 41;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Enabled = false;
            this.buttonAgregar.Location = new System.Drawing.Point(98, 303);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(64, 23);
            this.buttonAgregar.TabIndex = 40;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // GestionVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(416, 351);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxVacuna);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxOrigen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerFechaRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonValidar);
            this.Controls.Add(this.textBoxRegistro);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "GestionVacunas";
            this.ShowIcon = false;
            this.Text = "GestionVacunas";
            this.Load += new System.EventHandler(this.GestionVacunas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.covid_Vacunas_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centrosAsistenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonValidar;
        private System.Windows.Forms.TextBox textBoxRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonCompras;
        private System.Windows.Forms.RadioButton radioButtonDonaciones;
        private System.Windows.Forms.TextBox textBoxOrigen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private Covid_Vacunas_DBDataSet covid_Vacunas_DBDataSet;
        private System.Windows.Forms.BindingSource centrosAsistenciaBindingSource;
        private Covid_Vacunas_DBDataSetTableAdapters.Centros_AsistenciaTableAdapter centros_AsistenciaTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxVacuna;
        private System.Windows.Forms.BindingSource vacunaBindingSource;
        private Covid_Vacunas_DBDataSetTableAdapters.VacunaTableAdapter vacunaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonAgregar;
    }
}