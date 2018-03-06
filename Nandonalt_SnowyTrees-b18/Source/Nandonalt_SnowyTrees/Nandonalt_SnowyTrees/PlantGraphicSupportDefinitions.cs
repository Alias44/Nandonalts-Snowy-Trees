using System.Collections.Generic;

namespace Nandonalt_SnowyTrees
{
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
}
