using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laborarorio2.Interface;
using Laborarorio2.Utilities;
using Laborarorio2.Models;

namespace Laborarorio2.Tree
{
	public class Node<T> where T : IComparable, IFixedSizeText
	{
		internal List<T> Data { get; set; }
		internal List<int> Children { get; set; }
		internal int Father { get; set; }
		internal int ID { get; set; }
		internal int Order { get; set; }

		internal int FixedSize (int Father)
		{
			int InTextSize = 0;

			InTextSize += Util.IntegerSize + 1; // Posición
			InTextSize += Util.IntegerSize + 1; // Padre

			if (Father == -1)
			{
				InTextSize += (Data[0].FixedSize + 1) * ((4 * (Order - 1)) / 3); //Data
				InTextSize += (Util.IntegerSize + 1) * ((4 * (Order - 1)) / 3) + (Util.IntegerSize + 1);	// Children
			}
			else
			{
				InTextSize += (Data[0].FixedSize + 1) * (Order - 1);
				InTextSize += (Util.IntegerSize + 1) * Order;
			}				
			InTextSize += 2; // \r\n

			return InTextSize;
			
		}

		public int FixedSizeText ()
		{
			return FixedSize(this.Father);
		}

		private int SeekPosition(int Root)
		{
			if (ID <= Root)
			{
				return Header.FixedSize + (ID * FixedSizeText());
			}
			else
			{
				return Header.FixedSize + ((ID - 1) * FixedSizeText()) + FixedSize(-1);
			}
		}
	}
}
