namespace WinFormsApp1.Forms
{
    partial class Gestion_Usuarios
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
            dataGridViewUsuarios = new DataGridView();
            InicioUsuarioButton = new Button();
            IdUsuarioBox = new TextBox();
            TelefonoUsuarioBox = new TextBox();
            EmailUsuarioBox = new TextBox();
            ApellidoUsuarioBox = new TextBox();
            NombreUsuarioBox = new TextBox();
            IdLabelUsuario = new Label();
            NombreLabelUsuario = new Label();
            ApellidoLabelUsuario = new Label();
            EmailLabelUsuario = new Label();
            TelefonoLabelUsuario = new Label();
            AgregaUsuarioButton = new Button();
            EditarUsuarioButton = new Button();
            EliminarUsuarioButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(374, 22);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewUsuarios.RowHeadersWidth = 62;
            dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsuarios.Size = new Size(814, 429);
            dataGridViewUsuarios.TabIndex = 0;
            dataGridViewUsuarios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // InicioUsuarioButton
            // 
            InicioUsuarioButton.Location = new Point(12, 415);
            InicioUsuarioButton.Name = "InicioUsuarioButton";
            InicioUsuarioButton.Size = new Size(88, 36);
            InicioUsuarioButton.TabIndex = 2;
            InicioUsuarioButton.Text = "Inicio";
            InicioUsuarioButton.UseVisualStyleBackColor = true;
            InicioUsuarioButton.Click += InicioUsuarioButton_Click;
            // 
            // IdUsuarioBox
            // 
            IdUsuarioBox.Location = new Point(67, 77);
            IdUsuarioBox.Name = "IdUsuarioBox";
            IdUsuarioBox.Size = new Size(224, 31);
            IdUsuarioBox.TabIndex = 3;
            // 
            // TelefonoUsuarioBox
            // 
            TelefonoUsuarioBox.Location = new Point(67, 325);
            TelefonoUsuarioBox.Name = "TelefonoUsuarioBox";
            TelefonoUsuarioBox.Size = new Size(224, 31);
            TelefonoUsuarioBox.TabIndex = 5;
            // 
            // EmailUsuarioBox
            // 
            EmailUsuarioBox.Location = new Point(67, 263);
            EmailUsuarioBox.Name = "EmailUsuarioBox";
            EmailUsuarioBox.Size = new Size(224, 31);
            EmailUsuarioBox.TabIndex = 6;
            // 
            // ApellidoUsuarioBox
            // 
            ApellidoUsuarioBox.Location = new Point(67, 201);
            ApellidoUsuarioBox.Name = "ApellidoUsuarioBox";
            ApellidoUsuarioBox.Size = new Size(224, 31);
            ApellidoUsuarioBox.TabIndex = 7;
            // 
            // NombreUsuarioBox
            // 
            NombreUsuarioBox.Location = new Point(67, 139);
            NombreUsuarioBox.Name = "NombreUsuarioBox";
            NombreUsuarioBox.Size = new Size(224, 31);
            NombreUsuarioBox.TabIndex = 8;
            // 
            // IdLabelUsuario
            // 
            IdLabelUsuario.AutoSize = true;
            IdLabelUsuario.Location = new Point(161, 49);
            IdLabelUsuario.Name = "IdLabelUsuario";
            IdLabelUsuario.Size = new Size(28, 25);
            IdLabelUsuario.TabIndex = 9;
            IdLabelUsuario.Text = "Id";
            // 
            // NombreLabelUsuario
            // 
            NombreLabelUsuario.AutoSize = true;
            NombreLabelUsuario.Location = new Point(135, 111);
            NombreLabelUsuario.Name = "NombreLabelUsuario";
            NombreLabelUsuario.Size = new Size(78, 25);
            NombreLabelUsuario.TabIndex = 10;
            NombreLabelUsuario.Text = "Nombre";
            // 
            // ApellidoLabelUsuario
            // 
            ApellidoLabelUsuario.AutoSize = true;
            ApellidoLabelUsuario.Location = new Point(135, 173);
            ApellidoLabelUsuario.Name = "ApellidoLabelUsuario";
            ApellidoLabelUsuario.Size = new Size(78, 25);
            ApellidoLabelUsuario.TabIndex = 11;
            ApellidoLabelUsuario.Text = "Apellido";
            // 
            // EmailLabelUsuario
            // 
            EmailLabelUsuario.AutoSize = true;
            EmailLabelUsuario.Location = new Point(148, 235);
            EmailLabelUsuario.Name = "EmailLabelUsuario";
            EmailLabelUsuario.Size = new Size(54, 25);
            EmailLabelUsuario.TabIndex = 12;
            EmailLabelUsuario.Text = "Email";
            // 
            // TelefonoLabelUsuario
            // 
            TelefonoLabelUsuario.AutoSize = true;
            TelefonoLabelUsuario.Location = new Point(134, 297);
            TelefonoLabelUsuario.Name = "TelefonoLabelUsuario";
            TelefonoLabelUsuario.Size = new Size(79, 25);
            TelefonoLabelUsuario.TabIndex = 13;
            TelefonoLabelUsuario.Text = "Telefono";
            // 
            // AgregaUsuarioButton
            // 
            AgregaUsuarioButton.Location = new Point(40, 362);
            AgregaUsuarioButton.Name = "AgregaUsuarioButton";
            AgregaUsuarioButton.Size = new Size(90, 34);
            AgregaUsuarioButton.TabIndex = 14;
            AgregaUsuarioButton.Text = "Agregar";
            AgregaUsuarioButton.UseVisualStyleBackColor = true;
            AgregaUsuarioButton.Click += AgregaUsuarioButton_Click;
            // 
            // EditarUsuarioButton
            // 
            EditarUsuarioButton.Location = new Point(232, 362);
            EditarUsuarioButton.Name = "EditarUsuarioButton";
            EditarUsuarioButton.Size = new Size(90, 34);
            EditarUsuarioButton.TabIndex = 15;
            EditarUsuarioButton.Text = "Editar";
            EditarUsuarioButton.UseVisualStyleBackColor = true;
            EditarUsuarioButton.Click += EditarUsuarioButton_Click;
            // 
            // EliminarUsuarioButton
            // 
            EliminarUsuarioButton.Location = new Point(136, 362);
            EliminarUsuarioButton.Name = "EliminarUsuarioButton";
            EliminarUsuarioButton.Size = new Size(90, 34);
            EliminarUsuarioButton.TabIndex = 16;
            EliminarUsuarioButton.Text = "Eliminar";
            EliminarUsuarioButton.UseVisualStyleBackColor = true;
            EliminarUsuarioButton.Click += EliminarUsuarioButton_Click;
            // 
            // Gestion_Usuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 476);
            Controls.Add(EliminarUsuarioButton);
            Controls.Add(EditarUsuarioButton);
            Controls.Add(AgregaUsuarioButton);
            Controls.Add(TelefonoLabelUsuario);
            Controls.Add(EmailLabelUsuario);
            Controls.Add(ApellidoLabelUsuario);
            Controls.Add(NombreLabelUsuario);
            Controls.Add(IdLabelUsuario);
            Controls.Add(NombreUsuarioBox);
            Controls.Add(ApellidoUsuarioBox);
            Controls.Add(EmailUsuarioBox);
            Controls.Add(TelefonoUsuarioBox);
            Controls.Add(IdUsuarioBox);
            Controls.Add(InicioUsuarioButton);
            Controls.Add(dataGridViewUsuarios);
            Name = "Gestion_Usuarios";
            Text = "Gestion_Usuarios";
            Load += Gestion_Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsuarios;
        private Button InicioUsuarioButton;
        private TextBox IdUsuarioBox;
        private TextBox TelefonoUsuarioBox;
        private TextBox EmailUsuarioBox;
        private TextBox ApellidoUsuarioBox;
        private TextBox NombreUsuarioBox;
        private Label IdLabelUsuario;
        private Label NombreLabelUsuario;
        private Label ApellidoLabelUsuario;
        private Label EmailLabelUsuario;
        private Label TelefonoLabelUsuario;
        private Button AgregaUsuarioButton;
        private Button EditarUsuarioButton;
        private Button EliminarUsuarioButton;
    }
}