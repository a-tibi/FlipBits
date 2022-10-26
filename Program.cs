using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlipBits
{
	class Program
	{
		public static long flippingBits(long n)
		{
			var bits = Convert.ToString(n, 2).PadLeft(32, '0');
			var flipped = bits.Select(b => b == '0' ? '1' : '0');

			var flippedBits = new StringBuilder();

			foreach (var bit in flipped)
			{
				flippedBits.Append(bit);
			}

			var uL = Convert.ToUInt64(flippedBits.ToString(), 2);

			return (long)uL;
		}

		static void Main(string[] args)
		{
			long x = flippingBits(8);
			Console.WriteLine(x);

			Console.ReadKey();
		}
	}
}
