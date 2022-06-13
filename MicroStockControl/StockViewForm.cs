using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DatabaseManagerLib;
using DatabaseStorageLib;

namespace MicroStockControl
{
	public partial class StockViewForm : Form
	{
		public StockViewForm(ref List<DataDefinition> list, string StockFormTitle, string StockID)
		{
			InitializeComponent();

			// Prepare the StockViewForm title to identify the window:
			this.Name = StockFormTitle + " - Stock ID: " + StockID;

			// Prepare the DataTable:
			this.StockDataTable = StockViewControls.CreateStockDataGridView();
			StockViewControls.PopulateStockGridView(ref list, ref this.StockDataTable);
		}

		private void RefreshDataGridViewButton_Click(object sender, EventArgs e)
		{
			this.StockDataGridView.Refresh();
		}
	}
}
