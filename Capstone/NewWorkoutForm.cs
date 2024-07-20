using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone
{
    public partial class NewWorkoutForm : Form
    {
        public string currentUsername;

        public NewWorkoutForm(string username)
        {
            InitializeComponent();
            currentUsername = username;
            this.FormClosing += NewWorkoutForm_FormClosing;
        }

        private void NewWorkoutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm(currentUsername);
            mainMenuForm.Show();
        }

        private void logWorkoutButton_Click(object sender, EventArgs e)
        {
            string workoutName = workoutNameTextBox.Text;
            int weight, sets, reps;

            if (string.IsNullOrWhiteSpace(workoutName))
            {
                MessageBox.Show("Please Enter a Workout Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!int.TryParse(weightTextBox.Text, out weight))
            {
                MessageBox.Show("Please Enter Valid Number for Weight", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(setsTextBox.Text, out sets))
            {
                MessageBox.Show("Please Enter Valid Number for Sets", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(repsTextBox.Text, out reps))
            {
                MessageBox.Show("Please Enter Valid Number for Reps", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DatabaseHelper.InsertWorkout(currentUsername, workoutName, weight, sets, reps);

            workoutNameTextBox.Clear();
            weightTextBox.Clear();
            setsTextBox.Clear();
            repsTextBox.Clear();
            submittedLabel.Text = "Workout Submitted";
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
