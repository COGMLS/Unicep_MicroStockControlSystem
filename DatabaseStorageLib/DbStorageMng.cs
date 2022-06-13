/* Database Storage Manager
 * --------------------------------------
 * This library has support to manage all
 * data in stock, also has an class to
 * manage to simplify the stock storage
 * creation as an object.
 * --------------------------------------
 * Stock database storage hierarchy:
 * 
 * StockStorageRoot
 * |
 * |- Content <Actual Storage>
 * |- Content.back <Backup Storage>
 * +- dbstatus <Database File Status>
 * **/

using System;

using DatabaseManagerLib;

namespace DatabaseStorageLib
{
	// Database Storage Manager functions:
	public static class DbStorageMng
	{
		//
		// Constants and Aux Functions to work on save/load functions:
		//

		public static string MicroStockDB = "\\MicroStockControlDB";
		
		public static string GetStorageStorageRootPath(string path, int StockTypeID)
		{
			return path + MicroStockDB + "\\" + StockTypeID.ToString() + ".db";
		}

		//
		// Load Stock Storage Saved Database Functions:
		//

		// Load the saved stock storage to memory:
		public static int LoadStockStorage(string StockStorageRoot, ref StockStorage Stock)
		{
			// Verify if the path exist
			if (!Directory.Exists(StockStorageRoot))
			{
				return 1;
			}

			// Verify if the database registry if available:
			if(!File.Exists(StockStorageRoot + "\\dbstatus"))
			{
				return 2;
			}

			// Read the database status file:
			string[] dbstatus = File.ReadAllLines(StockStorageRoot + "\\dbstatus");

			// Load elements and add to a List:
			string[] FilesArray = Directory.GetFiles(StockStorageRoot + "\\" + "Content");

			for(int i = 0; i < FilesArray.Length; i++)
			{
				DataDefinition item = DataManipulator.NewOrphanItem("Not Available", "Not Available", "Not Available", new DbDate(), "Not Available", 0, 0, "Not Available");

				if(LoadFile(StockStorageRoot, ref item))
				{
					Stock.RegProdStock(ref item);
				}
			}

			return 0;
		}

		// Load a file as a string array and return an Stock item:
		private static bool LoadFile(string FilePath, ref DataDefinition item)
		{
			string[] FileContent = File.ReadAllLines(FilePath, System.Text.Encoding.Unicode);

			if(FileContent.Length == 0)
			{
				return false;
			}

			string Product = LoadStringData(ref FileContent, 0);
			string Brand = LoadStringData(ref FileContent, 1);
			string Manufacturer = LoadStringData(ref FileContent, 2);
			string Lot = LoadStringData(ref FileContent, 3);
			string Unit = LoadStringData(ref FileContent, 4);
			string IdCode = LoadStringData(ref FileContent, 7);

			ulong UnitPrice = LoadUlongData(ref FileContent, 5);
			ulong QuantityStock = LoadUlongData(ref FileContent, 6);

			DbDate ManufacturingDate = LoadDate(ref FileContent, 8);
			DbDate ExpirationDate = LoadDate(ref FileContent, 14);

			DataDefinition loadedItem = DataManipulator.NewOrphanItem(Product, Brand, Manufacturer, Lot, ManufacturingDate, ExpirationDate, Unit, UnitPrice, QuantityStock, IdCode);

			item = loadedItem;

			return true;
		}

		private static string LoadStringData(ref string[] FileContent, int Index)
		{
			if (FileContent.Length - 1 > Index)
			{
				return FileContent[Index];
			}
			else
			{
				return "Not Available";
			}
		}

		private static ulong LoadUlongData(ref string[] FileContent, int Index)
		{
			if(FileContent.Length - 1 > Index)
			{
				if (ulong.TryParse(FileContent[Index], out _))
				{
					return ulong.Parse(FileContent[Index]);
				}
				else
				{
					return 0;
				}
			}
			else
			{
				return 0;
			}
		}

