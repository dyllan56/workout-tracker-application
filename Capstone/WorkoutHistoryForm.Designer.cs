namespace Capstone
{
    partial class WorkoutHistoryForm
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
            workoutHistoryLabel = new Label();
            historyMainMenuButton = new Button();
            workoutHistoryListbox = new ListBox();
            monthCalendar = new MonthCalendar();
            SuspendLayout();
            // 
            // workoutHistoryLabel
            // 
            workoutHistoryLabel.AutoSize = true;
            workoutHistoryLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            workoutHistoryLabel.Location = new Point(280, 9);
            workoutHistoryLabel.Name = "workoutHistoryLabel";
            workoutHistoryLabel.Size = new Size(210, 37);
            workoutHistoryLabel.TabIndex = 0;
            workoutHistoryLabel.Text = "Workout History";
            // 
            // historyMainMenuButton
            // 
            historyMainMenuButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            historyMainMenuButton.Location = new Point(280, 379);
            historyMainMenuButton.Name = "historyMainMenuButton";
            historyMainMenuButton.Size = new Size(104, 32);
            historyMainMenuButton.TabIndex = 12;
            historyMainMenuButton.Text = "Main Menu";
            historyMainMenuButton.UseVisualStyleBackColor = true;
            historyMainMenuButton.Click += historyMainMenuButton_Click;
            // 
            // workoutHistoryListbox
            // 
            workoutHistoryListbox.FormattingEnabled = true;
            workoutHistoryListbox.ItemHeight = 15;
            workoutHistoryListbox.Location = new Point(280, 60);
            workoutHistoryListbox.Name = "workoutHistoryListbox";
            workoutHistoryListbox.Size = new Size(421, 304);
            workoutHistoryListbox.TabIndex = 13;
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(50, 60);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 14;
            // 
            // WorkoutHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(monthCalendar);
            Controls.Add(workoutHistoryListbox);
            Controls.Add(historyMainMenuButton);
            Controls.Add(workoutHistoryLabel);
            Name = "WorkoutHistoryForm";
            Text = "Workout History";
            Load += WorkoutHistoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label workoutHistoryLabel;
        private Button historyMainMenuButton;
        private ListBox workoutHistoryListbox;
        private MonthCalendar monthCalendar;
    }
}