using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _07_Business_Challenge_1;

namespace _07_Business_Challenge_1_UnitTests
{
	[TestClass]
	public class MenuRepositoryUnitTests
	{
		private MenuRepository _menuRepo;
		private Menu _menuItem1;
		private Menu _menuItem2;
		private Menu _menuItem3;
		
		[TestInitialize]
		public void Initialize()
		{
			_menuRepo = new MenuRepository();
			_menuItem1 = new Menu(1, "Sandwich", "A tasty sandwich", 1.50d);
			_menuItem2 = new Menu(2, "Salad", "A tasty salad", 2.00d);
			_menuItem3 = new Menu(3, "Burger", "A tasty burger", 2.50d);

		}
		[TestMethod]
		public void Menu_AddMenuItem_adds_item_to_list()
		{
			var expected = "Sandwich";
			var actual = _menuRepo.AddMenuItemToList(_menuItem1);
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Menu_RemoveMenuItem_adds_item_to_list()
		{
			var expected = "Sandwich";
			var actual = _menuRepo.RemoveMenuItemFromList(_menuItem1);
			Assert.AreEqual(expected, actual);
		}
	}
}
