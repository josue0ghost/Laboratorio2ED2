using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laborarorio2.Tree;
using Laborarorio2.Models;

namespace Laborarorio2.Models
{
    public class Data
    {
		private static Data instance = null;
		public static Data Instance
		{
			get
			{
				if (instance == null) instance = new Data();
				return instance;
			}
		}

		public Tree<Bebida> myTree;	
	}
}
