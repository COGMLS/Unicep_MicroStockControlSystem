/* Data Definition Library:
 * -------------------------------------------------------
 * This library provides all datatypes definitions needed
 * for the Micro Stock Control database.
 * 
 * All common datatypes are direct accessable and the
 * custom dataypes have their own getters and setters
 * to provide the correct data treatment.
 * -------------------------------------------------------
 * NOTE: The DataManipulator lib has the functions to set
 * correctly all data property on DateDefinition class, 
 * including error reporting and error sum to create
 * objects.
 */

namespace DatabaseManagerLib
{
	// DbDate: class for storage the date and time info.
	// NOTE: UseTime is a control variable to avoid have problems when the user don't set the time.
	// NOTE: IsValidDateTime is a control variable to determinate if the data is valid to be used or not.
	public class DbDate
	{
		// Class data:
		public System.DateTime dateTime;
		public bool UseTime;
		public bool IsValidDateTime;

		// Constructor to use all infomations available:
		public DbDate(int year, int month, int day, int hour, int minute, int second)
		{
			this.dateTime = new System.DateTime(year, month, day, hour, minute, second);
			
			this.UseTime = true;

			this.IsValidDateTime = true;
		}

		// Constructor to use only the date info:
		public DbDate(int year, int month, int day)
		{
			dateTime = new System.DateTime(year, month, day);

			this.UseTime = false;

			this.IsValidDateTime = true;
		}

		// Constructor to not available data:
		public DbDate()
		{
			dateTime = new System.DateTime();

			this.UseTime = false;

			this.IsValidDateTime = false;
		}

		// Check if only the date is equal, dosn't verify the time:
		public bool IsDateEqual(System.DateTime dateTime)
		{
			if(this.dateTime.Year == dateTime.Year)
			{
				if(this.dateTime.Month == dateTime.Month)
				{
					if(this.dateTime.Day == dateTime.Day)
					{
						return true;
					}
				}
			}

			return false;
		}

		// Check if only the date is bigger than, dosn't verify the time:
		public bool IsDateBiggerThan(System.DateTime dateTime)
		{
			if (this.dateTime.Year >= dateTime.Year)
			{
				if (this.dateTime.Month >= dateTime.Month)
				{
					if (this.dateTime.Day > dateTime.Day)
					{
						return true;
					}
				}
			}

			return false;
		}

		// Check if only the date is less than, dosn't verify the time:
		public bool IsDateLessThan(System.DateTime dateTime)
		{
			if (this.dateTime.Year <= dateTime.Year)
			{
				if (this.dateTime.Month <= dateTime.Month)
				{
					if (this.dateTime.Day < dateTime.Day)
					{
						return true;
					}
				}
			}

			return false;
		}

		// Check if only the date is equal or bigger than, dosn't verify the time:
		public bool IsDateBiggerOrEqualThan(System.DateTime dateTime)
		{
			if (this.dateTime.Year >= dateTime.Year)
			{
				if (this.dateTime.Month >= dateTime.Month)
				{
					if (this.dateTime.Day >= dateTime.Day)
					{
						return true;
					}
				}
			}

			return false;
		}

		// Check if only the date is equal or less than, dosn't verify the time:
		public bool IsDateLessOrEqualThan(System.DateTime dateTime)
		{
			if (this.dateTime.Year <= dateTime.Year)
			{
				if (this.dateTime.Month <= dateTime.Month)
				{
					if (this.dateTime.Day <= dateTime.Day)
					{
						return true;
					}
				}
			}

			return false;
		}

		// Update the date time data:
		public bool UpdateDateTime(int year, int month, int day, int hour, int minute, int second)
		{
			try
			{
				this.dateTime = new System.DateTime(year, month, day, hour, minute, second);

				this.UseTime = true;

				this.IsValidDateTime = true;

				return true;
			}
			catch (Exception)
			{
				return false;
				throw;
			}
		}

		// Update the date time data, only with date:
		public bool UpdateDateTime(int year, int month, int day)
		{
			try
			{
				this.dateTime = new System.DateTime(year, month, day);

				this.UseTime = false;

				this.IsValidDateTime = true;

				return true;
			}
			catch (Exception)
			{
				return false;
				throw;
			}
		}

		//Update the date time data to not available data:
		public bool UpdateDateTime()
		{
			try
			{
				this.IsValidDateTime = false;

				return true;
			}
			catch (Exception)
			{
				return false;
				throw;
			}
		}
	}

	// DataDefinition: class to define the list for the app database
	public class DataDefinition
	{
		// Stock data ID:
		public ulong StockItemID;

		// Direct data access:
		public string Product { get; set; }
		public string Brand { get; set; }
		public string Manufacturer { get; set; }
		public string Lot { get; set; }
		public string Unit { get; set; }
		public ulong UnitPrice { get; set; }
		public ulong QuantityStock { get; set; }
		public string IdCode { get; set; }
		
		// Custom datatypes that needs treatment:
		private DbDate ManufacturingDate;
		private DbDate ExpirationDate;

