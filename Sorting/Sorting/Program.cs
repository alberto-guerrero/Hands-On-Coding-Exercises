using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
	// The output must display the items sorted in ascending order.
	// Notes:
	//     Main method cannot be modified.
	//     The base class for Entity cannot be changed.
	class Program
	{
		static void Main(string[] args)
		{
			Entity e = new Entity();
			e.Add(5);
			e.Add(2);
			e.Add(10);
			e.Add(9);
			e.Add(1);
			e.Add(3);
			e.Add(4);

			foreach (int i in e)
				Console.WriteLine(i);

			Console.ReadLine();
		}
	}

	class Entity : System.Collections.ArrayList
	{
	}
}
