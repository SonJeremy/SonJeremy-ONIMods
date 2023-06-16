namespace SonJeremy.TileAtmoSensor
{
    public static class TileAtmoSensorStrings
    {
        public static class BUILDINGS
        {
            public static class PREFABS
            {
                public static class TILEATMOSENSOR
                {
                    public static LocString NAME = STRINGS.UI.FormatAsLink("Thermo Sensor Tile", TileAtmoSensorConfig.ID);
                    public static LocString DESC = "Liquid drops have been sent an official eviction notice with the invention of a Thermo Sensor that can transfer heat effectively with its surrounding solid tiles.";
                    public static LocString EFFECT = string.Concat("Sends a ",
                        STRINGS.UI.FormatAsAutomationState("Green Signal", STRINGS.UI.AutomationState.Active),
                        " or a ",
                        STRINGS.UI.FormatAsAutomationState("Red Signal", STRINGS.UI.AutomationState.Standby),
                        " when ambient ",
                        STRINGS.UI.FormatAsLink("Temperature", "HEAT"),
                        " enters the chosen range.");
                }
            }
        }
    }
}