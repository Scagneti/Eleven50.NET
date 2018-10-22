using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Business_Challenge_1
{
    public class Menu
    {
		private int _mealNumber;

		public int MealNumber
		{
			get { return _mealNumber; }
			set { _mealNumber = value; }
		}
		private string _mealName;

		public string MealName
		{
			get { return _mealName; }
			set { _mealName = value; }
		}
		private string _description;

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}
		private double _price;

		public double Price
		{
			get { return _price; }
			set { _price = value; }
		}
		private string _ingredients;
		private int v1;
		private string v2;

		public string Ingredients
		{
			get { return _ingredients; }
			set { _ingredients = value; }
		}

		public Menu() { }

		public Menu(int MealNumber, string MealName, string Description, double Price)
		{
			_mealNumber = MealNumber;
			_mealName = MealName;
			_description = Description;
			_price = Price;
		}


	}
}
