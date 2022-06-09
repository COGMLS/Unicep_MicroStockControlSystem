/* Data Manipulator Library
 * --------------------------------------------------
 * This library provides functions to manipulate the
 * datas available in the Data Definition Library.
 * 
 * **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagerLib
{
	// Data Manipulator class
	public static class DataManipulator
	{
		// Function to test the text and compare without case sensitive
		public static bool TextCompNS(string basetxt, string testtxt)
		{
			return basetxt.ToLower().Contains(testtxt.ToLower());
		}

		// Function to test and partially compare
		public static bool UintCompPart(ulong basenum, ulong testnum)
		{
			return basenum.ToString().Contains(testnum.ToString());
		}

		// Set a new StockUniqueIDCounter
		public static int SetStockUID(ref ulong StockStockUniqueIDCounter, ref DataDefinition Obj)
		{
			try
			{
				// Check if the counter has the orphan exclusive code
				if (StockStockUniqueIDCounter == 0)
				{
					StockStockUniqueIDCounter++;
				}

				// Check if the counter is available for the operation
				if (StockStockUniqueIDCounter < ulong.MaxValue - 1)
				{
					// Set the StockUID for thr object
					Obj.StockItemID = StockStockUniqueIDCounter;

					// Advance the counter to the next object
					StockStockUniqueIDCounter++;

					// Return 0 if the operation has success
					return 0;
				}

				// Return -1 if StockUniqueCounter is in max value
				return -1;
			}
			catch (Exception)
			{
				// Launch an exception
				return 1;
				throw;
			}
		}

		// Creates an orphan object (dosn't belongs to stock) with StockItemID = 0
		public static DataDefinition NewOrphanItem(string Product, string Brand, string Manufacturer, string Lot, DbDate ManufacturingDate, DbDate ExpirationDate, string Unit, ulong UnitPrice, ulong QuantityStock, string IdCode)
		{
			DataDefinition OrphanObj = new DataDefinition(0, Product, Brand, Manufacturer, Lot, ManufacturingDate, ExpirationDate, Unit, UnitPrice, QuantityStock, IdCode);

			return OrphanObj;
		}

		// Creates an orphan object (dosn't belongs to stock) with StockItemID = 0, without brand info.
		public static DataDefinition NewOrphanItem(string Product, string Manufacturer, string Lot, DbDate ManufacturingDate, DbDate ExpirationDate, string Unit, ulong UnitPrice, ulong QuantityStock, string IdCode)
		{
			DataDefinition OrphanObj = new DataDefinition(0, Product, Manufacturer, Lot, ManufacturingDate, ExpirationDate, Unit, UnitPrice, QuantityStock, IdCode);

			return OrphanObj;
		}

		// Creates an orphan object (dosn't belongs to stock) with StockItemID = 0, without ExpirationDate.
		public static DataDefinition NewOrphanItem(string Product, string Brand, string Manufacturer, string Lot, DbDate ManufacturingDate, string Unit, ulong UnitPrice, ulong QuantityStock, string IdCode)
		{
			DataDefinition OrphanObj = new DataDefinition(0, Product, Brand, Manufacturer, Lot, ManufacturingDate, Unit, UnitPrice, QuantityStock, IdCode);

			return OrphanObj;
		}

		// Creates an orphan object (dosn't belongs to stock) with StockItemID = 0, without brand and ExpirationDate info.
		public static DataDefinition NewOrphanItem(string Product, string Manufacturer, string Lot, DbDate ManufacturingDate, string Unit, ulong UnitPrice, ulong QuantityStock, string IdCode)
		{
			DataDefinition OrphanObj = new DataDefinition(0, Product, Manufacturer, Lot, ManufacturingDate, Unit, UnitPrice, QuantityStock, IdCode);

			return OrphanObj;
		}
	}
}
