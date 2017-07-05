using BD.Helpers;
using BusinessLayer.DTO;
using BusinessLayer.Searchers;
using DataLayer.Status;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BD.Manager.beta;
using System.Linq;

namespace BD.Manager
{
    public partial class ManagerPanel : UserControl
    {
        public ClientData SelectedClient { get; private set; }
        private ICollection<string> statuses = Enum.GetNames(typeof(Statuses));

        public ManagerPanel()
        {
            InitializeComponent();
            statusComboBox.DataSource = statuses;
        }

        private void ManagerPanel_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        private void selectClientButton_Click(object sender, EventArgs e)
        {
            this.GoToNextView(new ManageClients(this));
        }

        public void SetClient(ClientData client)
        {
            SelectedClient = client;
            currentClientTextBox.Text = client.Name;
        }

        private void registerRequestButton_Click(object sender, EventArgs e)
        {
            this.GoToNextView(new CreateRequest(this));
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            var searcher = new RequestSearcher();
            var status = !string.IsNullOrEmpty(statusComboBox.Text) ? new List<string> { statusComboBox.Text } : Enum.GetNames(typeof(Statuses)).OfType<string>().ToList();
            try
            {
                if (string.IsNullOrEmpty(currentClientTextBox.Text) || SelectedClient == null)
                    requestsDataGridView.DataSource = await searcher.GetRequestsWithStatuses(status);
                else
                    requestsDataGridView.DataSource = await searcher.GetClientRequests(SelectedClient.Id, status);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void manageRequestButton_Click(object sender, EventArgs e)
        {
            this.GoToNextView(new HandleRequest(this, (RequestData)requestsDataGridView.CurrentRow.DataBoundItem));
        }
    }
}
