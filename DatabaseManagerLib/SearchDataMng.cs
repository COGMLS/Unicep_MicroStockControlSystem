using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagerLib
{
	//
	// Search an item in stock functions:
	//
	public static class SearchDataMng
	{
		// Search for any possible text match on database
		public static List<DataDefinition> SearchItem_General(string text, ref List<DataDefinition> DataBase, bool IncludeNoQuant = false)
		{
			List<DataDefinition> filteredData = new List<DataDefinition>();

			foreach (var item in DataBase)
			{
				if (
						DataManipulator.TextCompNS(item.Product, text) || 
						DataManipulator.TextCompNS(item.Brand, text) || 
						DataManipulator.TextCompNS(item.Manufacturer, text) || 
						DataManipulator.TextCompNS(item.Lot, text) || 
						DataManipulator.TextCompNS(item.Unit, text) || 
						DataManipulator.TextCompNS(item.IdCode, text)
					)
				{
					if (IncludeNoQuant && item.QuantityStock == 0)
					{
						filteredData.Add(item);
					}
					else
					{
						filteredData.Add(item);
					}
				}
			}

			return filteredData;
		}

		// Search for an unique ID
		public static List<DataDefinition> SearchItem_UID(ulong uid, ref List<DataDefinition> DataBase)
		{
			List<DataDefinition> filteredData = new List<DataDefinition>();

			foreach (var item in DataBase)
			{
				if (DataManipulator.UintCompPart(item.StockItemID, uid))
				{
					filteredData.Add(item);
				}
			}

			return filteredData;
		}

		// Search for an product name
		public static List<DataDefinition> SearchItem_Product(string Product, ref List<DataDefinition> DataBase)
		{
			List<DataDefinition> filteredData = new List<DataDefinition>();

			foreach (var item in DataBase)
			{
				if (DataManipulator.TextCompNS(item.Product, Product))
				{
					filteredData.Add(item);
				}
			}

			return filteredData;
		}

		// Search for a brand name
		public static List<DataDefinition> SearchItem_Brand(string Brand, ref List<DataDefinition> DataBase)
		{
			List<DataDefinition> filteredData = new List<DataDefinition>();

			foreach (var item in DataBase)
			{
				if (DataManipulator.TextCompNS(item.Brand, Brand))
				{
					filteredData.Add(item);
				}
			}

			return filteredData;
		}

		// Search for a manufacter name
		public static List<DataDefinition> SearchItem_Manufacter(string Manufacturer, ref List<DataDefinition> DataBase)
		{
			List<DataDefinition> filteredData = new List<DataDefinition>();

			foreach (var item in DataBase)
			{
				if (DataManipulator.TextCompNS(item.Manufacturer, Manufacturer))
				{
					filteredData.Add(item);
				}
			}

			return filteredData;
		}

		//Search for a Lot data
		public static List<DataDefinition> SearchItem_Lot(string Lot, ref List<DataDefinition> DataBase)
		{
			List<DataDefinition> filteredData = new List<DataDefinition>();

			foreach (var item in DataBase)
			{
				if (DataManipulator.TextCompNS(item.Lot, Lot))
				{
					filteredData.Add(item);
				}
			}

			return filteredData;
		}

		// Search for a manufacturing date
		public static List<DataDefinition> SearchItem_ManufacturingDate(string MDate, ref List<DataDefinition> DataBase)
		{
			List<DataDefinition> filteredData = new List<DataDefinition>();

			foreach (var item in DataBase)
			{
				if (item.GetManufacDate() == MDate)
				{
					filteredData.Add(item);
				}
			}

			return filteredData;
		}

		// Search for expiration date
		public static List<DataDefinition> SearchItem_ExpirationDate(string ExpDate, ref List<DataDefinition> DataBase)
		{
			List<DataDefinition> filteredData = new List<DataDefinition>();

			foreach (var item in DataBase)
			{
				if (item.GetExpirateDate() == ExpDate)
				{
					filteredData.Add(item);
				}
			}

			return filteredData;
		}

		// Search for unit
		public static List<DataDefinition> SearchItem_Unit(string Unit, ref List<DataDefinition> DataBase)
		{
			List<DataDefinition> filteredData = new List<DataDefinition>();

			foreach (var item in DataBase)
			{
				if (DataManipulator.TextCompNS(item.Unit, Unit))
				{
					filteredData.Add(item);
				}
			}

			return filteredData;
		}

		// Search for unit price
		public static List<DataDefinition> SearchItem_UnitPrice(ulong UnitPrice, ref List<DataDefinition> DataBase)
		{
			List<DataDefinition> filteredData = new List<DataDefinition>();

			foreach (var item in DataBase)
			{
				if (item.UnitPrice == UnitPrice)
				{
					filteredData.Add(item);
				}
			}

			return filteredData;
		}

		// Search for quantity in stock
		public static List<DataDefinition> SearchItem_QuantStock(ulong QuantStock, ref List<DataDefinition> DataBase)
		{
			List<DataDefinition> filteredData = new List<DataDefinition>();

			foreach (var item in DataBase)
			{
				if (item.QuantityStock == QuantStock)
				{
					filteredData.Add(item);
				}
			}

			return filteredData;
		}

		// Search for ID Code
		public static List<DataDefinition> SearchItem_IDCode(string IDCode, ref List<DataDefinition> DataBase)
		{
			List<DataDefinition> filteredData = new List<DataDefinition>();

			foreach (var item in DataBase)
			{
				if (DataManipulator.TextCompNS(item.IdCode, IDCode))
				{
					filteredData.Add(item);
				}
			}

			return filteredData;
		}
	}

	//
	// Search for a register functions:
	//
	public static class SearchRegistry
	{ 
		// Search for any possible text match on database
		public static void SearchReg_General(string text)
		{

		}

		// Search for an unique ID
		public static void SearchReg_UID(ulong uid)
		{

		}

		// Search for an product name
		public static void SearchReg_Product(string Product)
		{

		}

		// Search for a branch name
		public static void SearchReg_Branch(string Branch)
		{

		}

		// Search for a manufacter name
		public static void SearchReg_Manufacter(string Manufacter)
		{

		}

		//Search for a Lot data
		public static void SearchReg_Lot(string Lot)
		{

		}

		// Search for a manufacturing date
		public static void SearchReg_ManufacturingDate(string MDate)
		{

		}

		// Search for expiration date
		public static void SearchReg_ExpirationDate(string ExpDate)
		{

		}

		// Search for unit
		public static void SearchReg_Unit(string Unit)
		{

		}

		// Search for unit price
		public static void SearchReg_UnitPrice(ulong UnitPrice)
		{

		}

		// Search for quantity in stock
		public static void SearchReg_QuantStock(ulong QuantStock)
		{

		}

		// Search for ID Code
		public static void SearchReg_IDCode(string IDCode)
		{

		}
	}
}
