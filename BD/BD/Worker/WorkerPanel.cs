using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BD.Helpers;
using BusinessLayer.DTO;
using BusinessLayer.Searchers;
using DataLayer;
using DataLayer.Status;

namespace BD.Worker
{
    public partial class WorkerPanel : UserControl
    {
        public ObjectData SelectedObject { get; private set; }

        public WorkerPanel()
        {
            InitializeComponent();
            statusComboBox.DataSource = Enum.GetValues(typeof(Statuses));
        }

        private void WorkerPanel_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        public void SetObject(ObjectData @object)
        {
            SelectedObject = @object;
            currentObjectTextBox.Text = @object.Name;
        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            var searcher = new ActivitySearcher();
            try
            {
                if (string.IsNullOrEmpty(statusComboBox.Text) || SelectedObject == null)
                    activitiesDataGridView.DataSource = await searcher.GetActivities(statusComboBox.Text);
                else
                    activitiesDataGridView.DataSource = await searcher.GetActivities(statusComboBox.Text, SelectedObject.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void finishRequestButton_Click(object sender, EventArgs e)
        {
            try
            {
                var activity = (ActivityData)activitiesDataGridView.CurrentRow.DataBoundItem;
                this.GoToNextView(new FinishOrCancelActivity(this, FormOpenMode.FINISH, activity, SelectedObject != null ? SelectedObject : activity.Request.Object));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie wybrano czynności.");
            }
        }

        private void cancelRequestButton_Click(object sender, EventArgs e)
        {
            try
            {
                var activity = (ActivityData)activitiesDataGridView.CurrentRow.DataBoundItem;
                this.GoToNextView(new FinishOrCancelActivity(this, FormOpenMode.CANCEL, activity, SelectedObject != null ? SelectedObject : activity.Request.Object));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie wybrano czynności.");
            }
        }

        private void openObjectListBtn_Click(object sender, EventArgs e)
        {
            this.GoToNextView(new SelectObject(this));
        }

        internal async void RefreshView()
        {
            var searcher = new ActivitySearcher();
            try
            {
                if (string.IsNullOrEmpty(statusComboBox.Text) || SelectedObject == null)
                    activitiesDataGridView.DataSource = await searcher.GetActivities(statusComboBox.Text);
                else
                    activitiesDataGridView.DataSource = await searcher.GetActivities(statusComboBox.Text, SelectedObject.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
