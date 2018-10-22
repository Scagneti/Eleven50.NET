using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_DefiningClasses_04;
namespace _03_DefiningClasses_04_UnitTests
{
	[TestClass]
	public class IncidentClaimUnitTests
	{
		private IncidentClaimRepository _incidentRepo;
		private Claim claim1;
		private Claim claim2;
		private Incident incident1;

		[TestInitialize]
		public void Initialize()
		{
			_incidentRepo = new IncidentClaimRepository();
			claim1 = new Claim(10001, Convert.ToDateTime("01/01/2018"));
			incident1 = new Incident(Convert.ToDateTime("12/31/2018"));
			claim1.ClaimDate = Convert.ToDateTime("01/01/2018");
			incident1.IncidentDate = Convert.ToDateTime("12/31/2018");
			claim1.Amount = 10001;
			claim2 = new Claim(999, Convert.ToDateTime("01/01/2018"));
			claim2.Amount = 999;

		}

		[TestMethod]
		public void IncidentClaimRepo_IsValid_returns_true()
		{
			
			var expected = true;
			var actual = _incidentRepo.IsClaimValid(claim1.ClaimDate, incident1.IncidentDate);
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void IncidentClaimRepo_ClaimOver10000_returns_correct_message()
		{
			var expected = "Please wait while transferring you to a representative.";
			var actual = _incidentRepo.ClaimMessage(claim1.Amount);
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void IncidentClaimRepo_ClaimUnder10000_returns_correct_message()
		{
			var expected = "Your claim is being processed.";
			var actual = _incidentRepo.ClaimMessage(claim2.Amount);
			Assert.AreEqual(expected, actual);
		}
	}
}
