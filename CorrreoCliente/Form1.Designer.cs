namespace CorrreoCliente
{
    partial class Form1
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
            label1 = new Label();
            txtDestinatario = new TextBox();
            label2 = new Label();
            txtAsunto = new TextBox();
            label3 = new Label();
            txtMensaje = new TextBox();
            btnGuardarCorreo = new Button();
            lblEstado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 62);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 0;
            label1.Text = "Destinatario";
            // 
            // txtDestinatario
            // 
            txtDestinatario.Location = new Point(264, 56);
            txtDestinatario.Name = "txtDestinatario";
            txtDestinatario.Size = new Size(200, 39);
            txtDestinatario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 129);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 2;
            label2.Text = "Asunto";
            // 
            // txtAsunto
            // 
            txtAsunto.Location = new Point(257, 140);
            txtAsunto.Name = "txtAsunto";
            txtAsunto.Size = new Size(200, 39);
            txtAsunto.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 216);
            label3.Name = "label3";
            label3.Size = new Size(104, 32);
            label3.TabIndex = 4;
            label3.Text = "Mensaje";
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(248, 228);
            txtMensaje.Multiline = true;
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(200, 78);
            txtMensaje.TabIndex = 5;
            // 
            // btnGuardarCorreo
            // 
            btnGuardarCorreo.Location = new Point(292, 339);
            btnGuardarCorreo.Name = "btnGuardarCorreo";
            btnGuardarCorreo.Size = new Size(150, 46);
            btnGuardarCorreo.TabIndex = 6;
            btnGuardarCorreo.Text = "Guardar Correo";
            btnGuardarCorreo.UseVisualStyleBackColor = true;
            btnGuardarCorreo.Click += btnGuardarCorreo_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(323, 400);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(78, 32);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEstado);
            Controls.Add(btnGuardarCorreo);
            Controls.Add(txtMensaje);
            Controls.Add(label3);
            Controls.Add(txtAsunto);
            Controls.Add(label2);
            Controls.Add(txtDestinatario);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDestinatario;
        private Label label2;
        private TextBox txtAsunto;
        private Label label3;
        private TextBox txtMensaje;
        private Button btnGuardarCorreo;
        private Label lblEstado;
    }
}
