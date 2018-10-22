using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04_Encapsulation_2;
using System.Linq;

namespace _04_Encapsulation_2_UnitTests
{
	[TestClass]
	public class RoomTests
	{
		private Room _room;
	

		[TestInitialize]
		public void Initialize()
		{
			_room = new Room();

		}

		[TestMethod]
		public void Room_MaxHeightandMinHeight_is_not_exceeded()
		{
			_room.RoomHeight = 11d;
		}
		[TestMethod]
		public void Room_MinWidthandMaxWidth_is_not_exceeded()
		{
			_room.RoomWidth = 25d;
		}
		[TestMethod]
		public void Room_MinLengthandMaxLength_is_not_exceeded()
		{
			_room.RoomLength = 6d;
		}
	}
}
