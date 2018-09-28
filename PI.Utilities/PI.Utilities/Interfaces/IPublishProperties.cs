using System;
namespace PI.Utilities.Interfaces
{
    /// <summary>
    /// Properties for an item that allows publication
    /// </summary>
    public interface IPublishProperties
    {
        /// <summary>
        /// Gets/sets if the items published version, should be incremented as required
        /// </summary>
        int PublishedVersion { get; set; }

        /// <summary>
        /// The date the item was published
        /// It is advised to use UTC dates
        /// </summary>
        DateTime PublishedDate { get; set; }

        /// <summary>
        /// Gets/set the publish notes
        /// </summary>
        string PublishedNotes { get; set; }

        /// <summary>
        /// Gets/set the name of the user who signed off the publish state change
        /// </summary>
        string SignedOffBy { get; set; }
    }
}
