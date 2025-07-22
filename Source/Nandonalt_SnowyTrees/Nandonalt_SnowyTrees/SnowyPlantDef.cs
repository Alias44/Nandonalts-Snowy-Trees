using System.Collections.Generic;
using System.Linq;
using Verse;

namespace Nandonalt_SnowyTrees;

public class SnowyPlantDef : Def
{
	public string baseGraphicPath;

	public List<SnowyGraphic> graphics = [];

	public Dictionary<PlantGraphic, Graphic> graphicDB = [];

	public bool HasPlantGraphic(PlantGraphic graphic) => graphicDB.ContainsKey(graphic);
	public Graphic GetGraphic(PlantGraphic graphic) => graphicDB.GetValueOrDefault(graphic, null);

	public override void PostLoad()
	{
		var autoPath = graphics.Where(g => g.path.NullOrEmpty());

		if (autoPath.Any() && (baseGraphicPath.NullOrEmpty() || this.label.NullOrEmpty()))
		{
			Log.Error($"Attempted Snowy Trees auto pathing for {this.defName} without defining base path or label");
			return;
		}

		foreach (var data in autoPath)
		{
			data.GeneratePath(baseGraphicPath, this.label);
		}
	}

	public override void ResolveReferences()
	{
		base.ResolveReferences();

		ThingDef parentDef = DefDatabase<ThingDef>.GetNamed(this.defName);


		foreach (var item in graphics)
		{
			if (!item.path.NullOrEmpty())
			{
				LongEventHandler.ExecuteWhenFinished(delegate
				{
					graphicDB[item.plantGraphic] = GraphicDatabase.Get(parentDef.graphicData.graphicClass, item.path, parentDef.graphic.Shader, parentDef.graphicData.drawSize, parentDef.graphicData.color, parentDef.graphicData.colorTwo);
				});
			}
		}
	}
}
