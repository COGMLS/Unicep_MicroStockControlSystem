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
		public static bool UintCompPart(uint basenum, uint testnum)
		{
			return basenum.ToString().Contains(testnum.ToString());
		}
	}
}
