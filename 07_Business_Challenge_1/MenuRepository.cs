using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Business_Challenge_1
{
	public class MenuRepository
	{
		private List<Menu> _menuList;

		public MenuRepository()
		{
			_menuList = new List<Menu>();
		}

		public string AddMenuItemToList(Menu model)
		{
			_menuList.Add(model);
			return model.MealName;
		}
		
		public string RemoveMenuItemFromList(Menu model)
		{
			_menuList.Remove(model);
			return model.MealName;
		}
		public List<Menu> GetMenuList()
		{
			return _menuList;
		}
	}
}
