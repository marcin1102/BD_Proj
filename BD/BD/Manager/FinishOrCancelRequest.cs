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
    public partial class FinishOrCancelRequest : UserControl
    {
        private readonly UserControl previousView;
        public FinishOrCancelRequest(UserControl previousView, RequestData request,
            FormOpenMode mode)
        {
            this.previousView = previousView;
            InitializeComponent();

            requestStatusLabel.Text = request.Status;
            workerAssignedToActivityLabel.Text = request.Worker.LastName;

            if (mode == FormOpenMode.FINISH)
                submitButton.Text = "Zakończ Zgłoszenie";
            if (mode == FormOpenMode.CANCEL)
                submitButton.Text = "Anuluj Zgłoszenie";            
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.GoToPreviousView(previousView);
        }
    }
}
