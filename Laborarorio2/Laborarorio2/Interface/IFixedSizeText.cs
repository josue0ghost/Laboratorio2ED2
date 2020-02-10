using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborarorio2.Interface
{
	public interface IFixedSizeText
	{
		int FixedSize { get; }
		string ToFixedSizeString();
	}
}
