using System;
using System.Windows.Forms;
using BD.Helpers;

namespace BD.Manager.beta
{
    public partial class HandleRequest : UserControl
    {
        private readonly UserControl previousControl;

        public HandleRequest(UserControl previousControl)
        {
            this.previousControl = previousControl;
            InitializeComponent();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.GoToPreviousView(previousControl);
        }
    }
}
