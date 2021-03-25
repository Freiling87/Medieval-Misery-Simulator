using System;
using System.Collections.Generic;
using System.Text;

using MMS.NonSpatial.PhysicalSystem;

namespace MMS.NonSpatial
{
	public class Genome
	{
		static List<Gene> genome;

		public Genome()
		{
			// Randomly generated 

			for (int i = 0; i < 32; i++)
				genome.Add(new Gene());
		}

		private Genome Addition(Genome target)
		{
			// E.g., 

			return this;
		}

		private Genome Subtraction(Genome target)
		{
			// E.g., Determine efficacy of a cure against a disease.

			return this;
		}

		public static Genome Combination(Genome father, Genome mother)
		{
			// Determine outcome of a cross-bred cultivar.
			// Should later be turned into static, since it accepts both ingredients as arguments.

			return new Genome();
		}
		public static Genome Combination(Agent father, Agent mother) =>
			Combination(father.genome, mother.genome);
		public static Genome Combination(Fauna father, Fauna mother) =>
			Combination(father.genome, mother.genome);
		public static Genome Combination(Flora father, Flora mother) =>
			Combination(father.genome, mother.genome);

		private Genome Mutation()
		{
			// Clone of self with modification

			return this;
		}
			
	}
}
