using BD.Helpers;
using BusinessLayer.DTO;
using System;
using System.Windows.Forms;

namespace BD.Manager
{
    public partial class ManagerPanel : UserControl
    {
        public ClientData SelectedClient { get; private set; }

        public ManagerPanel()
        {
            InitializeComponent();
        }

        private void ManagerPanel_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        private void selectClientButton_Click(object sender, EventArgs e)
        {
            this.GoToNextView(new SelectClient(this));
        }

        public void SetClient(ClientData client)
        {
            SelectedClient = client;
            currentClientTextBox.Text = client.Name;
        }
    }
}
