using BD.Helpers;
using BusinessLayer.Services.Client;
using System;
using System.Windows.Forms;

namespace BD.Manager
{
    public partial class CreateClient : UserControl
    {
        private readonly UserControl previousView;
        public CreateClient(UserControl previousView)
        {
            this.previousView = previousView;
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            var clientService = new ClientService();
            try
            {
                clientService.Create(new BusinessLayer.DTO.ClientData()
                {
                    FirstName = nameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    PhoneNumber = phoneNumberTextBox.Text,
                    Name = nameTextBox.Text + " " + lastNameTextBox.Text
                });
                MessageBox.Show($"Utworzono klienta {nameTextBox.Text} {lastNameTextBox.Text}");
                this.GoToPreviousView(previousView);
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
