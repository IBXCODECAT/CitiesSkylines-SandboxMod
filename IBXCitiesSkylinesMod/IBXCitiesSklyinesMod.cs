using ICities;
using UnityEngine;

namespace NathanCitiesSkylinesMod
{
    public class IBXCitiesSklyinesMod : IUserMod
    {
        public string Name { get { return "IBX Mod"; } }
        public string Description { get { return "This is an epic mod made by Nathan Schmitt (IBXCODECAT)"; } }

        public void OnSettingsUI(UIHelperBase helper)
        {
            helper.AddGroup("Turn Simulation Features On or Off");
            helper.AddCheckbox("Disable Electricity Consumption", false, (value) => BuildingMod.ToggleElectricityConsumption(!value));
            helper.AddCheckbox("Disable Water Consumption", false, (value) => BuildingMod.ToggleWaterConsumption(!value));
            helper.AddCheckbox("Disable Garabage Acumulation", false, (value) => BuildingMod.ToggleGarabageAcumulation(!value));

            helper.AddSpace(250);

            helper.AddGroup("Source Code");
            helper.AddButton("View Code on GitHub", () => Application.OpenURL("https://github.com/IBXCODECAT/CitiesSkylines-SandboxMod"));
        }
    }
}
