using System;
using _02_Reference_Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Reference_Types_UnitTests
{
	[TestClass]
	public class CustomerTests
	{
		[TestInitialize]
		public void Initialize()
		{
			Customer customer = new Customer();
		}

		[TestMethod]
		public void Customer_SetFirstNameAsString()
		{
			//-- Arrange
			Customer customer = new Customer();
			//-- Act
			customer.FirstName = "Zach";
			var actual = customer.FirstName;
			var expected = "Zach";



			Console.Write($"Actual: {actual}");
			//-- Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Customer_LastNameIsProperString()
		{
			Customer customer = new Customer();

			customer.LastName = "Jauhal";
			var actual = customer.LastName;
			var expected = "Jauhal";

			Assert.AreEqual(expected, actual);
		}
	}
}
