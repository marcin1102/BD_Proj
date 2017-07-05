using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BD.Helpers;
using BusinessLayer;
using BusinessLayer.DTO;
using BusinessLayer.Searchers;
using BusinessLayer.Services.Activity;
using DataLayer.Status;

namespace BD
{
    public partial class FinishOrCancelActivity : UserControl
    {
        private readonly UserControl previousControl;
        private readonly RequestData request;

        private FormOpenMode MODE;
        private ActivityData ACTIVITY;

        public FinishOrCancelActivity(UserControl previousControl)
        {
            this.previousControl = previousControl;
            InitializeComponent();
        }

        public void LoadObjectDataToLabels(ObjectData @object)
        {
            objectTypeLabel.Text = @object.ObjectTypeCode;
            objectNameLabel.Text = @object.Name;
        }

        public void LoadActivityDataToLabels(ActivityData activity)
        {
            activityIdLabel.Text = activity.Id.ToString();
            activityStatusLabel.Text = activity.Status;
            activityDescrTextBox.Text = activity.Descr;
        }

        public void LoadRequestDesc(ActivityData activity)
        {
            var requestSearcher = new RequestSearcher();
            try
            {
                requestDescrTextBox.Text = requestSearcher.GetRequest(activity.ReqId).Result.Descr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public FinishOrCancelActivity(UserControl previousControl, FormOpenMode mode, ActivityData activity, ObjectData @object)
        {
            this.previousControl = previousControl;
            InitializeComponent();

            MODE = mode;
            ACTIVITY = activity;

            if (mode == FormOpenMode.FINISH)
                confirmBtn.Text = "Zakończ";
            else if (mode == FormOpenMode.CANCEL)
                confirmBtn.Text = "Anuluj";

            LoadObjectDataToLabels(@object);
            LoadActivityDataToLabels(activity);
            LoadRequestDesc(activity);
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.GoToPreviousView(previousControl);
        }

        private async void ChangeActivityStatus()
        {
            var service = new ActivityService();
            if (MODE == FormOpenMode.CANCEL)
            {
                await service.UpdateDetails(new ActivityData()
                {
                    Status = Statuses.CNL.ToString()
                });
            }
            else if (MODE == FormOpenMode.FINISH)
            {
                await service.UpdateDetails(new ActivityData()
                {
                    Status = Statuses.DON.ToString()
                });
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(activityResultTextBox.Text))
            {
                ChangeActivityStatus();
            }
            else
            {
                MessageBox.Show("Wynik nie został uzupełniony");
            }
        }
    }
}
