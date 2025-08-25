namespace PryAgorioAct1
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBienvenidos = new Label();
            lblSintepart = new Label();
            SuspendLayout();
            // 
            // lblBienvenidos
            // 
            lblBienvenidos.AutoSize = true;
            lblBienvenidos.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenidos.Location = new Point(234, 128);
            lblBienvenidos.Name = "lblBienvenidos";
            lblBienvenidos.Size = new Size(316, 54);
            lblBienvenidos.TabIndex = 0;
            lblBienvenidos.Text = "¡BIENVENIDOS!";
            // 
            // lblSintepart
            // 
            lblSintepart.AutoSize = true;
            lblSintepart.BackColor = Color.FromArgb(128, 255, 128);
            lblSintepart.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSintepart.Location = new Point(280, 265);
            lblSintepart.Name = "lblSintepart";
            lblSintepart.Size = new Size(240, 50);
            lblSintepart.TabIndex = 1;
            lblSintepart.Text = "Sintepart SRL";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(lblSintepart);
            Controls.Add(lblBienvenidos);
            Name = "frmPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenidos;
        private Label lblSintepart;
    }
}
