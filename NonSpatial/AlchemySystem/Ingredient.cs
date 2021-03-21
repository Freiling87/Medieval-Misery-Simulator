using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.NonSpatial
{
	public enum IngredientType
	{
		Liquid,
		Powder,
		Solid,
		Vapor
	}

	// Consider making child classes for these instead? Would simplify arguments in Alchemy

	public class Ingredient
	{
		public Genome genome;
		public IngredientType type;
		public string name;

		public Ingredient(string _name, Genome _genome, IngredientType _type)
		{
			genome = _genome;
			type = _type;
		}
	}
}
