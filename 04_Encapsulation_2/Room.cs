using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation_2
{
    public class Room
    {
		private const double MAX_LENGTH = 30d;
		private const double MIN_LENGTH = 6d;
		private const double MAX_WIDTH = 30d;
		private const double MIN_WIDTH = 6d;
		private const double MAX_HEIGHT = 12d;
		private const double MIN_HEIGHT = 10d;

		private double _roomHeight;

		public double RoomHeight
		{
			get => _roomHeight;
			set
			{
				if (value > MAX_HEIGHT || value < MIN_HEIGHT)
					throw new ArgumentOutOfRangeException("Height does not meet requirements.");
				else
					_roomHeight = value;
			}
		}
		private double _roomLength;

		public double RoomLength
		{
			get => _roomLength;
			set
			{
				if (value > MAX_LENGTH || value < MIN_LENGTH)
					throw new ArgumentOutOfRangeException("Length does not meet requirements.");
				else
					_roomLength = value;
			}
		}
		private double _roomWidth;

		public double RoomWidth
		{
			get => _roomWidth;
			set
			{
				if (value > MAX_WIDTH || value < MIN_WIDTH)
					throw new ArgumentOutOfRangeException("Width does not meet requirements.");
				else
					_roomWidth = value;
			}
		}

		public double WallArea(double width, double length)
		{
			var area = width * length;
			return area;
		}
		}



	}

