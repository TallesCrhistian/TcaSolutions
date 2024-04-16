namespace TcaSolutions.Forms
{
    partial class LoginForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForms));
            textBoxUser = new TextBox();
            textBoxPassword = new TextBox();
            userLabel = new Label();
            passwordLabel = new Label();
            pictureBox1 = new PictureBox();
            enterButton = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(397, 151);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(233, 21);
            textBoxUser.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(397, 216);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(233, 21);
            textBoxPassword.TabIndex = 1;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            userLabel.ForeColor = SystemColors.Desktop;
            userLabel.Location = new Point(397, 130);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(59, 17);
            userLabel.TabIndex = 2;
            userLabel.Text = "Usuário";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            passwordLabel.Location = new Point(397, 184);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(50, 17);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Senha";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(343, 451);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // enterButton
            // 
            enterButton.BackColor = SystemColors.ScrollBar;
            enterButton.FlatStyle = FlatStyle.Flat;
            enterButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            enterButton.Location = new Point(419, 252);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(75, 23);
            enterButton.TabIndex = 5;
            enterButton.Text = "Entrar";
            enterButton.UseVisualStyleBackColor = false;
            enterButton.Click += enterButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = SystemColors.ScrollBar;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.Location = new Point(516, 252);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 6;
            exitButton.Text = "Fechar";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // LoginForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 107, 142);
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(enterButton);
            Controls.Add(pictureBox1);
            Controls.Add(passwordLabel);
            Controls.Add(userLabel);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUser);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForms";
            Text = "Logar no Sistema";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUser;
        private TextBox textBoxPassword;
        private Label userLabel;
        private Label passwordLabel;
        private PictureBox pictureBox1;
        private Button enterButton;
        private Button exitButton;
    }
}