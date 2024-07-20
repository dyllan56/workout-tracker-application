namespace Capstone
{
    partial class NewWorkoutForm
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
            addWorkoutLabel = new Label();
            workoutNameLabel = new Label();
            weightLabel = new Label();
            setsLabel = new Label();
            repsLabel = new Label();
            workoutNameTextBox = new TextBox();
            weightTextBox = new TextBox();
            setsTextBox = new TextBox();
            repsTextBox = new TextBox();
            logWorkoutButton = new Button();
            mainMenuButton = new Button();
            submittedLabel = new Label();
            SuspendLayout();
            // 
            // addWorkoutLabel
            // 
            addWorkoutLabel.AutoSize = true;
            addWorkoutLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addWorkoutLabel.Location = new Point(286, 9);
            addWorkoutLabel.Name = "addWorkoutLabel";
            addWorkoutLabel.Size = new Size(236, 37);
            addWorkoutLabel.TabIndex = 1;
            addWorkoutLabel.Text = "Add New Workout";
            addWorkoutLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // workoutNameLabel
            // 
            workoutNameLabel.AutoSize = true;
            workoutNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            workoutNameLabel.Location = new Point(110, 103);
            workoutNameLabel.Name = "workoutNameLabel";
            workoutNameLabel.Size = new Size(210, 37);
            workoutNameLabel.TabIndex = 2;
            workoutNameLabel.Text = "Workout Name: ";
            workoutNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weightLabel.Location = new Point(110, 163);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(108, 37);
            weightLabel.TabIndex = 3;
            weightLabel.Text = "Weight:";
            weightLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // setsLabel
            // 
            setsLabel.AutoSize = true;
            setsLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setsLabel.Location = new Point(110, 218);
            setsLabel.Name = "setsLabel";
            setsLabel.Size = new Size(71, 37);
            setsLabel.TabIndex = 4;
            setsLabel.Text = "Sets:";
            setsLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // repsLabel
            // 
            repsLabel.AutoSize = true;
            repsLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            repsLabel.Location = new Point(110, 272);
            repsLabel.Name = "repsLabel";
            repsLabel.Size = new Size(79, 37);
            repsLabel.TabIndex = 5;
            repsLabel.Text = "Reps:";
            repsLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // workoutNameTextBox
            // 
            workoutNameTextBox.Location = new Point(326, 117);
            workoutNameTextBox.Name = "workoutNameTextBox";
            workoutNameTextBox.Size = new Size(155, 23);
            workoutNameTextBox.TabIndex = 6;
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(224, 177);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(155, 23);
            weightTextBox.TabIndex = 7;
            // 
            // setsTextBox
            // 
            setsTextBox.Location = new Point(187, 232);
            setsTextBox.Name = "setsTextBox";
            setsTextBox.Size = new Size(155, 23);
            setsTextBox.TabIndex = 8;
            // 
            // repsTextBox
            // 
            repsTextBox.Location = new Point(195, 287);
            repsTextBox.Name = "repsTextBox";
            repsTextBox.Size = new Size(155, 23);
            repsTextBox.TabIndex = 9;
            // 
            // logWorkoutButton
            // 
            logWorkoutButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logWorkoutButton.Location = new Point(114, 328);
            logWorkoutButton.Name = "logWorkoutButton";
            logWorkoutButton.Size = new Size(104, 32);
            logWorkoutButton.TabIndex = 10;
            logWorkoutButton.Text = "Log Workout";
            logWorkoutButton.UseVisualStyleBackColor = true;
            logWorkoutButton.Click += logWorkoutButton_Click;
            // 
            // mainMenuButton
            // 
            mainMenuButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainMenuButton.Location = new Point(114, 366);
            mainMenuButton.Name = "mainMenuButton";
            mainMenuButton.Size = new Size(104, 32);
            mainMenuButton.TabIndex = 11;
            mainMenuButton.Text = "Main Menu";
            mainMenuButton.UseVisualStyleBackColor = true;
            mainMenuButton.Click += mainMenuButton_Click;
            // 
            // submittedLabel
            // 
            submittedLabel.AutoSize = true;
            submittedLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submittedLabel.Location = new Point(224, 330);
            submittedLabel.Name = "submittedLabel";
            submittedLabel.Size = new Size(0, 30);
            submittedLabel.TabIndex = 12;
            // 
            // NewWorkoutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(submittedLabel);
            Controls.Add(mainMenuButton);
            Controls.Add(logWorkoutButton);
            Controls.Add(repsTextBox);
            Controls.Add(setsTextBox);
            Controls.Add(weightTextBox);
            Controls.Add(workoutNameTextBox);
            Controls.Add(repsLabel);
            Controls.Add(setsLabel);
            Controls.Add(weightLabel);
            Controls.Add(workoutNameLabel);
            Controls.Add(addWorkoutLabel);
            Name = "NewWorkoutForm";
            Text = "New Workout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addWorkoutLabel;
        private Label workoutNameLabel;
        private Label weightLabel;
        private Label setsLabel;
        private Label repsLabel;
        private TextBox workoutNameTextBox;
        private TextBox weightTextBox;
        private TextBox setsTextBox;
        private TextBox repsTextBox;
        private Button logWorkoutButton;
        private Button mainMenuButton;
        private Label submittedLabel;
    }
}