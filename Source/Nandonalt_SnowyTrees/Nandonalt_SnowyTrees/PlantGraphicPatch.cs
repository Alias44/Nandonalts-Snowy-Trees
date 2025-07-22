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
#if !(RELEASE_1_1 || RELEASE_1_2 || RELEASE_1_3)
				if(candidatePlant.HasPlantGraphic(PlantGraphic.PollutedGraphic) && __instance.PositionHeld.IsPolluted(__instance.MapHeld)) {
					__result = candidatePlant.GetGraphic(PlantGraphic.PollutedGraphic);
				}
				else
#endif
				if (candidatePlant.HasPlantGraphic(PlantGraphic.LeaflessImmature) && __instance.LeaflessNow && !__instance.HarvestableNow)
				{
					__result = candidatePlant.GetGraphic(PlantGraphic.LeaflessImmature);
				}
				// If the tree is currently leafless and a leafless graphic exists
				else if (candidatePlant.HasPlantGraphic(PlantGraphic.Leafless) && __instance.LeaflessNow && (!__instance.sown || !__instance.HarvestableNow))
				{
					__result = candidatePlant.GetGraphic(PlantGraphic.Leafless);
				}
				// else, if immature variant and supported:
				else if (candidatePlant.HasPlantGraphic(PlantGraphic.Immature) && !__instance.HarvestableNow)
				{
					__result = candidatePlant.GetGraphic(PlantGraphic.Immature);
				}
				// Otherwise we show the snowy default / mature variant if it is supported.
				else if (candidatePlant.HasPlantGraphic(PlantGraphic.Regular))
				{
					__result = candidatePlant.GetGraphic(PlantGraphic.Regular);
				}
			}
		}
	}
}