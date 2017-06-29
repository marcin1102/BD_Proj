using BD.Helpers;
using BusinessLayer.DTO;
using BusinessLayer.Searchers;
using BusinessLayer.Services.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void registerRequestButton_Click(object sender, EventArgs e)
        {
            //var client = (ClientData)clientDataGridView.CurrentRow.DataBoundItem;
            //var description = descriptionTextBox.Text;


            //var requestService = new RequestService();
            //requestService.CreateObject();
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
