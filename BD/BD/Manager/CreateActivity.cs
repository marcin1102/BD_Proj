using BD.Helpers;
using BusinessLayer.DTO;
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

		private void addBtn_Click(object sender, EventArgs e)
        {
			var service = new ActivityService();
			service.Create(new ActivityData()
			{
				Type = SelectedType.Type,
                Descr = descrTextBox.Text,
				Status = Statuses.OPN.ToString(),
				Result = "",
				ReqId = request.Id,
				WorkerId = null //TODO
			});

        }

		private void goBackBtn_Click(object sender, EventArgs e)
		{
			this.GoToPreviousView(previousView);
		}

		private void typeButton_Click(object sender, EventArgs e)
		{
			this.GoToNextView(new SelectActivityType(this));
		}
	}
}
