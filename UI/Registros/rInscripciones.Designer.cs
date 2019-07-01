namespace RegistroUniversitario.UI.Registros
{
    partial class rInscripciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AgregarDetalleButton = new System.Windows.Forms.Button();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PrecioCreditoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AsignaturaComboBox = new System.Windows.Forms.ComboBox();
            this.EstudianteComboBox = new System.Windows.Forms.ComboBox();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.EliminarFilaButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioCreditoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(120, 30);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.IdNumericUpDown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "fecha";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(120, 56);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.FechaDateTimePicker.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MontoTextBox);
            this.groupBox1.Controls.Add(this.AsignaturaComboBox);
            this.groupBox1.Controls.Add(this.EliminarFilaButton);
            this.groupBox1.Controls.Add(this.AgregarDetalleButton);
            this.groupBox1.Controls.Add(this.DetalleDataGridView);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 314);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // AgregarDetalleButton
            // 
            this.AgregarDetalleButton.Location = new System.Drawing.Point(345, 34);
            this.AgregarDetalleButton.Name = "AgregarDetalleButton";
            this.AgregarDetalleButton.Size = new System.Drawing.Size(25, 23);
            this.AgregarDetalleButton.TabIndex = 6;
            this.AgregarDetalleButton.Text = "+";
            this.AgregarDetalleButton.UseVisualStyleBackColor = true;
            this.AgregarDetalleButton.Click += new System.EventHandler(this.AgregarDetalleButton_Click);
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(10, 74);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.Size = new System.Drawing.Size(370, 186);
            this.DetalleDataGridView.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "EstudianteId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "AsignaturaId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio Credito";
            // 
            // PrecioCreditoNumericUpDown
            // 
            this.PrecioCreditoNumericUpDown.Location = new System.Drawing.Point(120, 112);
            this.PrecioCreditoNumericUpDown.Name = "PrecioCreditoNumericUpDown";
            this.PrecioCreditoNumericUpDown.Size = new System.Drawing.Size(135, 20);
            this.PrecioCreditoNumericUpDown.TabIndex = 11;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // AsignaturaComboBox
            // 
            this.AsignaturaComboBox.FormattingEnabled = true;
            this.AsignaturaComboBox.Location = new System.Drawing.Point(95, 35);
            this.AsignaturaComboBox.Name = "AsignaturaComboBox";
            this.AsignaturaComboBox.Size = new System.Drawing.Size(121, 21);
            this.AsignaturaComboBox.TabIndex = 13;
            // 
            // EstudianteComboBox
            // 
            this.EstudianteComboBox.FormattingEnabled = true;
            this.EstudianteComboBox.Location = new System.Drawing.Point(120, 85);
            this.EstudianteComboBox.Name = "EstudianteComboBox";
            this.EstudianteComboBox.Size = new System.Drawing.Size(135, 21);
            this.EstudianteComboBox.TabIndex = 16;
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Location = new System.Drawing.Point(216, 280);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(100, 20);
            this.MontoTextBox.TabIndex = 14;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::RegistroUniversitario.Properties.Resources.delete2_file_icon;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(278, 500);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 36);
            this.EliminarButton.TabIndex = 15;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::RegistroUniversitario.Properties.Resources.Save2_icon;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(158, 501);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 35);
            this.GuardarButton.TabIndex = 14;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::RegistroUniversitario.Properties.Resources.new_file_icon;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(37, 501);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 35);
            this.NuevoButton.TabIndex = 13;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // EliminarFilaButton
            // 
            this.EliminarFilaButton.Image = global::RegistroUniversitario.Properties.Resources.Button_Close_icon;
            this.EliminarFilaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarFilaButton.Location = new System.Drawing.Point(10, 271);
            this.EliminarFilaButton.Name = "EliminarFilaButton";
            this.EliminarFilaButton.Size = new System.Drawing.Size(89, 37);
            this.EliminarFilaButton.TabIndex = 7;
            this.EliminarFilaButton.Text = "Eliminar fila";
            this.EliminarFilaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarFilaButton.UseVisualStyleBackColor = true;
            this.EliminarFilaButton.Click += new System.EventHandler(this.EliminarFilaButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::RegistroUniversitario.Properties.Resources.search2_icon;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(278, 30);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 42);
            this.BuscarButton.TabIndex = 6;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // rInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 557);
            this.Controls.Add(this.EstudianteComboBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.PrecioCreditoNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "rInscripciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rInscripciones";
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioCreditoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PrecioCreditoNumericUpDown;
        private System.Windows.Forms.Button EliminarFilaButton;
        private System.Windows.Forms.Button AgregarDetalleButton;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.ComboBox AsignaturaComboBox;
        private System.Windows.Forms.ComboBox EstudianteComboBox;
        private System.Windows.Forms.TextBox MontoTextBox;
    }
}