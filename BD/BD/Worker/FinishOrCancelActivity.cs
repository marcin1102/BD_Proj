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
using BD.Worker;
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

        public async void LoadRequestDesc(ActivityData activity)
        {
            var requestSearcher = new RequestSearcher();
            try
            {
                var request = await requestSearcher.GetRequest(activity.ReqId);
                requestDescrTextBox.Text = request.Descr;
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
            try
            {
                var workerPanel = previousControl as WorkerPanel;
                this.GoToPreviousView(workerPanel);
                workerPanel.RefreshView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void ChangeActivityStatus()
        {
            try
            {
                var service = new ActivityService();
                if (MODE == FormOpenMode.CANCEL)
                {
                    await service.FinishOrCancel(ACTIVITY.Id, activityResultTextBox.Text, false);
                }
                else if (MODE == FormOpenMode.FINISH)
                {
                    await service.FinishOrCancel(ACTIVITY.Id, activityResultTextBox.Text, true);
                }

                RefreshView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void RefreshView()
        {
            var searcher = new ActivitySearcher();
            ACTIVITY = await searcher.GetActivity(ACTIVITY.Id);
            LoadActivityDataToLabels(ACTIVITY);
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
