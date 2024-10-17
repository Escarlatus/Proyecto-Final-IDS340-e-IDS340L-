namespace WinFormsApp1.Forms
{
    partial class Libros
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
            AgregarLibroBotton = new Button();
            IdLibroBox = new TextBox();
            ISBNBox = new TextBox();
            GeneroBox = new TextBox();
            AñoBox = new TextBox();
            EditorialBox = new TextBox();
            AutorBox = new TextBox();
            TituloBox = new TextBox();
            CopiasBox = new TextBox();
            EditarLibroButton = new Button();
            EliminarLibroButton = new Button();
            InicioLibrosButton = new Button();
            IdLibroLabel = new Label();
            AutorLabel = new Label();
            TituloLabel = new Label();
            ISBNLabel = new Label();
            EditorialLabel = new Label();
            AnoLabel = new Label();
            GeneroLabel = new Label();
            CopiasLabel = new Label();
            BuscarLibroBox = new TextBox();
            BuscarLibroComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 271);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1253, 258);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // AgregarLibroBotton
            // 
            AgregarLibroBotton.Location = new Point(385, 137);
            AgregarLibroBotton.Name = "AgregarLibroBotton";
            AgregarLibroBotton.Size = new Size(139, 36);
            AgregarLibroBotton.TabIndex = 1;
            AgregarLibroBotton.Text = "Agregar";
            AgregarLibroBotton.UseVisualStyleBackColor = true;
            AgregarLibroBotton.Click += AgregarLibroBotton_Click;
            // 
            // IdLibroBox
            // 
            IdLibroBox.Location = new Point(11, 38);
            IdLibroBox.Name = "IdLibroBox";
            IdLibroBox.Size = new Size(196, 31);
            IdLibroBox.TabIndex = 2;
            // 
            // ISBNBox
            // 
            ISBNBox.Location = new Point(245, 38);
            ISBNBox.Name = "ISBNBox";
            ISBNBox.Size = new Size(196, 31);
            ISBNBox.TabIndex = 3;
            // 
            // GeneroBox
            // 
            GeneroBox.Location = new Point(484, 100);
            GeneroBox.Name = "GeneroBox";
            GeneroBox.Size = new Size(196, 31);
            GeneroBox.TabIndex = 4;
            // 
            // AñoBox
            // 
            AñoBox.Location = new Point(245, 100);
            AñoBox.Name = "AñoBox";
            AñoBox.Size = new Size(196, 31);
            AñoBox.TabIndex = 5;
            // 
            // EditorialBox
            // 
            EditorialBox.Location = new Point(11, 100);
            EditorialBox.Name = "EditorialBox";
            EditorialBox.Size = new Size(196, 31);
            EditorialBox.TabIndex = 6;
            // 
            // AutorBox
            // 
            AutorBox.Location = new Point(704, 38);
            AutorBox.Name = "AutorBox";
            AutorBox.Size = new Size(196, 31);
            AutorBox.TabIndex = 7;
            // 
            // TituloBox
            // 
            TituloBox.Location = new Point(484, 38);
            TituloBox.Name = "TituloBox";
            TituloBox.Size = new Size(196, 31);
            TituloBox.TabIndex = 8;
            // 
            // CopiasBox
            // 
            CopiasBox.Location = new Point(704, 100);
            CopiasBox.Name = "CopiasBox";
            CopiasBox.Size = new Size(196, 31);
            CopiasBox.TabIndex = 9;
            // 
            // EditarLibroButton
            // 
            EditarLibroButton.Location = new Point(530, 137);
            EditarLibroButton.Name = "EditarLibroButton";
            EditarLibroButton.Size = new Size(139, 36);
            EditarLibroButton.TabIndex = 10;
            EditarLibroButton.Text = "Editar";
            EditarLibroButton.UseVisualStyleBackColor = true;
            EditarLibroButton.Click += EditarButton_Click;
            // 
            // EliminarLibroButton
            // 
            EliminarLibroButton.Location = new Point(675, 137);
            EliminarLibroButton.Name = "EliminarLibroButton";
            EliminarLibroButton.Size = new Size(139, 36);
            EliminarLibroButton.TabIndex = 11;
            EliminarLibroButton.Text = "Eliminar";
            EliminarLibroButton.UseVisualStyleBackColor = true;
            EliminarLibroButton.Click += EliminarLibroButton_Click;
            // 
            // InicioLibrosButton
            // 
            InicioLibrosButton.Location = new Point(11, 140);
            InicioLibrosButton.Name = "InicioLibrosButton";
            InicioLibrosButton.Size = new Size(133, 33);
            InicioLibrosButton.TabIndex = 12;
            InicioLibrosButton.Text = "Inicio";
            InicioLibrosButton.UseVisualStyleBackColor = true;
            InicioLibrosButton.Click += InicioLibrosButton_Click;
            // 
            // IdLibroLabel
            // 
            IdLibroLabel.AutoSize = true;
            IdLibroLabel.Location = new Point(80, 10);
            IdLibroLabel.Name = "IdLibroLabel";
            IdLibroLabel.Size = new Size(28, 25);
            IdLibroLabel.TabIndex = 13;
            IdLibroLabel.Text = "Id";
            // 
            // AutorLabel
            // 
            AutorLabel.AutoSize = true;
            AutorLabel.Location = new Point(766, 10);
            AutorLabel.Name = "AutorLabel";
            AutorLabel.Size = new Size(57, 25);
            AutorLabel.TabIndex = 14;
            AutorLabel.Text = "Autor";
            // 
            // TituloLabel
            // 
            TituloLabel.AutoSize = true;
            TituloLabel.Location = new Point(546, 10);
            TituloLabel.Name = "TituloLabel";
            TituloLabel.Size = new Size(56, 25);
            TituloLabel.TabIndex = 15;
            TituloLabel.Text = "Titulo";
            // 
            // ISBNLabel
            // 
            ISBNLabel.AutoSize = true;
            ISBNLabel.Location = new Point(317, 10);
            ISBNLabel.Name = "ISBNLabel";
            ISBNLabel.Size = new Size(50, 25);
            ISBNLabel.TabIndex = 16;
            ISBNLabel.Text = "ISBN";
            // 
            // EditorialLabel
            // 
            EditorialLabel.AutoSize = true;
            EditorialLabel.Location = new Point(57, 72);
            EditorialLabel.Name = "EditorialLabel";
            EditorialLabel.Size = new Size(76, 25);
            EditorialLabel.TabIndex = 17;
            EditorialLabel.Text = "Editorial";
            // 
            // AnoLabel
            // 
            AnoLabel.AutoSize = true;
            AnoLabel.Location = new Point(257, 72);
            AnoLabel.Name = "AnoLabel";
            AnoLabel.Size = new Size(165, 25);
            AnoLabel.TabIndex = 18;
            AnoLabel.Text = "Ano de publicacion";
            // 
            // GeneroLabel
            // 
            GeneroLabel.AutoSize = true;
            GeneroLabel.Location = new Point(546, 72);
            GeneroLabel.Name = "GeneroLabel";
            GeneroLabel.Size = new Size(69, 25);
            GeneroLabel.TabIndex = 19;
            GeneroLabel.Text = "Genero";
            // 
            // CopiasLabel
            // 
            CopiasLabel.AutoSize = true;
            CopiasLabel.Location = new Point(722, 72);
            CopiasLabel.Name = "CopiasLabel";
            CopiasLabel.Size = new Size(158, 25);
            CopiasLabel.TabIndex = 20;
            CopiasLabel.Text = "Numero de copias";
            // 
            // BuscarLibroBox
            // 
            BuscarLibroBox.Location = new Point(124, 234);
            BuscarLibroBox.Name = "BuscarLibroBox";
            BuscarLibroBox.Size = new Size(317, 31);
            BuscarLibroBox.TabIndex = 21;
            BuscarLibroBox.TextChanged += BuscarLibroBox_TextChanged;
            // 
            // BuscarLibroComboBox
            // 
            BuscarLibroComboBox.FormattingEnabled = true;
            BuscarLibroComboBox.Location = new Point(447, 234);
            BuscarLibroComboBox.Name = "BuscarLibroComboBox";
            BuscarLibroComboBox.Size = new Size(155, 33);
            BuscarLibroComboBox.TabIndex = 22;
            BuscarLibroComboBox.SelectedIndexChanged += BuscarLibroComboBox_SelectedIndexChanged;
            // 
            // Libros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 531);
            Controls.Add(BuscarLibroComboBox);
            Controls.Add(BuscarLibroBox);
            Controls.Add(CopiasLabel);
            Controls.Add(GeneroLabel);
            Controls.Add(AnoLabel);
            Controls.Add(EditorialLabel);
            Controls.Add(ISBNLabel);
            Controls.Add(TituloLabel);
            Controls.Add(AutorLabel);
            Controls.Add(IdLibroLabel);
            Controls.Add(InicioLibrosButton);
            Controls.Add(EliminarLibroButton);
            Controls.Add(EditarLibroButton);
            Controls.Add(CopiasBox);
            Controls.Add(TituloBox);
            Controls.Add(AutorBox);
            Controls.Add(EditorialBox);
            Controls.Add(AñoBox);
            Controls.Add(GeneroBox);
            Controls.Add(ISBNBox);
            Controls.Add(IdLibroBox);
            Controls.Add(AgregarLibroBotton);
            Controls.Add(dataGridView1);
            Name = "Libros";
            Text = "Libros";
            Load += Libros_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button AgregarLibroBotton;
        private TextBox IdLibroBox;
        private TextBox ISBNBox;
        private TextBox GeneroBox;
        private TextBox AñoBox;
        private TextBox EditorialBox;
        private TextBox AutorBox;
        private TextBox TituloBox;
        private TextBox CopiasBox;
        private Button EditarLibroButton;
        private Button EliminarLibroButton;
        private Button InicioLibrosButton;
        private Label IdLibroLabel;
        private Label AutorLabel;
        private Label TituloLabel;
        private Label ISBNLabel;
        private Label EditorialLabel;
        private Label AnoLabel;
        private Label GeneroLabel;
        private Label CopiasLabel;
        private TextBox BuscarLibroBox;
        private ComboBox BuscarLibroComboBox;
    }
}