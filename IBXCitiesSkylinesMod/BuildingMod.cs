using ICities;

namespace NathanCitiesSkylinesMod
{
    public class BuildingMod : BuildingAI
    {
        private static bool ConsumeElectricity = true;
        private static bool ConsumeWater = true;
        private static bool AcumulateGarabage = true;

        internal static void ToggleElectricityConsumption(bool value)
        {
            ConsumeElectricity = value;

            DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Warning, $"Consume Electricity {ConsumeElectricity}");
        }

        internal static void ToggleWaterConsumption(bool value)
        {
            ConsumeWater = value;
            DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Warning, $"Consume Water {ConsumeWater}");
        }

        internal static void ToggleGarabageAcumulation(bool value)
        {
            AcumulateGarabage = value;
            DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Warning, $"Acumulate Garabage {AcumulateGarabage}");
        }

        public override int GetElectricityConsumption()
        {
            if(ConsumeElectricity)
            {
                return base.GetElectricityConsumption();
            }

            return 0;
        }

        public override int GetWaterConsumption()
        {
            if(ConsumeWater)
            {
                return base.GetWaterConsumption();
            }

            return 0;
        }

        public override int GetGarbageRate(ushort buildingID, ref Building data)
        {
            if(AcumulateGarabage)
            {
                return base.GetGarbageRate(buildingID, ref data);
            }

            return 0;
        }

        public override int GetGarbageAmount(ushort buildingID, ref Building data)
        {
            if(AcumulateGarabage)
            {
                return base.GetGarbageAmount(buildingID, ref data);
            }

            return 0;
        }
    }
}
