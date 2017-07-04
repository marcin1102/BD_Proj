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

        public HandleRequest(UserControl previousView, RequestData request)
        {
            InitializeComponent();
            this.previousView = previousView;
            this.request = request;
		}
<<<<<<< Updated upstream
		private void addActivityButton_Click(object sender, EventArgs e)
		{
=======

        private void goBackButton_Click(object sender, EventArgs e)
        {
>>>>>>> Stashed changes
			this.GoToNextView(new CreateActivity(this, request));
		}

		private void goBackButton_Click(object sender, EventArgs e)
		{
			
		}
	}
}
