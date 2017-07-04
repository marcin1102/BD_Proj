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

		public CreateActivity(UserControl previousView, RequestData request)
		{
			InitializeComponent();
			this.previousView = previousView;
			this.request = request;
		}

		private void button1_Click(object sender, EventArgs e)
        {
			var service = new ActivityService();
			service.Create(new ActivityData()
			{
				Type = "", //TODO
				Descr = descrTextBox.Text,
				Status = Statuses.OPN.ToString(),
				Result = "",
				ReqId = request.Id,
				WorkerId = null //TODO
			});

        }

		private void button2_Click(object sender, EventArgs e)
		{
			this.GoToPreviousView(previousView);
		}
	}
}
