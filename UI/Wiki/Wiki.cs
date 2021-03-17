using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.UI.Wiki
{
	class Wiki
	{
		// Will need various node tree operations, either here or in WikiCategory

		public Wiki()
		{
			Dictionary<string, string> categories = new Dictionary<string, string>()
			{
				{ "Root", null },

				{ "Creations", "Root" }, // Those of Godde
					{ "Fauna", "Creations" },
						{ "Cattle", "Fauna" },
						{ "Pests", "Fauna" },
						{ "Predators", "Fauna" },
					{ "Flora", "Creations" },
						{ "Ferns", "Flora" },
						{ "Flowers", "Flora" },
						{ "Fungi", "Flora" },
						{ "Gourds", "Flora" },
						{ "Grasses", "Flora" }, // Incl. Grains
						{ "Legumes", "Flora" },
						{ "Trees", "Flora" },
						{ "Tubers", "Flora" },
					{ "Maladies", "Creations" },
					{ "Minerals", "Creations" },

				{ "Works", "Root" }, // Those of Manne
					{ "Blueprints", "Works" },
					{ "Buildings", "Works" },

				{ "People", "Root" }, // Those who... are Manne
					{ "Villagers", "People" },
						{ "Babes", "Villagers" },
						{ "Men", "Villagers" },
						{ "Women", "Villagers" }, // And these be all types there ever shall be; Mayst thou forever @ me not
					{ "Merchants", "People" },
			};

			foreach (KeyValuePair<string, string> category in categories)
			{
				CreateCategory(category.Key, category.Value);
			}
		}

		private void CreateCategory(string name, string parent)
		{
			// TODO: Handle nodes with multiple parents
			// But beware of looping parenthood! It lurks.

			var myObject = (WikiCategory)Activator.CreateInstance(null, name, parent);
		}

		public static bool DoesWikiPageExist(string destination)
		{

			return false;
		}
	}
}