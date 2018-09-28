using System;
namespace PI.Utilities.Interfaces
{
    /// <summary>
    /// Properties required to publish an item
    /// </summary>
    public interface IPublishingProperties
    {
        /// <summary>
        /// Gets/set the new publishing step
        /// This should be set to the step you are publishing to or removing from
        /// A common step would be Live, it is recommended that you keep this fixed unless you have multiple step publishing flow
        /// </summary>
        string NewStep { get; set; }

        /// <summary>
        /// Gets/set the publishing notes
        /// </summary>
        string Notes { get; set; }

        /// <summary>
        /// Gets/set the name of the user who signed off the publish state change
        /// </summary>
        string SignedOffBy { get; set; }
    }
}
