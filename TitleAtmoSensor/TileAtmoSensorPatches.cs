using HarmonyLib;
using PeterHan.PLib.AVC;
using PeterHan.PLib.Buildings;
using PeterHan.PLib.Core;
using PeterHan.PLib.Database;
using SonJeremy.TileAtmoSensor;

namespace PeterHan.TileAtmoSensor
{
    public sealed class TileAtmoSensorPatches : KMod.UserMod2
    {
        public override void OnLoad(Harmony harmony)
        {
            PUtil.InitLibrary();

            new PLocalization().Register();
            new PBuildingManager().Register(TileAtmoSensorConfig.CreateBuilding());

            new PVersionCheck().Register(this, new SteamVersionChecker());
        }
    }
}