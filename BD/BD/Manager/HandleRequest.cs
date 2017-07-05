using System;
using System.Linq;
using System.Windows.Forms;
using BD.Helpers;
using BusinessLayer.DTO;
using BusinessLayer.Searchers;

namespace BD.Manager.beta
{
    public partial class HandleRequest : UserControl
    {
        private readonly UserControl previousView;
        private RequestData request;

        public HandleRequest(UserControl previousView, RequestData request)
        {
            InitializeComponent();
            this.previousView = previousView;
            this.request = request;
            managerLabel.Text = request.Worker.ToString();
            requestStatusLabel.Text = request.Status;
            objectTypeLabel.Text = request.Object.ObjectTypeCode;
            objectNameLabel.Text = request.Object.Name;
            requestDescrRichTextBox.Text = request.Descr;
            requestResultRichTextBox.Text = request.Result;
            activitiesDataGridView.DataSource = request.Activities.ToList();
		}

        private void addActivityButton_Click(object sender, EventArgs e)
        {
            this.GoToNextView(new CreateActivity(this, request));
        }

        public async void RefreshDescription()
        {
            var requestSearcher = new RequestSearcher();
            request = await requestSearcher.GetRequest(request.Id);
            activityDescrRichTextBox.Text = request.Descr;
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
			this.GoToPreviousView(previousView);
		}

        private void finishRequestButton_Click(object sender, EventArgs e)
        {
            this.GoToNextView(new CloseOrCancelRequest(this, request, true));
        }

        private void activitiesDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var activity = (ActivityData)activitiesDataGridView.CurrentRow.DataBoundItem;
            activityDescrRichTextBox.Text = activity.Descr;
            activityResultRichTextBox.Text = activity.Result;
        }

        public async void RefreshActivities()
        {
            try
            {
                var requestSearcher = new RequestSearcher();
                request = await requestSearcher.GetRequest(request.Id);
                activitiesDataGridView.DataSource = request.Activities;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async void RefreshControls()
        {
            try
            {
                var requestSearcher = new RequestSearcher();
                request = await requestSearcher.GetRequest(request.Id);
                activitiesDataGridView.DataSource = request.Activities;
                requestStatusLabel.Text = request.Status;
                requestResultRichTextBox.Text = request.Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void editButton_Click(object sender, EventArgs e)
		{
            try
            {
                this.GoToNextView(new CreateActivity(this, request, (ActivityData)activitiesDataGridView.CurrentRow.DataBoundItem));
            }
            catch (Exception)
            {
                MessageBox.Show("Nie wybrano aktywności do edycji");
            }			
		}

        private void editRequestButton_Click(object sender, EventArgs e)
        {
            this.GoToNextView(new CreateRequest(this, true, request.Id));
        }

        private void cancelActivityButton_Click(object sender, EventArgs e)
        {
            this.GoToNextView(new CloseOrCancelRequest(this, request, false));
        }
    }
}
