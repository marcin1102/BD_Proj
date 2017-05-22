using System;
using System.Linq;
using System.Windows.Forms;
using BusinessLayer.Searchers;
using BusinessLayer.Services.Client;
using BusinessLayer.Services.Object;
using BusinessLayer.Services.ObjectType;
using BusinessLayer.ValueObjects;

namespace BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            var clientToCreate = new ClientData
            {
                FirstName = "Bartosz",
                LastName = "Kowalski",
                Name = "Bartosz Kowalski",
                PhoneNumber = "111111111"
            };
            var clientService = new ClientService();
            clientService.Create(clientToCreate);
        }

        private void ShowClients_Click(object sender, EventArgs e)
        {
            var clientSearcher = new ClientSearcher();
            var clients = clientSearcher.GetClients();
            ClientDataGridView.DataSource = clients;
        }

        private void AddObjectToClient_Click(object sender, EventArgs e)
        {
            var clientSearcher = new ClientSearcher();
            var client = clientSearcher.GetClients().FirstOrDefault();
            var objectTypeSearcher = new ObjectTypeSearcher();
            var objectType = objectTypeSearcher.GetObjectTypes().FirstOrDefault();
            var objectData = new ObjectData
            {
                Name = "Seat",
                Type = "Ibiza",
                ObjectTypeCode = objectType?.Code,
                ClientId = client.Id
            };
            var objectService = new ObjectService();
            objectService.CreateObject(objectData);
        }

        private void AddObjectType_Click(object sender, EventArgs e)
        {
            var objectType = new ObjectTypeData
            {
                Code = "TEST",
                Name = "Test Object Type"
            };
            var objectTypeService = new ObjectTypeService();
            objectTypeService.CreateObjectType(objectType);
        }

        private void ShowObjects_Click(object sender, EventArgs e)
        {
            var objectSearcher = new ObjectSearcher();
            ObjectDataGridView.DataSource = objectSearcher.GetObjects();
        }
    }
}