		//
		// DataDefinition Constructors:
		//

		// Default constructor: using ALL informations available.
		public DataDefinition(ulong StockItemID, string Product, string Brand, string Manufacturer, string Lot, DbDate ManufacturingDate, DbDate ExpirationDate, string Unit, ulong UnitPrice, ulong QuantityStock, string IdCode)
		{
			// Set object property values:
			this.StockItemID = StockItemID;
			this.Product = Product;
			this.Brand = Brand;
			this.Manufacturer = Manufacturer;
			this.Lot = Lot;
			this.ManufacturingDate = ManufacturingDate;
			this.ExpirationDate = ExpirationDate;
			this.Unit = Unit;
			this.UnitPrice = UnitPrice;
			this.QuantityStock = QuantityStock;
			this.IdCode = IdCode;
		}

		// Constructor for NO Brand info.
		public DataDefinition(ulong StockItemID, string Product, string Manufacturer, string Lot, DbDate ManufacturingDate, DbDate ExpirationDate, string Unit, ulong UnitPrice, ulong QuantityStock, string IdCode)
		{
			// Set object property values:
			this.StockItemID = StockItemID;
			this.Product = Product;
			this.Brand = "N/A";
			this.Manufacturer = Manufacturer;
			this.Lot = Lot;
			this.ManufacturingDate = ManufacturingDate;
			this.ExpirationDate = ExpirationDate;
			this.Unit = Unit;
			this.UnitPrice = UnitPrice;
			this.QuantityStock = QuantityStock;
			this.IdCode = IdCode;
		}

		// Constructor for NO ExpirationDate
		public DataDefinition(ulong StockItemID, string Product, string Brand, string Manufacturer, string Lot, DbDate ManufacturingDate, string Unit, ulong UnitPrice, ulong QuantityStock, string IdCode)
		{
			// Create an empty ExpirationDate:
			DbDate ExpirationDate = new DbDate();

			// Set object property values:
			this.StockItemID = StockItemID;
			this.Product = Product;
			this.Brand = Brand;
			this.Manufacturer = Manufacturer;
			this.Lot = Lot;
			this.ManufacturingDate = ManufacturingDate;
			this.ExpirationDate = ExpirationDate;
			this.Unit = Unit;
			this.UnitPrice = UnitPrice;
			this.QuantityStock = QuantityStock;
			this.IdCode = IdCode;
		}

		// Constructor for NO Brand info and Expiration Date:
		public DataDefinition(ulong StockItemID, string Product, string Manufacturer, string Lot, DbDate ManufacturingDate, string Unit, ulong UnitPrice, ulong QuantityStock, string IdCode)
		{
			// Create an empty ExpirationDate:
			DbDate ExpirationDate = new DbDate();

			// Set object property values:
			this.StockItemID = StockItemID;
			this.Product = Product;
			this.Brand = "N/A";
			this.Manufacturer = Manufacturer;
			this.Lot = Lot;
			this.ManufacturingDate = ManufacturingDate;
			this.ExpirationDate = ExpirationDate;
			this.Unit = Unit;
			this.UnitPrice = UnitPrice;
			this.QuantityStock = QuantityStock;
			this.IdCode = IdCode;
		}

		//
		// Getters:
		//

		// ManufacturingDate:
		public string GetManufacDate(bool UseOnlyDate = false)
		{
			string dateStr = "";

			if(this.ManufacturingDate.IsValidDateTime)
			{
				if (UseOnlyDate)
				{
					dateStr = this.ManufacturingDate.dateTime.ToShortDateString();
				}
				else
				{
					dateStr = this.ManufacturingDate.dateTime.ToString();
				}
			}
			else
			{
				dateStr = "Not available";
			}

			return dateStr;
		}

		// ManufacturingDateDb:
		public DbDate GetManufacDateDb()
		{
			DbDate db = this.ManufacturingDate;

			return db;
		}

		// Expiration formated date:
		public string GetExpirateDate(bool UseOnlyDate = false)
		{
			string dateStr = "";

			if (this.ExpirationDate.IsValidDateTime)
			{
				if (UseOnlyDate)
				{
					dateStr = this.ExpirationDate.dateTime.ToShortDateString();
				}
				else
				{
					dateStr = this.ExpirationDate.dateTime.ToString();
				}
			}
			else
			{
				dateStr = "Not available";
			}

			return dateStr;
		}

		// ExpirationDateDb:
		public DbDate GetExpirateDateDb()
		{
			DbDate db = this.ExpirationDate;

			return db;
		}

		//
		// Setters:
		//

		// ManufacturingDate with complete date and time:
		public void SetManufacDate(int Day, int Month, int Year, int Hours, int Minutes, int Seconds)
		{
			this.ManufacturingDate.UpdateDateTime(Year, Month, Day, Hours, Minutes, Seconds);
		}

		// ManufacturingDate with only date
		public void SetManufacDate(int Day, int Month, int Year)
		{
			this.ManufacturingDate.UpdateDateTime(Year, Month, Day);
		}

