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
using BusinessLayer.Services;
using BusinessLayer.DTO;

namespace BD.Manager
{
	public partial class ActivityTypeForm : UserControl
	{
		private enum FormMode
		{
			CREATE, UPDATE
		}

		private readonly UserControl previousView;
		private readonly FormMode mode;

		public ActivityTypeForm(UserControl previousView, string mode)
		{
			InitializeComponent();
			this.previousView = previousView;
			this.mode = (FormMode)Enum.Parse(typeof(FormMode), mode, true);
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			var service = new ActivitiesTypesService();
			
			try
			{
				switch (mode)
				{
					case FormMode.CREATE:
						service.Create(new ActivityTypeData()
						{
							Name = nameTextBox.Text,
							Type = codeTextBox.Text
						});
						MessageBox.Show($"Utworzono typ czynności {nameTextBox.Text} o kodzie {codeTextBox.Text}");
						break;
					case FormMode.UPDATE:
						break;
					default:
						break;
				}
				this.GoToPreviousView(previousView);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.GoToPreviousView(previousView);
		}
	}
}
