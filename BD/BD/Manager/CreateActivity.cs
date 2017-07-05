using BD.Helpers;
using BD.Manager.beta;
using BusinessLayer.DTO;
using BusinessLayer.Services;
using BusinessLayer.Services.Activity;
using DataLayer.Status;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD.Manager
{
    public partial class CreateActivity : UserControl
    {
		private readonly UserControl previousView;
		private readonly RequestData request;
		private readonly ActivityData activity;

		public WorkerData SelectedWorker { get; private set; }
		public ActivityTypeData SelectedType { get; private set; } 

		public void SetType(ActivityTypeData type)
		{
			SelectedType = type;
			typeTextBox.Text = SelectedType.Name;
		}

		public void SetWorker(WorkerData worker)
		{
			SelectedWorker = worker;
			workerTextBox.Text = worker.FirstName + " " + worker.LastName;
		}

		public CreateActivity(UserControl previousView, RequestData request)
		{
			InitializeComponent();
			this.previousView = previousView;
			this.request = request;
		}

		public CreateActivity(UserControl previousView, RequestData request, ActivityData activity)
		{
			InitializeComponent();
			this.previousView = previousView;
			this.activity = activity;
            SelectedWorker = activity.Worker;
            workerTextBox.Text = activity.Worker?.ToString();
            typeTextBox.Text = activity.Type;
            objectTypeLabel.Text = request.Object.ObjectTypeCode;
            objectNameLabel.Text = request.Object.Name;
            requestDescriptionRichTextBox.Text = request.Descr;
            descrTextBox.Text = activity.Descr;
            GetData();

			addBtn.Text = "Zapisz";
		}

		private async void GetData()
		{
            if(activity.WorkerId.HasValue)
            {
                SelectedWorker = activity.Worker;
                var searcher = new ActivitiesTypesDictionarySearcher();
                SelectedType = await searcher.GetByCode(activity.Type);
            }			
		}

		private async void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new ActivityService();
                if (activity == null)
                {
                    await service.Create(new ActivityData()
                    {
                        Type = SelectedType.Type,
                        Descr = descrTextBox.Text,
                        Status = Statuses.OPN.ToString(),
                        Result = "",
                        ReqId = request.Id,
                        WorkerId = SelectedWorker?.Id
                    });
                }
                else
                {
                    await service.UpdateDetails(new ActivityData()
                    {
                        Id = activity.Id,
                        Type = SelectedType != null ? SelectedType.Type : activity.Type,
                        Descr = descrTextBox.Text,
                        Status = activity.Status,
                        Result = activity.Result,
                        ReqId = activity.ReqId,
                        WorkerId = SelectedWorker?.Id
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }			
        }

		private void goBackBtn_Click(object sender, EventArgs e)
		{
            var requestForm = previousView as HandleRequest;
			this.GoToPreviousView(requestForm);
            requestForm.RefreshActivities();
		}

		private void typeButton_Click(object sender, EventArgs e)
		{
			this.GoToNextView(new SelectActivityType(this));
		}

		private void workerButton_Click(object sender, EventArgs e)
		{
			this.GoToNextView(new SelectWorker(this));
		}
	}
}