		// Unkown or not available Manufacturing Date:
		public void SetManufacDate()
		{
			this.ManufacturingDate.UpdateDateTime();
		}

		// ManufacturingDate object ready to be setted:
		public void SetManufacDate(DbDate ManufacturingDate)
		{
			this.ManufacturingDate = ManufacturingDate;
		}

		// ExpirationDate with complete date and time:
		public void SetExpiratDate(int Day, int Month, int Year, int Hours, int Minutes, int Seconds)
		{
			this.ExpirationDate.UpdateDateTime(Year, Month, Day, Hours, Minutes, Seconds);
		}

		// ExpirationDate with only date
		public void SetExpiratDate(int Day, int Month, int Year)
		{
			this.ExpirationDate.UpdateDateTime(Year, Month, Day);
		}

		// Unknow or not available expiration date:
		public void SetExpiratDate()
		{
			this.ExpirationDate.UpdateDateTime();
		}

		// ExpirationDate object ready to be setted:
		public void SetExpiratDate(DbDate ExpirationDate)
		{
			this.ExpirationDate = ExpirationDate;
		}

		//
		// Treatment Functions:
		//

		// Update object data:
		public bool UpdateData(ref DataDefinition EditedObj)
		{
			// Check if the object is null
			if(EditedObj == null)
			{
				return false;
			}

			try
			{
				// Update data that not match with storage object data:
				if (this.Product != EditedObj.Product)
				{
					this.Product = EditedObj.Product;
				}
				if (this.Brand != EditedObj.Brand)
				{
					this.Brand = EditedObj.Brand;
				}
				if (this.Manufacturer != EditedObj.Manufacturer)
				{
					this.Manufacturer = EditedObj.Manufacturer;
				}
				if (this.Lot != EditedObj.Lot)
				{
					this.Lot = EditedObj.Lot;
				}

				//
				// Manufacturing Date treatment:
				//

				// Check if the updated data will be used
				if (EditedObj.ManufacturingDate.IsValidDateTime)
				{
					// Verify if both objects use the time data
					if (this.ManufacturingDate.UseTime && EditedObj.ManufacturingDate.UseTime)
					{
						// If the dates and times are diferent, update them
						if (this.ManufacturingDate.dateTime != EditedObj.ManufacturingDate.dateTime)
						{
							this.ManufacturingDate = EditedObj.ManufacturingDate;
						}
					}
					// If only one or no one use UseTime variable control
					else
					{
						// If the dates are diferent, update it.
						if (!this.ManufacturingDate.IsDateEqual(EditedObj.ManufacturingDate.dateTime))
						{
							// If the updated data will use time data
							if (EditedObj.ManufacturingDate.UseTime)
							{
								this.ManufacturingDate = EditedObj.ManufacturingDate;
							}
							// Create an object to represent only the date
							else
							{
								this.ManufacturingDate.UpdateDateTime(EditedObj.ManufacturingDate.dateTime.Year, EditedObj.ManufacturingDate.dateTime.Month, EditedObj.ManufacturingDate.dateTime.Day);
							}
						}
					}
				}
				else
				{
					this.ManufacturingDate = EditedObj.ManufacturingDate;
				}

				//
				// Expiration Date treatment:
				//

				// Check if the updated data will be used
				if (EditedObj.ExpirationDate.IsValidDateTime)
				{
					// Verify if both objects use the time data
					if (this.ExpirationDate.UseTime && EditedObj.ExpirationDate.UseTime)
					{
						// If the dates and times are diferent, update them
						if (this.ExpirationDate.dateTime != EditedObj.ExpirationDate.dateTime)
						{
							this.ExpirationDate = EditedObj.ExpirationDate;
						}
					}
					// If only one or no one use UseTime variable control
					else
					{
						// If the dates are diferent, update it.
						if (!this.ExpirationDate.IsDateEqual(EditedObj.ExpirationDate.dateTime))
						{
							// If the updated data will use time data
							if (EditedObj.ExpirationDate.UseTime)
							{
								this.ExpirationDate = EditedObj.ExpirationDate;
							}
							// Create an object to represent only the date
							else
							{
								this.ExpirationDate.UpdateDateTime(EditedObj.ExpirationDate.dateTime.Year, EditedObj.ExpirationDate.dateTime.Month, EditedObj.ExpirationDate.dateTime.Day);
							}
						}
					}
				}
				else
				{
					this.ExpirationDate = EditedObj.ExpirationDate;
				}

				if (this.Unit != EditedObj.Unit)
				{
					this.Unit = EditedObj.Unit;
				}
				if (this.UnitPrice != EditedObj.UnitPrice)
				{
					this.UnitPrice = EditedObj.UnitPrice;
				}
				if (this.QuantityStock != EditedObj.QuantityStock)
				{
					this.QuantityStock = EditedObj.QuantityStock;
				}
				if (this.IdCode != EditedObj.IdCode)
				{
					this.IdCode = EditedObj.IdCode;
				}

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
