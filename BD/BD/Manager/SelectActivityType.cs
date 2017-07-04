using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Services;
using BD.Helpers;
using BusinessLayer.DTO;

namespace BD.Manager
{
	public partial class SelectActivityType : UserControl
	{
		private readonly UserControl previousView;

		public SelectActivityType(UserControl previousView)
		{
			InitializeComponent();
			GetData();

			this.previousView = previousView;
		}

		public async void GetData()
		{
			var searcher = new ActivitiesTypesDictionarySearcher();
			activityTypesDataGridView.DataSource = await searcher.GetTypes();
		}

		private void selectButton_Click(object sender, EventArgs e)
		{
			try
			{
				var type = (ActivityTypeData)activityTypesDataGridView.CurrentRow.DataBoundItem;
				var activityPanel = previousView as CreateActivity;
				if (activityPanel != null)
				{
					activityPanel.SetType(type);
					this.GoToPreviousView(previousView);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			this.GoToPreviousView(previousView);
		}
	}
}
