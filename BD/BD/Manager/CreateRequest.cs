using BD.Helpers;
using BD.Manager.beta;
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
        private bool editMode;
        private readonly int requestId;
        public CreateRequest(UserControl previousView)
        {
            InitializeComponent();
            this.previousView = previousView;
        }

        public CreateRequest(UserControl previousView, bool editMode, int requestId)
        {
            InitializeComponent();
            this.previousView = previousView;
            this.editMode = editMode;
            this.requestId = requestId;
        }

        private async void registerRequestButton_Click(object sender, EventArgs e)
        {
            if(editMode == true)
            {
                EditData();
                MessageBox.Show("Dane zostaly zaktualizowane");
                var view = previousView as HandleRequest;
                view.RefreshDescription();
                this.GoToPreviousView(view);
                return;
            }

            try
            {
                var client = (ClientData)clientDataGridView.CurrentRow.DataBoundItem;
                var @object = (ObjectData)objectDataGridView.CurrentRow.DataBoundItem;
                if (client != null && @object != null)
                {
                    var requestService = new RequestService();
                    await requestService.CreateRequest(new RequestData
                    {
                        Descr = descriptionTextBox.Text,
                        ObjId = @object.Id,
                        Worker = LoggedUser.Worker,
                        WorkerId = LoggedUser.Worker.Id
                    });
                    MessageBox.Show("Zadanie dodano z powodzeniem!");
                }
                else
                    MessageBox.Show("Nie wybrano klienta lub obiektu klienta!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }

        private async void EditData()
        {
            try
            {
                var requestService = new RequestService();
                await requestService.UpdateDescription(requestId, descriptionTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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

        private void manageClientsButton_Click(object sender, EventArgs e)
        {
            this.GoToNextView(new ManageClients(this));
        }

        public void SetSearchFields(string lastName, string firstName, string phoneNumber)
        {
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            phoneNumberTextBox.Text = phoneNumber;
        }
    }
}
