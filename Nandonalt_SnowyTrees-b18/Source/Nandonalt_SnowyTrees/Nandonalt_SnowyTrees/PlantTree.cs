using System;
using System.Collections.Generic;
using System.Reflection;
using RimWorld;
using Verse;
using Harmony;
using UnityEngine;


namespace Nandonalt_SnowyTrees
{
	[StaticConstructorOnStartup]
	public class HarmonyPatches
	{
		static readonly Type patchType = typeof(HarmonyPatches);

		static HarmonyPatches()
		{
			HarmonyInstance harmony = HarmonyInstance.Create("Nandonalt_SnowyTrees.main");
			harmony.Patch(AccessTools.Method(typeof(Plant), "get_Graphic"), null, new HarmonyMethod(patchType, nameof(PlantGraphicPostfix)));

			harmony.PatchAll(Assembly.GetExecutingAssembly());
		}

		public static void PlantGraphicPostfix(Plant __instance, ref Graphic __result)
		{
			List<string> alteredPlantDefs = new List<string>(new string[] { "PlantRaspberry", "PlantBush", "PlantTreeOak", "PlantTreePoplar", "PlantTreePine", "PlantTreeBirch", "PlantTreeTeak", "PlantTreeCecropia" });

			if (alteredPlantDefs.Contains(__instance.def.defName))
			{
				//if (__instance.Map.snowGrid.GetDepth(__instance.Position) >= 0.5f)
				{
					ThingDef parentDef = __instance.def;

					string imgPath = parentDef.graphicData.texPath;
					//string imgPath = "Things/Plant/"

					Graphic Snowy = GraphicDatabase.Get(parentDef.graphicData.graphicClass, imgPath, parentDef.graphic.Shader, parentDef.graphicData.drawSize, parentDef.graphicData.color, parentDef.graphicData.colorTwo);
					__result = Snowy;
				}
			}
		}
	}

	/*public static class TreeInjector
	{
		public static List<string> alteredPlantDefs = new List<string>(new string[] { "PlantRaspberry", "PlantBush", "PlantTreeOak", "PlantTreePoplar", "PlantTreePine", "PlantTreeBirch", "PlantTreeTeak", "PlantTreeCecropia" });

		static TreeInjector ()
		{

			alteredPlantDefs.ForEach(delegate (string defName)
			{
				ThingDef parentDef = ThingDef.Named(defName);

				Graphic loadSnowy = GraphicDatabase.Get(parentDef.graphicData.graphicClass, parentDef.graphicData.texPath, parentDef.graphic.Shader, parentDef.graphicData.drawSize, parentDef.graphicData.color, parentDef.graphicData.colorTwo);
			});

		}

	}*/
}
