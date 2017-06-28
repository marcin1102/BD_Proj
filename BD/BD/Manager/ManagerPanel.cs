using DataLayer.Status;
using System;
using System.Windows.Forms;

namespace BD.Manager.beta
{
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
            statusComboBox.DataSource = Enum.GetNames(typeof(Statuses));
        }
    }
}
