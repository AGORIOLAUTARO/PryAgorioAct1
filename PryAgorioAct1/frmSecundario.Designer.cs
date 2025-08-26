namespace PryAgorioAct1
{
    partial class frmSecundario
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
            lblUsuario = new Label();
            lblContraseña = new Label();
            lblModulo = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            cmbModulo = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(68, 45);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(77, 25);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(68, 110);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(108, 25);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModulo.Location = new Point(68, 194);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(78, 25);
            lblModulo.TabIndex = 2;
            lblModulo.Text = "Módulo";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(207, 47);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(149, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Location = new Point(207, 110);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '#';
            txtContraseña.Size = new Size(149, 23);
            txtContraseña.TabIndex = 4;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // cmbModulo
            // 
            cmbModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModulo.FormattingEnabled = true;
            cmbModulo.Items.AddRange(new object[] { "ADM", "SIST", "COM", "VTA" });
            cmbModulo.Location = new Point(207, 199);
            cmbModulo.Margin = new Padding(3, 2, 3, 2);
            cmbModulo.Name = "cmbModulo";
            cmbModulo.Size = new Size(149, 23);
            cmbModulo.TabIndex = 5;
            // 
            // btnAceptar
            // 
            btnAceptar.Enabled = false;
            btnAceptar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(422, 39);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(136, 36);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(422, 105);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(136, 34);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmSecundario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(620, 259);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(cmbModulo);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblModulo);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmSecundario";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private Label lblModulo;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private ComboBox cmbModulo;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}