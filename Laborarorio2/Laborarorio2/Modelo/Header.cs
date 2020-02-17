using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborarorio2.Modelo
{
	public class Header
	{
		public int Root { get; set; }
		public int NextPosition { get; set; }
		public int Order { get; set; }

		public static int FixedSize { get { return 34; } }

		public string ToFixedSizeString()
		{
			return $"{Root.ToString("0000000000;-000000000")}|"
				+ $"{Order.ToString("0000000000;-000000000")}|"
				+ $"{NextPosition.ToString("0000000000;-000000000")}\r\n";
		}

		public int FixedSizeText
		{
			get { return FixedSize; }
		}
	}
}
