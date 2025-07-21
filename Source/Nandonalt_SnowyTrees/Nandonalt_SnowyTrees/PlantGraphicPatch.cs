using HarmonyLib;
using RimWorld;
using System;
using System.Reflection;
using Verse;


namespace Nandonalt_SnowyTrees;

[StaticConstructorOnStartup]
public class HarmonyPatches
{
	static readonly Type patchType = typeof(HarmonyPatches);

	static HarmonyPatches ()
	{
		var harmony = new Harmony("Nandonalt_SnowyTrees.main");
		harmony.Patch(AccessTools.Method(typeof(Plant), "get_Graphic"), null, new HarmonyMethod(patchType, nameof(SnowyGraphic)));

		harmony.PatchAll(Assembly.GetExecutingAssembly());
	}

	[HarmonyPostfix]
	public static void SnowyGraphic (Plant __instance, ref Graphic __result)
	{
		if (__instance.Spawned &&
		    __instance.Map.snowGrid.GetDepth(__instance.Position) >= 0.5f &&
		    __instance.LifeStage != PlantLifeStage.Sowing)
		{

			SnowyPlantDef candidatePlant = DefDatabase<SnowyPlantDef>.GetNamed(__instance.def.defName, false);

			if (candidatePlant != null)
			{
				// If the tree is currently leafless and a leafless graphic exists
				 if (candidatePlant.graphicDB.ContainsKey(PlantGraphic.Leafless) && __instance.LeaflessNow && (!__instance.sown || !__instance.HarvestableNow))
				{
					__result = candidatePlant.LeaflessGraphic;
				}
				// else, if immature variant and supported:
				else if (candidatePlant.graphicDB.ContainsKey(PlantGraphic.Immature) && !__instance.HarvestableNow)
				{
					__result = candidatePlant.ImmatureGraphic;
				}
				// Otherwise we show the snowy default / mature variant if it is supported.
				else if (candidatePlant.graphicDB.ContainsKey(PlantGraphic.Regular))
				{
					__result = candidatePlant.Graphic;
				}
			}
		}
	}
}