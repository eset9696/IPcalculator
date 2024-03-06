using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int value = 0;
			int p = 1;
			int n = 8;
			int counter = 0;
			Console.WriteLine(value);
			while (--n > 0)
			{
				value += 1;
				value <<= 1;
				counter++;
			}
			Console.WriteLine(value);
			Console.WriteLine(Convert.ToString(value, 2) + " " + counter);
		}
	}
}
