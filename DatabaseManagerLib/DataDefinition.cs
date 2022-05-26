﻿/* Data Definition Library:
 * -------------------------------------------------------
 * This library provides all datatypes definitions needed
 * for the Micro Stock Control database.
 * 
 * All common datatypes are direct accessable and the
 * custom dataypes have their own getters and setters
 * to provide the correct data treatment.
 */

namespace DatabaseManagerLib
{
	// DbDate: struct for storage the date.
	// NOTE: To determinate if the date will not include time, use Hours >= 24
	// NOTE: To determinate a date not available for ExpirationDate property, use Day = 0
	struct DbDate
	{
		public uint Seconds;
		public uint Minutes;
		public uint Hours;
		public uint Day;
		public uint Month;
		public uint Year;
	}

	// DataDefinition: class to define the list for the app database
	internal class DataDefinition
	{
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
		public DataDefinition(string Product, string Brand, string Manufacturer, string Lot, DbDate ManufacturingDate, DbDate ExpirationDate, string Unit, ulong UnitPrice, ulong QuantityStock, string IdCode)
		{
			// Set object property values:
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
		public DataDefinition(string Product, string Manufacturer, string Lot, DbDate ManufacturingDate, DbDate ExpirationDate, string Unit, ulong UnitPrice, ulong QuantityStock, string IdCode)
		{
			// Set object property values:
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
		public DataDefinition(string Product, string Brand, string Manufacturer, string Lot, DbDate ManufacturingDate, string Unit, ulong UnitPrice, ulong QuantityStock, string IdCode)
		{
			DbDate ExpirationDate = new DbDate();

			// Turn ExpirationDate unavailable:
			ExpirationDate.Day = 0;
			ExpirationDate.Month = 0;
			ExpirationDate.Year = 0;
			ExpirationDate.Hours = 24;
			ExpirationDate.Minutes = 0;
			ExpirationDate.Seconds = 0;

			// Set object property values:
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
		public DataDefinition(string Product, string Manufacturer, string Lot, DbDate ManufacturingDate, string Unit, ulong UnitPrice, ulong QuantityStock, string IdCode)
		{
			DbDate ExpirationDate = new DbDate();

			// Turn ExpirationDate unavailable:
			ExpirationDate.Day = 0;
			ExpirationDate.Month = 0;
			ExpirationDate.Year = 0;
			ExpirationDate.Hours = 24;
			ExpirationDate.Minutes = 0;
			ExpirationDate.Seconds = 0;

			// Set object property values:
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
		public string GetManufacDate()
		{
			string dateStr = "";

			if(this.ManufacturingDate.Day < 10)
			{
				dateStr += "0" + this.ManufacturingDate.Day.ToString() + "/";
			}
			else
			{
				dateStr += this.ManufacturingDate.Day.ToString() + "/";
			}

			if (this.ManufacturingDate.Month < 10)
			{
				dateStr += "0" + this.ManufacturingDate.Day.ToString() + "/";
			}
			else
			{
				dateStr += this.ManufacturingDate.Day.ToString() + "/";
			}

			dateStr += this.ManufacturingDate.Year.ToString();

			if(this.ManufacturingDate.Hours < 24)
			{
				dateStr += " ";

				if(this.ManufacturingDate.Hours < 10)
				{
					dateStr += "0" + this.ManufacturingDate.Hours.ToString() + ":";
				}
				else
				{
					dateStr += this.ManufacturingDate.Hours.ToString() + ":";
				}

				if (this.ManufacturingDate.Minutes < 10)
				{
					dateStr += "0" + this.ManufacturingDate.Minutes.ToString() + ":";
				}
				else
				{
					dateStr += this.ManufacturingDate.Minutes.ToString() + ":";
				}

				if (this.ManufacturingDate.Seconds < 10)
				{
					dateStr += "0" + this.ManufacturingDate.Seconds.ToString();
				}
				else
				{
					dateStr += this.ManufacturingDate.Seconds.ToString();
				}
			}

			return dateStr;
		}

		public string GetExpirateDate()
		{
			string dateStr = "";

			if (this.ExpirationDate.Day > 0)
			{
				if (this.ExpirationDate.Day < 10)
				{
					dateStr += "0" + this.ExpirationDate.Day.ToString() + "/";
				}
				else
				{
					dateStr += this.ExpirationDate.Day.ToString() + "/";
				}

				if (this.ExpirationDate.Month < 10)
				{
					dateStr += "0" + this.ExpirationDate.Day.ToString() + "/";
				}
				else
				{
					dateStr += this.ExpirationDate.Day.ToString() + "/";
				}

				dateStr += this.ExpirationDate.Year.ToString();

				if (this.ExpirationDate.Hours < 24)
				{
					dateStr += " ";

					if (this.ExpirationDate.Hours < 10)
					{
						dateStr += "0" + this.ExpirationDate.Hours.ToString() + ":";
					}
					else
					{
						dateStr += this.ExpirationDate.Hours.ToString() + ":";
					}

					if (this.ExpirationDate.Minutes < 10)
					{
						dateStr += "0" + this.ExpirationDate.Minutes.ToString() + ":";
					}
					else
					{
						dateStr += this.ExpirationDate.Minutes.ToString() + ":";
					}

					if (this.ExpirationDate.Seconds < 10)
					{
						dateStr += "0" + this.ExpirationDate.Seconds.ToString();
					}
					else
					{
						dateStr += this.ExpirationDate.Seconds.ToString();
					}
				}
			}
			else
			{
				dateStr += "N/A";
			}

			return dateStr;
		}

		//
		// Setters:
		//

		// ManufacturingDate with complete date and time:
		public void SetManufacDate(uint Day, uint Month, uint Year, uint Hours, uint Minutes, uint Seconds)
		{
			this.ManufacturingDate.Day = Day;
			this.ManufacturingDate.Month = Month;
			this.ManufacturingDate.Year = Year;
			this.ManufacturingDate.Hours = Hours;
			this.ManufacturingDate.Minutes = Minutes;
			this.ManufacturingDate.Seconds = Seconds;
		}

		// ManufacturingDate with only date
		public void SetManufacDate(uint Day, uint Month, uint Year)
		{
			this.ManufacturingDate.Day = Day;
			this.ManufacturingDate.Month = Month;
			this.ManufacturingDate.Year = Year;

			// Turn as unavailable time.
			this.ManufacturingDate.Hours = 24;
			this.ManufacturingDate.Minutes = 0;
			this.ManufacturingDate.Seconds = 0;
		}

		// ExpirationDate with complete date and time:
		public void SetExpiratDate(uint Day, uint Month, uint Year, uint Hours, uint Minutes, uint Seconds)
		{
			this.ExpirationDate.Day = Day;
			this.ExpirationDate.Month = Month;
			this.ExpirationDate.Year = Year;
			this.ExpirationDate.Hours = Hours;
			this.ExpirationDate.Minutes = Minutes;
			this.ExpirationDate.Seconds = Seconds;
		}

		// ExpirationDate with only date
		public void SetExpiratDate(uint Day, uint Month, uint Year)
		{
			this.ExpirationDate.Day = Day;
			this.ExpirationDate.Month = Month;
			this.ExpirationDate.Year = Year;

			// Turn as unavailable time.
			this.ExpirationDate.Hours = 24;
			this.ExpirationDate.Minutes = 0;
			this.ExpirationDate.Seconds = 0;
		}

		// Unknow or not available expiration date:
		public void SetExpiratDate()
		{
			this.ExpirationDate.Day = 0;
			this.ExpirationDate.Month = 0;
			this.ExpirationDate.Year = 0;

			// Turn as unavailable time.
			this.ExpirationDate.Hours = 24;
			this.ExpirationDate.Minutes = 0;
			this.ExpirationDate.Seconds = 0;
		}
	}
}