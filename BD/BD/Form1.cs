using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            ClientDataGridView.DataSource = clientSearcher.GetClients().Result;
        }

        private async void AddObjectToClient_Click(object sender, EventArgs e)
        {
            var clientSearcher = new ClientSearcher();
            var clients = await clientSearcher.GetClients();
            var client = clients.FirstOrDefault();
            var objectTypeSearcher = new ObjectTypeSearcher();
            var objectTypes =  await objectTypeSearcher.GetObjectTypes();
            var objectType = objectTypes.FirstOrDefault();
            var objectData = new ObjectData
            {
                Name = "Seat",
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
            ObjectDataGridView.DataSource = objectSearcher.GetObjects().Result;
        }

        private void ObjectsFirstClient_Click(object sender, EventArgs e)
        {
            var objectSearcher = new ObjectSearcher();
            var clientId = (int)ClientDataGridView.CurrentCell.Value;
            ObjectDataGridView.DataSource = objectSearcher.GetObjectsByClientId(clientId).Result;
        }

        private async void UpdateObjects_Click(object sender, EventArgs e)
        {
            var clientService = new ClientService();

            var objects = new List<ObjectData>()
            {
                new ObjectData
                {
                    ClientId = 1,
                    Name = "HWDP",
                    ObjectTypeCode = "ABC"
                },
                new ObjectData
                {
                    Id = 2,
                    ClientId = 1,
                    Name = "ZMIENIONY2",
                    ObjectTypeCode = "TEST"
                },
                new ObjectData
                {
                    Id = 6,
                    ClientId = 1,
                    Name = "STALY",
                    ObjectTypeCode = "ABC"
                }
            };

            clientService.UpdateObjects(1, objects);

            //await objectService.UpdateObjectDetails(new ObjectData
            //   {
            //       Name = "Andrzej",
            //       Id = 1
            //   });

            //objectService.UpdateObjectType(new ObjectData
            //{
            //    ObjectTypeCode = "TEST",
            //    Id = 1
            //});
        }
    }
}
