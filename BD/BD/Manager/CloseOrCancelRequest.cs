using System.Windows.Forms;
using BusinessLayer.Services;
using BusinessLayer.Searchers;
using BusinessLayer.DTO;
using DataLayer.Status;
using System.Linq;
using BD.Helpers;
using System;

namespace BD.Manager.beta
{
    public partial class CloseOrCancelRequest : UserControl
    {
        private readonly RequestService service;
        private readonly WorkerSearcher workerSearcher;
        private readonly UserControl previousView;
        private readonly RequestData request;
        private readonly bool isFinished;
        private const string finished = "zakonczonono";
        private const string cancelled = "anulowano";
        public CloseOrCancelRequest(UserControl previousView, RequestData request, bool isFinished)
        {
            InitializeComponent();
            this.previousView = previousView;
            service = new RequestService();
            this.request = request;
            this.isFinished = isFinished;
            managerLabel.Text = request.Worker.ToString();
            requestStatusLabel.Text = request.Status;
            objectTypeLabel.Text = request.Object.ObjectTypeCode;
            objectNameLabel.Text = request.Object.Name;
            requestDescrRichTextBox.Text = request.Descr;
            requestResultRichTextBox.Text = request.Result;
            activitiesDataGridView.DataSource = request.Activities.ToList();
        }

        private async void submitButton_Click(object sender, System.EventArgs e)
        {
            if (isFinished)
                FinishRequest(Statuses.DON);
            else
                FinishRequest(Statuses.CNL);
        }

        private async void FinishRequest(Statuses status)
        {
            if (request.Activities.Any(x => x.Status == Statuses.OPN.ToString() || x.Status == Statuses.PRG.ToString()))
            {
                var result = MessageBox.Show("Masz niezakonczone aktywności związane z tym zadaniem. Czy na pewno chcesz zakończyć to zadanie?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;
            }

            try
            {
                await service.SetRequestResult(request.Id, requestResultRichTextBox.Text);
                await service.SetRequestStatus(request.Id, status);
                var endMessagePart = isFinished ? finished : cancelled;
                MessageBox.Show($"Zadanie {endMessagePart} pomyślnie");
                GoBack();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GoBack()
        {
            var view = previousView as HandleRequest;
            view.RefreshControls();
            this.GoToPreviousView(view);
        }

        private void goBackButton_Click(object sender, System.EventArgs e)
        {
            this.GoToPreviousView(previousView);
        }
    }
}
