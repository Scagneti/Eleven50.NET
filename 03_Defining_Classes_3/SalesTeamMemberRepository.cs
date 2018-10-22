using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_3
{
	public class SalesTeamMemberRepository
	{
		private List<SalesTeamMember> _salesTeamList;

		public SalesTeamMemberRepository()
		{
			_salesTeamList = new List<SalesTeamMember>();
		}

		public void AddSalesTeamMember(SalesTeamMember model)
		{
			_salesTeamList.Add(model);
		}

		public List<SalesTeamMember> GetList()
		{
			return _salesTeamList;
		}

		public int ReturnTotals()
		{
			var Total = 0;
			foreach(SalesTeamMember mem in _salesTeamList)
			{
				Total += mem.TotalSales;
			}
			return Total;
		}
		public int ReturnMin()
		{
			var lowest = _salesTeamList.Min(s => s.TotalSales);

			return lowest;
		}
		public int ReturnMax()
		{
			var lowest = _salesTeamList.Max(s => s.TotalSales);

			return lowest;
		}
		public List<SalesTeamMember> GetMembersWithLowestSales()
		{
			var lowestNum = ReturnMin();

			//var members = _salesTeamMemberList.FindAll(x => x.MonthlySales == lowestNum);
			List<SalesTeamMember> members = new List<SalesTeamMember>();
			foreach (SalesTeamMember s in _salesTeamList)
			{
				if (s.TotalSales == lowestNum)
					members.Add(s);
			}

			return members;
		}
		public List<SalesTeamMember> GetMembersWithHighestSales()
		{
			var highestNum = ReturnMax();

			//var members = _salesTeamMemberList.FindAll(x => x.MonthlySales == lowestNum);
			List<SalesTeamMember> members = new List<SalesTeamMember>();
			foreach (SalesTeamMember s in _salesTeamList)
			{
				if (s.TotalSales == highestNum)
					members.Add(s);
			}

			return members;
		}
	}
}
