using System;
using System.Windows.Forms;
using BD.Helpers;
using BusinessLayer.Searchers;
using System.Linq;
using System.Collections.Generic;
using BusinessLayer.DTO;
using BusinessLayer.Services.Object;

namespace BD.Manager
{
    public partial class CreateObject : UserControl
    {
        private readonly UserControl previousView;
        private readonly int clientId;
        public CreateObject(UserControl previousView, int clientId)
        {
            InitializeComponent();
            this.previousView = previousView;
            this.clientId = clientId;
            ShowObjectTypes();
        }

        public async void ShowObjectTypes()
        {
            var searcher = new ObjectTypeSearcher();
            var result = await searcher.GetObjectTypes();
            objectTypeComboBox.DataSource = result.ToList();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.GoToPreviousView(previousView);
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            var objectService = new ObjectService();
            try
            {
                await objectService.CreateObject(new ObjectData()
                {
                    Name = nameTextBox.Text,
                    ObjectTypeCode = ((ObjectTypeData)objectTypeComboBox.SelectedItem).Code,
                    ClientId = clientId
                });
                MessageBox.Show($"Dodano obiekt {nameTextBox.Text}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void objectTypeButton_Click(object sender, EventArgs e)
        {
            this.GoToNextView(new CreateObjectType(this));
        }
    }
}
