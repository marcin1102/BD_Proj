using System;
using System.Windows.Forms;
using BusinessLayer.Searchers;
using AdminView.Helpers;

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
            var uName = (string)usersDGV.CurrentCell.Value;
            if (wantEdit)
                this.GoToNextView(new UpdateUserWindow(this, uName));
            else
                this.GoToNextView(new DeactivateUserWindow(this, uName));
        }

        private void returnBT_Click(object sender, EventArgs e)
        {
            this.ClearControls();
        }
    }
}
