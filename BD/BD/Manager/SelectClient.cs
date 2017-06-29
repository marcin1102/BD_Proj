using System;
using System.Windows.Forms;
using BD.Helpers;
using BusinessLayer.Searchers;
using BusinessLayer.DTO;

namespace BD.Manager
{
    public partial class SelectClient : UserControl
    {
        private readonly UserControl previousControl;

        public SelectClient(UserControl previousControl)
        {
            this.previousControl = previousControl;
            InitializeComponent();
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            this.GoToNextView(new CreateClient(this));
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            var firstName = firstNameTextBox.Text;
            var lastName = lastNameTextBox.Text;
            var phoneNumber = phoneNumberTextBox.Text;

            var clientSearcher = new ClientSearcher();
            clientDataGridView.DataSource = await clientSearcher.SearchClients(firstName, lastName, phoneNumber);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.GoToPreviousView(previousControl);
        }

        private void chooseClientButton_Click(object sender, EventArgs e)
        {
            var client = (ClientData)clientDataGridView.CurrentRow.DataBoundItem;
            var managerPanel = previousControl as ManagerPanel;
            managerPanel.SetClient(client);
            this.GoToPreviousView(managerPanel);
        }
    }
}
