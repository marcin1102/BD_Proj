using System;
using System.Windows.Forms;
using BusinessLayer.Commands.Client;
using BusinessLayer.Commands.Object;
using BusinessLayer.Commands.ObjectType;
using BusinessLayer.Searchers;
using BusinessLayer.Services.Client;
using BusinessLayer.Services.Object;
using BusinessLayer.Services.ObjectType;

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
            var clientToCreate = new CreateClient("Bartosz", "Kowalski", "Bartosz Kowalski", "111111111");
            var clientService = new ClientService();
            var id = clientService.CreateClient(clientToCreate);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var clientSearcher = new ClientSearcher();
            var clients = clientSearcher.GetClients();
            ClientDataGridView.DataSource = clients;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var command = new CreateObject(1, "TEST", "Ibiza", "TEST");
            var objectService = new ObjectService();
            var id = objectService.CreateObject(command);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var command = new CreateObjectType("TEST", "Test Object Type");
            var objectTypeService = new ObjectTypeService();
            objectTypeService.CreateObjectType(command);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var objectSearcher = new ObjectSearcher();
            ObjectDataGridView.DataSource = objectSearcher.GetObjects();
        }
    }
}
