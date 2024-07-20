namespace Capstone
{
    partial class RegistrationForm
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
            usernameLabel = new Label();
            emailLabel = new Label();
            passwordLabel = new Label();
            emailTextBox = new TextBox();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            registerButton = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(197, 205);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(142, 37);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username:";
            usernameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(197, 168);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(88, 37);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            emailLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(197, 242);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(134, 37);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            passwordLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(291, 179);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(155, 23);
            emailTextBox.TabIndex = 7;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(345, 219);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(155, 23);
            usernameTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(337, 256);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(155, 23);
            passwordTextBox.TabIndex = 9;
            // 
            // registerButton
            // 
            registerButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerButton.Location = new Point(206, 282);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(104, 32);
            registerButton.TabIndex = 11;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.Location = new Point(206, 320);
            backButton.Name = "backButton";
            backButton.Size = new Size(125, 32);
            backButton.TabIndex = 12;
            backButton.Text = "Return to Login";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(registerButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            Controls.Add(usernameLabel);
            Name = "RegistrationForm";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private Label emailLabel;
        private Label passwordLabel;
        private TextBox emailTextBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button registerButton;
        private Button backButton;
    }
}