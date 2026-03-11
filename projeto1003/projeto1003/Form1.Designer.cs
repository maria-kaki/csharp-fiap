namespace projeto1003
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
            lbl_email = new Label();
            lbl_senha = new Label();
            txtbx_email = new TextBox();
            txtbx_senha = new TextBox();
            btn_cadastrar = new Button();
            btn_entrar = new Button();
            btn_sair = new Button();
            SuspendLayout();
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(292, 94);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(45, 23);
            lbl_email.TabIndex = 0;
            lbl_email.Text = "Email";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Location = new Point(290, 154);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(48, 23);
            lbl_senha.TabIndex = 0;
            lbl_senha.Text = "Senha";
            // 
            // txtbx_email
            // 
            txtbx_email.Location = new Point(284, 123);
            txtbx_email.Name = "txtbx_email";
            txtbx_email.PlaceholderText = "Digite seu e-mail";
            txtbx_email.Size = new Size(117, 28);
            txtbx_email.TabIndex = 1;
            // 
            // txtbx_senha
            // 
            txtbx_senha.Location = new Point(284, 190);
            txtbx_senha.Name = "txtbx_senha";
            txtbx_senha.PasswordChar = '*';
            txtbx_senha.PlaceholderText = "Digite sua senha";
            txtbx_senha.Size = new Size(117, 28);
            txtbx_senha.TabIndex = 2;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.RosyBrown;
            btn_cadastrar.Cursor = Cursors.Hand;
            btn_cadastrar.FlatStyle = FlatStyle.Flat;
            btn_cadastrar.Location = new Point(356, 244);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(86, 40);
            btn_cadastrar.TabIndex = 4;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_entrar
            // 
            btn_entrar.BackColor = Color.RosyBrown;
            btn_entrar.Cursor = Cursors.Hand;
            btn_entrar.FlatStyle = FlatStyle.Flat;
            btn_entrar.Location = new Point(238, 244);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(75, 39);
            btn_entrar.TabIndex = 3;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = false;
            // 
            // btn_sair
            // 
            btn_sair.BackColor = Color.RosyBrown;
            btn_sair.Cursor = Cursors.Hand;
            btn_sair.FlatAppearance.BorderColor = Color.RosyBrown;
            btn_sair.FlatAppearance.BorderSize = 0;
            btn_sair.FlatStyle = FlatStyle.Flat;
            btn_sair.Location = new Point(301, 300);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(75, 38);
            btn_sair.TabIndex = 5;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(702, 430);
            Controls.Add(btn_sair);
            Controls.Add(btn_entrar);
            Controls.Add(btn_cadastrar);
            Controls.Add(txtbx_senha);
            Controls.Add(txtbx_email);
            Controls.Add(lbl_senha);
            Controls.Add(lbl_email);
            Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_email;
        private Label lbl_senha;
        private TextBox txtbx_email;
        private TextBox txtbx_senha;
        private Button btn_cadastrar;
        private Button btn_entrar;
        private Button btn_sair;
    }
}
