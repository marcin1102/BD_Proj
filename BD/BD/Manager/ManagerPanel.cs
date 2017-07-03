using BD.Helpers;
using BusinessLayer.DTO;
using BusinessLayer.Searchers;
using DataLayer.Status;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BD.Manager
{
    public partial class ManagerPanel : UserControl
    {
        public ClientData SelectedClient { get; private set; }

        public ManagerPanel()
        {
            InitializeComponent();
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
            try
            {
                if (string.IsNullOrEmpty(currentClientTextBox.Text) || SelectedClient == null)
                   requestsDataGridView.DataSource = await searcher.GetRequestsWithStatuses(new List<Statuses>
                    {
                        Statuses.OPN,
                        Statuses.PRG
                    });
                else
                    requestsDataGridView.DataSource = await searcher.GetClientRequests(SelectedClient.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
