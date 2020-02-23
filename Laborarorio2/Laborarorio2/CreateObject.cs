using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laborarorio2.Models;
using Laborarorio2.Interface;

namespace Laborarorio2
{
    public class CreateObject : ICreateFixedSizeText<Bebida>
    {
		public Bebida Create(string FixedSizeText)
		{
			Bebida ob = new Bebida();
			ob.Nombre = Convert.ToString(FixedSizeText.Substring(0, 10));
			/*ob. = Convert.ToString(FixedSizeText.Substring(11, 20));
			ob.Campos = Convert.ToString(FixedSizeText.Substring(21, 222));
			*/
			return ob;
		}

		public Bebida CreateNull()
		{
			return new Bebida();
		}
	}	
}
