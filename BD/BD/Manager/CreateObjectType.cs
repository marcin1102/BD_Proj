using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BD.Helpers;
using BusinessLayer.Services.ObjectType;
using BusinessLayer.DTO;

namespace BD.Manager
{
    public partial class CreateObjectType : UserControl
    {
        private readonly UserControl previousView;
        public CreateObjectType(UserControl previousView)
        {
            InitializeComponent();
            this.previousView = previousView;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var service = new ObjectTypeService();
            try
            {
                service.CreateObjectType(new ObjectTypeData()
                {
                    Code = codeTextBox.Text,
                    Name = nameTextBox.Text
                });
                MessageBox.Show($"Dodano {nameTextBox.Text}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            var view = previousView as CreateObject;
            view.ShowObjectTypes();
            this.GoToPreviousView(view);
        }
    }
}
