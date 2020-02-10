using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborarorio2.Interface
{
	public interface ICreateFixedSizeText<T> where T : IFixedSizeText
	{
		T Create(string FixedSizeText);
		T CreateNull();
	}
}
