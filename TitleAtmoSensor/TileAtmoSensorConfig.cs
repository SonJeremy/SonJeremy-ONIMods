using UnityEngine;

using PeterHan.PLib.Core;
using PeterHan.PLib.Buildings;

namespace SonJeremy.TileAtmoSensor
{
    public sealed class TileAtmoSensorConfig : LogicPressureSensorGasConfig
    {
        internal const string ID = "TileAtmoSensor";
        internal static PBuilding TileAtmoSensor;
        internal static PBuilding CreateBuilding()
        {
            return TileAtmoSensor = new PBuilding(ID, TileAtmoSensorStrings.BUILDINGS.PREFABS.TILEATMOSENSOR.NAME)
            {
                AddAfter = LogicPressureSensorGasConfig.ID,
                Animation = "thermo_tile_kanim",
                AudioCategory = "Metal",
                AudioSize = "small",
                Category = "Automation",
                ConstructionTime = 30.0f,
                Decor = TUNING.BUILDINGS.DECOR.BONUS.TIER4,
                Description = null,
                EffectText = null,
                Entombs = false,
                Floods = false,
                Height = 1,
                HP = 100,
                Ingredients = {
                    new BuildIngredient(TUNING.MATERIALS.REFINED_METALS, tier: 2)
                },
                IsSolidTile = true,
                LogicIO = {
                    LogicPorts.Port.OutputPort(LogicSwitch.PORT_ID, new CellOffset(0, 0),
                    STRINGS.BUILDINGS.PREFABS.LOGICPRESSURESENSORGAS.LOGIC_PORT,
                    STRINGS.BUILDINGS.PREFABS.LOGICPRESSURESENSORGAS.LOGIC_PORT_ACTIVE,
                    STRINGS.BUILDINGS.PREFABS.LOGICPRESSURESENSORGAS.LOGIC_PORT_INACTIVE, true)
                },
                ObjectLayer = PGameUtils.GetObjectLayer(nameof(ObjectLayer.Backwall),
                    ObjectLayer.Backwall),
                Placement = BuildLocationRule.Tile,
                SceneLayer = Grid.SceneLayer.TileMain,
                SubCategory = "sensors",
                Tech = "HVAC",
                ViewMode = OverlayModes.Logic.ID,
                Width = 1,
                AlwaysOperational = true,
            };
        }

        public override BuildingDef CreateBuildingDef()
        {
            LocString.CreateLocStringKeys(typeof(TileAtmoSensorStrings.BUILDINGS));
            GeneratedBuildings.RegisterWithOverlay(OverlayModes.Logic.HighlightItemIDs, ID);

            return TileAtmoSensor.CreateDef();
        }

        public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
        {
            base.ConfigureBuildingTemplate(go, prefab_tag);

            TileAtmoSensor?.ConfigureBuildingTemplate(go);

            //BuildingConfigManager.Instance.IgnoreDefaultKComponent(typeof(RequiresFoundation), prefab_tag);

            var Occupier = go.AddOrGet<SimCellOccupier>();

            Occupier.notifyOnMelt = true;
            Occupier.movementSpeedMultiplier = TUNING.DUPLICANTSTATS.MOVEMENT.NEUTRAL;
            
            go.AddOrGet<LogicPressureSensor>();
            go.AddOrGet<BuildingHP>().destroyOnDamaged = true;
        }

        public override void DoPostConfigureComplete(GameObject go)
        {
            TileAtmoSensor?.DoPostConfigureComplete(go);
            TileAtmoSensor?.CreateLogicPorts(go);

            var AtmoSensor = go.AddOrGet<LogicPressureSensor>();
           
            AtmoSensor.rangeMax = 50;
            AtmoSensor.manuallyControlled = false;

            go.GetComponent<KPrefabID>().AddTag(GameTags.FloorTiles, false);
        }

        public override void DoPostConfigurePreview(BuildingDef def, GameObject go)
        {
            TileAtmoSensor?.CreateLogicPorts(go);
        }

        public override void DoPostConfigureUnderConstruction(GameObject go)
        {
            TileAtmoSensor?.CreateLogicPorts(go);
        }
    }
}
