using System;

namespace PI.Utilities.Interfaces
{
    public interface IAuditFieldsWithId
    {
        /// <summary>
        /// Gets/sets the object id
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// Gets/sets the object creator
        /// </summary>
        string CreatedBy { get; set; }

        /// <summary>
        /// Gets/sets the created date
        /// </summary>
        /// <markdown>
        DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets/sets the last updater of the object
        /// </summary>
        string UpdatedBy { get; set; }

        /// <summary>
        /// Gets/sets the last updated date
        /// </summary>
        DateTime UpdatedDate { get; set; }
    }
}
