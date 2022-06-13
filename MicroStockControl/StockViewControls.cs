using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using DatabaseManagerLib;
using DatabaseStorageLib;

namespace MicroStockControl
{
	public static class StockViewControls
	{
		// Generate a Stock Data Table:
		public static DataTable CreateStockDataGridView()
		{
			DataTable listDataTable = new DataTable();

			listDataTable.Columns.Add(new DataColumn("UID", typeof(ulong)));
			listDataTable.Columns.Add(new DataColumn("Produto", typeof(string)));
			listDataTable.Columns.Add(new DataColumn("Marca", typeof(string)));
			listDataTable.Columns.Add(new DataColumn("Fabricante", typeof(string)));
			listDataTable.Columns.Add(new DataColumn("Lote", typeof(string)));
			listDataTable.Columns.Add(new DataColumn("Data de Fabricação", typeof(DbDate)));
			listDataTable.Columns.Add(new DataColumn("Data de Validade", typeof(DbDate)));
			listDataTable.Columns.Add(new DataColumn("Unidade", typeof(string)));
			listDataTable.Columns.Add(new DataColumn("Preço Unitário", typeof(ulong)));
			listDataTable.Columns.Add(new DataColumn("Código de Barras/Registro", typeof(string)));

			return listDataTable;
		}

		// Populates the Stock Data Table:
		public static void PopulateStockGridView(ref List<DataDefinition> list, ref DataTable StockDataTable, bool UseOnlyDate = false)
		{
			foreach (var item in list)
			{
				StockDataTable.Rows.Add(item.StockItemID, item.Product, item.Brand, item.Manufacturer, item.GetManufacDate(UseOnlyDate), item.GetExpirateDate(UseOnlyDate), item.Unit, item.UnitPrice, item.IdCode);
			}
		}

		// Update the Stock Data Table:
		public static DataTable UpdateStockDataTable(ref List<DataDefinition> listToAdd, ref DataTable StockDataTable, bool UseOnlyDate = false)
		{
			foreach (var item in listToAdd)
			{
				StockDataTable.Rows.Add(item.StockItemID, item.Product, item.Brand, item.Manufacturer, item.GetManufacDate(UseOnlyDate), item.GetExpirateDate(UseOnlyDate), item.Unit, item.UnitPrice, item.IdCode);
			}

			return StockDataTable;
		}
	}
}
