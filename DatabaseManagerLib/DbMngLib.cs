/* Database Manager Library:
 * -----------------------------------------------------
 * This library provides the access to create, delete and
 * manipulate all data available on Stock, including a
 * unique ID to each item in stock. Also can load and save
 * the stock data on disk.
 * -----------------------------------------------------
 * 
 */

namespace DatabaseManagerLib
{
	// General Database Management:
	public static class DbMngLib
	{
		//
		// Functions to manipulate the stock:
		//

		// Create a new database for stock, represented as a List<DataDefiniton>
		public static List<DataDefinition> CreateNewDatabase()
		{
			List<DataDefinition> list = new List<DataDefinition>();

			return list;
		}

		// Delete an database
		public static bool RemDatabase(ref List<DataDefinition> list)
		{
			try
			{
				list.Clear();
				return true;
			}
			catch (Exception)
			{
				return false;
				throw;
			}
		}

		// Add an item in stock (how many itens of product X will be added)
		public static bool AddItemStock(ref List<DataDefinition> list, ulong StockItemID, ulong AddItens)
		{
			bool itemFounded = false;

			foreach (var item in list)
			{
				if(item.StockItemID == StockItemID)
				{
					itemFounded = true;
					item.QuantityStock += AddItens;
				}
			}

			return itemFounded;
		}

		// Remove an item from stock (how many itens of product X will be removed.) NOTE: can't result in a number less than 0!
		public static bool RemItemStock(ref List<DataDefinition> list, ulong StockItemID, ulong Num2Rem)
		{
			bool itemFounded = false;

			foreach (var item in list)
			{
				if (item.StockItemID == StockItemID)
				{
					itemFounded = true;

					// In case the quantity to remove is bigger than quantity in stock, set the value as zero.
					if(item.QuantityStock < Num2Rem)
					{
						item.QuantityStock = 0;
					}
					else
					{
						item.QuantityStock -= Num2Rem;
					}
				}
			}

			return itemFounded;
		}

		// Register a product in stock
		public static bool RegProdStock(ref DataDefinition item, ref List<DataDefinition> list, ref ulong StockUniqueIDCounter)
		{
			try
			{
				int SetUID = DataManipulator.SetStockUID(ref StockUniqueIDCounter, ref item);

				if(SetUID == 0)
				{
					list.Add(item);

					return true;
				}

				return false;
			}
			catch (Exception)
			{
				return false;
				throw;
			}
		}

		// Register another product with same information, except Lot, Manufacturing and Expiration Date, Quantity in Stock and IdCode
		public static bool RegProdStock(ref List<DataDefinition> list, ref ulong StockUniqueIDCounter, ulong StockItemIDRef, string Lot, DbDate ManufacturingDate, DbDate ExpirationDate, ulong QuantityStock, string IdCode)
		{
			// Find the item:
			foreach (var item in list)
			{
				if(item.StockItemID == StockItemIDRef)
				{
					try
					{
						// Copy the object and register another
						DataDefinition CopyObj = item;

						// Set a new StockItemID
						int SetUID = DataManipulator.SetStockUID(ref StockUniqueIDCounter, ref CopyObj);

						if (SetUID == 0)
						{
							// Set the new data
							CopyObj.Lot = Lot;
							CopyObj.SetManufacDate(ManufacturingDate);
							CopyObj.SetExpiratDate(ExpirationDate);
							CopyObj.QuantityStock = QuantityStock;
							CopyObj.IdCode = IdCode;

							// Add the orphan obj to the stock:
							list.Add(CopyObj);

							return true;
						}

						return false;
					}
					catch(Exception)
					{
						return false;
						throw;
					}
				}
			}

			return false;
		}

		// Register another product with same information, except Lot, Manufacturing Date, Quantity in Stock and IdCode
		public static bool RegProdStock(ref List<DataDefinition> list, ref ulong StockUniqueIDCounter, ulong StockItemIDRef, string Lot, DbDate ManufacturingDate, ulong QuantityStock, string IdCode)
		{
			// Find the item:
			foreach (var item in list)
			{
				if (item.StockItemID == StockItemIDRef)
				{
					try
					{
						// Copy the object and register another
						DataDefinition CopyObj = item;

						// Creates an ExpirationDate obj with unkown date
						DbDate ExpirationDate = new DbDate();

						// Set a new StockItemID
						int SetUID = DataManipulator.SetStockUID(ref StockUniqueIDCounter, ref CopyObj);

						if (SetUID == 0)
						{
							// Set the new data
							CopyObj.Lot = Lot;
							CopyObj.SetManufacDate(ManufacturingDate);
							CopyObj.SetExpiratDate(ExpirationDate);
							CopyObj.QuantityStock = QuantityStock;
							CopyObj.IdCode = IdCode;

							// Add the orphan obj to the stock:
							list.Add(CopyObj);

							return true;
						}

						return false;
					}
					catch (Exception)
					{
						return false;
						throw;
					}
				}
			}

			return false;
		}

		// Unregister a product in stock
		public static bool UnregProdStock(ref List<DataDefinition> list, ulong StockItemID)
		{
			foreach (var item in list)
			{
				if(item.StockItemID == StockItemID)
				{
					list.Remove(item);

					return true;
				}
			}

			return false;
		}

		// Edit a product registered in stock
		public static bool EditRegProdStock(ref DataDefinition EditedItem, ref List<DataDefinition> list)
		{
			foreach (var item in list)
			{
				if(item.StockItemID == EditedItem.StockItemID)
				{
					item.UpdateData(ref EditedItem);

					return true;
				}
			}

			// Alternative, replacing the old object in the list.
			//for (int i = 0; i < list.Count; i++)
			//{
			//	if (list[i].StockItemID == EditedItem.StockItemID)
			//	{
			//		list[i] = EditedItem;
			//		return true;
			//	}
			//}

			return false;
		}

		//
		// Functions to maintain the database working
		//

		// Reload the stock data for datagrid:
		public static void ReloadDatabase()
		{

		}
	}
}