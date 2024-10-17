namespace WinFormsApp1.Forms
{
    partial class Inicio
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
            Librosbutton = new Button();
            Usuariobutton = new Button();
            Reportebutton = new Button();
            Reservasbutton = new Button();
            CerrarButton = new Button();
            SuspendLayout();
            // 
            // Librosbutton
            // 
            Librosbutton.Location = new Point(155, 142);
            Librosbutton.Name = "Librosbutton";
            Librosbutton.Size = new Size(226, 126);
            Librosbutton.TabIndex = 0;
            Librosbutton.Text = "Libros";
            Librosbutton.UseVisualStyleBackColor = true;
            Librosbutton.Click += Librosbutton_Click;
            // 
            // Usuariobutton
            // 
            Usuariobutton.Location = new Point(467, 142);
            Usuariobutton.Name = "Usuariobutton";
            Usuariobutton.Size = new Size(226, 126);
            Usuariobutton.TabIndex = 1;
            Usuariobutton.Text = "Usuarios";
            Usuariobutton.UseVisualStyleBackColor = true;
            Usuariobutton.Click += Usuariobutton_Click;
            // 
            // Reportebutton
            // 
            Reportebutton.Location = new Point(467, 328);
            Reportebutton.Name = "Reportebutton";
            Reportebutton.Size = new Size(226, 126);
            Reportebutton.TabIndex = 2;
            Reportebutton.Text = "Reporte";
            Reportebutton.UseVisualStyleBackColor = true;
            Reportebutton.Click += Consultasbutton_Click;
            // 
            // Reservasbutton
            // 
            Reservasbutton.Location = new Point(155, 328);
            Reservasbutton.Name = "Reservasbutton";
            Reservasbutton.Size = new Size(226, 126);
            Reservasbutton.TabIndex = 3;
            Reservasbutton.Text = "Reservas";
            Reservasbutton.UseVisualStyleBackColor = true;
            Reservasbutton.Click += Reservasbutton_Click;
            // 
            // CerrarButton
            // 
            CerrarButton.Location = new Point(809, 501);
            CerrarButton.Name = "CerrarButton";
            CerrarButton.Size = new Size(86, 37);
            CerrarButton.TabIndex = 4;
            CerrarButton.Text = "Cerrar";
            CerrarButton.UseVisualStyleBackColor = true;
            CerrarButton.Click += button1_Click_1;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 550);
            Controls.Add(CerrarButton);
            Controls.Add(Reservasbutton);
            Controls.Add(Reportebutton);
            Controls.Add(Usuariobutton);
            Controls.Add(Librosbutton);
            Name = "Inicio";
            Text = "Inicio";
            Load += Inicio_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Librosbutton;
        private Button Usuariobutton;
        private Button Reportebutton;
        private Button Reservasbutton;
        private Button CerrarButton;
    }
}