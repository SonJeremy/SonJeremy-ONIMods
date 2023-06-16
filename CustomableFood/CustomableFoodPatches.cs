using KMod;
using TUNING;

using HarmonyLib;
using UnityEngine;

using PeterHan.PLib.Core;
using PeterHan.PLib.Options;
using PeterHan.PLib.PatchManager;

namespace SonJeremy.CustomableFood
{
    public sealed class CustomableFoodPatches : UserMod2
    {
        class MappedFoodTypeWithFoodID
        {
            public string FoodID { get; set; }
            public string FoodType { get; set; }
        }

        public override void OnLoad(Harmony harmony)
        {
            base.OnLoad(harmony);

            PUtil.InitLibrary(false);

            new POptions().RegisterOptions(this, typeof(CustomableFoodConfig));

            new PPatchManager(harmony).RegisterPatchClass(typeof(CustomableFoodPatches));
        }

        [HarmonyPatch(typeof(Db))]
        [HarmonyPatch("Initialize")]
        public static class Db_Initalize_Patch
        {
            public static void Postfix()
            {
                CustomableFoodConfig FoodConfig = CustomableFoodConfig.Instance;

                int SpoilTimeOverride = 4800;
                float StaleTimeOverride = SpoilTimeOverride / 2f;

                #region OverrideConfigFieldRation

                if (FoodConfig.FieldRationOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.FieldRationSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.FIELDRATION.CanRot = FoodConfig.FieldRationCanRotOverride;
                    FOOD.FOOD_TYPES.FIELDRATION.RotTemperature = FoodConfig.FieldRationRotTemperatureOverride;
                    FOOD.FOOD_TYPES.FIELDRATION.CaloriesPerUnit = FoodConfig.FieldRationCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.FIELDRATION.PreserveTemperature = FoodConfig.FieldRationPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigMushBar

                if (FoodConfig.MushBarOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.MushBarSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.MUSHBAR.CanRot = FoodConfig.MushBarCanRotOverride;
                    FOOD.FOOD_TYPES.MUSHBAR.RotTemperature = FoodConfig.MushBarRotTemperatureOverride;
                    FOOD.FOOD_TYPES.MUSHBAR.CaloriesPerUnit = FoodConfig.MushBarCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.MUSHBAR.PreserveTemperature = FoodConfig.MushBarPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigBasicPlantFood

                if (FoodConfig.BasicPlantFoodOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.BasicPlantFoodSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.BASICPLANTFOOD.CanRot = FoodConfig.BasicPlantFoodCanRotOverride;
                    FOOD.FOOD_TYPES.BASICPLANTFOOD.RotTemperature = FoodConfig.BasicPlantFoodRotTemperatureOverride;
                    FOOD.FOOD_TYPES.BASICPLANTFOOD.CaloriesPerUnit = FoodConfig.BasicPlantFoodCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.BASICPLANTFOOD.PreserveTemperature = FoodConfig.BasicPlantFoodPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigBasicForagePlant

                if (FoodConfig.BasicForagePlantOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.BasicForagePlantSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.BASICFORAGEPLANT.CanRot = FoodConfig.BasicForagePlantCanRotOverride;
                    FOOD.FOOD_TYPES.BASICFORAGEPLANT.RotTemperature = FoodConfig.BasicForagePlantRotTemperatureOverride;
                    FOOD.FOOD_TYPES.BASICFORAGEPLANT.CaloriesPerUnit = FoodConfig.BasicForagePlantCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.BASICFORAGEPLANT.PreserveTemperature = FoodConfig.BasicForagePlantPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigForestForagePlant

                if (FoodConfig.ForestForagePlantOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.ForestForagePlantSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.FORESTFORAGEPLANT.CanRot = FoodConfig.ForestForagePlantCanRotOverride;
                    FOOD.FOOD_TYPES.FORESTFORAGEPLANT.RotTemperature = FoodConfig.ForestForagePlantRotTemperatureOverride;
                    FOOD.FOOD_TYPES.FORESTFORAGEPLANT.CaloriesPerUnit = FoodConfig.ForestForagePlantCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.FORESTFORAGEPLANT.PreserveTemperature = FoodConfig.ForestForagePlantPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigSwampForagePlant

                if (FoodConfig.SwampForagePlantOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.SwampForagePlantSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.SWAMPFORAGEPLANT.CanRot = FoodConfig.SwampForagePlantCanRotOverride;
                    FOOD.FOOD_TYPES.SWAMPFORAGEPLANT.RotTemperature = FoodConfig.SwampForagePlantRotTemperatureOverride;
                    FOOD.FOOD_TYPES.SWAMPFORAGEPLANT.CaloriesPerUnit = FoodConfig.SwampForagePlantCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.SWAMPFORAGEPLANT.PreserveTemperature = FoodConfig.SwampForagePlantPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigMushroom

                if (FoodConfig.MushroomOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.MushroomSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.MUSHROOM.CanRot = FoodConfig.MushroomCanRotOverride;
                    FOOD.FOOD_TYPES.MUSHROOM.RotTemperature = FoodConfig.MushroomRotTemperatureOverride;
                    FOOD.FOOD_TYPES.MUSHROOM.CaloriesPerUnit = FoodConfig.MushroomCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.MUSHROOM.PreserveTemperature = FoodConfig.MushroomPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigLettuce

                if (FoodConfig.LettuceOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.LettuceSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.LETTUCE.CanRot = FoodConfig.LettuceCanRotOverride;
                    FOOD.FOOD_TYPES.LETTUCE.RotTemperature = FoodConfig.LettuceRotTemperatureOverride;
                    FOOD.FOOD_TYPES.LETTUCE.CaloriesPerUnit = FoodConfig.LettuceCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.LETTUCE.PreserveTemperature = FoodConfig.LettucePreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigMeat

                if (FoodConfig.MeatOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.MeatSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.MEAT.CanRot = FoodConfig.MeatCanRotOverride;
                    FOOD.FOOD_TYPES.MEAT.RotTemperature = FoodConfig.MeatRotTemperatureOverride;
                    FOOD.FOOD_TYPES.MEAT.CaloriesPerUnit = FoodConfig.MeatCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.MEAT.PreserveTemperature = FoodConfig.MeatPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigPlantMeat

                if (FoodConfig.PlantMeatOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.PlantMeatSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.PLANTMEAT.CanRot = FoodConfig.PlantMeatCanRotOverride;
                    FOOD.FOOD_TYPES.PLANTMEAT.RotTemperature = FoodConfig.PlantMeatRotTemperatureOverride;
                    FOOD.FOOD_TYPES.PLANTMEAT.CaloriesPerUnit = FoodConfig.PlantMeatCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.PLANTMEAT.PreserveTemperature = FoodConfig.PlantMeatPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigPrickleFruit

                if (FoodConfig.PrickleFruitOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.PrickleFruitSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.PRICKLEFRUIT.CanRot = FoodConfig.PrickleFruitCanRotOverride;
                    FOOD.FOOD_TYPES.PRICKLEFRUIT.RotTemperature = FoodConfig.PrickleFruitRotTemperatureOverride;
                    FOOD.FOOD_TYPES.PRICKLEFRUIT.CaloriesPerUnit = FoodConfig.PrickleFruitCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.PRICKLEFRUIT.PreserveTemperature = FoodConfig.PrickleFruitPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigSwampFruit

                if (FoodConfig.SwampFruitOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.SwampFruitSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.SWAMPFRUIT.CanRot = FoodConfig.SwampFruitCanRotOverride;
                    FOOD.FOOD_TYPES.SWAMPFRUIT.RotTemperature = FoodConfig.SwampFruitRotTemperatureOverride;
                    FOOD.FOOD_TYPES.SWAMPFRUIT.CaloriesPerUnit = FoodConfig.SwampFruitCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.SWAMPFRUIT.PreserveTemperature = FoodConfig.SwampFruitPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigFishMeat

                if (FoodConfig.FishMeatOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.FishMeatSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.FISH_MEAT.CanRot = FoodConfig.FishMeatCanRotOverride;
                    FOOD.FOOD_TYPES.FISH_MEAT.RotTemperature = FoodConfig.FishMeatRotTemperatureOverride;
                    FOOD.FOOD_TYPES.FISH_MEAT.CaloriesPerUnit = FoodConfig.FishMeatCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.FISH_MEAT.PreserveTemperature = FoodConfig.FishMeatPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigShellfishMeat

                if (FoodConfig.ShellfishMeatOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.ShellfishMeatSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.SHELLFISH_MEAT.CanRot = FoodConfig.ShellfishMeatCanRotOverride;
                    FOOD.FOOD_TYPES.SHELLFISH_MEAT.RotTemperature = FoodConfig.ShellfishMeatRotTemperatureOverride;
                    FOOD.FOOD_TYPES.SHELLFISH_MEAT.CaloriesPerUnit = FoodConfig.ShellfishMeatCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.SHELLFISH_MEAT.PreserveTemperature = FoodConfig.ShellfishMeatPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigWormBasicFruit

                if (FoodConfig.WormBasicFruitOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.WormBasicFruitSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.WORMBASICFRUIT.CanRot = FoodConfig.WormBasicFruitCanRotOverride;
                    FOOD.FOOD_TYPES.WORMBASICFRUIT.RotTemperature = FoodConfig.WormBasicFruitRotTemperatureOverride;
                    FOOD.FOOD_TYPES.WORMBASICFRUIT.CaloriesPerUnit = FoodConfig.WormBasicFruitCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.WORMBASICFRUIT.PreserveTemperature = FoodConfig.WormBasicFruitPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigWormSuperFruit

                if (FoodConfig.WormSuperFruitOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.WormSuperFruitSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.WORMSUPERFRUIT.CanRot = FoodConfig.WormSuperFruitCanRotOverride;
                    FOOD.FOOD_TYPES.WORMSUPERFRUIT.RotTemperature = FoodConfig.WormSuperFruitRotTemperatureOverride;
                    FOOD.FOOD_TYPES.WORMSUPERFRUIT.CaloriesPerUnit = FoodConfig.WormSuperFruitCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.WORMSUPERFRUIT.PreserveTemperature = FoodConfig.WormSuperFruitPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigPickledMeal

                if (FoodConfig.PickledMealOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.PickledMealSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.PICKLEDMEAL.CanRot = FoodConfig.PickledMealCanRotOverride;
                    FOOD.FOOD_TYPES.PICKLEDMEAL.RotTemperature = FoodConfig.PickledMealRotTemperatureOverride;
                    FOOD.FOOD_TYPES.PICKLEDMEAL.CaloriesPerUnit = FoodConfig.PickledMealCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.PICKLEDMEAL.PreserveTemperature = FoodConfig.PickledMealPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigBasicPlantBar

                if (FoodConfig.BasicPlantBarOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.BasicPlantBarSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.BASICPLANTBAR.CanRot = FoodConfig.BasicPlantBarCanRotOverride;
                    FOOD.FOOD_TYPES.BASICPLANTBAR.RotTemperature = FoodConfig.BasicPlantBarRotTemperatureOverride;
                    FOOD.FOOD_TYPES.BASICPLANTBAR.CaloriesPerUnit = FoodConfig.BasicPlantBarCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.BASICPLANTBAR.PreserveTemperature = FoodConfig.BasicPlantBarPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigFriedMushBar

                if (FoodConfig.FriedMushBarOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.FriedMushBarSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.FRIEDMUSHBAR.CanRot = FoodConfig.FriedMushBarCanRotOverride;
                    FOOD.FOOD_TYPES.FRIEDMUSHBAR.RotTemperature = FoodConfig.FriedMushBarRotTemperatureOverride;
                    FOOD.FOOD_TYPES.FRIEDMUSHBAR.CaloriesPerUnit = FoodConfig.FriedMushBarCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.FRIEDMUSHBAR.PreserveTemperature = FoodConfig.FriedMushBarPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigGammaMush

                if (FoodConfig.GammaMushOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.GammaMushSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.GAMMAMUSH.CanRot = FoodConfig.GammaMushCanRotOverride;
                    FOOD.FOOD_TYPES.GAMMAMUSH.RotTemperature = FoodConfig.GammaMushRotTemperatureOverride;
                    FOOD.FOOD_TYPES.GAMMAMUSH.CaloriesPerUnit = FoodConfig.GammaMushCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.GAMMAMUSH.PreserveTemperature = FoodConfig.GammaMushPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigGrilledPrickleFruit

                if (FoodConfig.GrilledPrickleFruitOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.GrilledPrickleFruitSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.GRILLED_PRICKLEFRUIT.CanRot = FoodConfig.GrilledPrickleFruitCanRotOverride;
                    FOOD.FOOD_TYPES.GRILLED_PRICKLEFRUIT.RotTemperature = FoodConfig.GrilledPrickleFruitRotTemperatureOverride;
                    FOOD.FOOD_TYPES.GRILLED_PRICKLEFRUIT.CaloriesPerUnit = FoodConfig.GrilledPrickleFruitCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.GRILLED_PRICKLEFRUIT.PreserveTemperature = FoodConfig.GrilledPrickleFruitPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigSwampDelights

                if (FoodConfig.SwampDelightsOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.SwampDelightsSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.SWAMP_DELIGHTS.CanRot = FoodConfig.SwampDelightsCanRotOverride;
                    FOOD.FOOD_TYPES.SWAMP_DELIGHTS.RotTemperature = FoodConfig.SwampDelightsRotTemperatureOverride;
                    FOOD.FOOD_TYPES.SWAMP_DELIGHTS.CaloriesPerUnit = FoodConfig.SwampDelightsCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.SWAMP_DELIGHTS.PreserveTemperature = FoodConfig.SwampDelightsPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigFriedMushroom

                if (FoodConfig.FriedMushroomOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.FriedMushroomSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.FRIED_MUSHROOM.CanRot = FoodConfig.FriedMushroomCanRotOverride;
                    FOOD.FOOD_TYPES.FRIED_MUSHROOM.RotTemperature = FoodConfig.FriedMushroomRotTemperatureOverride;
                    FOOD.FOOD_TYPES.FRIED_MUSHROOM.CaloriesPerUnit = FoodConfig.FriedMushroomCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.FRIED_MUSHROOM.PreserveTemperature = FoodConfig.FriedMushroomPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigColdWheatBread

                if (FoodConfig.ColdWheatBreadOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.ColdWheatBreadSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.COLD_WHEAT_BREAD.CanRot = FoodConfig.ColdWheatBreadCanRotOverride;
                    FOOD.FOOD_TYPES.COLD_WHEAT_BREAD.RotTemperature = FoodConfig.ColdWheatBreadRotTemperatureOverride;
                    FOOD.FOOD_TYPES.COLD_WHEAT_BREAD.CaloriesPerUnit = FoodConfig.ColdWheatBreadCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.COLD_WHEAT_BREAD.PreserveTemperature = FoodConfig.ColdWheatBreadPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigCookedEgg

                if (FoodConfig.CookedEggOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.CookedEggSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.COOKED_EGG.CanRot = FoodConfig.CookedEggCanRotOverride;
                    FOOD.FOOD_TYPES.COOKED_EGG.RotTemperature = FoodConfig.CookedEggRotTemperatureOverride;
                    FOOD.FOOD_TYPES.COOKED_EGG.CaloriesPerUnit = FoodConfig.CookedEggCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.COOKED_EGG.PreserveTemperature = FoodConfig.CookedEggPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigCookedFish

                if (FoodConfig.CookedFishOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.CookedFishSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.COOKED_FISH.CanRot = FoodConfig.CookedFishCanRotOverride;
                    FOOD.FOOD_TYPES.COOKED_FISH.RotTemperature = FoodConfig.CookedFishRotTemperatureOverride;
                    FOOD.FOOD_TYPES.COOKED_FISH.CaloriesPerUnit = FoodConfig.CookedFishCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.COOKED_FISH.PreserveTemperature = FoodConfig.CookedFishPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigCookedMeat

                if (FoodConfig.CookedMeatOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.CookedMeatSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.COOKED_MEAT.CanRot = FoodConfig.CookedMeatCanRotOverride;
                    FOOD.FOOD_TYPES.COOKED_MEAT.RotTemperature = FoodConfig.CookedMeatRotTemperatureOverride;
                    FOOD.FOOD_TYPES.COOKED_MEAT.CaloriesPerUnit = FoodConfig.CookedMeatCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.COOKED_MEAT.PreserveTemperature = FoodConfig.CookedMeatPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigWormBasicFood

                if (FoodConfig.WormBasicFoodOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.WormBasicFoodSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.WORMBASICFOOD.CanRot = FoodConfig.WormBasicFoodCanRotOverride;
                    FOOD.FOOD_TYPES.WORMBASICFOOD.RotTemperature = FoodConfig.WormBasicFoodRotTemperatureOverride;
                    FOOD.FOOD_TYPES.WORMBASICFOOD.CaloriesPerUnit = FoodConfig.WormBasicFoodCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.WORMBASICFOOD.PreserveTemperature = FoodConfig.WormBasicFoodPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigWormSuperFood

                if (FoodConfig.WormSuperFoodOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.WormSuperFoodSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.WORMSUPERFOOD.CanRot = FoodConfig.WormSuperFoodCanRotOverride;
                    FOOD.FOOD_TYPES.WORMSUPERFOOD.RotTemperature = FoodConfig.WormSuperFoodRotTemperatureOverride;
                    FOOD.FOOD_TYPES.WORMSUPERFOOD.CaloriesPerUnit = FoodConfig.WormSuperFoodCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.WORMSUPERFOOD.PreserveTemperature = FoodConfig.WormSuperFoodPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigFruitCake

                if (FoodConfig.FruitCakeOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.FruitCakeSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.FRUITCAKE.CanRot = FoodConfig.FruitCakeCanRotOverride;
                    FOOD.FOOD_TYPES.FRUITCAKE.RotTemperature = FoodConfig.FruitCakeRotTemperatureOverride;
                    FOOD.FOOD_TYPES.FRUITCAKE.CaloriesPerUnit = FoodConfig.FruitCakeCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.FRUITCAKE.PreserveTemperature = FoodConfig.FruitCakePreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigSalsa

                if (FoodConfig.SalsaOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.SalsaSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.SALSA.CanRot = FoodConfig.SalsaCanRotOverride;
                    FOOD.FOOD_TYPES.SALSA.RotTemperature = FoodConfig.SalsaRotTemperatureOverride;
                    FOOD.FOOD_TYPES.SALSA.CaloriesPerUnit = FoodConfig.SalsaCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.SALSA.PreserveTemperature = FoodConfig.SalsaPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigSurfAndTurf

                if (FoodConfig.SurfAndTurfOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.SurfAndTurfSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.SURF_AND_TURF.CanRot = FoodConfig.SurfAndTurfCanRotOverride;
                    FOOD.FOOD_TYPES.SURF_AND_TURF.RotTemperature = FoodConfig.SurfAndTurfRotTemperatureOverride;
                    FOOD.FOOD_TYPES.SURF_AND_TURF.CaloriesPerUnit = FoodConfig.SurfAndTurfCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.SURF_AND_TURF.PreserveTemperature = FoodConfig.SurfAndTurfPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigMushroomWrap

                if (FoodConfig.MushroomWrapOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.MushroomWrapSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.MUSHROOM_WRAP.CanRot = FoodConfig.MushroomWrapCanRotOverride;
                    FOOD.FOOD_TYPES.MUSHROOM_WRAP.RotTemperature = FoodConfig.MushroomWrapRotTemperatureOverride;
                    FOOD.FOOD_TYPES.MUSHROOM_WRAP.CaloriesPerUnit = FoodConfig.MushroomWrapCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.MUSHROOM_WRAP.PreserveTemperature = FoodConfig.MushroomWrapPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigTofu

                if (FoodConfig.TofuOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.TofuSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.TOFU.CanRot = FoodConfig.TofuCanRotOverride;
                    FOOD.FOOD_TYPES.TOFU.RotTemperature = FoodConfig.TofuRotTemperatureOverride;
                    FOOD.FOOD_TYPES.TOFU.CaloriesPerUnit = FoodConfig.TofuCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.TOFU.PreserveTemperature = FoodConfig.TofuPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigSpiceBread

                if (FoodConfig.SpiceBreadOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.SpiceBreadSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.SPICEBREAD.CanRot = FoodConfig.SpiceBreadCanRotOverride;
                    FOOD.FOOD_TYPES.SPICEBREAD.RotTemperature = FoodConfig.SpiceBreadRotTemperatureOverride;
                    FOOD.FOOD_TYPES.SPICEBREAD.CaloriesPerUnit = FoodConfig.SpiceBreadCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.SPICEBREAD.PreserveTemperature = FoodConfig.SpiceBreadPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigSpicyTofu

                if (FoodConfig.SpicyTofuOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.SpicyTofuSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.SPICY_TOFU.CanRot = FoodConfig.SpicyTofuCanRotOverride;
                    FOOD.FOOD_TYPES.SPICY_TOFU.RotTemperature = FoodConfig.SpicyTofuRotTemperatureOverride;
                    FOOD.FOOD_TYPES.SPICY_TOFU.CaloriesPerUnit = FoodConfig.SpicyTofuCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.SPICY_TOFU.PreserveTemperature = FoodConfig.SpicyTofuPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigCurry

                if (FoodConfig.CurryOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.CurrySpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.CURRY.CanRot = FoodConfig.CurryCanRotOverride;
                    FOOD.FOOD_TYPES.CURRY.RotTemperature = FoodConfig.CurryRotTemperatureOverride;
                    FOOD.FOOD_TYPES.CURRY.CaloriesPerUnit = FoodConfig.CurryCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.CURRY.PreserveTemperature = FoodConfig.CurryPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigBerryPie

                if (FoodConfig.BerryPieOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.BerryPieSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.BERRY_PIE.CanRot = FoodConfig.BerryPieCanRotOverride;
                    FOOD.FOOD_TYPES.BERRY_PIE.RotTemperature = FoodConfig.BerryPieRotTemperatureOverride;
                    FOOD.FOOD_TYPES.BERRY_PIE.CaloriesPerUnit = FoodConfig.BerryPieCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.BERRY_PIE.PreserveTemperature = FoodConfig.BerryPiePreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigBurger

                if (FoodConfig.BurgerOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.BurgerSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.CanRot = FoodConfig.BurgerCanRotOverride;
                    FOOD.FOOD_TYPES.BURGER.RotTemperature = FoodConfig.BurgerRotTemperatureOverride;
                    FOOD.FOOD_TYPES.BURGER.CaloriesPerUnit = FoodConfig.BurgerCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.BURGER.PreserveTemperature = FoodConfig.BurgerPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigBeanPlantSeed

                if (FoodConfig.BeanPlantSeedOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.BeanPlantSeedSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.BEAN.CanRot = FoodConfig.BeanPlantSeedCanRotOverride;
                    FOOD.FOOD_TYPES.BEAN.RotTemperature = FoodConfig.BeanPlantSeedRotTemperatureOverride;
                    FOOD.FOOD_TYPES.BEAN.CaloriesPerUnit = FoodConfig.BeanPlantSeedCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.BEAN.PreserveTemperature = FoodConfig.BeanPlantSeedPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigSpiceNut

                if (FoodConfig.SpiceNutOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.SpiceNutSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.SPICENUT.CanRot = FoodConfig.SpiceNutCanRotOverride;
                    FOOD.FOOD_TYPES.SPICENUT.RotTemperature = FoodConfig.SpiceNutRotTemperatureOverride;
                    FOOD.FOOD_TYPES.SPICENUT.CaloriesPerUnit = FoodConfig.SpiceNutCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.SPICENUT.PreserveTemperature = FoodConfig.SpiceNutPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigColdWheatSeed

                if (FoodConfig.ColdWheatSeedOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.ColdWheatSeedSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.COLD_WHEAT_SEED.CanRot = FoodConfig.ColdWheatSeedCanRotOverride;
                    FOOD.FOOD_TYPES.COLD_WHEAT_SEED.RotTemperature = FoodConfig.ColdWheatSeedRotTemperatureOverride;
                    FOOD.FOOD_TYPES.COLD_WHEAT_SEED.CaloriesPerUnit = FoodConfig.ColdWheatSeedCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.COLD_WHEAT_SEED.PreserveTemperature = FoodConfig.ColdWheatSeedPreserveTemperatureOverride;
                }

                #endregion


                #region OverrideConfigRawEgg

                if (FoodConfig.RawEggOverride == true)
                {
                    /** Config Is Based On Cycle. One Cycle = 600s **/
                    SpoilTimeOverride = FoodConfig.RawEggSpoilTimeOverride * 600;
                    StaleTimeOverride = SpoilTimeOverride / 2f;

                    FOOD.FOOD_TYPES.BURGER.SpoilTime = SpoilTimeOverride;
                    FOOD.FOOD_TYPES.BURGER.StaleTime = StaleTimeOverride;
                    FOOD.FOOD_TYPES.RAWEGG.CanRot = FoodConfig.RawEggCanRotOverride;
                    FOOD.FOOD_TYPES.RAWEGG.RotTemperature = FoodConfig.RawEggRotTemperatureOverride;
                    FOOD.FOOD_TYPES.RAWEGG.CaloriesPerUnit = FoodConfig.RawEggCaloriesPerUnitOverride;
                    FOOD.FOOD_TYPES.RAWEGG.PreserveTemperature = FoodConfig.RawEggPreserveTemperatureOverride;
                }

                #endregion



            }
        }

        [HarmonyPatch(typeof(TravelTubeEntranceConfig), "ConfigureBuildingTemplate")]
        public static class TravelTubeEntranceConfig_TravelTubeEntranceConfig_Patch
        {
            public static void Postfix(GameObject go, Tag prefab_tag)
            {
                if (go == null)
                {
                    PUtil.LogDebug("[CustomableFood - TravelTubeEntrance] Object _GameObject Is Null.!");
                    return;
                }

                TravelTubeEntrance _TravelTubeEntrance = go.GetComponent<TravelTubeEntrance>();
                if (_TravelTubeEntrance != null)
                {
                    _TravelTubeEntrance.joulesPerLaunch = CustomableFoodConfig.Instance.TransitTubeJoulesPerLaunchOverride;
                    _TravelTubeEntrance.jouleCapacity = CustomableFoodConfig.Instance.TransitTubeJouleCapacityOverride;
                }
                else PUtil.LogDebug("[CustomableFood - TravelTubeEntrance] Object TravelTubeEntrance Is Null.!");
            }
        }
    }
}
