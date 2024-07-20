namespace Capstone
{
    public partial class MainMenuForm : Form
    {
        private string currentUsername;

        public MainMenuForm(string username)
        {
            InitializeComponent();
            currentUsername = username;
            this.FormClosing += MainMenuForm_FormClosing;
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            WorkoutHistoryForm workoutHistoryForm = new WorkoutHistoryForm(currentUsername);
            workoutHistoryForm.Show();
            this.Hide();
        }

        private void newWorkoutButton_Click(object sender, EventArgs e)
        {
            NewWorkoutForm newWorkoutForm = new NewWorkoutForm(currentUsername);
            newWorkoutForm.Show();
            this.Hide();
        }
    }
}
