﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Concepts
{
	class BarnOwl : IBird
	{
		public void Eat()
		{
			throw new NotImplementedException();
		}

		public void FlapWings()
		{
			throw new NotImplementedException();
		}

		public void MakeSound()
		{
			Console.WriteLine("Hissssss");
		}

		public void Move()
		{
			throw new NotImplementedException();
		}
	}
}
