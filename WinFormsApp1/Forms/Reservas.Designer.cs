namespace WinFormsApp1.Forms._3
{
    partial class Reservas
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
            IdDeUsuarioReservaLabel = new Label();
            IdLibroReservaLabel = new Label();
            FechaDeReservaLabel = new Label();
            IdUsuarioReservaBox = new TextBox();
            IdLibroReservaBox = new TextBox();
            FechaDeRetornoLabel = new Label();
            dateTimePickerReserva1 = new DateTimePicker();
            dateTimePickerReserva2 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            AgregarReservaButton = new Button();
            EliminarReservaButton = new Button();
            InicioReservaButton = new Button();
            RegistrarDevolucionButton = new Button();
            HistorialReservasButton = new Button();
            BuscarReservaBox = new TextBox();
            BuscarReservaComboBox = new ComboBox();
            BuscarReservaLabel = new Label();
            FiltroReservaLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // IdDeUsuarioReservaLabel
            // 
            IdDeUsuarioReservaLabel.AutoSize = true;
            IdDeUsuarioReservaLabel.Location = new Point(39, 17);
            IdDeUsuarioReservaLabel.Name = "IdDeUsuarioReservaLabel";
            IdDeUsuarioReservaLabel.Size = new Size(120, 25);
            IdDeUsuarioReservaLabel.TabIndex = 1;
            IdDeUsuarioReservaLabel.Text = "Id del usuario";
            IdDeUsuarioReservaLabel.Click += label1_Click;
            // 
            // IdLibroReservaLabel
            // 
            IdLibroReservaLabel.AutoSize = true;
            IdLibroReservaLabel.Location = new Point(186, 16);
            IdLibroReservaLabel.Name = "IdLibroReservaLabel";
            IdLibroReservaLabel.Size = new Size(98, 25);
            IdLibroReservaLabel.TabIndex = 3;
            IdLibroReservaLabel.Text = "Id del libro";
            // 
            // FechaDeReservaLabel
            // 
            FechaDeReservaLabel.AutoSize = true;
            FechaDeReservaLabel.Location = new Point(346, 15);
            FechaDeReservaLabel.Name = "FechaDeReservaLabel";
            FechaDeReservaLabel.Size = new Size(147, 25);
            FechaDeReservaLabel.TabIndex = 5;
            FechaDeReservaLabel.Text = "Fecha de Reserva";
            // 
            // IdUsuarioReservaBox
            // 
            IdUsuarioReservaBox.Location = new Point(37, 45);
            IdUsuarioReservaBox.Name = "IdUsuarioReservaBox";
            IdUsuarioReservaBox.Size = new Size(122, 31);
            IdUsuarioReservaBox.TabIndex = 6;
            IdUsuarioReservaBox.TextChanged += textBox1_TextChanged;
            // 
            // IdLibroReservaBox
            // 
            IdLibroReservaBox.Location = new Point(186, 44);
            IdLibroReservaBox.Name = "IdLibroReservaBox";
            IdLibroReservaBox.Size = new Size(122, 31);
            IdLibroReservaBox.TabIndex = 8;
            // 
            // FechaDeRetornoLabel
            // 
            FechaDeRetornoLabel.AutoSize = true;
            FechaDeRetornoLabel.Location = new Point(495, 14);
            FechaDeRetornoLabel.Name = "FechaDeRetornoLabel";
            FechaDeRetornoLabel.Size = new Size(150, 25);
            FechaDeRetornoLabel.TabIndex = 10;
            FechaDeRetornoLabel.Text = "Fecha de Retorno";
            FechaDeRetornoLabel.Click += label2_Click;
            // 
            // dateTimePickerReserva1
            // 
            dateTimePickerReserva1.Location = new Point(340, 43);
            dateTimePickerReserva1.Name = "dateTimePickerReserva1";
            dateTimePickerReserva1.Size = new Size(153, 31);
            dateTimePickerReserva1.TabIndex = 11;
            // 
            // dateTimePickerReserva2
            // 
            dateTimePickerReserva2.Location = new Point(499, 44);
            dateTimePickerReserva2.Name = "dateTimePickerReserva2";
            dateTimePickerReserva2.Size = new Size(153, 31);
            dateTimePickerReserva2.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(751, 266);
            dataGridView1.TabIndex = 13;
            // 
            // AgregarReservaButton
            // 
            AgregarReservaButton.Location = new Point(850, 23);
            AgregarReservaButton.Name = "AgregarReservaButton";
            AgregarReservaButton.Size = new Size(212, 74);
            AgregarReservaButton.TabIndex = 14;
            AgregarReservaButton.Text = "Agregar";
            AgregarReservaButton.UseVisualStyleBackColor = true;
            AgregarReservaButton.Click += AgregarReservaButton_Click;
            // 
            // EliminarReservaButton
            // 
            EliminarReservaButton.Location = new Point(850, 103);
            EliminarReservaButton.Name = "EliminarReservaButton";
            EliminarReservaButton.Size = new Size(212, 74);
            EliminarReservaButton.TabIndex = 15;
            EliminarReservaButton.Text = "Eliminar";
            EliminarReservaButton.UseVisualStyleBackColor = true;
            EliminarReservaButton.Click += EliminarReservaButton_Click;
            // 
            // InicioReservaButton
            // 
            InicioReservaButton.Location = new Point(850, 183);
            InicioReservaButton.Name = "InicioReservaButton";
            InicioReservaButton.Size = new Size(212, 74);
            InicioReservaButton.TabIndex = 16;
            InicioReservaButton.Text = "Inicio";
            InicioReservaButton.UseVisualStyleBackColor = true;
            InicioReservaButton.Click += InicioReservaButton_Click;
            // 
            // RegistrarDevolucionButton
            // 
            RegistrarDevolucionButton.Location = new Point(850, 263);
            RegistrarDevolucionButton.Name = "RegistrarDevolucionButton";
            RegistrarDevolucionButton.Size = new Size(212, 74);
            RegistrarDevolucionButton.TabIndex = 17;
            RegistrarDevolucionButton.Text = "Registrar Devolucion";
            RegistrarDevolucionButton.UseVisualStyleBackColor = true;
            RegistrarDevolucionButton.Click += RegistrarDevolucionButton_Click_1;
            // 
            // HistorialReservasButton
            // 
            HistorialReservasButton.Location = new Point(850, 343);
            HistorialReservasButton.Name = "HistorialReservasButton";
            HistorialReservasButton.Size = new Size(212, 74);
            HistorialReservasButton.TabIndex = 18;
            HistorialReservasButton.Text = "Historial";
            HistorialReservasButton.UseVisualStyleBackColor = true;
            HistorialReservasButton.Click += HistorialReservasButton_Click;
            // 
            // BuscarReservaBox
            // 
            BuscarReservaBox.Location = new Point(39, 146);
            BuscarReservaBox.Name = "BuscarReservaBox";
            BuscarReservaBox.Size = new Size(290, 31);
            BuscarReservaBox.TabIndex = 19;
            BuscarReservaBox.TextChanged += BuscarReservaBox_TextChanged;
            // 
            // BuscarReservaComboBox
            // 
            BuscarReservaComboBox.FormattingEnabled = true;
            BuscarReservaComboBox.Location = new Point(335, 144);
            BuscarReservaComboBox.Name = "BuscarReservaComboBox";
            BuscarReservaComboBox.Size = new Size(133, 33);
            BuscarReservaComboBox.TabIndex = 20;
            BuscarReservaComboBox.SelectedIndexChanged += BuscarReservaComboBox_SelectedIndexChanged;
            // 
            // BuscarReservaLabel
            // 
            BuscarReservaLabel.AutoSize = true;
            BuscarReservaLabel.Location = new Point(39, 118);
            BuscarReservaLabel.Name = "BuscarReservaLabel";
            BuscarReservaLabel.Size = new Size(214, 25);
            BuscarReservaLabel.TabIndex = 21;
            BuscarReservaLabel.Text = "Buscar en reservas activas";
            // 
            // FiltroReservaLabel
            // 
            FiltroReservaLabel.AutoSize = true;
            FiltroReservaLabel.Location = new Point(335, 116);
            FiltroReservaLabel.Name = "FiltroReservaLabel";
            FiltroReservaLabel.Size = new Size(52, 25);
            FiltroReservaLabel.TabIndex = 22;
            FiltroReservaLabel.Text = "Filtro";
            // 
            // Reservas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 469);
            Controls.Add(FiltroReservaLabel);
            Controls.Add(BuscarReservaLabel);
            Controls.Add(BuscarReservaComboBox);
            Controls.Add(BuscarReservaBox);
            Controls.Add(HistorialReservasButton);
            Controls.Add(RegistrarDevolucionButton);
            Controls.Add(InicioReservaButton);
            Controls.Add(EliminarReservaButton);
            Controls.Add(AgregarReservaButton);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePickerReserva2);
            Controls.Add(dateTimePickerReserva1);
            Controls.Add(FechaDeRetornoLabel);
            Controls.Add(IdLibroReservaBox);
            Controls.Add(IdUsuarioReservaBox);
            Controls.Add(FechaDeReservaLabel);
            Controls.Add(IdLibroReservaLabel);
            Controls.Add(IdDeUsuarioReservaLabel);
            Name = "Reservas";
            Text = "Reservas";
            Load += Reservas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label IdDeUsuarioReservaLabel;
        private Label IdLibroReservaLabel;
        private Label FechaDeReservaLabel;
        private TextBox IdUsuarioReservaBox;
        private TextBox IdLibroReservaBox;
        private Label FechaDeRetornoLabel;
        private DateTimePicker dateTimePickerReserva1;
        private DateTimePicker dateTimePickerReserva2;
        private DataGridView dataGridView1;
        private Button AgregarReservaButton;
        private Button EliminarReservaButton;
        private Button InicioReservaButton;
        private Button RegistrarDevolucionButton;
        private Button HistorialReservasButton;
        private TextBox BuscarReservaBox;
        private ComboBox BuscarReservaComboBox;
        private Label BuscarReservaLabel;
        private Label FiltroReservaLabel;
    }
}