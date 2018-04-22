using System.Collections.Generic;

namespace Nandonalt_SnowyTrees
{
	public static class PlantGraphicSupportDefinitions
	{
		/// <summary>
		/// All plant defs from the core game, searched for index to be used in the boolean arrays below
		/// </summary>
		public static readonly List<string> plantList = new List<string>
		{
			"Agarilux",
			"Bryolux",
			"BurnedTree",
			"Glowstool",
			"PlantAgave",
			"PlantAlocasia",
			"PlantAmbrosia",
			"PlantAstragalus",
			"PlantBrambles",
			"PlantBush",
			"PlantChokevine",
			"PlantClivia",
			"PlantCorn",
			"PlantCotton",
			"PlantDandelion",
			"PlantDaylily",
			"PlantDevilstrand",
			"PlantGrass",
			"PlantHaygrass",
			"PlantHealroot",
			"PlantHops",
			"PlantMoss",
			"PlantPincushionCactus",
			"PlantPotato",
			"PlantPsychoid",
			"PlantRafflesia",
			"PlantRaspberry",
			"PlantRice",
			"PlantRose",
			"PlantSaguaroCactus",
			"PlantShrubLow",
			"PlantSmokeleaf",
			"PlantStrawberry",
			"PlantTallGrass",
			"PlantTreeBamboo",
			"PlantTreeBirch",
			"PlantTreeCecropia",
			"PlantTreeCypress",
			"PlantTreeDrago",
			"PlantTreeMaple",
			"PlantTreeOak",
			"PlantTreePalm",
			"PlantTreePine",
			"PlantTreePoplar",
			"PlantTreeTeak",
			"PlantTreeWillow",
			"PlantWildHealroot"
		};

		/// <summary>
		/// Plant definition names which have graphics for snowy state.
		/// Textures located in Textures located in "Textures\Things\Plant_Snowy" folder.
		/// /// Internal structure is the same as for basic textures.
		/// </summary>
		public static readonly List<bool> SnowyPlants = new List<bool>
		{
			false,	//Agarilux
			false,	//Bryolux
			false,	//BurnedTree
			false,	//Glowstool
			true,	//PlantAgave
			false,	//PlantAlocasia
			false,	//PlantAmbrosia
			false,	//PlantAstragalus
			false,	//PlantBrambles
			true,	//PlantBush
			false,	//PlantChokevine
			false,	//PlantClivia
			false,	//PlantCorn
			false,	//PlantCotton
			false,	//PlantDandelion
			false,	//PlantDaylily
			false,	//PlantDevilstrand
			false,	//PlantGrass
			false,	//PlantHaygrass
			false,	//PlantHealroot
			false,	//PlantHops
			false,	//PlantMoss
			false,	//PlantPincushionCactus
			false,	//PlantPotato
			false,	//PlantPsychoid
			false,	//PlantRafflesia
			true,	//PlantRaspberry
			false,	//PlantRice
			false,	//PlantRose
			false,	//PlantSaguaroCactus
			false,	//PlantShrubLow
			false,	//PlantSmokeleaf
			false,	//PlantStrawberry
			false,	//PlantTallGrass
			false,	//PlantTreeBamboo
			true,	//PlantTreeBirch
			true,	//PlantTreeCecropia
			false,	//PlantTreeCypress
			false,	//PlantTreeDrago
			false,	//PlantTreeMaple
			true,	//PlantTreeOak
			false,	//PlantTreePalm
			true,	//PlantTreePine
			true,	//PlantTreePoplar
			true,	//PlantTreeTeak
			true,	//PlantTreeWillow
			false,	//PlantWildHealroot
		};

		/// <summary>
		/// Plant definition names which have graphics for immature state.
		/// Textures located in Textures located in "Textures\Things\Plant_Snowy_Immature" folder.
		/// /// Internal structure is the same as for basic textures.
		/// </summary>
		public static readonly List<bool> ImmatureSnowyPlants = new List<bool>
		{
			false,	//Agarilux
			false,	//Bryolux
			false,	//BurnedTree
			false,	//Glowstool
			false,	//PlantAgave
			false,	//PlantAlocasia
			false,	//PlantAmbrosia
			false,	//PlantAstragalus
			false,	//PlantBrambles
			false,	//PlantBush
			false,	//PlantChokevine
			false,	//PlantClivia
			false,	//PlantCorn
			false,	//PlantCotton
			false,	//PlantDandelion
			false,	//PlantDaylily
			false,	//PlantDevilstrand
			false,	//PlantGrass
			false,	//PlantHaygrass
			false,	//PlantHealroot
			false,	//PlantHops
			false,	//PlantMoss
			false,	//PlantPincushionCactus
			false,	//PlantPotato
			false,	//PlantPsychoid
			false,	//PlantRafflesia
			true,	//PlantRaspberry
			false,	//PlantRice
			false,	//PlantRose
			false,	//PlantSaguaroCactus
			false,	//PlantShrubLow
			false,	//PlantSmokeleaf
			false,	//PlantStrawberry
			false,	//PlantTallGrass
			false,	//PlantTreeBamboo
			false,	//PlantTreeBirch
			false,	//PlantTreeCecropia
			false,	//PlantTreeCypress
			false,	//PlantTreeDrago
			false,	//PlantTreeMaple
			false,	//PlantTreeOak
			false,	//PlantTreePalm
			false,	//PlantTreePine
			false,	//PlantTreePoplar
			false,	//PlantTreeTeak
			false,	//PlantTreeWillow
			false,	//PlantWildHealroot
		};

