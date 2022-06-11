/* Stock Storage Library
 * -----------------------------------------
 * This library brings support to implement
 * the stock object manageble to easily work
 * with all data and functions.
 * 
 * All StockStorage objects represents
 * a stock type, with your own functions
 * and management.
 * -----------------------------------------
 * 
 * **/

using System.IO;
using DatabaseManagerLib;

namespace DatabaseStorageLib
{
	// StockStorage to implement the stock object storage:
	public class StockStorage
	{
		// Stock database:
		private List<DataDefinition> StockList;

		// Stock variables control:
		private ulong StockUniqueIDCounter;

		// Stock status:
		private int ActiveStockItems;
		private int InactiveStockItems;
		private int StockTypeID;

		// Constructor to determinate a new storage
		public StockStorage(int StockTypeID)
		{
			// Call function to create the Stock Database List:
			this.StockList = DatabaseManagerLib.DbMngLib.CreateNewDatabase();

			// Define the StockUniqueIDCounter:
			this.StockUniqueIDCounter = 0;

			// Define the Stock Status:
			this.InactiveStockItems = this.ActiveStockItems - this.StockList.Count;
			this.ActiveStockItems = this.StockList.Count;
			this.StockTypeID = StockTypeID;
		}

		// Save the database:
		public int SaveChanges(string path)
		{
			string MicroStockDB = path + "\\MicroStockControlDB";
			string StockDB = MicroStockDB + "\\" + this.StockTypeID.ToString() + ".db";

			// Verify if the directory exist
			if (!Directory.Exists(path))
			{
				return 1;
			}

			// If the directory to storage the database will try create it.
			if (!Directory.Exists(MicroStockDB))
			{
				try
				{
					Directory.CreateDirectory(MicroStockDB);

					// Creates the directory container
					if (Directory.Exists(StockDB))
					{
						try
						{
							Directory.CreateDirectory(StockDB);
						}
						catch (Exception)
						{
							return 2;
							throw;
						}
					}
				}
				catch (Exception)
				{
					return 3;
					throw;
				}
			}

			// Try save the data in files.
			try
			{
				return 0;
			}
			catch (Exception)
			{
				return 4;
				throw;
			}
		}

		// Add an item from stock:
		public bool AddItemStock(ulong StockItemID, ulong AddItens)
		{
			return DbMngLib.AddItemStock(ref this.StockList, StockItemID, AddItens);
		}

		// Remove an item from stock:
		public bool RemItemStock(ulong StockItemID, ulong Num2Rem)
		{
			return DbMngLib.RemItemStock(ref this.StockList, StockItemID, Num2Rem);
		}

		// Register a product in stock, with an object item:
		public bool RegProdStock(ref DataDefinition item)
		{
			return DbMngLib.RegProdStock(ref item, ref this.StockList, ref this.StockUniqueIDCounter);
		}

		// Register a product in stock, with same information from an item with StockItemIDRef (reference to item):
		public bool RegProdStock(ulong StockItemIDRef, string Lot, DbDate ManufacturingDate, DbDate ExpirationDate, ulong QuantityStock, string IdCode)
		{
			return DbMngLib.RegProdStock(ref this.StockList, ref this.StockUniqueIDCounter, StockItemIDRef, Lot, ManufacturingDate, ExpirationDate, QuantityStock, IdCode);
		}

		// Register a product in stock, with same information from an item with StockItemIDRef (reference to item):
		public bool RegProdStock(ulong StockItemIDRef, string Lot, DbDate ManufacturingDate, ulong QuantityStock, string IdCode)
		{
			return DbMngLib.RegProdStock(ref this.StockList, ref this.StockUniqueIDCounter, StockItemIDRef, Lot, ManufacturingDate, QuantityStock, IdCode);
		}

		// Unregister a product from stock:
		public bool UnregProdStock(ulong StockItemID)
		{
			return DbMngLib.UnregProdStock(ref this.StockList, StockItemID);
		}

		// Edit a registred product in stock:
		public bool EditRegProdStock(ref DataDefinition EditedItem)
		{
			return DbMngLib.EditRegProdStock(ref EditedItem, ref this.StockList);
		}
	}
}
