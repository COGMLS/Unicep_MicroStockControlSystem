using DatabaseStorageLib;

namespace MicroStockControl
{
	// Create a global storage:
	public static class StockGlobalAccess
	{
		// Create an empty stock data base:
		public static StockStorage InStockDB = new StockStorage(0);
		public static StockStorage OutStockDB = new StockStorage(1);
	}

	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new MainForm());
		}
	}
}