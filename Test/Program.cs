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
			int value =;
			int[] result = new int[8];
			Console.WriteLine(value);
			for (int i = 0; i < 8; i++)
			{
                result[7 - i] = value % 2;
                value /= 2;
            }
			for (int i = 0;i < 8;i++)
			{
				Console.Write(result[i]);

			}
			
			Console.WriteLine();
			Console.WriteLine(result);
		}
	}
}
