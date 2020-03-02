using Verse;

namespace Nandonalt_SnowyTrees
{
	public class SnowyPlantDef : Def
	{
		private string leaflessSnowyPath = null;
		private string immatureSnowyPath = null;
		private string regularSnowyPath = null;

		public string LeaflessSnowyPath
		{
			get { return leaflessSnowyPath; }
			set { leaflessSnowyPath = value; }
		}

		public string ImmatureSnowyPath
		{
			get { return immatureSnowyPath; }
			set { immatureSnowyPath = value; }
		}

		public string RegularSnowyPath
		{
			get { return regularSnowyPath; }
			set { regularSnowyPath = value; }
		}
	}
}
