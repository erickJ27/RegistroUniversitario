namespace RegistroUniversitario.UI.Consultas
{
    partial class cEstudiantes
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
            this.ConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FiltrarFechaCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaDataGridView
            // 
            this.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDataGridView.Location = new System.Drawing.Point(12, 56);
            this.ConsultaDataGridView.Name = "ConsultaDataGridView";
            this.ConsultaDataGridView.Size = new System.Drawing.Size(741, 337);
            this.ConsultaDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde";
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(31, 30);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(126, 20);
            this.DesdeDateTimePicker.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta";
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(176, 30);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(126, 20);
            this.HastaDateTimePicker.TabIndex = 4;
            // 
            // FiltrarFechaCheckBox
            // 
            this.FiltrarFechaCheckBox.AutoSize = true;
            this.FiltrarFechaCheckBox.Location = new System.Drawing.Point(322, 30);
            this.FiltrarFechaCheckBox.Name = "FiltrarFechaCheckBox";
            this.FiltrarFechaCheckBox.Size = new System.Drawing.Size(84, 17);
            this.FiltrarFechaCheckBox.TabIndex = 5;
            this.FiltrarFechaCheckBox.Text = "Filtrar Fecha";
            this.FiltrarFechaCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filtro";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Location = new System.Drawing.Point(417, 29);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltroComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Criterio";
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(558, 29);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(100, 20);
            this.CriterioTextBox.TabIndex = 9;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(678, 26);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 10;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // cEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FiltrarFechaCheckBox);
            this.Controls.Add(this.HastaDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DesdeDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsultaDataGridView);
            this.Name = "cEstudiantes";
            this.Text = "cEstudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultaDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.CheckBox FiltrarFechaCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Button BuscarButton;
    }
}