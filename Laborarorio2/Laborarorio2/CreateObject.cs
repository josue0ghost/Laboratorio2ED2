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
			ob.Nombre = Convert.ToString(FixedSizeText.Substring(0, 25)).Trim();
			ob.Sabor = Convert.ToString(FixedSizeText.Substring(26, 25)).Trim();
			ob.Volumen = Convert.ToDouble(FixedSizeText.Substring(52, 10));
			ob.Precio = Convert.ToDouble(FixedSizeText.Substring(63, 10));
			ob.CasaProductora = Convert.ToString(FixedSizeText.Substring(74, 25)).Trim();
			
			return ob;
		}

		public Bebida CreateNull()
		{
			Bebida bebida = new Bebida();
			bebida.Nombre = "";
			bebida.Sabor = "";
			bebida.Volumen = 0;
			bebida.Precio = 0;
			bebida.CasaProductora = "";

			return bebida;
		}
	}	
}
