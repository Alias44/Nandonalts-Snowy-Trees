using System;
using System.Reflection;
using Harmony;
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
			HarmonyInstance harmony = HarmonyInstance.Create("Nandonalt_SnowyTrees.main");
			harmony.Patch(AccessTools.Method(typeof(Plant), "get_Graphic"), null, new HarmonyMethod(patchType, nameof(SnowyGraphic)));

			harmony.PatchAll(Assembly.GetExecutingAssembly());
		}

		[HarmonyPostfix]
		public static void SnowyGraphic (Plant __instance, ref Graphic __result)
		{
			if (PlantGraphicSupportDefinitions.SnowyPlantsNormal.Contains(__instance.def.defName)
				&& (!(__instance.def.plant.leaflessGraphic != null && __instance.LeaflessNow) || PlantGraphicSupportDefinitions.SnowyPlantsLeafless.Contains(__instance.def.defName))
				&& !(__instance.LifeStage == PlantLifeStage.Sowing)
				)
			{
				// Switch graphic to snowy variant:
				if (__instance.Map.snowGrid.GetDepth(__instance.Position) >= 0.5f)
				{
					ThingDef parentDef = __instance.def;
					string newPath = null;
					Graphic snowyGraphic;

					// If supporting leafless graphic:
					if (__instance.LeaflessNow && PlantGraphicSupportDefinitions.SnowyPlantsLeafless.Contains(__instance.def.defName))
					{
						newPath = parentDef.graphicData.texPath.Replace("Things/Plant/", "Things/Plant_Snowy_Leafless/");
					}
					// else, if immature variant and supported:
					else if (__result.path.ToLowerInvariant().Contains("immature")
						&& PlantGraphicSupportDefinitions.SnowyPlantsImmature.Contains(__instance.def.defName)
						)
					{
						newPath = parentDef.graphicData.texPath.Replace("Things/Plant/", "Things/Plant_Snowy_Immature/");
					}
					// Otherwise we show the snowy default / mature variant.
					else
					{
						newPath = parentDef.graphicData.texPath.Replace("Things/Plant/", "Things/Plant_Snowy/");
					}

					snowyGraphic = GraphicDatabase.Get<Graphic_Random>(newPath, __result.Shader, __result.drawSize, __result.Color, __result.ColorTwo, __result.data);

					__result = snowyGraphic;
				}
			}
		}

		#region A16: HugsLib detour:
		/*using HugsLib.Source.Detour;

		[StaticConstructorOnStartup]
		public class PlantTree : Plant
		{
			private static Graphic GraphicSowing = GraphicDatabase.Get<Graphic_Single>("Things/Plant/Plant_Sowing", ShaderDatabase.Cutout, Vector2.one, Color.white);

			[DetourProperty(typeof(Plant), "Graphic", DetourProperty.Getter)]
			public override Graphic Graphic
			{
				get
				{
					if (this.LifeStage == PlantLifeStage.Sowing)
					{
						return GraphicSowing;
					}
					if (this.def.plant.leaflessGraphic != null && this.LeaflessNow)
					{
						return this.def.plant.leaflessGraphic;
					}
					if (TreeInjector.alteredPlants.Contains(this.def.defName))
						{
						if (this.Map.snowGrid.GetDepth(this.Position) >= 0.5f)
						{
							ThingDef parentDef = this.def;
							Graphic Snowy = GraphicDatabase.Get(parentDef.graphicData.graphicClass, parentDef.graphicData.texPath + "_Snowy", parentDef.graphic.Shader, parentDef.graphicData.drawSize, parentDef.graphicData.color, parentDef.graphicData.colorTwo);
							return Snowy;
						}
					}
					return this.def.graphicData.GraphicColoredFor(this);
				}
			}
		}*/
		#endregion
	}
}

