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

namespace BD.Manager
{
	public partial class SelectActivityType : UserControl
	{
		public SelectActivityType()
		{
			InitializeComponent();
			GetData();
		}

		public async void GetData()
		{
			var searcher = new ActivitiesTypesDictionarySearcher();
			activityTypesDataGridView.DataSource = await searcher.GetTypes();
		}

		private void selectButton_Click(object sender, EventArgs e)
		{

		}

		private void backButton_Click(object sender, EventArgs e)
		{

		}
	}
}
