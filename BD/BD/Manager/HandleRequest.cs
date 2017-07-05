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

namespace BD.Manager.beta
{
    public partial class HandleRequest : UserControl
    {
        private readonly UserControl previousView;

        private readonly RequestData request;

        public HandleRequest(UserControl previousView, RequestData request, FormOpenMode mode)
        {
            InitializeComponent();
            this.previousView = previousView;
            this.request = request;
            requestStatusLabel.Text = request.Status;
            workerAssignedToActivityLabel.Text = request.Worker.LastName;
        }

        private void addActivityButton_Click(object sender, EventArgs e)
        {
            this.GoToNextView(new CreateOrEditActivity(this, request, FormOpenMode.CREATE));
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
			this.GoToPreviousView(previousView);
		}

        private void editActivityButton_Click(object sender, EventArgs e)
        {
            this.GoToNextView(new CreateOrEditActivity(this, request, FormOpenMode.EDIT));
        }
    }
}
