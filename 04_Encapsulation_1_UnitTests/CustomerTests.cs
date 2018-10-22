using System;
using _04_Encapsulation_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Encapsulation_1_UnitTests
{
	[TestClass]
	public class CustomerTests
	{
		private CustomerQueueRepository _queueRepository;
		private Customer _customer1;
		private Customer _customer2;
		private Customer _customer3;

		[TestInitialize]
		public void Initialize()
		{
			_customer1 = new Customer();
			_customer2 = new Customer();

			_queueRepository = new CustomerQueueRepository();
			_queueRepository.AddCustomerToQueue(_customer1);
			_queueRepository.AddCustomerToQueue(_customer2);
			_queueRepository.AddCustomerToQueue(_customer3);
			
		}
		

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void Customer_ExceptionOutOfRange_should_throw_expection()
		{
			Customer customer = new Customer();
			customer.FirstName = "Kenn  ";
			Console.WriteLine(customer.FirstName);
			customer.LastName = "McLastName";
			customer.Age = -1;

		}
		//TODO: Add other exceptions

		[TestMethod]
		public void QueueRepo_RemoveFromQueue_removes_customer()
		{
			var expected = _customer1;
			var actual = _queueRepository.RemoveCustomerFromQue();
			Assert.AreEqual(expected, actual);
		}
	}
}
