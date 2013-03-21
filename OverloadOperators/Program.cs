using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperators
{
	class Program
	{
		static void Main(string[] args)
		{
			DoubleOOP result;
			DoubleOOP v1 = new DoubleOOP(10);
			DoubleOOP v2 = new DoubleOOP(20);
			Console.WriteLine("Value1: " + v1 + " Value2: " + v2);
			Console.WriteLine("Hashcodes - Value1: " + v1.GetHashCode() + " Value2: " + v2.GetHashCode());
			result = v1 + v2; 
			Console.WriteLine("Value1 + Value2: " + result);
			result = v1 - v2;
			Console.WriteLine("Value1 - Value2: " + result);
			result = v1 * v2;
			Console.WriteLine("Value1 * Value2: " + result);
			result = v1 / v2;
			Console.WriteLine("Value1 / Value2: " + result);
			Console.WriteLine("Casting to double - Value1: " + (double)v1 + " Value2: " + (double)v2);
			Console.WriteLine("Are they equal? {0}: ", (v1 == v2).ToString());
			Console.WriteLine("Are they not equal? {0}: ", (v1 != v2).ToString());
			Console.ReadKey();

		}
	}
}
