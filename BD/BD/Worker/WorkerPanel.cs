using System;
using System.Windows.Forms;

namespace BD.Worker
{
    public partial class WorkerPanel : UserControl
    {
        public WorkerPanel()
        {
            InitializeComponent();
        }

        private void WorkerPanel_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }
    }
}
