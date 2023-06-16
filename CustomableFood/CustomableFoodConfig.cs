using System;
using Newtonsoft.Json;
using PeterHan.PLib.Options;

namespace SonJeremy.CustomableFood
{

    [Serializable]
    [RestartRequired]
    [ConfigFile(SharedConfigLocation: true)]
    public class CustomableFoodConfig : SingletonOptions<CustomableFoodConfig>
    {
        #region TravelTubeEntrance

        [Option("Enable Custom Travel Tube Entrance", "", "Travel Tube Entrance")]
        [JsonProperty]
        public bool TravelTubeEntranceOverride { get; set; } = true;

        [Option("Transit TubeJoule Capacity", "", "Travel Tube Entrance")]
        [JsonProperty]
        public float TransitTubeJouleCapacityOverride { get; set; } = 5000f;

        [Option("Transit Tube Joules Per Launch", "", "Travel Tube Entrance")]
        [JsonProperty]
        public float TransitTubeJoulesPerLaunchOverride { get; set; } = 100000f;

        #endregion


        #region FieldRation

        [Option("Enable Custom Nutrient Bar", "", "Nutrient Bar")]
        [JsonProperty]
        public bool FieldRationOverride { get; set; }

        [Option("Calories Per Unit", "", "Nutrient Bar")]
        [JsonProperty]
        public int FieldRationCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Nutrient Bar")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float FieldRationPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Nutrient Bar")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float FieldRationRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Nutrient Bar")]
        [Limit(1, 100)]
        [JsonProperty]
        public int FieldRationSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Nutrient Bar")]
        [JsonProperty]
        public bool FieldRationCanRotOverride { get; set; }

        #endregion


        #region MushBar

        [Option("Enable Custom Mush Bar", "", "Mush Bar")]
        [JsonProperty]
        public bool MushBarOverride { get; set; }