		/// <summary>
		/// Plant definition names which have graphics for leafless state.
		/// Textures located in Textures located in "Textures\Things\Plant_Snowy_Leafless" folder.
		/// /// Internal structure is the same as for basic textures.
		/// </summary>
		public static readonly List<bool> LeaflessSnowyPlants = new List<bool>
		{
			false,	//Agarilux
			false,	//Bryolux
			false,	//BurnedTree
			false,	//Glowstool
			false,	//PlantAgave
			false,	//PlantAlocasia	                                                                                                                                                                                                                                                                                                         
			false,	//PlantAmbrosia
			false,	//PlantAstragalus
			false,	//PlantBrambles
			true,	//PlantBush
			false,	//PlantChokevine
			false,	//PlantClivia
			false,	//PlantCorn
			false,	//PlantCotton
			false,	//PlantDandelion
			false,	//PlantDaylily
			false,	//PlantDevilstrand
			false,	//PlantGrass
			false,	//PlantHaygrass
			false,	//PlantHealroot
			false,	//PlantHops
			false,	//PlantMoss
			false,	//PlantPincushionCactus
			false,	//PlantPotato
			false,	//PlantPsychoid
			false,	//PlantRafflesia
			false,	//PlantRaspberry
			false,	//PlantRice
			false,	//PlantRose
			false,	//PlantSaguaroCactus
			false,	//PlantShrubLow
			false,	//PlantSmokeleaf
			false,	//PlantStrawberry
			false,	//PlantTallGrass
			false,	//PlantTreeBamboo
			true,	//PlantTreeBirch
			false,	//PlantTreeCecropia
			true,	//PlantTreeCypress
			false,	//PlantTreeDrago
			true,	//PlantTreeMaple
			true,	//PlantTreeOak
			false,	//PlantTreePalm
			false,	//PlantTreePine
			true,	//PlantTreePoplar
			false,	//PlantTreeTeak
			true,	//PlantTreeWillow
			false,	//PlantWildHealroot
		};
	}
}

#region a17: string comp version
/*
	/// <summary>
	/// Definitions for what textures are supported for which plants.
	/// Basic texture is needed to even enter the logic for picking a new texture.
	/// Textures have been sepparated due to issues with the game engine understanding all textures in the same folder
	/// as alternatives instead of textures for different states. Even if following vanilla folder structure, leafless 
	/// textures cause issues loading other textures for the same plant even without any logic or added definitions.
	/// 
	/// TODO:
	/// Should probably look into defining these through xml files instead.
	/// </summary>
	public static class PlantGraphicSupportDefinitions
	{
		/// <summary>
		/// Planet definition names which have basic graphics support.
		/// Textures located in "Textures\Things\Plant_Snowy" folder.
		/// </summary>
		public static readonly List<string> SnowyPlantsNormal = new List<string>(new string[]
		{
			"PlantRaspberry",
			"PlantBush",
			"PlantTreeOak",
			"PlantTreePoplar",
			"PlantTreePine",
			"PlantTreeBirch",
			"PlantTreeTeak",
			"PlantTreeCecropia"
		});

		/// <summary>
		/// Planet definition names which have graphics for immature state.
		/// Textures located in "Textures\Things\Plant_Snowy_Immature" folder.
		/// /// Internal structure is the same as for basic textures.
		/// </summary>
		public static readonly List<string> SnowyPlantsImmature = new List<string>(new string[]
		{
			"PlantRaspberry",
		});

		/// <summary>
		/// Plant definition names which have graphics for leafless state.
		/// Textures located in "Textures\Things\Plant_Snowy_Leafless" folder.
		/// Internal structure is the same as for basic textures.
		/// </summary>
		public static readonly List<string> SnowyPlantsLeafless = new List<string>(new string[]
		{
			"PlantBush",
		});
	}
}*/
#endregion