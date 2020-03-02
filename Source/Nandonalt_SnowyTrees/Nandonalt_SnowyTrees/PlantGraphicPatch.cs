using System;
using System.Reflection;
using HarmonyLib;
using RimWorld;
using Verse;


namespace Nandonalt_SnowyTrees
{
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
			if (!(__instance.LifeStage == PlantLifeStage.Sowing))
			{
				// If there is snow in the ground, switch graphic to snowy variant:
				if (__instance.Map.snowGrid.GetDepth(__instance.Position) >= 0.5f)
				{
					string newPath = null;
					Graphic snowyGraphic;

					SnowyPlantDef candidatePlant = DefDatabase<SnowyPlantDef>.GetNamed(__instance.def.defName, false);

					if (candidatePlant != null)
					{
						// If the tree is currently leafless and a leafless graphic exists
						if (__instance.LeaflessNow && __instance.def.plant.leaflessGraphic != null)
						{
							// (nested if prevents Jesus trees: leafless trees getting the wrong graphic because a leafless snowy texture doesn't exist):
							if (candidatePlant.LeaflessSnowyPath != null)
							{
								newPath = candidatePlant.LeaflessSnowyPath;
							}
						}
						// else, if immature variant and supported:
						else if (__result.path.ToLowerInvariant().Contains("immature")
							&& (candidatePlant.ImmatureSnowyPath != null))
						{
							newPath = candidatePlant.ImmatureSnowyPath;
						}
						// Otherwise we show the snowy default / mature variant if it is supported.
						else if (candidatePlant.RegularSnowyPath != null)
						{
							newPath = candidatePlant.RegularSnowyPath;
						}

						//If the texture has something to replace
						if (newPath != null)
						{
							snowyGraphic = GraphicDatabase.Get<Graphic_Random>(newPath, __result.Shader, __result.drawSize, __result.Color, __result.ColorTwo, __result.data);

							__result = snowyGraphic;
						}
					}
				}
			}
		}
	}
}