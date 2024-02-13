using ICities;

namespace NathanCitiesSkylinesMod
{
    /// <summary>
    /// Modify the Cities Sklyines demand calculations to always return maximum demand
    /// </summary>
    public class DemandManager : DemandExtensionBase
    {
        /// <summary>
        /// Maximum demand in Cities Skylines is 100. Minimum is zero
        /// </summary>
        const int MAX_DEMAND = 100;

        /// <summary>
        /// Overrides the demand calculation and sets the target and next demands to max (very high)
        /// </summary>
        /// <param name="lastDemand">The dmeand that was set last simulation update</param>
        /// <param name="nextDemand">The demand next simulation update (allows for transition)</param>
        /// <param name="targetDemand">The simulated demand that Cities Skylines will try to reach</param>
        /// <returns>The modified demand calculation method invocation</returns>
        public override int OnUpdateDemand(int lastDemand, int nextDemand, int targetDemand)
        {
            return base.OnUpdateDemand(lastDemand, MAX_DEMAND, MAX_DEMAND);
        }

        /// <summary>
        /// Called by GameObjects that need to see residential demand, always returns max demand
        /// </summary>
        /// <param name="originalDemand">The demand calculated by Cities Sklyines</param>
        /// <returns>The maximum demand value calculated by us</returns>
        public override int OnCalculateResidentialDemand(int originalDemand)
        {
            return MAX_DEMAND;
        }

        /// <summary>
        /// Called by GameObjects that need to see comercial demand, always returns max demand
        /// </summary>
        /// <param name="originalDemand">The demand calculated by Cities Sklyines</param>
        /// <returns>The maximum demand value calculted by us</returns>
        public override int OnCalculateCommercialDemand(int originalDemand)
        {
            return MAX_DEMAND;
        }

        /// <summary>
        /// Called by GameObjects that need to see industrial and office demand, always returns max demand
        /// </summary>
        /// <param name="originalDemand">The demand calculated by Cities Skylines</param>
        /// <returns>The maximum demand value calculated by us</returns>
        public override int OnCalculateWorkplaceDemand(int originalDemand)
        {
            return MAX_DEMAND;
        }
    }
}
