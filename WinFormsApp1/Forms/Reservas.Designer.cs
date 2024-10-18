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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // IdDeUsuarioReservaLabel
            // 
            IdDeUsuarioReservaLabel.AutoSize = true;
            IdDeUsuarioReservaLabel.Location = new Point(34, 39);
            IdDeUsuarioReservaLabel.Name = "IdDeUsuarioReservaLabel";
            IdDeUsuarioReservaLabel.Size = new Size(120, 25);
            IdDeUsuarioReservaLabel.TabIndex = 1;
            IdDeUsuarioReservaLabel.Text = "Id del usuario";
            IdDeUsuarioReservaLabel.Click += label1_Click;
            // 
            // IdLibroReservaLabel
            // 
            IdLibroReservaLabel.AutoSize = true;
            IdLibroReservaLabel.Location = new Point(200, 39);
            IdLibroReservaLabel.Name = "IdLibroReservaLabel";
            IdLibroReservaLabel.Size = new Size(98, 25);
            IdLibroReservaLabel.TabIndex = 3;
            IdLibroReservaLabel.Text = "Id del libro";
            // 
            // FechaDeReservaLabel
            // 
            FechaDeReservaLabel.AutoSize = true;
            FechaDeReservaLabel.Location = new Point(343, 49);
            FechaDeReservaLabel.Name = "FechaDeReservaLabel";
            FechaDeReservaLabel.Size = new Size(147, 25);
            FechaDeReservaLabel.TabIndex = 5;
            FechaDeReservaLabel.Text = "Fecha de Reserva";
            // 
            // IdUsuarioReservaBox
            // 
            IdUsuarioReservaBox.Location = new Point(34, 79);
            IdUsuarioReservaBox.Name = "IdUsuarioReservaBox";
            IdUsuarioReservaBox.Size = new Size(122, 31);
            IdUsuarioReservaBox.TabIndex = 6;
            IdUsuarioReservaBox.TextChanged += textBox1_TextChanged;
            // 
            // IdLibroReservaBox
            // 
            IdLibroReservaBox.Location = new Point(183, 78);
            IdLibroReservaBox.Name = "IdLibroReservaBox";
            IdLibroReservaBox.Size = new Size(122, 31);
            IdLibroReservaBox.TabIndex = 8;
            // 
            // FechaDeRetornoLabel
            // 
            FechaDeRetornoLabel.AutoSize = true;
            FechaDeRetornoLabel.Location = new Point(492, 48);
            FechaDeRetornoLabel.Name = "FechaDeRetornoLabel";
            FechaDeRetornoLabel.Size = new Size(150, 25);
            FechaDeRetornoLabel.TabIndex = 10;
            FechaDeRetornoLabel.Text = "Fecha de Retorno";
            FechaDeRetornoLabel.Click += label2_Click;
            // 
            // dateTimePickerReserva1
            // 
            dateTimePickerReserva1.Location = new Point(337, 77);
            dateTimePickerReserva1.Name = "dateTimePickerReserva1";
            dateTimePickerReserva1.Size = new Size(153, 31);
            dateTimePickerReserva1.TabIndex = 11;
            // 
            // dateTimePickerReserva2
            // 
            dateTimePickerReserva2.Location = new Point(496, 78);
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
            // Reservas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 469);
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
    }
}