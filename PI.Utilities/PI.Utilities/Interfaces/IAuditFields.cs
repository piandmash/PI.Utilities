using System;

namespace PI.Utilities.Interfaces
{
    public interface IAuditFields
    {
        /// <summary>
        /// Gets/sets the object creator
        /// </summary>
        string CreatedBy { get; set; }

        /// <summary>
        /// Gets/sets the created date
        /// </summary>
        DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets/sets the last updater of the object
        /// </summary>
        string UpdatedBy { get; set; }

        /// <summary>
        /// Gets/sets the last updated date
        /// </summary>
        DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets/sets if the items version, should be incremented as required
        /// </summary>
        int Version { get; set; }

        /// <summary>
        /// Gets/sets if the item is deleted
        /// </summary>
        bool Deleted { get; set; }

        /// <summary>
        /// Gets/sets if the item is archived
        /// </summary>
        bool Archived { get; set; }
    }
}