        [Option("Calories Per Unit", "", "Mush Bar")]
        [JsonProperty]
        public int MushBarCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Mush Bar")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float MushBarPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Mush Bar")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float MushBarRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Mush Bar")]
        [Limit(1, 100)]
        [JsonProperty]
        public int MushBarSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Mush Bar")]
        [JsonProperty]
        public bool MushBarCanRotOverride { get; set; }

        #endregion


        #region BasicPlantFood

        [Option("Enable Custom Meal Lice", "", "Meal Lice")]
        [JsonProperty]
        public bool BasicPlantFoodOverride { get; set; }

        [Option("Calories Per Unit", "", "Meal Lice")]
        [JsonProperty]
        public int BasicPlantFoodCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Meal Lice")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float BasicPlantFoodPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Meal Lice")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float BasicPlantFoodRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Meal Lice")]
        [Limit(1, 100)]
        [JsonProperty]
        public int BasicPlantFoodSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Meal Lice")]
        [JsonProperty]
        public bool BasicPlantFoodCanRotOverride { get; set; }

        #endregion


        #region BasicForagePlant

        [Option("Enable Custom Muckroot", "", "Muckroot")]
        [JsonProperty]
        public bool BasicForagePlantOverride { get; set; }

        [Option("Calories Per Unit", "", "Muckroot")]
        [JsonProperty]
        public int BasicForagePlantCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Muckroot")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float BasicForagePlantPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Muckroot")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float BasicForagePlantRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Muckroot")]
        [Limit(1, 100)]
        [JsonProperty]
        public int BasicForagePlantSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Muckroot")]
        [JsonProperty]
        public bool BasicForagePlantCanRotOverride { get; set; }

        #endregion


        #region ForestForagePlant

        [Option("Enable Custom Hexalent Fruit", "", "Hexalent Fruit")]
        [JsonProperty]
        public bool ForestForagePlantOverride { get; set; }

        [Option("Calories Per Unit", "", "Hexalent Fruit")]
        [JsonProperty]
        public int ForestForagePlantCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Hexalent Fruit")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float ForestForagePlantPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Hexalent Fruit")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float ForestForagePlantRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Hexalent Fruit")]
        [Limit(1, 100)]
        [JsonProperty]
        public int ForestForagePlantSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Hexalent Fruit")]
        [JsonProperty]
        public bool ForestForagePlantCanRotOverride { get; set; }

        #endregion


        #region SwampForagePlant

        [Option("Enable Custom Swamp Chard Heart", "", "Swamp Chard Heart")]
        [JsonProperty]
        public bool SwampForagePlantOverride { get; set; }

        [Option("Calories Per Unit", "", "Swamp Chard Heart")]
        [JsonProperty]
        public int SwampForagePlantCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Swamp Chard Heart")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float SwampForagePlantPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Swamp Chard Heart")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float SwampForagePlantRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Swamp Chard Heart")]
        [Limit(1, 100)]
        [JsonProperty]
        public int SwampForagePlantSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Swamp Chard Heart")]
        [JsonProperty]
        public bool SwampForagePlantCanRotOverride { get; set; }

        #endregion


        #region Mushroom

        [Option("Enable Custom Mushroom", "", "Mushroom")]
        [JsonProperty]
        public bool MushroomOverride { get; set; }

        [Option("Calories Per Unit", "", "Mushroom")]
        [JsonProperty]
        public int MushroomCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Mushroom")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float MushroomPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Mushroom")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float MushroomRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Mushroom")]
        [Limit(1, 100)]
        [JsonProperty]
        public int MushroomSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Mushroom")]
        [JsonProperty]
        public bool MushroomCanRotOverride { get; set; }

        #endregion


        #region Lettuce

        [Option("Enable Custom Lettuce", "", "Lettuce")]
        [JsonProperty]
        public bool LettuceOverride { get; set; }

        [Option("Calories Per Unit", "", "Lettuce")]
        [JsonProperty]
        public int LettuceCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Lettuce")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float LettucePreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Lettuce")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float LettuceRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Lettuce")]
        [Limit(1, 100)]
        [JsonProperty]
        public int LettuceSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Lettuce")]
        [JsonProperty]
        public bool LettuceCanRotOverride { get; set; }

        #endregion


        #region Meat

        [Option("Enable Custom Meat", "", "Meat")]
        [JsonProperty]
        public bool MeatOverride { get; set; }

        [Option("Calories Per Unit", "", "Meat")]
        [JsonProperty]
        public int MeatCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Meat")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float MeatPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Meat")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float MeatRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Meat")]
        [Limit(1, 100)]
        [JsonProperty]
        public int MeatSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Meat")]
        [JsonProperty]
        public bool MeatCanRotOverride { get; set; }

        #endregion


        #region PlantMeat

        [Option("Enable Custom Plant Meat", "", "Plant Meat")]
        [JsonProperty]
        public bool PlantMeatOverride { get; set; }

        [Option("Calories Per Unit", "", "Plant Meat")]
        [JsonProperty]
        public int PlantMeatCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Plant Meat")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float PlantMeatPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Plant Meat")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float PlantMeatRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Plant Meat")]
        [Limit(1, 100)]
        [JsonProperty]
        public int PlantMeatSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Plant Meat")]
        [JsonProperty]
        public bool PlantMeatCanRotOverride { get; set; }

        #endregion


        #region PrickleFruit

        [Option("Enable Custom Bristle Berry", "", "Bristle Berry")]
        [JsonProperty]
        public bool PrickleFruitOverride { get; set; }

        [Option("Calories Per Unit", "", "Bristle Berry")]
        [JsonProperty]
        public int PrickleFruitCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Bristle Berry")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float PrickleFruitPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Bristle Berry")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float PrickleFruitRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Bristle Berry")]
        [Limit(1, 100)]
        [JsonProperty]
        public int PrickleFruitSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Bristle Berry")]
        [JsonProperty]
        public bool PrickleFruitCanRotOverride { get; set; }

        #endregion


        #region SwampFruit

        [Option("Enable Custom Bog Jelly", "", "Bog Jelly")]
        [JsonProperty]
        public bool SwampFruitOverride { get; set; }

        [Option("Calories Per Unit", "", "Bog Jelly")]
        [JsonProperty]
        public int SwampFruitCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Bog Jelly")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float SwampFruitPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Bog Jelly")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float SwampFruitRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Bog Jelly")]
        [Limit(1, 100)]
        [JsonProperty]
        public int SwampFruitSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Bog Jelly")]
        [JsonProperty]
        public bool SwampFruitCanRotOverride { get; set; }

        #endregion


        #region FishMeat

        [Option("Enable Custom Pacu Fillet", "", "Pacu Fillet")]
        [JsonProperty]
        public bool FishMeatOverride { get; set; }

        [Option("Calories Per Unit", "", "Pacu Fillet")]
        [JsonProperty]
        public int FishMeatCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Pacu Fillet")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float FishMeatPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Pacu Fillet")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float FishMeatRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Pacu Fillet")]
        [Limit(1, 100)]
        [JsonProperty]
        public int FishMeatSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Pacu Fillet")]
        [JsonProperty]
        public bool FishMeatCanRotOverride { get; set; }

        #endregion


        #region ShellfishMeat

        [Option("Enable Custom Raw Shellfish", "", "Raw Shellfish")]
        [JsonProperty]
        public bool ShellfishMeatOverride { get; set; }

        [Option("Calories Per Unit", "", "Raw Shellfish")]
        [JsonProperty]
        public int ShellfishMeatCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Raw Shellfish")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float ShellfishMeatPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Raw Shellfish")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float ShellfishMeatRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Raw Shellfish")]
        [Limit(1, 100)]
        [JsonProperty]
        public int ShellfishMeatSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Raw Shellfish")]
        [JsonProperty]
        public bool ShellfishMeatCanRotOverride { get; set; }

        #endregion


        #region WormBasicFruit

        [Option("Enable Custom Spindly Grubfruit", "", "Spindly Grubfruit")]
        [JsonProperty]
        public bool WormBasicFruitOverride { get; set; }

        [Option("Calories Per Unit", "", "Spindly Grubfruit")]
        [JsonProperty]
        public int WormBasicFruitCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Spindly Grubfruit")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float WormBasicFruitPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Spindly Grubfruit")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float WormBasicFruitRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Spindly Grubfruit")]
        [Limit(1, 100)]
        [JsonProperty]
        public int WormBasicFruitSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Spindly Grubfruit")]
        [JsonProperty]
        public bool WormBasicFruitCanRotOverride { get; set; }

        #endregion


        #region WormSuperFruit

        [Option("Enable Custom Grubfruit", "", "Grubfruit")]
        [JsonProperty]
        public bool WormSuperFruitOverride { get; set; }

        [Option("Calories Per Unit", "", "Grubfruit")]
        [JsonProperty]
        public int WormSuperFruitCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Grubfruit")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float WormSuperFruitPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Grubfruit")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float WormSuperFruitRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Grubfruit")]
        [Limit(1, 100)]
        [JsonProperty]
        public int WormSuperFruitSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Grubfruit")]
        [JsonProperty]
        public bool WormSuperFruitCanRotOverride { get; set; }

        #endregion


        #region PickledMeal

        [Option("Enable Custom Pickled Meal", "", "Pickled Meal")]
        [JsonProperty]
        public bool PickledMealOverride { get; set; }

        [Option("Calories Per Unit", "", "Pickled Meal")]
        [JsonProperty]
        public int PickledMealCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Pickled Meal")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float PickledMealPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Pickled Meal")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float PickledMealRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Pickled Meal")]
        [Limit(1, 100)]
        [JsonProperty]
        public int PickledMealSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Pickled Meal")]
        [JsonProperty]
        public bool PickledMealCanRotOverride { get; set; }

        #endregion


        #region BasicPlantBar

        [Option("Enable Custom Liceloaf", "", "Liceloaf")]
        [JsonProperty]
        public bool BasicPlantBarOverride { get; set; }

        [Option("Calories Per Unit", "", "Liceloaf")]
        [JsonProperty]
        public int BasicPlantBarCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Liceloaf")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float BasicPlantBarPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Liceloaf")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float BasicPlantBarRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Liceloaf")]
        [Limit(1, 100)]
        [JsonProperty]
        public int BasicPlantBarSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Liceloaf")]
        [JsonProperty]
        public bool BasicPlantBarCanRotOverride { get; set; }

        #endregion


        #region FriedMushBar

        [Option("Enable Custom Mush Fry", "", "Mush Fry")]
        [JsonProperty]
        public bool FriedMushBarOverride { get; set; }

        [Option("Calories Per Unit", "", "Mush Fry")]
        [JsonProperty]
        public int FriedMushBarCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Mush Fry")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float FriedMushBarPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Mush Fry")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float FriedMushBarRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Mush Fry")]
        [Limit(1, 100)]
        [JsonProperty]
        public int FriedMushBarSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Mush Fry")]
        [JsonProperty]
        public bool FriedMushBarCanRotOverride { get; set; }

        #endregion


        #region GammaMush

        [Option("Enable Custom Gamma Mush", "", "Gamma Mush")]
        [JsonProperty]
        public bool GammaMushOverride { get; set; }

        [Option("Calories Per Unit", "", "Gamma Mush")]
        [JsonProperty]
        public int GammaMushCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Gamma Mush")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float GammaMushPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Gamma Mush")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float GammaMushRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Gamma Mush")]
        [Limit(1, 100)]
        [JsonProperty]
        public int GammaMushSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Gamma Mush")]
        [JsonProperty]
        public bool GammaMushCanRotOverride { get; set; }

        #endregion


        #region GrilledPrickleFruit

        [Option("Enable Custom Gristle Berry", "", "Gristle Berry")]
        [JsonProperty]
        public bool GrilledPrickleFruitOverride { get; set; }

        [Option("Calories Per Unit", "", "Gristle Berry")]
        [JsonProperty]
        public int GrilledPrickleFruitCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Gristle Berry")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float GrilledPrickleFruitPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Gristle Berry")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float GrilledPrickleFruitRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Gristle Berry")]
        [Limit(1, 100)]
        [JsonProperty]
        public int GrilledPrickleFruitSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Gristle Berry")]
        [JsonProperty]
        public bool GrilledPrickleFruitCanRotOverride { get; set; }

        #endregion


        #region SwampDelights

        [Option("Enable Custom Swampy Delights", "", "Swampy Delights")]
        [JsonProperty]
        public bool SwampDelightsOverride { get; set; }

        [Option("Calories Per Unit", "", "Swampy Delights")]
        [JsonProperty]
        public int SwampDelightsCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Swampy Delights")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float SwampDelightsPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Swampy Delights")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float SwampDelightsRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Swampy Delights")]
        [Limit(1, 100)]
        [JsonProperty]
        public int SwampDelightsSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Swampy Delights")]
        [JsonProperty]
        public bool SwampDelightsCanRotOverride { get; set; }

        #endregion


        #region FriedMushroom

        [Option("Enable Custom Fried Mushroom", "", "Fried Mushroom")]
        [JsonProperty]
        public bool FriedMushroomOverride { get; set; }

        [Option("Calories Per Unit", "", "Fried Mushroom")]
        [JsonProperty]
        public int FriedMushroomCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Fried Mushroom")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float FriedMushroomPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Fried Mushroom")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float FriedMushroomRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Fried Mushroom")]
        [Limit(1, 100)]
        [JsonProperty]
        public int FriedMushroomSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Fried Mushroom")]
        [JsonProperty]
        public bool FriedMushroomCanRotOverride { get; set; }

        #endregion


        #region ColdWheatBread

        [Option("Enable Custom Frost Bun", "", "Frost Bun")]
        [JsonProperty]
        public bool ColdWheatBreadOverride { get; set; }

        [Option("Calories Per Unit", "", "Frost Bun")]
        [JsonProperty]
        public int ColdWheatBreadCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Frost Bun")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float ColdWheatBreadPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Frost Bun")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float ColdWheatBreadRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Frost Bun")]
        [Limit(1, 100)]
        [JsonProperty]
        public int ColdWheatBreadSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Frost Bun")]
        [JsonProperty]
        public bool ColdWheatBreadCanRotOverride { get; set; }

        #endregion


        #region CookedEgg

        [Option("Enable Custom Omelette", "", "Omelette")]
        [JsonProperty]
        public bool CookedEggOverride { get; set; }

        [Option("Calories Per Unit", "", "Omelette")]
        [JsonProperty]
        public int CookedEggCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Omelette")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float CookedEggPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Omelette")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float CookedEggRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Omelette")]
        [Limit(1, 100)]
        [JsonProperty]
        public int CookedEggSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Omelette")]
        [JsonProperty]
        public bool CookedEggCanRotOverride { get; set; }

        #endregion


        #region CookedFish

        [Option("Enable Custom Cooked Seafood", "", "Cooked Seafood")]
        [JsonProperty]
        public bool CookedFishOverride { get; set; }

        [Option("Calories Per Unit", "", "Cooked Seafood")]
        [JsonProperty]
        public int CookedFishCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Cooked Seafood")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float CookedFishPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Cooked Seafood")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float CookedFishRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Cooked Seafood")]
        [Limit(1, 100)]
        [JsonProperty]
        public int CookedFishSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Cooked Seafood")]
        [JsonProperty]
        public bool CookedFishCanRotOverride { get; set; }

        #endregion


        #region CookedMeat

        [Option("Enable Custom Barbeque", "", "Barbeque")]
        [JsonProperty]
        public bool CookedMeatOverride { get; set; }

        [Option("Calories Per Unit", "", "Barbeque")]
        [JsonProperty]
        public int CookedMeatCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Barbeque")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float CookedMeatPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Barbeque")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float CookedMeatRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Barbeque")]
        [Limit(1, 100)]
        [JsonProperty]
        public int CookedMeatSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Barbeque")]
        [JsonProperty]
        public bool CookedMeatCanRotOverride { get; set; }

        #endregion


        #region WormBasicFood

        [Option("Enable Custom Roast Grubfruit Nut", "", "Roast Grubfruit Nut")]
        [JsonProperty]
        public bool WormBasicFoodOverride { get; set; }

        [Option("Calories Per Unit", "", "Roast Grubfruit Nut")]
        [JsonProperty]
        public int WormBasicFoodCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Roast Grubfruit Nut")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float WormBasicFoodPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Roast Grubfruit Nut")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float WormBasicFoodRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Roast Grubfruit Nut")]
        [Limit(1, 100)]
        [JsonProperty]
        public int WormBasicFoodSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Roast Grubfruit Nut")]
        [JsonProperty]
        public bool WormBasicFoodCanRotOverride { get; set; }

        #endregion


        #region WormSuperFood

        [Option("Enable Custom Grubfruit Preserve", "", "Grubfruit Preserve")]
        [JsonProperty]
        public bool WormSuperFoodOverride { get; set; }

        [Option("Calories Per Unit", "", "Grubfruit Preserve")]
        [JsonProperty]
        public int WormSuperFoodCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Grubfruit Preserve")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float WormSuperFoodPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Grubfruit Preserve")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float WormSuperFoodRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Grubfruit Preserve")]
        [Limit(1, 100)]
        [JsonProperty]
        public int WormSuperFoodSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Grubfruit Preserve")]
        [JsonProperty]
        public bool WormSuperFoodCanRotOverride { get; set; }

        #endregion


        #region FruitCake

        [Option("Enable Custom Berry Sludge", "", "Berry Sludge")]
        [JsonProperty]
        public bool FruitCakeOverride { get; set; }

        [Option("Calories Per Unit", "", "Berry Sludge")]
        [JsonProperty]
        public int FruitCakeCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Berry Sludge")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float FruitCakePreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Berry Sludge")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float FruitCakeRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Berry Sludge")]
        [Limit(1, 100)]
        [JsonProperty]
        public int FruitCakeSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Berry Sludge")]
        [JsonProperty]
        public bool FruitCakeCanRotOverride { get; set; }

        #endregion


        #region Salsa

        [Option("Enable Custom Stuffed Berry", "", "Stuffed Berry")]
        [JsonProperty]
        public bool SalsaOverride { get; set; }

        [Option("Calories Per Unit", "", "Stuffed Berry")]
        [JsonProperty]
        public int SalsaCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Stuffed Berry")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float SalsaPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Stuffed Berry")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float SalsaRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Stuffed Berry")]
        [Limit(1, 100)]
        [JsonProperty]
        public int SalsaSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Stuffed Berry")]
        [JsonProperty]
        public bool SalsaCanRotOverride { get; set; }

        #endregion


        #region SurfAndTurf

        [Option("Enable Custom Surf'n'Turf", "", "Surf'n'Turf")]
        [JsonProperty]
        public bool SurfAndTurfOverride { get; set; }

        [Option("Calories Per Unit", "", "Surf'n'Turf")]
        [JsonProperty]
        public int SurfAndTurfCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Surf'n'Turf")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float SurfAndTurfPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Surf'n'Turf")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float SurfAndTurfRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Surf'n'Turf")]
        [Limit(1, 100)]
        [JsonProperty]
        public int SurfAndTurfSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Surf'n'Turf")]
        [JsonProperty]
        public bool SurfAndTurfCanRotOverride { get; set; }

        #endregion


        #region MushroomWrap

        [Option("Enable Custom Mushroom Wrap", "", "Mushroom Wrap")]
        [JsonProperty]
        public bool MushroomWrapOverride { get; set; }

        [Option("Calories Per Unit", "", "Mushroom Wrap")]
        [JsonProperty]
        public int MushroomWrapCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Mushroom Wrap")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float MushroomWrapPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Mushroom Wrap")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float MushroomWrapRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Mushroom Wrap")]
        [Limit(1, 100)]
        [JsonProperty]
        public int MushroomWrapSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Mushroom Wrap")]
        [JsonProperty]
        public bool MushroomWrapCanRotOverride { get; set; }

        #endregion


        #region Tofu

        [Option("Enable Custom Tofu", "", "Tofu")]
        [JsonProperty]
        public bool TofuOverride { get; set; }

        [Option("Calories Per Unit", "", "Tofu")]
        [JsonProperty]
        public int TofuCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Tofu")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float TofuPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Tofu")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float TofuRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Tofu")]
        [Limit(1, 100)]
        [JsonProperty]
        public int TofuSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Tofu")]
        [JsonProperty]
        public bool TofuCanRotOverride { get; set; }

        #endregion


        #region SpiceBread

        [Option("Enable Custom Pepper Bread", "", "Pepper Bread")]
        [JsonProperty]
        public bool SpiceBreadOverride { get; set; }

        [Option("Calories Per Unit", "", "Pepper Bread")]
        [JsonProperty]
        public int SpiceBreadCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Pepper Bread")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float SpiceBreadPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Pepper Bread")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float SpiceBreadRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Pepper Bread")]
        [Limit(1, 100)]
        [JsonProperty]
        public int SpiceBreadSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Pepper Bread")]
        [JsonProperty]
        public bool SpiceBreadCanRotOverride { get; set; }

        #endregion


        #region SpicyTofu

        [Option("Enable Custom Spicy Tofu", "", "Spicy Tofu")]
        [JsonProperty]
        public bool SpicyTofuOverride { get; set; }

        [Option("Calories Per Unit", "", "Spicy Tofu")]
        [JsonProperty]
        public int SpicyTofuCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Spicy Tofu")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float SpicyTofuPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Spicy Tofu")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float SpicyTofuRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Spicy Tofu")]
        [Limit(1, 100)]
        [JsonProperty]
        public int SpicyTofuSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Spicy Tofu")]
        [JsonProperty]
        public bool SpicyTofuCanRotOverride { get; set; }

        #endregion


        #region Curry

        [Option("Enable Custom Curried Beans", "", "Curried Beans")]
        [JsonProperty]
        public bool CurryOverride { get; set; }

        [Option("Calories Per Unit", "", "Curried Beans")]
        [JsonProperty]
        public int CurryCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Curried Beans")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float CurryPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Curried Beans")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float CurryRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Curried Beans")]
        [Limit(1, 100)]
        [JsonProperty]
        public int CurrySpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Curried Beans")]
        [JsonProperty]
        public bool CurryCanRotOverride { get; set; }

        #endregion


        #region BerryPie

        [Option("Enable Custom Mixed Berry Pie", "", "Mixed Berry Pie")]
        [JsonProperty]
        public bool BerryPieOverride { get; set; }

        [Option("Calories Per Unit", "", "Mixed Berry Pie")]
        [JsonProperty]
        public int BerryPieCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Mixed Berry Pie")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float BerryPiePreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Mixed Berry Pie")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float BerryPieRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Mixed Berry Pie")]
        [Limit(1, 100)]
        [JsonProperty]
        public int BerryPieSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Mixed Berry Pie")]
        [JsonProperty]
        public bool BerryPieCanRotOverride { get; set; }

        #endregion


        #region Burger

        [Option("Enable Custom Frost Burger", "", "Frost Burger")]
        [JsonProperty]
        public bool BurgerOverride { get; set; }

        [Option("Calories Per Unit", "", "Frost Burger")]
        [JsonProperty]
        public int BurgerCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Frost Burger")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float BurgerPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Frost Burger")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float BurgerRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Frost Burger")]
        [Limit(1, 100)]
        [JsonProperty]
        public int BurgerSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Frost Burger")]
        [JsonProperty]
        public bool BurgerCanRotOverride { get; set; }

        #endregion


        #region BeanPlantSeed

        [Option("Enable Custom Nosh Bean", "", "Nosh Bean")]
        [JsonProperty]
        public bool BeanPlantSeedOverride { get; set; }

        [Option("Calories Per Unit", "", "Nosh Bean")]
        [JsonProperty]
        public int BeanPlantSeedCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Nosh Bean")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float BeanPlantSeedPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Nosh Bean")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float BeanPlantSeedRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Nosh Bean")]
        [Limit(1, 100)]
        [JsonProperty]
        public int BeanPlantSeedSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Nosh Bean")]
        [JsonProperty]
        public bool BeanPlantSeedCanRotOverride { get; set; }

        #endregion


        #region SpiceNut

        [Option("Enable Custom Pincha Peppernut", "", "Pincha Peppernut")]
        [JsonProperty]
        public bool SpiceNutOverride { get; set; }

        [Option("Calories Per Unit", "", "Pincha Peppernut")]
        [JsonProperty]
        public int SpiceNutCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Pincha Peppernut")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float SpiceNutPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Pincha Peppernut")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float SpiceNutRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Pincha Peppernut")]
        [Limit(1, 100)]
        [JsonProperty]
        public int SpiceNutSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Pincha Peppernut")]
        [JsonProperty]
        public bool SpiceNutCanRotOverride { get; set; }

        #endregion


        #region ColdWheatSeed

        [Option("Enable Custom Sleet Wheat Grain", "", "Sleet Wheat Grain")]
        [JsonProperty]
        public bool ColdWheatSeedOverride { get; set; }

        [Option("Calories Per Unit", "", "Sleet Wheat Grain")]
        [JsonProperty]
        public int ColdWheatSeedCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Sleet Wheat Grain")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float ColdWheatSeedPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Sleet Wheat Grain")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float ColdWheatSeedRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Sleet Wheat Grain")]
        [Limit(1, 100)]
        [JsonProperty]
        public int ColdWheatSeedSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Sleet Wheat Grain")]
        [JsonProperty]
        public bool ColdWheatSeedCanRotOverride { get; set; }

        #endregion


        #region RawEgg

        [Option("Enable Custom Raw Egg", "", "Raw Egg")]
        [JsonProperty]
        public bool RawEggOverride { get; set; }

        [Option("Calories Per Unit", "", "Raw Egg")]
        [JsonProperty]
        public int RawEggCaloriesPerUnitOverride { get; set; }

        [Option("Preserve Temperature", "", "Raw Egg")]
        [Limit(255.15f, 283.15f)]
        [JsonProperty]
        public float RawEggPreserveTemperatureOverride { get; set; }

        [Option("Rot Temperature", "", "Raw Egg")]
        [Limit(277.15f, 308.15f)]
        [JsonProperty]
        public float RawEggRotTemperatureOverride { get; set; }

        [Option("Spoil Time", "Time (in cycles) food is edible.", "Raw Egg")]
        [Limit(1, 100)]
        [JsonProperty]
        public int RawEggSpoilTimeOverride { get; set; }

        [Option("Can Rot", "", "Raw Egg")]
        [JsonProperty]
        public bool RawEggCanRotOverride { get; set; }

        #endregion


        public CustomableFoodConfig()
        {
            #region DefaultConfigFieldRation

            FieldRationCaloriesPerUnitOverride = 800000;
            FieldRationPreserveTemperatureOverride = 255.15f;
            FieldRationRotTemperatureOverride = 277.15f;
            FieldRationSpoilTimeOverride = 32;
            FieldRationCanRotOverride = false;

            #endregion


            #region DefaultConfigMushBar

            MushBarCaloriesPerUnitOverride = 800000;
            MushBarPreserveTemperatureOverride = 255.15f;
            MushBarRotTemperatureOverride = 277.15f;
            MushBarSpoilTimeOverride = 8;
            MushBarCanRotOverride = true;

            #endregion


            #region DefaultConfigBasicPlantFood

            BasicPlantFoodCaloriesPerUnitOverride = 600000;
            BasicPlantFoodPreserveTemperatureOverride = 255.15f;
            BasicPlantFoodRotTemperatureOverride = 277.15f;
            BasicPlantFoodSpoilTimeOverride = 8;
            BasicPlantFoodCanRotOverride = true;

            #endregion


            #region DefaultConfigBasicForagePlant

            BasicForagePlantCaloriesPerUnitOverride = 800000;
            BasicForagePlantPreserveTemperatureOverride = 255.15f;
            BasicForagePlantRotTemperatureOverride = 277.15f;
            BasicForagePlantSpoilTimeOverride = 8;
            BasicForagePlantCanRotOverride = false;

            #endregion


            #region DefaultConfigForestForagePlant

            ForestForagePlantCaloriesPerUnitOverride = 6400000;
            ForestForagePlantPreserveTemperatureOverride = 255.15f;
            ForestForagePlantRotTemperatureOverride = 277.15f;
            ForestForagePlantSpoilTimeOverride = 8;
            ForestForagePlantCanRotOverride = false;

            #endregion


            #region DefaultConfigSwampForagePlant

            SwampForagePlantCaloriesPerUnitOverride = 2400000;
            SwampForagePlantPreserveTemperatureOverride = 255.15f;
            SwampForagePlantRotTemperatureOverride = 277.15f;
            SwampForagePlantSpoilTimeOverride = 8;
            SwampForagePlantCanRotOverride = false;

            #endregion


            #region DefaultConfigMushroom

            MushroomCaloriesPerUnitOverride = 2400000;
            MushroomPreserveTemperatureOverride = 255.15f;
            MushroomRotTemperatureOverride = 277.15f;
            MushroomSpoilTimeOverride = 8;
            MushroomCanRotOverride = true;

            #endregion


            #region DefaultConfigLettuce

            LettuceCaloriesPerUnitOverride = 400000;
            LettucePreserveTemperatureOverride = 255.15f;
            LettuceRotTemperatureOverride = 277.15f;
            LettuceSpoilTimeOverride = 4;
            LettuceCanRotOverride = true;

            #endregion


            #region DefaultConfigMeat

            MeatCaloriesPerUnitOverride = 1600000;
            MeatPreserveTemperatureOverride = 255.15f;
            MeatRotTemperatureOverride = 277.15f;
            MeatSpoilTimeOverride = 8;
            MeatCanRotOverride = true;

            #endregion


            #region DefaultConfigPlantMeat

            PlantMeatCaloriesPerUnitOverride = 1200000;
            PlantMeatPreserveTemperatureOverride = 255.15f;
            PlantMeatRotTemperatureOverride = 277.15f;
            PlantMeatSpoilTimeOverride = 4;
            PlantMeatCanRotOverride = true;

            #endregion


            #region DefaultConfigPrickleFruit

            PrickleFruitCaloriesPerUnitOverride = 1600000;
            PrickleFruitPreserveTemperatureOverride = 255.15f;
            PrickleFruitRotTemperatureOverride = 277.15f;
            PrickleFruitSpoilTimeOverride = 8;
            PrickleFruitCanRotOverride = true;

            #endregion


            #region DefaultConfigSwampFruit

            SwampFruitCaloriesPerUnitOverride = 1840000;
            SwampFruitPreserveTemperatureOverride = 255.15f;
            SwampFruitRotTemperatureOverride = 277.15f;
            SwampFruitSpoilTimeOverride = 4;
            SwampFruitCanRotOverride = true;

            #endregion


            #region DefaultConfigFishMeat

            FishMeatCaloriesPerUnitOverride = 1000000;
            FishMeatPreserveTemperatureOverride = 255.15f;
            FishMeatRotTemperatureOverride = 277.15f;
            FishMeatSpoilTimeOverride = 4;
            FishMeatCanRotOverride = true;

            #endregion


            #region DefaultConfigShellfishMeat

            ShellfishMeatCaloriesPerUnitOverride = 1000000;
            ShellfishMeatPreserveTemperatureOverride = 255.15f;
            ShellfishMeatRotTemperatureOverride = 277.15f;
            ShellfishMeatSpoilTimeOverride = 4;
            ShellfishMeatCanRotOverride = true;

            #endregion


            #region DefaultConfigWormBasicFruit

            WormBasicFruitCaloriesPerUnitOverride = 800000;
            WormBasicFruitPreserveTemperatureOverride = 255.15f;
            WormBasicFruitRotTemperatureOverride = 277.15f;
            WormBasicFruitSpoilTimeOverride = 8;
            WormBasicFruitCanRotOverride = true;

            #endregion


            #region DefaultConfigWormSuperFruit

            WormSuperFruitCaloriesPerUnitOverride = 250000;
            WormSuperFruitPreserveTemperatureOverride = 255.15f;
            WormSuperFruitRotTemperatureOverride = 277.15f;
            WormSuperFruitSpoilTimeOverride = 4;
            WormSuperFruitCanRotOverride = true;

            #endregion


            #region DefaultConfigPickledMeal

            PickledMealCaloriesPerUnitOverride = 1800000;
            PickledMealPreserveTemperatureOverride = 255.15f;
            PickledMealRotTemperatureOverride = 277.15f;
            PickledMealSpoilTimeOverride = 32;
            PickledMealCanRotOverride = true;

            #endregion


            #region DefaultConfigBasicPlantBar

            BasicPlantBarCaloriesPerUnitOverride = 1700000;
            BasicPlantBarPreserveTemperatureOverride = 255.15f;
            BasicPlantBarRotTemperatureOverride = 277.15f;
            BasicPlantBarSpoilTimeOverride = 8;
            BasicPlantBarCanRotOverride = true;

            #endregion


            #region DefaultConfigFriedMushBar

            FriedMushBarCaloriesPerUnitOverride = 1050000;
            FriedMushBarPreserveTemperatureOverride = 255.15f;
            FriedMushBarRotTemperatureOverride = 277.15f;
            FriedMushBarSpoilTimeOverride = 8;
            FriedMushBarCanRotOverride = true;

            #endregion


            #region DefaultConfigGammaMush

            GammaMushCaloriesPerUnitOverride = 1050000;
            GammaMushPreserveTemperatureOverride = 255.15f;
            GammaMushRotTemperatureOverride = 277.15f;
            GammaMushSpoilTimeOverride = 4;
            GammaMushCanRotOverride = true;

            #endregion


            #region DefaultConfigGrilledPrickleFruit

            GrilledPrickleFruitCaloriesPerUnitOverride = 2000000;
            GrilledPrickleFruitPreserveTemperatureOverride = 255.15f;
            GrilledPrickleFruitRotTemperatureOverride = 277.15f;
            GrilledPrickleFruitSpoilTimeOverride = 8;
            GrilledPrickleFruitCanRotOverride = true;

            #endregion


            #region DefaultConfigSwampDelights

            SwampDelightsCaloriesPerUnitOverride = 2240000;
            SwampDelightsPreserveTemperatureOverride = 255.15f;
            SwampDelightsRotTemperatureOverride = 277.15f;
            SwampDelightsSpoilTimeOverride = 8;
            SwampDelightsCanRotOverride = true;

            #endregion


            #region DefaultConfigFriedMushroom

            FriedMushroomCaloriesPerUnitOverride = 2800000;
            FriedMushroomPreserveTemperatureOverride = 255.15f;
            FriedMushroomRotTemperatureOverride = 277.15f;
            FriedMushroomSpoilTimeOverride = 8;
            FriedMushroomCanRotOverride = true;

            #endregion


            #region DefaultConfigColdWheatBread

            ColdWheatBreadCaloriesPerUnitOverride = 1200000;
            ColdWheatBreadPreserveTemperatureOverride = 255.15f;
            ColdWheatBreadRotTemperatureOverride = 277.15f;
            ColdWheatBreadSpoilTimeOverride = 8;
            ColdWheatBreadCanRotOverride = true;

            #endregion


            #region DefaultConfigCookedEgg

            CookedEggCaloriesPerUnitOverride = 2800000;
            CookedEggPreserveTemperatureOverride = 255.15f;
            CookedEggRotTemperatureOverride = 277.15f;
            CookedEggSpoilTimeOverride = 4;
            CookedEggCanRotOverride = true;

            #endregion


            #region DefaultConfigCookedFish

            CookedFishCaloriesPerUnitOverride = 1600000;
            CookedFishPreserveTemperatureOverride = 255.15f;
            CookedFishRotTemperatureOverride = 277.15f;
            CookedFishSpoilTimeOverride = 4;
            CookedFishCanRotOverride = true;

            #endregion


            #region DefaultConfigCookedMeat

            CookedMeatCaloriesPerUnitOverride = 4000000;
            CookedMeatPreserveTemperatureOverride = 255.15f;
            CookedMeatRotTemperatureOverride = 277.15f;
            CookedMeatSpoilTimeOverride = 4;
            CookedMeatCanRotOverride = true;

            #endregion


            #region DefaultConfigWormBasicFood

            WormBasicFoodCaloriesPerUnitOverride = 1200000;
            WormBasicFoodPreserveTemperatureOverride = 255.15f;
            WormBasicFoodRotTemperatureOverride = 277.15f;
            WormBasicFoodSpoilTimeOverride = 8;
            WormBasicFoodCanRotOverride = true;

            #endregion


            #region DefaultConfigWormSuperFood

            WormSuperFoodCaloriesPerUnitOverride = 2400000;
            WormSuperFoodPreserveTemperatureOverride = 255.15f;
            WormSuperFoodRotTemperatureOverride = 277.15f;
            WormSuperFoodSpoilTimeOverride = 32;
            WormSuperFoodCanRotOverride = true;

            #endregion


            #region DefaultConfigFruitCake

            FruitCakeCaloriesPerUnitOverride = 4000000;
            FruitCakePreserveTemperatureOverride = 255.15f;
            FruitCakeRotTemperatureOverride = 277.15f;
            FruitCakeSpoilTimeOverride = 32;
            FruitCakeCanRotOverride = false;

            #endregion


            #region DefaultConfigSalsa

            SalsaCaloriesPerUnitOverride = 4400000;
            SalsaPreserveTemperatureOverride = 255.15f;
            SalsaRotTemperatureOverride = 277.15f;
            SalsaSpoilTimeOverride = 4;
            SalsaCanRotOverride = true;

            #endregion


            #region DefaultConfigSurfAndTurf

            SurfAndTurfCaloriesPerUnitOverride = 6000000;
            SurfAndTurfPreserveTemperatureOverride = 255.15f;
            SurfAndTurfRotTemperatureOverride = 277.15f;
            SurfAndTurfSpoilTimeOverride = 4;
            SurfAndTurfCanRotOverride = true;

            #endregion


            #region DefaultConfigMushroomWrap

            MushroomWrapCaloriesPerUnitOverride = 4800000;
            MushroomWrapPreserveTemperatureOverride = 255.15f;
            MushroomWrapRotTemperatureOverride = 277.15f;
            MushroomWrapSpoilTimeOverride = 4;
            MushroomWrapCanRotOverride = true;

            #endregion


            #region DefaultConfigTofu

            TofuCaloriesPerUnitOverride = 3600000;
            TofuPreserveTemperatureOverride = 255.15f;
            TofuRotTemperatureOverride = 277.15f;
            TofuSpoilTimeOverride = 4;
            TofuCanRotOverride = true;

            #endregion


            #region DefaultConfigSpiceBread

            SpiceBreadCaloriesPerUnitOverride = 4000000;
            SpiceBreadPreserveTemperatureOverride = 255.15f;
            SpiceBreadRotTemperatureOverride = 277.15f;
            SpiceBreadSpoilTimeOverride = 8;
            SpiceBreadCanRotOverride = true;

            #endregion


            #region DefaultConfigSpicyTofu

            SpicyTofuCaloriesPerUnitOverride = 4000000;
            SpicyTofuPreserveTemperatureOverride = 255.15f;
            SpicyTofuRotTemperatureOverride = 277.15f;
            SpicyTofuSpoilTimeOverride = 4;
            SpicyTofuCanRotOverride = true;

            #endregion


            #region DefaultConfigCurry

            CurryCaloriesPerUnitOverride = 5000000;
            CurryPreserveTemperatureOverride = 255.15f;
            CurryRotTemperatureOverride = 277.15f;
            CurrySpoilTimeOverride = 16;
            CurryCanRotOverride = true;

            #endregion


            #region DefaultConfigBerryPie

            BerryPieCaloriesPerUnitOverride = 4200000;
            BerryPiePreserveTemperatureOverride = 255.15f;
            BerryPieRotTemperatureOverride = 277.15f;
            BerryPieSpoilTimeOverride = 4;
            BerryPieCanRotOverride = true;

            #endregion


            #region DefaultConfigBurger

            BurgerCaloriesPerUnitOverride = 6000000;
            BurgerPreserveTemperatureOverride = 255.15f;
            BurgerRotTemperatureOverride = 277.15f;
            BurgerSpoilTimeOverride = 4;
            BurgerCanRotOverride = false;

            #endregion


            #region DefaultConfigBeanPlantSeed

            BeanPlantSeedCaloriesPerUnitOverride = 0;
            BeanPlantSeedPreserveTemperatureOverride = 255.15f;
            BeanPlantSeedRotTemperatureOverride = 277.15f;
            BeanPlantSeedSpoilTimeOverride = 8;
            BeanPlantSeedCanRotOverride = true;

            #endregion


            #region DefaultConfigSpiceNut

            SpiceNutCaloriesPerUnitOverride = 0;
            SpiceNutPreserveTemperatureOverride = 255.15f;
            SpiceNutRotTemperatureOverride = 277.15f;
            SpiceNutSpoilTimeOverride = 4;
            SpiceNutCanRotOverride = true;

            #endregion


            #region DefaultConfigColdWheatSeed

            ColdWheatSeedCaloriesPerUnitOverride = 0;
            ColdWheatSeedPreserveTemperatureOverride = 283.15f;
            ColdWheatSeedRotTemperatureOverride = 308.15f;
            ColdWheatSeedSpoilTimeOverride = 16;
            ColdWheatSeedCanRotOverride = true;

            #endregion


            #region DefaultConfigRawEgg

            RawEggCaloriesPerUnitOverride = 0;
            RawEggPreserveTemperatureOverride = 255.15f;
            RawEggRotTemperatureOverride = 277.15f;
            RawEggSpoilTimeOverride = 8;
            RawEggCanRotOverride = true;

            #endregion
        }
    }
}
