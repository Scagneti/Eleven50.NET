using BadgeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeDictionary
{
	public class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				BadgeRepo _repo = new BadgeRepo();
				List<string> _inputList = new List<string>();

				Console.WriteLine("Hello Security Admin, What would you like to do? \n" +
					"1. Add a badge \n" +
					"2. Update a badge \n" +
					"3. List all badges \n" +
					"4. Revoke access");
				var menu = int.Parse(Console.ReadLine());

				if (menu == 1)
				{
					Console.WriteLine("What is the number on the badge?");
					var id = int.Parse(Console.ReadLine());

					Console.Write("What door(s) will this badge have access to?");
					string doors = Console.ReadLine();
					_inputList.Add(doors);


					_repo.AddToDictionary(id, _inputList);
				}
				if (menu == 2)
				{
					Console.WriteLine("What is the number of the badge you'd like to edit?");
					var id = int.Parse(Console.ReadLine());

					Console.WriteLine($"What door(s) will badge number {id} have access to?");
					string doors = Console.ReadLine();
					_inputList.Add(doors);

					_repo.UpdateBadge(id, _inputList);
				}
				if (menu == 3)
				{
					var contents = _repo.GetDictionary();
					_inputList.Add("abc");
					_repo.AddToDictionary(1, _inputList);
					contents.ToList().ForEach(x => Console.WriteLine(x.Key));
				}
				if (menu == 4)
				{
					Console.WriteLine("What badge would you like to remove all door access for?");
					var id = int.Parse(Console.ReadLine());

					_repo.RemoveAllDoorsFromBadge(id);

					Console.WriteLine($"Badge number {id} has had all access revoked.");
				}
			}
		}
	}
}
