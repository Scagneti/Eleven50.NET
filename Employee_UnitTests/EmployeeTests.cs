using System;
using _03_Defining_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Employee_UnitTests
{
	[TestClass]
	public class EmployeeTests
	{
		//--Field 
		private Employee _employee;

		[TestInitialize]
		public void Arrange()
		{
			//--Arrange
			_employee = new Employee();
			_employee.EmployeeID = 1;
			_employee.LastName = "Nelson";
			_employee.NumberOfHoursOnClock = 4000;
			_employee.Age = 40;
		}

		[TestMethod]
		public void Employee_LastName_IsProperString()
		{
			//--Arrange
			//--Act
			var expected = "Nelson";
			var actual = _employee.LastName;
			//--Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Employee_ID_IsInt()
		{
			var expected = 1;
			var actual = _employee.EmployeeID;
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Employee_Age_IsInt()
		{
			var expected = 40;
			var actual = _employee.Age;
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Employee_NumberOfHoursOnClock_IsInt()
		{
			var expected = 4000;
			var actual = _employee.NumberOfHoursOnClock;
			Assert.AreEqual(expected, actual);
		}
	}
}
