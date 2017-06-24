using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD.Admin
{
    public partial class AdminUserCreateForm : Form
    {
        public AdminUserCreateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            var entity = new DataLayer.Worker()
            {
                //worker
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                Role = comboBox1.Text,

                //login
                Login = new Login()
                {
                    UName = textBox3.Text,
                    Pass = textBox4.Text,
                    Expiration = dateTimePicker1.Value
                },
            };
            WorkerFacade.AddWorker(entity);
            this.Close();
        }
    }
}
