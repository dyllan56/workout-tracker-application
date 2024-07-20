namespace Capstone
{
    partial class LoginForm
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
            passwordLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            newAccountButton = new Button();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(202, 152);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(142, 37);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "Username:";
            usernameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(202, 189);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(134, 37);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password:";
            passwordLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(350, 167);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(155, 23);
            usernameTextBox.TabIndex = 9;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(342, 203);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(155, 23);
            passwordTextBox.TabIndex = 10;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.Location = new Point(211, 229);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(104, 32);
            loginButton.TabIndex = 12;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // newAccountButton
            // 
            newAccountButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newAccountButton.Location = new Point(211, 267);
            newAccountButton.Name = "newAccountButton";
            newAccountButton.Size = new Size(139, 32);
            newAccountButton.TabIndex = 13;
            newAccountButton.Text = "Create New Account";
            newAccountButton.UseVisualStyleBackColor = true;
            newAccountButton.Click += newAccountButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(newAccountButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Button newAccountButton;
    }
}