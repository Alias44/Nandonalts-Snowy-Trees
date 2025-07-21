using System;
using System.Xml;

namespace Nandonalt_SnowyTrees;

public enum PlantGraphic : byte
{
	Regular = 0,
	Immature,
	Leafless,
}

public class SnowyGraphic
{
	public PlantGraphic plantGraphic;
	public string path;

	public SnowyGraphic() { }

	public void GeneratePath(string basePath, string name)
	{
		string suffix = plantGraphic switch
		{
			PlantGraphic.Leafless => "_Leafless",
			PlantGraphic.Immature => "_Immature",

			_ => "",
		};
		path = basePath + name + suffix;
	}

	public void LoadDataFromXmlCustom(XmlNode xmlRoot)
	{
		plantGraphic = (PlantGraphic) Enum.Parse(typeof(PlantGraphic), xmlRoot.Name);

		if (xmlRoot.HasChildNodes)
		{
			path = xmlRoot.FirstChild.Value;
		}
	}
}