		private static DbDate LoadDate(ref string[] FileContent, int IndexStart)
		{
			// Verify if the Index range is valid:
			if (FileContent.Length - 1 >= IndexStart + 5)
			{
				// Declare all necessary variables:
				int Year,Month,Day,Hour,Minute,Second;

				// Try to convert the data string to int or set as invalid:

				// Year:
				if (int.TryParse(FileContent[IndexStart], out _))
				{
					Year = int.Parse(FileContent[IndexStart]);
				}
				else
				{
					Year = -1;
				}

				// Month:
				if (int.TryParse(FileContent[IndexStart + 1], out _))
				{
					Month = int.Parse(FileContent[IndexStart + 1]);
				}
				else
				{
					Month = -1;
				}

				// Day:
				if (int.TryParse(FileContent[IndexStart + 2], out _))
				{
					Day = int.Parse(FileContent[IndexStart + 2]);
				}
				else
				{
					Day = -1;
				}

				// Hour:
				if (int.TryParse(FileContent[IndexStart + 3], out _))
				{
					Hour = int.Parse(FileContent[IndexStart + 3]);
				}
				else
				{
					Hour = -1;
				}

				// Minute:
				if (int.TryParse(FileContent[IndexStart + 4], out _))
				{
					Minute = int.Parse(FileContent[IndexStart + 4]);
				}
				else
				{
					Minute = -1;
				}

				// Second:
				if (int.TryParse(FileContent[IndexStart + 5], out _))
				{
					Second = int.Parse(FileContent[IndexStart + 5]);
				}
				else
				{
					Second = -1;
				}

				// Check the date is invalid:
				if (Year < 0 || Month < 0 || Day < 0)
				{
					return new DbDate();
				}

				// Check if the time is invalid:
				if (Hour < 0 || Minute < 0 || Second < 0)
				{
					return new DbDate(Year, Month, Day);
				}

				// In case the date and time valid:
				return new DbDate(Year, Month, Day, Hour, Minute, Second);
			}

			// In case the index range isn't valid, return a invalid date and time:
			return new DbDate();
		}

		//
		// Save Stock Storage Functions:
		//

		// Function to save the stock database:
		public static int SaveStockStorage(string StockStorageRoot, ref List<DataDefinition> list)
		{
			// Create the directory conteiner to storage the stock database file if dosn't exist.
			CreateDatabaseDirectoryHierarchy(StockStorageRoot);

			// Create a new directory backup if already exist one.
			ManageDatabaseBackup(StockStorageRoot);

			// Get each list item and save the content
			int FileIndex = 0;

			// Control variable to detect if some file was missed.
			int FilesSaved = 0;

			foreach (var item in list)
			{
				string[] itemSaveContent = GetItemStockContent(item);

				if(SaveFileContent(FileIndex, StockStorageRoot, itemSaveContent))
				{
					FilesSaved++;
				}

				FileIndex++;
			}

			return FilesSaved;
		}

		private static bool CreateDatabaseDirectoryHierarchy(string StockStorageRoot)
		{
			try
			{
				// Create the directory conteiner to storage the stock database file if dosn't exist.
				if (!Directory.Exists(StockStorageRoot + "\\" + "Content"))
				{
					Directory.CreateDirectory(StockStorageRoot + "\\" + "Content");
					// Check if the directory was created

					return Directory.Exists(StockStorageRoot + "\\" + "Content");
				}
				else
				{
					return true;
				}

			}
			catch (Exception)
			{
				return false;
				throw;
			}
		}

		// Function to manage the backup database
		private static bool ManageDatabaseBackup(string StockStorageRoot)
		{
			bool Successful = true;

			// Create a new directory backup if already exist one.
			if (Directory.Exists(StockStorageRoot + "\\" + "Content.back"))
			{
				Directory.Delete(StockStorageRoot + "\\" + "Content.back", true);
				Directory.CreateDirectory(StockStorageRoot + "\\" + "Content.back");
			}

			// Get all files available in Content folder:
			string[] FilesArr = Directory.GetFiles(StockStorageRoot + "\\" + "Content");

			// If there is any file, move it to Content.back
			if (FilesArr.LongLength > 0)
			{
				for (int i = 0; i < FilesArr.Length; i++)
				{
					try
					{
						File.Move(FilesArr[i], StockStorageRoot + "\\" + "Content.back");
					}
					catch (Exception)
					{
						Successful = false;
						throw;
					}
				}
			}

			return Successful;
		}

