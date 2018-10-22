using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeRepository
{
	public class BadgeRepo
	{
		Dictionary<int, List<string>> BadgeDictionary = new Dictionary<int, List<string>>();


		public void CreateDictionary()
		{
			BadgeDictionary = new  Dictionary<int, List<string>>();
		}

		public Dictionary<int, List<string>> GetDictionary()
		{
			return BadgeDictionary;
		}

		public void AddToDictionary(int id, List<string> doors)
		{
			BadgeDictionary.Add(id, doors);
		}

		public void RemoveAllDoorsFromBadge(int id)
		{
			BadgeDictionary.Remove(id);
		}

		public void UpdateBadge(int id, List<string> values)
		{
			BadgeDictionary[id] = values;
		}
	}
}
