using BD.Helpers;
using BusinessLayer.DTO;
using BusinessLayer.Searchers;
using BusinessLayer.Services;
using DataLayer.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BD.Manager
{
    public partial class CreateRequest : UserControl
    {
        private readonly UserControl previousView;
        private ICollection<ClientData> searchedClients;
        public CreateRequest(UserControl previousView)
        {
            InitializeComponent();
            this.previousView = previousView;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void registerRequestButton_Click(object sender, EventArgs e)
        {
            var client = (ClientData)clientDataGridView.CurrentRow.DataBoundItem;
            var @object = (ObjectData)objectDataGridView.CurrentRow.DataBoundItem;
            if(client != null && @object != null)
            {
                try
                {
                    var requestService = new RequestService();
                    await requestService.CreateRequest(new RequestData
                    {
                        Descr = descriptionTextBox.Text,
                        ObjId = @object.Id
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Nie wybrano klienta lub obiektu klienta!");
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            var firstName = firstNameTextBox.Text;
            var lastName = lastNameTextBox.Text;
            var phoneNumber = phoneNumberTextBox.Text;

            var clientSearcher = new ClientSearcher();
            try
            {
                searchedClients = await clientSearcher.SearchClients(firstName, lastName, phoneNumber);
                clientDataGridView.DataSource = searchedClients;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clientDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var client = (ClientData)clientDataGridView.CurrentRow.DataBoundItem;
            try
            {
                objectDataGridView.DataSource = searchedClients.Single(x => x.Id == client.Id).Objects.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.GoToPreviousView(previousView);
        }
    }
}
