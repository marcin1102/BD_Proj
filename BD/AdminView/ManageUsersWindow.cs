using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminView
{
    public partial class ManageUsersWindow : UserControl
    {
        public ManageUsersWindow()
        {
            InitializeComponent();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            var form = Parent as Form;
            form.Controls.Add(new AddUserWindow(this));
            Hide();
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            GoToFindUserWindow(true);
        }

        private void deactivateUserButton_Click(object sender, EventArgs e)
        {
            GoToFindUserWindow(false);
        }

        private void GoToFindUserWindow(bool wantEdit)
        {
            var form = Parent as Form;
            form.Controls.Add(new FindUserWindow(wantEdit));
            Hide();
        }
    }
}
