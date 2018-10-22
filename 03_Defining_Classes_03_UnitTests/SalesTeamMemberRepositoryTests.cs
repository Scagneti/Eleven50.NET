using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Defining_Classes_3;
using System.Collections.Generic;

namespace _03_Defining_Classes_03_UnitTests
{
	[TestClass]
	public class SalesTeamMemberRepositoryTests
	{
		private SalesTeamMember _member1;
		private SalesTeamMember _member2;
		private SalesTeamMemberRepository _salesRepo;
		[TestInitialize]
		public void Initialize()
		{
			_salesRepo = new SalesTeamMemberRepository();
			SalesTeamMember newMember = new SalesTeamMember()
			{
				LastName = "Nelson",
				TotalSales = 10
			};
			SalesTeamMember newMember2 = new SalesTeamMember()
			{
				LastName = "Alderson",
				TotalSales = 15
			};

			_member1 = new SalesTeamMember("nelson", 500);
			_member2 = new SalesTeamMember("alderson", 400);
			_salesRepo.AddSalesTeamMember(newMember);
			_salesRepo.AddSalesTeamMember(newMember2);

		}
		[TestMethod]
		public void SalesTeamRepo_TotalSales_returns_correct_value()
		{
			var expected = 25;
			var actual = _salesRepo.ReturnTotals();
			Assert.AreEqual(expected, actual);
			
		}

		[TestMethod]
		public void SalesTeamRepo_MinSales_returns_correct_value()
		{
			var expected = 10;
			var actual = _salesRepo.ReturnMin();
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void SalesTeamRepo_MaxSales_returns_correct_value()
		{
			var expected = 15;
			var actual = _salesRepo.ReturnMax();
			Assert.AreEqual(expected, actual);
		}
	}
}