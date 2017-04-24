using System;
using System.Windows.Forms;
using BusinessLayer.Commands;
using BusinessLayer.Searchers;
using BusinessLayer.Services;

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
            clientService.CreateClient(clientToCreate);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var clientSearcher = new ClientSearcher();
            dataGridView1.DataSource = clientSearcher.GetClients();
        }
    }
}
