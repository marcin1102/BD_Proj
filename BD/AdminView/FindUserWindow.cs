using System;
using System.Windows.Forms;
using BusinessLayer.Searchers;
using AdminView.Helpers;
using BusinessLayer.DTO;

namespace AdminView
{
    public partial class FindUserWindow : UserControl
    {
        private readonly bool wantEdit;
        public FindUserWindow(bool wantEdit)
        {
            InitializeComponent();
            this.wantEdit = wantEdit;
        }

        private async void searchBT_Click(object sender, EventArgs e)
        {
            var text = searchTB.Text;
            var workerSearcher = new WorkerSearcher();
            var result = await workerSearcher.FullTextSearch(text);
            usersDGV.DataSource = result;
        }

        private void nextViewBT_Click(object sender, EventArgs e)
        {
            var worker = (WorkerData)usersDGV.CurrentRow.DataBoundItem;
            if (wantEdit)
                this.GoToNextView(new UpdateUserWindow(this, worker.UName));
            else if (worker.Expiration == null)
                this.GoToNextView(new DeactivateUserWindow(this, worker.UName));
            else
                this.GoToNextView(new ActivateUserWindow(this, worker.UName));
        }

        private void returnBT_Click(object sender, EventArgs e)
        {
            this.ClearControls();
        }
    }
}
