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
    public partial class WorkoutHistoryForm : Form
    {
        private string currentUsername;

        public WorkoutHistoryForm(string username)
        {
            InitializeComponent();
            currentUsername = username;
            this.FormClosing += WorkoutHistoryForm_FormClosing;
        }

        private void WorkoutHistoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm(currentUsername);
            mainMenuForm.Show();
        }

        private void WorkoutHistoryForm_Load(object sender, EventArgs e)
        {
            monthCalendar.DateSelected += new DateRangeEventHandler(this.monthCalendar_DateSelected);
        }

        private void monthCalendar_DateSelected(object? sender, DateRangeEventArgs e)
        {
            string selectedDate = e.Start.ToString("yyyy-MM-dd");
            LoadWorkoutsByDate(selectedDate);
        }

        private void LoadWorkoutsByDate(string date)
        {
            workoutHistoryListbox.Items.Clear();
            using (var reader = DatabaseHelper.GetWorkoutsByDateAndUser(currentUsername, date))
            {
                while (reader.Read())
                {
                    string entry = $"Name: {reader["WorkoutName"]}," +
                        $" Weight: {reader["Weight"]}," +
                        $" Sets: {reader["Sets"]}," +
                        $" Reps: {reader["Reps"]}";
                    workoutHistoryListbox.Items.Add(entry);
                }
            }
        }

        private void historyMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
