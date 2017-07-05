using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BD.Helpers;
using BusinessLayer.DTO;
using BusinessLayer.Services.Activity;
using BusinessLayer.Searchers;

namespace BD.Manager.beta
{
    public partial class HandleRequest : UserControl
    {
        private readonly UserControl previousView;
        private readonly RequestData request;

        public HandleRequest(UserControl previousView, RequestData request)
        {
            InitializeComponent();
            this.previousView = previousView;
            this.request = request;
            managerLabel.Text = request.Worker.FullName();
            requestStatusLabel.Text = request.Status;
            objectTypeLabel.Text = request.Object.ObjectTypeCode;
            ObjectNameLabel.Text = request.Object.Name;
            requestDescrRichTextBox.Text = request.Descr;
            requestResultRichTextBox.Text = request.Result;
            activitiesDataGridView.DataSource = request.Activities;
		}

        private void addActivityButton_Click(object sender, EventArgs e)
        {
            this.GoToNextView(new CreateActivity(this, request));
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
			this.GoToPreviousView(previousView);
		}

        private void finishRequestButton_Click(object sender, EventArgs e)
        {

        }

        private void activitiesDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var activity = (ActivityData)activitiesDataGridView.CurrentRow.DataBoundItem;
            activityDescrRichTextBox.Text = activity.Descr;
            activityResultRichTextBox.Text = activity.Result;
        }
    }
}
