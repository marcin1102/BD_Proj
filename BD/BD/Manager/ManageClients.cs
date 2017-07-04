using System;
using System.Windows.Forms;
using BD.Helpers;
using BusinessLayer.Searchers;
using BusinessLayer.DTO;
using System.Collections.Generic;
using System.Linq;

namespace BD.Manager
{
    public partial class ManageClients : UserControl
    {
        private readonly UserControl previousControl;
        private ICollection<ClientData> searchedClients;

        public ManageClients(UserControl previousControl)
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
            searchedClients = await clientSearcher.SearchClients(firstName, lastName, phoneNumber);
            clientDataGridView.DataSource = searchedClients;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.GoToPreviousView(previousControl);
        }

        private void chooseClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                var client = (ClientData)clientDataGridView.CurrentRow.DataBoundItem;
                var managerPanel = previousControl as ManagerPanel;
                if (managerPanel != null)
                {
                    managerPanel.SetClient(client);
                    this.GoToPreviousView(managerPanel);
                }
                else
                {
                    var createRequestPanel = previousControl as CreateRequest;
                    createRequestPanel.SetSearchFields(client.LastName, client.FirstName, client.PhoneNumber);
                    this.GoToPreviousView(createRequestPanel);
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               
        }

        private void addObjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                var client = (ClientData)clientDataGridView.CurrentRow.DataBoundItem;
                this.GoToNextView(new CreateObject(this, client.Id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clientDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var client = (ClientData)clientDataGridView.CurrentRow.DataBoundItem;
                objectDataGridView.DataSource = searchedClients.Single(x => x.Id == client.Id).Objects.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
