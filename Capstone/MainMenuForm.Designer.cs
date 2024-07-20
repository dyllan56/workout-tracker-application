namespace Capstone
{
    partial class MainMenuForm
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
            mainMenu = new Label();
            newWorkoutButton = new Button();
            historyButton = new Button();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.AutoSize = true;
            mainMenu.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainMenu.Location = new Point(327, 9);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(152, 37);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "Main Menu";
            mainMenu.TextAlign = ContentAlignment.TopCenter;
            // 
            // newWorkoutButton
            // 
            newWorkoutButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newWorkoutButton.Location = new Point(277, 118);
            newWorkoutButton.Name = "newWorkoutButton";
            newWorkoutButton.Size = new Size(256, 49);
            newWorkoutButton.TabIndex = 1;
            newWorkoutButton.Text = "Add New Workout";
            newWorkoutButton.UseVisualStyleBackColor = true;
            newWorkoutButton.Click += newWorkoutButton_Click;
            // 
            // historyButton
            // 
            historyButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            historyButton.Location = new Point(277, 221);
            historyButton.Name = "historyButton";
            historyButton.Size = new Size(256, 87);
            historyButton.TabIndex = 2;
            historyButton.Text = "View Workout History";
            historyButton.UseVisualStyleBackColor = true;
            historyButton.Click += historyButton_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(historyButton);
            Controls.Add(newWorkoutButton);
            Controls.Add(mainMenu);
            ForeColor = SystemColors.ControlText;
            Name = "MainMenuForm";
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainMenu;
        private Button newWorkoutButton;
        private Button historyButton;
    }
}
