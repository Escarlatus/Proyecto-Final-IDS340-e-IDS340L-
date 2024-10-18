namespace WinFormsApp1.Forms
{
    partial class HistorialReserva
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
            dataGridView1 = new DataGridView();
            BuscarHistorialBox = new TextBox();
            BuscarHistorialComboBox = new ComboBox();
            BuscarHistorialLabel = new Label();
            FiltrarHistoriaLabel = new Label();
            VolverReservaButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1065, 321);
            dataGridView1.TabIndex = 0;
            // 
            // BuscarHistorialBox
            // 
            BuscarHistorialBox.Location = new Point(26, 120);
            BuscarHistorialBox.Name = "BuscarHistorialBox";
            BuscarHistorialBox.Size = new Size(286, 31);
            BuscarHistorialBox.TabIndex = 1;
            BuscarHistorialBox.TextChanged += this.BuscarHistorialBox_TextChanged_1;
            // 
            // BuscarHistorialComboBox
            // 
            BuscarHistorialComboBox.FormattingEnabled = true;
            BuscarHistorialComboBox.Location = new Point(318, 118);
            BuscarHistorialComboBox.Name = "BuscarHistorialComboBox";
            BuscarHistorialComboBox.Size = new Size(168, 33);
            BuscarHistorialComboBox.TabIndex = 2;
            BuscarHistorialComboBox.SelectedIndexChanged += BuscarHistorialComboBox_SelectedIndexChanged;
            // 
            // BuscarHistorialLabel
            // 
            BuscarHistorialLabel.AutoSize = true;
            BuscarHistorialLabel.Location = new Point(26, 90);
            BuscarHistorialLabel.Name = "BuscarHistorialLabel";
            BuscarHistorialLabel.Size = new Size(63, 25);
            BuscarHistorialLabel.TabIndex = 3;
            BuscarHistorialLabel.Text = "Buscar";
            // 
            // FiltrarHistoriaLabel
            // 
            FiltrarHistoriaLabel.AutoSize = true;
            FiltrarHistoriaLabel.Location = new Point(318, 90);
            FiltrarHistoriaLabel.Name = "FiltrarHistoriaLabel";
            FiltrarHistoriaLabel.Size = new Size(56, 25);
            FiltrarHistoriaLabel.TabIndex = 4;
            FiltrarHistoriaLabel.Text = "Filtrar";
            // 
            // VolverReservaButton
            // 
            VolverReservaButton.Location = new Point(12, 12);
            VolverReservaButton.Name = "VolverReservaButton";
            VolverReservaButton.Size = new Size(207, 39);
            VolverReservaButton.TabIndex = 5;
            VolverReservaButton.Text = "<-- Volver a Reservas";
            VolverReservaButton.UseVisualStyleBackColor = true;
            VolverReservaButton.Click += button1_Click;
            // 
            // HistorialReserva
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 502);
            Controls.Add(VolverReservaButton);
            Controls.Add(FiltrarHistoriaLabel);
            Controls.Add(BuscarHistorialLabel);
            Controls.Add(BuscarHistorialComboBox);
            Controls.Add(BuscarHistorialBox);
            Controls.Add(dataGridView1);
            Name = "HistorialReserva";
            Text = "Historial";
            Load += Historial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox BuscarHistorialBox;
        private ComboBox BuscarHistorialComboBox;
        private Label BuscarHistorialLabel;
        private Label FiltrarHistoriaLabel;
        private Button VolverReservaButton;
    }
}