		// Get all content in a stock item to string array
		private static string[] GetItemStockContent(DataDefinition item)
		{
			string[] FileContent = new string[20];

			// Get all base string information:
			FileContent[0] = item.Product;
			FileContent[1] = item.Brand;
			FileContent[2] = item.Manufacturer;
			FileContent[3] = item.Lot;
			FileContent[4] = item.Unit;
			FileContent[5] = item.UnitPrice.ToString();
			FileContent[6] = item.QuantityStock.ToString();
			FileContent[7] = item.IdCode;

			DbDate ManufacturingDate = item.GetManufacDateDb();
			DbDate ExpirationDate = item.GetExpirateDateDb();

			// Define the manufacturing date as string:
			if (ManufacturingDate.IsValidDateTime)
			{
				if (ManufacturingDate.UseTime)
				{
					FileContent[8] = ManufacturingDate.dateTime.Year.ToString();        // Year
					FileContent[9] = ManufacturingDate.dateTime.Month.ToString();       // Month
					FileContent[10] = ManufacturingDate.dateTime.Day.ToString();        // Day
					FileContent[11] = ManufacturingDate.dateTime.Hour.ToString();       // Hour
					FileContent[12] = ManufacturingDate.dateTime.Minute.ToString();     // Minute
					FileContent[13] = ManufacturingDate.dateTime.Second.ToString();     // Second
				}
				else
				{
					FileContent[8] = ManufacturingDate.dateTime.Year.ToString();        // Year
					FileContent[9] = ManufacturingDate.dateTime.Month.ToString();       // Month
					FileContent[10] = ManufacturingDate.dateTime.Day.ToString();        // Day
					FileContent[11] = "-1";     // Hour
					FileContent[12] = "-1";     // Minute
					FileContent[13] = "-1";     // Second
				}
			}
			else
			{
				FileContent[8] = "-1";      // Year
				FileContent[9] = "-1";      // Month
				FileContent[10] = "-1";     // Day
				FileContent[11] = "-1";     // Hour
				FileContent[12] = "-1";     // Minute
				FileContent[13] = "-1";     // Second
			}

			// Define the expiration date as string:
			if (ExpirationDate.IsValidDateTime)
			{
				if (ExpirationDate.UseTime)
				{
					FileContent[14] = ExpirationDate.dateTime.Year.ToString();       // Year
					FileContent[15] = ExpirationDate.dateTime.Month.ToString();      // Month
					FileContent[16] = ExpirationDate.dateTime.Day.ToString();        // Day
					FileContent[17] = ExpirationDate.dateTime.Hour.ToString();       // Hour
					FileContent[18] = ExpirationDate.dateTime.Minute.ToString();     // Minute
					FileContent[19] = ExpirationDate.dateTime.Second.ToString();     // Second
				}
				else
				{
					FileContent[14] = ExpirationDate.dateTime.Year.ToString();       // Year
					FileContent[15] = ExpirationDate.dateTime.Month.ToString();      // Month
					FileContent[16] = ExpirationDate.dateTime.Day.ToString();        // Day
					FileContent[17] = "-1";     // Hour
					FileContent[18] = "-1";     // Minute
					FileContent[19] = "-1";     // Second
				}
			}
			else
			{
				FileContent[14] = "-1";     // Year
				FileContent[15] = "-1";     // Month
				FileContent[16] = "-1";     // Day
				FileContent[17] = "-1";     // Hour
				FileContent[18] = "-1";     // Minute
				FileContent[19] = "-1";     // Second
			}

			return FileContent;
		}

		// Save the stock item to a file.
		private static bool SaveFileContent(int Index, string StockStorageRoot, string[] FileContent)
		{
			if(File.Exists(StockStorageRoot + "\\" + "Content" + "\\" + Index.ToString()))
			{
				File.Delete(StockStorageRoot + "\\" + "Content" + "\\" + Index.ToString());
			}

			try
			{
				File.WriteAllLines(StockStorageRoot + "\\" + "Content" + "\\" + Index.ToString(), FileContent, System.Text.Encoding.Unicode);

				return true;
			}
			catch (Exception)
			{
				return false;
				throw;
			}
		}
	}
}