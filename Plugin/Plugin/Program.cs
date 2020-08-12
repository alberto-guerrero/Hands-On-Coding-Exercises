using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plugin
{
	// Modify the code to allow a single collection containing both circles & squares.
	// There must be only one loop to generate the output from the Draw method.
	
	class Program
	{
		static void Main(string[] args)
		{
			List<Circle> circles = new List<Circle>();
			circles.Add(new Circle { X = 1, Y = 2, Radius = 3 });
			circles.Add(new Circle { X = 2, Y = 15, Radius = 1 });

			List<Square> squares = new List<Square>();
			squares.Add(new Square { X = 3, Y = 7, Length = 15 });
			squares.Add(new Square { X = 3, Y = 10, Length = 23 });
			squares.Add(new Square { X = 7, Y = 0, Length = 2 });

			foreach (var c in circles)
				c.Draw();

			foreach (var s in squares)
			    s.Draw();

			Console.ReadLine();
		}
	}

	public class Circle
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Radius { get; set; }

		public void Draw()
		{
			Console.WriteLine(String.Format("Circle: {0} {1} {2}", X, Y, Radius));
		}
	}

	public class Square
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Length { get; set; }

		public void Draw()
		{
			Console.WriteLine(String.Format("Square: {0} {1} {2}", X, Y, Length));
		}
	}
}
