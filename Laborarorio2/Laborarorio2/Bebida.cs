using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laborarorio2.Interface;

namespace Laborarorio2.Models
{
	public class Bebida : IComparable, IFixedSizeText
	{
		public string Nombre { get; set; }
		public string Sabor { get; set; }
		public double Volumen { get; set; }
		public double Precio { get; set; }
		public string CasaProductora { get; set; }

		public int CompareTo(object obj)
		{
			var s2 = (Bebida)obj;
			return Nombre.CompareTo(s2.Nombre);
		}

		public int FixedSize { get { return 99; } }

		public string ToFixedSizeString()
		{
			return $"{string.Format("{0,-25}", Nombre)}~" +
				$"{string.Format("{0,-25}", Sabor)}~" + 
				$"{Volumen.ToString("0000000000;-0000000000")}~" +
				$"{Precio.ToString("0000000000;-0000000000")}~" +
				$"{string.Format("{0,-25}", CasaProductora)}";
		}

		public int FixedSizeText
		{
			//return suma de todos los caracteres en ToFixedSizeString
			get { return FixedSize; }
		}

		public override string ToString()
		{
			return string.Format("Nombre: {0}\r\nSabor: {1}\r\nVolumen: {2}\r\nPrecio: {3}\r\nCasa Productora: {4}"
				, string.Format("{0,-25}", Nombre)
				, string.Format("{0,-25}", Sabor)
				, Volumen.ToString("0000000000;-0000000000")
				, Precio.ToString("00000000000;-0000000000")
				, string.Format("{0,-25}", CasaProductora));
		}
	}
}
